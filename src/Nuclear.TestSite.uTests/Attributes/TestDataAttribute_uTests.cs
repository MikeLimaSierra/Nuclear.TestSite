using System;

using Ntt;

namespace Nuclear.TestSite {
    class TestDataAttribute_uTests {

        [TestMethod]
        [TestParameters(null, null, null)]
        [TestParameters(typeof(Dummy), typeof(Dummy), null)]
        void CtorType(Type input, Type provider, String name) {

            TestDataAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestDataAttribute(input), out Exception ex);

            Test.If.Value.IsEqual(attr.Provider, provider);
            Test.If.Value.IsEqual(attr.ProviderMember, name);

        }

        [TestMethod]
        [TestParameters(null, null, null)]
        [TestParameters("MemberName", null, "MemberName")]
        void CtorProvider(String input, Type provider, String name) {

            TestDataAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestDataAttribute(input), out Exception ex);

            Test.If.Value.IsEqual(attr.Provider, provider);
            Test.If.Value.IsEqual(attr.ProviderMember, name);

        }

        [TestMethod]
        [TestParameters(null, null, null, null)]
        [TestParameters(typeof(Dummy), null, typeof(Dummy), null)]
        [TestParameters(typeof(Dummy), "", typeof(Dummy), "")]
        [TestParameters(typeof(Dummy), " ", typeof(Dummy), " ")]
        [TestParameters(typeof(Dummy), "GetData", typeof(Dummy), "GetData")]
        void CtorTypeAndMember(Type input1, String input2, Type provider, String name) {

            TestDataAttribute attr = null;

            Test.IfNot.Action.ThrowsException(() => attr = new TestDataAttribute(input1, input2), out Exception ex);

            Test.If.Value.IsEqual(attr.Provider, provider);
            Test.If.Value.IsEqual(attr.ProviderMember, name);

        }

        [TestMethod]
        [TestParameters(typeof(TestDataAttribute_uTests), null, "[TestData('Nuclear.TestSite.TestDataAttribute_uTests', null)]")]
        [TestParameters(typeof(TestDataAttribute_uTests), "SomeMethod", "[TestData('Nuclear.TestSite.TestDataAttribute_uTests', 'SomeMethod')]")]
        [TestParameters(null, "SomeMethod", "[TestData(null, 'SomeMethod')]")]
        [TestParameters(null, null, "[TestData(null, null)]")]
        void ToString(Type provider, String providerName, String expected) {

            String result = default;
            TestDataAttribute attr = new TestDataAttribute(provider, providerName);

            Test.IfNot.Action.ThrowsException(() => result = attr.ToString(), out Exception ex);

            Test.If.Value.IsEqual(result, expected);

        }

    }
}
