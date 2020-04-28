using System;
using System.IO;
using System.Runtime.CompilerServices;

using Nuclear.TestSite.TestSuites;

namespace Nuclear.TestSite {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static class DummyTest {

        #region properties

        public static TestSuiteCollection If { get; private set; } = new TestSuiteCollection(DummyTestResults.Instance);

        public static TestSuiteCollection IfNot { get; private set; } = new TestSuiteCollection(DummyTestResults.Instance, invert: true);

        #endregion

        #region ctors

        static DummyTest() {
            DummyTestResults.Instance.Initialize(Statics._scenario);
        }

        #endregion

        #region methods

        public static void Note(String note, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => DummyTestResults.Instance.AddNote(note, Path.GetFileNameWithoutExtension(_file), _method);

        #endregion

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
