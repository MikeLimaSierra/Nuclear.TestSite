using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Nuclear.TestSite.TestTypes;

namespace Nuclear.TestSite.TestSuites {
    class EnumerableTestSuite_uTests {

        #region IsEmpty

        [TestMethod]
        [TestData(nameof(IsEmptyData))]
        void IsEmpty(IEnumerable input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.IsEmpty(input),
                expected, "Test.If.Enumerable.IsEmpty");

        }

        IEnumerable<Object[]> IsEmptyData() {
            return new List<Object[]>() {
                new Object[] { null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), (2, true, "Enumeration is empty. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (3, false, "Enumeration is not empty. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, (4, false, "Enumeration is not empty. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<Dummy>() { null, null, }, (5, false, "Enumeration is not empty. Enumeration is: [null, null]") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEmptyData))]
        void NotIsEmpty(IEnumerable input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.IsEmpty(input),
                expected, "Test.IfNot.Enumerable.IsEmpty");

        }

        IEnumerable<Object[]> NotIsEmptyData() {
            return new List<Object[]>() {
                new Object[] { null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), (2, false, "Enumeration is empty. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (3, true, "Enumeration is not empty. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, (4, true, "Enumeration is not empty. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<Dummy>() { null, null, }, (5, true, "Enumeration is not empty. Enumeration is: [null, null]") },
            };
        }

        #endregion

        #region IsEmptyWithMessage

        [TestMethod]
        [TestData(nameof(IsEmptyWithMessageData))]
        void IsEmptyWithMessage(IEnumerable input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.IsEmpty(input, customMessage),
                expected, "Test.If.Enumerable.IsEmpty");

        }

        IEnumerable<Object[]> IsEmptyWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), "message", (2, true, "Enumeration is empty. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, "message", (3, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEmptyWithMessageData))]
        void NotIsEmptyWithMessage(IEnumerable input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.IsEmpty(input, customMessage),
                expected, "Test.IfNot.Enumerable.IsEmpty");

        }

        IEnumerable<Object[]> NotIsEmptyWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), "message", (2, false, "message") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, "message", (3, true, "Enumeration is not empty. Enumeration is: ['1', '2', '3']") },
            };
        }

        #endregion

        #region IsEmptyT

        [TestMethod]
        [TestData(nameof(IsEmptyTData))]
        void IsEmptyT<T>(IEnumerable<T> input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.IsEmpty(input),
                expected, "Test.If.Enumerable.IsEmpty");

        }

        IEnumerable<Object[]> IsEmptyTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), (2, true, "Enumeration is empty. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (3, false, "Enumeration is not empty. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, (4, false, "Enumeration is not empty. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { null, null, }, (5, false, "Enumeration is not empty. Enumeration is: [null, null]") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEmptyTData))]
        void NotIsEmptyT<T>(IEnumerable<T> input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.IsEmpty(input),
                expected, "Test.IfNot.Enumerable.IsEmpty");

        }

        IEnumerable<Object[]> NotIsEmptyTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), (2, false, "Enumeration is empty. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (3, true, "Enumeration is not empty. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, (4, true, "Enumeration is not empty. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { null, null, }, (5, true, "Enumeration is not empty. Enumeration is: [null, null]") },
            };
        }

        #endregion

        #region IsEmptyTWithMessage

        [TestMethod]
        [TestData(nameof(IsEmptyTWithMessageData))]
        void IsEmptyTWithMessage<T>(IEnumerable<T> input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.IsEmpty(input, customMessage),
                expected, "Test.If.Enumerable.IsEmpty");

        }

        IEnumerable<Object[]> IsEmptyTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), "message", (2, true, "Enumeration is empty. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, "message", (3, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEmptyTWithMessageData))]
        void NotIsEmptyTWithMessage<T>(IEnumerable<T> input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.IsEmpty(input, customMessage),
                expected, "Test.IfNot.Enumerable.IsEmpty");

        }

        IEnumerable<Object[]> NotIsEmptyTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), "message", (2, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, "message", (3, true, "Enumeration is not empty. Enumeration is: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsNull

        [TestMethod]
        [TestData(nameof(ContainsNullData))]
        void ContainsNull(IEnumerable input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsNull(input),
                expected, "Test.If.Enumerable.ContainsNull");

        }

        IEnumerable<Object[]> ContainsNullData() {
            return new List<Object[]>() {
                new Object[] { null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), (2, false, "Enumeration doesn't contain null. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (3, false, "Enumeration doesn't contain null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, (4, true, "Enumeration contains null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsNullData))]
        void NotContainsNull(IEnumerable input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsNull(input),
                expected, "Test.IfNot.Enumerable.ContainsNull");

        }

        IEnumerable<Object[]> NotContainsNullData() {
            return new List<Object[]>() {
                new Object[] { null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), (2, true, "Enumeration doesn't contain null. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (3, true, "Enumeration doesn't contain null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, (4, false, "Enumeration contains null. Enumeration is: ['1', null, '3']") },
            };
        }

        #endregion

        #region ContainsNullWithMessage

        [TestMethod]
        [TestData(nameof(ContainsNullWithMessageData))]
        void ContainsNullWithMessage(IEnumerable input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsNull(input, customMessage),
                expected, "Test.If.Enumerable.ContainsNull");

        }

        IEnumerable<Object[]> ContainsNullWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, "message", (2, false, "message") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, "message", (3, true, "Enumeration contains null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsNullWithMessageData))]
        void NotContainsNullWithMessage(IEnumerable input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsNull(input, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsNull");

        }

        IEnumerable<Object[]> NotContainsNullWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, "message", (2, true, "Enumeration doesn't contain null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, "message", (3, false, "message") },
            };
        }

        #endregion

        #region ContainsNullT

        [TestMethod]
        [TestData(nameof(ContainsNullTData))]
        void ContainsNullT<T>(IEnumerable<T> input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsNull(input),
                expected, "Test.If.Enumerable.ContainsNull");

        }

        IEnumerable<Object[]> ContainsNullTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), (2, false, "Enumeration doesn't contain null. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (3, false, "Enumeration doesn't contain null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, (4, true, "Enumeration contains null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsNullTData))]
        void NotContainsNullT<T>(IEnumerable<T> input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsNull(input),
                expected, "Test.IfNot.Enumerable.ContainsNull");

        }

        IEnumerable<Object[]> NotContainsNullTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), (2, true, "Enumeration doesn't contain null. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (3, true, "Enumeration doesn't contain null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, (4, false, "Enumeration contains null. Enumeration is: ['1', null, '3']") },
            };
        }

        #endregion

        #region ContainsNullTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsNullTWithMessageData))]
        void ContainsNullTWithMessage<T>(IEnumerable<T> input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsNull(input, customMessage),
                expected, "Test.If.Enumerable.ContainsNull");

        }

        IEnumerable<Object[]> ContainsNullTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, "message", (2, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, "message", (3, true, "Enumeration contains null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsNullTWithMessageData))]
        void NotContainsNullTWithMessage<T>(IEnumerable<T> input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsNull(input, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsNull");

        }

        IEnumerable<Object[]> NotContainsNullTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, "message", (2, true, "Enumeration doesn't contain null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, "message", (3, false, "message") },
            };
        }

        #endregion

        #region ContainsNonNull

        [TestMethod]
        [TestData(nameof(ContainsNonNullData))]
        void ContainsNonNull(IEnumerable input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsNonNull(input),
                expected, "Test.If.Enumerable.ContainsNonNull");

        }

        IEnumerable<Object[]> ContainsNonNullData() {
            return new List<Object[]>() {
                new Object[] { null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), (2, false, "Enumeration doesn't contain a non null value. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (3, true, "Enumeration contains a non null value. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, (4, true, "Enumeration contains a non null value. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<Dummy>() { null }, (5, false, "Enumeration doesn't contain a non null value. Enumeration is: [null]") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsNonNullData))]
        void NotContainsNonNull(IEnumerable input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsNonNull(input),
                expected, "Test.IfNot.Enumerable.ContainsNonNull");

        }

        IEnumerable<Object[]> NotContainsNonNullData() {
            return new List<Object[]>() {
                new Object[] { null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), (2, true, "Enumeration doesn't contain a non null value. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (3, false, "Enumeration contains a non null value. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, (4, false, "Enumeration contains a non null value. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<Dummy>() { null }, (5, true, "Enumeration doesn't contain a non null value. Enumeration is: [null]") },
            };
        }

        #endregion

        #region ContainsNonNullWithMessage

        [TestMethod]
        [TestData(nameof(ContainsNonNullWithMessageData))]
        void ContainsNonNullWithMessage(IEnumerable input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsNonNull(input, customMessage),
                expected, "Test.If.Enumerable.ContainsNonNull");

        }

        IEnumerable<Object[]> ContainsNonNullWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), "message", (2, false, "message") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, "message", (3, true, "Enumeration contains a non null value. Enumeration is: ['1', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsNonNullWithMessageData))]
        void NotContainsNonNullWithMessage(IEnumerable input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsNonNull(input, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsNonNull");

        }

        IEnumerable<Object[]> NotContainsNonNullWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<Dummy>(), "message", (2, true, "Enumeration doesn't contain a non null value. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, "message", (3, false, "message") },
            };
        }

        #endregion

        #region ContainsNonNullT

        [TestMethod]
        [TestData(nameof(ContainsNonNullTData))]
        void ContainsNonNullT<T>(IEnumerable<T> input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsNonNull(input),
                expected, "Test.If.Enumerable.ContainsNonNull");

        }

        IEnumerable<Object[]> ContainsNonNullTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), (2, false, "Enumeration doesn't contain a non null value. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (3, true, "Enumeration contains a non null value. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, (4, true, "Enumeration contains a non null value. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { null }, (5, false, "Enumeration doesn't contain a non null value. Enumeration is: [null]") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsNonNullTData))]
        void NotContainsNonNullT<T>(IEnumerable<T> input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsNonNull(input),
                expected, "Test.IfNot.Enumerable.ContainsNonNull");

        }

        IEnumerable<Object[]> NotContainsNonNullTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), (2, true, "Enumeration doesn't contain a non null value. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (3, false, "Enumeration contains a non null value. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, (4, false, "Enumeration contains a non null value. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { null }, (5, true, "Enumeration doesn't contain a non null value. Enumeration is: [null]") },
            };
        }

        #endregion

        #region ContainsNonNullTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsNonNullTWithMessageData))]
        void ContainsNonNullTWithMessage<T>(IEnumerable<T> input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsNonNull(input, customMessage),
                expected, "Test.If.Enumerable.ContainsNonNull");

        }

        IEnumerable<Object[]> ContainsNonNullTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), "message", (2, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, "message", (3, true, "Enumeration contains a non null value. Enumeration is: ['1', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsNonNullTWithMessageData))]
        void NotContainsNonNullTWithMessage<T>(IEnumerable<T> input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsNonNull(input, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsNonNull");

        }

        IEnumerable<Object[]> NotContainsNonNullTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), Enumerable.Empty<Dummy>(), "message", (2, true, "Enumeration doesn't contain a non null value. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, "message", (3, false, "message") },
            };
        }

        #endregion

        #region Contains

        [TestMethod]
        [TestData(nameof(ContainsData))]
        void Contains(IEnumerable input1, Object input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, 1, (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, null, (3, false, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, null, (4, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, (DummyIEquatableT) 2, (5, true, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, (DummyIEquatableT) 4, (6, false, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsData))]
        void NotContains(IEnumerable input1, Object input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, 1, (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, null, (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, null, (4, false, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, (DummyIEquatableT) 2, (5, false, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, (DummyIEquatableT) 4, (6, true, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithMessageData))]
        void ContainsWithMessage(IEnumerable input1, Object input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, 1, "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, null, "message", (3, false, "message") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, null, "message", (4, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithMessageData))]
        void NotContainsWithMessage(IEnumerable input1, Object input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, 1, "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, null, "message", (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, null, "message", (4, false, "message") },
            };
        }

        #endregion

        #region ContainsT

        [TestMethod]
        [TestData(nameof(ContainsTData))]
        void ContainsT<T>(IEnumerable<T> input1, T input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, (DummyIEquatableT) 1, (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, null, (3, false, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, null, (4, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, (DummyIEquatableT) 2, (5, true, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, (DummyIEquatableT) 4, (6, false, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsTData))]
        void NotContainsT<T>(IEnumerable<T> input1, T input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, (DummyIEquatableT) 1, (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, null, (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, null, (4, false, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, (DummyIEquatableT) 2, (5, false, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, (DummyIEquatableT) 4, (6, true, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsTWithMessageData))]
        void ContainsTWithMessage<T>(IEnumerable<T> input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, (DummyIEquatableT) 1, "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, null, "message", (3, false, "message") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, null, "message", (4, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsTWithMessageData))]
        void NotContainsTWithMessage<T>(IEnumerable<T> input1, T input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, (DummyIEquatableT) 1, "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, null, "message", (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, null, "message", (4, false, "message") },
            };
        }

        #endregion

        #region ContainsEqualityComparer

        [TestMethod]
        [TestData(nameof(ContainsWithEqualityComparerData))]
        void ContainsWithEqualityComparer<T>(IEnumerable<T> input1, T input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, (Dummy) 1, new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, new DummyEqualityComparer(), (3, false, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingEqualityComparer(), (5, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, null, new DummyEqualityComparer(), (6, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 2, new DummyEqualityComparer(), (7, true, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 4, new DummyEqualityComparer(), (8, false, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithEqualityComparerData))]
        void NotContainsWithEqualityComparer<T>(IEnumerable<T> input1, T input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, (Dummy) 1, new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, new DummyEqualityComparer(), (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingEqualityComparer(), (5, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, null, new DummyEqualityComparer(), (6, false, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 2, new DummyEqualityComparer(), (7, false, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 4, new DummyEqualityComparer(), (8, true, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithEqualityComparerWithMessageData))]
        void ContainsWithEqualityComparerWithMessage<T>(IEnumerable<T> input1, T input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, (Dummy) 1, new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, new DummyEqualityComparer(), "message", (3, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, null, new DummyEqualityComparer(), "message", (6, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithEqualityComparerWithMessageData))]
        void NotContainsWithEqualityComparerWithMessage<T>(IEnumerable<T> input1, T input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, (Dummy) 1, new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, new DummyEqualityComparer(), "message", (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, null, new DummyEqualityComparer(), "message", (6, false, "message") },
            };
        }

        #endregion

        #region ContainsIEqualityComparer

        [TestMethod]
        [TestData(nameof(ContainsWithIEqualityComparerData))]
        void ContainsWithIEqualityComparer(IEnumerable input1, Object input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, (Dummy) 1, new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, null, new DummyIEqualityComparer(), (3, false, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingIEqualityComparer(), (5, false, "Comparer threw Exception:") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, null, new DummyIEqualityComparer(), (6, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 2, new DummyIEqualityComparer(), (7, true, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 4, new DummyIEqualityComparer(), (8, false, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithIEqualityComparerData))]
        void NotContainsWithIEqualityComparer(IEnumerable input1, Object input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, (Dummy) 1, new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, null, new DummyIEqualityComparer(), (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingIEqualityComparer(), (5, false, "Comparer threw Exception:") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, null, new DummyIEqualityComparer(), (6, false, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 2, new DummyIEqualityComparer(), (7, false, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 4, new DummyIEqualityComparer(), (8, true, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsIEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithIEqualityComparerWithMessageData))]
        void ContainsWithIEqualityComparerWithMessage(IEnumerable input1, Object input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, (Dummy) 1, new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, null, new DummyIEqualityComparer(), "message", (3, false, "message") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingIEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, null, new DummyIEqualityComparer(), "message", (6, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithIEqualityComparerWithMessageData))]
        void NotContainsWithIEqualityComparerWithMessage(IEnumerable input1, Object input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, (Dummy) 1, new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, null, new DummyIEqualityComparer(), "message", (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingIEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, null, new DummyIEqualityComparer(), "message", (6, false, "message") },
            };
        }

        #endregion

        #region ContainsIEqualityComparerT

        [TestMethod]
        [TestData(nameof(ContainsWithIEqualityComparerTData))]
        void ContainsWithIEqualityComparerT<T>(IEnumerable<T> input1, T input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, (Dummy) 1, new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, new DummyIEqualityComparerT(), (3, false, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingIEqualityComparerT(), (5, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, null, new DummyIEqualityComparerT(), (6, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 2, new DummyIEqualityComparerT(), (7, true, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 4, new DummyIEqualityComparerT(), (8, false, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithIEqualityComparerTData))]
        void NotContainsWithIEqualityComparerT<T>(IEnumerable<T> input1, T input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, (Dummy) 1, new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, new DummyIEqualityComparerT(), (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingIEqualityComparerT(), (5, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, null, new DummyIEqualityComparerT(), (6, false, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 2, new DummyIEqualityComparerT(), (7, false, "Enumeration contains element '2'. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 4, new DummyIEqualityComparerT(), (8, true, "Enumeration doesn't contain element '4'. Enumeration is: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsIEqualityComparerTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithIEqualityComparerTWithMessageData))]
        void ContainsWithIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, T input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, (Dummy) 1, new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, new DummyIEqualityComparerT(), "message", (3, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingIEqualityComparerT(), "message", (5, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, null, new DummyIEqualityComparerT(), "message", (6, true, "Enumeration contains element null. Enumeration is: ['1', null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithIEqualityComparerTWithMessageData))]
        void NotContainsWithIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, T input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, (Dummy) 1, new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, new DummyIEqualityComparerT(), "message", (3, true, "Enumeration doesn't contain element null. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, (Dummy) 1, new ThrowingIEqualityComparerT(), "message", (5, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, null, new DummyIEqualityComparerT(), "message", (6, false, "message") },
            };
        }

        #endregion

        #region ContainsEqualityComparerKVP

        [TestMethod]
        [TestData(nameof(ContainsWithEqualityComparerKVPData))]
        void ContainsWithEqualityComparerKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, KeyValuePair<TKey, TValue> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, new DummyEqualityComparer(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, null, new DummyEqualityComparer(), (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, new DummyEqualityComparer(), null, (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    (5, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    (6, false, "Value comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(0, 0), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (7, false, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(0, 2), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (8, false, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (9, false, "Enumeration doesn't contain element ['1'] => '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 2), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (10, true, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 4), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (11, false, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithEqualityComparerKVPData))]
        void NotContainsWithEqualityComparerKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, KeyValuePair<TKey, TValue> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, new DummyEqualityComparer(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, null, new DummyEqualityComparer(), (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, new DummyEqualityComparer(), null, (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    (5, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    (6, false, "Value comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(0, 0), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (7, true, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(0, 2), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (8, true, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (9, true, "Enumeration doesn't contain element ['1'] => '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 2), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (10, false, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 4), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (11, true, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region ContainsEqualityComparerKVPWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithEqualityComparerKVPWithMessageData))]
        void ContainsWithEqualityComparerKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, KeyValuePair<TKey, TValue> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, null, new DummyEqualityComparer(), "message", (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, new DummyEqualityComparer(), null, "message", (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    "message", (5, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    "message", (6, false, "Value comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 2), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (7, true, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 4), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (8, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithEqualityComparerKVPWithMessageData))]
        void NotContainsWithEqualityComparerKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, KeyValuePair<TKey, TValue> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, null, new DummyEqualityComparer(), "message", (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, new DummyEqualityComparer(), null, "message", (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    "message", (5, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    "message", (6, false, "Value comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 2), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (7, false, "message") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 4), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (8, true, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region ContainsIEqualityComparerKVP

        [TestMethod]
        [TestData(nameof(ContainsWithIEqualityComparerKVPData))]
        void ContainsWithIEqualityComparerKVP(IEnumerable<DictionaryEntry> input1, DictionaryEntry input2, IEqualityComparer input3, IEqualityComparer input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithIEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { null, default, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, default, new DummyIEqualityComparer(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), default, null, new DummyIEqualityComparer(), (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), default, new DummyIEqualityComparer(), null, (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new ThrowingIEqualityComparer(), new DummyIEqualityComparer(),
                    (5, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new DummyIEqualityComparer(), new ThrowingIEqualityComparer(),
                    (6, false, "Value comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 0, (Dummy) 0), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (7, false, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 0, (Dummy) 2), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (8, false, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (9, false, "Enumeration doesn't contain element ['1'] => '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 2), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (10, true, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 4), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (11, false, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithIEqualityComparerKVPData))]
        void NotContainsWithIEqualityComparerKVP(IEnumerable<DictionaryEntry> input1, DictionaryEntry input2, IEqualityComparer input3, IEqualityComparer input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithIEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { null, default, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, default, new DummyIEqualityComparer(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), default, null, new DummyIEqualityComparer(), (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), default, new DummyIEqualityComparer(), null, (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new ThrowingIEqualityComparer(), new DummyIEqualityComparer(),
                    (5, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new DummyIEqualityComparer(), new ThrowingIEqualityComparer(),
                    (6, false, "Value comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 0, (Dummy) 0), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (7, true, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 0, (Dummy) 2), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (8, true, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (9, true, "Enumeration doesn't contain element ['1'] => '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 2), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (10, false, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 4), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (11, true, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region ContainsIEqualityComparerKVPWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithIEqualityComparerKVPWithMessageData))]
        void ContainsWithIEqualityComparerKVPWithMessage(IEnumerable<DictionaryEntry> input1, DictionaryEntry input2, IEqualityComparer input3, IEqualityComparer input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithIEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, default, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, default, new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), default, null, new DummyIEqualityComparer(), "message", (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), default, new DummyIEqualityComparer(), null, "message", (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new ThrowingIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (5, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new DummyIEqualityComparer(), new ThrowingIEqualityComparer(),
                    "message", (6, false, "Value comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 2), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (7, true, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 4), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (8, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithIEqualityComparerKVPWithMessageData))]
        void NotContainsWithIEqualityComparerKVPWithMessage(IEnumerable<DictionaryEntry> input1, DictionaryEntry input2, IEqualityComparer input3, IEqualityComparer input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithIEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, default, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, default, new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), default, null, new DummyIEqualityComparer(), "message", (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), default, new DummyIEqualityComparer(), null, "message", (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new ThrowingIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (5, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 0), new DummyIEqualityComparer(), new ThrowingIEqualityComparer(),
                    "message", (6, false, "Value comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 2), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (7, false, "message") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DictionaryEntry((Dummy) 1, (Dummy) 4), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (8, true, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region ContainsIEqualityComparerTKVP

        [TestMethod]
        [TestData(nameof(ContainsWithIEqualityComparerTKVPData))]
        void ContainsWithIEqualityComparerTKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, KeyValuePair<TKey, TValue> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithIEqualityComparerTKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, null, new DummyIEqualityComparerT(), (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, new DummyIEqualityComparerT(), null, (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (5, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    (6, false, "Value comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(0, 0), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (7, false, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(0, 2), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (8, false, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (9, false, "Enumeration doesn't contain element ['1'] => '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 2), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (10, true, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 4), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (11, false, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithIEqualityComparerTKVPData))]
        void NotContainsWithIEqualityComparerTKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, KeyValuePair<TKey, TValue> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithIEqualityComparerTKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, null, new DummyIEqualityComparerT(), (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, new DummyIEqualityComparerT(), null, (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (5, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    (6, false, "Value comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(0, 0), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (7, true, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(0, 2), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (8, true, "Enumeration doesn't contain element with key '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (9, true, "Enumeration doesn't contain element ['1'] => '0'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 2), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (10, false, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 4), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (11, true, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region ContainsIEqualityComparerTKVPWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithIEqualityComparerTKVPWithMessageData))]
        void ContainsWithIEqualityComparerTKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, KeyValuePair<TKey, TValue> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithIEqualityComparerTKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, null, new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, new DummyIEqualityComparerT(), null, "message", (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (5, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    "message", (6, false, "Value comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 2), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (7, true, "Enumeration contains element ['1'] => '2'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 4), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (8, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithIEqualityComparerTKVPWithMessageData))]
        void NotContainsWithIEqualityComparerTKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, KeyValuePair<TKey, TValue> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithIEqualityComparerTKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, default, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, null, new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), default, new DummyIEqualityComparerT(), null, "message", (4, false, "Parameter 'valueComparer' is null.") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (5, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 0), new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    "message", (6, false, "Value comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 2), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (7, false, "message") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new KeyValuePair<Dummy, Dummy>(1, 4), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (8, true, "Enumeration doesn't contain element ['1'] => '4'. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region ContainsFilter

        [TestMethod]
        [TestData(nameof(ContainsWithFilterData))]
        void ContainsWithFilter(IEnumerable input1, Predicate<Object> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithFilterData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new Predicate<Object>((_) => true), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, null, (3, false, "Parameter 'match' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => _ == null), (4, false, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, new Predicate<Object>((_) => _ == null), (5, true, "Enumeration contains a matching element. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => _ as DummyIEquatableT == 2), (6, true, "Enumeration contains a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => _ as DummyIEquatableT == 4), (7, false, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => throw new Exception("test")), (8, false, "Predicate threw Exception: 'test'") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithFilterData))]
        void NotContainsWithFilter(IEnumerable input1, Predicate<Object> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithFilterData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new Predicate<Object>((_) => true), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, null, (3, false, "Parameter 'match' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => _ == null), (4, true, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, new Predicate<Object>((_) => _ == null), (5, false, "Enumeration contains a matching element. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => _ as DummyIEquatableT == 2), (6, false, "Enumeration contains a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => _ as DummyIEquatableT == 4), (7, true, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => throw new Exception("test")), (8, false, "Predicate threw Exception: 'test'") },
            };
        }

        #endregion

        #region ContainsFilterWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithFilterWithMessageData))]
        void ContainsWithFilterWithMessage(IEnumerable input1, Predicate<Object> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithFilterWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new Predicate<Object>((_) => true), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'match' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => _ == null), "message", (4, false, "message") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, new Predicate<Object>((_) => _ == null), "message", (5, true, "Enumeration contains a matching element. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => throw new Exception("test")), "message", (6, false, "Predicate threw Exception: 'test'") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithFilterWithMessageData))]
        void NotContainsWithFilterWithMessage(IEnumerable input1, Predicate<Object> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithFilterWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new Predicate<Object>((_) => true), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'match' is null.") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => _ == null), "message", (4, true, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, new Predicate<Object>((_) => _ == null), "message", (5, false, "message") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<Object>((_) => throw new Exception("test")), "message", (6, false, "Predicate threw Exception: 'test'") },
            };
        }

        #endregion

        #region ContainsFilterT

        [TestMethod]
        [TestData(nameof(ContainsWithFilterTData))]
        void ContainsWithFilterT<T>(IEnumerable<T> input1, Predicate<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithFilterTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new Predicate<Object>((_) => true), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, null, (3, false, "Parameter 'match' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => _ == null), (4, false, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, new Predicate<DummyIEquatableT>((_) => _ == null), (5, true, "Enumeration contains a matching element. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => _ as DummyIEquatableT == 2), (6, true, "Enumeration contains a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => _ as DummyIEquatableT == 4), (7, false, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => throw new Exception("test")), (8, false, "Predicate threw Exception: 'test'") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithFilterTData))]
        void NotContainsWithFilterT<T>(IEnumerable<T> input1, Predicate<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithFilterTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new Predicate<Object>((_) => true), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, null, (3, false, "Parameter 'match' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => _ == null), (4, true, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, new Predicate<DummyIEquatableT>((_) => _ == null), (5, false, "Enumeration contains a matching element. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => _ as DummyIEquatableT == 2), (6, false, "Enumeration contains a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => _ as DummyIEquatableT == 4), (7, true, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => throw new Exception("test")), (8, false, "Predicate threw Exception: 'test'") },
            };
        }

        #endregion

        #region ContainsFilterTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsWithFilterTWithMessageData))]
        void ContainsWithFilterTWithMessage<T>(IEnumerable<T> input1, Predicate<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Contains(input1, input2, customMessage),
                expected, "Test.If.Enumerable.Contains");

        }

        IEnumerable<Object[]> ContainsWithFilterTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new Predicate<Object>((_) => true), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'match' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => _ == null), "message", (4, false, "message") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, new Predicate<DummyIEquatableT>((_) => _ == null), "message", (5, true, "Enumeration contains a matching element. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => throw new Exception("test")), "message", (6, false, "Predicate threw Exception: 'test'") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsWithFilterTWithMessageData))]
        void NotContainsWithFilterTWithMessage<T>(IEnumerable<T> input1, Predicate<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Contains(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.Contains");

        }

        IEnumerable<Object[]> NotContainsWithFilterTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new Predicate<Object>((_) => true), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'match' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => _ == null), "message", (4, true, "Enumeration doesn't contain a matching element. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, new Predicate<DummyIEquatableT>((_) => _ == null), "message", (5, false, "message") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new Predicate<DummyIEquatableT>((_) => throw new Exception("test")), "message", (6, false, "Predicate threw Exception: 'test'") },
            };
        }

        #endregion

        #region ContainsDuplicates

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesData))]
        void ContainsDuplicates(IEnumerable input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesData() {
            return new List<Object[]>() {
                new Object[] { null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { }, (2, false, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, (3, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, (4, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, null, 3 }, (5, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 2, 3 }, (6, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 2, 2, 3 }, (7, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesData))]
        void NotContainsDuplicates(IEnumerable input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesData() {
            return new List<Object[]>() {
                new Object[] { null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { }, (2, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, (3, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 3 }, (4, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, null, 3 }, (5, false, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 2, 3 }, (6, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 2, 2, 3 }, (7, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        #endregion

        #region ContainsDuplicatesWithMessage

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesWithMessageData))]
        void ContainsDuplicatesWithMessage(IEnumerable input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input, customMessage),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { }, "message", (2, false, "message") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, null, 3 }, "message", (3, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesWithMessageData))]
        void NotContainsDuplicatesWithMessage(IEnumerable input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>() { }, "message", (2, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, null, 3 }, "message", (3, false, "message") },
            };
        }

        #endregion

        #region ContainsDuplicatesT

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesTData))]
        void ContainsDuplicatesT<T>(IEnumerable<T> input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, (2, false, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, (3, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, (4, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, null, 3 }, (5, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 2, 3 }, (6, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 2, 2, 3 }, (7, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesTData))]
        void NotContainsDuplicatesT<T>(IEnumerable<T> input, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, (2, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, (3, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 3 }, (4, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, null, 3 }, (5, false, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 2, 3 }, (6, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 2, 2, 3 }, (7, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        #endregion

        #region ContainsDuplicatesTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesTWithMessageData))]
        void ContainsDuplicatesTWithMessage<T>(IEnumerable<T> input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input, customMessage),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, "message", (2, false, "message") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, null, 3 }, "message", (3, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesTWithMessageData))]
        void NotContainsDuplicatesTWithMessage<T>(IEnumerable<T> input, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, "message", (2, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, null, 3 }, "message", (3, false, "message") },
            };
        }

        #endregion

        #region ContainsDuplicatesEqualityComparer

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesWithEqualityComparerData))]
        void ContainsDuplicatesWithEqualityComparer<T>(IEnumerable<T> input1, EqualityComparer<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input1, input2),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesWithEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new ThrowingEqualityComparer(), (4, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { }, new DummyEqualityComparer(), (5, false, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new DummyEqualityComparer(), (6, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, new DummyEqualityComparer(), (7, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 3 }, new DummyEqualityComparer(), (8, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 2, 3 }, new DummyEqualityComparer(), (9, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 2, 2, 3 }, new DummyEqualityComparer(), (10, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesWithEqualityComparerData))]
        void NotContainsDuplicatesWithEqualityComparer<T>(IEnumerable<T> input1, EqualityComparer<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input1, input2),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesWithEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new ThrowingEqualityComparer(), (4, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { }, new DummyEqualityComparer(), (5, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new DummyEqualityComparer(), (6, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, new DummyEqualityComparer(), (7, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 3 }, new DummyEqualityComparer(), (8, false, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 2, 3 }, new DummyEqualityComparer(), (9, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 2, 2, 3 }, new DummyEqualityComparer(), (10, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        #endregion

        #region ContainsDuplicatesEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesWithEqualityComparerWithMessageData))]
        void ContainsDuplicatesWithEqualityComparerWithMessage<T>(IEnumerable<T> input1, EqualityComparer<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input1, input2, customMessage),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesWithEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new ThrowingEqualityComparer(), "message", (4, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { }, new DummyEqualityComparer(), "message", (5, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 3 }, new DummyEqualityComparer(), "message", (6, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesWithEqualityComparerWithMessageData))]
        void NotContainsDuplicatesWithEqualityComparerWithMessage<T>(IEnumerable<T> input1, EqualityComparer<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesWithEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new ThrowingEqualityComparer(), "message", (4, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { }, new DummyEqualityComparer(), "message", (5, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 3 }, new DummyEqualityComparer(), "message", (6, false, "message") },
            };
        }

        #endregion

        #region ContainsDuplicatesIEqualityComparer

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesWithIEqualityComparerData))]
        void ContainsDuplicatesWithIEqualityComparer(IEnumerable input1, IEqualityComparer input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input1, input2),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesWithIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, null, (3, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new ThrowingIEqualityComparer(), (4, false, "Comparer threw Exception:") },
                new Object[] { new List<Dummy>() { }, new DummyIEqualityComparer(), (5, false, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparer(), (6, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, new DummyIEqualityComparer(), (7, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<Dummy>() { 1, null, null, 3 }, new DummyIEqualityComparer(), (8, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 2, 3 }, new DummyIEqualityComparer(), (9, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 2, 2, 3 }, new DummyIEqualityComparer(), (10, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesWithIEqualityComparerData))]
        void NotContainsDuplicatesWithIEqualityComparer(IEnumerable input1, IEqualityComparer input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input1, input2),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesWithIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, null, (3, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new ThrowingIEqualityComparer(), (4, false, "Comparer threw Exception:") },
                new Object[] { new List<Dummy>() { }, new DummyIEqualityComparer(), (5, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparer(), (6, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, null, 3 }, new DummyIEqualityComparer(), (7, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { new List<Dummy>() { 1, null, null, 3 }, new DummyIEqualityComparer(), (8, false, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 2, 3 }, new DummyIEqualityComparer(), (9, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 2, 2, 3 }, new DummyIEqualityComparer(), (10, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        #endregion

        #region ContainsDuplicatesIEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesWithIEqualityComparerWithMessageData))]
        void ContainsDuplicatesWithIEqualityComparerWithMessage(IEnumerable input1, IEqualityComparer input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input1, input2, customMessage),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesWithIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new ThrowingIEqualityComparer(), "message", (4, false, "Comparer threw Exception:") },
                new Object[] { new List<Dummy>() { }, new DummyIEqualityComparer(), "message", (5, false, "message") },
                new Object[] { new List<Dummy>() { 1, null, null, 3 }, new DummyIEqualityComparer(), "message", (6, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesWithIEqualityComparerWithMessageData))]
        void NotContainsDuplicatesWithIEqualityComparerWithMessage(IEnumerable input1, IEqualityComparer input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesWithIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new ThrowingIEqualityComparer(), "message", (4, false, "Comparer threw Exception:") },
                new Object[] { new List<Dummy>() { }, new DummyIEqualityComparer(), "message", (5, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { new List<Dummy>() { 1, null, null, 3 }, new DummyIEqualityComparer(), "message", (6, false, "message") },
            };
        }

        #endregion

        #region ContainsDuplicatesIEqualityComparerT

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesWithIEqualityComparerTData))]
        void ContainsDuplicatesWithIEqualityComparerT<T>(IEnumerable<T> input1, IEqualityComparer<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input1, input2),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesWithIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new ThrowingIEqualityComparerT(), (4, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { }, new DummyIEqualityComparerT(), (5, false, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparerT(), (6, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, new DummyIEqualityComparerT(), (7, false, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 3 }, new DummyIEqualityComparerT(), (8, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 2, 3 }, new DummyIEqualityComparerT(), (9, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 2, 2, 3 }, new DummyIEqualityComparerT(), (10, true, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesWithIEqualityComparerTData))]
        void NotContainsDuplicatesWithIEqualityComparerT<T>(IEnumerable<T> input1, IEqualityComparer<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input1, input2),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesWithIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new ThrowingIEqualityComparerT(), (4, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { }, new DummyIEqualityComparerT(), (5, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparerT(), (6, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 3 }, new DummyIEqualityComparerT(), (7, true, "Enumeration doesn't contain duplicates. Enumeration is: ['1', null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 3 }, new DummyIEqualityComparerT(), (8, false, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 2, 3 }, new DummyIEqualityComparerT(), (9, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 2, 2, 3 }, new DummyIEqualityComparerT(), (10, false, "Enumeration contains duplicates. Enumeration is: ['1', '2', '2', '2', '3']") },
            };
        }

        #endregion

        #region ContainsDuplicatesIEqualityComparerTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsDuplicatesWithIEqualityComparerTWithMessageData))]
        void ContainsDuplicatesWithIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, IEqualityComparer<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsDuplicates(input1, input2, customMessage),
                expected, "Test.If.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> ContainsDuplicatesWithIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new ThrowingIEqualityComparerT(), "message", (4, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { }, new DummyIEqualityComparerT(), "message", (5, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 3 }, new DummyIEqualityComparerT(), "message", (6, true, "Enumeration contains duplicates. Enumeration is: ['1', null, null, '3']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsDuplicatesWithIEqualityComparerTWithMessageData))]
        void NotContainsDuplicatesWithIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, IEqualityComparer<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsDuplicates(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsDuplicates");

        }

        IEnumerable<Object[]> NotContainsDuplicatesWithIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, null, "message", (3, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new ThrowingIEqualityComparerT(), "message", (4, false, "Comparer threw Exception:") },
                new Object[] { typeof(Dummy), new List<Dummy>() { }, new DummyIEqualityComparerT(), "message", (5, true, "Enumeration doesn't contain duplicates. Enumeration is: []") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 3 }, new DummyIEqualityComparerT(), "message", (6, false, "message") },
            };
        }

        #endregion

        #region ContainsRange

        [TestMethod]
        [TestData(nameof(ContainsRangeData))]
        void ContainsRange(IEnumerable input1, IEnumerable input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, (3, false, "Parameter 'elements' is null.") },

                new Object[] { new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { }, (4, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { 1, 2, 3 }, (5, false, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { }, (6, true, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1 }, (7, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1, 1 }, (8, true, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1, 2, 4 }, (9, false, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 3 }, new List<DummyIEquatableT>() { 1 }, (10, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeData))]
        void NotContainsRange(IEnumerable input1, IEnumerable input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, (3, false, "Parameter 'elements' is null.") },

                new Object[] { new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { }, (4, false, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { 1, 2, 3 }, (5, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { }, (6, false, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1 }, (7, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1, 1 }, (8, false, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1, 2, 4 }, (9, true, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 3 }, new List<DummyIEquatableT>() { 1 }, (10, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        #endregion

        #region ContainsRangeWithMessage

        [TestMethod]
        [TestData(nameof(ContainsRangeWithMessageData))]
        void ContainsRangeWithMessage(IEnumerable input1, IEnumerable input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, customMessage),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'elements' is null.") },

                new Object[] { new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { }, "message", (4, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { 1, 2, 3 }, "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeWithMessageData))]
        void NotContainsRangeWithMessage(IEnumerable input1, IEnumerable input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'elements' is null.") },

                new Object[] { new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { }, "message", (4, false, "message") },
                new Object[] { new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { 1, 2, 3 }, "message", (5, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsRangeT

        [TestMethod]
        [TestData(nameof(ContainsRangeTData))]
        void ContainsRangeT<T>(IEnumerable<T> input1, IEnumerable<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, (3, false, "Parameter 'elements' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { }, (4, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { 1, 2, 3 }, (5, false, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { }, (6, true, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1 }, (7, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1, 1 }, (8, true, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1, 2, 4 }, (9, false, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 3 }, new List<DummyIEquatableT>() { 1 }, (10, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeTData))]
        void NotContainsRangeT<T>(IEnumerable<T> input1, IEnumerable<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, (3, false, "Parameter 'elements' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { }, (4, false, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { 1, 2, 3 }, (5, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { }, (6, false, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1 }, (7, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1, 1 }, (8, false, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2, 3 }, new List<DummyIEquatableT>() { 1, 2, 4 }, (9, true, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 3 }, new List<DummyIEquatableT>() { 1 }, (10, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        #endregion

        #region ContainsRangeTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsRangeTWithMessageData))]
        void ContainsRangeTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, customMessage),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'elements' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { }, "message", (4, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { 1, 2, 3 }, "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeTWithMessageData))]
        void NotContainsRangeTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'elements' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { }, "message", (4, false, "message") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { }, new List<DummyIEquatableT>() { 1, 2, 3 }, "message", (5, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsRangeEqualityComparer

        [TestMethod]
        [TestData(nameof(ContainsRangeEqualityComparerData))]
        void ContainsRangeEqualityComparer<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), new DummyEqualityComparer(), (6, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyEqualityComparer(), (7, false, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>(), new DummyEqualityComparer(), (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), (9, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 1 }, new DummyEqualityComparer(), (10, true, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 2, 4 }, new DummyEqualityComparer(), (11, false, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 3 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), (12, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeEqualityComparerData))]
        void NotContainsRangeEqualityComparer<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), new DummyEqualityComparer(), (6, false, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyEqualityComparer(), (7, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>(), new DummyEqualityComparer(), (8, false, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), (9, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 1 }, new DummyEqualityComparer(), (10, false, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 2, 4 }, new DummyEqualityComparer(), (11, true, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 3 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), (12, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        #endregion

        #region ContainsRangeEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(ContainsRangeEqualityComparerWithMessageData))]
        void ContainsRangeEqualityComparerWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), new DummyEqualityComparer(), "message", (6, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyEqualityComparer(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeEqualityComparerWithMessageData))]
        void NotContainsRangeEqualityComparerWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), new DummyEqualityComparer(), "message", (6, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyEqualityComparer(), "message", (7, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsRangeIEqualityComparer

        [TestMethod]
        [TestData(nameof(ContainsRangeIEqualityComparerData))]
        void ContainsRangeIEqualityComparer(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>(), new List<Dummy>(), new DummyIEqualityComparer(), (6, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparer(), (7, false, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new List<Dummy>(), new DummyIEqualityComparer(), (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), (9, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 1 }, new DummyIEqualityComparer(), (10, true, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 2, 4 }, new DummyIEqualityComparer(), (11, false, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { new List<Dummy>() { 1, 1, 3 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), (12, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeIEqualityComparerData))]
        void NotContainsRangeIEqualityComparer(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>(), new List<Dummy>(), new DummyIEqualityComparer(), (6, false, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparer(), (7, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new List<Dummy>(), new DummyIEqualityComparer(), (8, false, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), (9, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 1 }, new DummyIEqualityComparer(), (10, false, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 2, 4 }, new DummyIEqualityComparer(), (11, true, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { new List<Dummy>() { 1, 1, 3 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), (12, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        #endregion

        #region ContainsRangeIEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(ContainsRangeIEqualityComparerWithMessageData))]
        void ContainsRangeIEqualityComparerWithMessage(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>(), new List<Dummy>(), new DummyIEqualityComparer(), "message", (6, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparer(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeIEqualityComparerWithMessageData))]
        void NotContainsRangeIEqualityComparerWithMessage(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>(), new List<Dummy>(), new DummyIEqualityComparer(), "message", (6, false, "message") },
                new Object[] { new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparer(), "message", (7, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsRangeIEqualityComparerT

        [TestMethod]
        [TestData(nameof(ContainsRangeIEqualityComparerTData))]
        void ContainsRangeIEqualityComparerT<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), new DummyIEqualityComparerT(), (6, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparerT(), (7, false, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>(), new DummyIEqualityComparerT(), (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), (9, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 1 }, new DummyIEqualityComparerT(), (10, true, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 2, 4 }, new DummyIEqualityComparerT(), (11, false, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 3 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), (12, true, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeIEqualityComparerTData))]
        void NotContainsRangeIEqualityComparerT<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), new DummyIEqualityComparerT(), (6, false, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparerT(), (7, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>(), new DummyIEqualityComparerT(), (8, false, "Enumeration contains 0 of 0 elements. Enumeration is: ['1', '2', '3']; Elements are: []") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), (9, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 1 }, new DummyIEqualityComparerT(), (10, false, "Enumeration contains 2 of 2 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2, 3 }, new List<Dummy>() { 1, 2, 4 }, new DummyIEqualityComparerT(), (11, true, "Enumeration contains 2 of 3 elements. Enumeration is: ['1', '2', '3']; Elements are: ['1', '2', '4']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 3 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), (12, false, "Enumeration contains 1 of 1 elements. Enumeration is: ['1', '1', '3']; Elements are: ['1']") },
            };
        }

        #endregion

        #region ContainsRangeIEqualityComparerTWithMessage

        [TestMethod]
        [TestData(nameof(ContainsRangeIEqualityComparerTWithMessageData))]
        void ContainsRangeIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), new DummyIEqualityComparerT(), "message", (6, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparerT(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeIEqualityComparerTWithMessageData))]
        void NotContainsRangeIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), new DummyIEqualityComparerT(), "message", (6, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>() { 1, 2, 3 }, new DummyIEqualityComparerT(), "message", (7, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: ['1', '2', '3']") },
            };
        }

        #endregion

        #region ContainsRangeEqualityComparerKVP

        [TestMethod]
        [TestData(nameof(ContainsRangeEqualityComparerKVPData))]
        void ContainsRangeEqualityComparerKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new ThrowingEqualityComparer(), new DummyEqualityComparer(), (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new DummyEqualityComparer(), new ThrowingEqualityComparer(), (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (9, false, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (10, true, "Enumeration contains 0 of 0 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (11, false, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 3, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (12, false, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['3'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (13, true, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (14, true, "Enumeration contains 2 of 2 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 5 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (15, false, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '5']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 6, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (16, false, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['6'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (17, true, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeEqualityComparerKVPData))]
        void NotContainsRangeEqualityComparerKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new ThrowingEqualityComparer(), new DummyEqualityComparer(), (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new DummyEqualityComparer(), new ThrowingEqualityComparer(), (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (8, false, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (9, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (10, false, "Enumeration contains 0 of 0 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (11, true, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 3, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (12, true, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['3'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (13, false, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (14, false, "Enumeration contains 2 of 2 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 5 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (15, true, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '5']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 6, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (16, true, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['6'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (17, false, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
            };
        }

        #endregion

        #region ContainsRangeEqualityComparerKVPWithMessage

        [TestMethod]
        [TestData(nameof(ContainsRangeEqualityComparerKVPWithMessageData))]
        void ContainsRangeEqualityComparerKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new ThrowingEqualityComparer(), new DummyEqualityComparer(), "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new DummyEqualityComparer(), new ThrowingEqualityComparer(), "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeEqualityComparerKVPWithMessageData))]
        void NotContainsRangeEqualityComparerKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new ThrowingEqualityComparer(), new DummyEqualityComparer(), "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new DummyEqualityComparer(), new ThrowingEqualityComparer(), "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (8, false, "message") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (9, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region ContainsRangeIEqualityComparerKVP

        [TestMethod]
        [TestData(nameof(ContainsRangeIEqualityComparerKVPData))]
        void ContainsRangeIEqualityComparerKVP(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeIEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), null, new DummyIEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new ThrowingIEqualityComparer(), new DummyIEqualityComparer(), (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new DummyIEqualityComparer(), new ThrowingIEqualityComparer(), (7, false, "Value comparer threw Exception:") },

                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (9, false, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (10, true, "Enumeration contains 0 of 0 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: []") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 3) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (11, false, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '3']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 3, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (12, false, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['3'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (13, true, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (14, true, "Enumeration contains 2 of 2 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 5) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (15, false, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '5']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 6, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (16, false, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['6'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (17, true, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeIEqualityComparerKVPData))]
        void NotContainsRangeIEqualityComparerKVP(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeIEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), null, new DummyIEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new ThrowingIEqualityComparer(), new DummyIEqualityComparer(), (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new DummyIEqualityComparer(), new ThrowingIEqualityComparer(), (7, false, "Value comparer threw Exception:") },

                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (8, false, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (9, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (10, false, "Enumeration contains 0 of 0 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: []") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 3) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (11, true, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '3']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 3, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (12, true, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['3'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (13, false, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (14, false, "Enumeration contains 2 of 2 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 5) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (15, true, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '5']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 6, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (16, true, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['6'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (17, false, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
            };
        }

        #endregion

        #region ContainsRangeIEqualityComparerKVPWithMessage

        [TestMethod]
        [TestData(nameof(ContainsRangeIEqualityComparerKVPWithMessageData))]
        void ContainsRangeIEqualityComparerKVPWithMessage(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeIEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), null, new DummyIEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new ThrowingIEqualityComparer(), new DummyIEqualityComparer(), "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new DummyIEqualityComparer(), new ThrowingIEqualityComparer(), "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeIEqualityComparerKVPWithMessageData))]
        void NotContainsRangeIEqualityComparerKVPWithMessage(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeIEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), null, new DummyIEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new ThrowingIEqualityComparer(), new DummyIEqualityComparer(), "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new DummyIEqualityComparer(), new ThrowingIEqualityComparer(), "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { Enumerable.Empty<DictionaryEntry>(), Enumerable.Empty<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (8, false, "message") },
                new Object[] { Enumerable.Empty<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (9, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region ContainsRangeIEqualityComparerTKVP

        [TestMethod]
        [TestData(nameof(ContainsRangeIEqualityComparerTKVPData))]
        void ContainsRangeIEqualityComparerTKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeIEqualityComparerTKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(), (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(), (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (9, false, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (10, true, "Enumeration contains 0 of 0 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (11, false, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 3, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (12, false, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['3'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (13, true, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (14, true, "Enumeration contains 2 of 2 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 5 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (15, false, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '5']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 6, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (16, false, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['6'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (17, true, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeIEqualityComparerTKVPData))]
        void NotContainsRangeIEqualityComparerTKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeIEqualityComparerTKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(), (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(), (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (8, false, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (9, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (10, false, "Enumeration contains 0 of 0 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (11, true, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 3, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (12, true, "Enumeration contains 0 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['3'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (13, false, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (14, false, "Enumeration contains 2 of 2 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 5 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (15, true, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '5']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 6, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (16, true, "Enumeration contains 2 of 3 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2', ['3'] => '4', ['6'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (17, false, "Enumeration contains 1 of 1 elements. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Elements are: [['1'] => '2']") },
            };
        }

        #endregion

        #region ContainsRangeIEqualityComparerTKVPWithMessage

        [TestMethod]
        [TestData(nameof(ContainsRangeIEqualityComparerTKVPWithMessageData))]
        void ContainsRangeIEqualityComparerTKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.ContainsRange(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> ContainsRangeIEqualityComparerTKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(), "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (8, true, "Enumeration contains 0 of 0 elements. Enumeration is: []; Elements are: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotContainsRangeIEqualityComparerTKVPWithMessageData))]
        void NotContainsRangeIEqualityComparerTKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.ContainsRange(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.ContainsRange");

        }

        IEnumerable<Object[]> NotContainsRangeIEqualityComparerTKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'elements' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } },
                    new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(), "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (8, false, "message") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (9, true, "Enumeration contains 0 of 3 elements. Enumeration is: []; Elements are: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region Matches

        [TestMethod]
        [TestData(nameof(MatchesData))]
        void Matches(IEnumerable input1, IEnumerable input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, (3, false, "Parameter 'other' is null.") },

                new Object[] { new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, (4, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, (5, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (6, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (7, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (8, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (9, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 1 }, (10, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 2 }, (11, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, null, 2 }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (12, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 2, null }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (13, true, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesData))]
        void NotMatches(IEnumerable input1, IEnumerable input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, (3, false, "Parameter 'other' is null.") },

                new Object[] { new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, (4, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, (5, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (6, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (7, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (8, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (9, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 1 }, (10, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 2 }, (11, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, null, 2 }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (12, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 2, null }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (13, false, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesWithMessage

        [TestMethod]
        [TestData(nameof(MatchesWithMessageData))]
        void MatchesWithMessage(IEnumerable input1, IEnumerable input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, customMessage),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'other' is null.") },

                new Object[] { new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, "message", (4, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesWithMessageData))]
        void NotMatchesWithMessage(IEnumerable input1, IEnumerable input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'other' is null.") },

                new Object[] { new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, "message", (4, false, "message") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, "message", (5, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
            };
        }

        #endregion

        #region MatchesT

        [TestMethod]
        [TestData(nameof(MatchesTData))]
        void MatchesT<T>(IEnumerable<T> input1, IEnumerable<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, (3, false, "Parameter 'other' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, (4, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, (5, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (6, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (7, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (8, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (9, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 1 }, (10, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 2 }, (11, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, null, 2 }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (12, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 2, null }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (13, true, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesTData))]
        void NotMatchesT<T>(IEnumerable<T> input1, IEnumerable<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, (3, false, "Parameter 'other' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, (4, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, (5, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (6, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (7, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (8, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (9, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 1 }, (10, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 2 }, (11, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, null, 2 }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (12, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 2, null }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (13, false, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesTWithMessage

        [TestMethod]
        [TestData(nameof(MatchesTWithMessageData))]
        void MatchesTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, customMessage),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'other' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, "message", (4, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesTWithMessageData))]
        void NotMatchesTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'other' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, "message", (4, false, "message") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, "message", (5, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
            };
        }

        #endregion

        #region MatchesEqualityComparer

        [TestMethod]
        [TestData(nameof(MatchesEqualityComparerData))]
        void MatchesEqualityComparer<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyEqualityComparer(), (7, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), (8, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), (9, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyEqualityComparer(), (10, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyEqualityComparer(), (11, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyEqualityComparer(), (12, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyEqualityComparer(), (13, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyEqualityComparer(), (14, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyEqualityComparer(), (15, true, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesEqualityComparerData))]
        void NotMatchesEqualityComparer<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), (6, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyEqualityComparer(), (7, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), (8, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), (9, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyEqualityComparer(), (10, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyEqualityComparer(), (11, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyEqualityComparer(), (12, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyEqualityComparer(), (13, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyEqualityComparer(), (14, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyEqualityComparer(), (15, false, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(MatchesEqualityComparerWithMessageData))]
        void MatchesEqualityComparerWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), "message", (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesEqualityComparerWithMessageData))]
        void NotMatchesEqualityComparerWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), "message", (6, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), "message", (7, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
            };
        }

        #endregion

        #region MatchesIEqualityComparer

        [TestMethod]
        [TestData(nameof(MatchesIEqualityComparerData))]
        void MatchesIEqualityComparer(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparer(), (7, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), (8, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), (9, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparer(), (10, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparer(), (11, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyIEqualityComparer(), (12, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyIEqualityComparer(), (13, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparer(), (14, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparer(), (15, true, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesIEqualityComparerData))]
        void NotMatchesIEqualityComparer(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), (6, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparer(), (7, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), (8, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), (9, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparer(), (10, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparer(), (11, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyIEqualityComparer(), (12, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyIEqualityComparer(), (13, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparer(), (14, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparer(), (15, false, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesIEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(MatchesIEqualityComparerWithMessageData))]
        void MatchesIEqualityComparerWithMessage(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), "message", (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesIEqualityComparerWithMessageData))]
        void NotMatchesIEqualityComparerWithMessage(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), "message", (6, false, "message") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), "message", (7, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
            };
        }

        #endregion

        #region MatchesIEqualityComparerT

        [TestMethod]
        [TestData(nameof(MatchesIEqualityComparerTData))]
        void MatchesIEqualityComparerT<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparerT(), (7, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), (8, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), (9, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparerT(), (10, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparerT(), (11, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyIEqualityComparerT(), (12, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyIEqualityComparerT(), (13, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparerT(), (14, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparerT(), (15, true, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesIEqualityComparerTData))]
        void NotMatchesIEqualityComparerT<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), (6, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparerT(), (7, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), (8, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), (9, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparerT(), (10, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparerT(), (11, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyIEqualityComparerT(), (12, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyIEqualityComparerT(), (13, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparerT(), (14, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparerT(), (15, false, "Enumerations match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesIEqualityComparerTWithMessage

        [TestMethod]
        [TestData(nameof(MatchesIEqualityComparerTWithMessageData))]
        void MatchesIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), "message", (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesIEqualityComparerTWithMessageData))]
        void NotMatchesIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), "message", (6, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), "message", (7, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
            };
        }

        #endregion

        #region MatchesEqualityComparerKVP

        [TestMethod]
        [TestData(nameof(MatchesEqualityComparerKVPData))]
        void MatchesEqualityComparerKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (9, false, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (10, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (11, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 2, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (12, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (13, true, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 3, 4 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (14, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (15, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (16, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (17, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (18, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (19, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (20, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesEqualityComparerKVPData))]
        void NotMatchesEqualityComparerKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (8, false, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (10, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (11, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 2, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (12, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (13, false, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 3, 4 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (14, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (15, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (16, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (17, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (18, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (19, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (20, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        #endregion

        #region MatchesEqualityComparerKVPWithMessage

        [TestMethod]
        [TestData(nameof(MatchesEqualityComparerKVPWithMessageData))]
        void MatchesEqualityComparerKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesEqualityComparerKVPWithMessageData))]
        void NotMatchesEqualityComparerKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (8, false, "message") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region MatchesIEqualityComparerKVP

        [TestMethod]
        [TestData(nameof(MatchesIEqualityComparerKVPData))]
        void MatchesIEqualityComparerKVP(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesIEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new ThrowingIEqualityComparer(), new DummyIEqualityComparer(), (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new DummyIEqualityComparer(), new ThrowingIEqualityComparer(), (7, false, "Value comparer threw Exception:") },

                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (9, false, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (10, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 3) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (11, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 2, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (12, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (13, true, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (14, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (15, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (16, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (17, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (18, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (19, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (20, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesIEqualityComparerKVPData))]
        void NotMatchesIEqualityComparerKVP(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesIEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new ThrowingIEqualityComparer(), new DummyIEqualityComparer(), (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new DummyIEqualityComparer(), new ThrowingIEqualityComparer(), (7, false, "Value comparer threw Exception:") },

                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (8, false, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (10, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 3) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (11, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 2, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (12, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (13, false, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (14, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (15, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (16, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (17, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (18, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (19, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (20, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        #endregion

        #region MatchesIEqualityComparerKVPWithMessage

        [TestMethod]
        [TestData(nameof(MatchesIEqualityComparerKVPWithMessageData))]
        void MatchesIEqualityComparerKVPWithMessage(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesIEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new ThrowingIEqualityComparer(), new DummyIEqualityComparer(), "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new DummyIEqualityComparer(), new ThrowingIEqualityComparer(), "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesIEqualityComparerKVPWithMessageData))]
        void NotMatchesIEqualityComparerKVPWithMessage(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesIEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new ThrowingIEqualityComparer(), new DummyIEqualityComparer(), "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) },
                    new DummyIEqualityComparer(), new ThrowingIEqualityComparer(), "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (8, false, "message") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region MatchesIEqualityComparerTKVP

        [TestMethod]
        [TestData(nameof(MatchesIEqualityComparerTKVPData))]
        void MatchesIEqualityComparerTKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesIEqualityComparerTKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (9, false, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (10, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (11, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 2, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (12, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (13, true, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 3, 4 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (14, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (15, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (16, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (17, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (18, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (19, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (20, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesIEqualityComparerTKVPData))]
        void NotMatchesIEqualityComparerTKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesIEqualityComparerTKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (8, false, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (10, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (11, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 2, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (12, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (13, false, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 3, 4 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (14, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (15, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (16, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (17, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (18, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (19, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (20, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        #endregion

        #region MatchesIEqualityComparerTKVPWithMessage

        [TestMethod]
        [TestData(nameof(MatchesIEqualityComparerTKVPWithMessageData))]
        void MatchesIEqualityComparerTKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.Matches(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.Matches");

        }

        IEnumerable<Object[]> MatchesIEqualityComparerTKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesIEqualityComparerTKVPWithMessageData))]
        void NotMatchesIEqualityComparerTKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.Matches(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.Matches");

        }

        IEnumerable<Object[]> NotMatchesIEqualityComparerTKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (8, false, "message") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region MatchesExactly

        [TestMethod]
        [TestData(nameof(MatchesExactlyData))]
        void MatchesExactly(IEnumerable input1, IEnumerable input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, (3, false, "Parameter 'other' is null.") },

                new Object[] { new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, (4, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, (5, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (6, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (7, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (8, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (9, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 1 }, (10, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 2 }, (11, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, null, 2 }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (12, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 2, null }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (13, false, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyData))]
        void NotMatchesExactly(IEnumerable input1, IEnumerable input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, (3, false, "Parameter 'other' is null.") },

                new Object[] { new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, (4, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, (5, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (6, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (7, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (8, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (9, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 1 }, (10, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 2 }, (11, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, null, 2 }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (12, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { new List<DummyIEquatableT>() { 1, null, 2, null }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (13, true, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesExactlyWithMessage

        [TestMethod]
        [TestData(nameof(MatchesExactlyWithMessageData))]
        void MatchesExactlyWithMessage(IEnumerable input1, IEnumerable input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, customMessage),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'other' is null.") },

                new Object[] { new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, "message", (4, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyWithMessageData))]
        void NotMatchesExactlyWithMessage(IEnumerable input1, IEnumerable input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'other' is null.") },

                new Object[] { new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, "message", (4, false, "message") },
                new Object[] { new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, "message", (5, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
            };
        }

        #endregion

        #region MatchesExactlyT

        [TestMethod]
        [TestData(nameof(MatchesExactlyTData))]
        void MatchesExactlyT<T>(IEnumerable<T> input1, IEnumerable<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, (3, false, "Parameter 'other' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, (4, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, (5, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (6, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (7, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (8, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (9, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 1 }, (10, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 2 }, (11, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, null, 2 }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (12, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 2, null }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (13, false, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyTData))]
        void NotMatchesExactlyT<T>(IEnumerable<T> input1, IEnumerable<T> input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyTData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, (3, false, "Parameter 'other' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, (4, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, (5, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (6, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2 }, (7, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (8, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 1, 2 }, (9, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 1 }, (10, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 1, 2 }, new List<DummyIEquatableT>() { 1, 2, 2 }, (11, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, null, 2 }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (12, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, null, 2, null }, new List<DummyIEquatableT>() { 1, null, null, 2 }, (13, true, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesExactlyTWithMessage

        [TestMethod]
        [TestData(nameof(MatchesExactlyTWithMessageData))]
        void MatchesExactlyTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, customMessage),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'other' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, "message", (4, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, "message", (5, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyTWithMessageData))]
        void NotMatchesExactlyTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, customMessage),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(DummyIEquatableT), null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), null, new List<DummyIEquatableT>(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>(), null, "message", (3, false, "Parameter 'other' is null.") },

                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1 }, new List<DummyIEquatableT>() { 1 }, "message", (4, false, "message") },
                new Object[] { typeof(DummyIEquatableT), new List<DummyIEquatableT>() { 1, 2 }, new List<DummyIEquatableT>() { 2, 1 }, "message", (5, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
            };
        }

        #endregion

        #region MatchesExactlyEqualityComparer

        [TestMethod]
        [TestData(nameof(MatchesExactlyEqualityComparerData))]
        void MatchesExactlyEqualityComparer<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyEqualityComparer(), (7, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), (8, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), (9, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyEqualityComparer(), (10, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyEqualityComparer(), (11, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyEqualityComparer(), (12, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyEqualityComparer(), (13, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyEqualityComparer(), (14, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyEqualityComparer(), (15, false, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyEqualityComparerData))]
        void NotMatchesExactlyEqualityComparer<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), (6, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyEqualityComparer(), (7, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), (8, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyEqualityComparer(), (9, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyEqualityComparer(), (10, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyEqualityComparer(), (11, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyEqualityComparer(), (12, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyEqualityComparer(), (13, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyEqualityComparer(), (14, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyEqualityComparer(), (15, true, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesExactlyEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(MatchesExactlyEqualityComparerWithMessageData))]
        void MatchesExactlyEqualityComparerWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), "message", (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyEqualityComparer(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyEqualityComparerWithMessageData))]
        void NotMatchesExactlyEqualityComparerWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, EqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyEqualityComparer(), "message", (6, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyEqualityComparer(), "message", (7, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
            };
        }

        #endregion

        #region MatchesExactlyIEqualityComparer

        [TestMethod]
        [TestData(nameof(MatchesExactlyIEqualityComparerData))]
        void MatchesExactlyIEqualityComparer(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparer(), (7, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), (8, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), (9, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparer(), (10, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparer(), (11, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyIEqualityComparer(), (12, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyIEqualityComparer(), (13, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparer(), (14, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparer(), (15, false, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyIEqualityComparerData))]
        void NotMatchesExactlyIEqualityComparer(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyIEqualityComparerData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), (6, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparer(), (7, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), (8, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparer(), (9, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparer(), (10, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparer(), (11, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyIEqualityComparer(), (12, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyIEqualityComparer(), (13, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparer(), (14, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparer(), (15, true, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesExactlyIEqualityComparerWithMessage

        [TestMethod]
        [TestData(nameof(MatchesExactlyIEqualityComparerWithMessageData))]
        void MatchesExactlyIEqualityComparerWithMessage(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), "message", (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparer(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyIEqualityComparerWithMessageData))]
        void NotMatchesExactlyIEqualityComparerWithMessage(IEnumerable input1, IEnumerable input2, IEqualityComparer input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyIEqualityComparerWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<Dummy>(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<Dummy>(), null, new DummyIEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparer(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparer(), "message", (6, false, "message") },
                new Object[] { new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparer(), "message", (7, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
            };
        }

        #endregion

        #region MatchesExactlyIEqualityComparerT

        [TestMethod]
        [TestData(nameof(MatchesExactlyIEqualityComparerTData))]
        void MatchesExactlyIEqualityComparerT<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparerT(), (7, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), (8, true, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), (9, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparerT(), (10, false, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparerT(), (11, true, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyIEqualityComparerT(), (12, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyIEqualityComparerT(), (13, false, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparerT(), (14, true, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparerT(), (15, false, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyIEqualityComparerTData))]
        void NotMatchesExactlyIEqualityComparerT<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyIEqualityComparerTData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), (6, false, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparerT(), (7, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), (8, false, "Enumerations match. Enumeration is: ['1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2 }, new DummyIEqualityComparerT(), (9, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparerT(), (10, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 1, 2 }, new DummyIEqualityComparerT(), (11, false, "Enumerations match. Enumeration is: ['1', '1', '2']; Other is: ['1', '1', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 1 }, new DummyIEqualityComparerT(), (12, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 1, 2 }, new List<Dummy>() { 1, 2, 2 }, new DummyIEqualityComparerT(), (13, true, "Enumerations don't match. Enumeration is: ['1', '1', '2']; Other is: ['1', '2', '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, null, 2 }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparerT(), (14, false, "Enumerations match. Enumeration is: ['1', null, null, '2']; Other is: ['1', null, null, '2']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, null, 2, null }, new List<Dummy>() { 1, null, null, 2 }, new DummyIEqualityComparerT(), (15, true, "Enumerations don't match. Enumeration is: ['1', null, '2', null]; Other is: ['1', null, null, '2']") },
            };
        }

        #endregion

        #region MatchesExactlyIEqualityComparerTWithMessage

        [TestMethod]
        [TestData(nameof(MatchesExactlyIEqualityComparerTWithMessageData))]
        void MatchesExactlyIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, customMessage),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), "message", (6, true, "Enumerations match. Enumeration is: ['1']; Other is: ['1']") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparerT(), "message", (7, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyIEqualityComparerTWithMessageData))]
        void NotMatchesExactlyIEqualityComparerTWithMessage<T>(IEnumerable<T> input1, IEnumerable<T> input2, IEqualityComparer<T> input3, String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, customMessage),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyIEqualityComparerTWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), null, new List<Dummy>(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), null, new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>(), new List<Dummy>(), null, "message", (4, false, "Parameter 'comparer' is null.") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new ThrowingIEqualityComparerT(), "message", (5, false, "Comparer threw Exception:") },

                new Object[] { typeof(Dummy), new List<Dummy>() { 1 }, new List<Dummy>() { 1 }, new DummyIEqualityComparerT(), "message", (6, false, "message") },
                new Object[] { typeof(Dummy), new List<Dummy>() { 1, 2 }, new List<Dummy>() { 2, 1 }, new DummyIEqualityComparerT(), "message", (7, true, "Enumerations don't match. Enumeration is: ['1', '2']; Other is: ['2', '1']") },
            };
        }

        #endregion

        #region MatchesExactlyEqualityComparerKVP

        [TestMethod]
        [TestData(nameof(MatchesExactlyEqualityComparerKVPData))]
        void MatchesExactlyEqualityComparerKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (9, false, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (10, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (11, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 2, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (12, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (13, true, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 3, 4 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (14, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (15, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (16, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (17, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (18, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (19, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (20, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyEqualityComparerKVPData))]
        void NotMatchesExactlyEqualityComparerKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (8, false, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (10, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (11, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 2, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (12, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (13, false, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 3, 4 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (14, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (15, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (16, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (17, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (18, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (19, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 3, 4 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    (20, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        #endregion

        #region MatchesExactlyEqualityComparerKVPWithMessage

        [TestMethod]
        [TestData(nameof(MatchesExactlyEqualityComparerKVPWithMessageData))]
        void MatchesExactlyEqualityComparerKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyEqualityComparerKVPWithMessageData))]
        void NotMatchesExactlyEqualityComparerKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, EqualityComparer<TKey> input3, EqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), new DummyEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingEqualityComparer(), new DummyEqualityComparer(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyEqualityComparer(), new ThrowingEqualityComparer(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (8, false, "message") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyEqualityComparer(), new DummyEqualityComparer(),
                    "message", (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region MatchesExactlyIEqualityComparerKVP

        [TestMethod]
        [TestData(nameof(MatchesExactlyIEqualityComparerKVPData))]
        void MatchesExactlyIEqualityComparerKVP(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyIEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new ThrowingIEqualityComparer(), new DummyIEqualityComparer(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new ThrowingIEqualityComparer(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (9, false, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (10, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 3) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (11, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 2, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (12, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (13, true, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (14, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (15, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (16, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (17, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (18, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (19, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (20, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyIEqualityComparerKVPData))]
        void NotMatchesExactlyIEqualityComparerKVP(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyIEqualityComparerKVPData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new ThrowingIEqualityComparer(), new DummyIEqualityComparer(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new ThrowingIEqualityComparer(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (8, false, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (10, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 3) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (11, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 2, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (12, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (13, false, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (14, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (15, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (16, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (17, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (18, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (19, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 3, (Dummy) 4) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    (20, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        #endregion

        #region MatchesExactlyIEqualityComparerKVPWithMessage

        [TestMethod]
        [TestData(nameof(MatchesExactlyIEqualityComparerKVPWithMessageData))]
        void MatchesExactlyIEqualityComparerKVPWithMessage(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyIEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new ThrowingIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new ThrowingIEqualityComparer(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyIEqualityComparerKVPWithMessageData))]
        void NotMatchesExactlyIEqualityComparerKVPWithMessage(IEnumerable<DictionaryEntry> input1, IEnumerable<DictionaryEntry> input2, IEqualityComparer input3, IEqualityComparer input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyIEqualityComparerKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { null, new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), new DummyIEqualityComparer(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), null, new DummyIEqualityComparer(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new ThrowingIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2) }, new DummyIEqualityComparer(), new ThrowingIEqualityComparer(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>(), new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (8, false, "message") },
                new Object[] { new List<DictionaryEntry>(), new List<DictionaryEntry>() { new DictionaryEntry((Dummy) 1, (Dummy) 2), new DictionaryEntry((Dummy) 3, (Dummy) 4), new DictionaryEntry((Dummy) 5, (Dummy) 6) }, new DummyIEqualityComparer(), new DummyIEqualityComparer(),
                    "message", (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

        #region MatchesExactlyIEqualityComparerTKVP

        [TestMethod]
        [TestData(nameof(MatchesExactlyIEqualityComparerTKVPData))]
        void MatchesExactlyIEqualityComparerTKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, input4),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyIEqualityComparerTKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (9, false, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (10, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (11, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 2, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (12, false, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (13, true, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 3, 4 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (14, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (15, true, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (16, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (17, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (18, true, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (19, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (20, false, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyIEqualityComparerTKVPData))]
        void NotMatchesExactlyIEqualityComparerTKVP<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, input4),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyIEqualityComparerTKVPData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (8, false, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (10, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4', ['5'] => '6']; Other is: []") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 3 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (11, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '3']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 2, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (12, true, "Enumerations don't match. Enumeration is: [['1'] => '2']; Other is: [['2'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (13, false, "Enumerations match. Enumeration is: [['1'] => '2']; Other is: [['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 3, 4 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (14, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (15, false, "Enumerations match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (16, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (17, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (18, false, "Enumerations match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['1'] => '2', ['3'] => '4']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (19, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['1'] => '2']") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 1, 2 }, { 3, 4 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 3, 4 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    (20, true, "Enumerations don't match. Enumeration is: [['1'] => '2', ['1'] => '2', ['3'] => '4']; Other is: [['1'] => '2', ['3'] => '4', ['3'] => '4']") },
            };
        }

        #endregion

        #region MatchesExactlyIEqualityComparerTKVPWithMessage

        [TestMethod]
        [TestData(nameof(MatchesExactlyIEqualityComparerTKVPWithMessageData))]
        void MatchesExactlyIEqualityComparerTKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Enumerable.MatchesExactly(input1, input2, input3, input4, customMessage),
                expected, "Test.If.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> MatchesExactlyIEqualityComparerTKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (8, true, "Enumerations match. Enumeration is: []; Other is: []") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (9, false, "message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotMatchesExactlyIEqualityComparerTKVPWithMessageData))]
        void NotMatchesExactlyIEqualityComparerTKVPWithMessage<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> input1, IEnumerable<KeyValuePair<TKey, TValue>> input2, IEqualityComparer<TKey> input3, IEqualityComparer<TValue> input4,
            String customMessage, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Enumerable.MatchesExactly(input1, input2, input3, input4, customMessage),
                expected, "Test.IfNot.Enumerable.MatchesExactly");

        }

        IEnumerable<Object[]> NotMatchesExactlyIEqualityComparerTKVPWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(Dummy), typeof(Dummy), null, null, null, null, "message", (1, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), null, new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (2, false, "Parameter 'enumeration' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(), "message", (3, false, "Parameter 'other' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), null, new DummyIEqualityComparerT(), "message", (4, false, "Parameter 'keyComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), null, "message", (5, false, "Parameter 'valueComparer' is null.") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new ThrowingIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (6, false, "Key comparer threw Exception:") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new Dictionary<Dummy, Dummy>() { { 1, 2 } }, new DummyIEqualityComparerT(), new ThrowingIEqualityComparerT(),
                    "message", (7, false, "Value comparer threw Exception:") },

                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>(), new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (8, false, "message") },
                new Object[] { typeof(Dummy), typeof(Dummy), new Dictionary<Dummy, Dummy>(), new Dictionary<Dummy, Dummy>() { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new DummyIEqualityComparerT(), new DummyIEqualityComparerT(),
                    "message", (9, true, "Enumerations don't match. Enumeration is: []; Other is: [['1'] => '2', ['3'] => '4', ['5'] => '6']") },
            };
        }

        #endregion

    }
}
