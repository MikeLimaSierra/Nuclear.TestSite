using System;
using System.Collections.Generic;

using Nuclear.Extensions;

namespace Nuclear.TestSite {

    /// <summary>
    /// Marks a test method with test data.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class TestDataAttribute : Attribute {

        internal enum TestDataKind {
            ParameterArray,
            ProviderType,
        }

        #region properties

        internal TestDataKind DataKind { get; private set; }

        /// <summary>
        /// Gets the parameters for the corresponding test method.
        /// </summary>
        public Object[] Parameters { get; private set; }

        /// <summary>
        /// Gets the type that provides the test data.
        /// </summary>
        public Type Provider { get; private set; }

        /// <summary>
        /// Gets the name of the providing method.
        /// </summary>
        public String ProviderName { get; private set; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="TestDataAttribute"/>.
        /// </summary>
        /// <param name="parameters">The <paramref name="parameters"/> that are fed into the corresponding test method.</param>
        public TestDataAttribute(params Object[] parameters) {
            Parameters = parameters;
            DataKind = TestDataKind.ParameterArray;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TestDataAttribute"/>.
        ///     If <paramref name="providerName"/> is a valid method name of <paramref name="provider"/> and
        ///       returns <see cref="IEnumerable{Object}"/> then this is invoked to yield test data.
        ///     Otherwise <see cref="IEnumerable{Object}.GetEnumerator()"/> will be invoked on an instance of
        ///       <paramref name="provider"/> if the type implements <see cref="IEnumerable{Object}"/>.
        /// </summary>
        /// <param name="provider">The provider <see cref="Type"/> that implements <see cref="IEnumerable{Object}"/>.</param>
        /// <param name="providerName">The name of the method to invoke on an instance of <paramref name="provider"/>.</param>
        public TestDataAttribute(Type provider, String providerName = null) {
            Provider = provider;
            ProviderName = providerName;
            DataKind = TestDataKind.ProviderType;
        }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override String ToString() {
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            switch(DataKind) {
                case TestDataKind.ParameterArray:
                    return $"[TestData({Parameters.Format()})]";

                case TestDataKind.ProviderType:
                    return $"[TestData({Provider.Format()}, {ProviderName.Format()})]";

                default:
                    return "[TestData]";
            }
        }

        #endregion

    }
}
