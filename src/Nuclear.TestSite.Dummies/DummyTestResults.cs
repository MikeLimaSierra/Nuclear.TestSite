using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Nuclear.Extensions;
using Nuclear.Test;
using Nuclear.Test.Results;

namespace Nuclear.TestSite {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DummyTestResults : ITestResultSink, ITestResultSource {

        #region fields

        private ConcurrentDictionary<IResultKey, ITestMethodResult> _results =
            new ConcurrentDictionary<IResultKey, ITestMethodResult>(DynamicEqualityComparer.FromIEquatable<IResultKey>());

        #endregion

        #region properties

        public static DummyTestResults Instance { get; } = new DummyTestResults();

        public ITestScenario Scenario { get; private set; }

        #endregion

        #region methods

        public void Add(IResultKey key, ITestMethodResult results) => _results.AddOrUpdate(key, results, (_, __) => results);

        public void Add(IEnumerable<KeyValuePair<IResultKey, ITestMethodResult>> results) {
            foreach(KeyValuePair<IResultKey, ITestMethodResult> result in results) {
                Add(result.Key, result.Value);
            }
        }


        public void Initialize(ITestScenario scenario) => Scenario = scenario;

        public void Clear() => _results.Clear();

        public void PrepareResults(MethodInfo _method) {
            Factory.Instance.Create(out IResultKey key, Scenario, _method.DeclaringType.Name, _method.Name);
            Factory.Instance.Create(out ITestMethodResult result);

            _results.GetOrAdd(key, result);
        }

        #endregion

        #region ITestResultSource

        public IEnumerable<IResultKey> GetKeys() => _results.Keys;

        public IEnumerable<IResultKey> GetKeys(IResultKey match) => GetKeys().Where(key => key.Equals(match));

        public ITestMethodResult GetResult(IResultKey key) {
            Factory.Instance.Create(out ITestMethodResult result);

            return _results.GetOrAdd(key, result);
        }

        public IEnumerable<ITestMethodResult> GetResults() => _results.Values;

        public IEnumerable<ITestMethodResult> GetResults(IResultKey match) => _results.Where(kvp => kvp.Key.Equals(match)).Select(value => value.Value);

        public IEnumerable<KeyValuePair<IResultKey, ITestMethodResult>> GetKeyedResults() => _results;

        #endregion

        #region ITestResultSink

        public void AddResult(Boolean result, String testInstruction, String message, String _file, String _method)
            => AddEntry(TestEntry.FromResult(result, testInstruction, message), _file, _method);

        public void AddNote(String message, String _file, String _method)
            => AddEntry(TestEntry.FromNote(message), _file, _method);

        #endregion

        #region private methods

        private void AddEntry(ITestEntry entry, String _file, String _method) {
            Factory.Instance.Create(out IResultKey key, Scenario, _file, _method);
            Factory.Instance.Create(out ITestMethodResult result);

            _results.GetOrAdd(key, result).TestEntries.Add(entry);
        }

        #endregion

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
