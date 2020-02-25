using System;
using System.Runtime.CompilerServices;
using Nuclear.Extensions;

namespace Nuclear.TestSite {
    class TestClassAttribute_uTests {

        [TestMethod]
        void Ctor() {

            DDTCtor((TestMode.Parallel, null, false));

            DDTCtor((TestMode) 1000, (TestMode.Parallel, null, false));
            DDTCtor(TestMode.Parallel, (TestMode.Parallel, null, false));
            DDTCtor(TestMode.Sequential, (TestMode.Sequential, null, false));

            DDTCtor(null, (TestMode.Parallel, null, false));
            DDTCtor("", (TestMode.Parallel, "", false));
            DDTCtor(" ", (TestMode.Parallel, " ", false));
            DDTCtor("reason", (TestMode.Parallel, "reason", true));

            DDTCtor(((TestMode) 1000, null), (TestMode.Parallel, null, false));
            DDTCtor((TestMode.Parallel, ""), (TestMode.Parallel, "", false));
            DDTCtor((TestMode.Sequential, " "), (TestMode.Sequential, " ", false));
            DDTCtor((TestMode.Sequential, "reason"), (TestMode.Sequential, "reason", true));

        }

        void DDTCtor((TestMode mode, String reason, Boolean ignored) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            TestClassAttribute attr = null;

            Test.Note($"new TestClassAttribute() => ({expected.mode.Format()}, {expected.reason.Format()}, {expected.ignored.Format()})", _file, _method);

            Test.IfNot.Action.ThrowsException(() => attr = new TestClassAttribute(), out Exception ex, _file, _method);

            Test.If.Value.IsEqual(attr.TestMode, expected.mode, _file, _method);
            Test.If.Value.IsEqual(attr.IgnoreReason, expected.reason, _file, _method);
            Test.If.Value.IsEqual(attr.IsIgnored, expected.ignored, _file, _method);

        }

        void DDTCtor(TestMode input, (TestMode mode, String reason, Boolean ignored) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            TestClassAttribute attr = null;

            Test.Note($"new TestClassAttribute({input.Format()}) => ({expected.mode.Format()}, {expected.reason.Format()}, {expected.ignored.Format()})", _file, _method);

            Test.IfNot.Action.ThrowsException(() => attr = new TestClassAttribute(input), out Exception ex, _file, _method);

            Test.If.Value.IsEqual(attr.TestMode, expected.mode, _file, _method);
            Test.If.Value.IsEqual(attr.IgnoreReason, expected.reason, _file, _method);
            Test.If.Value.IsEqual(attr.IsIgnored, expected.ignored, _file, _method);

        }

        void DDTCtor(String input, (TestMode mode, String reason, Boolean ignored) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            TestClassAttribute attr = null;

            Test.Note($"new TestClassAttribute({input.Format()}) => ({expected.mode.Format()}, {expected.reason.Format()}, {expected.ignored.Format()})", _file, _method);

            Test.IfNot.Action.ThrowsException(() => attr = new TestClassAttribute(input), out Exception ex, _file, _method);

            Test.If.Value.IsEqual(attr.TestMode, expected.mode, _file, _method);
            Test.If.Value.IsEqual(attr.IgnoreReason, expected.reason, _file, _method);
            Test.If.Value.IsEqual(attr.IsIgnored, expected.ignored, _file, _method);

        }

        void DDTCtor((TestMode mode, String reason) input, (TestMode mode, String reason, Boolean ignored) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            TestClassAttribute attr = null;

            Test.Note($"new TestClassAttribute({input.mode.Format()}, {input.reason.Format()}) => ({expected.mode.Format()}, {expected.reason.Format()}, {expected.ignored.Format()})", _file, _method);

            Test.IfNot.Action.ThrowsException(() => attr = new TestClassAttribute(input.mode, input.reason), out Exception ex, _file, _method);

            Test.If.Value.IsEqual(attr.TestMode, expected.mode, _file, _method);
            Test.If.Value.IsEqual(attr.IgnoreReason, expected.reason, _file, _method);
            Test.If.Value.IsEqual(attr.IsIgnored, expected.ignored, _file, _method);

        }

    }
}
