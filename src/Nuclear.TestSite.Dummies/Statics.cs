using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

using Nuclear.Assemblies;
using Nuclear.Assemblies.Runtimes;
using Nuclear.Exceptions;
using Nuclear.Test;
using Nuclear.Test.Results;

namespace Nuclear.TestSite {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static class Statics {

        #region fields

        internal static ITestScenario _scenario = null;

        #endregion

        #region ctors

        static Statics() {
            Assembly _assembly = typeof(Statics).Assembly;
            AssemblyName _assemblyName = _assembly.GetName();

            AssemblyHelper.TryGetRuntime(_assembly, out RuntimeInfo testAssemblyInfo);
            Assembly executionAssembly = Assembly.GetEntryAssembly();
            AssemblyHelper.TryGetRuntime(executionAssembly, out RuntimeInfo executionAssemblyInfo);

            _scenario = new TestScenario(_assemblyName.Name, testAssemblyInfo, _assemblyName.ProcessorArchitecture, executionAssemblyInfo, executionAssembly.GetName().ProcessorArchitecture);
        }

        #endregion

        #region methods

        public static ITestResultKey GetKey([CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {
            Throw.If.Object.IsNull(_scenario, nameof(_scenario));
            return new TestResultKey(_scenario, Path.GetFileNameWithoutExtension(_file), _method);
        }

        public static ITestMethodResult GetResults(ITestResultSource results, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => results.GetResult(GetKey(_file, _method));

        public static ITestEntry GetResult(ITestResultSource results, Int32 index, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => results.GetResult(GetKey(_file, _method)).TestEntries[index];

        public static ITestEntry GetLastResult(ITestResultSource results, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => results.GetResult(GetKey(_file, _method)).TestEntries.Last();

        public static void DDTResultState(Action action, (Int32 count, Boolean result, String message) expected, String instruction,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.IfNot.Action.ThrowsException(action, out Exception _, null, _file, _method);

            ITestMethodResult results = GetResults(DummyTestResults.Instance, _file, _method);
            ITestEntry lastResult = GetLastResult(DummyTestResults.Instance, _file, _method);

            Test.If.Value.IsEqual(results.TestEntries.Count, expected.count, null, _file, _method);
            Test.If.Value.IsEqual(lastResult.EntryType, expected.result ? EntryTypes.ResultOk : EntryTypes.ResultFail, null, _file, _method);
            Test.If.String.StartsWith(lastResult.Message, expected.message, null, _file, _method);
            Test.If.Value.IsEqual(lastResult.Instruction, instruction, null, _file, _method);

        }

        #endregion

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
