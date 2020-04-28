using System;

using Nuclear.TestSite.TestComparers;

namespace Nuclear.TestSite.TestTypes {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DummyIEquatableT : Dummy, IEquatable<DummyIEquatableT> {

        public DummyIEquatableT(Int32 value) : base(value) { }

        public Boolean Equals(DummyIEquatableT other) {
            if(other == null) { return false; }

            return Value.Equals(other.Value);
        }

        public override Boolean Equals(Object obj) {
            if(obj is DummyIEquatableT dummy) { return this == dummy; }

            return base.Equals(obj);
        }

        public override Int32 GetHashCode() => base.GetHashCode();

        public static implicit operator DummyIEquatableT(Int32 num) => new DummyIEquatableT(num);

        public static Boolean operator ==(DummyIEquatableT left, DummyIEquatableT right) => new DummyIEqualityComparerT().Equals(left, right);

        public static Boolean operator !=(DummyIEquatableT left, DummyIEquatableT right) => !new DummyIEqualityComparerT().Equals(left, right);

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
