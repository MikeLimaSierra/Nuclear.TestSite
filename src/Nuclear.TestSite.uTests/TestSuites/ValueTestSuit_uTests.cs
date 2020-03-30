using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Ntt;

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
        [TestData(nameof(IsEqualComparerData))]
        void IsEqualComparer<T>(T input1, T input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyEqualityComparer(), (2, false, "('DummyEqualityComparer') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyEqualityComparer(), (3, false, "('DummyEqualityComparer') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyEqualityComparer(), (5, false, "('DummyEqualityComparer') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyEqualityComparer(), (6, true, "('DummyEqualityComparer') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingEqualityComparer(), (7, false, "Comparison threw Exception:") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualComparerData))]
        void NotIsEqualComparer<T>(T input1, T input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyEqualityComparer(), (2, true, "('DummyEqualityComparer') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyEqualityComparer(), (3, true, "('DummyEqualityComparer') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyEqualityComparer(), (5, true, "('DummyEqualityComparer') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyEqualityComparer(), (6, false, "('DummyEqualityComparer') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingEqualityComparer(), (7, false, "Comparison threw Exception:") },
            };
        }

        #endregion

        #region IsEqualIComparer

        [TestMethod]
        [TestData(nameof(IsEqualIComparerData))]
        void IsEqualIComparer<T>(T input1, T input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualIComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIEqualityComparer(), (2, false, "('InternalEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIEqualityComparer(), (3, false, "('InternalEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyIEqualityComparer(), (5, false, "('InternalEqualityComparer`1') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyIEqualityComparer(), (6, true, "('InternalEqualityComparer`1') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingIEqualityComparer(), (7, false, "Comparison threw Exception:") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualIComparerData))]
        void NotIsEqualIComparer<T>(T input1, T input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualIComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIEqualityComparer(), (2, true, "('InternalEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIEqualityComparer(), (3, true, "('InternalEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyIEqualityComparer(), (5, true, "('InternalEqualityComparer`1') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyIEqualityComparer(), (6, false, "('InternalEqualityComparer`1') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingIEqualityComparer(), (7, false, "Comparison threw Exception:") },
            };
        }

        #endregion

        #region IsEqualIComparerT

        [TestMethod]
        [TestData(nameof(IsEqualIComparerTData))]
        void IsEqualIComparerT<T>(T input1, T input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualIComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIEqualityComparerT(), (2, false, "('DummyIEqualityComparerT') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIEqualityComparerT(), (3, false, "('DummyIEqualityComparerT') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyIEqualityComparerT(), (5, false, "('DummyIEqualityComparerT') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyIEqualityComparerT(), (6, true, "('DummyIEqualityComparerT') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingIEqualityComparerT(), (7, false, "Comparison threw Exception:") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualIComparerTData))]
        void NotIsEqualIComparerT<T>(T input1, T input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualIComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIEqualityComparerT(), (2, true, "('DummyIEqualityComparerT') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIEqualityComparerT(), (3, true, "('DummyIEqualityComparerT') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyIEqualityComparerT(), (5, true, "('DummyIEqualityComparerT') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyIEqualityComparerT(), (6, false, "('DummyIEqualityComparerT') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingIEqualityComparerT(), (7, false, "Comparison threw Exception:") },
            };
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
        [TestParameters(1f, 0f, 1, true, "[Left = '1'; Right = '0'; Margin = '1E-12']")]
        [TestParameters(1f, 1f, 2, false, "[Left = '1'; Right = '1'; Margin = '1E-12']")]
        [TestParameters(1e-11f, 1.1e-11f, 3, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-12']")]
        [TestParameters(1e-12f, 1.1e-12f, 4, false, "[Left = '1E-12'; Right = '1.1E-12'; Margin = '1E-12']")]
        void NotIsEqualSingle(Single input1, Single input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2),
                (count, result, message), "Test.IfNot.Value.IsEqual");

        }

        #endregion

        #region IsEqualSingleMargin

        [TestMethod]
        [TestParameters(1e-11f, 1.1e-11f, 1e-11f, 1, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-11']")]
        void IsEqualSingleMargin(Single input1, Single input2, Single input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3),
                (count, result, message), "Test.If.Value.IsEqual");

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
        [TestParameters(1d, 0d, 1, true, "[Left = '1'; Right = '0'; Margin = '1E-12']")]
        [TestParameters(1d, 1d, 2, false, "[Left = '1'; Right = '1'; Margin = '1E-12']")]
        [TestParameters(1e-11d, 1.1e-11d, 3, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-12']")]
        [TestParameters(1e-12d, 1.1e-12d, 4, false, "[Left = '1E-12'; Right = '1.1E-12'; Margin = '1E-12']")]
        void NotIsEqualDouble(Double input1, Double input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2),
                (count, result, message), "Test.IfNot.Value.IsEqual");

        }

        #endregion

        #region IsEqualDoubleMargin

        [TestMethod]
        [TestParameters(1e-11d, 1.1e-11d, 1e-11d, 1, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-11']")]
        void IsEqualDoubleMargin(Double input1, Double input2, Double input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3),
                (count, result, message), "Test.If.Value.IsEqual");

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
        [TestData(nameof(IsLessThanData))]
        void IsLessThan<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input1, input2),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), (1, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), (2, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), (3, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanData))]
        void NotIsLessThan<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input1, input2),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), (2, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), (3, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanT

        [TestMethod]
        [TestData(nameof(IsLessThanTData))]
        void IsLessThanT<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanT(input1, input2),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), (1, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), (2, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), (3, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanTData))]
        void NotIsLessThanT<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanT(input1, input2),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), (2, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), (3, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanComparer

        [TestMethod]
        [TestData(nameof(IsLessThanComparerData))]
        void IsLessThanComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input1, input2, input3),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyComparer(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyComparer(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanComparerData))]
        void NotIsLessThanComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input1, input2, input3),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyComparer(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyComparer(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanIComparer

        [TestMethod]
        [TestData(nameof(IsLessThanIComparerData))]
        void IsLessThanIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input1, input2, input3),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanIComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparer(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparer(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanIComparerData))]
        void NotIsLessThanIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input1, input2, input3),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanIComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparer(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparer(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanIComparerT

        [TestMethod]
        [TestData(nameof(IsLessThanIComparerTData))]
        void IsLessThanIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input1, input2, input3),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanIComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparerT(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparerT(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanIComparerTData))]
        void NotIsLessThanIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input1, input2, input3),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanIComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparerT(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparerT(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanOrEqual

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualData))]
        void IsLessThanOrEqual<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input1, input2),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), (2, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), (3, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualData))]
        void NotIsLessThanOrEqual<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input1, input2),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), (1, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), (2, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), (3, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanOrEqualT

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualTData))]
        void IsLessThanOrEqualT<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqualT(input1, input2),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), (2, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), (3, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualTData))]
        void NotIsLessThanOrEqualT<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqualT(input1, input2),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), (1, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), (2, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), (3, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanOrEqualComparer

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualComparerData))]
        void IsLessThanOrEqualComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input1, input2, input3),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyComparer(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyComparer(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualComparerData))]
        void NotIsLessThanOrEqualComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyComparer(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyComparer(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanOrEqualIComparer

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualIComparerData))]
        void IsLessThanOrEqualIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input1, input2, input3),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualIComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparer(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparer(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualIComparerData))]
        void NotIsLessThanOrEqualIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualIComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparer(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparer(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsLessThanOrEqualIComparerT

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualIComparerTData))]
        void IsLessThanOrEqualIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input1, input2, input3),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualIComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparerT(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparerT(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualIComparerTData))]
        void NotIsLessThanOrEqualIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualIComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparerT(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparerT(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsGreaterThan

        [TestMethod]
        [TestData(nameof(IsGreaterThanData))]
        void IsGreaterThan<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input1, input2),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), (1, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), (2, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), (3, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanData))]
        void NotIsGreaterThan<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input1, input2),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), (2, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), (3, false, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsGreaterThanT

        [TestMethod]
        [TestData(nameof(IsGreaterThanTData))]
        void IsGreaterThanT<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanT(input1, input2),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), (1, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), (2, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), (3, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanTData))]
        void NotIsGreaterThanT<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanT(input1, input2),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), (2, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), (3, false, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsGreaterThanComparer

        [TestMethod]
        [TestData(nameof(IsGreaterThanComparerData))]
        void IsGreaterThanComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input1, input2, input3),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyComparer(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyComparer(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanComparerData))]
        void NotIsGreaterThanComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyComparer(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyComparer(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsGreaterThanIComparer

        [TestMethod]
        [TestData(nameof(IsGreaterThanIComparerData))]
        void IsGreaterThanIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input1, input2, input3),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanIComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparer(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparer(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanIComparerData))]
        void NotIsGreaterThanIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanIComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparer(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparer(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsGreaterThanIComparerT

        [TestMethod]
        [TestData(nameof(IsGreaterThanIComparerTData))]
        void IsGreaterThanIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input1, input2, input3),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanIComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparerT(), (2, false, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparerT(), (3, true, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), (6, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), (7, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), (8, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanIComparerTData))]
        void NotIsGreaterThanIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanIComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new DummyIComparerT(), (2, true, "[Value = null; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new DummyIComparerT(), (3, false, "[Value = '0'; Other = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), (6, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), (7, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), (8, false, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsGreaterThanOrEqual

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualData))]
        void IsGreaterThanOrEqual<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), (2, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), (3, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualData))]
        void NotIsGreaterThanOrEqual<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), (1, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), (2, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), (3, false, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        #region IsGreaterThanOrEqualT

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualTData))]
        void IsGreaterThanOrEqualT<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqualT(input1, input2),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), (2, false, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), (3, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualTData))]
        void NotIsGreaterThanOrEqualT<T>(T input1, T input2, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqualT(input1, input2),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), (1, false, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), (2, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), (3, false, "[Value = '1'; Other = '0']") },
            };
        }

        #endregion

        //[TestMethod]
        //void IsGreaterThanOrEqualComparer() {

        //    IsGreaterThanOrEqualComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
        //    IsGreaterThanOrEqualComparer((null, 0, new DummyComparer()), (2, false, "[Value = null; Other = '0']"));
        //    IsGreaterThanOrEqualComparer((0, null, new DummyComparer()), (3, true, "[Value = '0'; Other = null]"));
        //    IsGreaterThanOrEqualComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
        //    IsGreaterThanOrEqualComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

        //    IsGreaterThanOrEqualComparer<Dummy>((0, 0, new DummyComparer()), (6, true, "[Value = '0'; Other = '0']"));
        //    IsGreaterThanOrEqualComparer<Dummy>((0, 1, new DummyComparer()), (7, false, "[Value = '0'; Other = '1']"));
        //    IsGreaterThanOrEqualComparer<Dummy>((1, 0, new DummyComparer()), (8, true, "[Value = '1'; Other = '0']"));

        //    IsGreaterThanOrEqualComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
        //    IsGreaterThanOrEqualComparer<Dummy>((null, 0, new DummyIComparer()), (10, false, "[Value = null; Other = '0']"));
        //    IsGreaterThanOrEqualComparer<Dummy>((0, null, new DummyIComparer()), (11, true, "[Value = '0'; Other = null]"));
        //    IsGreaterThanOrEqualComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
        //    IsGreaterThanOrEqualComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

        //    IsGreaterThanOrEqualComparer<Dummy>((0, 0, new DummyIComparer()), (14, true, "[Value = '0'; Other = '0']"));
        //    IsGreaterThanOrEqualComparer<Dummy>((0, 1, new DummyIComparer()), (15, false, "[Value = '0'; Other = '1']"));
        //    IsGreaterThanOrEqualComparer<Dummy>((1, 0, new DummyIComparer()), (16, true, "[Value = '1'; Other = '0']"));

        //    IsGreaterThanOrEqualComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
        //    IsGreaterThanOrEqualComparer((null, 0, new DummyIComparerT()), (18, false, "[Value = null; Other = '0']"));
        //    IsGreaterThanOrEqualComparer((0, null, new DummyIComparerT()), (19, true, "[Value = '0'; Other = null]"));
        //    IsGreaterThanOrEqualComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
        //    IsGreaterThanOrEqualComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

        //    IsGreaterThanOrEqualComparer((0, 0, new DummyIComparerT()), (22, true, "[Value = '0'; Other = '0']"));
        //    IsGreaterThanOrEqualComparer((0, 1, new DummyIComparerT()), (23, false, "[Value = '0'; Other = '1']"));
        //    IsGreaterThanOrEqualComparer((1, 0, new DummyIComparerT()), (24, true, "[Value = '1'; Other = '0']"));

        //}

        //[TestMethod]
        //void NotIsGreaterThanOrEqualComparer() {

        //    NotIsGreaterThanOrEqualComparer<Dummy>((null, null, null), (1, false, "Parameter 'comparer' is null."));
        //    NotIsGreaterThanOrEqualComparer((null, 0, new DummyComparer()), (2, true, "[Value = null; Other = '0']"));
        //    NotIsGreaterThanOrEqualComparer((0, null, new DummyComparer()), (3, false, "[Value = '0'; Other = null]"));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, 0, null), (4, false, "Parameter 'comparer' is null."));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, 0, new ThrowingComparer()), (5, false, "Comparer threw Exception:"));

        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, 0, new DummyComparer()), (6, false, "[Value = '0'; Other = '0']"));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, 1, new DummyComparer()), (7, true, "[Value = '0'; Other = '1']"));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((1, 0, new DummyComparer()), (8, false, "[Value = '1'; Other = '0']"));

        //    NotIsGreaterThanOrEqualComparer<Dummy>((null, null, (IComparer) null), (9, false, "Parameter 'comparer' is null."));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((null, 0, new DummyIComparer()), (10, true, "[Value = null; Other = '0']"));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, null, new DummyIComparer()), (11, false, "[Value = '0'; Other = null]"));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, 0, (IComparer) null), (12, false, "Parameter 'comparer' is null."));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (13, false, "Comparer threw Exception:"));

        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, 0, new DummyIComparer()), (14, false, "[Value = '0'; Other = '0']"));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((0, 1, new DummyIComparer()), (15, true, "[Value = '0'; Other = '1']"));
        //    NotIsGreaterThanOrEqualComparer<Dummy>((1, 0, new DummyIComparer()), (16, false, "[Value = '1'; Other = '0']"));

        //    NotIsGreaterThanOrEqualComparer((null, null, (IComparer<Dummy>) null), (17, false, "Parameter 'comparer' is null."));
        //    NotIsGreaterThanOrEqualComparer((null, 0, new DummyIComparerT()), (18, true, "[Value = null; Other = '0']"));
        //    NotIsGreaterThanOrEqualComparer((0, null, new DummyIComparerT()), (19, false, "[Value = '0'; Other = null]"));
        //    NotIsGreaterThanOrEqualComparer((0, 0, (IComparer<Dummy>) null), (20, false, "Parameter 'comparer' is null."));
        //    NotIsGreaterThanOrEqualComparer((0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (21, false, "Comparer threw Exception:"));

        //    NotIsGreaterThanOrEqualComparer((0, 0, new DummyIComparerT()), (22, false, "[Value = '0'; Other = '0']"));
        //    NotIsGreaterThanOrEqualComparer((0, 1, new DummyIComparerT()), (23, true, "[Value = '0'; Other = '1']"));
        //    NotIsGreaterThanOrEqualComparer((1, 0, new DummyIComparerT()), (24, false, "[Value = '1'; Other = '0']"));

        //}

        #region IsGreaterThanOrEqualComparer

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualComparerData))]
        void IsGreaterThanOrEqualComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualComparerData))]
        void NotIsGreaterThanOrEqualComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        #endregion

        #region IsGreaterThanOrEqualIComparer

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualIComparerData))]
        void IsGreaterThanOrEqualIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualIComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualIComparerData))]
        void NotIsGreaterThanOrEqualIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualIComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        #endregion

        #region IsGreaterThanOrEqualIComparerT

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualIComparerTData))]
        void IsGreaterThanOrEqualIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualIComparerTData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualIComparerTData))]
        void NotIsGreaterThanOrEqualIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualIComparerTData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
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
        [TestParameters(true, 1, false, "[Value = 'True']")]
        [TestParameters(false, 2, true, "[Value = 'False']")]
        void NotTrue(Boolean input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsTrue(input),
                (count, result, message), "Test.IfNot.Value.IsTrue");

        }

        #endregion

        #region IsTrueNullable

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
        [TestParameters(true, 1, true, "[Value = 'True']")]
        [TestParameters(false, 2, false, "[Value = 'False']")]
        void NotFalse(Boolean input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsFalse(input),
                (count, result, message), "Test.IfNot.Value.IsFalse");

        }

        #endregion

        #region IsFalseNullable

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
        [TestParameters(null, 3, false, "Parameter 'value' is null.")]
        void NotFalseNullable(Boolean? input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsFalse(input),
                (count, result, message), "Test.IfNot.Value.IsFalse");

        }

        #endregion

        #region IsClamped

        [TestMethod]
        [TestData(nameof(IsClampedData))]
        void IsClamped<T>(T input1, T input2, T input3, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), new DummyIComparable(0), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, new DummyIComparable(0), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), null, (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(0), (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(1), (6, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(-1), (7, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(1), (8, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(0), (9, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(2), (10, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-2), new DummyIComparable(-1), (11, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedData))]
        void NotIsClamped<T>(T input1, T input2, T input3, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input1, input2, input3),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), new DummyIComparable(0), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, new DummyIComparable(0), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), null, (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(0), (5, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(1), (6, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(-1), (7, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(1), (8, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(0), (9, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(2), (10, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-2), new DummyIComparable(-1), (11, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        #region IsClampedT

        [TestMethod]
        [TestData(nameof(IsClampedTData))]
        void IsClampedT<T>(T input1, T input2, T input3, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedT(input1, input2, input3),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), new DummyIComparableT(0), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, new DummyIComparableT(0), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), null, (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(0), (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(1), (6, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(-1), (7, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(1), (8, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(0), (9, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(2), (10, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-2), new DummyIComparableT(-1), (11, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedTData))]
        void NotIsClampedT<T>(T input1, T input2, T input3, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedT(input1, input2, input3),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), new DummyIComparableT(0), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, new DummyIComparableT(0), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), null, (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(0), (5, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(1), (6, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(-1), (7, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(1), (8, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(0), (9, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(2), (10, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-2), new DummyIComparableT(-1), (11, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        //[TestMethod]
        //void IsClampedComparer() {

        //    IsClampedComparer<Dummy>((null, null, null, null), (1, false, "Parameter 'value' is null."));
        //    IsClampedComparer((null, 0, 0, new DummyComparer()), (2, false, "Parameter 'value' is null."));
        //    IsClampedComparer((0, null, 0, new DummyComparer()), (3, true, "[Value = '0'; Min = null; Max = '0']"));
        //    IsClampedComparer((0, 0, null, new DummyComparer()), (4, true, "[Value = '0'; Min = '0'; Max = null]"));
        //    IsClampedComparer<Dummy>((0, 0, 0, null), (5, false, "Parameter 'comparer' is null."));
        //    IsClampedComparer<Dummy>((0, 0, 0, new ThrowingComparer()), (6, false, "Comparer threw Exception:"));

        //    IsClampedComparer<Dummy>((0, 0, 0, new DummyComparer()), (7, true, "[Value = '0'; Min = '0'; Max = '0']"));
        //    IsClampedComparer<Dummy>((0, -1, 1, new DummyComparer()), (8, true, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    IsClampedComparer<Dummy>((0, 1, -1, new DummyComparer()), (9, true, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    IsClampedComparer<Dummy>((0, 0, 1, new DummyComparer()), (10, true, "[Value = '0'; Min = '0'; Max = '1']"));
        //    IsClampedComparer<Dummy>((0, -1, 0, new DummyComparer()), (11, true, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    IsClampedComparer<Dummy>((0, 1, 2, new DummyComparer()), (12, false, "[Value = '0'; Min = '1'; Max = '2']"));
        //    IsClampedComparer<Dummy>((0, -2, -1, new DummyComparer()), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //    IsClampedComparer<Dummy>((null, null, null, (IComparer) null), (14, false, "Parameter 'value' is null."));
        //    IsClampedComparer<Dummy>((null, 0, 0, new DummyIComparer()), (15, false, "Parameter 'value' is null."));
        //    IsClampedComparer<Dummy>((0, null, 0, new DummyIComparer()), (16, true, "[Value = '0'; Min = null; Max = '0']"));
        //    IsClampedComparer<Dummy>((0, 0, null, new DummyIComparer()), (17, true, "[Value = '0'; Min = '0'; Max = null]"));
        //    IsClampedComparer<Dummy>((0, 0, 0, (IComparer) null), (18, false, "Parameter 'comparer' is null."));
        //    IsClampedComparer<Dummy>((0, 0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (19, false, "Comparer threw Exception:"));

        //    IsClampedComparer<Dummy>((0, 0, 0, new DummyIComparer()), (20, true, "[Value = '0'; Min = '0'; Max = '0']"));
        //    IsClampedComparer<Dummy>((0, -1, 1, new DummyIComparer()), (21, true, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    IsClampedComparer<Dummy>((0, 1, -1, new DummyIComparer()), (22, true, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    IsClampedComparer<Dummy>((0, 0, 1, new DummyIComparer()), (23, true, "[Value = '0'; Min = '0'; Max = '1']"));
        //    IsClampedComparer<Dummy>((0, -1, 0, new DummyIComparer()), (24, true, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    IsClampedComparer<Dummy>((0, 1, 2, new DummyIComparer()), (25, false, "[Value = '0'; Min = '1'; Max = '2']"));
        //    IsClampedComparer<Dummy>((0, -2, -1, new DummyIComparer()), (26, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //    IsClampedComparer((null, null, null, (IComparer<Dummy>) null), (27, false, "Parameter 'value' is null."));
        //    IsClampedComparer((null, 0, 0, new DummyIComparerT()), (28, false, "Parameter 'value' is null."));
        //    IsClampedComparer((0, null, 0, new DummyIComparerT()), (29, true, "[Value = '0'; Min = null; Max = '0']"));
        //    IsClampedComparer((0, 0, null, new DummyIComparerT()), (30, true, "[Value = '0'; Min = '0'; Max = null]"));
        //    IsClampedComparer((0, 0, 0, (IComparer<Dummy>) null), (31, false, "Parameter 'comparer' is null."));
        //    IsClampedComparer((0, 0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (32, false, "Comparer threw Exception:"));

        //    IsClampedComparer((0, 0, 0, new DummyIComparerT()), (33, true, "[Value = '0'; Min = '0'; Max = '0']"));
        //    IsClampedComparer((0, -1, 1, new DummyIComparerT()), (34, true, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    IsClampedComparer((0, 1, -1, new DummyIComparerT()), (35, true, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    IsClampedComparer((0, 0, 1, new DummyIComparerT()), (36, true, "[Value = '0'; Min = '0'; Max = '1']"));
        //    IsClampedComparer((0, -1, 0, new DummyIComparerT()), (37, true, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    IsClampedComparer((0, 1, 2, new DummyIComparerT()), (38, false, "[Value = '0'; Min = '1'; Max = '2']"));
        //    IsClampedComparer((0, -2, -1, new DummyIComparerT()), (39, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //}

        //[TestMethod]
        //void NotIsClampedComparer() {

        //    NotIsClampedComparer<Dummy>((null, null, null, null), (1, false, "Parameter 'value' is null."));
        //    NotIsClampedComparer((null, 0, 0, new DummyComparer()), (2, false, "Parameter 'value' is null."));
        //    NotIsClampedComparer((0, null, 0, new DummyComparer()), (3, false, "[Value = '0'; Min = null; Max = '0']"));
        //    NotIsClampedComparer((0, 0, null, new DummyComparer()), (4, false, "[Value = '0'; Min = '0'; Max = null]"));
        //    NotIsClampedComparer<Dummy>((0, 0, 0, null), (5, false, "Parameter 'comparer' is null."));
        //    NotIsClampedComparer<Dummy>((0, 0, 0, new ThrowingComparer()), (6, false, "Comparer threw Exception:"));

        //    NotIsClampedComparer<Dummy>((0, 0, 0, new DummyComparer()), (7, false, "[Value = '0'; Min = '0'; Max = '0']"));
        //    NotIsClampedComparer<Dummy>((0, -1, 1, new DummyComparer()), (8, false, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    NotIsClampedComparer<Dummy>((0, 1, -1, new DummyComparer()), (9, false, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    NotIsClampedComparer<Dummy>((0, 0, 1, new DummyComparer()), (10, false, "[Value = '0'; Min = '0'; Max = '1']"));
        //    NotIsClampedComparer<Dummy>((0, -1, 0, new DummyComparer()), (11, false, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    NotIsClampedComparer<Dummy>((0, 1, 2, new DummyComparer()), (12, true, "[Value = '0'; Min = '1'; Max = '2']"));
        //    NotIsClampedComparer<Dummy>((0, -2, -1, new DummyComparer()), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //    NotIsClampedComparer<Dummy>((null, null, null, (IComparer) null), (14, false, "Parameter 'value' is null."));
        //    NotIsClampedComparer<Dummy>((null, 0, 0, new DummyIComparer()), (15, false, "Parameter 'value' is null."));
        //    NotIsClampedComparer<Dummy>((0, null, 0, new DummyIComparer()), (16, false, "[Value = '0'; Min = null; Max = '0']"));
        //    NotIsClampedComparer<Dummy>((0, 0, null, new DummyIComparer()), (17, false, "[Value = '0'; Min = '0'; Max = null]"));
        //    NotIsClampedComparer<Dummy>((0, 0, 0, (IComparer) null), (18, false, "Parameter 'comparer' is null."));
        //    NotIsClampedComparer<Dummy>((0, 0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (19, false, "Comparer threw Exception:"));

        //    NotIsClampedComparer<Dummy>((0, 0, 0, new DummyIComparer()), (20, false, "[Value = '0'; Min = '0'; Max = '0']"));
        //    NotIsClampedComparer<Dummy>((0, -1, 1, new DummyIComparer()), (21, false, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    NotIsClampedComparer<Dummy>((0, 1, -1, new DummyIComparer()), (22, false, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    NotIsClampedComparer<Dummy>((0, 0, 1, new DummyIComparer()), (23, false, "[Value = '0'; Min = '0'; Max = '1']"));
        //    NotIsClampedComparer<Dummy>((0, -1, 0, new DummyIComparer()), (24, false, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    NotIsClampedComparer<Dummy>((0, 1, 2, new DummyIComparer()), (25, true, "[Value = '0'; Min = '1'; Max = '2']"));
        //    NotIsClampedComparer<Dummy>((0, -2, -1, new DummyIComparer()), (26, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //    NotIsClampedComparer((null, null, null, (IComparer<Dummy>) null), (27, false, "Parameter 'value' is null."));
        //    NotIsClampedComparer((null, 0, 0, new DummyIComparerT()), (28, false, "Parameter 'value' is null."));
        //    NotIsClampedComparer((0, null, 0, new DummyIComparerT()), (29, false, "[Value = '0'; Min = null; Max = '0']"));
        //    NotIsClampedComparer((0, 0, null, new DummyIComparerT()), (30, false, "[Value = '0'; Min = '0'; Max = null]"));
        //    NotIsClampedComparer((0, 0, 0, (IComparer<Dummy>) null), (31, false, "Parameter 'comparer' is null."));
        //    NotIsClampedComparer((0, 0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (32, false, "Comparer threw Exception:"));

        //    NotIsClampedComparer((0, 0, 0, new DummyIComparerT()), (33, false, "[Value = '0'; Min = '0'; Max = '0']"));
        //    NotIsClampedComparer((0, -1, 1, new DummyIComparerT()), (34, false, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    NotIsClampedComparer((0, 1, -1, new DummyIComparerT()), (35, false, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    NotIsClampedComparer((0, 0, 1, new DummyIComparerT()), (36, false, "[Value = '0'; Min = '0'; Max = '1']"));
        //    NotIsClampedComparer((0, -1, 0, new DummyIComparerT()), (37, false, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    NotIsClampedComparer((0, 1, 2, new DummyIComparerT()), (38, true, "[Value = '0'; Min = '1'; Max = '2']"));
        //    NotIsClampedComparer((0, -2, -1, new DummyIComparerT()), (39, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //}

        #region IsClampedComparer

        [TestMethod]
        [TestData(nameof(IsClampedComparerData))]
        void IsClampedComparer<T>(T input1, T input2, T input3, Comparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3, input4),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedComparerData))]
        void NotIsClampedComparer<T>(T input1, T input2, T input3, Comparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input1, input2, input3, input4),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        #endregion

        #region IsClampedIComparer

        [TestMethod]
        [TestData(nameof(IsClampedIComparerData))]
        void IsClampedIComparer<T>(T input1, T input2, T input3, IComparer input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3, input4),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedIComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedIComparerData))]
        void NotIsClampedIComparer<T>(T input1, T input2, T input3, IComparer input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input1, input2, input3, input4),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedIComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        #endregion

        #region IsClampedIComparerT

        [TestMethod]
        [TestData(nameof(IsClampedIComparerTData))]
        void IsClampedIComparerT<T>(T input1, T input2, T input3, IComparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3, input4),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedIComparerTData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedIComparerTData))]
        void NotIsClampedIComparerT<T>(T input1, T input2, T input3, IComparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input1, input2, input3, input4),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedIComparerTData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        #endregion

        #region IsClampedExclusive

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveData))]
        void IsClampedExclusive<T>(T input1, T input2, T input3, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), new DummyIComparable(0), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, new DummyIComparable(0), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), null, (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(0), (5, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(1), (6, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(-1), (7, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(1), (8, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(0), (9, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(2), (10, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-2), new DummyIComparable(-1), (11, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveData))]
        void NotIsClampedExclusive<T>(T input1, T input2, T input3, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input1, input2, input3),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), new DummyIComparable(0), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, new DummyIComparable(0), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), null, (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(0), (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(1), (6, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(-1), (7, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(1), (8, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(0), (9, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(2), (10, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-2), new DummyIComparable(-1), (11, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        #region IsClampedExclusiveT

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveTData))]
        void IsClampedExclusiveT<T>(T input1, T input2, T input3, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusiveT(input1, input2, input3),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), new DummyIComparableT(0), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, new DummyIComparableT(0), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), null, (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(0), (5, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(1), (6, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(-1), (7, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(1), (8, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(0), (9, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(2), (10, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-2), new DummyIComparableT(-1), (11, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveTData))]
        void NotIsClampedExclusiveT<T>(T input1, T input2, T input3, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusiveT(input1, input2, input3),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), new DummyIComparableT(0), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, new DummyIComparableT(0), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), null, (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(0), (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(1), (6, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(-1), (7, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(1), (8, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(0), (9, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(2), (10, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-2), new DummyIComparableT(-1), (11, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        //[TestMethod]
        //void IsClampedExclusiveComparer() {

        //    IsClampedExclusiveComparer<Dummy>((null, null, null, null), (1, false, "Parameter 'value' is null."));
        //    IsClampedExclusiveComparer((null, 0, 0, new DummyComparer()), (2, false, "Parameter 'value' is null."));
        //    IsClampedExclusiveComparer((0, null, 0, new DummyComparer()), (3, false, "[Value = '0'; Min = null; Max = '0']"));
        //    IsClampedExclusiveComparer((0, 0, null, new DummyComparer()), (4, false, "[Value = '0'; Min = '0'; Max = null]"));
        //    IsClampedExclusiveComparer<Dummy>((0, 0, 0, null), (5, false, "Parameter 'comparer' is null."));
        //    IsClampedExclusiveComparer<Dummy>((0, 0, 0, new ThrowingComparer()), (6, false, "Comparer threw Exception:"));

        //    IsClampedExclusiveComparer<Dummy>((0, 0, 0, new DummyComparer()), (7, false, "[Value = '0'; Min = '0'; Max = '0']"));
        //    IsClampedExclusiveComparer<Dummy>((0, -1, 1, new DummyComparer()), (8, true, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    IsClampedExclusiveComparer<Dummy>((0, 1, -1, new DummyComparer()), (9, true, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    IsClampedExclusiveComparer<Dummy>((0, 0, 1, new DummyComparer()), (10, false, "[Value = '0'; Min = '0'; Max = '1']"));
        //    IsClampedExclusiveComparer<Dummy>((0, -1, 0, new DummyComparer()), (11, false, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    IsClampedExclusiveComparer<Dummy>((0, 1, 2, new DummyComparer()), (12, false, "[Value = '0'; Min = '1'; Max = '2']"));
        //    IsClampedExclusiveComparer<Dummy>((0, -2, -1, new DummyComparer()), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //    IsClampedExclusiveComparer<Dummy>((null, null, null, (IComparer) null), (14, false, "Parameter 'value' is null."));
        //    IsClampedExclusiveComparer<Dummy>((null, 0, 0, new DummyIComparer()), (15, false, "Parameter 'value' is null."));
        //    IsClampedExclusiveComparer<Dummy>((0, null, 0, new DummyIComparer()), (16, false, "[Value = '0'; Min = null; Max = '0']"));
        //    IsClampedExclusiveComparer<Dummy>((0, 0, null, new DummyIComparer()), (17, false, "[Value = '0'; Min = '0'; Max = null]"));
        //    IsClampedExclusiveComparer<Dummy>((0, 0, 0, (IComparer) null), (18, false, "Parameter 'comparer' is null."));
        //    IsClampedExclusiveComparer<Dummy>((0, 0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (19, false, "Comparer threw Exception:"));

        //    IsClampedExclusiveComparer<Dummy>((0, 0, 0, new DummyIComparer()), (20, false, "[Value = '0'; Min = '0'; Max = '0']"));
        //    IsClampedExclusiveComparer<Dummy>((0, -1, 1, new DummyIComparer()), (21, true, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    IsClampedExclusiveComparer<Dummy>((0, 1, -1, new DummyIComparer()), (22, true, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    IsClampedExclusiveComparer<Dummy>((0, 0, 1, new DummyIComparer()), (23, false, "[Value = '0'; Min = '0'; Max = '1']"));
        //    IsClampedExclusiveComparer<Dummy>((0, -1, 0, new DummyIComparer()), (24, false, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    IsClampedExclusiveComparer<Dummy>((0, 1, 2, new DummyIComparer()), (25, false, "[Value = '0'; Min = '1'; Max = '2']"));
        //    IsClampedExclusiveComparer<Dummy>((0, -2, -1, new DummyIComparer()), (26, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //    IsClampedExclusiveComparer((null, null, null, (IComparer<Dummy>) null), (27, false, "Parameter 'value' is null."));
        //    IsClampedExclusiveComparer((null, 0, 0, new DummyIComparerT()), (28, false, "Parameter 'value' is null."));
        //    IsClampedExclusiveComparer((0, null, 0, new DummyIComparerT()), (29, false, "[Value = '0'; Min = null; Max = '0']"));
        //    IsClampedExclusiveComparer((0, 0, null, new DummyIComparerT()), (30, false, "[Value = '0'; Min = '0'; Max = null]"));
        //    IsClampedExclusiveComparer((0, 0, 0, (IComparer<Dummy>) null), (31, false, "Parameter 'comparer' is null."));
        //    IsClampedExclusiveComparer((0, 0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (32, false, "Comparer threw Exception:"));

        //    IsClampedExclusiveComparer((0, 0, 0, new DummyIComparerT()), (33, false, "[Value = '0'; Min = '0'; Max = '0']"));
        //    IsClampedExclusiveComparer((0, -1, 1, new DummyIComparerT()), (34, true, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    IsClampedExclusiveComparer((0, 1, -1, new DummyIComparerT()), (35, true, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    IsClampedExclusiveComparer((0, 0, 1, new DummyIComparerT()), (36, false, "[Value = '0'; Min = '0'; Max = '1']"));
        //    IsClampedExclusiveComparer((0, -1, 0, new DummyIComparerT()), (37, false, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    IsClampedExclusiveComparer((0, 1, 2, new DummyIComparerT()), (38, false, "[Value = '0'; Min = '1'; Max = '2']"));
        //    IsClampedExclusiveComparer((0, -2, -1, new DummyIComparerT()), (39, false, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //}

        //[TestMethod]
        //void NotIsClampedExclusiveComparer() {

        //    NotIsClampedExclusiveComparer<Dummy>((null, null, null, null), (1, false, "Parameter 'value' is null."));
        //    NotIsClampedExclusiveComparer((null, 0, 0, new DummyComparer()), (2, false, "Parameter 'value' is null."));
        //    NotIsClampedExclusiveComparer((0, null, 0, new DummyComparer()), (3, true, "[Value = '0'; Min = null; Max = '0']"));
        //    NotIsClampedExclusiveComparer((0, 0, null, new DummyComparer()), (4, true, "[Value = '0'; Min = '0'; Max = null]"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, 0, null), (5, false, "Parameter 'comparer' is null."));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, 0, new ThrowingComparer()), (6, false, "Comparer threw Exception:"));

        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, 0, new DummyComparer()), (7, true, "[Value = '0'; Min = '0'; Max = '0']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, -1, 1, new DummyComparer()), (8, false, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 1, -1, new DummyComparer()), (9, false, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, 1, new DummyComparer()), (10, true, "[Value = '0'; Min = '0'; Max = '1']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, -1, 0, new DummyComparer()), (11, true, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 1, 2, new DummyComparer()), (12, true, "[Value = '0'; Min = '1'; Max = '2']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, -2, -1, new DummyComparer()), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //    NotIsClampedExclusiveComparer<Dummy>((null, null, null, (IComparer) null), (14, false, "Parameter 'value' is null."));
        //    NotIsClampedExclusiveComparer<Dummy>((null, 0, 0, new DummyIComparer()), (15, false, "Parameter 'value' is null."));
        //    NotIsClampedExclusiveComparer<Dummy>((0, null, 0, new DummyIComparer()), (16, true, "[Value = '0'; Min = null; Max = '0']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, null, new DummyIComparer()), (17, true, "[Value = '0'; Min = '0'; Max = null]"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, 0, (IComparer) null), (18, false, "Parameter 'comparer' is null."));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, 0, DynamicComparer.FromDelegate((x, y) => throw new NotImplementedException())), (19, false, "Comparer threw Exception:"));

        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, 0, new DummyIComparer()), (20, true, "[Value = '0'; Min = '0'; Max = '0']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, -1, 1, new DummyIComparer()), (21, false, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 1, -1, new DummyIComparer()), (22, false, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 0, 1, new DummyIComparer()), (23, true, "[Value = '0'; Min = '0'; Max = '1']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, -1, 0, new DummyIComparer()), (24, true, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, 1, 2, new DummyIComparer()), (25, true, "[Value = '0'; Min = '1'; Max = '2']"));
        //    NotIsClampedExclusiveComparer<Dummy>((0, -2, -1, new DummyIComparer()), (26, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //    NotIsClampedExclusiveComparer((null, null, null, (IComparer<Dummy>) null), (27, false, "Parameter 'value' is null."));
        //    NotIsClampedExclusiveComparer((null, 0, 0, new DummyIComparerT()), (28, false, "Parameter 'value' is null."));
        //    NotIsClampedExclusiveComparer((0, null, 0, new DummyIComparerT()), (29, true, "[Value = '0'; Min = null; Max = '0']"));
        //    NotIsClampedExclusiveComparer((0, 0, null, new DummyIComparerT()), (30, true, "[Value = '0'; Min = '0'; Max = null]"));
        //    NotIsClampedExclusiveComparer((0, 0, 0, (IComparer<Dummy>) null), (31, false, "Parameter 'comparer' is null."));
        //    NotIsClampedExclusiveComparer((0, 0, 0, DynamicComparer.FromDelegate<Dummy>((x, y) => throw new NotImplementedException())), (32, false, "Comparer threw Exception:"));

        //    NotIsClampedExclusiveComparer((0, 0, 0, new DummyIComparerT()), (33, true, "[Value = '0'; Min = '0'; Max = '0']"));
        //    NotIsClampedExclusiveComparer((0, -1, 1, new DummyIComparerT()), (34, false, "[Value = '0'; Min = '-1'; Max = '1']"));
        //    NotIsClampedExclusiveComparer((0, 1, -1, new DummyIComparerT()), (35, false, "[Value = '0'; Min = '1'; Max = '-1']"));
        //    NotIsClampedExclusiveComparer((0, 0, 1, new DummyIComparerT()), (36, true, "[Value = '0'; Min = '0'; Max = '1']"));
        //    NotIsClampedExclusiveComparer((0, -1, 0, new DummyIComparerT()), (37, true, "[Value = '0'; Min = '-1'; Max = '0']"));
        //    NotIsClampedExclusiveComparer((0, 1, 2, new DummyIComparerT()), (38, true, "[Value = '0'; Min = '1'; Max = '2']"));
        //    NotIsClampedExclusiveComparer((0, -2, -1, new DummyIComparerT()), (39, true, "[Value = '0'; Min = '-2'; Max = '-1']"));

        //}

        #region IsClampedExclusiveComparer

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveComparerData))]
        void IsClampedExclusiveComparer<T>(T input1, T input2, T input3, Comparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3, input4),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveComparerData))]
        void NotIsClampedExclusiveComparer<T>(T input1, T input2, T input3, Comparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input1, input2, input3, input4),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        #endregion

        #region IsClampedExclusiveIComparer

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveIComparerData))]
        void IsClampedExclusiveIComparer<T>(T input1, T input2, T input3, IComparer input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3, input4),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveIComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveIComparerData))]
        void NotIsClampedExclusiveIComparer<T>(T input1, T input2, T input3, IComparer input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input1, input2, input3, input4),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveIComparerData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        #endregion

        #region IsClampedExclusiveIComparerT

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveIComparerTData))]
        void IsClampedExclusiveIComparerT<T>(T input1, T input2, T input3, IComparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3, input4),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveIComparerTData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveIComparerTData))]
        void NotIsClampedExclusiveIComparerT<T>(T input1, T input2, T input3, IComparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input1, input2, input3, input4),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveIComparerTData() {
            return new List<Object[]>() {
                new Object[] {  },
            };
        }

        #endregion

    }
}
