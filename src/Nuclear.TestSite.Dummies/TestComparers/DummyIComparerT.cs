using System;
using System.Collections.Generic;

using Nuclear.TestSite.TestTypes;

namespace Nuclear.TestSite.TestComparers {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DummyIComparerT : IComparer<Dummy> {

        public Int32 Compare(Dummy x, Dummy y) {
            if(x == null) {
                return y == null ? 0 : -Compare(y, x);
            }

            return y == null ? 1 : x.Value.CompareTo(y.Value);
        }

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
