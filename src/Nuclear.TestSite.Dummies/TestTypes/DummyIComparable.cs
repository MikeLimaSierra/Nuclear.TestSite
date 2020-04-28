using System;

namespace Nuclear.TestSite.TestTypes {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DummyIComparable : Dummy, IComparable {

        public DummyIComparable(Int32 value) : base(value) { }

        public Int32 CompareTo(Object obj) => Value.CompareTo((obj as DummyIComparable).Value);

        public static implicit operator DummyIComparable(Int32 num) => new DummyIComparable(num);

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
