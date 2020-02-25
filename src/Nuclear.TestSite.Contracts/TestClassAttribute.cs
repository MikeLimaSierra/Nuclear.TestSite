using System;

namespace Nuclear.TestSite {

    /// <summary>
    /// Explicitly marks a class as containing test methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class TestClassAttribute : Attribute {

        #region properties

        /// <summary>
        /// Gets the <see cref="TestMode"/> of the corresponding class.
        /// </summary>
        public TestMode TestMode { get; private set; }

        /// <summary>
        /// Gets the reason why the corresponding test class is being ignored.
        /// </summary>
        public String IgnoreReason { get; private set; }

        /// <summary>
        /// Gets if the corresponding test class is being ignored.
        /// </summary>
        public Boolean IsIgnored => !String.IsNullOrWhiteSpace(IgnoreReason);

        #endregion

        #region ctors

        /// <summary>
        /// Creates a new instance of <see cref="TestClassAttribute"/> with <see cref="TestMode.Parallel"/>.
        /// </summary>
        public TestClassAttribute() : this(TestMode.Parallel, null) { }

        /// <summary>
        /// Creates a new instance of <see cref="TestClassAttribute"/>.
        /// </summary>
        /// <param name="testMode">The <see cref="TestMode"/> of the corresponding test class.</param>
        public TestClassAttribute(TestMode testMode) : this(testMode, null) { }

        /// <summary>
        /// Creates a new instance of <see cref="TestClassAttribute"/> with <see cref="TestMode.Parallel"/>.
        /// </summary>
        /// <param name="ignoreReason">The reason why this test class is being ignored.</param>
        public TestClassAttribute(String ignoreReason) : this(TestMode.Parallel, ignoreReason) { }

        /// <summary>
        /// Creates a new instance of <see cref="TestClassAttribute"/>.
        /// </summary>
        /// <param name="testMode">The <see cref="TestMode"/> of the corresponding test method.</param>
        /// <param name="ignoreReason">The reason why this test class is being ignored.</param>
        public TestClassAttribute(TestMode testMode, String ignoreReason) {
            TestMode = Enum.IsDefined(typeof(TestMode), testMode) ? testMode : TestMode.Parallel;
            IgnoreReason = ignoreReason;
        }

        #endregion

    }
}
