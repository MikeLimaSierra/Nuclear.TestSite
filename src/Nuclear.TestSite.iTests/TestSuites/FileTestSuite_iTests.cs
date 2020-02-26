using System;
using System.IO;
using System.Runtime.CompilerServices;
using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {

    class FileTestSuite_iTests {

        #region statics

        static (String path, FileInfo file) GetLocation() {
            String path = Path.Combine(@"C:\Temp", Guid.NewGuid().ToString());

            return (path, new FileInfo(path));
        }

        static void Create(DirectoryInfo dir, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {
            Test.Note($"Create directory {dir.FullName.Format()}", _file, _method);
            if(!dir.Exists) { dir.Create(); }
        }

        static void Delete(DirectoryInfo dir, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {
            Test.Note($"Delete directory {dir.FullName.Format()}", _file, _method);
            if(dir.Exists) { dir.Delete(true); }
        }

        static void Create(FileInfo file, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {
            Test.Note($"Create file {file.FullName.Format()}", _file, _method);
            if(!file.Exists) { file.Create().Close(); }
        }

        static void Delete(FileInfo file, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {
            Test.Note($"Delete file {file.FullName.Format()}", _file, _method);
            if(file.Exists) { file.Delete(); }
        }

        #endregion

        #region Exists

        [TestMethod]
        void Exists() {

            (String path, FileInfo file) test = GetLocation();

            FileTestSuite_uTests.DDTExists(test.path, (1, false, $"File {test.path.Format()} does not exist."));
            FileTestSuite_uTests.DDTExists(test.file, (2, false, $"File {test.path.Format()} does not exist."));

            FileTestSuite_uTests.DDTNotExists(test.path, (3, true, $"File {test.path.Format()} does not exist."));
            FileTestSuite_uTests.DDTNotExists(test.file, (4, true, $"File {test.path.Format()} does not exist."));

            Create(test.file);

            FileTestSuite_uTests.DDTExists(test.path, (5, true, $"File {test.path.Format()} exists."));
            FileTestSuite_uTests.DDTExists(test.file, (6, true, $"File {test.path.Format()} exists."));

            FileTestSuite_uTests.DDTNotExists(test.path, (7, false, $"File {test.path.Format()} exists."));
            FileTestSuite_uTests.DDTNotExists(test.file, (8, false, $"File {test.path.Format()} exists."));

            Delete(test.file);

        }

        #endregion

    }
}
