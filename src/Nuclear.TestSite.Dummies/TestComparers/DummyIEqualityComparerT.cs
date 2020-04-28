using System;
using System.Collections.Generic;

using Nuclear.TestSite.TestTypes;

namespace Nuclear.TestSite.TestComparers {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DummyIEqualityComparerT : IEqualityComparer<Dummy> {

        public Boolean Equals(Dummy x, Dummy y) {
            if(x == null) {
                return y == null ? true : y.Equals(x);
            }

            return y == null ? false : x.Value.Equals(y.Value);
        }

        public Int32 GetHashCode(Dummy obj) => obj.Value;

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
