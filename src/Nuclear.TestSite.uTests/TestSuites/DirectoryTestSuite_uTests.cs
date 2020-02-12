using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    class DirectoryTestSuite_uTests {

        #region Exists

        [TestMethod]
        void Exists() {

            String path = "C:/Temp" + String.Join("/", Enumerable.Repeat("asdf", 100));

            DDTExists((DirectoryInfo) null, (1, false, "Parameter 'path' is null or white space."));
            DDTExists((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTExists(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTExists(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTExists("C:/Win|32", (5, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTExists(path, (6, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

            DDTNotExists((DirectoryInfo) null, (7, false, "Parameter 'path' is null or white space."));
            DDTNotExists((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotExists(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotExists(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotExists("C:/Win|32", (11, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTNotExists(path, (12, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

        }

        void DDTExists(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.Exists({input.Format()})");

            Statics.DDTResultState(() => DummyTest.If.Directory.Exists(input), expected, "Test.If.Directory.Exists");

        }

        void DDTExists(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.Exists({input.FullName.Format()})");

            Statics.DDTResultState(() => DummyTest.If.Directory.Exists(input), expected, "Test.If.Directory.Exists");

        }

        void DDTNotExists(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.Exists({input.Format()})");

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.Exists(input), expected, "Test.IfNot.Directory.Exists");

        }

        void DDTNotExists(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.Exists({input.FullName.Format()})");

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.Exists(input), expected, "Test.IfNot.Directory.Exists");

        }

        #endregion

        #region IsEmpty

        [TestMethod]
        void IsEmpty() {

            String path = "C:/Temp" + String.Join("/", Enumerable.Repeat("asdf", 100));

            DDTIsEmpty((DirectoryInfo) null, (1, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty("C:/Win|32", (5, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTIsEmpty(path, (6, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

            DDTNotIsEmpty((DirectoryInfo) null, (7, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty("C:/Win|32", (11, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTNotIsEmpty(path, (12, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

        }

        void DDTIsEmpty(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.IsEmpty({input.Format()})");

            Statics.DDTResultState(() => DummyTest.If.Directory.IsEmpty(input), expected, "Test.If.Directory.IsEmpty");

        }

        void DDTIsEmpty(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.IsEmpty({input.FullName.Format()})");

            Statics.DDTResultState(() => DummyTest.If.Directory.IsEmpty(input), expected, "Test.If.Directory.IsEmpty");

        }

        void DDTNotIsEmpty(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.IsEmpty({input.Format()})");

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.IsEmpty(input), expected, "Test.IfNot.Directory.IsEmpty");

        }

        void DDTNotIsEmpty(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.IsEmpty({input.FullName.Format()})");

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.IsEmpty(input), expected, "Test.IfNot.Directory.IsEmpty");

        }

        #endregion

        #region ContainsFiles

        [TestMethod]
        void ContainsFiles() {

            String path = "C:/Temp" + String.Join("/", Enumerable.Repeat("asdf", 100));

            DDTContainsFiles((DirectoryInfo) null, (1, false, "Parameter 'path' is null or white space."));
            DDTContainsFiles((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTContainsFiles(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTContainsFiles(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTContainsFiles("C:/Win|32", (5, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTContainsFiles(path, (6, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

            DDTNotContainsFiles((DirectoryInfo) null, (7, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFiles((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFiles(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFiles(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFiles("C:/Win|32", (11, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTNotContainsFiles(path, (12, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

        }

        void DDTContainsFiles(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.Format()})");

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input), expected, "Test.If.Directory.ContainsFiles");

        }

        void DDTContainsFiles(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.FullName.Format()})");

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input), expected, "Test.If.Directory.ContainsFiles");

        }

        void DDTNotContainsFiles(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.Format()})");

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input), expected, "Test.IfNot.Directory.ContainsFiles");

        }

        void DDTNotContainsFiles(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.FullName.Format()})");

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input), expected, "Test.IfNot.Directory.ContainsFiles");

        }

        #endregion

        #region ContainsDirectories

        [TestMethod]
        void ContainsDirectories() {

            String path = "C:/Temp" + String.Join("/", Enumerable.Repeat("asdf", 100));

            DDTContainsDirectories((DirectoryInfo) null, (1, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectories((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectories(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectories(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectories("C:/Win|32", (5, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTContainsDirectories(path, (6, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

            DDTNotContainsDirectories((DirectoryInfo) null, (7, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectories((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectories(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectories(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectories("C:/Win|32", (11, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTNotContainsDirectories(path, (12, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

        }

        void DDTContainsDirectories(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.Format()})");

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input), expected, "Test.If.Directory.ContainsDirectories");

        }

        void DDTContainsDirectories(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.FullName.Format()})");

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input), expected, "Test.If.Directory.ContainsDirectories");

        }

        void DDTNotContainsDirectories(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.Format()})");

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input), expected, "Test.IfNot.Directory.ContainsDirectories");

        }

        void DDTNotContainsDirectories(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.FullName.Format()})");

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input), expected, "Test.IfNot.Directory.ContainsDirectories");

        }

        #endregion

    }
}
