using System;

using Nuclear.Test.Results;

namespace Nuclear.TestSite {
    class Test_uTests {

        [TestMethod]
        [TestParameters(null, 0)]
        [TestParameters("", 0)]
        [TestParameters(" ", 0)]
        void TestNoteThrows(String input, Int32 results) {

            Test.If.Action.ThrowsException(() => DummyTest.Note(input), out ArgumentException argEx);
            Test.If.Value.IsEqual(Statics.GetResults(DummyTestResults.Instance).CountResults, results);

        }

        [TestMethod]
        void TestNote() {

            Test.IfNot.Action.ThrowsException(() => DummyTest.Note("This is a note"), out Exception ex);
            Test.If.Value.IsEqual(Statics.GetResults(DummyTestResults.Instance).CountResults, 0);
            Test.If.Value.IsEqual(Statics.GetLastResult(DummyTestResults.Instance).EntryType, EntryTypes.Note);
            Test.If.Value.IsEqual(Statics.GetLastResult(DummyTestResults.Instance).Message, "This is a note");

        }

    }
}
