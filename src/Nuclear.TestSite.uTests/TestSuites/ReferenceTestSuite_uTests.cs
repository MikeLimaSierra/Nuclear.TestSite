using System;
using System.Collections.Generic;

namespace Nuclear.TestSite.TestSuites {
    class ReferenceTestSuite_uTests {

        #region IsEqual

        [TestMethod]
        [TestData(nameof(IsEqualData))]
        void IsEqual(Object input1, Object input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Reference.IsEqual(input1, input2),
                expected, "Test.If.Reference.IsEqual");

        }

        IEnumerable<Object[]> IsEqualData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, true, "References equal.") },
                new Object[] { null, new Object(), (2, false, "References don't equal.") },
                new Object[] { new Object(), null, (3, false, "References don't equal.") },
                new Object[] { new Object(), new Object(), (4, false, "References don't equal.") },
                new Object[] { DummyTestResults.Instance, DummyTestResults.Instance, (5, true, "References equal.") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualData))]
        void NotIsEqual(Object input1, Object input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Reference.IsEqual(input1, input2),
                expected, "Test.IfNot.Reference.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "References equal.") },
                new Object[] { null, new Object(), (2, true, "References don't equal.") },
                new Object[] { new Object(), null, (3, true, "References don't equal.") },
                new Object[] { new Object(), new Object(), (4, true, "References don't equal.") },
                new Object[] { DummyTestResults.Instance, DummyTestResults.Instance, (5, false, "References equal.") },
            };
        }

        #endregion

    }
}
