using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Ntt;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    class ValueTestSuit_uTests {

        #region IsEqual

        [TestMethod]
        [TestData(nameof(IsEqualData))]
        void IsEqual<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, true, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIEquatableT), null, new DummyIEquatableT(0), (2, false, "('GenericEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(0), null, (3, false, "('Ntt.DummyIEquatableT'.IEquatable<T>) [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(5), new DummyIEquatableT(0), (4, false, "('Ntt.DummyIEquatableT'.IEquatable<T>) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(5), new DummyIEquatableT(5), (5, true, "('Ntt.DummyIEquatableT'.IEquatable<T>) [Left = '5'; Right = '5']") },

                new Object[] { typeof(DummyIComparableT), null, null, (6, true, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), (7, false, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, (8, false, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(5), new DummyIComparableT(0), (9, false, "('Ntt.DummyIComparableT'.IComparable<T>) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(5), new DummyIComparableT(5), (10, true, "('Ntt.DummyIComparableT'.IComparable<T>) [Left = '5'; Right = '5']") },

                new Object[] { typeof(DummyIComparable), null, null, (11, true, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), (12, false, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, (13, false, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(5), new DummyIComparable(0), (14, false, "('Ntt.DummyIComparable'.IComparable) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(5), new DummyIComparable(5), (15, true, "('Ntt.DummyIComparable'.IComparable) [Left = '5'; Right = '5']") },

                new Object[] { typeof(Dummy), null, null, (16, true, "[Left = null; Right = null]") },
                new Object[] { typeof(Dummy), null, new Dummy(0), (17, false, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, (18, false, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), (19, false, "('ObjectEqualityComparer`1') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), (20, false, "('ObjectEqualityComparer`1') [Left = '5'; Right = '5']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualData))]
        void NotIsEqual<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIEquatableT), null, new DummyIEquatableT(0), (2, true, "('GenericEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(0), null, (3, true, "('Ntt.DummyIEquatableT'.IEquatable<T>) [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(5), new DummyIEquatableT(0), (4, true, "('Ntt.DummyIEquatableT'.IEquatable<T>) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(5), new DummyIEquatableT(5), (5, false, "('Ntt.DummyIEquatableT'.IEquatable<T>) [Left = '5'; Right = '5']") },

                new Object[] { typeof(DummyIComparableT), null, null, (6, false, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), (7, true, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, (8, true, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(5), new DummyIComparableT(0), (9, true, "('Ntt.DummyIComparableT'.IComparable<T>) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(5), new DummyIComparableT(5), (10, false, "('Ntt.DummyIComparableT'.IComparable<T>) [Left = '5'; Right = '5']") },

                new Object[] { typeof(DummyIComparable), null, null, (11, false, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), (12, true, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, (13, true, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(5), new DummyIComparable(0), (14, true, "('Ntt.DummyIComparable'.IComparable) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(5), new DummyIComparable(5), (15, false, "('Ntt.DummyIComparable'.IComparable) [Left = '5'; Right = '5']") },

                new Object[] { typeof(Dummy), null, null, (16, false, "[Left = null; Right = null]") },
                new Object[] { typeof(Dummy), null, new Dummy(0), (17, true, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, (18, true, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), (19, true, "('ObjectEqualityComparer`1') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), (20, true, "('ObjectEqualityComparer`1') [Left = '5'; Right = '5']") },
            };
        }

        #endregion

        #region IsEqualComparer

        [TestMethod]
        void IsEqualComparer() {

            DDTIsEqualComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTIsEqualComparer((null, 0, new DummyEqualityComparer()), (2, false, "('DummyEqualityComparer') [Left = null; Right = '0']"));
            DDTIsEqualComparer((0, null, new DummyEqualityComparer()), (3, false, "('DummyEqualityComparer') [Left = '0'; Right = null]"));
            DDTIsEqualComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTIsEqualComparer<Dummy>((5, 0, new DummyEqualityComparer()), (5, false, "('DummyEqualityComparer') [Left = '5'; Right = '0']"));
            DDTIsEqualComparer<Dummy>((5, 5, new DummyEqualityComparer()), (6, true, "('DummyEqualityComparer') [Left = '5'; Right = '5']"));
            DDTIsEqualComparer<Dummy>((5, 5, new ThrowingEqualityComparer()), (7, false, "Comparison threw Exception:"));

            DDTIsEqualComparer<Dummy>((null, null, (IEqualityComparer) null), (8, false, "Parameter 'comparer' is null."));
            DDTIsEqualComparer<Dummy>((null, 0, new DummyIEqualityComparer()), (9, false, "('InternalEqualityComparer`1') [Left = null; Right = '0']"));
            DDTIsEqualComparer<Dummy>((0, null, new DummyIEqualityComparer()), (10, false, "('InternalEqualityComparer`1') [Left = '0'; Right = null]"));
            DDTIsEqualComparer<Dummy>((0, 0, (IEqualityComparer) null), (11, false, "Parameter 'comparer' is null."));
            DDTIsEqualComparer<Dummy>((5, 0, new DummyIEqualityComparer()), (12, false, "('InternalEqualityComparer`1') [Left = '5'; Right = '0']"));
            DDTIsEqualComparer<Dummy>((5, 5, new DummyIEqualityComparer()), (13, true, "('InternalEqualityComparer`1') [Left = '5'; Right = '5']"));
            DDTIsEqualComparer<Dummy>((5, 5, DynamicEqualityComparer.FromDelegate(
                (x, y) => throw new NotImplementedException(),
                (obj) => throw new NotImplementedException())),
                (14, false, "Comparison threw Exception:"));

            DDTIsEqualComparer((null, null, (IEqualityComparer<Dummy>) null), (15, false, "Parameter 'comparer' is null."));
            DDTIsEqualComparer((null, 0, new DummyIEqualityComparerT()), (16, false, "('DummyIEqualityComparerT') [Left = null; Right = '0']"));
            DDTIsEqualComparer((0, null, new DummyIEqualityComparerT()), (17, false, "('DummyIEqualityComparerT') [Left = '0'; Right = null]"));
            DDTIsEqualComparer((0, 0, (IEqualityComparer<Dummy>) null), (18, false, "Parameter 'comparer' is null."));
            DDTIsEqualComparer((5, 0, new DummyIEqualityComparerT()), (19, false, "('DummyIEqualityComparerT') [Left = '5'; Right = '0']"));
            DDTIsEqualComparer((5, 5, new DummyIEqualityComparerT()), (20, true, "('DummyIEqualityComparerT') [Left = '5'; Right = '5']"));
            DDTIsEqualComparer((5, 5, DynamicEqualityComparer.FromDelegate<Dummy>(
                (x, y) => throw new NotImplementedException(),
                (obj) => throw new NotImplementedException())),
                (21, false, "Comparison threw Exception:"));

        }

        void DDTIsEqualComparer<T>((T left, T right, EqualityComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsEqual<{typeof(T).Format()}>({input.left.Format()}, {input.right.Format()}, {input.comparer.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input.left, input.right, input.comparer, _file, _method),
                expected, "Test.If.Value.IsEqual", _file, _method);

        }

        void DDTIsEqualComparer<T>((T left, T right, IEqualityComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsEqual<{typeof(T).Format()}>({input.left.Format()}, {input.right.Format()}, {input.comparer.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input.left, input.right, input.comparer, _file, _method),
                expected, "Test.If.Value.IsEqual", _file, _method);

        }

        void DDTIsEqualComparer<T>((T left, T right, IEqualityComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsEqual<{typeof(T).Format()}>({input.left.Format()}, {input.right.Format()}, {input.comparer.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input.left, input.right, input.comparer, _file, _method),
                expected, "Test.If.Value.IsEqual", _file, _method);

        }

        [TestMethod]
        void NotIsEqualComparer() {

            DDTNotIsEqualComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTNotIsEqualComparer((null, 0, new DummyEqualityComparer()), (2, true, "('DummyEqualityComparer') [Left = null; Right = '0']"));
            DDTNotIsEqualComparer((0, null, new DummyEqualityComparer()), (3, true, "('DummyEqualityComparer') [Left = '0'; Right = null]"));
            DDTNotIsEqualComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTNotIsEqualComparer<Dummy>((5, 0, new DummyEqualityComparer()), (5, true, "('DummyEqualityComparer') [Left = '5'; Right = '0']"));
            DDTNotIsEqualComparer<Dummy>((5, 5, new DummyEqualityComparer()), (6, false, "('DummyEqualityComparer') [Left = '5'; Right = '5']"));
            DDTNotIsEqualComparer<Dummy>((5, 5, new ThrowingEqualityComparer()), (7, false, "Comparison threw Exception:"));

            DDTNotIsEqualComparer<Dummy>((null, null, (IEqualityComparer) null), (8, false, "Parameter 'comparer' is null."));
            DDTNotIsEqualComparer<Dummy>((null, 0, new DummyIEqualityComparer()), (9, true, "('InternalEqualityComparer`1') [Left = null; Right = '0']"));
            DDTNotIsEqualComparer<Dummy>((0, null, new DummyIEqualityComparer()), (10, true, "('InternalEqualityComparer`1') [Left = '0'; Right = null]"));
            DDTNotIsEqualComparer<Dummy>((0, 0, (IEqualityComparer) null), (11, false, "Parameter 'comparer' is null."));
            DDTNotIsEqualComparer<Dummy>((5, 0, new DummyIEqualityComparer()), (12, true, "('InternalEqualityComparer`1') [Left = '5'; Right = '0']"));
            DDTNotIsEqualComparer<Dummy>((5, 5, new DummyIEqualityComparer()), (13, false, "('InternalEqualityComparer`1') [Left = '5'; Right = '5']"));
            DDTNotIsEqualComparer<Dummy>((5, 5, DynamicEqualityComparer.FromDelegate(
                (x, y) => throw new NotImplementedException(),
                (obj) => throw new NotImplementedException())),
                (14, false, "Comparison threw Exception:"));

            DDTNotIsEqualComparer((null, null, (IEqualityComparer<Dummy>) null), (15, false, "Parameter 'comparer' is null."));
            DDTNotIsEqualComparer((null, 0, new DummyIEqualityComparerT()), (16, true, "('DummyIEqualityComparerT') [Left = null; Right = '0']"));
            DDTNotIsEqualComparer((0, null, new DummyIEqualityComparerT()), (17, true, "('DummyIEqualityComparerT') [Left = '0'; Right = null]"));
            DDTNotIsEqualComparer((0, 0, (IEqualityComparer<Dummy>) null), (18, false, "Parameter 'comparer' is null."));
            DDTNotIsEqualComparer((5, 0, new DummyIEqualityComparerT()), (19, true, "('DummyIEqualityComparerT') [Left = '5'; Right = '0']"));
            DDTNotIsEqualComparer((5, 5, new DummyIEqualityComparerT()), (20, false, "('DummyIEqualityComparerT') [Left = '5'; Right = '5']"));
            DDTNotIsEqualComparer((5, 5, DynamicEqualityComparer.FromDelegate<Dummy>(
                (x, y) => throw new NotImplementedException(),
                (obj) => throw new NotImplementedException())),
                (21, false, "Comparison threw Exception:"));

        }

        void DDTNotIsEqualComparer<T>((T left, T right, EqualityComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsEqual<{typeof(T).Format()}>({input.left.Format()}, {input.right.Format()}, {input.comparer.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input.left, input.right, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsEqual", _file, _method);

        }

        void DDTNotIsEqualComparer<T>((T left, T right, IEqualityComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsEqual<{typeof(T).Format()}>({input.left.Format()}, {input.right.Format()}, {input.comparer.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input.left, input.right, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsEqual", _file, _method);

        }

        void DDTNotIsEqualComparer<T>((T left, T right, IEqualityComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsEqual<{typeof(T).Format()}>({input.left.Format()}, {input.right.Format()}, {input.comparer.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input.left, input.right, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsEqual", _file, _method);

        }

        #endregion

        #region IsEqualSingle

        [TestMethod]
        [TestParameters(1f, 0f, 1, false, "[Left = '1'; Right = '0'; Margin = '1E-12']")]
        [TestParameters(1f, 1f, 2, true, "[Left = '1'; Right = '1'; Margin = '1E-12']")]
        [TestParameters(1e-11f, 1.1e-11f, 3, false, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-12']")]
        [TestParameters(1e-12f, 1.1e-12f, 4, true, "[Left = '1E-12'; Right = '1.1E-12'; Margin = '1E-12']")]
        void IsEqualSingle(Single input1, Single input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2),
                (count, result, message), "Test.If.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1e-11f, 1.1e-11f, 1e-11f, 1, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-11']")]
        void IsEqualSingleMargin(Single input1, Single input2, Single input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3),
                (count, result, message), "Test.If.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1f, 0f, 1, true, "[Left = '1'; Right = '0'; Margin = '1E-12']")]
        [TestParameters(1f, 1f, 2, false, "[Left = '1'; Right = '1'; Margin = '1E-12']")]
        [TestParameters(1e-11f, 1.1e-11f, 3, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-12']")]
        [TestParameters(1e-12f, 1.1e-12f, 4, false, "[Left = '1E-12'; Right = '1.1E-12'; Margin = '1E-12']")]
        void NotIsEqualSingle(Single input1, Single input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2),
                (count, result, message), "Test.IfNot.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1e-11f, 1.1e-11f, 1e-11f, 1, false, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-11']")]
        void NotIsEqualSingleMargin(Single input1, Single input2, Single input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3),
                (count, result, message), "Test.IfNot.Value.IsEqual");

        }

        #endregion

        #region IsEqualDouble

        [TestMethod]
        [TestParameters(1d, 0d, 1, false, "[Left = '1'; Right = '0'; Margin = '1E-12']")]
        [TestParameters(1d, 1d, 2, true, "[Left = '1'; Right = '1'; Margin = '1E-12']")]
        [TestParameters(1e-11d, 1.1e-11d, 3, false, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-12']")]
        [TestParameters(1e-12d, 1.1e-12d, 4, true, "[Left = '1E-12'; Right = '1.1E-12'; Margin = '1E-12']")]
        void IsEqualDouble(Double input1, Double input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2),
                (count, result, message), "Test.If.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1e-11d, 1.1e-11d, 1e-11d, 1, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-11']")]
        void IsEqualDoubleMargin(Double input1, Double input2, Double input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3),
                (count, result, message), "Test.If.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1d, 0d, 1, true, "[Left = '1'; Right = '0'; Margin = '1E-12']")]
        [TestParameters(1d, 1d, 2, false, "[Left = '1'; Right = '1'; Margin = '1E-12']")]
        [TestParameters(1e-11d, 1.1e-11d, 3, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-12']")]
        [TestParameters(1e-12d, 1.1e-12d, 4, false, "[Left = '1E-12'; Right = '1.1E-12'; Margin = '1E-12']")]
        void NotIsEqualDouble(Double input1, Double input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2),
                (count, result, message), "Test.IfNot.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1e-11d, 1.1e-11d, 1e-11d, 1, false, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-11']")]
        void NotIsEqualDoubleMargin(Double input1, Double input2, Double input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3),
                (count, result, message), "Test.IfNot.Value.IsEqual");

        }

        #endregion

        #region IsLessThan

        [TestMethod]
        void IsLessThan() {

            DDTIsLessThan<DummyIComparable>((0, 0), (1, false, "[Value = '0'; Other = '0']"));
            DDTIsLessThan<DummyIComparable>((0, 1), (2, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThan<DummyIComparable>((1, 0), (3, false, "[Value = '1'; Other = '0']"));

            DDTIsLessThanT<DummyIComparableT>((0, 0), (4, false, "[Value = '0'; Other = '0']"));
            DDTIsLessThanT<DummyIComparableT>((0, 1), (5, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanT<DummyIComparableT>((1, 0), (6, false, "[Value = '1'; Other = '0']"));

            DDTNotIsLessThan<DummyIComparable>((0, 0), (7, true, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThan<DummyIComparable>((0, 1), (8, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThan<DummyIComparable>((1, 0), (9, true, "[Value = '1'; Other = '0']"));

            DDTNotIsLessThanT<DummyIComparableT>((0, 0), (10, true, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanT<DummyIComparableT>((0, 1), (11, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanT<DummyIComparableT>((1, 0), (12, true, "[Value = '1'; Other = '0']"));

        }

        void DDTIsLessThan<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.If.Value.IsLessThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input.value, input.other, _file, _method),
                expected, "Test.If.Value.IsLessThan", _file, _method);

        }

        void DDTIsLessThanT<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.If.Value.IsLessThanT<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanT(input.value, input.other, _file, _method),
                expected, "Test.If.Value.IsLessThan", _file, _method);

        }

        void DDTNotIsLessThan<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.IfNot.Value.IsLessThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input.value, input.other, _file, _method),
                expected, "Test.IfNot.Value.IsLessThan", _file, _method);

        }

        void DDTNotIsLessThanT<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.IfNot.Value.IsLessThanT<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanT(input.value, input.other, _file, _method),
                expected, "Test.IfNot.Value.IsLessThan", _file, _method);

        }

        #endregion

        #region IsLessThanComparer

        [TestMethod]
        void IsLessThanComparer() {

            DDTIsLessThanComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTIsLessThanComparer((null, 0, new DummyComparer()), (2, true, "[Value = null; Other = '0']"));
            DDTIsLessThanComparer((0, null, new DummyComparer()), (3, false, "[Value = '0'; Other = null]"));
            DDTIsLessThanComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTIsLessThanComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

            DDTIsLessThanComparer<Dummy>((0, 0, new DummyComparer()), (6, false, "[Value = '0'; Other = '0']"));
            DDTIsLessThanComparer<Dummy>((0, 1, new DummyComparer()), (7, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanComparer<Dummy>((1, 0, new DummyComparer()), (8, false, "[Value = '1'; Other = '0']"));

            DDTIsLessThanComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
            DDTIsLessThanComparer<Dummy>((null, 0, new DummyIComparer()), (10, true, "[Value = null; Other = '0']"));
            DDTIsLessThanComparer<Dummy>((0, null, new DummyIComparer()), (11, false, "[Value = '0'; Other = null]"));
            DDTIsLessThanComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
            DDTIsLessThanComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

            DDTIsLessThanComparer<Dummy>((0, 0, new DummyIComparer()), (14, false, "[Value = '0'; Other = '0']"));
            DDTIsLessThanComparer<Dummy>((0, 1, new DummyIComparer()), (15, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanComparer<Dummy>((1, 0, new DummyIComparer()), (16, false, "[Value = '1'; Other = '0']"));

            DDTIsLessThanComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
            DDTIsLessThanComparer((null, 0, new DummyIComparerT()), (18, true, "[Value = null; Other = '0']"));
            DDTIsLessThanComparer((0, null, new DummyIComparerT()), (19, false, "[Value = '0'; Other = null]"));
            DDTIsLessThanComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
            DDTIsLessThanComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

            DDTIsLessThanComparer((0, 0, new DummyIComparerT()), (22, false, "[Value = '0'; Other = '0']"));
            DDTIsLessThanComparer((0, 1, new DummyIComparerT()), (23, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanComparer((1, 0, new DummyIComparerT()), (24, false, "[Value = '1'; Other = '0']"));

        }

        void DDTIsLessThanComparer<T>((T value, T other, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsLessThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsLessThan", _file, _method);

        }

        void DDTIsLessThanComparer<T>((T value, T other, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsLessThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsLessThan", _file, _method);

        }

        void DDTIsLessThanComparer<T>((T value, T other, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsLessThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsLessThan", _file, _method);

        }

        [TestMethod]
        void NotIsLessThanComparer() {

            DDTNotIsLessThanComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanComparer((null, 0, new DummyComparer()), (2, false, "[Value = null; Other = '0']"));
            DDTNotIsLessThanComparer((0, null, new DummyComparer()), (3, true, "[Value = '0'; Other = null]"));
            DDTNotIsLessThanComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

            DDTNotIsLessThanComparer<Dummy>((0, 0, new DummyComparer()), (6, true, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanComparer<Dummy>((0, 1, new DummyComparer()), (7, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanComparer<Dummy>((1, 0, new DummyComparer()), (8, true, "[Value = '1'; Other = '0']"));

            DDTNotIsLessThanComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanComparer<Dummy>((null, 0, new DummyIComparer()), (10, false, "[Value = null; Other = '0']"));
            DDTNotIsLessThanComparer<Dummy>((0, null, new DummyIComparer()), (11, true, "[Value = '0'; Other = null]"));
            DDTNotIsLessThanComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

            DDTNotIsLessThanComparer<Dummy>((0, 0, new DummyIComparer()), (14, true, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanComparer<Dummy>((0, 1, new DummyIComparer()), (15, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanComparer<Dummy>((1, 0, new DummyIComparer()), (16, true, "[Value = '1'; Other = '0']"));

            DDTNotIsLessThanComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanComparer((null, 0, new DummyIComparerT()), (18, false, "[Value = null; Other = '0']"));
            DDTNotIsLessThanComparer((0, null, new DummyIComparerT()), (19, true, "[Value = '0'; Other = null]"));
            DDTNotIsLessThanComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

            DDTNotIsLessThanComparer((0, 0, new DummyIComparerT()), (22, true, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanComparer((0, 1, new DummyIComparerT()), (23, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanComparer((1, 0, new DummyIComparerT()), (24, true, "[Value = '1'; Other = '0']"));

        }

        void DDTNotIsLessThanComparer<T>((T value, T other, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsLessThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsLessThan", _file, _method);

        }

        void DDTNotIsLessThanComparer<T>((T value, T other, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsLessThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsLessThan", _file, _method);

        }

        void DDTNotIsLessThanComparer<T>((T value, T other, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsLessThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsLessThan", _file, _method);

        }

        #endregion

        #region IsLessThanOrEqual

        [TestMethod]
        void IsLessThanOrEqual() {

            DDTIsLessThanOrEqual<DummyIComparable>((0, 0), (1, true, "[Value = '0'; Other = '0']"));
            DDTIsLessThanOrEqual<DummyIComparable>((0, 1), (2, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanOrEqual<DummyIComparable>((1, 0), (3, false, "[Value = '1'; Other = '0']"));

            DDTIsLessThanOrEqualT<DummyIComparableT>((0, 0), (4, true, "[Value = '0'; Other = '0']"));
            DDTIsLessThanOrEqualT<DummyIComparableT>((0, 1), (5, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanOrEqualT<DummyIComparableT>((1, 0), (6, false, "[Value = '1'; Other = '0']"));

            DDTNotIsLessThanOrEqual<DummyIComparable>((0, 0), (7, false, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanOrEqual<DummyIComparable>((0, 1), (8, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanOrEqual<DummyIComparable>((1, 0), (9, true, "[Value = '1'; Other = '0']"));

            DDTNotIsLessThanOrEqualT<DummyIComparableT>((0, 0), (10, false, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanOrEqualT<DummyIComparableT>((0, 1), (11, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanOrEqualT<DummyIComparableT>((1, 0), (12, true, "[Value = '1'; Other = '0']"));

        }

        void DDTIsLessThanOrEqual<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.If.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input.value, input.other, _file, _method),
                expected, "Test.If.Value.IsLessThanOrEqual", _file, _method);

        }

        void DDTIsLessThanOrEqualT<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.If.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqualT(input.value, input.other, _file, _method),
                expected, "Test.If.Value.IsLessThanOrEqual", _file, _method);

        }

        void DDTNotIsLessThanOrEqual<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.IfNot.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input.value, input.other, _file, _method),
                expected, "Test.IfNot.Value.IsLessThanOrEqual", _file, _method);

        }

        void DDTNotIsLessThanOrEqualT<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.IfNot.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqualT(input.value, input.other, _file, _method),
                expected, "Test.IfNot.Value.IsLessThanOrEqual", _file, _method);

        }

        #endregion

        #region IsLessThanOrEqualComparer

        [TestMethod]
        void IsLessThanOrEqualComparer() {

            DDTIsLessThanOrEqualComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTIsLessThanOrEqualComparer((null, 0, new DummyComparer()), (2, true, "[Value = null; Other = '0']"));
            DDTIsLessThanOrEqualComparer((0, null, new DummyComparer()), (3, false, "[Value = '0'; Other = null]"));
            DDTIsLessThanOrEqualComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTIsLessThanOrEqualComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

            DDTIsLessThanOrEqualComparer<Dummy>((0, 0, new DummyComparer()), (6, true, "[Value = '0'; Other = '0']"));
            DDTIsLessThanOrEqualComparer<Dummy>((0, 1, new DummyComparer()), (7, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanOrEqualComparer<Dummy>((1, 0, new DummyComparer()), (8, false, "[Value = '1'; Other = '0']"));

            DDTIsLessThanOrEqualComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
            DDTIsLessThanOrEqualComparer<Dummy>((null, 0, new DummyIComparer()), (10, true, "[Value = null; Other = '0']"));
            DDTIsLessThanOrEqualComparer<Dummy>((0, null, new DummyIComparer()), (11, false, "[Value = '0'; Other = null]"));
            DDTIsLessThanOrEqualComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
            DDTIsLessThanOrEqualComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

            DDTIsLessThanOrEqualComparer<Dummy>((0, 0, new DummyIComparer()), (14, true, "[Value = '0'; Other = '0']"));
            DDTIsLessThanOrEqualComparer<Dummy>((0, 1, new DummyIComparer()), (15, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanOrEqualComparer<Dummy>((1, 0, new DummyIComparer()), (16, false, "[Value = '1'; Other = '0']"));

            DDTIsLessThanOrEqualComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
            DDTIsLessThanOrEqualComparer((null, 0, new DummyIComparerT()), (18, true, "[Value = null; Other = '0']"));
            DDTIsLessThanOrEqualComparer((0, null, new DummyIComparerT()), (19, false, "[Value = '0'; Other = null]"));
            DDTIsLessThanOrEqualComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
            DDTIsLessThanOrEqualComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

            DDTIsLessThanOrEqualComparer((0, 0, new DummyIComparerT()), (22, true, "[Value = '0'; Other = '0']"));
            DDTIsLessThanOrEqualComparer((0, 1, new DummyIComparerT()), (23, true, "[Value = '0'; Other = '1']"));
            DDTIsLessThanOrEqualComparer((1, 0, new DummyIComparerT()), (24, false, "[Value = '1'; Other = '0']"));

        }

        void DDTIsLessThanOrEqualComparer<T>((T value, T other, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsLessThanOrEqual", _file, _method);

        }

        void DDTIsLessThanOrEqualComparer<T>((T value, T other, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsLessThanOrEqual", _file, _method);

        }

        void DDTIsLessThanOrEqualComparer<T>((T value, T other, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsLessThanOrEqual", _file, _method);

        }

        [TestMethod]
        void NotIsLessThanOrEqualComparer() {

            DDTNotIsLessThanOrEqualComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanOrEqualComparer((null, 0, new DummyComparer()), (2, false, "[Value = null; Other = '0']"));
            DDTNotIsLessThanOrEqualComparer((0, null, new DummyComparer()), (3, true, "[Value = '0'; Other = null]"));
            DDTNotIsLessThanOrEqualComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanOrEqualComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

            DDTNotIsLessThanOrEqualComparer<Dummy>((0, 0, new DummyComparer()), (6, false, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanOrEqualComparer<Dummy>((0, 1, new DummyComparer()), (7, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanOrEqualComparer<Dummy>((1, 0, new DummyComparer()), (8, true, "[Value = '1'; Other = '0']"));

            DDTNotIsLessThanOrEqualComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanOrEqualComparer<Dummy>((null, 0, new DummyIComparer()), (10, false, "[Value = null; Other = '0']"));
            DDTNotIsLessThanOrEqualComparer<Dummy>((0, null, new DummyIComparer()), (11, true, "[Value = '0'; Other = null]"));
            DDTNotIsLessThanOrEqualComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanOrEqualComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

            DDTNotIsLessThanOrEqualComparer<Dummy>((0, 0, new DummyIComparer()), (14, false, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanOrEqualComparer<Dummy>((0, 1, new DummyIComparer()), (15, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanOrEqualComparer<Dummy>((1, 0, new DummyIComparer()), (16, true, "[Value = '1'; Other = '0']"));

            DDTNotIsLessThanOrEqualComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanOrEqualComparer((null, 0, new DummyIComparerT()), (18, false, "[Value = null; Other = '0']"));
            DDTNotIsLessThanOrEqualComparer((0, null, new DummyIComparerT()), (19, true, "[Value = '0'; Other = null]"));
            DDTNotIsLessThanOrEqualComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
            DDTNotIsLessThanOrEqualComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

            DDTNotIsLessThanOrEqualComparer((0, 0, new DummyIComparerT()), (22, false, "[Value = '0'; Other = '0']"));
            DDTNotIsLessThanOrEqualComparer((0, 1, new DummyIComparerT()), (23, false, "[Value = '0'; Other = '1']"));
            DDTNotIsLessThanOrEqualComparer((1, 0, new DummyIComparerT()), (24, true, "[Value = '1'; Other = '0']"));

        }

        void DDTNotIsLessThanOrEqualComparer<T>((T value, T other, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsLessThanOrEqual", _file, _method);

        }

        void DDTNotIsLessThanOrEqualComparer<T>((T value, T other, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsLessThanOrEqual", _file, _method);

        }

        void DDTNotIsLessThanOrEqualComparer<T>((T value, T other, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsLessThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsLessThanOrEqual", _file, _method);

        }

        #endregion

        #region IsGreaterThan

        [TestMethod]
        void IsGreaterThan() {

            DDTIsGreaterThan<DummyIComparable>((0, 0), (1, false, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThan<DummyIComparable>((0, 1), (2, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThan<DummyIComparable>((1, 0), (3, true, "[Value = '1'; Other = '0']"));

            DDTIsGreaterThanT<DummyIComparableT>((0, 0), (4, false, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanT<DummyIComparableT>((0, 1), (5, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanT<DummyIComparableT>((1, 0), (6, true, "[Value = '1'; Other = '0']"));

            DDTNotIsGreaterThan<DummyIComparable>((0, 0), (7, true, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThan<DummyIComparable>((0, 1), (8, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThan<DummyIComparable>((1, 0), (9, false, "[Value = '1'; Other = '0']"));

            DDTNotIsGreaterThanT<DummyIComparableT>((0, 0), (10, true, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanT<DummyIComparableT>((0, 1), (11, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanT<DummyIComparableT>((1, 0), (12, false, "[Value = '1'; Other = '0']"));

        }

        void DDTIsGreaterThan<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.If.Value.IsGreaterThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input.value, input.other, _file, _method),
                expected, "Test.If.Value.IsGreaterThan", _file, _method);

        }

        void DDTIsGreaterThanT<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.If.Value.IsGreaterThanT<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanT(input.value, input.other, _file, _method),
                expected, "Test.If.Value.IsGreaterThan", _file, _method);

        }

        void DDTNotIsGreaterThan<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.IfNot.Value.IsGreaterThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input.value, input.other, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThan", _file, _method);

        }

        void DDTNotIsGreaterThanT<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.IfNot.Value.IsGreaterThanT<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanT(input.value, input.other, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThan", _file, _method);

        }

        #endregion

        #region IsGreaterThanComparer

        [TestMethod]
        void IsGreaterThanComparer() {

            DDTIsGreaterThanComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanComparer((null, 0, new DummyComparer()), (2, false, "[Value = null; Other = '0']"));
            DDTIsGreaterThanComparer((0, null, new DummyComparer()), (3, true, "[Value = '0'; Other = null]"));
            DDTIsGreaterThanComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

            DDTIsGreaterThanComparer<Dummy>((0, 0, new DummyComparer()), (6, false, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanComparer<Dummy>((0, 1, new DummyComparer()), (7, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanComparer<Dummy>((1, 0, new DummyComparer()), (8, true, "[Value = '1'; Other = '0']"));

            DDTIsGreaterThanComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanComparer<Dummy>((null, 0, new DummyIComparer()), (10, false, "[Value = null; Other = '0']"));
            DDTIsGreaterThanComparer<Dummy>((0, null, new DummyIComparer()), (11, true, "[Value = '0'; Other = null]"));
            DDTIsGreaterThanComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

            DDTIsGreaterThanComparer<Dummy>((0, 0, new DummyIComparer()), (14, false, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanComparer<Dummy>((0, 1, new DummyIComparer()), (15, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanComparer<Dummy>((1, 0, new DummyIComparer()), (16, true, "[Value = '1'; Other = '0']"));

            DDTIsGreaterThanComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanComparer((null, 0, new DummyIComparerT()), (18, false, "[Value = null; Other = '0']"));
            DDTIsGreaterThanComparer((0, null, new DummyIComparerT()), (19, true, "[Value = '0'; Other = null]"));
            DDTIsGreaterThanComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

            DDTIsGreaterThanComparer((0, 0, new DummyIComparerT()), (22, false, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanComparer((0, 1, new DummyIComparerT()), (23, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanComparer((1, 0, new DummyIComparerT()), (24, true, "[Value = '1'; Other = '0']"));

        }

        void DDTIsGreaterThanComparer<T>((T value, T other, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsGreaterThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsGreaterThan", _file, _method);

        }

        void DDTIsGreaterThanComparer<T>((T value, T other, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsGreaterThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsGreaterThan", _file, _method);

        }

        void DDTIsGreaterThanComparer<T>((T value, T other, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsGreaterThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsGreaterThan", _file, _method);

        }

        [TestMethod]
        void NotIsGreaterThanComparer() {

            DDTNotIsGreaterThanComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanComparer((null, 0, new DummyComparer()), (2, true, "[Value = null; Other = '0']"));
            DDTNotIsGreaterThanComparer((0, null, new DummyComparer()), (3, false, "[Value = '0'; Other = null]"));
            DDTNotIsGreaterThanComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

            DDTNotIsGreaterThanComparer<Dummy>((0, 0, new DummyComparer()), (6, true, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanComparer<Dummy>((0, 1, new DummyComparer()), (7, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanComparer<Dummy>((1, 0, new DummyComparer()), (8, false, "[Value = '1'; Other = '0']"));

            DDTNotIsGreaterThanComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanComparer<Dummy>((null, 0, new DummyIComparer()), (10, true, "[Value = null; Other = '0']"));
            DDTNotIsGreaterThanComparer<Dummy>((0, null, new DummyIComparer()), (11, false, "[Value = '0'; Other = null]"));
            DDTNotIsGreaterThanComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

            DDTNotIsGreaterThanComparer<Dummy>((0, 0, new DummyIComparer()), (14, true, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanComparer<Dummy>((0, 1, new DummyIComparer()), (15, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanComparer<Dummy>((1, 0, new DummyIComparer()), (16, false, "[Value = '1'; Other = '0']"));

            DDTNotIsGreaterThanComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanComparer((null, 0, new DummyIComparerT()), (18, true, "[Value = null; Other = '0']"));
            DDTNotIsGreaterThanComparer((0, null, new DummyIComparerT()), (19, false, "[Value = '0'; Other = null]"));
            DDTNotIsGreaterThanComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

            DDTNotIsGreaterThanComparer((0, 0, new DummyIComparerT()), (22, true, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanComparer((0, 1, new DummyIComparerT()), (23, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanComparer((1, 0, new DummyIComparerT()), (24, false, "[Value = '1'; Other = '0']"));

        }

        void DDTNotIsGreaterThanComparer<T>((T value, T other, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsGreaterThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThan", _file, _method);

        }

        void DDTNotIsGreaterThanComparer<T>((T value, T other, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsGreaterThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThan", _file, _method);

        }

        void DDTNotIsGreaterThanComparer<T>((T value, T other, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsGreaterThan<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThan", _file, _method);

        }

        #endregion

        #region IsGreaterThanOrEqual

        [TestMethod]
        void IsGreaterThanOrEqual() {

            DDTIsGreaterThanOrEqual<DummyIComparable>((0, 0), (1, true, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanOrEqual<DummyIComparable>((0, 1), (2, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanOrEqual<DummyIComparable>((1, 0), (3, true, "[Value = '1'; Other = '0']"));

            DDTIsGreaterThanOrEqualT<DummyIComparableT>((0, 0), (4, true, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanOrEqualT<DummyIComparableT>((0, 1), (5, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanOrEqualT<DummyIComparableT>((1, 0), (6, true, "[Value = '1'; Other = '0']"));

            DDTNotIsGreaterThanOrEqual<DummyIComparable>((0, 0), (7, false, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanOrEqual<DummyIComparable>((0, 1), (8, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanOrEqual<DummyIComparable>((1, 0), (9, false, "[Value = '1'; Other = '0']"));

            DDTNotIsGreaterThanOrEqualT<DummyIComparableT>((0, 0), (10, false, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanOrEqualT<DummyIComparableT>((0, 1), (11, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanOrEqualT<DummyIComparableT>((1, 0), (12, false, "[Value = '1'; Other = '0']"));

        }

        void DDTIsGreaterThanOrEqual<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.If.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input.value, input.other, _file, _method),
                expected, "Test.If.Value.IsGreaterThanOrEqual", _file, _method);

        }

        void DDTIsGreaterThanOrEqualT<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.If.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqualT(input.value, input.other, _file, _method),
                expected, "Test.If.Value.IsGreaterThanOrEqual", _file, _method);

        }

        void DDTNotIsGreaterThanOrEqual<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.IfNot.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input.value, input.other, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual", _file, _method);

        }

        void DDTNotIsGreaterThanOrEqualT<T>((T value, T other) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.IfNot.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqualT(input.value, input.other, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual", _file, _method);

        }

        #endregion

        #region IsGreaterThanOrEqualComparer

        [TestMethod]
        void IsGreaterThanOrEqualComparer() {

            DDTIsGreaterThanOrEqualComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanOrEqualComparer((null, 0, new DummyComparer()), (2, false, "[Value = null; Other = '0']"));
            DDTIsGreaterThanOrEqualComparer((0, null, new DummyComparer()), (3, true, "[Value = '0'; Other = null]"));
            DDTIsGreaterThanOrEqualComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanOrEqualComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

            DDTIsGreaterThanOrEqualComparer<Dummy>((0, 0, new DummyComparer()), (6, true, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanOrEqualComparer<Dummy>((0, 1, new DummyComparer()), (7, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanOrEqualComparer<Dummy>((1, 0, new DummyComparer()), (8, true, "[Value = '1'; Other = '0']"));

            DDTIsGreaterThanOrEqualComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanOrEqualComparer<Dummy>((null, 0, new DummyIComparer()), (10, false, "[Value = null; Other = '0']"));
            DDTIsGreaterThanOrEqualComparer<Dummy>((0, null, new DummyIComparer()), (11, true, "[Value = '0'; Other = null]"));
            DDTIsGreaterThanOrEqualComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanOrEqualComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

            DDTIsGreaterThanOrEqualComparer<Dummy>((0, 0, new DummyIComparer()), (14, true, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanOrEqualComparer<Dummy>((0, 1, new DummyIComparer()), (15, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanOrEqualComparer<Dummy>((1, 0, new DummyIComparer()), (16, true, "[Value = '1'; Other = '0']"));

            DDTIsGreaterThanOrEqualComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanOrEqualComparer((null, 0, new DummyIComparerT()), (18, false, "[Value = null; Other = '0']"));
            DDTIsGreaterThanOrEqualComparer((0, null, new DummyIComparerT()), (19, true, "[Value = '0'; Other = null]"));
            DDTIsGreaterThanOrEqualComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
            DDTIsGreaterThanOrEqualComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

            DDTIsGreaterThanOrEqualComparer((0, 0, new DummyIComparerT()), (22, true, "[Value = '0'; Other = '0']"));
            DDTIsGreaterThanOrEqualComparer((0, 1, new DummyIComparerT()), (23, false, "[Value = '0'; Other = '1']"));
            DDTIsGreaterThanOrEqualComparer((1, 0, new DummyIComparerT()), (24, true, "[Value = '1'; Other = '0']"));

        }

        void DDTIsGreaterThanOrEqualComparer<T>((T value, T other, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsGreaterThanOrEqual", _file, _method);

        }

        void DDTIsGreaterThanOrEqualComparer<T>((T value, T other, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsGreaterThanOrEqual", _file, _method);

        }

        void DDTIsGreaterThanOrEqualComparer<T>((T value, T other, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.If.Value.IsGreaterThanOrEqual", _file, _method);

        }

        [TestMethod]
        void NotIsGreaterThanOrEqualComparer() {

            DDTNotIsGreaterThanOrEqualComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanOrEqualComparer((null, 0, new DummyComparer()), (2, true, "[Value = null; Other = '0']"));
            DDTNotIsGreaterThanOrEqualComparer((0, null, new DummyComparer()), (3, false, "[Value = '0'; Other = null]"));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, 0, new DummyComparer()), (6, false, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, 1, new DummyComparer()), (7, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((1, 0, new DummyComparer()), (8, false, "[Value = '1'; Other = '0']"));

            DDTNotIsGreaterThanOrEqualComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((null, 0, new DummyIComparer()), (10, true, "[Value = null; Other = '0']"));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, null, new DummyIComparer()), (11, false, "[Value = '0'; Other = null]"));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, 0, new DummyIComparer()), (14, false, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((0, 1, new DummyIComparer()), (15, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanOrEqualComparer<Dummy>((1, 0, new DummyIComparer()), (16, false, "[Value = '1'; Other = '0']"));

            DDTNotIsGreaterThanOrEqualComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanOrEqualComparer((null, 0, new DummyIComparerT()), (18, true, "[Value = null; Other = '0']"));
            DDTNotIsGreaterThanOrEqualComparer((0, null, new DummyIComparerT()), (19, false, "[Value = '0'; Other = null]"));
            DDTNotIsGreaterThanOrEqualComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
            DDTNotIsGreaterThanOrEqualComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

            DDTNotIsGreaterThanOrEqualComparer((0, 0, new DummyIComparerT()), (22, false, "[Value = '0'; Other = '0']"));
            DDTNotIsGreaterThanOrEqualComparer((0, 1, new DummyIComparerT()), (23, true, "[Value = '0'; Other = '1']"));
            DDTNotIsGreaterThanOrEqualComparer((1, 0, new DummyIComparerT()), (24, false, "[Value = '1'; Other = '0']"));

        }

        void DDTNotIsGreaterThanOrEqualComparer<T>((T value, T other, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual", _file, _method);

        }

        void DDTNotIsGreaterThanOrEqualComparer<T>((T value, T other, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual", _file, _method);

        }

        void DDTNotIsGreaterThanOrEqualComparer<T>((T value, T other, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsGreaterThanOrEqual<{typeof(T).Format()}>({input.value.Format()}, {input.other.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input.value, input.other, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual", _file, _method);

        }

        #endregion

        #region IsTrue

        [TestMethod]
        [TestParameters(true, 1, true, "[Value = 'True']")]
        [TestParameters(false, 2, false, "[Value = 'False']")]
        void True(Boolean input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsTrue(input),
                (count, result, message), "Test.If.Value.IsTrue");

        }

        [TestMethod]
        [TestParameters(true, 1, true, "[Value = 'True']")]
        [TestParameters(false, 2, false, "[Value = 'False']")]
        [TestParameters(null, 3, false, "Parameter 'value' is null.")]
        void TrueNullable(Boolean? input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsTrue(input),
                (count, result, message), "Test.If.Value.IsTrue");

        }

        [TestMethod]
        [TestParameters(true, 1, false, "[Value = 'True']")]
        [TestParameters(false, 2, true, "[Value = 'False']")]
        void NotTrue(Boolean input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsTrue(input),
                (count, result, message), "Test.IfNot.Value.IsTrue");

        }

        [TestMethod]
        [TestParameters(true, 1, false, "[Value = 'True']")]
        [TestParameters(false, 2, true, "[Value = 'False']")]
        [TestParameters(null, 3, false, "Parameter 'value' is null.")]
        void NotTrueNullable(Boolean? input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsTrue(input),
                (count, result, message), "Test.IfNot.Value.IsTrue");

        }

        #endregion

        #region IsFalse

        [TestMethod]
        [TestParameters(true, 1, false, "[Value = 'True']")]
        [TestParameters(false, 2, true, "[Value = 'False']")]
        void IsFalse(Boolean input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsFalse(input),
                (count, result, message), "Test.If.Value.IsFalse");

        }

        [TestMethod]
        [TestParameters(true, 1, false, "[Value = 'True']")]
        [TestParameters(false, 2, true, "[Value = 'False']")]
        [TestParameters(null, 3, false, "Parameter 'value' is null.")]
        void IsFalseNullable(Boolean? input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsFalse(input),
                (count, result, message), "Test.If.Value.IsFalse");

        }

        [TestMethod]
        [TestParameters(true, 1, true, "[Value = 'True']")]
        [TestParameters(false, 2, false, "[Value = 'False']")]
        void NotFalse(Boolean input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsFalse(input),
                (count, result, message), "Test.IfNot.Value.IsFalse");

        }

        [TestMethod]
        [TestParameters(true, 1, true, "[Value = 'True']")]
        [TestParameters(false, 2, false, "[Value = 'False']")]
        [TestParameters(null, 3, false, "Parameter 'value' is null.")]
        void NotFalseNullable(Boolean? input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsFalse(input),
                (count, result, message), "Test.IfNot.Value.IsFalse");

        }

        #endregion

        #region IsClamped

        [TestMethod]
        void IsClamped() {

            DDTIsClamped<DummyIComparable>((null, null, null), (1, false, "Parameter 'value' is null."));
            DDTIsClamped<DummyIComparable>((null, 0, 0), (2, false, "Parameter 'value' is null."));
            DDTIsClamped<DummyIComparable>((0, null, 0), (3, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClamped<DummyIComparable>((0, 0, null), (4, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClamped<DummyIComparable>((0, 0, 0), (5, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClamped<DummyIComparable>((0, -1, 1), (6, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClamped<DummyIComparable>((0, 1, -1), (7, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClamped<DummyIComparable>((0, 0, 1), (8, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClamped<DummyIComparable>((0, -1, 0), (9, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClamped<DummyIComparable>((0, 1, 2), (10, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClamped<DummyIComparable>((0, -2, -1), (11, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTIsClampedT<DummyIComparableT>((null, null, null), (12, false, "Parameter 'value' is null."));
            DDTIsClampedT<DummyIComparableT>((null, 0, 0), (13, false, "Parameter 'value' is null."));
            DDTIsClampedT<DummyIComparableT>((0, null, 0), (14, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedT<DummyIComparableT>((0, 0, null), (15, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedT<DummyIComparableT>((0, 0, 0), (16, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedT<DummyIComparableT>((0, -1, 1), (17, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedT<DummyIComparableT>((0, 1, -1), (18, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedT<DummyIComparableT>((0, 0, 1), (19, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedT<DummyIComparableT>((0, -1, 0), (20, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedT<DummyIComparableT>((0, 1, 2), (21, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedT<DummyIComparableT>((0, -2, -1), (22, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        }

        void DDTIsClamped<T>((T value, T min, T max) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.If.Value.IsClamped<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input.value, input.min, input.max, _file, _method),
                expected, "Test.If.Value.IsClamped", _file, _method);

        }

        void DDTIsClampedT<T>((T value, T min, T max) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.If.Value.IsClampedT<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedT(input.value, input.min, input.max, _file, _method),
                expected, "Test.If.Value.IsClamped", _file, _method);

        }

        [TestMethod]
        void NotIsClamped() {

            DDTNotIsClamped<DummyIComparable>((null, null, null), (1, false, "Parameter 'value' is null."));
            DDTNotIsClamped<DummyIComparable>((null, 0, 0), (2, false, "Parameter 'value' is null."));
            DDTNotIsClamped<DummyIComparable>((0, null, 0), (3, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClamped<DummyIComparable>((0, 0, null), (4, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClamped<DummyIComparable>((0, 0, 0), (5, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClamped<DummyIComparable>((0, -1, 1), (6, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClamped<DummyIComparable>((0, 1, -1), (7, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClamped<DummyIComparable>((0, 0, 1), (8, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClamped<DummyIComparable>((0, -1, 0), (9, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClamped<DummyIComparable>((0, 1, 2), (10, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClamped<DummyIComparable>((0, -2, -1), (11, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTNotIsClampedT<DummyIComparableT>((null, null, null), (12, false, "Parameter 'value' is null."));
            DDTNotIsClampedT<DummyIComparableT>((null, 0, 0), (13, false, "Parameter 'value' is null."));
            DDTNotIsClampedT<DummyIComparableT>((0, null, 0), (14, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedT<DummyIComparableT>((0, 0, null), (15, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedT<DummyIComparableT>((0, 0, 0), (16, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedT<DummyIComparableT>((0, -1, 1), (17, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedT<DummyIComparableT>((0, 1, -1), (18, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedT<DummyIComparableT>((0, 0, 1), (19, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedT<DummyIComparableT>((0, -1, 0), (20, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedT<DummyIComparableT>((0, 1, 2), (21, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedT<DummyIComparableT>((0, -2, -1), (22, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        }

        void DDTNotIsClamped<T>((T value, T min, T max) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.IfNot.Value.IsClamped<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input.value, input.min, input.max, _file, _method),
                expected, "Test.IfNot.Value.IsClamped", _file, _method);

        }

        void DDTNotIsClampedT<T>((T value, T min, T max) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.IfNot.Value.IsClampedT<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedT(input.value, input.min, input.max, _file, _method),
                expected, "Test.IfNot.Value.IsClamped", _file, _method);

        }

        #endregion

        #region IsClampedComparer

        [TestMethod]
        void IsClampedComparer() {

            DDTIsClampedComparer<Dummy>((null, null, null, null), (1, false, "Parameter 'value' is null."));
            DDTIsClampedComparer((null, 0, 0, new DummyComparer()), (2, false, "Parameter 'value' is null."));
            DDTIsClampedComparer((0, null, 0, new DummyComparer()), (3, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedComparer((0, 0, null, new DummyComparer()), (4, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedComparer<Dummy>((0, 0, 0, null), (5, false, "Parameter 'comparer' is null."));
            DDTIsClampedComparer<Dummy>((0, 0, 0, new ThrowingComparer()), (6, false, "Comparer threw Exception:"));

            DDTIsClampedComparer<Dummy>((0, 0, 0, new DummyComparer()), (7, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedComparer<Dummy>((0, -1, 1, new DummyComparer()), (8, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedComparer<Dummy>((0, 1, -1, new DummyComparer()), (9, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedComparer<Dummy>((0, 0, 1, new DummyComparer()), (10, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedComparer<Dummy>((0, -1, 0, new DummyComparer()), (11, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedComparer<Dummy>((0, 1, 2, new DummyComparer()), (12, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedComparer<Dummy>((0, -2, -1, new DummyComparer()), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTIsClampedComparer<Dummy>((null, null, null, (IComparer) null), (14, false, "Parameter 'value' is null."));
            DDTIsClampedComparer<Dummy>((null, 0, 0, new DummyIComparer()), (15, false, "Parameter 'value' is null."));
            DDTIsClampedComparer<Dummy>((0, null, 0, new DummyIComparer()), (16, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedComparer<Dummy>((0, 0, null, new DummyIComparer()), (17, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedComparer<Dummy>((0, 0, 0, (IComparer) null), (18, false, "Parameter 'comparer' is null."));
            DDTIsClampedComparer<Dummy>((0, 0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (19, false, "Comparer threw Exception:"));

            DDTIsClampedComparer<Dummy>((0, 0, 0, new DummyIComparer()), (20, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedComparer<Dummy>((0, -1, 1, new DummyIComparer()), (21, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedComparer<Dummy>((0, 1, -1, new DummyIComparer()), (22, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedComparer<Dummy>((0, 0, 1, new DummyIComparer()), (23, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedComparer<Dummy>((0, -1, 0, new DummyIComparer()), (24, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedComparer<Dummy>((0, 1, 2, new DummyIComparer()), (25, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedComparer<Dummy>((0, -2, -1, new DummyIComparer()), (26, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTIsClampedComparer((null, null, null, (IComparer<Dummy>) null), (27, false, "Parameter 'value' is null."));
            DDTIsClampedComparer((null, 0, 0, new DummyIComparerT()), (28, false, "Parameter 'value' is null."));
            DDTIsClampedComparer((0, null, 0, new DummyIComparerT()), (29, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedComparer((0, 0, null, new DummyIComparerT()), (30, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedComparer((0, 0, 0, (IComparer<Dummy>) null), (31, false, "Parameter 'comparer' is null."));
            DDTIsClampedComparer((0, 0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (32, false, "Comparer threw Exception:"));

            DDTIsClampedComparer((0, 0, 0, new DummyIComparerT()), (33, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedComparer((0, -1, 1, new DummyIComparerT()), (34, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedComparer((0, 1, -1, new DummyIComparerT()), (35, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedComparer((0, 0, 1, new DummyIComparerT()), (36, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedComparer((0, -1, 0, new DummyIComparerT()), (37, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedComparer((0, 1, 2, new DummyIComparerT()), (38, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedComparer((0, -2, -1, new DummyIComparerT()), (39, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        }

        void DDTIsClampedComparer<T>((T value, T min, T max, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsClamped<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.If.Value.IsClamped", _file, _method);

        }

        void DDTIsClampedComparer<T>((T value, T min, T max, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsClamped<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.If.Value.IsClamped", _file, _method);

        }

        void DDTIsClampedComparer<T>((T value, T min, T max, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsClamped<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.If.Value.IsClamped", _file, _method);

        }

        [TestMethod]
        void NotIsClampedComparer() {

            DDTNotIsClampedComparer<Dummy>((null, null, null, null), (1, false, "Parameter 'value' is null."));
            DDTNotIsClampedComparer((null, 0, 0, new DummyComparer()), (2, false, "Parameter 'value' is null."));
            DDTNotIsClampedComparer((0, null, 0, new DummyComparer()), (3, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedComparer((0, 0, null, new DummyComparer()), (4, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedComparer<Dummy>((0, 0, 0, null), (5, false, "Parameter 'comparer' is null."));
            DDTNotIsClampedComparer<Dummy>((0, 0, 0, new ThrowingComparer()), (6, false, "Comparer threw Exception:"));

            DDTNotIsClampedComparer<Dummy>((0, 0, 0, new DummyComparer()), (7, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedComparer<Dummy>((0, -1, 1, new DummyComparer()), (8, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedComparer<Dummy>((0, 1, -1, new DummyComparer()), (9, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedComparer<Dummy>((0, 0, 1, new DummyComparer()), (10, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedComparer<Dummy>((0, -1, 0, new DummyComparer()), (11, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedComparer<Dummy>((0, 1, 2, new DummyComparer()), (12, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedComparer<Dummy>((0, -2, -1, new DummyComparer()), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTNotIsClampedComparer<Dummy>((null, null, null, (IComparer) null), (14, false, "Parameter 'value' is null."));
            DDTNotIsClampedComparer<Dummy>((null, 0, 0, new DummyIComparer()), (15, false, "Parameter 'value' is null."));
            DDTNotIsClampedComparer<Dummy>((0, null, 0, new DummyIComparer()), (16, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedComparer<Dummy>((0, 0, null, new DummyIComparer()), (17, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedComparer<Dummy>((0, 0, 0, (IComparer) null), (18, false, "Parameter 'comparer' is null."));
            DDTNotIsClampedComparer<Dummy>((0, 0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (19, false, "Comparer threw Exception:"));

            DDTNotIsClampedComparer<Dummy>((0, 0, 0, new DummyIComparer()), (20, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedComparer<Dummy>((0, -1, 1, new DummyIComparer()), (21, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedComparer<Dummy>((0, 1, -1, new DummyIComparer()), (22, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedComparer<Dummy>((0, 0, 1, new DummyIComparer()), (23, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedComparer<Dummy>((0, -1, 0, new DummyIComparer()), (24, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedComparer<Dummy>((0, 1, 2, new DummyIComparer()), (25, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedComparer<Dummy>((0, -2, -1, new DummyIComparer()), (26, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTNotIsClampedComparer((null, null, null, (IComparer<Dummy>) null), (27, false, "Parameter 'value' is null."));
            DDTNotIsClampedComparer((null, 0, 0, new DummyIComparerT()), (28, false, "Parameter 'value' is null."));
            DDTNotIsClampedComparer((0, null, 0, new DummyIComparerT()), (29, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedComparer((0, 0, null, new DummyIComparerT()), (30, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedComparer((0, 0, 0, (IComparer<Dummy>) null), (31, false, "Parameter 'comparer' is null."));
            DDTNotIsClampedComparer((0, 0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (32, false, "Comparer threw Exception:"));

            DDTNotIsClampedComparer((0, 0, 0, new DummyIComparerT()), (33, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedComparer((0, -1, 1, new DummyIComparerT()), (34, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedComparer((0, 1, -1, new DummyIComparerT()), (35, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedComparer((0, 0, 1, new DummyIComparerT()), (36, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedComparer((0, -1, 0, new DummyIComparerT()), (37, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedComparer((0, 1, 2, new DummyIComparerT()), (38, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedComparer((0, -2, -1, new DummyIComparerT()), (39, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        }

        void DDTNotIsClampedComparer<T>((T value, T min, T max, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsClamped<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsClamped", _file, _method);

        }

        void DDTNotIsClampedComparer<T>((T value, T min, T max, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsClamped<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsClamped", _file, _method);

        }

        void DDTNotIsClampedComparer<T>((T value, T min, T max, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsClamped<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsClamped", _file, _method);

        }

        #endregion

        #region IsClampedExclusive

        [TestMethod]
        void IsClampedExclusive() {

            DDTIsClampedExclusive<DummyIComparable>((null, null, null), (1, false, "Parameter 'value' is null."));
            DDTIsClampedExclusive<DummyIComparable>((null, 0, 0), (2, false, "Parameter 'value' is null."));
            DDTIsClampedExclusive<DummyIComparable>((0, null, 0), (3, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedExclusive<DummyIComparable>((0, 0, null), (4, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedExclusive<DummyIComparable>((0, 0, 0), (5, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedExclusive<DummyIComparable>((0, -1, 1), (6, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedExclusive<DummyIComparable>((0, 1, -1), (7, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedExclusive<DummyIComparable>((0, 0, 1), (8, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedExclusive<DummyIComparable>((0, -1, 0), (9, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedExclusive<DummyIComparable>((0, 1, 2), (10, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedExclusive<DummyIComparable>((0, -2, -1), (11, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTIsClampedExclusiveT<DummyIComparableT>((null, null, null), (12, false, "Parameter 'value' is null."));
            DDTIsClampedExclusiveT<DummyIComparableT>((null, 0, 0), (13, false, "Parameter 'value' is null."));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, null, 0), (14, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, 0, null), (15, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, 0, 0), (16, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, -1, 1), (17, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, 1, -1), (18, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, 0, 1), (19, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, -1, 0), (20, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, 1, 2), (21, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedExclusiveT<DummyIComparableT>((0, -2, -1), (22, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        }

        void DDTIsClampedExclusive<T>((T value, T min, T max) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.If.Value.IsClampedExclusive<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input.value, input.min, input.max, _file, _method),
                expected, "Test.If.Value.IsClampedExclusive", _file, _method);

        }

        void DDTIsClampedExclusiveT<T>((T value, T min, T max) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.If.Value.IsClampedExclusiveT<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusiveT(input.value, input.min, input.max, _file, _method),
                expected, "Test.If.Value.IsClampedExclusive", _file, _method);

        }

        [TestMethod]
        void NotIsClampedExclusive() {

            DDTNotIsClampedExclusive<DummyIComparable>((null, null, null), (1, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusive<DummyIComparable>((null, 0, 0), (2, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusive<DummyIComparable>((0, null, 0), (3, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedExclusive<DummyIComparable>((0, 0, null), (4, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedExclusive<DummyIComparable>((0, 0, 0), (5, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedExclusive<DummyIComparable>((0, -1, 1), (6, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedExclusive<DummyIComparable>((0, 1, -1), (7, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedExclusive<DummyIComparable>((0, 0, 1), (8, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedExclusive<DummyIComparable>((0, -1, 0), (9, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedExclusive<DummyIComparable>((0, 1, 2), (10, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedExclusive<DummyIComparable>((0, -2, -1), (11, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTNotIsClampedExclusiveT<DummyIComparableT>((null, null, null), (12, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((null, 0, 0), (13, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, null, 0), (14, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, 0, null), (15, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, 0, 0), (16, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, -1, 1), (17, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, 1, -1), (18, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, 0, 1), (19, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, -1, 0), (20, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, 1, 2), (21, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedExclusiveT<DummyIComparableT>((0, -2, -1), (22, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        }

        void DDTNotIsClampedExclusive<T>((T value, T min, T max) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable {

            Test.Note($"Test.IfNot.Value.IsClampedExclusive<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input.value, input.min, input.max, _file, _method),
                expected, "Test.IfNot.Value.IsClampedExclusive", _file, _method);

        }

        void DDTNotIsClampedExclusiveT<T>((T value, T min, T max) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> {

            Test.Note($"Test.IfNot.Value.IsClampedExclusiveT<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusiveT(input.value, input.min, input.max, _file, _method),
                expected, "Test.IfNot.Value.IsClampedExclusive", _file, _method);

        }

        #endregion

        #region IsClampedExclusiveComparer

        [TestMethod]
        void IsClampedExclusiveComparer() {

            DDTIsClampedExclusiveComparer<Dummy>((null, null, null, null), (1, false, "Parameter 'value' is null."));
            DDTIsClampedExclusiveComparer((null, 0, 0, new DummyComparer()), (2, false, "Parameter 'value' is null."));
            DDTIsClampedExclusiveComparer((0, null, 0, new DummyComparer()), (3, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedExclusiveComparer((0, 0, null, new DummyComparer()), (4, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 0, 0, null), (5, false, "Parameter 'comparer' is null."));
            DDTIsClampedExclusiveComparer<Dummy>((0, 0, 0, new ThrowingComparer()), (6, false, "Comparer threw Exception:"));

            DDTIsClampedExclusiveComparer<Dummy>((0, 0, 0, new DummyComparer()), (7, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, -1, 1, new DummyComparer()), (8, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 1, -1, new DummyComparer()), (9, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 0, 1, new DummyComparer()), (10, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, -1, 0, new DummyComparer()), (11, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 1, 2, new DummyComparer()), (12, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, -2, -1, new DummyComparer()), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTIsClampedExclusiveComparer<Dummy>((null, null, null, (IComparer) null), (14, false, "Parameter 'value' is null."));
            DDTIsClampedExclusiveComparer<Dummy>((null, 0, 0, new DummyIComparer()), (15, false, "Parameter 'value' is null."));
            DDTIsClampedExclusiveComparer<Dummy>((0, null, 0, new DummyIComparer()), (16, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 0, null, new DummyIComparer()), (17, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 0, 0, (IComparer) null), (18, false, "Parameter 'comparer' is null."));
            DDTIsClampedExclusiveComparer<Dummy>((0, 0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (19, false, "Comparer threw Exception:"));

            DDTIsClampedExclusiveComparer<Dummy>((0, 0, 0, new DummyIComparer()), (20, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, -1, 1, new DummyIComparer()), (21, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 1, -1, new DummyIComparer()), (22, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 0, 1, new DummyIComparer()), (23, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, -1, 0, new DummyIComparer()), (24, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, 1, 2, new DummyIComparer()), (25, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedExclusiveComparer<Dummy>((0, -2, -1, new DummyIComparer()), (26, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTIsClampedExclusiveComparer((null, null, null, (IComparer<Dummy>) null), (27, false, "Parameter 'value' is null."));
            DDTIsClampedExclusiveComparer((null, 0, 0, new DummyIComparerT()), (28, false, "Parameter 'value' is null."));
            DDTIsClampedExclusiveComparer((0, null, 0, new DummyIComparerT()), (29, false, "[Value = '0'; Min = null; Max = '0']"));
            DDTIsClampedExclusiveComparer((0, 0, null, new DummyIComparerT()), (30, false, "[Value = '0'; Min = '0'; Max = null]"));
            DDTIsClampedExclusiveComparer((0, 0, 0, (IComparer<Dummy>) null), (31, false, "Parameter 'comparer' is null."));
            DDTIsClampedExclusiveComparer((0, 0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (32, false, "Comparer threw Exception:"));

            DDTIsClampedExclusiveComparer((0, 0, 0, new DummyIComparerT()), (33, false, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTIsClampedExclusiveComparer((0, -1, 1, new DummyIComparerT()), (34, true, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTIsClampedExclusiveComparer((0, 1, -1, new DummyIComparerT()), (35, true, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTIsClampedExclusiveComparer((0, 0, 1, new DummyIComparerT()), (36, false, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTIsClampedExclusiveComparer((0, -1, 0, new DummyIComparerT()), (37, false, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTIsClampedExclusiveComparer((0, 1, 2, new DummyIComparerT()), (38, false, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTIsClampedExclusiveComparer((0, -2, -1, new DummyIComparerT()), (39, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        }

        void DDTIsClampedExclusiveComparer<T>((T value, T min, T max, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsClampedExclusive<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.If.Value.IsClampedExclusive", _file, _method);

        }

        void DDTIsClampedExclusiveComparer<T>((T value, T min, T max, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsClampedExclusive<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.If.Value.IsClampedExclusive", _file, _method);

        }

        void DDTIsClampedExclusiveComparer<T>((T value, T min, T max, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsClampedExclusive<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.If.Value.IsClampedExclusive", _file, _method);

        }

        [TestMethod]
        void NotIsClampedExclusiveComparer() {

            DDTNotIsClampedExclusiveComparer<Dummy>((null, null, null, null), (1, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusiveComparer((null, 0, 0, new DummyComparer()), (2, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusiveComparer((0, null, 0, new DummyComparer()), (3, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedExclusiveComparer((0, 0, null, new DummyComparer()), (4, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, 0, null), (5, false, "Parameter 'comparer' is null."));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, 0, new ThrowingComparer()), (6, false, "Comparer threw Exception:"));

            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, 0, new DummyComparer()), (7, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, -1, 1, new DummyComparer()), (8, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 1, -1, new DummyComparer()), (9, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, 1, new DummyComparer()), (10, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, -1, 0, new DummyComparer()), (11, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 1, 2, new DummyComparer()), (12, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, -2, -1, new DummyComparer()), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTNotIsClampedExclusiveComparer<Dummy>((null, null, null, (IComparer) null), (14, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusiveComparer<Dummy>((null, 0, 0, new DummyIComparer()), (15, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, null, 0, new DummyIComparer()), (16, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, null, new DummyIComparer()), (17, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, 0, (IComparer) null), (18, false, "Parameter 'comparer' is null."));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (19, false, "Comparer threw Exception:"));

            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, 0, new DummyIComparer()), (20, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, -1, 1, new DummyIComparer()), (21, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 1, -1, new DummyIComparer()), (22, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 0, 1, new DummyIComparer()), (23, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, -1, 0, new DummyIComparer()), (24, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, 1, 2, new DummyIComparer()), (25, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedExclusiveComparer<Dummy>((0, -2, -1, new DummyIComparer()), (26, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

            DDTNotIsClampedExclusiveComparer((null, null, null, (IComparer<Dummy>) null), (27, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusiveComparer((null, 0, 0, new DummyIComparerT()), (28, false, "Parameter 'value' is null."));
            DDTNotIsClampedExclusiveComparer((0, null, 0, new DummyIComparerT()), (29, true, "[Value = '0'; Min = null; Max = '0']"));
            DDTNotIsClampedExclusiveComparer((0, 0, null, new DummyIComparerT()), (30, true, "[Value = '0'; Min = '0'; Max = null]"));
            DDTNotIsClampedExclusiveComparer((0, 0, 0, (IComparer<Dummy>) null), (31, false, "Parameter 'comparer' is null."));
            DDTNotIsClampedExclusiveComparer((0, 0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (32, false, "Comparer threw Exception:"));

            DDTNotIsClampedExclusiveComparer((0, 0, 0, new DummyIComparerT()), (33, true, "[Value = '0'; Min = '0'; Max = '0']"));
            DDTNotIsClampedExclusiveComparer((0, -1, 1, new DummyIComparerT()), (34, false, "[Value = '0'; Min = '-1'; Max = '1']"));
            DDTNotIsClampedExclusiveComparer((0, 1, -1, new DummyIComparerT()), (35, false, "[Value = '0'; Min = '1'; Max = '-1']"));
            DDTNotIsClampedExclusiveComparer((0, 0, 1, new DummyIComparerT()), (36, true, "[Value = '0'; Min = '0'; Max = '1']"));
            DDTNotIsClampedExclusiveComparer((0, -1, 0, new DummyIComparerT()), (37, true, "[Value = '0'; Min = '-1'; Max = '0']"));
            DDTNotIsClampedExclusiveComparer((0, 1, 2, new DummyIComparerT()), (38, true, "[Value = '0'; Min = '1'; Max = '2']"));
            DDTNotIsClampedExclusiveComparer((0, -2, -1, new DummyIComparerT()), (39, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        }

        void DDTNotIsClampedExclusiveComparer<T>((T value, T min, T max, Comparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsClampedExclusive<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsClampedExclusive", _file, _method);

        }

        void DDTNotIsClampedExclusiveComparer<T>((T value, T min, T max, IComparer comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsClampedExclusive<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsClampedExclusive", _file, _method);

        }

        void DDTNotIsClampedExclusiveComparer<T>((T value, T min, T max, IComparer<T> comparer) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsClampedExclusive<{typeof(T).Format()}>({input.value.Format()}, {input.min.Format()}, {input.max.Format()}, {input.comparer.FormatType()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input.value, input.min, input.max, input.comparer, _file, _method),
                expected, "Test.IfNot.Value.IsClampedExclusive", _file, _method);

        }

        #endregion

    }
}
