using System;
using System.Collections.Generic;

using Ntt;

namespace Nuclear.TestSite.TestSuites {
    class TypeTestSuit_uTests {

        #region ImplementsGeneric

        [TestMethod]
        [TestData(nameof(ImplementsGenericData))]
        void ImplementsGeneric<TType, TInterface>((Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Type.Implements<TType, TInterface>(),
                expected, "Test.If.Type.Implements");

        }

        IEnumerable<Object[]> ImplementsGenericData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), typeof(Zero), (1, false, "Type 'Ntt.Zero' is not an interface.") },
                new Object[] { typeof(Two), typeof(ITwo), (2, true, "Type 'Ntt.Two' implements interface 'Ntt.ITwo'.") },
                new Object[] { typeof(Two), typeof(IZero), (3, false, "Type 'Ntt.Two' doesn't implement interface 'Ntt.IZero'.") },
                new Object[] { typeof(Zero), typeof(ITwo), (4, true, "Type 'Ntt.Zero' implements interface 'Ntt.ITwo'.") },
                new Object[] { typeof(IZero), typeof(IZero), (5, false, "Type 'Ntt.IZero' doesn't implement interface 'Ntt.IZero'.") },
                new Object[] { typeof(IZero), typeof(ITwo), (6, true, "Type 'Ntt.IZero' implements interface 'Ntt.ITwo'.") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotImplementsGenericData))]
        void NotImplementsGeneric<TType, TInterface>((Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Type.Implements<TType, TInterface>(),
                expected, "Test.IfNot.Type.Implements");

        }

        IEnumerable<Object[]> NotImplementsGenericData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), typeof(Zero), (1, false, "Type 'Ntt.Zero' is not an interface.") },
                new Object[] { typeof(Two), typeof(ITwo), (2, false, "Type 'Ntt.Two' implements interface 'Ntt.ITwo'.") },
                new Object[] { typeof(Two), typeof(IZero), (3, true, "Type 'Ntt.Two' doesn't implement interface 'Ntt.IZero'.") },
                new Object[] { typeof(Zero), typeof(ITwo), (4, false, "Type 'Ntt.Zero' implements interface 'Ntt.ITwo'.") },
                new Object[] { typeof(IZero), typeof(IZero), (5, true, "Type 'Ntt.IZero' doesn't implement interface 'Ntt.IZero'.") },
                new Object[] { typeof(IZero), typeof(ITwo), (6, false, "Type 'Ntt.IZero' implements interface 'Ntt.ITwo'.") },
            };
        }

        #endregion

        #region ImplementsGenericWithMessage

        [TestMethod]
        [TestData(nameof(ImplementsGenericWithMessageData))]
        void ImplementsGenericWithMessage<TType, TInterface>(String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Type.Implements<TType, TInterface>(customMessage),
                expected, "Test.If.Type.Implements");

        }

        IEnumerable<Object[]> ImplementsGenericWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), typeof(Zero), "message", (1, false, "Type 'Ntt.Zero' is not an interface.") },
                new Object[] { typeof(Two), typeof(ITwo), "message", (2, true, "Type 'Ntt.Two' implements interface 'Ntt.ITwo'.") },
                new Object[] { typeof(Two), typeof(IZero), "message", (3, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotImplementsGenericWithMessageData))]
        void NotImplementsGenericWithMessage<TType, TInterface>(String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Type.Implements<TType, TInterface>(customMessage),
                expected, "Test.IfNot.Type.Implements");

        }

        IEnumerable<Object[]> NotImplementsGenericWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), typeof(Zero), "message", (1, false, "Type 'Ntt.Zero' is not an interface.") },
                new Object[] { typeof(Two), typeof(ITwo), "message", (2, false, "message") },
                new Object[] { typeof(Two), typeof(IZero), "message", (3, true, "Type 'Ntt.Two' doesn't implement interface 'Ntt.IZero'.") },
            };
        }

        #endregion

        #region Implements

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

        #region ImplementsWithMessage

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'type' is null.")]
        [TestParameters(null, typeof(Zero), "message", 2, false, "Parameter 'type' is null.")]
        [TestParameters(typeof(Zero), null, "message", 3, false, "Parameter 'interface' is null.")]
        [TestParameters(typeof(Zero), typeof(Zero), "message", 4, false, "Type 'Ntt.Zero' is not an interface.")]
        [TestParameters(typeof(Two), typeof(ITwo), "message", 5, true, "Type 'Ntt.Two' implements interface 'Ntt.ITwo'.")]
        [TestParameters(typeof(Two), typeof(IZero), "message", 6, false, "message")]
        void ImplementsWithMessage(Type input1, Type input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Type.Implements(input1, input2, customMessage),
                (count, result, message), "Test.If.Type.Implements");

        }

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'type' is null.")]
        [TestParameters(null, typeof(Zero), "message", 2, false, "Parameter 'type' is null.")]
        [TestParameters(typeof(Zero), null, "message", 3, false, "Parameter 'interface' is null.")]
        [TestParameters(typeof(Zero), typeof(Zero), "message", 4, false, "Type 'Ntt.Zero' is not an interface.")]
        [TestParameters(typeof(Two), typeof(ITwo), "message", 5, false, "message")]
        [TestParameters(typeof(Two), typeof(IZero), "message", 6, true, "Type 'Ntt.Two' doesn't implement interface 'Ntt.IZero'.")]
        void NotImplementsWithMessage(Type input1, Type input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Type.Implements(input1, input2, customMessage),
                (count, result, message), "Test.IfNot.Type.Implements");

        }

        #endregion

        #region IsSubClassGeneric

        [TestMethod]
        [TestData(nameof(IsSubClassGenericData))]
        void IsSubClassGeneric<TType, TBase>((Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Type.IsSubClass<TType, TBase>(),
                expected, "Test.If.Type.IsSubClass");

        }

        IEnumerable<Object[]> IsSubClassGenericData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), typeof(Zero), (1, false, "Type 'Ntt.Zero' is no subclass of 'Ntt.Zero'.") },
                new Object[] { typeof(DerivesFromZero), typeof(Zero), (2, true, "Type 'Ntt.DerivesFromZero' is subclass of 'Ntt.Zero'.") },
                new Object[] { typeof(DerivesFromZero), typeof(ITwo), (3, false, "Type 'Ntt.ITwo' is not a class.") },
                new Object[] { typeof(ITwo), typeof(Zero), (4, false, "Type 'Ntt.ITwo' is not a class.") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsSubClassGenericData))]
        void NotIsSubClassGeneric<TType, TBase>((Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Type.IsSubClass<TType, TBase>(),
                expected, "Test.IfNot.Type.IsSubClass");

        }

        IEnumerable<Object[]> NotIsSubClassGenericData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), typeof(Zero), (1, true, "Type 'Ntt.Zero' is no subclass of 'Ntt.Zero'.") },
                new Object[] { typeof(DerivesFromZero), typeof(Zero), (2, false, "Type 'Ntt.DerivesFromZero' is subclass of 'Ntt.Zero'.") },
                new Object[] { typeof(DerivesFromZero), typeof(ITwo), (3, false, "Type 'Ntt.ITwo' is not a class.") },
                new Object[] { typeof(ITwo), typeof(Zero), (4, false, "Type 'Ntt.ITwo' is not a class.") },
            };
        }

        #endregion

        #region IsSubClassGenericWithMessage

        [TestMethod]
        [TestData(nameof(IsSubClassGenericWithMessageData))]
        void IsSubClassGenericWithMessage<TType, TBase>(String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Type.IsSubClass<TType, TBase>(customMessage),
                expected, "Test.If.Type.IsSubClass");

        }

        IEnumerable<Object[]> IsSubClassGenericWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), typeof(Zero), "message", (1, false, "message") },
                new Object[] { typeof(DerivesFromZero), typeof(Zero), "message", (2, true, "Type 'Ntt.DerivesFromZero' is subclass of 'Ntt.Zero'.") },
                new Object[] { typeof(DerivesFromZero), typeof(ITwo), "message", (3, false, "Type 'Ntt.ITwo' is not a class.") },
                new Object[] { typeof(ITwo), typeof(Zero), "message", (4, false, "Type 'Ntt.ITwo' is not a class.") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsSubClassGenericWithMessageData))]
        void NotIsSubClassGenericWithMessage<TType, TBase>(String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Type.IsSubClass<TType, TBase>(customMessage),
                expected, "Test.IfNot.Type.IsSubClass");

        }

        IEnumerable<Object[]> NotIsSubClassGenericWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), typeof(Zero), "message", (1, true, "Type 'Ntt.Zero' is no subclass of 'Ntt.Zero'.") },
                new Object[] { typeof(DerivesFromZero), typeof(Zero), "message", (2, false, "message") },
                new Object[] { typeof(DerivesFromZero), typeof(ITwo), "message", (3, false, "Type 'Ntt.ITwo' is not a class.") },
                new Object[] { typeof(ITwo), typeof(Zero), "message", (4, false, "Type 'Ntt.ITwo' is not a class.") },
            };
        }

        #endregion

        #region IsSubClass

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

        #region IsSubClassWithMessage

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'type' is null.")]
        [TestParameters(null, typeof(Zero), "message", 2, false, "Parameter 'type' is null.")]
        [TestParameters(typeof(Zero), null, "message", 3, false, "Parameter 'baseType' is null.")]
        [TestParameters(typeof(Zero), typeof(Zero), "message", 4, false, "message")]
        [TestParameters(typeof(DerivesFromZero), typeof(Zero), "message", 5, true, "Type 'Ntt.DerivesFromZero' is subclass of 'Ntt.Zero'.")]
        [TestParameters(typeof(DerivesFromZero), typeof(ITwo), "message", 6, false, "Type 'Ntt.ITwo' is not a class.")]
        [TestParameters(typeof(ITwo), typeof(Zero), "message", 7, false, "Type 'Ntt.ITwo' is not a class.")]
        void IsSubClassWithMessage(Type input1, Type input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Type.IsSubClass(input1, input2, customMessage),
                (count, result, message), "Test.If.Type.IsSubClass");

        }

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'type' is null.")]
        [TestParameters(null, typeof(Zero), "message", 2, false, "Parameter 'type' is null.")]
        [TestParameters(typeof(Zero), null, "message", 3, false, "Parameter 'baseType' is null.")]
        [TestParameters(typeof(Zero), typeof(Zero), "message", 4, true, "Type 'Ntt.Zero' is no subclass of 'Ntt.Zero'.")]
        [TestParameters(typeof(DerivesFromZero), typeof(Zero), "message", 5, false, "message")]
        [TestParameters(typeof(DerivesFromZero), typeof(ITwo), "message", 6, false, "Type 'Ntt.ITwo' is not a class.")]
        [TestParameters(typeof(ITwo), typeof(Zero), "message", 7, false, "Type 'Ntt.ITwo' is not a class.")]
        void NotIsSubClassWithMessage(Type input1, Type input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Type.IsSubClass(input1, input2, customMessage),
                (count, result, message), "Test.IfNot.Type.IsSubClass");

        }

        #endregion

    }
}
