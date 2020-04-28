using System;
using System.Collections;

using Nuclear.TestSite.TestTypes;

namespace Nuclear.TestSite.TestComparers {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DummyIEqualityComparer : IEqualityComparer {

        public new Boolean Equals(Object x, Object y) {
            if(x == null) {
                return y == null ? true : y.Equals(x);
            }

            return y == null ? false : (x as Dummy).Value.Equals((y as Dummy).Value);
        }

        public Int32 GetHashCode(Object obj) => (obj as Dummy).Value;

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
