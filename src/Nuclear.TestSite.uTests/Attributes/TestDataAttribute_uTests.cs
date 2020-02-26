﻿using System;
using System.Runtime.CompilerServices;
using Ntt;
using Nuclear.Extensions;

namespace Nuclear.TestSite {
    class TestDataAttribute_uTests {

        [TestMethod]
        void Ctor() {

            DDTCtor(new Object[] { }, new Object[] { });
            DDTCtor(new Object[] { }, new Object[] { });
            DDTCtor(new Object[] { "1", 2, 0x3 }, new Object[] { "1", 2, 0x3 });

            DDTCtor((Type) null, (null, null));
            DDTCtor(typeof(Dummy), (typeof(Dummy), null));

            DDTCtor((null, null), (null, null));
            DDTCtor((typeof(Dummy), ""), (typeof(Dummy), ""));
            DDTCtor((typeof(Dummy), " "), (typeof(Dummy), " "));
            DDTCtor((typeof(Dummy), "GetData"), (typeof(Dummy), "GetData"));

        }

        void DDTCtor(Object[] input, Object[] expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            TestDataAttribute attr = null;

            Test.Note($"new TestDataAttribute({input.Format()}) => {expected.Format()}", _file, _method);

            Test.IfNot.Action.ThrowsException(() => attr = new TestDataAttribute(input), out Exception ex, _file, _method);

            Test.If.Value.IsEqual(attr.DataKind, TestDataAttribute.TestDataKind.ParameterArray, _file, _method);
            Test.If.Enumerable.MatchesExactly(attr.Parameters, expected, _file, _method);
            Test.If.Object.IsNull(attr.Provider, _file, _method);
            Test.If.Object.IsNull(attr.ProviderName, _file, _method);

        }

        void DDTCtor(Type input, (Type provider, String name) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            TestDataAttribute attr = null;

            Test.Note($"new TestDataAttribute({input.Format()}) => ({expected.provider.Format()}, {expected.name.Format()})", _file, _method);

            Test.IfNot.Action.ThrowsException(() => attr = new TestDataAttribute(input), out Exception ex, _file, _method);

            Test.If.Value.IsEqual(attr.DataKind, TestDataAttribute.TestDataKind.ProviderType, _file, _method);
            Test.If.Object.IsNull(attr.Parameters, _file, _method);
            Test.If.Value.IsEqual(attr.Provider, expected.provider, _file, _method);
            Test.If.Value.IsEqual(attr.ProviderName, expected.name, _file, _method);

        }

        void DDTCtor((Type provider, String name) input, (Type provider, String name) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            TestDataAttribute attr = null;

            Test.Note($"new TestDataAttribute({input.provider.Format()}, {input.name.Format()}) => ({expected.provider.Format()}, {expected.name.Format()})", _file, _method);

            Test.IfNot.Action.ThrowsException(() => attr = new TestDataAttribute(input.provider, input.name), out Exception ex, _file, _method);

            Test.If.Value.IsEqual(attr.DataKind, TestDataAttribute.TestDataKind.ProviderType, _file, _method);
            Test.If.Object.IsNull(attr.Parameters, _file, _method);
            Test.If.Value.IsEqual(attr.Provider, expected.provider, _file, _method);
            Test.If.Value.IsEqual(attr.ProviderName, expected.name, _file, _method);

        }

    }
}