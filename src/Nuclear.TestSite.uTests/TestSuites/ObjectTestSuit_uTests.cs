using System;
using System.Collections.Generic;

using Ntt;

namespace Nuclear.TestSite.TestSuites {
    class ObjectTestSuit_uTests {

        #region IsNull

        [TestMethod]
        [TestParameters(null, 1, true, "[Object: null]")]
        [TestParameters("", 2, false, "[Object: not null]")]
        void IsNull(Object input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsNull(input),
                (count, result, message), "Test.If.Object.IsNull");

        }

        [TestMethod]
        [TestParameters(null, 1, false, "[Object: null]")]
        [TestParameters("", 2, true, "[Object: not null]")]
        void NotIsNull(Object input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsNull(input),
                (count, result, message), "Test.IfNot.Object.IsNull");

        }

        #endregion

        #region IsNullWithMessage

        [TestMethod]
        [TestParameters(null, "message", 1, true, "[Object: null]")]
        [TestParameters("", "message", 2, false, "message")]
        void IsNullWithMessage(Object input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsNull(input, customMessage),
                (count, result, message), "Test.If.Object.IsNull");

        }

        [TestMethod]
        [TestParameters(null, "message", 1, false, "message")]
        [TestParameters("", "message", 2, true, "[Object: not null]")]
        void NotIsNullWithMessage(Object input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsNull(input, customMessage),
                (count, result, message), "Test.IfNot.Object.IsNull");

        }

        #endregion

        #region IsOfTypeGeneric

        [TestMethod]
        [TestData(nameof(IsOfTypeGenericData))]
        void IsOfTypeGeneric<TType>(Object input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfType<TType>(input),
                expected, "Test.If.Object.IsOfType");

        }

        IEnumerable<Object[]> IsOfTypeGenericData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), new Zero(), (1, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new DerivesFromZero(), (2, true, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new Two(), (3, false, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(ITwo), new Two(), (4, true, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'.") },
                new Object[] { typeof(IZero), new Two(), (5, false, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'.") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsOfTypeGenericData))]
        void NotIsOfTypeGeneric<TType>(Object input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfType<TType>(input),
                expected, "Test.IfNot.Object.IsOfType");

        }

        IEnumerable<Object[]> NotIsOfTypeGenericData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), new Zero(), (1, false, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new DerivesFromZero(), (2, false, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new Two(), (3, true, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(ITwo), new Two(), (4, false, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'.") },
                new Object[] { typeof(IZero), new Two(), (5, true, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'.") },
            };
        }

        #endregion

        #region IsOfTypeGenericWithMessage

        [TestMethod]
        [TestData(nameof(IsOfTypeGenericWithMessageData))]
        void IsOfTypeGenericWithMessage<TType>(Object input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfType<TType>(input, customMessage),
                expected, "Test.If.Object.IsOfType");

        }

        IEnumerable<Object[]> IsOfTypeGenericWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), new Zero(), "message", (1, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new Two(), "message", (2, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsOfTypeGenericWithMessageData))]
        void NotIsOfTypeGenericWithMessage<TType>(Object input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfType<TType>(input, customMessage),
                expected, "Test.IfNot.Object.IsOfType");

        }

        IEnumerable<Object[]> NotIsOfTypeGenericWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), new Zero(), "message", (1, false, "message") },
                new Object[] { typeof(Zero), new Two(), "message", (2, true, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
            };
        }

        #endregion

        #region IsOfType

        [TestMethod]
        [TestData(nameof(IsOfTypeData))]
        void IsOfType(Object input1, Type input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfType(input1, input2),
                expected, "Test.If.Object.IsOfType");

        }

        IEnumerable<Object[]> IsOfTypeData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'object' is null.") },
                new Object[] { null, typeof(Zero), (2, false, "Parameter 'object' is null.") },
                new Object[] { new Zero(), null, (3, false, "Parameter 'type' is null.") },
                new Object[] { new Zero(), typeof(Zero), (4, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new DerivesFromZero(), typeof(Zero), (5, true, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(Zero), (6, false, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(ITwo), (7, true, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'.") },
                new Object[] { new Two(), typeof(IZero), (8, false, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'.") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsOfTypeData))]
        void NotIsOfType(Object input1, Type input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfType(input1, input2),
                expected, "Test.IfNot.Object.IsOfType");

        }

        IEnumerable<Object[]> NotIsOfTypeData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'object' is null.") },
                new Object[] { null, typeof(Zero), (2, false, "Parameter 'object' is null.") },
                new Object[] { new Zero(), null, (3, false, "Parameter 'type' is null.") },
                new Object[] { new Zero(), typeof(Zero), (4, false, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new DerivesFromZero(), typeof(Zero), (5, false, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(Zero), (6, true, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(ITwo), (7, false, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'.") },
                new Object[] { new Two(), typeof(IZero), (8, true, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'.") },
            };
        }

        #endregion

        #region IsOfTypeWithMessage

        [TestMethod]
        [TestData(nameof(IsOfTypeWithMessageData))]
        void IsOfTypeWithMessage(Object input1, Type input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfType(input1, input2, customMessage),
                expected, "Test.If.Object.IsOfType");

        }

        IEnumerable<Object[]> IsOfTypeWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'object' is null.") },
                new Object[] { null, typeof(Zero), "message", (2, false, "Parameter 'object' is null.") },
                new Object[] { new Zero(), null, "message", (3, false, "Parameter 'type' is null.") },
                new Object[] { new Zero(), typeof(Zero), "message", (4, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(Zero), "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsOfTypeWithMessageData))]
        void NotIsOfTypeWithMessage(Object input1, Type input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfType(input1, input2, customMessage),
                expected, "Test.IfNot.Object.IsOfType");

        }

        IEnumerable<Object[]> NotIsOfTypeWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'object' is null.") },
                new Object[] { null, typeof(Zero), "message", (2, false, "Parameter 'object' is null.") },
                new Object[] { new Zero(), null, "message", (3, false, "Parameter 'type' is null.") },
                new Object[] { new Zero(), typeof(Zero), "message", (4, false, "message") },
                new Object[] { new Two(), typeof(Zero), "message", (5, true, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
            };
        }

        #endregion

        #region IsOfExactTypeGeneric

        [TestMethod]
        [TestData(nameof(IsOfExactTypeGenericData))]
        void IsOfExactTypeGeneric<TType>(Object input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfExactType<TType>(input),
                expected, "Test.If.Object.IsOfExactType");

        }

        IEnumerable<Object[]> IsOfExactTypeGenericData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), null, (1, false, "Parameter 'object' is null.") },
                new Object[] { typeof(Zero), new Zero(), (2, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new DerivesFromZero(), (3, false, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new Two(), (4, false, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(ITwo), new Two(), (5, false, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'.") },
                new Object[] { typeof(IZero), new Two(), (6, false, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'.") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsOfExactTypeGenericData))]
        void NotIsOfExactTypeGeneric<TType>(Object input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfExactType<TType>(input),
                expected, "Test.IfNot.Object.IsOfExactType");

        }

        IEnumerable<Object[]> NotIsOfExactTypeGenericData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), null, (1, false, "Parameter 'object' is null.") },
                new Object[] { typeof(Zero), new Zero(), (2, false, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new DerivesFromZero(), (3, true, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new Two(), (4, true, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(ITwo), new Two(), (5, true, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'.") },
                new Object[] { typeof(IZero), new Two(), (6, true, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'.") },
            };
        }

        #endregion

        #region IsOfExactTypeGenericWithMessage

        [TestMethod]
        [TestData(nameof(IsOfExactTypeGenericWithMessageData))]
        void IsOfExactTypeGenericWithMessage<TType>(Object input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfExactType<TType>(input, customMessage),
                expected, "Test.If.Object.IsOfExactType");

        }

        IEnumerable<Object[]> IsOfExactTypeGenericWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), null, "message", (1, false, "Parameter 'object' is null.") },
                new Object[] { typeof(Zero), new Zero(), "message", (2, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { typeof(Zero), new DerivesFromZero(), "message", (3, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsOfExactTypeGenericWithMessageData))]
        void NotIsOfExactTypeGenericWithMessage<TType>(Object input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfExactType<TType>(input, customMessage),
                expected, "Test.IfNot.Object.IsOfExactType");

        }

        IEnumerable<Object[]> NotIsOfExactTypeGenericWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Zero), null, "message", (1, false, "Parameter 'object' is null.") },
                new Object[] { typeof(Zero), new Zero(), "message", (2, false, "message") },
                new Object[] { typeof(Zero), new DerivesFromZero(), "message", (3, true, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
            };
        }

        #endregion

        #region IsOfExactType

        [TestMethod]
        [TestData(nameof(IsOfExactTypeData))]
        void IsOfExactType(Object input1, Type input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfExactType(input1, input2),
                expected, "Test.If.Object.IsOfExactType");

        }

        IEnumerable<Object[]> IsOfExactTypeData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'object' is null.") },
                new Object[] { null, typeof(Zero), (2, false, "Parameter 'object' is null.") },
                new Object[] { new Zero(), null, (3, false, "Parameter 'type' is null.") },
                new Object[] { new Zero(), typeof(Zero), (4, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new DerivesFromZero(), typeof(Zero), (5, false, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(Zero), (6, false, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(ITwo), (7, false, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'.") },
                new Object[] { new Two(), typeof(IZero), (8, false, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'.") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsOfExactTypeData))]
        void NotIsOfExactType(Object input1, Type input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfExactType(input1, input2),
                expected, "Test.IfNot.Object.IsOfExactType");

        }

        IEnumerable<Object[]> NotIsOfExactTypeData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'object' is null.") },
                new Object[] { null, typeof(Zero), (2, false, "Parameter 'object' is null.") },
                new Object[] { new Zero(), null, (3, false, "Parameter 'type' is null.") },
                new Object[] { new Zero(), typeof(Zero), (4, false, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new DerivesFromZero(), typeof(Zero), (5, true, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(Zero), (6, true, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'.") },
                new Object[] { new Two(), typeof(ITwo), (7, true, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'.") },
                new Object[] { new Two(), typeof(IZero), (8, true, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'.") },
            };
        }

        #endregion

        #region IsOfExactTypeWithMessage

        [TestMethod]
        [TestData(nameof(IsOfExactTypeWithMessageData))]
        void IsOfExactTypeWithMessage(Object input1, Type input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfExactType(input1, input2, customMessage),
                expected, "Test.If.Object.IsOfExactType");

        }

        IEnumerable<Object[]> IsOfExactTypeWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'object' is null.") },
                new Object[] { null, typeof(Zero), "message", (2, false, "Parameter 'object' is null.") },
                new Object[] { new Zero(), null, "message", (3, false, "Parameter 'type' is null.") },
                new Object[] { new Zero(), typeof(Zero), "message", (4, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'.") },
                new Object[] { new DerivesFromZero(), typeof(Zero), "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsOfExactTypeWithMessageData))]
        void NotIsOfExactTypeWithMessage(Object input1, Type input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfExactType(input1, input2, customMessage),
                expected, "Test.IfNot.Object.IsOfExactType");

        }

        IEnumerable<Object[]> NotIsOfExactTypeWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'object' is null.") },
                new Object[] { null, typeof(Zero), "message", (2, false, "Parameter 'object' is null.") },
                new Object[] { new Zero(), null, "message", (3, false, "Parameter 'type' is null.") },
                new Object[] { new Zero(), typeof(Zero), "message", (4, false, "message") },
                new Object[] { new DerivesFromZero(), typeof(Zero), "message", (5, true, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'.") },
            };
        }

        #endregion

    }
}
