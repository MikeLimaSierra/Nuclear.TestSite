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
            DDTExists(_invalidPath, (5, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTExists(_crazyLongPath, (6, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));
            DDTExists(_pathWithColon, (7, false, $"{_pathWithColon.Format()} contains a colon (:) in the middle of the string."));

            DDTNotExists((FileInfo) null, (8, false, "Parameter 'file' is null."));

            DDTNotExists((String) null, (9, false, "Parameter 'path' is null or white space."));
            DDTNotExists(String.Empty, (10, false, "Parameter 'path' is null or white space."));
            DDTNotExists(" ", (11, false, "Parameter 'path' is null or white space."));
            DDTNotExists(_invalidPath, (12, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotExists(_crazyLongPath, (13, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));
            DDTNotExists(_pathWithColon, (14, false, $"{_pathWithColon.Format()} contains a colon (:) in the middle of the string."));

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

    }
}
