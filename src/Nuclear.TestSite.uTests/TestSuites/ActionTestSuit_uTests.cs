using System;
using System.Collections.Generic;
using System.ComponentModel;

using Nuclear.TestSite.TestComparers;
using Nuclear.TestSite.TestTypes;

namespace Nuclear.TestSite.TestSuites {
    class ActionTestSuit_uTests {

        #region ThrowsException

        [TestMethod]
        [TestData(nameof(ThrowsExceptionData))]
        void ThrowsException<TException>(Action input1, String input2,
            (Int32 count, Boolean result, String message, Boolean exceptionThrown, String exMessage) expected)
            where TException : Exception {

            TException ex = null;

            Statics.DDTResultState(() => DummyTest.If.Action.ThrowsException(input1, out ex),
                (expected.count, expected.result, expected.message), "Test.If.Action.ThrowsException");

            if(expected.exceptionThrown) {
                Test.IfNot.Object.IsNull(ex);
                Test.If.String.StartsWith(ex.Message, expected.exMessage);
            }

        }

        IEnumerable<Object[]> ThrowsExceptionData() {
            return new List<Object[]>() {
                new Object[] { typeof(SystemException), null, null,
                    (1, false, "Parameter 'action' is null.", false, "") },
                new Object[] { typeof(Exception), new Action(() => { }), "() => {{ }}",
                    (2, false, "[Exception = null]", false, "") },
                new Object[] { typeof(SystemException), new Action(() => throw new ArgumentException("test message")), "() => {{ throw new ArgumentException(\"test message\"); }}",
                    (3, true, "[Exception = 'System.ArgumentException", true, "test message") },
                new Object[] { typeof(NullReferenceException), new Action(() => throw new ArgumentException("test message")), "() => {{ throw new ArgumentException(\"test message\"); }}",
                    (4, false, "[Exception = null]", false, "") },
                new Object[] { typeof(Exception), new Action(() => throw new Exception("test message")), "() => {{ throw new Exception(\"test message\"); }}",
                    (5, true, "[Exception = 'System.Exception", true, "test message") },
                new Object[] { typeof(SystemException), new Action(() => throw new Exception("test message")), "() => {{ throw new Exception(\"test message\"); }}",
                    (6, false, "[Exception = null]", false, "") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotThrowsExceptionData))]
        void NotThrowsException<TException>(Action input1, String input2,
            (Int32 count, Boolean result, String message, Boolean exceptionThrown, String exMessage) expected)
            where TException : Exception {

            TException ex = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.ThrowsException(input1, out ex),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.ThrowsException");

            if(expected.exceptionThrown) {
                Test.IfNot.Object.IsNull(ex);
                Test.If.String.StartsWith(ex.Message, expected.exMessage);
            }

        }

        IEnumerable<Object[]> NotThrowsExceptionData() {
            return new List<Object[]>() {
                new Object[] { typeof(SystemException), null, null,
                    (1, false, "Parameter 'action' is null.", false, "") },
                new Object[] { typeof(Exception), new Action(() => { }), "() => {{ }}",
                    (2, true, "[Exception = null]", false, "") },
                new Object[] { typeof(SystemException), new Action(() => throw new ArgumentException("test message")), "() => {{ throw new ArgumentException(\"test message\"); }}",
                    (3, false, "[Exception = 'System.ArgumentException", true, "test message") },
                new Object[] { typeof(NullReferenceException), new Action(() => throw new ArgumentException("test message")), "() => {{ throw new ArgumentException(\"test message\"); }}",
                    (4, true, "[Exception = null]", false, "") },
                new Object[] { typeof(Exception), new Action(() => throw new Exception("test message")), "() => {{ throw new Exception(\"test message\"); }}",
                    (5, false, "[Exception = 'System.Exception", true, "test message") },
                new Object[] { typeof(SystemException), new Action(() => throw new Exception("test message")), "() => {{ throw new Exception(\"test message\"); }}",
                    (6, true, "[Exception = null]", false, "") },
            };
        }

        #endregion

        #region ThrowsExceptionWithMessage

