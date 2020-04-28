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

        private ConcurrentDictionary<ITestResultKey, ITestMethodResult> _results { get; } =
            new ConcurrentDictionary<ITestResultKey, ITestMethodResult>(DynamicEqualityComparer.FromIEquatable<ITestResultKey>());

        private static readonly IEqualityComparer<ITestResultKey> _comparer = DynamicEqualityComparer.FromIEquatable<ITestResultKey>();

        #endregion

        #region properties

        public static DummyTestResults Instance { get; } = new DummyTestResults();

        public ITestScenario Scenario { get; private set; }

        #endregion

        #region methods

        public void Initialize(ITestScenario scenario) => Scenario = scenario;

        public void Clear() => _results.Clear();

        public void PrepareResults(MethodInfo _method)
            => _results.GetOrAdd(new TestResultKey(Scenario, _method.DeclaringType.Name, _method.Name),
                new TestMethodResult());

        public void LogException(MethodInfo _method, Exception ex) => AddResult(false, ex.FormatType(), ex.Message, _method.DeclaringType.Name, _method.Name);

        #endregion

        #region ITestResultSource

        public IEnumerable<ITestResultKey> GetKeys() => _results.Keys;

        public IEnumerable<ITestResultKey> GetKeys(ITestResultKey match) => GetKeys().Where(key => key.Matches(match));

        public IEnumerable<ITestResultKey> GetKeys(ITestResultKey match, TestResultKeyPrecisions precision) {
            List<ITestResultKey> keys = new List<ITestResultKey>();

            foreach(ITestResultKey key in GetKeys(match)) {
                ITestResultKey clippedKey = key.Clip(precision);

                if(!keys.Contains(clippedKey, _comparer)) {
                    keys.Add(clippedKey);
                }
            }

            return keys;
        }

        public ITestMethodResult GetResult(ITestResultKey key) => _results.GetOrAdd(key, new TestMethodResult());

        public IEnumerable<ITestMethodResult> GetResults() => _results.Values;

        public IEnumerable<ITestMethodResult> GetResults(ITestResultKey match) => _results.Where(value => value.Key.Matches(match)).Select(value => value.Value);

        public IEnumerable<KeyValuePair<ITestResultKey, ITestMethodResult>> GetKeyedResults() => _results;

        #endregion

        #region ITestResultSink

        public void AddResult(Boolean result, String testInstruction, String message, String _file, String _method)
            => _results.GetOrAdd(new TestResultKey(Scenario, _file, _method),
                new TestMethodResult()).TestEntries.Add(new TestEntry(result ? EntryTypes.ResultOk : EntryTypes.ResultFail, testInstruction, message));

        public void AddNote(String message, String _file, String _method)
            => _results.GetOrAdd(new TestResultKey(Scenario, _file, _method),
                new TestMethodResult()).TestEntries.Add(new TestEntry(EntryTypes.Note, null, message));

        #endregion

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
