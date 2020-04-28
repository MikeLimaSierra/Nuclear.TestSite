using System;

namespace Nuclear.TestSite.TestTypes {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DummyIComparableT : Dummy, IComparable<DummyIComparableT> {

        public DummyIComparableT(Int32 value) : base(value) { }

        public Int32 CompareTo(DummyIComparableT other) => Value.CompareTo(other.Value);

        public static implicit operator DummyIComparableT(Int32 num) => new DummyIComparableT(num);

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
