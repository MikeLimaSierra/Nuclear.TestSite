using System;

namespace Nuclear.TestSite {
    class TestClassAttribute_uTests {

        [TestMethod]
        [TestParameters(TestMode.Parallel, null, false)]
        void Ctor(TestMode mode, String reason, Boolean ignored) {

            TestClassAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestClassAttribute(), out Exception ex);

            Test.If.Value.IsEqual(attr.TestMode, mode);
            Test.If.Value.IsEqual(attr.IgnoreReason, reason);
            Test.If.Value.IsEqual(attr.IsIgnored, ignored);

        }

        [TestMethod]
        [TestParameters((TestMode) 1000, TestMode.Parallel, null, false)]
        [TestParameters(TestMode.Parallel, TestMode.Parallel, null, false)]
        [TestParameters(TestMode.Sequential, TestMode.Sequential, null, false)]
        void CtorMode(TestMode input, TestMode mode, String reason, Boolean ignored) {

            TestClassAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestClassAttribute(input), out Exception ex);

            Test.If.Value.IsEqual(attr.TestMode, mode);
            Test.If.Value.IsEqual(attr.IgnoreReason, reason);
            Test.If.Value.IsEqual(attr.IsIgnored, ignored);

        }

        [TestMethod]
        [TestParameters(null, TestMode.Parallel, null, false)]
        [TestParameters("", TestMode.Parallel, "", false)]
        [TestParameters(" ", TestMode.Parallel, " ", false)]
        [TestParameters("reason", TestMode.Parallel, "reason", true)]
        void CtorIgnore(String input, TestMode mode, String reason, Boolean ignored) {

            TestClassAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestClassAttribute(input), out Exception ex);

            Test.If.Value.IsEqual(attr.TestMode, mode);
            Test.If.Value.IsEqual(attr.IgnoreReason, reason);
            Test.If.Value.IsEqual(attr.IsIgnored, ignored);

        }

        [TestMethod]
        [TestParameters((TestMode) 1000, null, TestMode.Parallel, null, false)]
        [TestParameters(TestMode.Parallel, "", TestMode.Parallel, "", false)]
        [TestParameters(TestMode.Sequential, " ", TestMode.Sequential, " ", false)]
        [TestParameters(TestMode.Sequential, "reason", TestMode.Sequential, "reason", true)]
        void CtorModeAndIgnore(TestMode input1, String input2, TestMode mode, String reason, Boolean ignored) {

            TestClassAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestClassAttribute(input1, input2), out Exception ex);

            Test.If.Value.IsEqual(attr.TestMode, mode);
            Test.If.Value.IsEqual(attr.IgnoreReason, reason);
            Test.If.Value.IsEqual(attr.IsIgnored, ignored);

        }

    }

}
