using System;
using System.Collections.Generic;
using System.IO;

namespace Nuclear.TestSite.TestSuites {
    class ValueTestSuit_iTests {

        #region IsEqualDirectory

        [TestMethod]
        [TestData(nameof(IsEqualDirectoryData))]
        void IsEqualDirectory(DirectoryInfo input1, DirectoryInfo input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualDirectoryData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'left' is null.") },
                new Object[] { null, new DirectoryInfo(@"C:\Temp"), (2, false, "Parameter 'left' is null.") },
                new Object[] { new DirectoryInfo(@"C:\Temp"), null, (3, false, "Parameter 'right' is null.") },
                new Object[] { new DirectoryInfo(@"C:\Temp1"), new DirectoryInfo(@"C:\Temp2"), (4, false, @"[Left = 'C:\Temp1'; Right = 'C:\Temp2']") },
                new Object[] { new DirectoryInfo(@"C:\Temp"), new DirectoryInfo(@"C:\Temp"), (5, true, @"[Left = 'C:\Temp'; Right = 'C:\Temp']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualDirectoryData))]
        void NotIsEqualDirectory(DirectoryInfo input1, DirectoryInfo input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualDirectoryData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'left' is null.") },
                new Object[] { null, new DirectoryInfo(@"C:\Temp"), (2, false, "Parameter 'left' is null.") },
                new Object[] { new DirectoryInfo(@"C:\Temp"), null, (3, false, "Parameter 'right' is null.") },
                new Object[] { new DirectoryInfo(@"C:\Temp1"), new DirectoryInfo(@"C:\Temp2"), (4, true, @"[Left = 'C:\Temp1'; Right = 'C:\Temp2']") },
                new Object[] { new DirectoryInfo(@"C:\Temp"), new DirectoryInfo(@"C:\Temp"), (5, false, @"[Left = 'C:\Temp'; Right = 'C:\Temp']") },
            };
        }

        #endregion

        #region IsEqualFile

        [TestMethod]
        [TestData(nameof(IsEqualFileData))]
        void IsEqualFile(FileInfo input1, FileInfo input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.If.Value.IsEqual(input1, input2),
                expected, "Test.If.Value.IsEqual");

        }

        IEnumerable<Object[]> IsEqualFileData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'left' is null.") },
                new Object[] { null, new FileInfo(@"C:\Temp"), (2, false, "Parameter 'left' is null.") },
                new Object[] { new FileInfo(@"C:\Temp"), null, (3, false, "Parameter 'right' is null.") },
                new Object[] { new FileInfo(@"C:\Temp1"), new FileInfo(@"C:\Temp2"), (4, false, @"[Left = 'C:\Temp1'; Right = 'C:\Temp2']") },
                new Object[] { new FileInfo(@"C:\Temp"), new FileInfo(@"C:\Temp"), (5, true, @"[Left = 'C:\Temp'; Right = 'C:\Temp']") },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsEqualFileData))]
        void NotIsEqualFile(FileInfo input1, FileInfo input2, (Int32 count, Boolean result, String message) expected) {

            Statics.DDTResultState(() => DummyTest.IfNot.Value.IsEqual(input1, input2),
                expected, "Test.IfNot.Value.IsEqual");

        }

        IEnumerable<Object[]> NotIsEqualFileData() {
            return new List<Object[]>() {
                new Object[] { null, null, (1, false, "Parameter 'left' is null.") },
                new Object[] { null, new FileInfo(@"C:\Temp"), (2, false, "Parameter 'left' is null.") },
                new Object[] { new FileInfo(@"C:\Temp"), null, (3, false, "Parameter 'right' is null.") },
                new Object[] { new FileInfo(@"C:\Temp1"), new FileInfo(@"C:\Temp2"), (4, true, @"[Left = 'C:\Temp1'; Right = 'C:\Temp2']") },
                new Object[] { new FileInfo(@"C:\Temp"), new FileInfo(@"C:\Temp"), (5, false, @"[Left = 'C:\Temp'; Right = 'C:\Temp']") },
            };
        }

        #endregion

    }
}
