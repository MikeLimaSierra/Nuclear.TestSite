using System;
using System.Collections.Generic;

using Nuclear.TestSite.TestTypes;

namespace Nuclear.TestSite.TestComparers {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class ThrowingComparer : Comparer<Dummy> {

        public override Int32 Compare(Dummy x, Dummy y) => throw new NotImplementedException();

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
