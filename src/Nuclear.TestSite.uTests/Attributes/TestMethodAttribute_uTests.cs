﻿using System;

namespace Nuclear.TestSite {
    class TestMethodAttribute_uTests {

        [TestMethod]
        void Ctor() {

            TestMethodAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestMethodAttribute(), out Exception ex);
            Test.IfNot.Object.IsNull(attr);
            Test.If.Value.IsEqual(attr.TestMode, TestMode.Parallel);

            Test.IfNot.Action.ThrowsException(() => attr = new TestMethodAttribute(TestMode.Parallel), out ex);
            Test.IfNot.Object.IsNull(attr);
            Test.If.Value.IsEqual(attr.TestMode, TestMode.Parallel);

            Test.IfNot.Action.ThrowsException(() => attr = new TestMethodAttribute(TestMode.Sequential), out ex);
            Test.IfNot.Object.IsNull(attr);
            Test.If.Value.IsEqual(attr.TestMode, TestMode.Sequential);

        }

    }
}
