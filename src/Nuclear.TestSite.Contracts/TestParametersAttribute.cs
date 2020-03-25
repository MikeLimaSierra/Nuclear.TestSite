using System;

using Nuclear.Extensions;

namespace Nuclear.TestSite {

    /// <summary>
    /// Marks a test method with test parameters.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class TestParametersAttribute : Attribute {

        #region properties

        /// <summary>
        /// Gets the parameters for the corresponding test method.
        /// </summary>
        public Object[] Parameters { get; private set; }

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="TestParametersAttribute"/>.
        /// </summary>
        /// <param name="parameters">The <paramref name="parameters"/> that are fed into the corresponding test method.</param>
        public TestParametersAttribute(params Object[] parameters) {
            Parameters = parameters;
        }

        #endregion

        #region methods

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override String ToString() => $"[TestParameters({Parameters.Format()})]";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #endregion

    }
}
