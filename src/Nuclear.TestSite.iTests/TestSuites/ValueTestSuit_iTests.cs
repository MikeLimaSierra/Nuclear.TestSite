using System;
using System.IO;
using System.Runtime.CompilerServices;
using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    class ValueTestSuit_iTests {

        #region IsEqualDirectory

        [TestMethod]
        void IsEqualDirectory() {

            DDTIsEqualDirectory((null, null), (1, false, "Parameter 'left' is null."));
            DDTIsEqualDirectory((null, new DirectoryInfo(@"C:\Temp")), (2, false, "Parameter 'left' is null."));
            DDTIsEqualDirectory((new DirectoryInfo(@"C:\Temp"), null), (3, false, "Parameter 'right' is null."));

            DDTIsEqualDirectory((new DirectoryInfo(@"C:\Temp1"), new DirectoryInfo(@"C:\Temp2")), (4, false, @"[Left = 'C:\Temp1'; Right = 'C:\Temp2']"));
            DDTIsEqualDirectory((new DirectoryInfo(@"C:\Temp"), new DirectoryInfo(@"C:\Temp")), (5, true, @"[Left = 'C:\Temp'; Right = 'C:\Temp']"));

            DDTNotIsEqualDirectory((null, null), (6, false, "Parameter 'left' is null."));
            DDTNotIsEqualDirectory((null, new DirectoryInfo(@"C:\Temp")), (7, false, "Parameter 'left' is null."));
            DDTNotIsEqualDirectory((new DirectoryInfo(@"C:\Temp"), null), (8, false, "Parameter 'right' is null."));

            DDTNotIsEqualDirectory((new DirectoryInfo(@"C:\Temp1"), new DirectoryInfo(@"C:\Temp2")), (9, true, @"[Left = 'C:\Temp1'; Right = 'C:\Temp2']"));
            DDTNotIsEqualDirectory((new DirectoryInfo(@"C:\Temp"), new DirectoryInfo(@"C:\Temp")), (10, false, @"[Left = 'C:\Temp'; Right = 'C:\Temp']"));

        }

        void DDTIsEqualDirectory((DirectoryInfo left, DirectoryInfo right) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsEqual({input.left.Format()}, {input.right.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input.left, input.right, _file, _method),
                expected, "Test.If.Value.IsEqual", _file, _method);

        }

        void DDTNotIsEqualDirectory((DirectoryInfo left, DirectoryInfo right) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsEqual({input.left.Format()}, {input.right.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input.left, input.right, _file, _method),
                expected, "Test.IfNot.Value.IsEqual", _file, _method);

        }

        #endregion

        #region IsEqualFile

        [TestMethod]
        void IsEqualFile() {

            DDTIsEqualFile((null, null), (1, false, "Parameter 'left' is null."));
            DDTIsEqualFile((null, new FileInfo(@"C:\Temp")), (2, false, "Parameter 'left' is null."));
            DDTIsEqualFile((new FileInfo(@"C:\Temp"), null), (3, false, "Parameter 'right' is null."));

            DDTIsEqualFile((new FileInfo(@"C:\Temp1"), new FileInfo(@"C:\Temp2")), (4, false, @"[Left = 'C:\Temp1'; Right = 'C:\Temp2']"));
            DDTIsEqualFile((new FileInfo(@"C:\Temp"), new FileInfo(@"C:\Temp")), (5, true, @"[Left = 'C:\Temp'; Right = 'C:\Temp']"));

            DDTNotIsEqualFile((null, null), (6, false, "Parameter 'left' is null."));
            DDTNotIsEqualFile((null, new FileInfo(@"C:\Temp")), (7, false, "Parameter 'left' is null."));
            DDTNotIsEqualFile((new FileInfo(@"C:\Temp"), null), (8, false, "Parameter 'right' is null."));

            DDTNotIsEqualFile((new FileInfo(@"C:\Temp1"), new FileInfo(@"C:\Temp2")), (9, true, @"[Left = 'C:\Temp1'; Right = 'C:\Temp2']"));
            DDTNotIsEqualFile((new FileInfo(@"C:\Temp"), new FileInfo(@"C:\Temp")), (10, false, @"[Left = 'C:\Temp'; Right = 'C:\Temp']"));

        }

        void DDTIsEqualFile((FileInfo left, FileInfo right) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.If.Value.IsEqual({input.left.Format()}, {input.right.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input.left, input.right, _file, _method),
                expected, "Test.If.Value.IsEqual", _file, _method);

        }

        void DDTNotIsEqualFile((FileInfo left, FileInfo right) input, (Int32 count, Boolean result, String message) expected,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            Test.Note($"Test.IfNot.Value.IsEqual({input.left.Format()}, {input.right.Format()})",
                _file, _method);

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input.left, input.right, _file, _method),
                expected, "Test.IfNot.Value.IsEqual", _file, _method);

        }

        #endregion

    }
}
