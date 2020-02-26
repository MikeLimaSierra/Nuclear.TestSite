using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    public partial class FileTestSuite {

        #region Exists

        /// <summary>
        /// Tests if the file at <paramref name="path"/> exists on disk.
        /// </summary>
        /// <param name="path">The file path to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.File.Exists(@"C:\Temp");
        /// </code>
        /// </example>
        public void Exists(String path,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest($"Parameter '{nameof(path)}' is null or white space.", _file, _method);
                return;
            }

            if(new Char[] { '"', '<', '>', '|' }.Any((c) => path.Contains(c))) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;
            }

            FileInfo dir;

            try {
                dir = new FileInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(UnauthorizedAccessException) {
                FailTest($"Access to {path.Format()} is denied.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(NotSupportedException) {
                FailTest($"{path.Format()} contains a colon (:) in the middle of the string.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the FileInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            Exists(dir, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="file"/> exists on disk.
        /// </summary>
        /// <param name="file">The file to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.File.Exists(dir);
        /// </code>
        /// </example>
        public void Exists(FileInfo file,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(file == null) {
                FailTest($"Parameter '{nameof(file)}' is null.", _file, _method);
                return;
            }

            file.Refresh();

            Boolean result = file.Exists;

            InternalTest(result, String.Format("File {0} {1}.", file.FullName.Format(), result ? "exists" : "does not exist"),
                _file, _method);
        }

        #endregion

    }
}
