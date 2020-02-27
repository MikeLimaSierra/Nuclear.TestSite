using System;
using System.IO;
using System.Runtime.CompilerServices;
using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {

    class DirectoryTestSuite_iTests {

        #region statics

        static (String path, DirectoryInfo dir) GetLocation() {
            String path = Path.Combine(@"C:\Temp", Guid.NewGuid().ToString());

            return (path, new DirectoryInfo(path));
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

            (String path, DirectoryInfo dir) test = GetLocation();

            DirectoryTestSuite_uTests.DDTExists(test.path, (1, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTExists(test.dir, (2, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotExists(test.path, (3, true, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotExists(test.dir, (4, true, $"Directory {test.path.Format()} doesn't exist."));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTExists(test.path, (5, true, $"Directory {test.path.Format()} exists."));
            DirectoryTestSuite_uTests.DDTExists(test.dir, (6, true, $"Directory {test.path.Format()} exists."));

            DirectoryTestSuite_uTests.DDTNotExists(test.path, (7, false, $"Directory {test.path.Format()} exists."));
            DirectoryTestSuite_uTests.DDTNotExists(test.dir, (8, false, $"Directory {test.path.Format()} exists."));

            Delete(test.dir);

        }

        #endregion

        #region IsEmpty

        [TestMethod]
        void IsEmpty() {

            (String path, DirectoryInfo dir) test = GetLocation();
            DirectoryInfo testContent = new DirectoryInfo(Path.Combine(test.path, "IsEmpty"));

            DirectoryTestSuite_uTests.DDTIsEmpty(test.path, (1, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTIsEmpty(test.dir, (2, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotIsEmpty(test.path, (3, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotIsEmpty(test.dir, (4, false, $"Directory {test.path.Format()} doesn't exist."));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTIsEmpty(test.path, (5, true, $"Directory {test.path.Format()} is empty."));
            DirectoryTestSuite_uTests.DDTIsEmpty(test.dir, (6, true, $"Directory {test.path.Format()} is empty."));

            DirectoryTestSuite_uTests.DDTNotIsEmpty(test.path, (7, false, $"Directory {test.path.Format()} is empty."));
            DirectoryTestSuite_uTests.DDTNotIsEmpty(test.dir, (8, false, $"Directory {test.path.Format()} is empty."));

            Create(testContent);

            DirectoryTestSuite_uTests.DDTIsEmpty(test.path, (9, false, $"Directory {test.path.Format()} is not empty."));
            DirectoryTestSuite_uTests.DDTIsEmpty(test.dir, (10, false, $"Directory {test.path.Format()} is not empty."));

            DirectoryTestSuite_uTests.DDTNotIsEmpty(test.path, (11, true, $"Directory {test.path.Format()} is not empty."));
            DirectoryTestSuite_uTests.DDTNotIsEmpty(test.dir, (12, true, $"Directory {test.path.Format()} is not empty."));

            Delete(test.dir);

        }

        #endregion

        #region HasAttribute

        [TestMethod]
        void HasAttribute() {

            (String path, DirectoryInfo dir) test = GetLocation();

            DirectoryTestSuite_uTests.DDTHasAttribute((test.path, FileAttributes.Hidden), (1, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTHasAttribute((test.dir, FileAttributes.Hidden), (2, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotHasAttribute((test.path, FileAttributes.Hidden), (3, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotHasAttribute((test.dir, FileAttributes.Hidden), (4, false, $"Directory {test.path.Format()} doesn't exist."));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTHasAttribute((test.path, FileAttributes.Hidden),
                (5, false, $"Directory {test.path.Format()} is not flagged with {FileAttributes.Hidden.Format()}."));
            DirectoryTestSuite_uTests.DDTHasAttribute((test.dir, FileAttributes.Hidden),
                (6, false, $"Directory {test.path.Format()} is not flagged with {FileAttributes.Hidden.Format()}."));

            DirectoryTestSuite_uTests.DDTNotHasAttribute((test.path, FileAttributes.Hidden),
                (7, true, $"Directory {test.path.Format()} is not flagged with {FileAttributes.Hidden.Format()}."));
            DirectoryTestSuite_uTests.DDTNotHasAttribute((test.dir, FileAttributes.Hidden),
                (8, true, $"Directory {test.path.Format()} is not flagged with {FileAttributes.Hidden.Format()}."));

            test.dir.Attributes = FileAttributes.Hidden;

            DirectoryTestSuite_uTests.DDTHasAttribute((test.path, FileAttributes.Hidden),
                (9, true, $"Directory {test.path.Format()} is flagged with {FileAttributes.Hidden.Format()}."));
            DirectoryTestSuite_uTests.DDTHasAttribute((test.dir, FileAttributes.Hidden),
                (10, true, $"Directory {test.path.Format()} is flagged with {FileAttributes.Hidden.Format()}."));

            DirectoryTestSuite_uTests.DDTNotHasAttribute((test.path, FileAttributes.Hidden),
                (11, false, $"Directory {test.path.Format()} is flagged with {FileAttributes.Hidden.Format()}."));
            DirectoryTestSuite_uTests.DDTNotHasAttribute((test.dir, FileAttributes.Hidden),
                (12, false, $"Directory {test.path.Format()} is flagged with {FileAttributes.Hidden.Format()}."));

            Delete(test.dir);

        }

        #endregion

        #region ContainsFiles

        [TestMethod]
        void ContainsFiles() {

            (String path, DirectoryInfo dir) test = GetLocation();
            FileInfo testContent1 = new FileInfo(Path.Combine(test.path, "ContainsFiles1"));
            FileInfo testContent2 = new FileInfo(Path.Combine(test.path, "ContainsFiles2"));

            DirectoryTestSuite_uTests.DDTContainsFiles(test.path, (1, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsFiles(test.dir, (2, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotContainsFiles(test.path, (3, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsFiles(test.dir, (4, false, $"Directory {test.path.Format()} doesn't exist."));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTContainsFiles(test.path, (5, false, $"Directory {test.path.Format()} contains 0 files."));
            DirectoryTestSuite_uTests.DDTContainsFiles(test.dir, (6, false, $"Directory {test.path.Format()} contains 0 files."));

            DirectoryTestSuite_uTests.DDTNotContainsFiles(test.path, (7, true, $"Directory {test.path.Format()} contains 0 files."));
            DirectoryTestSuite_uTests.DDTNotContainsFiles(test.dir, (8, true, $"Directory {test.path.Format()} contains 0 files."));

            Create(testContent1);

            DirectoryTestSuite_uTests.DDTContainsFiles(test.path, (9, true, $"Directory {test.path.Format()} contains 1 file."));
            DirectoryTestSuite_uTests.DDTContainsFiles(test.dir, (10, true, $"Directory {test.path.Format()} contains 1 file."));

            DirectoryTestSuite_uTests.DDTNotContainsFiles(test.path, (11, false, $"Directory {test.path.Format()} contains 1 file."));
            DirectoryTestSuite_uTests.DDTNotContainsFiles(test.dir, (12, false, $"Directory {test.path.Format()} contains 1 file."));

            Create(testContent2);

            DirectoryTestSuite_uTests.DDTContainsFiles(test.path, (13, true, $"Directory {test.path.Format()} contains 2 files."));
            DirectoryTestSuite_uTests.DDTContainsFiles(test.dir, (14, true, $"Directory {test.path.Format()} contains 2 files."));

            DirectoryTestSuite_uTests.DDTNotContainsFiles(test.path, (15, false, $"Directory {test.path.Format()} contains 2 files."));
            DirectoryTestSuite_uTests.DDTNotContainsFiles(test.dir, (16, false, $"Directory {test.path.Format()} contains 2 files."));

            Delete(test.dir);

        }

        #endregion

        #region ContainsFilesPattern

        [TestMethod]
        void ContainsFilesPattern() {

            (String path, DirectoryInfo dir) test = GetLocation();
            FileInfo testContent1 = new FileInfo(Path.Combine(test.path, "ContainsFiles1"));
            FileInfo testContent2 = new FileInfo(Path.Combine(test.path, "ContainsFiles2"));
            DirectoryInfo deepPath = new DirectoryInfo(Path.Combine(test.path, "Deep"));
            FileInfo testContentDeep1 = new FileInfo(Path.Combine(deepPath.FullName, "ContainsFiles1"));
            FileInfo testContentDeep2 = new FileInfo(Path.Combine(deepPath.FullName, "ContainsFiles2"));

            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.path, "", SearchOption.AllDirectories), (1, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.path, "", SearchOption.TopDirectoryOnly), (2, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.dir, "", SearchOption.AllDirectories), (3, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.dir, "", SearchOption.TopDirectoryOnly), (4, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.path, "", SearchOption.AllDirectories), (5, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.path, "", SearchOption.TopDirectoryOnly), (6, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.dir, "", SearchOption.AllDirectories), (7, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.dir, "", SearchOption.TopDirectoryOnly), (8, false, $"Directory {test.path.Format()} doesn't exist."));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.path, "", SearchOption.AllDirectories),
                (9, false, $"Directory {test.path.Format()} contains 0 files matching {"".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.path, "", SearchOption.TopDirectoryOnly),
                (10, false, $"Directory {test.path.Format()} contains 0 files matching {"".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.dir, "", SearchOption.AllDirectories),
                (11, false, $"Directory {test.path.Format()} contains 0 files matching {"".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.dir, "", SearchOption.TopDirectoryOnly),
                (12, false, $"Directory {test.path.Format()} contains 0 files matching {"".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.path, "", SearchOption.AllDirectories),
                (13, true, $"Directory {test.path.Format()} contains 0 files matching {"".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.path, "", SearchOption.TopDirectoryOnly),
                (14, true, $"Directory {test.path.Format()} contains 0 files matching {"".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.dir, "", SearchOption.AllDirectories),
                (15, true, $"Directory {test.path.Format()} contains 0 files matching {"".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.dir, "", SearchOption.TopDirectoryOnly),
                (16, true, $"Directory {test.path.Format()} contains 0 files matching {"".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            Create(testContent1);
            Create(testContent2);
            Create(deepPath);
            Create(testContentDeep1);
            Create(testContentDeep2);

            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.path, "*Files*", SearchOption.AllDirectories),
                (17, true, $"Directory {test.path.Format()} contains 4 files matching {"*Files*".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.path, "*Files*", SearchOption.TopDirectoryOnly),
                (18, true, $"Directory {test.path.Format()} contains 2 files matching {"*Files*".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.dir, "*Files*", SearchOption.AllDirectories),
                (19, true, $"Directory {test.path.Format()} contains 4 files matching {"*Files*".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.dir, "*Files*", SearchOption.TopDirectoryOnly),
                (20, true, $"Directory {test.path.Format()} contains 2 files matching {"*Files*".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.path, "*Files*", SearchOption.AllDirectories),
                (21, false, $"Directory {test.path.Format()} contains 4 files matching {"*Files*".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.path, "*Files*", SearchOption.TopDirectoryOnly),
                (22, false, $"Directory {test.path.Format()} contains 2 files matching {"*Files*".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.dir, "*Files*", SearchOption.AllDirectories),
                (23, false, $"Directory {test.path.Format()} contains 4 files matching {"*Files*".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.dir, "*Files*", SearchOption.TopDirectoryOnly),
                (24, false, $"Directory {test.path.Format()} contains 2 files matching {"*Files*".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.path, "*Files1", SearchOption.AllDirectories),
                (25, true, $"Directory {test.path.Format()} contains 2 files matching {"*Files1".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.path, "*Files1", SearchOption.TopDirectoryOnly),
                (26, true, $"Directory {test.path.Format()} contains 1 file matching {"*Files1".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.dir, "*Files1", SearchOption.AllDirectories),
                (27, true, $"Directory {test.path.Format()} contains 2 files matching {"*Files1".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPattern((test.dir, "*Files1", SearchOption.TopDirectoryOnly),
                (28, true, $"Directory {test.path.Format()} contains 1 file matching {"*Files1".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.path, "*Files1", SearchOption.AllDirectories),
                (29, false, $"Directory {test.path.Format()} contains 2 files matching {"*Files1".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.path, "*Files1", SearchOption.TopDirectoryOnly),
                (30, false, $"Directory {test.path.Format()} contains 1 file matching {"*Files1".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.dir, "*Files1", SearchOption.AllDirectories),
                (31, false, $"Directory {test.path.Format()} contains 2 files matching {"*Files1".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPattern((test.dir, "*Files1", SearchOption.TopDirectoryOnly),
                (32, false, $"Directory {test.path.Format()} contains 1 file matching {"*Files1".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            Delete(test.dir);

        }

        #endregion

        #region ContainsFilesPredicate

        [TestMethod]
        void ContainsFilesPredicate() {

            (String path, DirectoryInfo dir) test = GetLocation();
            FileInfo testContent1 = new FileInfo(Path.Combine(test.path, "ContainsFiles1"));
            FileInfo testContent2 = new FileInfo(Path.Combine(test.path, "ContainsFiles2"));
            DirectoryInfo deepPath = new DirectoryInfo(Path.Combine(test.path, "Deep"));
            FileInfo testContentDeep1 = new FileInfo(Path.Combine(deepPath.FullName, "ContainsFiles1"));
            FileInfo testContentDeep2 = new FileInfo(Path.Combine(deepPath.FullName, "ContainsFiles2"));

            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.path, (_) => true, SearchOption.AllDirectories), (1, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.path, (_) => true, SearchOption.TopDirectoryOnly), (2, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.dir, (_) => true, SearchOption.AllDirectories), (3, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.dir, (_) => true, SearchOption.TopDirectoryOnly), (4, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.path, (_) => true, SearchOption.AllDirectories), (5, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.path, (_) => true, SearchOption.TopDirectoryOnly), (6, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.dir, (_) => true, SearchOption.AllDirectories), (7, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.dir, (_) => true, SearchOption.TopDirectoryOnly), (8, false, $"Directory {test.path.Format()} doesn't exist."));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.path, (_) => true, SearchOption.AllDirectories),
                (9, false, $"Directory {test.path.Format()} contains 0 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.path, (_) => true, SearchOption.TopDirectoryOnly),
                (10, false, $"Directory {test.path.Format()} contains 0 matching files in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.dir, (_) => true, SearchOption.AllDirectories),
                (11, false, $"Directory {test.path.Format()} contains 0 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.dir, (_) => true, SearchOption.TopDirectoryOnly),
                (12, false, $"Directory {test.path.Format()} contains 0 matching files in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.path, (_) => true, SearchOption.AllDirectories),
                (13, true, $"Directory {test.path.Format()} contains 0 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.path, (_) => true, SearchOption.TopDirectoryOnly),
                (14, true, $"Directory {test.path.Format()} contains 0 matching files in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.dir, (_) => true, SearchOption.AllDirectories),
                (15, true, $"Directory {test.path.Format()} contains 0 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.dir, (_) => true, SearchOption.TopDirectoryOnly),
                (16, true, $"Directory {test.path.Format()} contains 0 matching files in {SearchOption.TopDirectoryOnly.Format()}."));

            Create(testContent1);
            Create(testContent2);
            Create(deepPath);
            Create(testContentDeep1);
            Create(testContentDeep2);

            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.path, (_) => _.Contains("Files"), SearchOption.AllDirectories),
                (17, true, $"Directory {test.path.Format()} contains 4 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.path, (_) => _.Contains("Files"), SearchOption.TopDirectoryOnly),
                (18, true, $"Directory {test.path.Format()} contains 2 matching files in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.dir, (_) => _.Name.Contains("Files"), SearchOption.AllDirectories),
                (19, true, $"Directory {test.path.Format()} contains 4 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.dir, (_) => _.Name.Contains("Files"), SearchOption.TopDirectoryOnly),
                (20, true, $"Directory {test.path.Format()} contains 2 matching files in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.path, (_) => _.Contains("Files"), SearchOption.AllDirectories),
                (21, false, $"Directory {test.path.Format()} contains 4 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.path, (_) => _.Contains("Files"), SearchOption.TopDirectoryOnly),
                (22, false, $"Directory {test.path.Format()} contains 2 matching files in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.dir, (_) => _.Name.Contains("Files"), SearchOption.AllDirectories),
                (23, false, $"Directory {test.path.Format()} contains 4 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.dir, (_) => _.Name.Contains("Files"), SearchOption.TopDirectoryOnly),
                (24, false, $"Directory {test.path.Format()} contains 2 matching files in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.path, (_) => _.Contains("Files1"), SearchOption.AllDirectories),
                (25, true, $"Directory {test.path.Format()} contains 2 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.path, (_) => _.Contains("Files1"), SearchOption.TopDirectoryOnly),
                (26, true, $"Directory {test.path.Format()} contains 1 matching file in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.dir, (_) => _.Name.Contains("Files1"), SearchOption.AllDirectories),
                (27, true, $"Directory {test.path.Format()} contains 2 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsFilesPredicate((test.dir, (_) => _.Name.Contains("Files1"), SearchOption.TopDirectoryOnly),
                (28, true, $"Directory {test.path.Format()} contains 1 matching file in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.path, (_) => _.Contains("Files1"), SearchOption.AllDirectories),
                (29, false, $"Directory {test.path.Format()} contains 2 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.path, (_) => _.Contains("Files1"), SearchOption.TopDirectoryOnly),
                (30, false, $"Directory {test.path.Format()} contains 1 matching file in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.dir, (_) => _.Name.Contains("Files1"), SearchOption.AllDirectories),
                (31, false, $"Directory {test.path.Format()} contains 2 matching files in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsFilesPredicate((test.dir, (_) => _.Name.Contains("Files1"), SearchOption.TopDirectoryOnly),
                (32, false, $"Directory {test.path.Format()} contains 1 matching file in {SearchOption.TopDirectoryOnly.Format()}."));

            Delete(test.dir);

        }

        #endregion

        #region ContainsDirectories

        [TestMethod]
        void ContainsDirectories() {

            (String path, DirectoryInfo dir) test = GetLocation();
            DirectoryInfo testContent1 = new DirectoryInfo(Path.Combine(test.path, "ContainsFiles1"));
            DirectoryInfo testContent2 = new DirectoryInfo(Path.Combine(test.path, "ContainsFiles2"));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTContainsDirectories(test.path, (1, false, $"Directory {test.path.Format()} contains 0 directories."));
            DirectoryTestSuite_uTests.DDTContainsDirectories(test.dir, (2, false, $"Directory {test.path.Format()} contains 0 directories."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectories(test.path, (3, true, $"Directory {test.path.Format()} contains 0 directories."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectories(test.dir, (4, true, $"Directory {test.path.Format()} contains 0 directories."));

            Test.Note($"Create {testContent1.Format()}");
            Create(testContent1);

            DirectoryTestSuite_uTests.DDTContainsDirectories(test.path, (5, true, $"Directory {test.path.Format()} contains 1 directory."));
            DirectoryTestSuite_uTests.DDTContainsDirectories(test.dir, (6, true, $"Directory {test.path.Format()} contains 1 directory."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectories(test.path, (7, false, $"Directory {test.path.Format()} contains 1 directory."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectories(test.dir, (8, false, $"Directory {test.path.Format()} contains 1 directory."));

            Test.Note($"Create {testContent2.Format()}");
            Create(testContent2);

            DirectoryTestSuite_uTests.DDTContainsDirectories(test.path, (9, true, $"Directory {test.path.Format()} contains 2 directories."));
            DirectoryTestSuite_uTests.DDTContainsDirectories(test.dir, (10, true, $"Directory {test.path.Format()} contains 2 directories."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectories(test.path, (11, false, $"Directory {test.path.Format()} contains 2 directories."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectories(test.dir, (12, false, $"Directory {test.path.Format()} contains 2 directories."));

            Delete(test.dir);

            DirectoryTestSuite_uTests.DDTContainsDirectories(test.path, (13, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsDirectories(test.dir, (14, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectories(test.path, (15, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectories(test.dir, (16, false, $"Directory {test.path.Format()} doesn't exist."));

        }

        #endregion

        #region ContainsDirectoriesPattern

        [TestMethod]
        void ContainsDirectoriesPattern() {

            (String path, DirectoryInfo dir) test = GetLocation();
            DirectoryInfo testContent1 = new DirectoryInfo(Path.Combine(test.path, "ContainsDirectories1"));
            DirectoryInfo testContent2 = new DirectoryInfo(Path.Combine(test.path, "ContainsDirectories2"));
            DirectoryInfo deepPath = new DirectoryInfo(Path.Combine(test.path, "Deep"));
            DirectoryInfo testContentDeep1 = new DirectoryInfo(Path.Combine(deepPath.FullName, "ContainsDirectories1"));
            DirectoryInfo testContentDeep2 = new DirectoryInfo(Path.Combine(deepPath.FullName, "ContainsDirectories2"));

            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.path, "", SearchOption.AllDirectories), (1, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.path, "", SearchOption.TopDirectoryOnly), (2, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.dir, "", SearchOption.AllDirectories), (3, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.dir, "", SearchOption.TopDirectoryOnly), (4, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.path, "", SearchOption.AllDirectories), (5, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.path, "", SearchOption.TopDirectoryOnly), (6, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.dir, "", SearchOption.AllDirectories), (7, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.dir, "", SearchOption.TopDirectoryOnly), (8, false, $"Directory {test.path.Format()} doesn't exist."));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.path, "", SearchOption.AllDirectories),
                (9, false, $"Directory {test.path.Format()} contains 0 directories matching {"".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.path, "", SearchOption.TopDirectoryOnly),
                (10, false, $"Directory {test.path.Format()} contains 0 directories matching {"".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.dir, "", SearchOption.AllDirectories),
                (11, false, $"Directory {test.path.Format()} contains 0 directories matching {"".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.dir, "", SearchOption.TopDirectoryOnly),
                (12, false, $"Directory {test.path.Format()} contains 0 directories matching {"".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.path, "", SearchOption.AllDirectories),
                (13, true, $"Directory {test.path.Format()} contains 0 directories matching {"".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.path, "", SearchOption.TopDirectoryOnly),
                (14, true, $"Directory {test.path.Format()} contains 0 directories matching {"".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.dir, "", SearchOption.AllDirectories),
                (15, true, $"Directory {test.path.Format()} contains 0 directories matching {"".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.dir, "", SearchOption.TopDirectoryOnly),
                (16, true, $"Directory {test.path.Format()} contains 0 directories matching {"".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            Create(testContent1);
            Create(testContent2);
            Create(deepPath);
            Create(testContentDeep1);
            Create(testContentDeep2);

            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.path, "*Directories*", SearchOption.AllDirectories),
                (17, true, $"Directory {test.path.Format()} contains 4 directories matching {"*Directories*".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.path, "*Directories*", SearchOption.TopDirectoryOnly),
                (18, true, $"Directory {test.path.Format()} contains 2 directories matching {"*Directories*".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.dir, "*Directories*", SearchOption.AllDirectories),
                (19, true, $"Directory {test.path.Format()} contains 4 directories matching {"*Directories*".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.dir, "*Directories*", SearchOption.TopDirectoryOnly),
                (20, true, $"Directory {test.path.Format()} contains 2 directories matching {"*Directories*".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.path, "*Directories*", SearchOption.AllDirectories),
                (21, false, $"Directory {test.path.Format()} contains 4 directories matching {"*Directories*".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.path, "*Directories*", SearchOption.TopDirectoryOnly),
                (22, false, $"Directory {test.path.Format()} contains 2 directories matching {"*Directories*".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.dir, "*Directories*", SearchOption.AllDirectories),
                (23, false, $"Directory {test.path.Format()} contains 4 directories matching {"*Directories*".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.dir, "*Directories*", SearchOption.TopDirectoryOnly),
                (24, false, $"Directory {test.path.Format()} contains 2 directories matching {"*Directories*".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.path, "*Directories1", SearchOption.AllDirectories),
                (25, true, $"Directory {test.path.Format()} contains 2 directories matching {"*Directories1".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.path, "*Directories1", SearchOption.TopDirectoryOnly),
                (26, true, $"Directory {test.path.Format()} contains 1 directory matching {"*Directories1".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.dir, "*Directories1", SearchOption.AllDirectories),
                (27, true, $"Directory {test.path.Format()} contains 2 directories matching {"*Directories1".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPattern((test.dir, "*Directories1", SearchOption.TopDirectoryOnly),
                (28, true, $"Directory {test.path.Format()} contains 1 directory matching {"*Directories1".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.path, "*Directories1", SearchOption.AllDirectories),
                (29, false, $"Directory {test.path.Format()} contains 2 directories matching {"*Directories1".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.path, "*Directories1", SearchOption.TopDirectoryOnly),
                (30, false, $"Directory {test.path.Format()} contains 1 directory matching {"*Directories1".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.dir, "*Directories1", SearchOption.AllDirectories),
                (31, false, $"Directory {test.path.Format()} contains 2 directories matching {"*Directories1".Format()} in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPattern((test.dir, "*Directories1", SearchOption.TopDirectoryOnly),
                (32, false, $"Directory {test.path.Format()} contains 1 directory matching {"*Directories1".Format()} in {SearchOption.TopDirectoryOnly.Format()}."));

            Delete(test.dir);

        }

        #endregion

        #region ContainsDirectoriesPredicate

        [TestMethod]
        void ContainsDirectoriesPredicate() {

            (String path, DirectoryInfo dir) test = GetLocation();
            DirectoryInfo testContent1 = new DirectoryInfo(Path.Combine(test.path, "ContainsFiles1"));
            DirectoryInfo testContent2 = new DirectoryInfo(Path.Combine(test.path, "ContainsFiles2"));
            DirectoryInfo deepPath = new DirectoryInfo(Path.Combine(test.path, "Deep"));
            DirectoryInfo testContentDeep1 = new DirectoryInfo(Path.Combine(deepPath.FullName, "ContainsFiles1"));
            DirectoryInfo testContentDeep2 = new DirectoryInfo(Path.Combine(deepPath.FullName, "ContainsFiles2"));

            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.path, (_) => true, SearchOption.AllDirectories), (1, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.path, (_) => true, SearchOption.TopDirectoryOnly), (2, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.dir, (_) => true, SearchOption.AllDirectories), (3, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.dir, (_) => true, SearchOption.TopDirectoryOnly), (4, false, $"Directory {test.path.Format()} doesn't exist."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.path, (_) => true, SearchOption.AllDirectories), (5, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.path, (_) => true, SearchOption.TopDirectoryOnly), (6, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.dir, (_) => true, SearchOption.AllDirectories), (7, false, $"Directory {test.path.Format()} doesn't exist."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.dir, (_) => true, SearchOption.TopDirectoryOnly), (8, false, $"Directory {test.path.Format()} doesn't exist."));

            Create(test.dir);

            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.path, (_) => true, SearchOption.AllDirectories),
                (9, false, $"Directory {test.path.Format()} contains 0 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.path, (_) => true, SearchOption.TopDirectoryOnly),
                (10, false, $"Directory {test.path.Format()} contains 0 matching directories in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.dir, (_) => true, SearchOption.AllDirectories),
                (11, false, $"Directory {test.path.Format()} contains 0 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.dir, (_) => true, SearchOption.TopDirectoryOnly),
                (12, false, $"Directory {test.path.Format()} contains 0 matching directories in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.path, (_) => true, SearchOption.AllDirectories),
                (13, true, $"Directory {test.path.Format()} contains 0 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.path, (_) => true, SearchOption.TopDirectoryOnly),
                (14, true, $"Directory {test.path.Format()} contains 0 matching directories in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.dir, (_) => true, SearchOption.AllDirectories),
                (15, true, $"Directory {test.path.Format()} contains 0 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.dir, (_) => true, SearchOption.TopDirectoryOnly),
                (16, true, $"Directory {test.path.Format()} contains 0 matching directories in {SearchOption.TopDirectoryOnly.Format()}."));

            Create(testContent1);
            Create(testContent2);
            Create(deepPath);
            Create(testContentDeep1);
            Create(testContentDeep2);

            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.path, (_) => _.Contains("Files"), SearchOption.AllDirectories),
                (17, true, $"Directory {test.path.Format()} contains 4 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.path, (_) => _.Contains("Files"), SearchOption.TopDirectoryOnly),
                (18, true, $"Directory {test.path.Format()} contains 2 matching directories in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.dir, (_) => _.Name.Contains("Files"), SearchOption.AllDirectories),
                (19, true, $"Directory {test.path.Format()} contains 4 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.dir, (_) => _.Name.Contains("Files"), SearchOption.TopDirectoryOnly),
                (20, true, $"Directory {test.path.Format()} contains 2 matching directories in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.path, (_) => _.Contains("Files"), SearchOption.AllDirectories),
                (21, false, $"Directory {test.path.Format()} contains 4 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.path, (_) => _.Contains("Files"), SearchOption.TopDirectoryOnly),
                (22, false, $"Directory {test.path.Format()} contains 2 matching directories in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.dir, (_) => _.Name.Contains("Files"), SearchOption.AllDirectories),
                (23, false, $"Directory {test.path.Format()} contains 4 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.dir, (_) => _.Name.Contains("Files"), SearchOption.TopDirectoryOnly),
                (24, false, $"Directory {test.path.Format()} contains 2 matching directories in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.path, (_) => _.Contains("Files1"), SearchOption.AllDirectories),
                (25, true, $"Directory {test.path.Format()} contains 2 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.path, (_) => _.Contains("Files1"), SearchOption.TopDirectoryOnly),
                (26, true, $"Directory {test.path.Format()} contains 1 matching directory in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.dir, (_) => _.Name.Contains("Files1"), SearchOption.AllDirectories),
                (27, true, $"Directory {test.path.Format()} contains 2 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTContainsDirectoriesPredicate((test.dir, (_) => _.Name.Contains("Files1"), SearchOption.TopDirectoryOnly),
                (28, true, $"Directory {test.path.Format()} contains 1 matching directory in {SearchOption.TopDirectoryOnly.Format()}."));

            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.path, (_) => _.Contains("Files1"), SearchOption.AllDirectories),
                (29, false, $"Directory {test.path.Format()} contains 2 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.path, (_) => _.Contains("Files1"), SearchOption.TopDirectoryOnly),
                (30, false, $"Directory {test.path.Format()} contains 1 matching directory in {SearchOption.TopDirectoryOnly.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.dir, (_) => _.Name.Contains("Files1"), SearchOption.AllDirectories),
                (31, false, $"Directory {test.path.Format()} contains 2 matching directories in {SearchOption.AllDirectories.Format()}."));
            DirectoryTestSuite_uTests.DDTNotContainsDirectoriesPredicate((test.dir, (_) => _.Name.Contains("Files1"), SearchOption.TopDirectoryOnly),
                (32, false, $"Directory {test.path.Format()} contains 1 matching directory in {SearchOption.TopDirectoryOnly.Format()}."));

            Delete(test.dir);

        }

        #endregion

    }
}
