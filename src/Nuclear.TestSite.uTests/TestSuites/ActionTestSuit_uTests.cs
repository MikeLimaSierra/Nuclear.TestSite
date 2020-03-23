using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Ntt;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    class ActionTestSuit_uTests {

        #region ThrowsException

        [TestMethod]
        void ThrowsException() {

            DDTThrowsException<SystemException>((null, null),
                (1, false, "Parameter 'action' is null.", false, ""));
            DDTThrowsException<Exception>((() => { }, "() => {{ }}"),
                (2, false, "[Exception = null]", false, ""));
            DDTThrowsException<SystemException>((() => throw new ArgumentException("test message"), "() => {{ throw new ArgumentException(\"test message\"); }}"),
                (3, true, "[Exception = 'System.ArgumentException", true, "test message"));
            DDTThrowsException<NullReferenceException>((() => throw new ArgumentException("test message"), "() => {{ throw new ArgumentException(\"test message\"); }}"),
                (4, false, "[Exception = null]", false, ""));
            DDTThrowsException<Exception>((() => throw new Exception("test message"), "() => {{ throw new Exception(\"test message\"); }}"),
                (5, true, "[Exception = 'System.Exception", true, "test message"));
            DDTThrowsException<SystemException>(( () => throw new Exception("test message"), "() => {{ throw new Exception(\"test message\"); }}"),
                (6, false, "[Exception = null]", false, ""));

        }

        void DDTThrowsException<TException>((Action action, String actionString) input,
            (Int32 count, Boolean result, String message, Boolean exceptionThrown, String exMessage) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TException : Exception {

            TException ex = null;

            Test.Note($"Test.If.Action.ThrowsException({input.actionString.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Action.ThrowsException(input.action, out ex, _file, _method),
                (expected.count, expected.result, expected.message), "Test.If.Action.ThrowsException", _file, _method);

            if(expected.exceptionThrown) {
                Test.IfNot.Object.IsNull(ex, _file, _method);
                Test.If.String.StartsWith(ex.Message, expected.exMessage, _file, _method);
            }

        }

        [TestMethod]
        void NotThrowsException() {

            DDTNotThrowsException<SystemException>((null, null),
                (1, false, "Parameter 'action' is null.", false, ""));
            DDTNotThrowsException<Exception>((() => { }, "() => {{ }}"),
                (2, true, "[Exception = null]", false, ""));
            DDTNotThrowsException<SystemException>((() => throw new ArgumentException("test message"), "() => {{ throw new ArgumentException(\"test message\"); }}"),
                (3, false, "[Exception = 'System.ArgumentException", true, "test message"));
            DDTNotThrowsException<NullReferenceException>((() => throw new ArgumentException("test message"), "() => {{ throw new ArgumentException(\"test message\"); }}"),
                (4, true, "[Exception = null]", false, ""));
            DDTNotThrowsException<Exception>((() => throw new Exception("test message"), "() => {{ throw new Exception(\"test message\"); }}"),
                (5, false, "[Exception = 'System.Exception", true, "test message"));
            DDTNotThrowsException<SystemException>((() => throw new Exception("test message"), "() => {{ throw new Exception(\"test message\"); }}"),
                (6, true, "[Exception = null]", false, ""));

        }

        void DDTNotThrowsException<TException>((Action action, String actionString) input,
            (Int32 count, Boolean result, String message, Boolean exceptionThrown, String exMessage) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TException : Exception {

            TException ex = null;

            Test.Note($"Test.IfNot.Action.ThrowsException({input.actionString.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Action.ThrowsException(input.action, out ex, _file, _method),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.ThrowsException", _file, _method);

            if(expected.exceptionThrown) {
                Test.IfNot.Object.IsNull(ex, _file, _method);
                Test.If.String.StartsWith(ex.Message, expected.exMessage, _file, _method);
            }

        }

        #endregion

        #region RaisesPropertyChangedEvent

        [TestMethod]
        void RaisesPropertyChangedEvent() {

            PropertyChangedClass pccObject = new PropertyChangedClass();

            DDTRaisesPropertyChangedEvent((null, null, null),
                (1, false, "Parameter 'action' is null.", null));
            DDTRaisesPropertyChangedEvent((null, pccObject, null),
                (2, false, "Parameter 'action' is null.", null));
            DDTRaisesPropertyChangedEvent((() => { }, null, "() => {{ }}"),
                (3, false, "Parameter 'object' is null.", null));

            DDTRaisesPropertyChangedEvent((() => { }, pccObject, "() => {{ }}"),
                (4, false, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", null));
            DDTRaisesPropertyChangedEvent((() => throw new Exception(), pccObject, "() => {{ throw new Exception(); }}"),
                (5, false, "Action threw Exception:", null));
            DDTRaisesPropertyChangedEvent((() => pccObject.Value1 = !pccObject.Value1, pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}"),
                (6, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))));

        }

        void DDTRaisesPropertyChangedEvent((Action action, INotifyPropertyChanged @object, String actionString) input,
            (Int32 count, Boolean result, String message, EventData<PropertyChangedEventArgs> eventData) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            EventData<PropertyChangedEventArgs> eventData = null;

            Test.Note($"Test.If.Action.RaisesPropertyChangedEvent({input.actionString.Format()}, {input.@object.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesPropertyChangedEvent(input.action, input.@object, out eventData, _file, _method),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesPropertyChangedEvent", _file, _method);

            if(expected.eventData != null) {
                Test.If.Value.IsEqual(eventData, expected.eventData, new PropertyChangedEventDataEqualityComparer(), _file, _method);
            }

        }

        [TestMethod]
        void NotRaisesPropertyChangedEvent() {

            PropertyChangedClass pccObject = new PropertyChangedClass();

            DDTNotRaisesPropertyChangedEvent((null, null, null),
                (1, false, "Parameter 'action' is null.", null));
            DDTNotRaisesPropertyChangedEvent((null, pccObject, null),
                (2, false, "Parameter 'action' is null.", null));
            DDTNotRaisesPropertyChangedEvent((() => { }, null, "() => {{ }}"),
                (3, false, "Parameter 'object' is null.", null));

            DDTNotRaisesPropertyChangedEvent((() => { }, pccObject, "() => {{ }}"),
                (4, true, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", null));
            DDTNotRaisesPropertyChangedEvent((() => throw new Exception(), pccObject, "() => {{ throw new Exception(); }}"),
                (5, false, "Action threw Exception:", null));
            DDTNotRaisesPropertyChangedEvent((() => pccObject.Value1 = !pccObject.Value1, pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}"),
                (6, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))));

        }

        void DDTNotRaisesPropertyChangedEvent((Action action, INotifyPropertyChanged @object, String actionString) input,
            (Int32 count, Boolean result, String message, EventData<PropertyChangedEventArgs> eventData) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            EventData<PropertyChangedEventArgs> eventData = null;

            Test.Note($"Test.IfNot.Action.RaisesPropertyChangedEvent({input.actionString.Format()}, {input.@object.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesPropertyChangedEvent(input.action, input.@object, out eventData, _file, _method),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesPropertyChangedEvent", _file, _method);

            if(expected.eventData != null) {
                Test.If.Value.IsEqual(eventData, expected.eventData, new PropertyChangedEventDataEqualityComparer(), _file, _method);
            }

        }

        #endregion

        #region RaisesMultiplePropertyChangedEvents

        [TestMethod]
        void RaisesPropertyChangedEvents() {

            PropertyChangedClass pccObject = new PropertyChangedClass();

            DDTRaisesPropertyChangedEvents((null, null, null),
                (1, false, "Parameter 'action' is null.", null));
            DDTRaisesPropertyChangedEvents((null, pccObject, null),
                (2, false, "Parameter 'action' is null.", null));
            DDTRaisesPropertyChangedEvents((() => { }, null, "() => {{ }}"),
                (3, false, "Parameter 'object' is null.", null));

            DDTRaisesPropertyChangedEvents((() => { }, pccObject, "() => {{ }}"),
                (4, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", null));
            DDTRaisesPropertyChangedEvents((() => throw new Exception(), pccObject, "() => {{ throw new Exception(); }}"),
                (5, false, "Action threw Exception:", null));
            DDTRaisesPropertyChangedEvents((() => pccObject.Value1 = !pccObject.Value1, pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}"),
                (6, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.",
                new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                }));
            DDTRaisesPropertyChangedEvents((() => pccObject.Value1And2 = !pccObject.Value1, pccObject, "() => {{ pccObject.Value1And2 = !pccObject.Value1; }}"),
                (7, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 2 times.",
                new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1")),
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value2"))
                }));

        }

        void DDTRaisesPropertyChangedEvents((Action action, INotifyPropertyChanged @object, String actionString) input,
            (Int32 count, Boolean result, String message, EventDataCollection<PropertyChangedEventArgs> eventDatas) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            EventDataCollection<PropertyChangedEventArgs> eventDatas = null;

            Test.Note($"Test.If.Action.RaisesPropertyChangedEvent({input.actionString.Format()}, {input.@object.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesPropertyChangedEvent(input.action, input.@object, out eventDatas, _file, _method),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesPropertyChangedEvent", _file, _method);

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, new PropertyChangedEventDataEqualityComparer(), _file, _method);
            }

        }

        [TestMethod]
        void NotRaisesPropertyChangedEvents() {

            PropertyChangedClass pccObject = new PropertyChangedClass();

            DDTNotRaisesPropertyChangedEvents((null, null, null),
                (1, false, "Parameter 'action' is null.", null));
            DDTNotRaisesPropertyChangedEvents((null, pccObject, null),
                (2, false, "Parameter 'action' is null.", null));
            DDTNotRaisesPropertyChangedEvents((() => { }, null, "() => {{ }}"),
                (3, false, "Parameter 'object' is null.", null));

            DDTNotRaisesPropertyChangedEvents((() => { }, pccObject, "() => {{ }}"),
                (4, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", null));
            DDTNotRaisesPropertyChangedEvents((() => throw new Exception(), pccObject, "() => {{ throw new Exception(); }}"),
                (5, false, "Action threw Exception:", null));
            DDTNotRaisesPropertyChangedEvents((() => pccObject.Value1 = !pccObject.Value1, pccObject, "() => {{ pccObject.Value1 = !pccObject.Value1; }}"),
                (6, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.",
                new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                }));
            DDTNotRaisesPropertyChangedEvents((() => pccObject.Value1And2 = !pccObject.Value1, pccObject, "() => {{ pccObject.Value1And2 = !pccObject.Value1; }}"),
                (7, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 2 times.",
                new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1")),
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value2"))
                }));

        }

        void DDTNotRaisesPropertyChangedEvents((Action action, INotifyPropertyChanged @object, String actionString) input,
            (Int32 count, Boolean result, String message, EventDataCollection<PropertyChangedEventArgs> eventDatas) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            EventDataCollection<PropertyChangedEventArgs> eventDatas = null;

            Test.Note($"Test.IfNot.Action.RaisesPropertyChangedEvent({input.actionString.Format()}, {input.@object.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesPropertyChangedEvent(input.action, input.@object, out eventDatas, _file, _method),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesPropertyChangedEvent", _file, _method);

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, new PropertyChangedEventDataEqualityComparer(), _file, _method);
            }

        }

        #endregion

        #region RaisesEvent

        [TestMethod]
        void RaisesEvent() {

            PropertyChangedClass pccObject = new PropertyChangedClass();

            DDTRaisesEvent<PropertyChangedEventArgs>((null, null, null, null),
                (1, false, "Parameter 'action' is null.", false));
            DDTRaisesEvent<PropertyChangedEventArgs>((null, pccObject, "PropertyChanged", null),
                (2, false, "Parameter 'action' is null.", false));
            DDTRaisesEvent<PropertyChangedEventArgs>((() => { }, null, "PropertyChanged", "() => {{ }}"),
                (3, false, "Parameter 'object' is null.", false));
            DDTRaisesEvent<PropertyChangedEventArgs>((() => { }, pccObject, null, "() => {{ }}"),
                (4, false, "Parameter 'eventName' is null or empty.", false));

            DDTRaisesEvent<PropertyChangedEventArgs>((() => throw new Exception(), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}"),
                (5, false, "Action threw Exception:", false));
            DDTRaisesEvent<PropertyChangedEventArgs>((() => { }, pccObject, "PropertyChanged_", "() => {{ }}"),
                (6, false, "Event with name 'PropertyChanged_' could not be found.", false));
            DDTRaisesEvent<DoWorkEventArgs>((() => { }, pccObject, "PropertyChanged", "() => {{ }}"),
                (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", false));

            DDTRaisesEvent<PropertyChangedEventArgs>((() => { }, pccObject, "PropertyChanged", "() => {{ }}"),
                (8, false, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", false));
            DDTRaisesEvent<PropertyChangedEventArgs>((() => pccObject.Value1 = !pccObject.Value1, pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}"),
                (9, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", true));

        }

        void DDTRaisesEvent<TEventArgs>((Action action, INotifyPropertyChanged @object, String eventName, String actionString) input,
            (Int32 count, Boolean result, String message, Boolean eventRaised) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TEventArgs : EventArgs {

            EventData<TEventArgs> eventData = null;

            Test.Note($"Test.If.Action.RaisesEvent({input.actionString.Format()}, {input.@object.Format()}, {input.eventName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesEvent(input.action, input.@object, input.eventName, out eventData, _file, _method),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesEvent", _file, _method);

            if(expected.eventRaised) {
                Test.IfNot.Object.IsNull(eventData.Sender, _file, _method);
                Test.If.Reference.IsEqual(input.@object, eventData.Sender, _file, _method);
                Test.IfNot.Object.IsNull(eventData.EventArgs, _file, _method);
            }

        }

        [TestMethod]
        void NotRaisesEvent() {

            PropertyChangedClass pccObject = new PropertyChangedClass();

            DDTNotRaisesEvent<PropertyChangedEventArgs>((null, null, null, null),
                (1, false, "Parameter 'action' is null.", false));
            DDTNotRaisesEvent<PropertyChangedEventArgs>((null, pccObject, "PropertyChanged", null),
                (2, false, "Parameter 'action' is null.", false));
            DDTNotRaisesEvent<PropertyChangedEventArgs>((() => { }, null, "PropertyChanged", "() => {{ }}"),
                (3, false, "Parameter 'object' is null.", false));
            DDTNotRaisesEvent<PropertyChangedEventArgs>((() => { }, pccObject, null, "() => {{ }}"),
                (4, false, "Parameter 'eventName' is null or empty.", false));

            DDTNotRaisesEvent<PropertyChangedEventArgs>((() => throw new Exception(), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}"),
                (5, false, "Action threw Exception:", false));
            DDTNotRaisesEvent<PropertyChangedEventArgs>((() => { }, pccObject, "PropertyChanged_", "() => {{ }}"),
                (6, false, "Event with name 'PropertyChanged_' could not be found.", false));
            DDTNotRaisesEvent<DoWorkEventArgs>((() => { }, pccObject, "PropertyChanged", "() => {{ }}"),
                (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", false));

            DDTNotRaisesEvent<PropertyChangedEventArgs>((() => { }, pccObject, "PropertyChanged", "() => {{ }}"),
                (8, true, "No event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", false));
            DDTNotRaisesEvent<PropertyChangedEventArgs>((() => pccObject.Value1 = !pccObject.Value1, pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}"),
                (9, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised.", true));

        }

        void DDTNotRaisesEvent<TEventArgs>((Action action, INotifyPropertyChanged @object, String eventName, String actionString) input,
            (Int32 count, Boolean result, String message, Boolean eventRaised) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TEventArgs : EventArgs {

            EventData<TEventArgs> eventData = null;

            Test.Note($"Test.IfNot.Action.RaisesEvent({input.actionString.Format()}, {input.@object.Format()}, {input.eventName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesEvent(input.action, input.@object, input.eventName, out eventData, _file, _method),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesEvent", _file, _method);

            if(expected.eventRaised) {
                Test.IfNot.Object.IsNull(eventData.Sender, _file, _method);
                Test.If.Reference.IsEqual(input.@object, eventData.Sender, _file, _method);
                Test.IfNot.Object.IsNull(eventData.EventArgs, _file, _method);
            }

        }

        #endregion

        #region RaisesMultipleEvents

        [TestMethod]
        void RaisesEvents() {

            PropertyChangedClass pccObject = new PropertyChangedClass();

            DDTRaisesEvents<PropertyChangedEventArgs>((null, null, null, null),
                (1, false, "Parameter 'action' is null.", null));
            DDTRaisesEvents<PropertyChangedEventArgs>((null, pccObject, "PropertyChanged", null),
                (2, false, "Parameter 'action' is null.", null));
            DDTRaisesEvents<PropertyChangedEventArgs>((() => { }, null, "PropertyChanged", "() => {{ }}"),
                (3, false, "Parameter 'object' is null.", null));
            DDTRaisesEvents<PropertyChangedEventArgs>((() => { }, pccObject, null, "() => {{ }}"),
                (4, false, "Parameter 'eventName' is null or empty.", null));

            DDTRaisesEvents<PropertyChangedEventArgs>((() => throw new Exception(), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}"),
                (5, false, "Action threw Exception:", null));
            DDTRaisesEvents<PropertyChangedEventArgs>((() => { }, pccObject, "PropertyChanged_", "() => {{ }}"),
                (6, false, "Event with name 'PropertyChanged_' could not be found.", null));
            DDTRaisesEvents<DoWorkEventArgs>((() => { }, pccObject, "PropertyChanged", "() => {{ }}"),
                (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.",
                null));

            DDTRaisesEvents<PropertyChangedEventArgs>((() => { }, pccObject, "PropertyChanged", "() => {{ }}"),
                (8, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", null));
            DDTRaisesEvents((() => pccObject.Value1 = !pccObject.Value1, pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer()),
                (9, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.",
                new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                }));
            DDTRaisesEvents((() => pccObject.Value1And2 = !pccObject.Value1, pccObject, "PropertyChanged", "() => {{ pccObject.Value1And2 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer()),
                (10, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 2 times.",
                new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1")),
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value2"))
                }));

        }

        void DDTRaisesEvents<TEventArgs>((Action action, INotifyPropertyChanged @object, String eventName, String actionString) input,
            (Int32 count, Boolean result, String message, EventDataCollection<TEventArgs> eventDatas) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TEventArgs : EventArgs => DDTRaisesEvents((input.action, input.@object, input.eventName, input.actionString, null), expected, _file, _method);

        void DDTRaisesEvents<TEventArgs>((Action action, INotifyPropertyChanged @object, String eventName, String actionString, IEqualityComparer<EventData<TEventArgs>> comparer) input,
            (Int32 count, Boolean result, String message, EventDataCollection<TEventArgs> eventDatas) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TEventArgs : EventArgs {

            EventDataCollection<TEventArgs> eventDatas = null;

            Test.Note($"Test.If.Action.RaisesEvent({input.actionString.Format()}, {input.@object.Format()}, {input.eventName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Action.RaisesEvent(input.action, input.@object, input.eventName, out eventDatas, _file, _method),
                (expected.count, expected.result, expected.message), "Test.If.Action.RaisesEvent", _file, _method);

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, input.comparer, _file, _method);
            }

        }

        [TestMethod]
        void NotRaisesEvents() {

            PropertyChangedClass pccObject = new PropertyChangedClass();

            DDTNotRaisesEvents<PropertyChangedEventArgs>((null, null, null, null),
                (1, false, "Parameter 'action' is null.", null));
            DDTNotRaisesEvents<PropertyChangedEventArgs>((null, pccObject, "PropertyChanged", null),
                (2, false, "Parameter 'action' is null.", null));
            DDTNotRaisesEvents<PropertyChangedEventArgs>((() => { }, null, "PropertyChanged", "() => {{ }}"),
                (3, false, "Parameter 'object' is null.", null));
            DDTNotRaisesEvents<PropertyChangedEventArgs>((() => { }, pccObject, null, "() => {{ }}"),
                (4, false, "Parameter 'eventName' is null or empty.", null));

            DDTNotRaisesEvents<PropertyChangedEventArgs>((() => throw new Exception(), pccObject, "PropertyChanged", "() => {{ throw new Exception(); }}"),
                (5, false, "Action threw Exception:", null));
            DDTNotRaisesEvents<PropertyChangedEventArgs>((() => { }, pccObject, "PropertyChanged_", "() => {{ }}"),
                (6, false, "Event with name 'PropertyChanged_' could not be found.", null));
            DDTNotRaisesEvents<DoWorkEventArgs>((() => { }, pccObject, "PropertyChanged", "() => {{ }}"),
                (7, false, "Given type of arguments 'System.ComponentModel.DoWorkEventArgs' doesn't match event handler of type 'System.ComponentModel.PropertyChangedEventHandler'.", null));

            DDTNotRaisesEvents<PropertyChangedEventArgs>((() => { }, pccObject, "PropertyChanged", "() => {{ }}"),
                (8, true, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 0 times.", null));
            DDTNotRaisesEvents((() => pccObject.Value1 = !pccObject.Value1, pccObject, "PropertyChanged", "() => {{ pccObject.Value1 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer()),
                (9, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 1 times.",
                new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1"))
                }));
            DDTNotRaisesEvents((() => pccObject.Value1And2 = !pccObject.Value1, pccObject, "PropertyChanged", "() => {{ pccObject.Value1And2 = !pccObject.Value1; }}", new PropertyChangedEventDataEqualityComparer()),
                (10, false, "Event of type 'System.ComponentModel.PropertyChangedEventHandler' raised 2 times.",
                new EventDataCollection<PropertyChangedEventArgs>() {
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value1")),
                    new EventData<PropertyChangedEventArgs>(pccObject, new PropertyChangedEventArgs("Value2"))
                }));

        }

        void DDTNotRaisesEvents<TEventArgs>((Action action, INotifyPropertyChanged @object, String eventName, String actionString) input,
            (Int32 count, Boolean result, String message, EventDataCollection<TEventArgs> eventDatas) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TEventArgs : EventArgs => DDTNotRaisesEvents((input.action, input.@object, input.eventName, input.actionString, null), expected, _file, _method);

        void DDTNotRaisesEvents<TEventArgs>((Action action, INotifyPropertyChanged @object, String eventName, String actionString, IEqualityComparer<EventData<TEventArgs>> comparer) input,
        (Int32 count, Boolean result, String message, EventDataCollection<TEventArgs> eventDatas) expected,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
        where TEventArgs : EventArgs {

            EventDataCollection<TEventArgs> eventDatas = null;

            Test.Note($"Test.IfNot.Action.RaisesEvent({input.actionString.Format()}, {input.@object.Format()}, {input.eventName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Action.RaisesEvent(input.action, input.@object, input.eventName, out eventDatas, _file, _method),
                (expected.count, expected.result, expected.message), "Test.IfNot.Action.RaisesEvent", _file, _method);

            if(expected.eventDatas != null) {
                Test.If.Enumerable.MatchesExactly(eventDatas, expected.eventDatas, input.comparer, _file, _method);
            }

        }

        #endregion

    }
}
