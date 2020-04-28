using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Nuclear.TestSite.TestComparers {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class PropertyChangedEventDataEqualityComparer : IEqualityComparer<EventData<PropertyChangedEventArgs>> {

        public Boolean Equals(EventData<PropertyChangedEventArgs> x, EventData<PropertyChangedEventArgs> y) {
            if(x == null) {
                return y == null ? true : y.Equals(x);
            }

            return ReferenceEquals(x.Sender, y.Sender) && x.EventArgs.PropertyName.Equals(y.EventArgs.PropertyName);
        }

        public Int32 GetHashCode(EventData<PropertyChangedEventArgs> obj) => 0;

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
