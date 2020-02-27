using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    class DirectoryTestSuite_uTests {

        readonly String _crazyLongPath = @"C:\Temp\" + String.Join(@"\", Enumerable.Repeat("abc", Int16.MaxValue / 4));
        readonly String _invalidPath = @"C:\Win|32<Bla>";

        #region Exists

        [TestMethod]
        void Exists() {

            DDTExists((DirectoryInfo) null, (1, false, "Parameter 'directory' is null."));

            DDTExists((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTExists(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTExists(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTExists(_invalidPath, (5, false, $"Directory {_invalidPath.Format()} doesn't exist."));
            DDTExists(_crazyLongPath, (6, false, $"Directory {_crazyLongPath.Format()} doesn't exist."));

            DDTNotExists((DirectoryInfo) null, (7, false, "Parameter 'directory' is null."));

            DDTNotExists((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotExists(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotExists(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotExists(_invalidPath, (11, true, $"Directory {_invalidPath.Format()} doesn't exist."));
            DDTNotExists(_crazyLongPath, (12, true, $"Directory {_crazyLongPath.Format()} doesn't exist."));

        }

        internal static void DDTExists(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.Exists(input, _file, _method),
                expected, "Test.If.Directory.Exists", _file, _method);

        }

        internal static void DDTExists(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.Exists(input, _file, _method),
                expected, "Test.If.Directory.Exists", _file, _method);

        }

        internal static void DDTNotExists(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.Exists(input, _file, _method),
                expected, "Test.IfNot.Directory.Exists", _file, _method);

        }

        internal static void DDTNotExists(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.Exists(input, _file, _method),
                expected, "Test.IfNot.Directory.Exists", _file, _method);

        }

        #endregion

        #region IsEmpty

        [TestMethod]
        void IsEmpty() {

            DDTIsEmpty((DirectoryInfo) null, (1, false, "Parameter 'directory' is null."));

            DDTIsEmpty((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty(_invalidPath, (5, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTIsEmpty(_crazyLongPath, (6, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

            DDTNotIsEmpty((DirectoryInfo) null, (7, false, "Parameter 'directory' is null."));

            DDTNotIsEmpty((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty(_invalidPath, (11, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotIsEmpty(_crazyLongPath, (12, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

        }

        internal static void DDTIsEmpty(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.IsEmpty(input, _file, _method),
                expected, "Test.If.Directory.IsEmpty", _file, _method);

        }

        internal static void DDTIsEmpty(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.IsEmpty(input, _file, _method),
                expected, "Test.If.Directory.IsEmpty", _file, _method);

        }

        internal static void DDTNotIsEmpty(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.IsEmpty(input, _file, _method),
                expected, "Test.IfNot.Directory.IsEmpty", _file, _method);

        }

        internal static void DDTNotIsEmpty(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.IsEmpty(input, _file, _method),
                expected, "Test.IfNot.Directory.IsEmpty", _file, _method);

        }

        #endregion

        #region HasAttribute

        [TestMethod]
        void HasAttribute() {

            DDTHasAttribute(((DirectoryInfo) null, (FileAttributes) 1000000), (1, false, "Parameter 'directory' is null."));
            DDTHasAttribute(((DirectoryInfo) null, FileAttributes.Normal), (2, false, "Parameter 'directory' is null."));
            DDTHasAttribute((new DirectoryInfo(@"C:\Users"), (FileAttributes) 1000000), (3, false, "Parameter 'attribute' is out of bounds."));

            DDTHasAttribute(((String) null, (FileAttributes) 1000000), (4, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute(((String) null, FileAttributes.Normal), (5, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((@"C:\Users", (FileAttributes) 1000000), (6, false, "Parameter 'attribute' is out of bounds."));
            DDTHasAttribute((String.Empty, FileAttributes.Normal), (7, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((" ", FileAttributes.Normal), (8, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((_invalidPath, FileAttributes.Normal), (9, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTHasAttribute((_crazyLongPath, FileAttributes.Normal), (10, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

            DDTNotHasAttribute(((DirectoryInfo) null, (FileAttributes) 1000000), (11, false, "Parameter 'directory' is null."));
            DDTNotHasAttribute(((DirectoryInfo) null, FileAttributes.Normal), (12, false, "Parameter 'directory' is null."));
            DDTNotHasAttribute((new DirectoryInfo(@"C:\Users"), (FileAttributes) 1000000), (13, false, "Parameter 'attribute' is out of bounds."));

            DDTNotHasAttribute(((String) null, (FileAttributes) 1000000), (14, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute(((String) null, FileAttributes.Normal), (15, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((@"C:\Users", (FileAttributes) 1000000), (16, false, "Parameter 'attribute' is out of bounds."));
            DDTNotHasAttribute((String.Empty, FileAttributes.Normal), (17, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((" ", FileAttributes.Normal), (18, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((_invalidPath, FileAttributes.Normal), (19, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotHasAttribute((_crazyLongPath, FileAttributes.Normal), (20, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

        }

        internal static void DDTHasAttribute((String path, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.HasAttribute({input.path.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.HasAttribute(input.path, input.attr, _file, _method),
                expected, "Test.If.Directory.HasAttribute", _file, _method);

        }

        internal static void DDTHasAttribute((DirectoryInfo dir, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.HasAttribute({input.dir.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.HasAttribute(input.dir, input.attr, _file, _method),
                expected, "Test.If.Directory.HasAttribute", _file, _method);

        }

        internal static void DDTNotHasAttribute((String path, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.HasAttribute({input.path.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.HasAttribute(input.path, input.attr, _file, _method),
                expected, "Test.IfNot.Directory.HasAttribute", _file, _method);

        }

        internal static void DDTNotHasAttribute((DirectoryInfo dir, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.HasAttribute({input.dir.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.HasAttribute(input.dir, input.attr, _file, _method),
                expected, "Test.IfNot.Directory.HasAttribute", _file, _method);

        }

        #endregion

        #region ContainsFiles

        [TestMethod]
        void ContainsFiles() {

            DDTContainsFiles((DirectoryInfo) null, (1, false, "Parameter 'directory' is null."));

            DDTContainsFiles((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTContainsFiles(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTContainsFiles(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTContainsFiles(_invalidPath, (5, false, $"Directory {_invalidPath.Format()} doesn't exist."));
            DDTContainsFiles(_crazyLongPath, (6, false, $"Directory {_crazyLongPath.Format()} doesn't exist."));

            DDTNotContainsFiles((DirectoryInfo) null, (7, false, "Parameter 'directory' is null."));

            DDTNotContainsFiles((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFiles(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFiles(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFiles(_invalidPath, (11, false, $"Directory {_invalidPath.Format()} doesn't exist."));
            DDTNotContainsFiles(_crazyLongPath, (12, false, $"Directory {_crazyLongPath.Format()} doesn't exist."));

        }

        internal static void DDTContainsFiles(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input, _file, _method),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTContainsFiles(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input, _file, _method),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTNotContainsFiles(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input, _file, _method),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTNotContainsFiles(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input, _file, _method),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        #endregion

        #region ContainsFilesPattern

        [TestMethod]
        void ContainsFilesPattern() {

            DDTContainsFilesPattern(((DirectoryInfo) null, null, (SearchOption) 1000), (1, false, "Parameter 'directory' is null."));
            DDTContainsFilesPattern(((DirectoryInfo) null, "", SearchOption.AllDirectories), (2, false, "Parameter 'directory' is null."));
            DDTContainsFilesPattern((new DirectoryInfo(@"C:\Windows"), null, SearchOption.AllDirectories), (3, false, "Parameter 'searchPattern' is null."));
            DDTContainsFilesPattern((new DirectoryInfo(@"C:\Windows"), "", (SearchOption) 1000), (4, false, "Parameter 'searchOption' is out of bounds."));

            DDTContainsFilesPattern(((String) null, null, (SearchOption) 1000), (5, false, "Parameter 'path' is null or white space."));
            DDTContainsFilesPattern(((String) null, "", SearchOption.AllDirectories), (6, false, "Parameter 'path' is null or white space."));
            DDTContainsFilesPattern((String.Empty, "", SearchOption.AllDirectories), (7, false, "Parameter 'path' is null or white space."));
            DDTContainsFilesPattern((" ", "", SearchOption.AllDirectories), (8, false, "Parameter 'path' is null or white space."));
            DDTContainsFilesPattern((@"C:\Windows", null, SearchOption.AllDirectories), (9, false, "Parameter 'searchPattern' is null."));
            DDTContainsFilesPattern((@"C:\Windows", "", (SearchOption) 1000), (10, false, "Parameter 'searchOption' is out of bounds."));
            DDTContainsFilesPattern((_invalidPath, null, SearchOption.AllDirectories), (11, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTContainsFilesPattern((_crazyLongPath, null, SearchOption.AllDirectories), (12, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

            DDTNotContainsFilesPattern(((DirectoryInfo) null, null, (SearchOption) 1000), (13, false, "Parameter 'directory' is null."));
            DDTNotContainsFilesPattern(((DirectoryInfo) null, "", SearchOption.AllDirectories), (14, false, "Parameter 'directory' is null."));
            DDTNotContainsFilesPattern((new DirectoryInfo(@"C:\Windows"), null, SearchOption.AllDirectories), (15, false, "Parameter 'searchPattern' is null."));
            DDTNotContainsFilesPattern((new DirectoryInfo(@"C:\Windows"), "", (SearchOption) 1000), (16, false, "Parameter 'searchOption' is out of bounds."));

            DDTNotContainsFilesPattern(((String) null, null, (SearchOption) 1000), (17, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFilesPattern(((String) null, "", SearchOption.AllDirectories), (18, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFilesPattern((String.Empty, "", SearchOption.AllDirectories), (19, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFilesPattern((" ", "", SearchOption.AllDirectories), (20, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFilesPattern((@"C:\Windows", null, SearchOption.AllDirectories), (21, false, "Parameter 'searchPattern' is null."));
            DDTNotContainsFilesPattern((@"C:\Windows", "", (SearchOption) 1000), (22, false, "Parameter 'searchOption' is out of bounds."));
            DDTNotContainsFilesPattern((_invalidPath, null, SearchOption.AllDirectories), (23, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotContainsFilesPattern((_crazyLongPath, null, SearchOption.AllDirectories), (24, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

        }

        internal static void DDTContainsFilesPattern((String path, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.path.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input.path, input.pattern, input.opt, _file, _method),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTContainsFilesPattern((DirectoryInfo dir, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.dir.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input.dir, input.pattern, input.opt, _file, _method),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTNotContainsFilesPattern((String path, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.path.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input.path, input.pattern, input.opt, _file, _method),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTNotContainsFilesPattern((DirectoryInfo dir, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.dir.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input.dir, input.pattern, input.opt, _file, _method),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        #endregion

        #region ContainsFilesPredicate

        [TestMethod]
        void ContainsFilesPredicate() {

            DDTContainsFilesPredicate(((DirectoryInfo) null, null, (SearchOption) 1000), (1, false, "Parameter 'directory' is null."));
            DDTContainsFilesPredicate(((DirectoryInfo) null, (_) => true, SearchOption.AllDirectories), (2, false, "Parameter 'directory' is null."));
            DDTContainsFilesPredicate((new DirectoryInfo(@"C:\Windows"), null, SearchOption.AllDirectories), (3, false, "Parameter 'match' is null."));
            DDTContainsFilesPredicate((new DirectoryInfo(@"C:\Windows"), (_) => true, (SearchOption) 1000), (4, false, "Parameter 'searchOption' is out of bounds."));
            DDTContainsFilesPredicate((new DirectoryInfo(@"C:\Windows"), (_) => throw new ArgumentException(), SearchOption.AllDirectories), (5, false, "Predicate threw Exception: "));

            DDTContainsFilesPredicate(((String) null, null, (SearchOption) 1000), (6, false, "Parameter 'path' is null or white space."));
            DDTContainsFilesPredicate(((String) null, (_) => true, SearchOption.AllDirectories), (7, false, "Parameter 'path' is null or white space."));
            DDTContainsFilesPredicate((String.Empty, (_) => true, SearchOption.AllDirectories), (8, false, "Parameter 'path' is null or white space."));
            DDTContainsFilesPredicate((" ", (_) => true, SearchOption.AllDirectories), (9, false, "Parameter 'path' is null or white space."));
            DDTContainsFilesPredicate((@"C:\Windows", null, SearchOption.AllDirectories), (10, false, "Parameter 'match' is null."));
            DDTContainsFilesPredicate((@"C:\Windows", (_) => true, (SearchOption) 1000), (11, false, "Parameter 'searchOption' is out of bounds."));
            DDTContainsFilesPredicate((@"C:\Windows", (_) => throw new ArgumentException(), SearchOption.AllDirectories), (12, false, "Predicate threw Exception: "));
            DDTContainsFilesPredicate((@_invalidPath, (_) => true, SearchOption.AllDirectories), (13, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTContainsFilesPredicate((_crazyLongPath, (_) => true, SearchOption.AllDirectories), (14, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

            DDTNotContainsFilesPredicate(((DirectoryInfo) null, null, (SearchOption) 1000), (15, false, "Parameter 'directory' is null."));
            DDTNotContainsFilesPredicate(((DirectoryInfo) null, (_) => true, SearchOption.AllDirectories), (16, false, "Parameter 'directory' is null."));
            DDTNotContainsFilesPredicate((new DirectoryInfo(@"C:\Windows"), null, SearchOption.AllDirectories), (17, false, "Parameter 'match' is null."));
            DDTNotContainsFilesPredicate((new DirectoryInfo(@"C:\Windows"), (_) => true, (SearchOption) 1000), (18, false, "Parameter 'searchOption' is out of bounds."));
            DDTNotContainsFilesPredicate((new DirectoryInfo(@"C:\Windows"), (_) => throw new ArgumentException(), SearchOption.AllDirectories), (19, false, "Predicate threw Exception: "));

            DDTNotContainsFilesPredicate(((String) null, null, (SearchOption) 1000), (20, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFilesPredicate(((String) null, (_) => true, SearchOption.AllDirectories), (21, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFilesPredicate((String.Empty, (_) => true, SearchOption.AllDirectories), (22, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFilesPredicate((" ", (_) => true, SearchOption.AllDirectories), (23, false, "Parameter 'path' is null or white space."));
            DDTNotContainsFilesPredicate((@"C:\Windows", null, SearchOption.AllDirectories), (24, false, "Parameter 'match' is null."));
            DDTNotContainsFilesPredicate((@"C:\Windows", (_) => true, (SearchOption) 1000), (25, false, "Parameter 'searchOption' is out of bounds."));
            DDTNotContainsFilesPredicate((@"C:\Windows", (_) => throw new ArgumentException(), SearchOption.AllDirectories), (26, false, "Predicate threw Exception: "));
            DDTNotContainsFilesPredicate((@_invalidPath, (_) => true, SearchOption.AllDirectories), (27, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotContainsFilesPredicate((_crazyLongPath, (_) => true, SearchOption.AllDirectories), (28, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

        }

        internal static void DDTContainsFilesPredicate((String path, Predicate<FileInfo> match, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.path.Format()}, {input.match.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input.path, input.match, input.opt, _file, _method),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTContainsFilesPredicate((DirectoryInfo dir, Predicate<FileInfo> match, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsFiles({input.dir.Format()}, {input.match.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsFiles(input.dir, input.match, input.opt, _file, _method),
                expected, "Test.If.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTNotContainsFilesPredicate((String path, Predicate<FileInfo> match, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.path.Format()}, {input.match.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input.path, input.match, input.opt, _file, _method),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        internal static void DDTNotContainsFilesPredicate((DirectoryInfo dir, Predicate<FileInfo> match, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsFiles({input.dir.Format()}, {input.match.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsFiles(input.dir, input.match, input.opt, _file, _method),
                expected, "Test.IfNot.Directory.ContainsFiles", _file, _method);

        }

        #endregion

        #region ContainsDirectories

        [TestMethod]
        void ContainsDirectories() {

            DDTContainsDirectories((DirectoryInfo) null, (1, false, "Parameter 'directory' is null."));

            DDTContainsDirectories((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectories(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectories(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectories(_invalidPath, (5, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTContainsDirectories(_crazyLongPath, (6, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

            DDTNotContainsDirectories((DirectoryInfo) null, (7, false, "Parameter 'directory' is null."));

            DDTNotContainsDirectories((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectories(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectories(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectories(_invalidPath, (11, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotContainsDirectories(_crazyLongPath, (12, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

        }

        internal static void DDTContainsDirectories(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input, _file, _method),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTContainsDirectories(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input, _file, _method),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTNotContainsDirectories(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input, _file, _method),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTNotContainsDirectories(DirectoryInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input, _file, _method),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        #endregion

        #region ContainsDirectoriesPattern

        [TestMethod]
        void ContainsDirectoriesPattern() {

            DDTContainsDirectoriesPattern(((DirectoryInfo) null, null, (SearchOption) 1000), (1, false, "Parameter 'directory' is null."));
            DDTContainsDirectoriesPattern(((DirectoryInfo) null, "", SearchOption.AllDirectories), (2, false, "Parameter 'directory' is null."));
            DDTContainsDirectoriesPattern((new DirectoryInfo(@"C:\Windows"), null, SearchOption.AllDirectories), (3, false, "Parameter 'searchPattern' is null."));
            DDTContainsDirectoriesPattern((new DirectoryInfo(@"C:\Windows"), "", (SearchOption) 1000), (4, false, "Parameter 'searchOption' is out of bounds."));

            DDTContainsDirectoriesPattern(((String) null, null, (SearchOption) 1000), (5, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectoriesPattern(((String) null, "", SearchOption.AllDirectories), (6, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectoriesPattern((String.Empty, "", SearchOption.AllDirectories), (7, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectoriesPattern((" ", "", SearchOption.AllDirectories), (8, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectoriesPattern((@"C:\Windows", null, SearchOption.AllDirectories), (9, false, "Parameter 'searchPattern' is null."));
            DDTContainsDirectoriesPattern((@"C:\Windows", "", (SearchOption) 1000), (10, false, "Parameter 'searchOption' is out of bounds."));
            DDTContainsDirectoriesPattern((_invalidPath, null, SearchOption.AllDirectories), (11, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTContainsDirectoriesPattern((_crazyLongPath, null, SearchOption.AllDirectories), (12, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

            DDTNotContainsDirectoriesPattern(((DirectoryInfo) null, null, (SearchOption) 1000), (13, false, "Parameter 'directory' is null."));
            DDTNotContainsDirectoriesPattern(((DirectoryInfo) null, "", SearchOption.AllDirectories), (14, false, "Parameter 'directory' is null."));
            DDTNotContainsDirectoriesPattern((new DirectoryInfo(@"C:\Windows"), null, SearchOption.AllDirectories), (15, false, "Parameter 'searchPattern' is null."));
            DDTNotContainsDirectoriesPattern((new DirectoryInfo(@"C:\Windows"), "", (SearchOption) 1000), (16, false, "Parameter 'searchOption' is out of bounds."));

            DDTNotContainsDirectoriesPattern(((String) null, null, (SearchOption) 1000), (17, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectoriesPattern(((String) null, "", SearchOption.AllDirectories), (18, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectoriesPattern((String.Empty, "", SearchOption.AllDirectories), (19, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectoriesPattern((" ", "", SearchOption.AllDirectories), (20, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectoriesPattern((@"C:\Windows", null, SearchOption.AllDirectories), (21, false, "Parameter 'searchPattern' is null."));
            DDTNotContainsDirectoriesPattern((@"C:\Windows", "", (SearchOption) 1000), (22, false, "Parameter 'searchOption' is out of bounds."));
            DDTNotContainsDirectoriesPattern((_invalidPath, null, SearchOption.AllDirectories), (23, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotContainsDirectoriesPattern((_crazyLongPath, null, SearchOption.AllDirectories), (24, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

        }

        internal static void DDTContainsDirectoriesPattern((String path, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.path.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input.path, input.pattern, input.opt, _file, _method),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTContainsDirectoriesPattern((DirectoryInfo dir, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.dir.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input.dir, input.pattern, input.opt, _file, _method),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTNotContainsDirectoriesPattern((String path, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.path.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input.path, input.pattern, input.opt, _file, _method),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTNotContainsDirectoriesPattern((DirectoryInfo dir, String pattern, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.dir.Format()}, {input.pattern.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input.dir, input.pattern, input.opt, _file, _method),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        #endregion

        #region ContainsDirectoriesPredicate

        [TestMethod]
        void ContainsDirectoriesPredicate() {

            DDTContainsDirectoriesPredicate(((DirectoryInfo) null, null, (SearchOption) 1000), (1, false, "Parameter 'directory' is null."));
            DDTContainsDirectoriesPredicate(((DirectoryInfo) null, (_) => true, SearchOption.AllDirectories), (2, false, "Parameter 'directory' is null."));
            DDTContainsDirectoriesPredicate((new DirectoryInfo(@"C:\Windows"), null, SearchOption.AllDirectories), (3, false, "Parameter 'match' is null."));
            DDTContainsDirectoriesPredicate((new DirectoryInfo(@"C:\Windows"), (_) => true, (SearchOption) 1000), (4, false, "Parameter 'searchOption' is out of bounds."));
            DDTContainsDirectoriesPredicate((new DirectoryInfo(@"C:\Windows"), (_) => throw new ArgumentException(), SearchOption.AllDirectories), (5, false, "Predicate threw Exception: "));

            DDTContainsDirectoriesPredicate(((String) null, null, (SearchOption) 1000), (6, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectoriesPredicate(((String) null, (_) => true, SearchOption.AllDirectories), (7, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectoriesPredicate((String.Empty, (_) => true, SearchOption.AllDirectories), (8, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectoriesPredicate((" ", (_) => true, SearchOption.AllDirectories), (9, false, "Parameter 'path' is null or white space."));
            DDTContainsDirectoriesPredicate((@"C:\Windows", null, SearchOption.AllDirectories), (10, false, "Parameter 'match' is null."));
            DDTContainsDirectoriesPredicate((@"C:\Windows", (_) => true, (SearchOption) 1000), (11, false, "Parameter 'searchOption' is out of bounds."));
            DDTContainsDirectoriesPredicate((@"C:\Windows", (_) => throw new ArgumentException(), SearchOption.AllDirectories), (12, false, "Predicate threw Exception: "));
            DDTContainsDirectoriesPredicate((@_invalidPath, (_) => true, SearchOption.AllDirectories), (13, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTContainsDirectoriesPredicate((_crazyLongPath, (_) => true, SearchOption.AllDirectories), (14, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

            DDTNotContainsDirectoriesPredicate(((DirectoryInfo) null, null, (SearchOption) 1000), (15, false, "Parameter 'directory' is null."));
            DDTNotContainsDirectoriesPredicate(((DirectoryInfo) null, (_) => true, SearchOption.AllDirectories), (16, false, "Parameter 'directory' is null."));
            DDTNotContainsDirectoriesPredicate((new DirectoryInfo(@"C:\Windows"), null, SearchOption.AllDirectories), (17, false, "Parameter 'match' is null."));
            DDTNotContainsDirectoriesPredicate((new DirectoryInfo(@"C:\Windows"), (_) => true, (SearchOption) 1000), (18, false, "Parameter 'searchOption' is out of bounds."));
            DDTNotContainsDirectoriesPredicate((new DirectoryInfo(@"C:\Windows"), (_) => throw new ArgumentException(), SearchOption.AllDirectories), (19, false, "Predicate threw Exception: "));

            DDTNotContainsDirectoriesPredicate(((String) null, null, (SearchOption) 1000), (20, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectoriesPredicate(((String) null, (_) => true, SearchOption.AllDirectories), (21, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectoriesPredicate((String.Empty, (_) => true, SearchOption.AllDirectories), (22, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectoriesPredicate((" ", (_) => true, SearchOption.AllDirectories), (23, false, "Parameter 'path' is null or white space."));
            DDTNotContainsDirectoriesPredicate((@"C:\Windows", null, SearchOption.AllDirectories), (24, false, "Parameter 'match' is null."));
            DDTNotContainsDirectoriesPredicate((@"C:\Windows", (_) => true, (SearchOption) 1000), (25, false, "Parameter 'searchOption' is out of bounds."));
            DDTNotContainsDirectoriesPredicate((@"C:\Windows", (_) => throw new ArgumentException(), SearchOption.AllDirectories), (26, false, "Predicate threw Exception: "));
            DDTNotContainsDirectoriesPredicate((@_invalidPath, (_) => true, SearchOption.AllDirectories), (27, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotContainsDirectoriesPredicate((_crazyLongPath, (_) => true, SearchOption.AllDirectories), (28, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));

        }

        internal static void DDTContainsDirectoriesPredicate((String path, Predicate<DirectoryInfo> match, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.path.Format()}, {input.match.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input.path, input.match, input.opt, _file, _method),
                expected, "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTContainsDirectoriesPredicate((DirectoryInfo dir, Predicate<DirectoryInfo> match, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Directory.ContainsDirectories({input.dir.Format()}, {input.match.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Directory.ContainsDirectories(input.dir, input.match, input.opt, _file, _method), expected,
                "Test.If.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTNotContainsDirectoriesPredicate((String path, Predicate<DirectoryInfo> match, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.path.Format()}, {input.match.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input.path, input.match, input.opt, _file, _method),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        internal static void DDTNotContainsDirectoriesPredicate((DirectoryInfo dir, Predicate<DirectoryInfo> match, SearchOption opt) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Directory.ContainsDirectories({input.dir.Format()}, {input.match.Format()}, {input.opt.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Directory.ContainsDirectories(input.dir, input.match, input.opt, _file, _method),
                expected, "Test.IfNot.Directory.ContainsDirectories", _file, _method);

        }

        #endregion

    }
}
