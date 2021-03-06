﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;
using Nuclear.TestSite.TestSuites.Proxies;

namespace Nuclear.TestSite.TestSuites {
    public partial class ActionTestSuite {

        #region ThrowsException

        /// <summary>
        /// Tests if <paramref name="action"/> throws an <see cref="Exception"/> of type <typeparamref name="TException"/> when executed.
        /// </summary>
        /// <typeparam name="TException">The expected type of exception.</typeparam>
        /// <param name="action">The action to be executed.</param>
        /// <param name="exception">Contains the exception if thrown.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Action.ThrowsException&lt;ArgumentException&gt;(() => obj.DoSomething(), out ArgumentException exception);
        /// </code>
        /// </example>
        public void ThrowsException<TException>(Action action, out TException exception,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TException : Exception {

            exception = null;

            if(action == null) {
                InternalFail($"Parameter '{nameof(action)}' is null.", _file, _method);
                return;
            }

            try {
                action();

            } catch(TException ex) {
                exception = ex;

            } catch(Exception) {
                // don't care about all the other ones, this is just about TException!

            } finally {
                InternalTest(exception != null, $"[Exception = {exception.Format()}]",
                    customMessage, _file, _method);
            }
        }

        #endregion

        #region RaisesPropertyChangedEvent

        /// <summary>
        /// Tests if <paramref name="action"/> raises one event of <see cref="INotifyPropertyChanged"/> on <paramref name="object"/>.
        /// </summary>
        /// <param name="action">The action to be invoked.</param>
        /// <param name="object">The object that raises the event.</param>
        /// <param name="eventData">The event data containing sender and arguments.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Action.RaisesPropertyChangedEvent(() => obj.Title = "new content", obj, out Object sender, out PropertyChangedEventArgs e);
        /// </code>
        /// </example>
        public void RaisesPropertyChangedEvent(Action action, INotifyPropertyChanged @object, out EventData<PropertyChangedEventArgs> eventData,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            eventData = null;

            if(action == null) {
                InternalFail($"Parameter '{nameof(action)}' is null.", _file, _method);
                return;
            }

            if(@object == null) {
                InternalFail($"Parameter '{nameof(@object)}' is null.", _file, _method);
                return;
            }

            EventData<PropertyChangedEventArgs> tmp = null;

            void handler(Object sender, PropertyChangedEventArgs e) => tmp = new EventData<PropertyChangedEventArgs>(sender, e);

            @object.PropertyChanged += handler;

            try {
                action();
                eventData = tmp;

                InternalTest(tmp != null, String.Format("{0} of type {1} raised.", tmp != null ? "Event" : "No event", typeof(PropertyChangedEventHandler).Format()),
                    customMessage, _file, _method);

            } catch(Exception ex) {
                InternalFail($"Action threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;

            } finally {
                @object.PropertyChanged -= handler;
            }
        }

        /// <summary>
        /// Tests if <paramref name="action"/> raises one or many events of <see cref="INotifyPropertyChanged"/> on <paramref name="object"/>.
        /// </summary>
        /// <param name="action">The action to be invoked.</param>
        /// <param name="object">The object that raises the event.</param>
        /// <param name="eventDatas">The collection of event datas containing senders and arguments.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Action.RaisesPropertyChangedEvent(() => obj.Title = "new content", obj, out Object sender, out PropertyChangedEventArgs e);
        /// </code>
        /// </example>
        public void RaisesPropertyChangedEvent(Action action, INotifyPropertyChanged @object, out EventDataCollection<PropertyChangedEventArgs> eventDatas,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            eventDatas = null;

            if(action == null) {
                InternalFail($"Parameter '{nameof(action)}' is null.", _file, _method);
                return;
            }

            if(@object == null) {
                InternalFail($"Parameter '{nameof(@object)}' is null.", _file, _method);
                return;
            }

            EventDataCollection<PropertyChangedEventArgs> tmp = new EventDataCollection<PropertyChangedEventArgs>();

            void handler(Object sender, PropertyChangedEventArgs e) => tmp.Add(new EventData<PropertyChangedEventArgs>(sender, e));

            @object.PropertyChanged += handler;

            try {
                action();
                eventDatas = tmp;

                InternalTest(tmp.Count > 0, $"Event of type {typeof(PropertyChangedEventHandler).Format()} raised {tmp.Count} times.",
                    customMessage, _file, _method);


            } catch(Exception ex) {
                InternalFail($"Action threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;

            } finally {
                @object.PropertyChanged -= handler;
            }
        }

        #endregion

        #region RaisesEvent

        /// <summary>
        /// Tests if <paramref name="action"/> raises one event with <typeparamref name="TEventArgs"/> on <paramref name="object"/>.
        /// </summary>
        /// <typeparam name="TEventArgs">The expected type of event arguments.</typeparam>
        /// <param name="action">The action to be invoked.</param>
        /// <param name="object">The object that raises the event.</param>
        /// <param name="eventName">The name of the event to be raised.</param>
        /// <param name="eventData">The event data containing sender and arguments.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Action.RaisesEvent(() => obj.DoSomething(), obj, "MyCustomEvent", out EventData&lt;MyCustomEventArgs&gt; eventData);
        /// </code>
        /// </example>
        public void RaisesEvent<TEventArgs>(Action action, Object @object, String eventName, out EventData<TEventArgs> eventData,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TEventArgs : EventArgs {

            eventData = null;

            if(action == null) {
                InternalFail($"Parameter '{nameof(action)}' is null.", _file, _method);
                return;
            }

            if(@object == null) {
                InternalFail($"Parameter '{nameof(@object)}' is null.", _file, _method);
                return;
            }

            if(String.IsNullOrWhiteSpace(eventName)) {
                InternalFail($"Parameter '{nameof(eventName)}' is null or empty.", _file, _method);
                return;
            }

            Delegate d = null;

            EventProxy<TEventArgs> eventProxy = new EventProxy<TEventArgs>();
            MethodInfo handlerInfo = eventProxy.GetType().GetRuntimeMethods().First(method => method.Name == "OnEventRaised");

            EventInfo eventInfo = @object.GetType().GetRuntimeEvent(eventName);

            if(eventInfo == null) {
                InternalFail($"Event with name {eventName.Format()} could not be found.",
                    _file, _method);
                return;
            }

            try {
                d = Delegate.CreateDelegate(eventInfo.EventHandlerType, eventProxy, handlerInfo);

            } catch {
                InternalFail($"Given type of arguments {typeof(TEventArgs).Format()} doesn't match event handler of type {eventInfo.EventHandlerType.Format()}.",
                    _file, _method);
                return;
            }

            eventInfo.GetAddMethod().Invoke(@object, new Object[] { d });

            try {
                action();
                eventData = eventProxy.EventData;

                InternalTest(eventProxy.EventRaised, String.Format("{0} of type '{1}' raised.", eventProxy.EventRaised ? "Event" : "No event", eventInfo.EventHandlerType.FullName),
                    customMessage, _file, _method);

            } catch(Exception ex) {
                InternalFail($"Action threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;

            } finally {
                eventInfo.GetRemoveMethod().Invoke(@object, new Object[] { d });
            }
        }

        /// <summary>
        /// Tests if <paramref name="action"/> raises one or many events with <typeparamref name="TEventArgs"/> on <paramref name="object"/>.
        /// </summary>
        /// <typeparam name="TEventArgs">The expected type of event arguments.</typeparam>
        /// <param name="action">The action to be invoked.</param>
        /// <param name="object">The object that raises the event.</param>
        /// <param name="eventName">The name of the event to be raised.</param>
        /// <param name="eventDatas">The collection of event datas containing senders and arguments.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Action.RaisesEvent(() => obj.DoSomething(), obj, "MyCustomEvent", out EventDataCollection&lt;MyCustomEventArgs&gt; eventDatas);
        /// </code>
        /// </example>
        public void RaisesEvent<TEventArgs>(Action action, Object @object, String eventName, out EventDataCollection<TEventArgs> eventDatas,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where TEventArgs : EventArgs {

            eventDatas = null;

            if(action == null) {
                InternalFail($"Parameter '{nameof(action)}' is null.", _file, _method);
                return;
            }

            if(@object == null) {
                InternalFail($"Parameter '{nameof(@object)}' is null.", _file, _method);
                return;
            }

            if(String.IsNullOrWhiteSpace(eventName)) {
                InternalFail($"Parameter '{nameof(eventName)}' is null or empty.", _file, _method);
                return;
            }

            Delegate d = null;

            MultiEventProxy<TEventArgs> eventProxy = new MultiEventProxy<TEventArgs>();
            MethodInfo handlerInfo = eventProxy.GetType().GetRuntimeMethods().First(method => method.Name == "OnEventRaised");

            EventInfo eventInfo = @object.GetType().GetRuntimeEvent(eventName);

            if(eventInfo == null) {
                InternalFail($"Event with name {eventName.Format()} could not be found.",
                    _file, _method);
                return;
            }

            try {
                d = Delegate.CreateDelegate(eventInfo.EventHandlerType, eventProxy, handlerInfo);

            } catch {
                InternalFail($"Given type of arguments {typeof(TEventArgs).Format()} doesn't match event handler of type {eventInfo.EventHandlerType.Format()}.",
                    _file, _method);
                return;
            }

            eventInfo.GetAddMethod().Invoke(@object, new Object[] { d });

            try {
                action();
                eventDatas = eventProxy.EventData;

                InternalTest(eventProxy.EventRaised, $"Event of type {eventInfo.EventHandlerType.Format()} raised {eventProxy.RaiseCount} times.",
                    customMessage, _file, _method);

            } catch(Exception ex) {
                InternalFail($"Action threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;

            } finally {
                eventInfo.GetRemoveMethod().Invoke(@object, new Object[] { d });
            }
        }

        #endregion

    }
}
