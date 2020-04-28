using System;
using System.Collections;

using Nuclear.TestSite.TestTypes;

namespace Nuclear.TestSite.TestComparers {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DummyIComparer : IComparer {

        public Int32 Compare(Object x, Object y) {
            if(x == null) {
                return y == null ? 0 : -Compare(y, x);
            }

            return y == null ? 1 : (x as Dummy).Value.CompareTo((y as Dummy).Value);
        }

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
