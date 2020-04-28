using System;
using System.Collections;

namespace Nuclear.TestSite.TestComparers {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class ThrowingIEqualityComparer : IEqualityComparer {

        public new Boolean Equals(Object x, Object y) => throw new NotImplementedException();

        public Int32 GetHashCode(Object obj) => throw new NotImplementedException();

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
