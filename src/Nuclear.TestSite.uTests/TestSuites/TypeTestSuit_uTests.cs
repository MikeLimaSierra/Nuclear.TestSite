using System;
using System.Runtime.CompilerServices;
using Ntt;
using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    class TypeTestSuit_uTests {

        #region Implements

        [TestMethod]
        void ImplementsGeneric() {

            DDTImplementsGeneric<Zero, Zero>((1, false, "Type 'Ntt.Zero' is not an interface."));
            DDTImplementsGeneric<Two, ITwo>((2, true, "Type 'Ntt.Two' implements interface 'Ntt.ITwo'."));
            DDTImplementsGeneric<Two, IZero>((3, false, "Type 'Ntt.Two' doesn't implement interface 'Ntt.IZero'."));
            DDTImplementsGeneric<Zero, ITwo>((4, true, "Type 'Ntt.Zero' implements interface 'Ntt.ITwo'."));
            DDTImplementsGeneric<IZero, IZero>((5, false, "Type 'Ntt.IZero' doesn't implement interface 'Ntt.IZero'."));
            DDTImplementsGeneric<IZero, ITwo>((6, true, "Type 'Ntt.IZero' implements interface 'Ntt.ITwo'."));
        }

        void DDTImplementsGeneric<TType, TInterface>((Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Type.Implements<{typeof(TType).Format()}, {typeof(TInterface).Format()}>()",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Type.Implements<TType, TInterface>(_file, _method),
                expected, "Test.If.Type.Implements", _file, _method);

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'type' is null.")]
        [TestParameters(null, typeof(Zero), 2, false, "Parameter 'type' is null.")]
        [TestParameters(typeof(Zero), null, 3, false, "Parameter 'interface' is null.")]
        [TestParameters(typeof(Zero), typeof(Zero), 4, false, "Type 'Ntt.Zero' is not an interface.")]
        [TestParameters(typeof(Two), typeof(ITwo), 5, true, "Type 'Ntt.Two' implements interface 'Ntt.ITwo'.")]
        [TestParameters(typeof(Two), typeof(IZero), 6, false, "Type 'Ntt.Two' doesn't implement interface 'Ntt.IZero'.")]
        [TestParameters(typeof(Zero), typeof(ITwo), 7, true, "Type 'Ntt.Zero' implements interface 'Ntt.ITwo'.")]
        [TestParameters(typeof(IZero), typeof(IZero), 8, false, "Type 'Ntt.IZero' doesn't implement interface 'Ntt.IZero'.")]
        [TestParameters(typeof(IZero), typeof(ITwo), 9, true, "Type 'Ntt.IZero' implements interface 'Ntt.ITwo'.")]
        void Implements(Type input1, Type input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Type.Implements(input1, input2),
                (count, result, message), "Test.If.Type.Implements");

        }

        [TestMethod]
        void NotImplementsGeneric() {

            DDTNotImplementsGeneric<Zero, Zero>((1, false, "Type 'Ntt.Zero' is not an interface."));
            DDTNotImplementsGeneric<Two, ITwo>((2, false, "Type 'Ntt.Two' implements interface 'Ntt.ITwo'."));
            DDTNotImplementsGeneric<Two, IZero>((3, true, "Type 'Ntt.Two' doesn't implement interface 'Ntt.IZero'."));
            DDTNotImplementsGeneric<Zero, ITwo>((4, false, "Type 'Ntt.Zero' implements interface 'Ntt.ITwo'."));
            DDTNotImplementsGeneric<IZero, IZero>((5, true, "Type 'Ntt.IZero' doesn't implement interface 'Ntt.IZero'."));
            DDTNotImplementsGeneric<IZero, ITwo>((6, false, "Type 'Ntt.IZero' implements interface 'Ntt.ITwo'."));

        }

        void DDTNotImplementsGeneric<TType, TInterface>((Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Type.Implements<{typeof(TType).Format()}, {typeof(TInterface).Format()}>()",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Type.Implements<TType, TInterface>(_file, _method),
                expected, "Test.IfNot.Type.Implements", _file, _method);

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'type' is null.")]
        [TestParameters(null, typeof(Zero), 2, false, "Parameter 'type' is null.")]
        [TestParameters(typeof(Zero), null, 3, false, "Parameter 'interface' is null.")]
        [TestParameters(typeof(Zero), typeof(Zero), 4, false, "Type 'Ntt.Zero' is not an interface.")]
        [TestParameters(typeof(Two), typeof(ITwo), 5, false, "Type 'Ntt.Two' implements interface 'Ntt.ITwo'.")]
        [TestParameters(typeof(Two), typeof(IZero), 6, true, "Type 'Ntt.Two' doesn't implement interface 'Ntt.IZero'.")]
        [TestParameters(typeof(Zero), typeof(ITwo), 7, false, "Type 'Ntt.Zero' implements interface 'Ntt.ITwo'.")]
        [TestParameters(typeof(IZero), typeof(IZero), 8, true, "Type 'Ntt.IZero' doesn't implement interface 'Ntt.IZero'.")]
        [TestParameters(typeof(IZero), typeof(ITwo), 9, false, "Type 'Ntt.IZero' implements interface 'Ntt.ITwo'.")]
        void NotImplements(Type input1, Type input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Type.Implements(input1, input2),
                (count, result, message), "Test.IfNot.Type.Implements");

        }

        #endregion

        #region IsSubClass

        [TestMethod]
        void IsSubClassGeneric() {

            DDTIsSubClassGeneric<Zero, Zero>((1, false, "Type 'Ntt.Zero' is no subclass of 'Ntt.Zero'."));
            DDTIsSubClassGeneric<DerivesFromZero, Zero>((2, true, "Type 'Ntt.DerivesFromZero' is subclass of 'Ntt.Zero'."));
            DDTIsSubClassGeneric<DerivesFromZero, ITwo>((3, false, "Type 'Ntt.ITwo' is not a class."));
            DDTIsSubClassGeneric<ITwo, Zero>((4, false, "Type 'Ntt.ITwo' is not a class."));

        }

        void DDTIsSubClassGeneric<TType, TBase>((Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Type.IsSubClass<{typeof(TType).Format()}, {typeof(TBase).Format()}>()",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Type.IsSubClass<TType, TBase>(_file, _method),
                expected, "Test.If.Type.IsSubClass", _file, _method);

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'type' is null.")]
        [TestParameters(null, typeof(Zero), 2, false, "Parameter 'type' is null.")]
        [TestParameters(typeof(Zero), null, 3, false, "Parameter 'baseType' is null.")]
        [TestParameters(typeof(Zero), typeof(Zero), 4, false, "Type 'Ntt.Zero' is no subclass of 'Ntt.Zero'.")]
        [TestParameters(typeof(DerivesFromZero), typeof(Zero), 5, true, "Type 'Ntt.DerivesFromZero' is subclass of 'Ntt.Zero'.")]
        [TestParameters(typeof(DerivesFromZero), typeof(ITwo), 6, false, "Type 'Ntt.ITwo' is not a class.")]
        [TestParameters(typeof(ITwo), typeof(Zero), 7, false, "Type 'Ntt.ITwo' is not a class.")]
        void IsSubClass(Type input1, Type input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Type.IsSubClass(input1, input2),
                (count, result, message), "Test.If.Type.IsSubClass");

        }

        [TestMethod]
        void NotIsSubClassGeneric() {

            DDTNotIsSubClassGeneric<Zero, Zero>((1, true, "Type 'Ntt.Zero' is no subclass of 'Ntt.Zero'."));
            DDTNotIsSubClassGeneric<DerivesFromZero, Zero>((2, false, "Type 'Ntt.DerivesFromZero' is subclass of 'Ntt.Zero'."));
            DDTNotIsSubClassGeneric<DerivesFromZero, ITwo>((3, false, "Type 'Ntt.ITwo' is not a class."));
            DDTNotIsSubClassGeneric<ITwo, Zero>((4, false, "Type 'Ntt.ITwo' is not a class."));

        }

        void DDTNotIsSubClassGeneric<TType, TBase>((Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Type.IsSubClass<{typeof(TType).Format()}, {typeof(TBase).Format()}>()",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Type.IsSubClass<TType, TBase>(_file, _method),
                expected, "Test.IfNot.Type.IsSubClass", _file, _method);

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'type' is null.")]
        [TestParameters(null, typeof(Zero), 2, false, "Parameter 'type' is null.")]
        [TestParameters(typeof(Zero), null, 3, false, "Parameter 'baseType' is null.")]
        [TestParameters(typeof(Zero), typeof(Zero), 4, true, "Type 'Ntt.Zero' is no subclass of 'Ntt.Zero'.")]
        [TestParameters(typeof(DerivesFromZero), typeof(Zero), 5, false, "Type 'Ntt.DerivesFromZero' is subclass of 'Ntt.Zero'.")]
        [TestParameters(typeof(DerivesFromZero), typeof(ITwo), 6, false, "Type 'Ntt.ITwo' is not a class.")]
        [TestParameters(typeof(ITwo), typeof(Zero), 7, false, "Type 'Ntt.ITwo' is not a class.")]
        void NotIsSubClass(Type input1, Type input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Type.IsSubClass(input1, input2),
                (count, result, message), "Test.IfNot.Type.IsSubClass");

        }

        #endregion

    }
}
