using System;
using System.Collections;

namespace Nuclear.TestSite.TestComparers {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class ThrowingIComparer : IComparer {

        public Int32 Compare(Object x, Object y) => throw new NotImplementedException();

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
