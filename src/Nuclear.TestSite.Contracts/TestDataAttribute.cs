using System;
using System.Collections.Generic;

using Nuclear.Extensions;

namespace Nuclear.TestSite {

    /// <summary>
    /// Marks a test method with test data.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class TestDataAttribute : Attribute {

        #region properties

        /// <summary>
        /// Gets the type that provides the test data.
        /// </summary>
        public Type Provider { get; private set; }

        /// <summary>
        /// Gets the name of the providing member.
        /// </summary>
        public String ProviderMember { get; private set; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="TestDataAttribute"/> using <see cref="IEnumerable{T}.GetEnumerator"/>
        ///   where the generic type argument is <see cref="T:Object[]"/> declared by <paramref name="provider"/> to provide test data.
        /// </summary>
        /// <param name="provider">The provider <see cref="Type"/> that implements <see cref="IEnumerable{T}"/>
        ///   where the generic type argument is <see cref="T:Object[]"/>.</param>
        public TestDataAttribute(Type provider) : this(provider, null) { }

        /// <summary>
        /// Creates a new instance of <see cref="TestDataAttribute"/> using a member named <paramref name="providerMember"/>
        ///   declared by the test class to provide test data.
        /// </summary>
        /// <param name="providerMember">The name of the member that provides test data.</param>
        public TestDataAttribute(String providerMember) : this(null, providerMember) { }

        /// <summary>
        /// Creates a new instance of <see cref="TestDataAttribute"/> using a member named <paramref name="providerMember"/>
        ///   declared by <paramref name="provider"/> to provide test data.
        /// </summary>
        /// <param name="provider">The provider <see cref="Type"/> that implements <see cref="IEnumerable{Object}"/>.</param>
        /// <param name="providerMember">The name of the member that provides test data.</param>
        public TestDataAttribute(Type provider, String providerMember) {
            Provider = provider;
            ProviderMember = providerMember;
        }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override String ToString() => $"[TestData({Provider.Format()}, {ProviderMember.Format()})]";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion

    }
}
