using System;
using System.IO;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    public partial class FileTestSuite {

        #region Exists

        /// <summary>
        /// Tests if the file at <paramref name="path"/> exists on disk.
        /// </summary>
        /// <param name="path">The file path to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.File.Exists(@"C:\Temp");
        /// </code>
        /// </example>
        public void Exists(String path,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest($"Parameter '{nameof(path)}' is null or white space.", _file, _method);
                return;
            }

            Boolean result = File.Exists(path);

            InternalTest(result, String.Format("File {0} {1}.", path.Format(), result ? "exists" : "doesn't exist"),
                customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="file"/> exists on disk.
        /// </summary>
        /// <param name="file">The file to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.File.Exists(dir);
        /// </code>
        /// </example>
        public void Exists(FileInfo file,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(file == null) {
                FailTest($"Parameter '{nameof(file)}' is null.", _file, _method);
                return;
            }

            file.Refresh();

            Boolean result = file.Exists;

            InternalTest(result, String.Format("File {0} {1}.", file.FullName.Format(), result ? "exists" : "doesn't exist"),
                customMessage, _file, _method);
        }

        #endregion

        #region IsEmpty

        /// <summary>
        /// Tests if the file at <paramref name="path"/> is empty.
        /// </summary>
        /// <param name="path">The file path to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.File.IsEmpty(@"C:\Temp");
        /// </code>
        /// </example>
        public void IsEmpty(String path,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest($"Parameter '{nameof(path)}' is null or white space.", _file, _method);
                return;
            }

            if(!File.Exists(path)) {
                FailTest($"File {path.Format()} doesn't exist.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = File.ReadAllText(path).Length == 0;

            } catch(Exception ex) {
                FailTest($"Operation threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, String.Format("File {0} is {1}empty.", path.Format(), result ? String.Empty : "not "),
                customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="file"/> is empty.
        /// </summary>
        /// <param name="file">The file to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Fil.IsEmpty(file);
        /// </code>
        /// </example>
        public void IsEmpty(FileInfo file,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(file == null) {
                FailTest($"Parameter '{nameof(file)}' is null.", _file, _method);
                return;
            }

            file.Refresh();

            if(!file.Exists) {
                FailTest($"File {file.Format()} doesn't exist.", _file, _method);
                return;
            }

            Boolean result = false;

            if(file.Length <= 6) {
                try {
                    result = File.ReadAllText(file.FullName).Length == 0;

                } catch(Exception ex) {
                    FailTest($"Operation threw Exception: {ex.Message.Format()}",
                        _file, _method);
                    return;
                }
            }

            InternalTest(result, String.Format("File {0} is {1}empty.", file.FullName.Format(), result ? String.Empty : "not "),
                customMessage, _file, _method);
        }

        #endregion

        #region HasAttribute

        /// <summary>
        /// Tests if the file at <paramref name="path"/> has an <paramref name="attribute"/>.
        /// </summary>
        /// <param name="path">The file path to be checked.</param>
        /// <param name="attribute">The attribute to check for.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.File.HasAttribute(@"C:\Temp", FileAttributes.Temporary);
        /// </code>
        /// </example>
        public void HasAttribute(String path, FileAttributes attribute,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest($"Parameter '{nameof(path)}' is null or white space.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(FileAttributes), attribute)) {
                FailTest($"Parameter '{nameof(attribute)}' is out of bounds.", _file, _method);
                return;
            }

            if(!File.Exists(path)) {
                FailTest($"File {path.Format()} doesn't exist.", _file, _method);
                return;
            }

            FileAttributes attr = default;

            try {
                attr = File.GetAttributes(path);

            } catch(Exception ex) {
                FailTest($"Operation threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            Boolean result = attr.HasFlag(attribute);

            InternalTest(result, String.Format("File {0} is {1}flagged with {2}.", path.Format(), result ? String.Empty : "not ", attribute.Format()),
                customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="file"/> has an <paramref name="attribute"/>.
        /// </summary>
        /// <param name="file">The file to be checked.</param>
        /// <param name="attribute">The attribute to check for.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.File.HasAttribute(dir, FileAttributes.Temporary);
        /// </code>
        /// </example>
        public void HasAttribute(FileInfo file, FileAttributes attribute,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(file == null) {
                FailTest($"Parameter '{nameof(file)}' is null.", _file, _method);
                return;
            }

            file.Refresh();

            if(!file.Exists) {
                FailTest($"File {file.Format()} doesn't exist.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(FileAttributes), attribute)) {
                FailTest($"Parameter '{nameof(attribute)}' is out of bounds.", _file, _method);
                return;
            }

            Boolean result = file.Attributes.HasFlag(attribute);

            InternalTest(result, String.Format("File {0} is {1}flagged with {2}.", file.FullName.Format(), result ? String.Empty : "not ", attribute.Format()),
                customMessage, _file, _method);
        }

        #endregion

    }
}
