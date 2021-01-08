using System;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    public partial class StringTestSuite {

        #region StartsWith

        /// <summary>
        /// Tests if a <see cref="String"/> starts with a specific <see cref="Char"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="Char"/> to check for.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.StartsWith(someString, '.');
        /// </code>
        /// </example>
        public void StartsWith(String @string, Char value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) => StartsWith(@string, value, StringComparison.CurrentCulture, customMessage, _file, _method);

        /// <summary>
        /// Tests if a <see cref="String"/> starts with a specific <see cref="Char"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="Char"/> to check for.</param>
        /// <param name="comparisonType">The value defining how strings are compared.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.StartsWith(someString, '.', StringComparison.CurrentCultureIgnoreCase);
        /// </code>
        /// </example>
        public void StartsWith(String @string, Char value, StringComparison comparisonType,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(@string == null) {
                InternalFail($"Parameter '{nameof(@string)}' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(StringComparison), comparisonType)) {
                InternalFail($"Parameter '{nameof(comparisonType)}' is out of bounds.", _file, _method);
                return;
            }

            String message;

            if(comparisonType == StringComparison.CurrentCulture) {
                message = $"[String = {@string.Format()}; Value = {value.Format()}]";
            } else {
                message = $"[String = {@string.Format()}; Value = {value.Format()}; ComparisonType = {comparisonType.Format()}]";
            }

            InternalTest(@string.StartsWith(value, comparisonType), message,
                customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if a <see cref="String"/> starts with a specific <see cref="String"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="String"/> to check for.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.StartsWith(someString, "https://");
        /// </code>
        /// </example>
        public void StartsWith(String @string, String value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) => StartsWith(@string, value, StringComparison.CurrentCulture, customMessage, _file, _method);

        /// <summary>
        /// Tests if a <see cref="String"/> starts with a specific <see cref="String"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="String"/> to check for.</param>
        /// <param name="comparisonType">The value defining how strings are compared.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.StartsWith(someString, "https://", StringComparison.CurrentCultureIgnoreCase);
        /// </code>
        /// </example>
        public void StartsWith(String @string, String value, StringComparison comparisonType,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(@string == null) {
                InternalFail($"Parameter '{nameof(@string)}' is null.", _file, _method);
                return;
            }

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(StringComparison), comparisonType)) {
                InternalFail($"Parameter '{nameof(comparisonType)}' is out of bounds.", _file, _method);
                return;
            }

            String message;

            if(comparisonType == StringComparison.CurrentCulture) {
                message = $"[String = {@string.Format()}; Value = {value.Format()}]";
            } else {
                message = $"[String = {@string.Format()}; Value = {value.Format()}; ComparisonType = {comparisonType.Format()}]";
            }

            InternalTest(@string.StartsWith(value, comparisonType), message,
                customMessage, _file, _method);
        }

        #endregion

        #region EndsWith

        /// <summary>
        /// Tests if a <see cref="String"/> ends with a specific <see cref="Char"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="Char"/> to check for.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.EndsWith(someString, '/');
        /// </code>
        /// </example>
        public void EndsWith(String @string, Char value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) => EndsWith(@string, value, StringComparison.CurrentCulture, customMessage, _file, _method);

        /// <summary>
        /// Tests if a <see cref="String"/> ends with a specific <see cref="Char"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="Char"/> to check for.</param>
        /// <param name="comparisonType">The value defining how strings are compared.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.EndsWith(someString, '/');
        /// </code>
        /// </example>
        public void EndsWith(String @string, Char value, StringComparison comparisonType,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(@string == null) {
                InternalFail($"Parameter '{nameof(@string)}' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(StringComparison), comparisonType)) {
                InternalFail($"Parameter '{nameof(comparisonType)}' is out of bounds.", _file, _method);
                return;
            }

            String message;

            if(comparisonType == StringComparison.CurrentCulture) {
                message = $"[String = {@string.Format()}; Value = {value.Format()}]";
            } else {
                message = $"[String = {@string.Format()}; Value = {value.Format()}; ComparisonType = {comparisonType.Format()}]";
            }

            InternalTest(@string.EndsWith(value, comparisonType), message,
                customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if a <see cref="String"/> ends with a specific <see cref="String"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="String"/> to check for.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.EndsWith(someString, ".xml");
        /// </code>
        /// </example>
        public void EndsWith(String @string, String value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) => EndsWith(@string, value, StringComparison.CurrentCulture, customMessage, _file, _method);

        /// <summary>
        /// Tests if a <see cref="String"/> ends with a specific <see cref="String"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="String"/> to check for.</param>
        /// <param name="comparisonType">The value defining how strings are compared.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.EndsWith(someString, ".xml");
        /// </code>
        /// </example>
        public void EndsWith(String @string, String value, StringComparison comparisonType,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(@string == null) {
                InternalFail($"Parameter '{nameof(@string)}' is null.", _file, _method);
                return;
            }

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(StringComparison), comparisonType)) {
                InternalFail($"Parameter '{nameof(comparisonType)}' is out of bounds.", _file, _method);
                return;
            }

            String message;

            if(comparisonType == StringComparison.CurrentCulture) {
                message = $"[String = {@string.Format()}; Value = {value.Format()}]";
            } else {
                message = $"[String = {@string.Format()}; Value = {value.Format()}; ComparisonType = {comparisonType.Format()}]";
            }

            InternalTest(@string.EndsWith(value, comparisonType), message,
                customMessage, _file, _method);
        }

        #endregion

        #region Null

        /// <summary>
        /// Tests if a <see cref="String"/> is null or empty.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.IsNullOrEmpty(someString);
        /// </code>
        /// </example>
        public void IsNullOrEmpty(String @string,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => InternalTest(String.IsNullOrEmpty(@string), $"[String = {@string.Format()}]",
                customMessage, _file, _method);

        /// <summary>
        /// Tests if a <see cref="String"/> is null or white spaces.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.IsNullOrWhiteSpace(someString);
        /// </code>
        /// </example>
        public void IsNullOrWhiteSpace(String @string,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => InternalTest(String.IsNullOrWhiteSpace(@string), $"[String = {@string.Format()}]",
                customMessage, _file, _method);

        #endregion

        #region Contains

        /// <summary>
        /// Tests if a <see cref="String"/> contains a specific <see cref="String"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="String"/> to check for.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.Contains(someString, "John Doe");
        /// </code>
        /// </example>
        public void Contains(String @string, String value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) => Contains(@string, value, StringComparison.CurrentCulture, customMessage, _file, _method);

        /// <summary>
        /// Tests if a <see cref="String"/> contains a specific <see cref="String"/>.
        /// </summary>
        /// <param name="string">The <see cref="String"/> to be checked.</param>
        /// <param name="value">The <see cref="String"/> to check for.</param>
        /// <param name="comparisonType">The value defining how strings are compared.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.String.Contains(someString, "John Doe");
        /// </code>
        /// </example>
        public void Contains(String @string, String value, StringComparison comparisonType,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(@string == null) {
                InternalFail($"Parameter '{nameof(@string)}' is null.", _file, _method);
                return;
            }

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(StringComparison), comparisonType)) {
                InternalFail($"Parameter '{nameof(comparisonType)}' is out of bounds.", _file, _method);
                return;
            }

            InternalTest(@string.Contains(value, comparisonType), $"[String = {@string.Format()}; Value = {value.Format()}; Comparison = {comparisonType.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

    }
}
