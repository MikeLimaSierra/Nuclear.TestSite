using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Nuclear.TestSite.TestSuites.Proxies {
    class EventProxy_uTests {

        [TestMethod]
        void Ctor() {

            EventProxy<PropertyChangedEventArgs> proxy = null;

            Test.IfNot.Action.ThrowsException(() => proxy = new EventProxy<PropertyChangedEventArgs>(), out Exception ex);
            Test.If.Value.IsFalse(proxy.EventRaised);
            Test.If.Object.IsNull(proxy.EventData);

        }

        [TestMethod]
        [TestData(nameof(OnEventRaisedData))]
        void OnEventRaised(Object input1, PropertyChangedEventArgs input2, Object sender, PropertyChangedEventArgs e) {

            EventProxy<PropertyChangedEventArgs> proxy = new EventProxy<PropertyChangedEventArgs>();

            Test.IfNot.Action.ThrowsException(() => proxy.OnEventRaised(input1, input2), out Exception ex);

            Test.If.Value.IsTrue(proxy.EventRaised);
            Test.IfNot.Object.IsNull(proxy.EventData);
            Test.If.Reference.IsEqual(proxy.EventData.Sender, sender);
            Test.If.Reference.IsEqual(proxy.EventData.EventArgs, e);

        }

        IEnumerable<Object[]> OnEventRaisedData() {
            Object sender = new Object();
            PropertyChangedEventArgs e = new PropertyChangedEventArgs("dummy");

            return new List<Object[]>() {
                new Object[] { null, null, null, null },
                new Object[] { sender, e, sender, e },
            };
        }

    }
}
