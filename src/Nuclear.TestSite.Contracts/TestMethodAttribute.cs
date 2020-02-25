using System;

namespace Nuclear.TestSite {

    /// <summary>
    /// Marks a method as test method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class TestMethodAttribute : Attribute {

        #region properties

        /// <summary>
        /// Gets the <see cref="TestMode"/> of the corresponding test method.
        /// </summary>
        public TestMode TestMode { get; private set; }

        /// <summary>
        /// Gets the reason why the corresponding test method is being ignored.
        /// </summary>
        public String IgnoreReason { get; private set; }

        /// <summary>
        /// Gets if the corresponding test method is being ignored.
        /// </summary>
        public Boolean IsIgnored => !String.IsNullOrWhiteSpace(IgnoreReason);

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="TestMethodAttribute"/> with <see cref="TestMode.Parallel"/>.
        /// </summary>
        public TestMethodAttribute() : this(TestMode.Parallel, null) { }

        /// <summary>
        /// Creates a new instance of <see cref="TestMethodAttribute"/>.
        /// </summary>
        /// <param name="testMode">The <see cref="TestMode"/> of the corresponding test method.</param>
        public TestMethodAttribute(TestMode testMode) : this(testMode, null) { }

        /// <summary>
        /// Creates a new instance of <see cref="TestMethodAttribute"/> with <see cref="TestMode.Parallel"/>.
        /// </summary>
        /// <param name="ignoreReason">The reason why this test method is being ignored.</param>
        public TestMethodAttribute(String ignoreReason) : this(TestMode.Parallel, ignoreReason) { }

        /// <summary>
        /// Creates a new instance of <see cref="TestMethodAttribute"/>.
        /// </summary>
        /// <param name="testMode">The <see cref="TestMode"/> of the corresponding test method.</param>
        /// <param name="ignoreReason">The reason why this test method is being ignored.</param>
        public TestMethodAttribute(TestMode testMode, String ignoreReason) {
            TestMode = Enum.IsDefined(typeof(TestMode), testMode) ? testMode : TestMode.Parallel;
            IgnoreReason = ignoreReason;
        }

        #endregion

    }
}