        [TestMethod]
        [TestData(nameof(ThrowsExceptionWithMessageData))]
        void ThrowsExceptionWithMessage<TException>(Action input1, String input2, String customMessage,
            (Int32 count, Boolean result, String message, Boolean exceptionThrown, String exMessage) expected)
            where TException : Exception {

            TException ex = null;

            Statics.DDTResultState(() => DummyTest.If.Action.ThrowsException(input1, out ex, customMessage),
                (expected.count, expected.result, expected.message), "Test.If.Action.ThrowsException");

            if(expected.exceptionThrown) {
                Test.IfNot.Object.IsNull(ex);
                Test.If.String.StartsWith(ex.Message, expected.exMessage);
            }

        }

        IEnumerable<Object[]> ThrowsExceptionWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(SystemException), null, null, "message",
                    (1, false, "Parameter 'action' is null.", false, "") },
                new Object[] { typeof(Exception), new Action(() => { }), "() => {{ }}", "message",
                    (2, false, "message", false, "") },
                new Object[] { typeof(SystemException), new Action(() => throw new ArgumentException("test message")), "() => {{ throw new ArgumentException(\"test message\"); }}", "message",
                    (3, true, "[Exception = 'System.ArgumentException", true, "test message") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotThrowsExceptionWithMessageData))]
        void NotThrowsExceptionWithMessage<TException>(Action input1, String input2, String customMessage,
            (Int32 count, Boolean result, String message, Boolean exceptionThrown, String exMessage) expected)
            where TException : Exception {

            TException ex = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.ThrowsException(input1, out ex, customMessage),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.ThrowsException");

            if(expected.exceptionThrown) {
                Test.IfNot.Object.IsNull(ex);
                Test.If.String.StartsWith(ex.Message, expected.exMessage);
            }

        }

        IEnumerable<Object[]> NotThrowsExceptionWithMessageData() {
            return new List<Object[]>() {
                new Object[] { typeof(SystemException), null, null, "message",
                    (1, false, "Parameter 'action' is null.", false, "") },
                new Object[] { typeof(Exception), new Action(() => { }), "() => {{ }}", "message",
                    (2, true, "[Exception = null]", false, "") },
                new Object[] { typeof(SystemException), new Action(() => throw new ArgumentException("test message")), "() => {{ throw new ArgumentException(\"test message\"); }}", "message",
                    (3, false, "message", true, "test message") },
            };
        }

        #endregion

        #region RaisesPropertyChangedEvent

        [TestMethod]
        [TestData(nameof(RaisesPropertyChangedEventData))]
        void RaisesPropertyChangedEvent(Action input1, INotifyPropertyChanged input2, String input3,
            (Int32 count, Boolean result, String message, EventData<PropertyChangedEventArgs> eventData) expected) {

            EventData<PropertyChangedEventArgs> eventData = null;

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesPropertyChangedEvent(input1, input2, out eventData),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesPropertyChangedEvent");

            if(expected.eventData != null) {
                Test.If.Value.IsEqual(eventData, expected.eventData, new PropertyChangedEventDataEqualityComparer());
            }

        }

        IEnumerable<Object[]> RaisesPropertyChangedEventData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { null, null, null,
                    (1, false, "Parameter 'action' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { null, pccObject, null,
                    (2, false, "Parameter 'action' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => { }), null, "() => {{ }}",
                    (3, false, "Parameter 'object' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => { }), pccObject, "() => {{ }}",
                    (4, false, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => throw new Exception()), pccObject, "() => {{ throw new Exception(); }}",
                    (5, false, "Action threw Exception:", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}",
                    (6, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))) },
            };
        }

        [TestMethod]
        [TestData(nameof(NotRaisesPropertyChangedEventData))]
        void NotRaisesPropertyChangedEvent(Action input1, INotifyPropertyChanged input2, String input3,
            (Int32 count, Boolean result, String message, EventData<PropertyChangedEventArgs> eventData) expected) {

            EventData<PropertyChangedEventArgs> eventData = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesPropertyChangedEvent(input1, input2, out eventData),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesPropertyChangedEvent");

            if(expected.eventData != null) {
                Test.If.Value.IsEqual(eventData, expected.eventData, new PropertyChangedEventDataEqualityComparer());
            }

        }

        IEnumerable<Object[]> NotRaisesPropertyChangedEventData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { null, null, null,
                    (1, false, "Parameter 'action' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { null, pccObject, null,
                    (2, false, "Parameter 'action' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => { }), null, "() => {{ }}",
                    (3, false, "Parameter 'object' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => { }), pccObject, "() => {{ }}",
                    (4, true, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => throw new Exception()), pccObject, "() => {{ throw new Exception(); }}",
                    (5, false, "Action threw Exception:", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}",
                    (6, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))) },
            };
        }

        #endregion

        #region RaisesPropertyChangedEventWithMessage

        [TestMethod]
        [TestData(nameof(RaisesPropertyChangedEventWithMessageData))]
        void RaisesPropertyChangedEventWithMessage(Action input1, INotifyPropertyChanged input2, String input3, String customMessage,
            (Int32 count, Boolean result, String message, EventData<PropertyChangedEventArgs> eventData) expected) {

            EventData<PropertyChangedEventArgs> eventData = null;

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesPropertyChangedEvent(input1, input2, out eventData, customMessage),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesPropertyChangedEvent");

            if(expected.eventData != null) {
                Test.If.Value.IsEqual(eventData, expected.eventData, new PropertyChangedEventDataEqualityComparer());
            }

        }

        IEnumerable<Object[]> RaisesPropertyChangedEventWithMessageData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { null, null, null, "message",
                    (1, false, "Parameter 'action' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { null, pccObject, null, "message",
                    (2, false, "Parameter 'action' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => { }), null, "() => {{ }}", "message",
                    (3, false, "Parameter 'object' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => { }), pccObject, "() => {{ }}", "message",
                    (4, false, "message", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => throw new Exception()), pccObject, "() => {{ throw new Exception(); }}", "message",
                    (5, false, "Action threw Exception:", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}", "message",
                    (6, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))) },
            };
        }

        [TestMethod]
        [TestData(nameof(NotRaisesPropertyChangedEventWithMessageData))]
        void NotRaisesPropertyChangedEventWithMessage(Action input1, INotifyPropertyChanged input2, String input3, String customMessage,
            (Int32 count, Boolean result, String message, EventData<PropertyChangedEventArgs> eventData) expected) {

            EventData<PropertyChangedEventArgs> eventData = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesPropertyChangedEvent(input1, input2, out eventData, customMessage),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesPropertyChangedEvent");

            if(expected.eventData != null) {
                Test.If.Value.IsEqual(eventData, expected.eventData, new PropertyChangedEventDataEqualityComparer());
            }

        }

        IEnumerable<Object[]> NotRaisesPropertyChangedEventWithMessageData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { null, null, null, "message",
                    (1, false, "Parameter 'action' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { null, pccObject, null, "message",
                    (2, false, "Parameter 'action' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => { }), null, "() => {{ }}", "message",
                    (3, false, "Parameter 'object' is null.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => { }), pccObject, "() => {{ }}", "message",
                    (4, true, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => throw new Exception()), pccObject, "() => {{ throw new Exception(); }}", "message",
                    (5, false, "Action threw Exception:", (EventData<PropertyChangedEventArgs>) null) },
                new Object[] { new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}", "message",
                    (6, false, "message", new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))) },
            };
        }

        #endregion

        #region RaisesMultiplePropertyChangedEvents

        [TestMethod]
        [TestData(nameof(RaisesPropertyChangedEvenstData))]
        void RaisesPropertyChangedEvents(Action input1, INotifyPropertyChanged input2, String input3,
            (Int32 count, Boolean result, String message, EventDataCollection<PropertyChangedEventArgs> eventDatas) expected) {

            EventDataCollection<PropertyChangedEventArgs> eventDatas = null;

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesPropertyChangedEvent(input1, input2, out eventDatas),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesPropertyChangedEvent");

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, new PropertyChangedEventDataEqualityComparer());
            }

        }

        IEnumerable<Object[]> RaisesPropertyChangedEvenstData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {

            new Object[] { null, null, null,
                (1, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { null, pccObject, null,
                (2, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => { }), null, "() => {{ }}",
                (3, false, "Parameter 'object' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },

            new Object[] { new Action(() => { }), pccObject, "() => {{ }}",
                (4, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => throw new Exception()), pccObject, "() => {{ throw new Exception(); }}",
                (5, false, "Action threw Exception:", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}",
                (6, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                }) },
            new Object[] { new Action(() => pccObject.Value1And2 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1And2 = !pccObject.Value1; }}",
                (7, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 2 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1")),
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value2"))
                }) },
            };
        }

        [TestMethod]
        [TestData(nameof(NotRaisesPropertyChangedEventsData))]
        void NotRaisesPropertyChangedEvents(Action input1, INotifyPropertyChanged input2, String input3,
            (Int32 count, Boolean result, String message, EventDataCollection<PropertyChangedEventArgs> eventDatas) expected) {

            EventDataCollection<PropertyChangedEventArgs> eventDatas = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesPropertyChangedEvent(input1, input2, out eventDatas),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesPropertyChangedEvent");

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, new PropertyChangedEventDataEqualityComparer());
            }

        }

        IEnumerable<Object[]> NotRaisesPropertyChangedEventsData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {

            new Object[] { null, null, null,
                (1, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { null, pccObject, null,
                (2, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => { }), null, "() => {{ }}",
                (3, false, "Parameter 'object' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },

            new Object[] { new Action(() => { }), pccObject, "() => {{ }}",
                (4, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => throw new Exception()), pccObject, "() => {{ throw new Exception(); }}",
                (5, false, "Action threw Exception:", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}",
                (6, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                }) },
            new Object[] { new Action(() => pccObject.Value1And2 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1And2 = !pccObject.Value1; }}",
                (7, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 2 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1")),
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value2"))
                }) },
            };
        }

        #endregion

        #region RaisesMultiplePropertyChangedEventsWithMessage

        [TestMethod]
        [TestData(nameof(RaisesPropertyChangedEvenstWithMessageData))]
        void RaisesPropertyChangedEventsWithMessage(Action input1, INotifyPropertyChanged input2, String input3, String customMessage,
            (Int32 count, Boolean result, String message, EventDataCollection<PropertyChangedEventArgs> eventDatas) expected) {

            EventDataCollection<PropertyChangedEventArgs> eventDatas = null;

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesPropertyChangedEvent(input1, input2, out eventDatas, customMessage),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesPropertyChangedEvent");

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, new PropertyChangedEventDataEqualityComparer());
            }

        }

        IEnumerable<Object[]> RaisesPropertyChangedEvenstWithMessageData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {

            new Object[] { null, null, null, "message",
                (1, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { null, pccObject, null, "message",
                (2, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => { }), null, "() => {{ }}", "message",
                (3, false, "Parameter 'object' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },

            new Object[] { new Action(() => { }), pccObject, "() => {{ }}", "message",
                (4, false, "message", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => throw new Exception()), pccObject, "() => {{ throw new Exception(); }}", "message",
                (5, false, "Action threw Exception:", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}", "message",
                (6, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                }) },
            };
        }

        [TestMethod]
        [TestData(nameof(NotRaisesPropertyChangedEventsWithMessageData))]
        void NotRaisesPropertyChangedEventsWithMessage(Action input1, INotifyPropertyChanged input2, String input3, String customMessage,
            (Int32 count, Boolean result, String message, EventDataCollection<PropertyChangedEventArgs> eventDatas) expected) {

            EventDataCollection<PropertyChangedEventArgs> eventDatas = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesPropertyChangedEvent(input1, input2, out eventDatas, customMessage),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesPropertyChangedEvent");

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, new PropertyChangedEventDataEqualityComparer());
            }

        }

        IEnumerable<Object[]> NotRaisesPropertyChangedEventsWithMessageData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {

            new Object[] { null, null, null, "message",
                (1, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { null, pccObject, null, "message",
                (2, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => { }), null, "() => {{ }}", "message",
                (3, false, "Parameter 'object' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },

            new Object[] { new Action(() => { }), pccObject, "() => {{ }}", "message",
                (4, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => throw new Exception()), pccObject, "() => {{ throw new Exception(); }}", "message",
                (5, false, "Action threw Exception:", (EventDataCollection<PropertyChangedEventArgs>) null) },
            new Object[] { new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}", "message",
                (6, false, "message", new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                }) },
            };
        }

        #endregion

        #region RaisesEvent

        [TestMethod]
        [TestData(nameof(RaisesEventData))]
        void RaisesEvent<TEventArgs>(Action input1, INotifyPropertyChanged input2, String input3, String input4,
            (Int32 count, Boolean result, String message, Boolean eventRaised) expected)
            where TEventArgs : EventArgs {

            EventData<TEventArgs> eventData = null;

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesEvent(input1, input2, input3, out eventData),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesEvent");

            if(expected.eventRaised) {
                Test.IfNot.Object.IsNull(eventData.Sender);
                Test.If.Reference.IsEqual(input2, eventData.Sender);
                Test.IfNot.Object.IsNull(eventData.EventArgs);
            }

        }

        IEnumerable<Object[]> RaisesEventData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { typeof(PropertyChangedEventArgs), null, null, null, null,
                    (1, false, "Parameter 'action' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), null, pccObject, "PropertyChanged", null,
                    (2, false, "Parameter 'action' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), null, "PropertyChanged", "() => {{ }}",
                    (3, false, "Parameter 'object' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, null, "() => {{ }}",
                    (4, false, "Parameter 'eventName' is null or empty.", false) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => throw new Exception()), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}",
                    (5, false, "Action threw Exception:", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged_", "() => {{ }}",
                    (6, false, "Event with name 'PropertyChanged_' could not be found.", false) },
                new Object[] { typeof(DoWorkEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}",
                    (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", false) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}",
                    (8, false, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}",
                    (9, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", true) },
            };
        }

        [TestMethod]
        [TestData(nameof(NotRaisesEventData))]
        void NotRaisesEvent<TEventArgs>(Action input1, INotifyPropertyChanged input2, String input3, String input4,
            (Int32 count, Boolean result, String message, Boolean eventRaised) expected)
            where TEventArgs : EventArgs {

            EventData<TEventArgs> eventData = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesEvent(input1, input2, input3, out eventData),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesEvent");

            if(expected.eventRaised) {
                Test.IfNot.Object.IsNull(eventData.Sender);
                Test.If.Reference.IsEqual(input2, eventData.Sender);
                Test.IfNot.Object.IsNull(eventData.EventArgs);
            }

        }

        IEnumerable<Object[]> NotRaisesEventData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { typeof(PropertyChangedEventArgs), null, null, null, null,
                    (1, false, "Parameter 'action' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), null, pccObject, "PropertyChanged", null,
                    (2, false, "Parameter 'action' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), null, "PropertyChanged", "() => {{ }}",
                    (3, false, "Parameter 'object' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, null, "() => {{ }}",
                    (4, false, "Parameter 'eventName' is null or empty.", false) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => throw new Exception()), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}",
                    (5, false, "Action threw Exception:", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged_", "() => {{ }}",
                    (6, false, "Event with name 'PropertyChanged_' could not be found.", false) },
                new Object[] { typeof(DoWorkEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}",
                    (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", false) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}",
                    (8, true, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}",
                    (9, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", true) },
            };
        }

        #endregion

        #region RaisesEventWithMessage

        [TestMethod]
        [TestData(nameof(RaisesEventWithMessageData))]
        void RaisesEventWithMessage<TEventArgs>(Action input1, INotifyPropertyChanged input2, String input3, String input4, String customMessage,
            (Int32 count, Boolean result, String message, Boolean eventRaised) expected)
            where TEventArgs : EventArgs {

            EventData<TEventArgs> eventData = null;

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesEvent(input1, input2, input3, out eventData, customMessage),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesEvent");

            if(expected.eventRaised) {
                Test.IfNot.Object.IsNull(eventData.Sender);
                Test.If.Reference.IsEqual(input2, eventData.Sender);
                Test.IfNot.Object.IsNull(eventData.EventArgs);
            }

        }

        IEnumerable<Object[]> RaisesEventWithMessageData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { typeof(PropertyChangedEventArgs), null, null, null, null, "message",
                    (1, false, "Parameter 'action' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), null, pccObject, "PropertyChanged", null, "message",
                    (2, false, "Parameter 'action' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), null, "PropertyChanged", "() => {{ }}", "message",
                    (3, false, "Parameter 'object' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, null, "() => {{ }}", "message",
                    (4, false, "Parameter 'eventName' is null or empty.", false) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => throw new Exception()), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}", "message",
                    (5, false, "Action threw Exception:", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged_", "() => {{ }}", "message",
                    (6, false, "Event with name 'PropertyChanged_' could not be found.", false) },
                new Object[] { typeof(DoWorkEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", "message",
                    (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", false) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", "message",
                    (8, false, "message", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}", "message",
                    (9, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", true) },
            };
        }

        [TestMethod]
        [TestData(nameof(NotRaisesEventWithMessageData))]
        void NotRaisesEventWithMessage<TEventArgs>(Action input1, INotifyPropertyChanged input2, String input3, String input4, String customMessage,
            (Int32 count, Boolean result, String message, Boolean eventRaised) expected)
            where TEventArgs : EventArgs {

            EventData<TEventArgs> eventData = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesEvent(input1, input2, input3, out eventData, customMessage),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesEvent");

            if(expected.eventRaised) {
                Test.IfNot.Object.IsNull(eventData.Sender);
                Test.If.Reference.IsEqual(input2, eventData.Sender);
                Test.IfNot.Object.IsNull(eventData.EventArgs);
            }

        }

        IEnumerable<Object[]> NotRaisesEventWithMessageData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { typeof(PropertyChangedEventArgs), null, null, null, null, "message",
                    (1, false, "Parameter 'action' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), null, pccObject, "PropertyChanged", null, "message",
                    (2, false, "Parameter 'action' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), null, "PropertyChanged", "() => {{ }}", "message",
                    (3, false, "Parameter 'object' is null.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, null, "() => {{ }}", "message",
                    (4, false, "Parameter 'eventName' is null or empty.", false) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => throw new Exception()), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}", "message",
                    (5, false, "Action threw Exception:", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged_", "() => {{ }}", "message",
                    (6, false, "Event with name 'PropertyChanged_' could not be found.", false) },
                new Object[] { typeof(DoWorkEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", "message",
                    (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", false) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", "message",
                    (8, true, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", false) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}", "message",
                    (9, false, "message", true) },
            };
        }

        #endregion

        #region RaisesMultipleEvents

        [TestMethod]
        [TestData(nameof(RaisesEventsData))]
        void RaisesEvents<TEventArgs>(Action input1, Object input2, String input3, String input4, IEqualityComparer<EventData<TEventArgs>> input5,
            (Int32 count, Boolean result, String message, EventDataCollection<TEventArgs> eventDatas) expected)
            where TEventArgs : EventArgs {

            EventDataCollection<TEventArgs> eventDatas = null;

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesEvent(input1, input2, input3, out eventDatas),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesEvent");

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, input5);
            }

        }

        IEnumerable<Object[]> RaisesEventsData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { typeof(PropertyChangedEventArgs), null, null, null, null, null,
                    (1, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), null, pccObject, "PropertyChanged", null, null,
                    (2, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), null, "PropertyChanged", "() => {{ }}", null,
                    (3, false, "Parameter 'object' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, null, "() => {{ }}", null,
                    (4, false, "Parameter 'eventName' is null or empty.", (EventDataCollection<PropertyChangedEventArgs>) null) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => throw new Exception()), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}", null,
                    (5, false, "Action threw Exception:", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged_", "() => {{ }}", null,
                    (6, false, "Event with name 'PropertyChanged_' could not be found.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(DoWorkEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", null,
                    (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", (EventDataCollection<DoWorkEventArgs>) null) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", null,
                    (8, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer(),
                    (9, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                        new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                    }) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1And2 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1And2 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer(),
                    (10, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 2 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                        new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1")),
                        new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value2"))
                    }) },
            };
        }

        [TestMethod]
        [TestData(nameof(NotRaisesEventsData))]
        void NotRaisesEvents<TEventArgs>(Action input1, Object input2, String input3, String input4, IEqualityComparer<EventData<TEventArgs>> input5,
            (Int32 count, Boolean result, String message, EventDataCollection<TEventArgs> eventDatas) expected)
            where TEventArgs : EventArgs {

            EventDataCollection<TEventArgs> eventDatas = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesEvent(input1, input2, input3, out eventDatas),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesEvent");

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, input5);
            }

        }

        IEnumerable<Object[]> NotRaisesEventsData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { typeof(PropertyChangedEventArgs), null, null, null, null, null,
                    (1, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), null, pccObject, "PropertyChanged", null, null,
                    (2, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), null, "PropertyChanged", "() => {{ }}", null,
                    (3, false, "Parameter 'object' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, null, "() => {{ }}", null,
                    (4, false, "Parameter 'eventName' is null or empty.", (EventDataCollection<PropertyChangedEventArgs>) null) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => throw new Exception()), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}", null,
                    (5, false, "Action threw Exception:", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged_", "() => {{ }}", null,
                    (6, false, "Event with name 'PropertyChanged_' could not be found.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(DoWorkEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", null,
                    (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", (EventDataCollection<DoWorkEventArgs>) null) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", null,
                    (8, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer(),
                    (9, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                        new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                    }) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1And2 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1And2 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer(),
                    (10, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 2 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                        new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1")),
                        new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value2"))
                    }) },
            };
        }

        #endregion

        #region RaisesMultipleEventsWithMessage

        [TestMethod]
        [TestData(nameof(RaisesEventsWithMessageData))]
        void RaisesEventsWithMessage<TEventArgs>(Action input1, Object input2, String input3, String input4, IEqualityComparer<EventData<TEventArgs>> input5, String customMessage,
            (Int32 count, Boolean result, String message, EventDataCollection<TEventArgs> eventDatas) expected)
            where TEventArgs : EventArgs {

            EventDataCollection<TEventArgs> eventDatas = null;

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesEvent(input1, input2, input3, out eventDatas, customMessage),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesEvent");

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, input5);
            }

        }

        IEnumerable<Object[]> RaisesEventsWithMessageData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { typeof(PropertyChangedEventArgs), null, null, null, null, null, "message",
                    (1, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), null, pccObject, "PropertyChanged", null, null, "message",
                    (2, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), null, "PropertyChanged", "() => {{ }}", null, "message",
                    (3, false, "Parameter 'object' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, null, "() => {{ }}", null, "message",
                    (4, false, "Parameter 'eventName' is null or empty.", (EventDataCollection<PropertyChangedEventArgs>) null) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => throw new Exception()), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}", null, "message",
                    (5, false, "Action threw Exception:", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged_", "() => {{ }}", null, "message",
                    (6, false, "Event with name 'PropertyChanged_' could not be found.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(DoWorkEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", null, "message",
                    (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", (EventDataCollection<DoWorkEventArgs>) null) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", null, "message",
                    (8, false, "message", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer(), "message",
                    (9, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.", new EventDataCollection<PropertyChangedEventArgs>() {
                        new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                    }) },
            };
        }

        [TestMethod]
        [TestData(nameof(NotRaisesEventsWithMessageData))]
        void NotRaisesEventsWithMessage<TEventArgs>(Action input1, Object input2, String input3, String input4, IEqualityComparer<EventData<TEventArgs>> input5, String customMessage,
            (Int32 count, Boolean result, String message, EventDataCollection<TEventArgs> eventDatas) expected)
            where TEventArgs : EventArgs {

            EventDataCollection<TEventArgs> eventDatas = null;

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesEvent(input1, input2, input3, out eventDatas, customMessage),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesEvent");

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, input5);
            }

        }

        IEnumerable<Object[]> NotRaisesEventsWithMessageData() {
            PropertyChangedClass pccObject = new PropertyChangedClass();

            return new List<Object[]>() {
                new Object[] { typeof(PropertyChangedEventArgs), null, null, null, null, null, "message",
                    (1, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), null, pccObject, "PropertyChanged", null, null, "message",
                    (2, false, "Parameter 'action' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), null, "PropertyChanged", "() => {{ }}", null, "message",
                    (3, false, "Parameter 'object' is null.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, null, "() => {{ }}", null, "message",
                    (4, false, "Parameter 'eventName' is null or empty.", (EventDataCollection<PropertyChangedEventArgs>) null) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => throw new Exception()), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}", null, "message",
                    (5, false, "Action threw Exception:", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged_", "() => {{ }}", null, "message",
                    (6, false, "Event with name 'PropertyChanged_' could not be found.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(DoWorkEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", null, "message",
                    (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", (EventDataCollection<DoWorkEventArgs>) null) },

                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => { }), pccObject, "PropertyChanged", "() => {{ }}", null, "message",
                    (8, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", (EventDataCollection<PropertyChangedEventArgs>) null) },
                new Object[] { typeof(PropertyChangedEventArgs), new Action(() => pccObject.Value1 = !pccObject.Value1), pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer(), "message",
                    (9, false, "message", new EventDataCollection<PropertyChangedEventArgs>() {
                        new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                    }) },
            };
        }

        #endregion

    }
}
