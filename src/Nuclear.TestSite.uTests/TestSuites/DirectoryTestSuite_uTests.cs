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

            Test.Note($"Test.If.Directory.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.Exists(input),
                expected, "Test.If.Directory.Exists", _file, _method);

        }

        void DDTExists(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.Exists({input.FullName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.Exists(input),
                expected, "Test.If.Directory.Exists", _file, _method);

        }

        void DDTNotExists(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.Exists(input),
                expected, "Test.IfNot.Directory.Exists", _file, _method);

        }

        void DDTNotExists(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.Exists({input.FullName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.Exists(input),
                expected, "Test.IfNot.Directory.Exists", _file, _method);

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

            Test.Note($"Test.If.Directory.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.IsEmpty(input),
                expected, "Test.If.Directory.IsEmpty", _file, _method);

        }

        void DDTIsEmpty(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.IsEmpty({input.FullName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.IsEmpty(input),
                expected, "Test.If.Directory.IsEmpty", _file, _method);

        }

        void DDTNotIsEmpty(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.IsEmpty(input),
                expected, "Test.IfNot.Directory.IsEmpty", _file, _method);

        }

        void DDTNotIsEmpty(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.IsEmpty({input.FullName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.IsEmpty(input),
                expected, "Test.IfNot.Directory.IsEmpty", _file, _method);

        }

        #endregion

        #region HasAttribute

        [TestMethod]
        void HasAttribute() {

            String path = "C:/Temp" + String.Join("/", Enumerable.Repeat("asdf", 100));

            DDTHasAttribute(((DirectoryInfo) null, (FileAttributes) 1000000), (1, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute(((DirectoryInfo) null, FileAttributes.Normal), (2, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((new DirectoryInfo(@"C:\Users"), (FileAttributes) 1000000), (3, false, "Parameter 'attribute' is out of bounds."));
            DDTHasAttribute(((String) null, (FileAttributes) 1000000), (4, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute(((String) null, FileAttributes.Normal), (5, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((@"C:\Users", (FileAttributes) 1000000), (6, false, "Parameter 'attribute' is out of bounds."));
            DDTHasAttribute((String.Empty, FileAttributes.Normal), (7, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((" ", FileAttributes.Normal), (8, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute(("C:/Win|32", FileAttributes.Normal), (9, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTHasAttribute((path, FileAttributes.Normal), (10, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

            DDTNotHasAttribute(((DirectoryInfo) null, (FileAttributes) 1000000), (11, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute(((DirectoryInfo) null, FileAttributes.Normal), (12, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((new DirectoryInfo(@"C:\Users"), (FileAttributes) 1000000), (13, false, "Parameter 'attribute' is out of bounds."));
            DDTNotHasAttribute(((String) null, (FileAttributes) 1000000), (14, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute(((String) null, FileAttributes.Normal), (15, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((@"C:\Users", (FileAttributes) 1000000), (16, false, "Parameter 'attribute' is out of bounds."));
            DDTNotHasAttribute((String.Empty, FileAttributes.Normal), (17, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((" ", FileAttributes.Normal), (18, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute(("C:/Win|32", FileAttributes.Normal), (19, false, "The path 'C:/Win|32' contains invalid characters such as \", <, >, or |."));
            DDTNotHasAttribute((path, FileAttributes.Normal), (20, false, $"The path {path.Format()} exceeds the system-defined maximum length."));

        }

        void DDTHasAttribute((String path, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.HasAttribute({input.path.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.HasAttribute(input.path, input.attr),
                expected, "Test.If.Directory.HasAttribute", _file, _method);

        }

        void DDTHasAttribute((DirectoryInfo dir, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.HasAttribute({input.dir.FullName.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.HasAttribute(input.dir, input.attr),
                expected, "Test.If.Directory.HasAttribute", _file, _method);

        }

        void DDTNotHasAttribute((String path, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.HasAttribute({input.path.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.HasAttribute(input.path, input.attr),
                expected, "Test.IfNot.Directory.HasAttribute", _file, _method);

        }

        void DDTNotHasAttribute((DirectoryInfo dir, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.HasAttribute({input.dir.FullName.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.HasAttribute(input.dir, input.attr),
                expected, "Test.IfNot.Directory.HasAttribute", _file, _method);

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

            Test.Note($"Test.If.Directory.ContainsFiles({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        void DDTContainsFiles(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.FullName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        void DDTNotContainsFiles(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        void DDTNotContainsFiles(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.FullName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        #endregion

        #region ContainsFilesPattern

        [TestMethod]
        void ContainsFilesPattern() {

        }

        void DDTContainsFilesPattern((String path, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.path.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input.path, input.pattern, input.opt),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        void DDTContainsFilesPattern((DirectoryInfo dir, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.dir.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input.dir, input.pattern, input.opt),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        void DDTNotContainsFilesPattern((String path, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.path.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input.path, input.pattern, input.opt),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        void DDTNotContainsFilesPattern((DirectoryInfo dir, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.dir.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input.dir, input.pattern, input.opt),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        #endregion

        #region ContainsFilesPredicate

        [TestMethod]
        void ContainsFilesPredicate() {

        }

        void DDTContainsFilesPredicate((String path, Predicate<FileInfo> match) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.path.Format()}, {input.match.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input.path, input.match),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        void DDTContainsFilesPredicate((DirectoryInfo dir, Predicate<FileInfo> match) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.dir.FullName.Format()}, {input.match.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input.dir, input.match),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        void DDTNotContainsFilesPredicate((String path, Predicate<FileInfo> match) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.path.Format()}, {input.match.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input.path, input.match),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        void DDTNotContainsFilesPredicate((DirectoryInfo dir, Predicate<FileInfo> match) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.dir.FullName.Format()}, {input.match.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input.dir, input.match),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

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

            Test.Note($"Test.If.Directory.ContainsDirectories({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        void DDTContainsDirectories(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.FullName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        void DDTNotContainsDirectories(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        void DDTNotContainsDirectories(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.FullName.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        #endregion

        #region ContainsDirectoriesPattern

        [TestMethod]
        void ContainsDirectoriesPattern() {

        }

        void DDTContainsDirectoriesPattern((String path, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.path.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input.path, input.pattern, input.opt),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        void DDTContainsDirectoriesPattern((DirectoryInfo dir, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.dir.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input.dir, input.pattern, input.opt),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        void DDTNotContainsDirectoriesPattern((String path, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.path.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input.path, input.pattern, input.opt),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        void DDTNotContainsDirectoriesPattern((DirectoryInfo dir, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.dir.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input.dir, input.pattern, input.opt),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        #endregion

        #region ContainsDirectoriesPredicate

        [TestMethod]
        void ContainsDirectoriesPredicate() {

        }

        void DDTContainsDirectoriesPredicate((String path, Predicate<DirectoryInfo> match) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.path.Format()}, {input.match.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input.path, input.match),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        void DDTContainsDirectoriesPredicate((DirectoryInfo dir, Predicate<DirectoryInfo> match) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.dir.FullName.Format()}, {input.match.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input.dir, input.match), expected,
                "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        void DDTNotContainsDirectoriesPredicate((String path, Predicate<DirectoryInfo> match) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.path.Format()}, {input.match.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input.path, input.match),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        void DDTNotContainsDirectoriesPredicate((DirectoryInfo dir, Predicate<DirectoryInfo> match) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.dir.FullName.Format()}, {input.match.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input.dir, input.match),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        #endregion

    }
}
