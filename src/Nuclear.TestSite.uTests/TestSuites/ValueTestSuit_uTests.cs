using System;
using System.Collections;
using System.Collections.Generic;

using Nuclear.TestSite.TestComparers;
using Nuclear.TestSite.TestTypes;

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
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(0), null, (3, false, "('Nuclear.TestSite.TestTypes.DummyIEquatableT'.IEquatable<T>) [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(5), new DummyIEquatableT(0), (4, false, "('Nuclear.TestSite.TestTypes.DummyIEquatableT'.IEquatable<T>) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(5), new DummyIEquatableT(5), (5, true, "('Nuclear.TestSite.TestTypes.DummyIEquatableT'.IEquatable<T>) [Left = '5'; Right = '5']") },

                new Object[] { typeof(DummyIComparableT), null, null, (6, true, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), (7, false, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, (8, false, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(5), new DummyIComparableT(0), (9, false, "('Nuclear.TestSite.TestTypes.DummyIComparableT'.IComparable<T>) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(5), new DummyIComparableT(5), (10, true, "('Nuclear.TestSite.TestTypes.DummyIComparableT'.IComparable<T>) [Left = '5'; Right = '5']") },

                new Object[] { typeof(DummyIComparable), null, null, (11, true, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), (12, false, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, (13, false, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(5), new DummyIComparable(0), (14, false, "('Nuclear.TestSite.TestTypes.DummyIComparable'.IComparable) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(5), new DummyIComparable(5), (15, true, "('Nuclear.TestSite.TestTypes.DummyIComparable'.IComparable) [Left = '5'; Right = '5']") },

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
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(0), null, (3, true, "('Nuclear.TestSite.TestTypes.DummyIEquatableT'.IEquatable<T>) [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(5), new DummyIEquatableT(0), (4, true, "('Nuclear.TestSite.TestTypes.DummyIEquatableT'.IEquatable<T>) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIEquatableT), new DummyIEquatableT(5), new DummyIEquatableT(5), (5, false, "('Nuclear.TestSite.TestTypes.DummyIEquatableT'.IEquatable<T>) [Left = '5'; Right = '5']") },

                new Object[] { typeof(DummyIComparableT), null, null, (6, false, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), (7, true, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, (8, true, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(5), new DummyIComparableT(0), (9, true, "('Nuclear.TestSite.TestTypes.DummyIComparableT'.IComparable<T>) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(5), new DummyIComparableT(5), (10, false, "('Nuclear.TestSite.TestTypes.DummyIComparableT'.IComparable<T>) [Left = '5'; Right = '5']") },

                new Object[] { typeof(DummyIComparable), null, null, (11, false, "[Left = null; Right = null]") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), (12, true, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, (13, true, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(5), new DummyIComparable(0), (14, true, "('Nuclear.TestSite.TestTypes.DummyIComparable'.IComparable) [Left = '5'; Right = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(5), new DummyIComparable(5), (15, false, "('Nuclear.TestSite.TestTypes.DummyIComparable'.IComparable) [Left = '5'; Right = '5']") },

                new Object[] { typeof(Dummy), null, null, (16, false, "[Left = null; Right = null]") },
                new Object[] { typeof(Dummy), null, new Dummy(0), (17, true, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), null, (18, true, "('ObjectEqualityComparer`1') [Left = '0'; Right = null]") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), (19, true, "('ObjectEqualityComparer`1') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), (20, true, "('ObjectEqualityComparer`1') [Left = '5'; Right = '5']") },
            };
        }

        #endregion

        #region IsEqualWithMessage

        [TestMethod]
        [TestData(nameof(IsEqualWithMessageData))]
        void IsEqualWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, customMessage),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, "message", (1, true, "[Left = null; Right = null]") },
                new Object[] { typeof(Dummy), null, new Dummy(0), "message", (2, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualWithMessageData))]
        void NotIsEqualWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, "message", (1, false, "message") },
                new Object[] { typeof(Dummy), null, new Dummy(0), "message", (2, true, "('ObjectEqualityComparer`1') [Left = null; Right = '0']") },
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

        #region IsEqualComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsEqualComparerWithMessageData))]
        void IsEqualComparerWithMessage<T>(T input1, T input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyEqualityComparer(), "message", (3, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyEqualityComparer(), "message", (4, true, "('DummyEqualityComparer') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingEqualityComparer(), "message", (5, false, "Comparison threw Exception:") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualComparerWithMessageData))]
        void NotIsEqualComparerWithMessage<T>(T input1, T input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyEqualityComparer(), "message", (3, true, "('DummyEqualityComparer') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyEqualityComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingEqualityComparer(), "message", (5, false, "Comparison threw Exception:") },
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

        #region IsEqualIComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsEqualIComparerWithMessageData))]
        void IsEqualIComparerWithMessage<T>(T input1, T input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyIEqualityComparer(), "message", (3, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyIEqualityComparer(), "message", (4, true, "('InternalEqualityComparer`1') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingIEqualityComparer(), "message", (5, false, "Comparison threw Exception:") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualIComparerWithMessageData))]
        void NotIsEqualIComparerWithMessage<T>(T input1, T input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyIEqualityComparer(), "message", (3, true, "('InternalEqualityComparer`1') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyIEqualityComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingIEqualityComparer(), "message", (5, false, "Comparison threw Exception:") },
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

        #region IsEqualIComparerTWithMessage

        [TestMethod]
        [TestData(nameof(IsEqualIComparerTWithMessageData))]
        void IsEqualIComparerTWithMessage<T>(T input1, T input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyIEqualityComparerT(), "message", (3, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyIEqualityComparerT(), "message", (4, true, "('DummyIEqualityComparerT') [Left = '5'; Right = '5']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingIEqualityComparerT(), "message", (5, false, "Comparison threw Exception:") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualIComparerTWithMessageData))]
        void NotIsEqualIComparerTWithMessage<T>(T input1, T input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(0), new DummyIEqualityComparerT(), "message", (3, true, "('DummyIEqualityComparerT') [Left = '5'; Right = '0']") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new DummyIEqualityComparerT(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(5), new Dummy(5), new ThrowingIEqualityComparerT(), "message", (5, false, "Comparison threw Exception:") },
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

        #region IsEqualSingleWithMessage

        [TestMethod]
        [TestParameters(1f, 0f, "message", 1, false, "message")]
        [TestParameters(1f, 1f, "message", 2, true, "[Left = '1'; Right = '1'; Margin = '1E-12']")]
        void IsEqualSingleWithMessage(Single input1, Single input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, customMessage),
                (count, result, message), "Test.If.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1f, 0f, "message", 1, true, "[Left = '1'; Right = '0'; Margin = '1E-12']")]
        [TestParameters(1f, 1f, "message", 2, false, "message")]
        void NotIsEqualSingleWithMessage(Single input1, Single input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, customMessage),
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

        #region IsEqualSingleMarginWithMessage

        [TestMethod]
        [TestParameters(1e-11f, 1.1e-11f, 1e-11f, "message", 1, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-11']")]
        void IsEqualSingleMarginWithMessage(Single input1, Single input2, Single input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3, customMessage),
                (count, result, message), "Test.If.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1e-11f, 1.1e-11f, 1e-11f, "message", 1, false, "message")]
        void NotIsEqualSingleMarginWithMessage(Single input1, Single input2, Single input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3, customMessage),
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

        #region IsEqualDoubleWithMessage

        [TestMethod]
        [TestParameters(1d, 0d, "message", 1, false, "message")]
        [TestParameters(1d, 1d, "message", 2, true, "[Left = '1'; Right = '1'; Margin = '1E-12']")]
        void IsEqualDoubleWithMessage(Double input1, Double input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, customMessage),
                (count, result, message), "Test.If.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1d, 0d, "message", 1, true, "[Left = '1'; Right = '0'; Margin = '1E-12']")]
        [TestParameters(1d, 1d, "message", 2, false, "message")]
        void NotIsEqualDoubleWithMessage(Double input1, Double input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, customMessage),
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

        #region IsEqualDoubleMarginWithMessage

        [TestMethod]
        [TestParameters(1e-11d, 1.1e-11d, 1e-11d, "message", 1, true, "[Left = '1E-11'; Right = '1.1E-11'; Margin = '1E-11']")]
        void IsEqualDoubleMarginWithMessage(Double input1, Double input2, Double input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2, input3, customMessage),
                (count, result, message), "Test.If.Value.IsEqual");

        }

        [TestMethod]
        [TestParameters(1e-11d, 1.1e-11d, 1e-11d, "message", 1, false, "message")]
        void NotIsEqualDoubleMarginWithMessage(Double input1, Double input2, Double input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2, input3, customMessage),
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

        #region IsLessThanWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanWithMessageData))]
        void IsLessThanWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input1, input2, customMessage),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), "message", (1, false, "message") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), "message", (2, true, "[Value = '0'; Other = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanWithMessageData))]
        void NotIsLessThanWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), "message", (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), "message", (2, false, "message") },
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

        #region IsLessThanTWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanTWithMessageData))]
        void IsLessThanTWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanT(input1, input2, customMessage),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), "message", (1, false, "message") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), "message", (2, true, "[Value = '0'; Other = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanTWithMessageData))]
        void NotIsLessThanTWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanT(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), "message", (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), "message", (2, false, "message") },
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

        #region IsLessThanComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanComparerWithMessageData))]
        void IsLessThanComparerWithMessage<T>(T input1, T input2, Comparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), "message", (5, true, "[Value = '0'; Other = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanComparerWithMessageData))]
        void NotIsLessThanComparerWithMessage<T>(T input1, T input2, Comparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), "message", (4, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), "message", (5, false, "message") },
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

        #region IsLessThanIComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanIComparerWithMessageData))]
        void IsLessThanIComparerWithMessage<T>(T input1, T input2, IComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), "message", (5, true, "[Value = '0'; Other = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanIComparerWithMessageData))]
        void NotIsLessThanIComparerWithMessage<T>(T input1, T input2, IComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (4, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), "message", (5, false, "message") },
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

        #region IsLessThanIComparerTWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanIComparerTWithMessageData))]
        void IsLessThanIComparerTWithMessage<T>(T input1, T input2, IComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThan(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsLessThan");

        }

        IEnumerable<Object[]> IsLessThanIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), "message", (5, true, "[Value = '0'; Other = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanIComparerTWithMessageData))]
        void NotIsLessThanIComparerTWithMessage<T>(T input1, T input2, IComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThan(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsLessThan");

        }

        IEnumerable<Object[]> NotIsLessThanIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (4, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), "message", (5, false, "message") },
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

        #region IsLessThanOrEqualWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualWithMessageData))]
        void IsLessThanOrEqualWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input1, input2, customMessage),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), "message", (1, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), "message", (2, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualWithMessageData))]
        void NotIsLessThanOrEqualWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), "message", (1, false, "message") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), "message", (2, true, "[Value = '1'; Other = '0']") },
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

        #region IsLessThanOrEqualTWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualTWithMessageData))]
        void IsLessThanOrEqualTWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqualT(input1, input2, customMessage),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), "message", (1, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), "message", (2, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualTWithMessageData))]
        void NotIsLessThanOrEqualTWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqualT(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), "message", (1, false, "message") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), "message", (2, true, "[Value = '1'; Other = '0']") },
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

        #region IsLessThanOrEqualComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualComparerWithMessageData))]
        void IsLessThanOrEqualComparerWithMessage<T>(T input1, T input2, Comparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), "message", (4, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualComparerWithMessageData))]
        void NotIsLessThanOrEqualComparerWithMessage<T>(T input1, T input2, Comparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), "message", (5, true, "[Value = '1'; Other = '0']") },
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

        #region IsLessThanOrEqualIComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualIComparerWithMessageData))]
        void IsLessThanOrEqualIComparerWithMessage<T>(T input1, T input2, IComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), "message", (4, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualIComparerWithMessageData))]
        void NotIsLessThanOrEqualIComparerWithMessage<T>(T input1, T input2, IComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), "message", (5, true, "[Value = '1'; Other = '0']") },
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

        #region IsLessThanOrEqualIComparerTWithMessage

        [TestMethod]
        [TestData(nameof(IsLessThanOrEqualIComparerTWithMessageData))]
        void IsLessThanOrEqualIComparerTWithMessage<T>(T input1, T input2, IComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsLessThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> IsLessThanOrEqualIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), "message", (4, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsLessThanOrEqualIComparerTWithMessageData))]
        void NotIsLessThanOrEqualIComparerTWithMessage<T>(T input1, T input2, IComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsLessThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsLessThanOrEqual");

        }

        IEnumerable<Object[]> NotIsLessThanOrEqualIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), "message", (5, true, "[Value = '1'; Other = '0']") },
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

        #region IsGreaterThanWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanWithMessageData))]
        void IsGreaterThanWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input1, input2, customMessage),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), "message", (1, false, "message") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), "message", (2, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanWithMessageData))]
        void NotIsGreaterThanWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), "message", (1, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(1), new DummyIComparable(0), "message", (2, false, "message") },
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

        #region IsGreaterThanTWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanTWithMessageData))]
        void IsGreaterThanTWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanT(input1, input2, customMessage),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), "message", (1, false, "message") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), "message", (2, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanTWithMessageData))]
        void NotIsGreaterThanTWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanT(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), "message", (1, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(1), new DummyIComparableT(0), "message", (2, false, "message") },
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

        #region IsGreaterThanComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanComparerWithMessageData))]
        void IsGreaterThanComparerWithMessage<T>(T input1, T input2, Comparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), "message", (5, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanComparerWithMessageData))]
        void NotIsGreaterThanComparerWithMessage<T>(T input1, T input2, Comparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), "message", (4, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyComparer(), "message", (5, false, "message") },
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

        #region IsGreaterThanIComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanIComparerWithMessageData))]
        void IsGreaterThanIComparerWithMessage<T>(T input1, T input2, IComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), "message", (5, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanIComparerWithMessageData))]
        void NotIsGreaterThanIComparerWithMessage<T>(T input1, T input2, IComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), "message", (4, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparer(), "message", (5, false, "message") },
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

        #region IsGreaterThanIComparerTWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanIComparerTWithMessageData))]
        void IsGreaterThanIComparerTWithMessage<T>(T input1, T input2, IComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThan(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> IsGreaterThanIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), "message", (5, true, "[Value = '1'; Other = '0']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanIComparerTWithMessageData))]
        void NotIsGreaterThanIComparerTWithMessage<T>(T input1, T input2, IComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThan(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThan");

        }

        IEnumerable<Object[]> NotIsGreaterThanIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), "message", (4, true, "[Value = '0'; Other = '1']") },
                new Object[] { typeof(Dummy), new Dummy(1), new Dummy(0), new DummyIComparerT(), "message", (5, false, "message") },
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

        #region IsGreaterThanOrEqualWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualWithMessageData))]
        void IsGreaterThanOrEqualWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2, customMessage),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), "message", (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), "message", (2, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualWithMessageData))]
        void NotIsGreaterThanOrEqualWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), "message", (1, false, "message") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), "message", (2, true, "[Value = '0'; Other = '1']") },
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

        #region IsGreaterThanOrEqualTWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualTWithMessageData))]
        void IsGreaterThanOrEqualTWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqualT(input1, input2, customMessage),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), "message", (1, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), "message", (2, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualTWithMessageData))]
        void NotIsGreaterThanOrEqualTWithMessage<T>(T input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqualT(input1, input2, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), "message", (1, false, "message") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), "message", (2, true, "[Value = '0'; Other = '1']") },
            };
        }

        #endregion

        #region IsGreaterThanOrEqualComparer

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualComparerData))]
        void IsGreaterThanOrEqualComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualComparerData() {
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

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualComparerData))]
        void NotIsGreaterThanOrEqualComparer<T>(T input1, T input2, Comparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualComparerData() {
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

        #endregion

        #region IsGreaterThanOrEqualComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualComparerWithMessageData))]
        void IsGreaterThanOrEqualComparerWithMessage<T>(T input1, T input2, Comparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), "message", (4, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualComparerWithMessageData))]
        void NotIsGreaterThanOrEqualComparerWithMessage<T>(T input1, T input2, Comparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyComparer(), "message", (5, true, "[Value = '0'; Other = '1']") },
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

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualIComparerData))]
        void NotIsGreaterThanOrEqualIComparer<T>(T input1, T input2, IComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualIComparerData() {
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

        #endregion

        #region IsGreaterThanOrEqualIComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualIComparerWithMessageData))]
        void IsGreaterThanOrEqualIComparerWithMessage<T>(T input1, T input2, IComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (4, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualIComparerWithMessageData))]
        void NotIsGreaterThanOrEqualIComparerWithMessage<T>(T input1, T input2, IComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparer(), "message", (5, true, "[Value = '0'; Other = '1']") },
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

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualIComparerTData))]
        void NotIsGreaterThanOrEqualIComparerT<T>(T input1, T input2, IComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualIComparerTData() {
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

        #endregion

        #region IsGreaterThanOrEqualIComparerTWithMessage

        [TestMethod]
        [TestData(nameof(IsGreaterThanOrEqualIComparerTWithMessageData))]
        void IsGreaterThanOrEqualIComparerTWithMessage<T>(T input1, T input2, IComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsGreaterThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> IsGreaterThanOrEqualIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (4, true, "[Value = '0'; Other = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsGreaterThanOrEqualIComparerTWithMessageData))]
        void NotIsGreaterThanOrEqualIComparerTWithMessage<T>(T input1, T input2, IComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsGreaterThanOrEqual(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsGreaterThanOrEqual");

        }

        IEnumerable<Object[]> NotIsGreaterThanOrEqualIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, "message", (2, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (3, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (4, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new DummyIComparerT(), "message", (5, true, "[Value = '0'; Other = '1']") },
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

        #region IsTrueWithMessage

        [TestMethod]
        [TestParameters(true, "message", 1, true, "[Value = 'True']")]
        [TestParameters(false, "message", 2, false, "message")]
        void TrueWithMessage(Boolean input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsTrue(input, customMessage),
                (count, result, message), "Test.If.Value.IsTrue");

        }

        [TestMethod]
        [TestParameters(true, "message", 1, false, "message")]
        [TestParameters(false, "message", 2, true, "[Value = 'False']")]
        void NotTrueWithMessage(Boolean input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsTrue(input, customMessage),
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

        #region IsTrueNullableWithMessage

        [TestMethod]
        [TestParameters(true, "message", 1, true, "[Value = 'True']")]
        [TestParameters(false, "message", 2, false, "message")]
        void TrueNullableWithMessage(Boolean? input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsTrue(input, customMessage),
                (count, result, message), "Test.If.Value.IsTrue");

        }

        [TestMethod]
        [TestParameters(true, "message", 1, false, "message")]
        [TestParameters(false, "message", 2, true, "[Value = 'False']")]
        void NotTrueNullableWithMessage(Boolean? input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsTrue(input, customMessage),
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

        #region IsFalseWithMessage

        [TestMethod]
        [TestParameters(true, "message", 1, false, "message")]
        [TestParameters(false, "message", 2, true, "[Value = 'False']")]
        void IsFalseWithMessage(Boolean input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsFalse(input, customMessage),
                (count, result, message), "Test.If.Value.IsFalse");

        }

        [TestMethod]
        [TestParameters(true, "message", 1, true, "[Value = 'True']")]
        [TestParameters(false, "message", 2, false, "message")]
        void NotFalseWithMessage(Boolean input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsFalse(input, customMessage),
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

        #region IsFalseNullableWithMessage

        [TestMethod]
        [TestParameters(true, "message", 1, false, "message")]
        [TestParameters(false, "message", 2, true, "[Value = 'False']")]
        [TestParameters(null, "message", 3, false, "Parameter 'value' is null.")]
        void IsFalseNullableWithMessage(Boolean? input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsFalse(input, customMessage),
                (count, result, message), "Test.If.Value.IsFalse");

        }

        [TestMethod]
        [TestParameters(true, "message", 1, true, "[Value = 'True']")]
        [TestParameters(false, "message", 2, false, "message")]
        [TestParameters(null, "message", 3, false, "Parameter 'value' is null.")]
        void NotFalseNullableWithMessage(Boolean? input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsFalse(input, customMessage),
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

        #region IsClampedWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedWithMessageData))]
        void IsClampedWithMessage<T>(T input1, T input2, T input3, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), new DummyIComparable(0), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, new DummyIComparable(0), "message", (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(2), "message", (4, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedWithMessageData))]
        void NotIsClampedWithMessage<T>(T input1, T input2, T input3, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), new DummyIComparable(0), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), null, new DummyIComparable(0), "message", (3, false, "message") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(1), new DummyIComparable(2), "message", (4, true, "[Value = '0'; Min = '1'; Max = '2']") },
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

        #region IsClampedTWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedTWithMessageData))]
        void IsClampedTWithMessage<T>(T input1, T input2, T input3, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedT(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), new DummyIComparableT(0), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, new DummyIComparableT(0), "message", (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(2), "message", (4, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedTWithMessageData))]
        void NotIsClampedTWithMessage<T>(T input1, T input2, T input3, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedT(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), new DummyIComparableT(0), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), null, new DummyIComparableT(0), "message", (3, false, "message") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(1), new DummyIComparableT(2), "message", (4, true, "[Value = '0'; Min = '1'; Max = '2']") },
            };
        }

        #endregion

        #region IsClampedComparer

        [TestMethod]
        [TestData(nameof(IsClampedComparerData))]
        void IsClampedComparer<T>(T input1, T input2, T input3, Comparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3, input4),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyComparer(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyComparer(), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyComparer(), (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingComparer(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyComparer(), (7, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyComparer(), (8, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyComparer(), (9, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyComparer(), (10, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyComparer(), (11, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyComparer(), (12, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyComparer(), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyComparer(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyComparer(), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyComparer(), (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingComparer(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyComparer(), (7, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyComparer(), (8, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyComparer(), (9, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyComparer(), (10, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyComparer(), (11, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyComparer(), (12, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyComparer(), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        #region IsClampedComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedComparerWithMessageData))]
        void IsClampedComparerWithMessage<T>(T input1, T input2, T input3, Comparer<T> input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyComparer(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyComparer(), "message", (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyComparer(), "message", (6, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedComparerWithMessageData))]
        void NotIsClampedComparerWithMessage<T>(T input1, T input2, T input3, Comparer<T> input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyComparer(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyComparer(), "message", (5, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyComparer(), "message", (6, true, "[Value = '0'; Min = '1'; Max = '2']") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparer(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyIComparer(), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyIComparer(), (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparer(), (7, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparer(), (8, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyIComparer(), (9, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyIComparer(), (10, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyIComparer(), (11, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparer(), (12, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyIComparer(), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparer(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyIComparer(), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyIComparer(), (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparer(), (7, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparer(), (8, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyIComparer(), (9, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyIComparer(), (10, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyIComparer(), (11, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparer(), (12, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyIComparer(), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        #region IsClampedIComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedIComparerWithMessageData))]
        void IsClampedIComparerWithMessage<T>(T input1, T input2, T input3, IComparer input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparer(), "message", (6, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedIComparerWithMessageData))]
        void NotIsClampedIComparerWithMessage<T>(T input1, T input2, T input3, IComparer input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (5, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparer(), "message", (6, true, "[Value = '0'; Min = '1'; Max = '2']") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparerT(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyIComparerT(), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyIComparerT(), (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparerT(), (7, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparerT(), (8, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyIComparerT(), (9, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyIComparerT(), (10, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyIComparerT(), (11, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparerT(), (12, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyIComparerT(), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparerT(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyIComparerT(), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyIComparerT(), (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparerT(), (7, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparerT(), (8, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyIComparerT(), (9, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyIComparerT(), (10, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyIComparerT(), (11, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparerT(), (12, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyIComparerT(), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        #region IsClampedIComparerTWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedIComparerTWithMessageData))]
        void IsClampedIComparerTWithMessage<T>(T input1, T input2, T input3, IComparer<T> input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClamped(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Value.IsClamped");

        }

        IEnumerable<Object[]> IsClampedIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparerT(), "message", (6, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedIComparerTWithMessageData))]
        void NotIsClampedIComparerTWithMessage<T>(T input1, T input2, T input3, IComparer<T> input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClamped(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Value.IsClamped");

        }

        IEnumerable<Object[]> NotIsClampedIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (5, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparerT(), "message", (6, true, "[Value = '0'; Min = '1'; Max = '2']") },
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

        #region IsClampedExclusiveWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveWithMessageData))]
        void IsClampedExclusiveWithMessage<T>(T input1, T input2, T input3, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), new DummyIComparable(0), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(0), "message", (3, false, "message") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(1), "message", (4, true, "[Value = '0'; Min = '-1'; Max = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveWithMessageData))]
        void NotIsClampedExclusiveWithMessage<T>(T input1, T input2, T input3, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparable), null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), null, new DummyIComparable(0), new DummyIComparable(0), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(0), new DummyIComparable(0), "message", (3, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparable), new DummyIComparable(0), new DummyIComparable(-1), new DummyIComparable(1), "message", (4, false, "message") },
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

        #region IsClampedExclusiveTWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveTWithMessageData))]
        void IsClampedExclusiveTWithMessage<T>(T input1, T input2, T input3, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusiveT(input1, input2, input3, customMessage),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), new DummyIComparableT(0), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(0), "message", (3, false, "message") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(1), "message", (4, true, "[Value = '0'; Min = '-1'; Max = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveTWithMessageData))]
        void NotIsClampedExclusiveTWithMessage<T>(T input1, T input2, T input3, String customMessage, (Int32 count, Boolean result, String message) expected)
            where T : IComparable<T> {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusiveT(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIComparableT), null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), null, new DummyIComparableT(0), new DummyIComparableT(0), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(0), new DummyIComparableT(0), "message", (3, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(DummyIComparableT), new DummyIComparableT(0), new DummyIComparableT(-1), new DummyIComparableT(1), "message", (4, false, "message") },
            };
        }

        #endregion

        #region IsClampedExclusiveComparer

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveComparerData))]
        void IsClampedExclusiveComparer<T>(T input1, T input2, T input3, Comparer<T> input4, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3, input4),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyComparer(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyComparer(), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyComparer(), (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingComparer(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyComparer(), (7, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyComparer(), (8, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyComparer(), (9, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyComparer(), (10, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyComparer(), (11, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyComparer(), (12, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyComparer(), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyComparer(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyComparer(), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyComparer(), (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingComparer(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyComparer(), (7, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyComparer(), (8, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyComparer(), (9, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyComparer(), (10, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyComparer(), (11, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyComparer(), (12, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyComparer(), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        #region IsClampedExclusiveComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveComparerWithMessageData))]
        void IsClampedExclusiveComparerWithMessage<T>(T input1, T input2, T input3, Comparer<T> input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyComparer(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyComparer(), "message", (5, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyComparer(), "message", (6, true, "[Value = '0'; Min = '-1'; Max = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveComparerWithMessageData))]
        void NotIsClampedExclusiveComparerWithMessage<T>(T input1, T input2, T input3, Comparer<T> input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyComparer(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingComparer(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyComparer(), "message", (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyComparer(), "message", (6, false, "message") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparer(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyIComparer(), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyIComparer(), (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparer(), (7, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparer(), (8, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyIComparer(), (9, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyIComparer(), (10, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyIComparer(), (11, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparer(), (12, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyIComparer(), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparer(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyIComparer(), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyIComparer(), (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparer(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparer(), (7, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparer(), (8, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyIComparer(), (9, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyIComparer(), (10, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyIComparer(), (11, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparer(), (12, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyIComparer(), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        #region IsClampedExclusiveIComparerWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveIComparerWithMessageData))]
        void IsClampedExclusiveIComparerWithMessage<T>(T input1, T input2, T input3, IComparer input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (5, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparer(), "message", (6, true, "[Value = '0'; Min = '-1'; Max = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveIComparerWithMessageData))]
        void NotIsClampedExclusiveIComparerWithMessage<T>(T input1, T input2, T input3, IComparer input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveIComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparer(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparer(), "message", (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparer(), "message", (6, false, "message") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparerT(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyIComparerT(), (3, false, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyIComparerT(), (4, false, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparerT(), (7, false, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparerT(), (8, true, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyIComparerT(), (9, true, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyIComparerT(), (10, false, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyIComparerT(), (11, false, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparerT(), (12, false, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyIComparerT(), (13, false, "[Value = '0'; Min = '-2'; Max = '-1']") },
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
                new Object[] { typeof(Dummy), null, null, null, null, (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparerT(), (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), null, new Dummy(0), new DummyIComparerT(), (3, true, "[Value = '0'; Min = null; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), null, new DummyIComparerT(), (4, true, "[Value = '0'; Min = '0'; Max = null]") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, (5, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), (6, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparerT(), (7, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparerT(), (8, false, "[Value = '0'; Min = '-1'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(-1), new DummyIComparerT(), (9, false, "[Value = '0'; Min = '1'; Max = '-1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(1), new DummyIComparerT(), (10, true, "[Value = '0'; Min = '0'; Max = '1']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(0), new DummyIComparerT(), (11, true, "[Value = '0'; Min = '-1'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(1), new Dummy(2), new DummyIComparerT(), (12, true, "[Value = '0'; Min = '1'; Max = '2']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-2), new Dummy(-1), new DummyIComparerT(), (13, true, "[Value = '0'; Min = '-2'; Max = '-1']") },
            };
        }

        #endregion

        #region IsClampedExclusiveIComparerTWithMessage

        [TestMethod]
        [TestData(nameof(IsClampedExclusiveIComparerTWithMessageData))]
        void IsClampedExclusiveIComparerTWithMessage<T>(T input1, T input2, T input3, IComparer<T> input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsClampedExclusive(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> IsClampedExclusiveIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (5, false, "message") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparerT(), "message", (6, true, "[Value = '0'; Min = '-1'; Max = '1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsClampedExclusiveIComparerTWithMessageData))]
        void NotIsClampedExclusiveIComparerTWithMessage<T>(T input1, T input2, T input3, IComparer<T> input4, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsClampedExclusive(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Value.IsClampedExclusive");

        }

        IEnumerable<Object[]> NotIsClampedExclusiveIComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), null, new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (2, false, "Parameter 'value' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new ThrowingIComparerT(), "message", (4, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(0), new Dummy(0), new DummyIComparerT(), "message", (5, true, "[Value = '0'; Min = '0'; Max = '0']") },
                new Object[] { typeof(Dummy), new Dummy(0), new Dummy(-1), new Dummy(1), new DummyIComparerT(), "message", (6, false, "message") },
            };
        }

        #endregion

    }
}
