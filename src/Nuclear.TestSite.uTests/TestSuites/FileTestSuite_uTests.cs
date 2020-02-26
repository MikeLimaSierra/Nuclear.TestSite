﻿using System;
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
            DDTHasAttribute((_invalidPath, FileAttributes.Normal), (9, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTHasAttribute((_crazyLongPath, FileAttributes.Normal), (10, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));
            DDTHasAttribute((_pathWithColon, FileAttributes.Normal), (11, false, $"{_pathWithColon.Format()} contains a colon (:) in the middle of the string."));

            DDTNotHasAttribute(((FileInfo) null, (FileAttributes) 1000000), (12, false, "Parameter 'file' is null."));
            DDTNotHasAttribute(((FileInfo) null, FileAttributes.Normal), (13, false, "Parameter 'file' is null."));
            DDTNotHasAttribute((new FileInfo(@"C:\Windows\explorer.exe"), (FileAttributes) 1000000), (14, false, "Parameter 'attribute' is out of bounds."));

            DDTNotHasAttribute(((String) null, (FileAttributes) 1000000), (15, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute(((String) null, FileAttributes.Normal), (16, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((@"C:\Windows\explorer.exe", (FileAttributes) 1000000), (17, false, "Parameter 'attribute' is out of bounds."));
            DDTNotHasAttribute((String.Empty, FileAttributes.Normal), (18, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((" ", FileAttributes.Normal), (19, false, "Parameter 'path' is null or white space."));
            DDTNotHasAttribute((_invalidPath, FileAttributes.Normal), (20, false, $"The path {_invalidPath.Format()} contains invalid characters such as \", <, >, or |."));
            DDTNotHasAttribute((_crazyLongPath, FileAttributes.Normal), (21, false, $"The path {_crazyLongPath.Format()} exceeds the system-defined maximum length."));
            DDTNotHasAttribute((_pathWithColon, FileAttributes.Normal), (22, false, $"{_pathWithColon.Format()} contains a colon (:) in the middle of the string."));

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
