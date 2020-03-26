using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Ntt;

using Nuclear.Extensions;

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

        #region IsOfType

        [TestMethod]
        void IsOfTypeGeneric() {

            DDTIsOfTypeGeneric<Zero>(null, (1, false, "Parameter 'object' is null."));
            DDTIsOfTypeGeneric<Zero>(new Zero(), (2, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'."));
            DDTIsOfTypeGeneric<Zero>(new DerivesFromZero(), (3, true, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'."));
            DDTIsOfTypeGeneric<Zero>(new Two(), (4, false, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'."));
            DDTIsOfTypeGeneric<ITwo>(new Two(), (5, true, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'."));
            DDTIsOfTypeGeneric<IZero>(new Two(), (6, false, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'."));

        }

        void DDTIsOfTypeGeneric<TType>(Object input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Object.IsOfType<{typeof(TType).Format()}>({input.FormatType()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfType<TType>(input, _file, _method),
                expected, "Test.If.Object.IsOfType", _file, _method);

        }

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
        void NotIsOfTypeGeneric() {

            DDTNotIsOfTypeGeneric<Zero>(null, (1, false, "Parameter 'object' is null."));
            DDTNotIsOfTypeGeneric<Zero>(new Zero(), (2, false, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'."));
            DDTNotIsOfTypeGeneric<Zero>(new DerivesFromZero(), (3, false, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'."));
            DDTNotIsOfTypeGeneric<Zero>(new Two(), (4, true, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'."));
            DDTNotIsOfTypeGeneric<ITwo>(new Two(), (5, false, "Object is 'Ntt.Two'. Given type is 'Ntt.ITwo'."));
            DDTNotIsOfTypeGeneric<IZero>(new Two(), (6, true, "Object is 'Ntt.Two'. Given type is 'Ntt.IZero'."));

        }

        void DDTNotIsOfTypeGeneric<TType>(Object input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Object.IsOfType<{typeof(TType).Format()}>({input.FormatType()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfType<TType>(input, _file, _method),
                expected, "Test.IfNot.Object.IsOfType", _file, _method);

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

        #region IsOfExactType

        [TestMethod]
        void IsOfExactTypeGeneric() {

            DDTIsOfExactTypeGeneric<Zero>(null, (1, false, "Parameter 'object' is null."));
            DDTIsOfExactTypeGeneric<Zero>(new Zero(), (2, true, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'."));
            DDTIsOfExactTypeGeneric<Zero>(new DerivesFromZero(), (3, false, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'."));
            DDTIsOfExactTypeGeneric<Zero>(new Two(), (4, false, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'."));

        }

        void DDTIsOfExactTypeGeneric<TType>(Object input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Object.IsOfExactType<{typeof(TType).Format()}>({input.FormatType()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Object.IsOfExactType<TType>(input, _file, _method),
                expected, "Test.If.Object.IsOfExactType", _file, _method);

        }

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
        void NotIsOfExactTypeGeneric() {

            DDTNotIsOfExactTypeGeneric<Zero>(null, (1, false, "Parameter 'object' is null."));
            DDTNotIsOfExactTypeGeneric<Zero>(new Zero(), (2, false, "Object is 'Ntt.Zero'. Given type is 'Ntt.Zero'."));
            DDTNotIsOfExactTypeGeneric<Zero>(new DerivesFromZero(), (3, true, "Object is 'Ntt.DerivesFromZero'. Given type is 'Ntt.Zero'."));
            DDTNotIsOfExactTypeGeneric<Zero>(new Two(), (4, true, "Object is 'Ntt.Two'. Given type is 'Ntt.Zero'."));

        }

        void DDTNotIsOfExactTypeGeneric<TType>(Object input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Object.IsOfExactType<{typeof(TType).Format()}>({input.FormatType()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Object.IsOfExactType<TType>(input, _file, _method),
                expected, "Test.IfNot.Object.IsOfExactType", _file, _method);

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

    }
}
