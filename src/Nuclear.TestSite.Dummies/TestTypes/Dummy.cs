using System;

namespace Nuclear.TestSite.TestTypes {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class Dummy {

        public Int32 Value { get; private set; }

        public Dummy(Int32 value) { Value = value; }

        public override String ToString() => Value.ToString();

        public static implicit operator Dummy(Int32 num) => new Dummy(num);

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
