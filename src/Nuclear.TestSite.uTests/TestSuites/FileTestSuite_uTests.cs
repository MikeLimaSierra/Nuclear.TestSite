using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    class FileTestSuite_uTests {

        readonly String _crazyLongPath = @"C:\Temp\" + String.Join(@"\", Enumerable.Repeat("abc", Int16.MaxValue / 4));
        readonly String _invalidPath = @"C:\Win|32<Bla>";
        readonly String _pathWithColon = @"C:\Temp:asdf";

        #region Exists

        [TestMethod]
        void Exists() {

            DDTExists((FileInfo) null, (1, false, "Parameter 'file' is null."));

            DDTExists((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTExists(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTExists(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTExists(_invalidPath, (5, false, $"File {_invalidPath.Format()} doesn't exist."));
            DDTExists(_crazyLongPath, (6, false, $"File {_crazyLongPath.Format()} doesn't exist."));

            DDTNotExists((FileInfo) null, (7, false, "Parameter 'file' is null."));

            DDTNotExists((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotExists(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotExists(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotExists(_invalidPath, (11, true, $"File {_invalidPath.Format()} doesn't exist."));
            DDTNotExists(_crazyLongPath, (12, true, $"File {_crazyLongPath.Format()} doesn't exist."));

        }

        internal static void DDTExists(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.File.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.File.Exists(input, _file, _method),
                expected, "Test.If.File.Exists", _file, _method);

        }

        internal static void DDTExists(FileInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.File.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.File.Exists(input, _file, _method),
                expected, "Test.If.File.Exists", _file, _method);

        }

        internal static void DDTNotExists(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.File.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.File.Exists(input, _file, _method),
                expected, "Test.IfNot.File.Exists", _file, _method);

        }

        internal static void DDTNotExists(FileInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.File.Exists({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.File.Exists(input, _file, _method),
                expected, "Test.IfNot.File.Exists", _file, _method);

        }

        #endregion

        #region IsEmpty

        [TestMethod]
        void IsEmpty() {

            DDTIsEmpty((FileInfo) null, (1, false, "Parameter 'file' is null."));

            DDTIsEmpty((String) null, (2, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty(String.Empty, (3, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty(" ", (4, false, "Parameter 'path' is null or white space."));
            DDTIsEmpty(_invalidPath, (5, false, $"File {_invalidPath.Format()} doesn't exist."));
            DDTIsEmpty(_crazyLongPath, (6, false, $"File {_crazyLongPath.Format()} doesn't exist."));

            DDTNotIsEmpty((FileInfo) null, (7, false, "Parameter 'file' is null."));

            DDTNotIsEmpty((String) null, (8, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty(String.Empty, (9, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty(" ", (10, false, "Parameter 'path' is null or white space."));
            DDTNotIsEmpty(_invalidPath, (11, false, $"File {_invalidPath.Format()} doesn't exist."));
            DDTNotIsEmpty(_crazyLongPath, (12, false, $"File {_crazyLongPath.Format()} doesn't exist."));

        }

        internal static void DDTIsEmpty(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.File.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.File.IsEmpty(input, _file, _method),
                expected, "Test.If.File.IsEmpty", _file, _method);

        }

        internal static void DDTIsEmpty(FileInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.File.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.File.IsEmpty(input, _file, _method),
                expected, "Test.If.File.IsEmpty", _file, _method);

        }

        internal static void DDTNotIsEmpty(String input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.File.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.File.IsEmpty(input, _file, _method),
                expected, "Test.IfNot.File.IsEmpty", _file, _method);

        }

        internal static void DDTNotIsEmpty(FileInfo input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.File.IsEmpty({input.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.File.IsEmpty(input, _file, _method),
                expected, "Test.IfNot.File.IsEmpty", _file, _method);

        }

        #endregion

        #region HasAttribute

        [TestMethod]
        void HasAttribute() {

            DDTHasAttribute(((FileInfo) null, (FileAttributes) 1000000), (1, false, "Parameter 'file' is null."));
            DDTHasAttribute(((FileInfo) null, FileAttributes.Normal), (2, false, "Parameter 'file' is null."));
            DDTHasAttribute((new FileInfo(@"C:\Windows\explorer.exe"), (FileAttributes) 1000000), (3, false, "Parameter 'attribute' is out of bounds."));

            DDTHasAttribute(((String) null, (FileAttributes) 1000000), (4, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute(((String) null, FileAttributes.Normal), (5, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((@"C:\Windows\explorer.exe", (FileAttributes) 1000000), (6, false, "Parameter 'attribute' is out of bounds."));
            DDTHasAttribute((String.Empty, FileAttributes.Normal), (7, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((" ", FileAttributes.Normal), (8, false, "Parameter 'path' is null or white space."));
            DDTHasAttribute((_invalidPath, FileAttributes.Normal), (9, false, $"File {_invalidPath.Format()} doesn't exist."));
            DDTHasAttribute((_crazyLongPath, FileAttributes.Normal), (10, false, $"File {_crazyLongPath.Format()} doesn't exist."));
            DDTHasAttribute((_pathWithColon, FileAttributes.Normal), (11, false, $"File {_pathWithColon.Format()} doesn't exist."));

            DDTNotHasAttribute(((FileInfo) null, (FileAttributes) 1000000), (12, false, "Parameter 'file' is null."));
            DDTNotHasAttribute(((FileInfo) null, FileAttributes.Normal), (13, false, "Parameter 'file' is null."));
            DDTNotHasAttribute((new FileInfo(@"C:\Windows\explorer.exe"), (FileAttributes) 1000000), (14, false, "Parameter 'attribute' is out of bounds."));

            DDTNotHasAttribute(((String) null, (FileAttributes) 1000000), (15, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute(((String) null, FileAttributes.Normal), (16, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((@"C:\Windows\explorer.exe", (FileAttributes) 1000000), (17, false, "Parameter 'attribute' is out of bounds."));
            DDTNotHasAttribute((String.Empty, FileAttributes.Normal), (18, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((" ", FileAttributes.Normal), (19, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((_invalidPath, FileAttributes.Normal), (20, false, $"File {_invalidPath.Format()} doesn't exist."));
            DDTNotHasAttribute((_crazyLongPath, FileAttributes.Normal), (21, false, $"File {_crazyLongPath.Format()} doesn't exist."));
            DDTNotHasAttribute((_pathWithColon, FileAttributes.Normal), (22, false, $"File {_pathWithColon.Format()} doesn't exist."));

        }

        internal static void DDTHasAttribute((String path, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.File.HasAttribute({input.path.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.File.HasAttribute(input.path, input.attr, _file, _method),
                expected, "Test.If.File.HasAttribute", _file, _method);

        }

        internal static void DDTHasAttribute((FileInfo dir, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.File.HasAttribute({input.dir.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.If.File.HasAttribute(input.dir, input.attr, _file, _method),
                expected, "Test.If.File.HasAttribute", _file, _method);

        }

        internal static void DDTNotHasAttribute((String path, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.File.HasAttribute({input.path.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.File.HasAttribute(input.path, input.attr, _file, _method),
                expected, "Test.IfNot.File.HasAttribute", _file, _method);

        }

        internal static void DDTNotHasAttribute((FileInfo dir, FileAttributes attr) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.File.HasAttribute({input.dir.Format()}, {input.attr.Format()})", _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.File.HasAttribute(input.dir, input.attr, _file, _method),
                expected, "Test.IfNot.File.HasAttribute", _file, _method);

        }

        #endregion

    }
}
