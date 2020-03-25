using System;
using System.Collections.Generic;

namespace Nuclear.TestSite {
    class TestParametersAttribute_uTests {

        [TestMethod]
        [TestData(nameof(CtorData))]
        void Ctor(Object[] input, Object[] expected) {

            TestParametersAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestParametersAttribute(input), out Exception ex);

            Test.If.Enumerable.MatchesExactly(attr.Parameters, expected);

        }

        IEnumerable<Object[]> CtorData() {
            return new List<Object[]>() {
                new Object[] { new Object[] { }, new Object[] { } },
                new Object[] { new Object[] { 1 }, new Object[] { 1 } },
                new Object[] { new Object[] { "1", 2, 0x3 }, new Object[] { "1", 2, 0x3 } },
                new Object[] { new Object[] { 1, 2, TestMode.Parallel }, new Object[] { 1, 2, TestMode.Parallel } },
                new Object[] { new Object[] { 1, null, TestMode.Parallel }, new Object[] { 1, null, TestMode.Parallel } },
            };
        }

        [TestMethod]
        [TestData(nameof(ToStringData))]
        void ToString(Object[] input, String expected) {

            String result = default;
            TestParametersAttribute attr = new TestParametersAttribute(input);

            Test.IfNot.Action.ThrowsException(() => result = attr.ToString(), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

        IEnumerable<Object[]> ToStringData() {
            return new List<Object[]>() {
                new Object[] { new Object[] { 1 }, "[TestParameters(['1'])]" },
                new Object[] { new Object[] { 1, 2, TestMode.Parallel }, "[TestParameters(['1', '2', 'Parallel'])]" },
                new Object[] { new Object[] { 1, null, TestMode.Parallel }, "[TestParameters(['1', null, 'Parallel'])]" },
            };
        }

    }
}
