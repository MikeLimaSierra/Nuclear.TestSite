﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    public partial class DirectoryTestSuite {

        #region Exists

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> exists on disk.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.Exists(@"C:\Temp");
        /// </code>
        /// </example>
        public void Exists(String path,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            Exists(dir, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> exists on disk.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.Exists(dir);
        /// </code>
        /// </example>
        public void Exists(DirectoryInfo directory,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            Boolean result = directory.Exists;

            InternalTest(result, String.Format("Directory {0} {1}.", directory.FullName.Format(), result ? "exists" : "does not exist"),
                _file, _method);
        }

        #endregion

        #region IsEmpty

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> is empty.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.IsEmpty(@"C:\Temp");
        /// </code>
        /// </example>
        public void IsEmpty(String path,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            IsEmpty(dir, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> is empty.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.IsEmpty(dir);
        /// </code>
        /// </example>
        public void IsEmpty(DirectoryInfo directory,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            if(!directory.Exists) {
                FailTest($"Directory {directory.Format()} doesn't exist.", _file, _method);
                return;
            }

            Boolean result = directory.GetFileSystemInfos().Length <= 0;

            InternalTest(result, String.Format("Directory {0} is {1}empty.", directory.FullName.Format(), result ? String.Empty : "not "),
                _file, _method);
        }

        #endregion

        #region HasAttribute

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> has an <paramref name="attribute"/>.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="attribute"></param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.HasAttribute(@"C:\Temp", FileAttributes.Temporary);
        /// </code>
        /// </example>
        public void HasAttribute(String path, FileAttributes attribute,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(FileAttributes), attribute)) {
                FailTest("Parameter 'searchOption' is out of bounds.", _file, _method);
                return;
            }

            HasAttribute(dir, attribute, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> has an <paramref name="attribute"/>.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="attribute"></param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.HasAttribute(dir, FileAttributes.Temporary);
        /// </code>
        /// </example>
        public void HasAttribute(DirectoryInfo directory, FileAttributes attribute,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            if(!directory.Exists) {
                FailTest($"Directory {directory.Format()} doesn't exist.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(FileAttributes), attribute)) {
                FailTest("Parameter 'searchOption' is out of bounds.", _file, _method);
                return;
            }

            Boolean result = directory.Attributes.HasFlag(attribute);

            InternalTest(result, String.Format("Directory {0} is {1}flagged with {2}.", directory.FullName.Format(), result ? String.Empty : "not ", attribute.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsFiles

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> contains any files.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsFiles(@"C:\Temp");
        /// </code>
        /// </example>
        public void ContainsFiles(String path,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            ContainsFiles(dir, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> contains any files.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsFiles(dir);
        /// </code>
        /// </example>
        public void ContainsFiles(DirectoryInfo directory,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            if(!directory.Exists) {
                FailTest($"Directory {directory.Format()} doesn't exist.", _file, _method);
                return;
            }

            Int32 result = directory.GetFiles().Length;

            InternalTest(result > 0, String.Format("Directory {0} contains {1} {2}.", directory.FullName.Format(), result, result == 1 ? "file" : "files"),
                _file, _method);
        }

        #endregion

        #region ContainsFilesPattern

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> contains matching files.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="searchPattern">The search string to match against the names of files. This parameter can contain
        /// a combination of valid literal path and wildcard (* and ?) characters, but it
        /// doesn't support regular expressions. The default pattern is "*", which returns
        /// all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should
        /// include only the current directory or all subdirectories.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsFiles(@"C:\Temp", "*log.txt", SearchOption.TopDirectoryOnly);
        /// </code>
        /// </example>
        public void ContainsFiles(String path, String searchPattern, SearchOption searchOption,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            if(searchPattern == null) {
                FailTest("Parameter 'searchPattern' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(SearchOption), searchOption)) {
                FailTest("Parameter 'searchOption' is out of bounds.", _file, _method);
                return;
            }

            ContainsFiles(dir, searchPattern, searchOption, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> contains matching files.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="searchPattern">The search string to match against the names of files. This parameter can contain
        /// a combination of valid literal path and wildcard (* and ?) characters, but it
        /// doesn't support regular expressions. The default pattern is "*", which returns
        /// all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should
        /// include only the current directory or all subdirectories.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsFiles(dir, "*log.txt", SearchOption.TopDirectoryOnly);
        /// </code>
        /// </example>
        public void ContainsFiles(DirectoryInfo directory, String searchPattern, SearchOption searchOption,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            if(!directory.Exists) {
                FailTest($"Directory {directory.Format()} doesn't exist.", _file, _method);
                return;
            }

            if(searchPattern == null) {
                FailTest("Parameter 'searchPattern' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(SearchOption), searchOption)) {
                FailTest("Parameter 'searchOption' is out of bounds.", _file, _method);
                return;
            }

            Int32 result = directory.GetFiles(searchPattern, searchOption).Length;

            InternalTest(result > 0, String.Format("Directory {0} contains {1} {2} matching {3} in {4}.",
                directory.FullName.Format(), result, result == 1 ? "file" : "files", searchPattern.Format(), searchOption.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsFilesPredicate

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> contains matching files.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="match">The <see cref="Predicate{FileInfo}"/> used to filter for matches.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsDirectories(@"C:\Temp", myFileMatch);
        /// </code>
        /// </example>
        public void ContainsFiles(String path, Predicate<FileInfo> match,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            if(match == null) {
                FailTest("Parameter 'match' is null.", _file, _method);
                return;
            }

            ContainsFiles(dir, match, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> contains matching files.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="match">The <see cref="Predicate{FileInfo}"/> used to filter for matches.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsDirectories(dir, myFileMatch);
        /// </code>
        /// </example>
        public void ContainsFiles(DirectoryInfo directory, Predicate<FileInfo> match,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            if(!directory.Exists) {
                FailTest($"Directory {directory.Format()} doesn't exist.", _file, _method);
                return;
            }

            if(match == null) {
                FailTest("Parameter 'match' is null.", _file, _method);
                return;
            }

            List<FileInfo> matches = new List<FileInfo>();

            try {
                foreach(FileInfo file in directory.GetFiles()) {
                    if(match(file)) {
                        matches.Add(file);
                    }
                }

            } catch(Exception ex) {
                FailTest($"Predicate threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(matches.Count > 0, String.Format("Directory {0} contains {1} matching {2}.",
                directory.FullName.Format(), matches.Count, matches.Count == 1 ? "file" : "files"),
                _file, _method);
        }

        #endregion

        #region ContainsDirectories

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> contains any sub directories.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsDirectories(@"C:\Temp");
        /// </code>
        /// </example>
        public void ContainsDirectories(String path,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            ContainsDirectories(dir, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> contains any sub directories.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsDirectories(dir);
        /// </code>
        /// </example>
        public void ContainsDirectories(DirectoryInfo directory,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            if(!directory.Exists) {
                FailTest($"Directory {directory.Format()} doesn't exist.", _file, _method);
                return;
            }

            Int32 result = directory.GetDirectories().Length;

            InternalTest(result > 0, String.Format("Directory {0} contains {1} {2}.", directory.FullName.Format(), result, result == 1 ? "directory" : "directories"),
                _file, _method);
        }

        #endregion

        #region ContainsDirectoriesPattern

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> contains matching sub directories.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="searchPattern">The search string to match against the names of files. This parameter can contain
        /// a combination of valid literal path and wildcard (* and ?) characters, but it
        /// doesn't support regular expressions. The default pattern is "*", which returns
        /// all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should
        /// include only the current directory or all subdirectories.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsDirectories(@"C:\Temp", "*_logs", SearchOption.TopDirectoryOnly);
        /// </code>
        /// </example>
        public void ContainsDirectories(String path, String searchPattern, SearchOption searchOption,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            if(searchPattern == null) {
                FailTest("Parameter 'searchPattern' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(SearchOption), searchOption)) {
                FailTest("Parameter 'searchOption' is out of bounds.", _file, _method);
                return;
            }

            ContainsDirectories(dir, searchPattern, searchOption, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> contains matching sub directories.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="searchPattern">The search string to match against the names of files. This parameter can contain
        /// a combination of valid literal path and wildcard (* and ?) characters, but it
        /// doesn't support regular expressions. The default pattern is "*", which returns
        /// all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should
        /// include only the current directory or all subdirectories.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsDirectories(dir, "*_logs", SearchOption.TopDirectoryOnly);
        /// </code>
        /// </example>
        public void ContainsDirectories(DirectoryInfo directory, String searchPattern, SearchOption searchOption,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            if(!directory.Exists) {
                FailTest($"Directory {directory.Format()} doesn't exist.", _file, _method);
                return;
            }

            if(searchPattern == null) {
                FailTest("Parameter 'searchPattern' is null.", _file, _method);
                return;
            }

            if(!Enum.IsDefined(typeof(SearchOption), searchOption)) {
                FailTest("Parameter 'searchOption' is out of bounds.", _file, _method);
                return;
            }

            Int32 result = directory.GetDirectories(searchPattern, searchOption).Length;

            InternalTest(result > 0, String.Format("Directory {0} contains {1} {2} matching {3} in {4}.",
                directory.FullName.Format(), result, result == 1 ? "directory" : "directories", searchPattern.Format(), searchOption.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsDirectoriesPredicate

        /// <summary>
        /// Tests if the directory at <paramref name="path"/> contains matching sub directories.
        /// </summary>
        /// <param name="path">The directory path to be checked.</param>
        /// <param name="match">The <see cref="Predicate{DirectoryInfo}"/> used to filter for matches.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsDirectories(@"C:\Temp", myDirMatch);
        /// </code>
        /// </example>
        public void ContainsDirectories(String path, Predicate<DirectoryInfo> match,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(String.IsNullOrWhiteSpace(path)) {
                FailTest("Parameter 'path' is null or white space.", _file, _method);
                return;
            }

            DirectoryInfo dir = null;

            try {
                dir = new DirectoryInfo(path);

            } catch(SecurityException) {
                FailTest($"The caller does not have the required permission to access {path.Format()}.", _file, _method);
                return;

            } catch(ArgumentException) {
                FailTest($"The path {path.Format()} contains invalid characters such as \", <, >, or |.", _file, _method);
                return;

            } catch(PathTooLongException) {
                FailTest($"The path {path.Format()} exceeds the system-defined maximum length.", _file, _method);
                return;

            } catch(Exception ex) {
                FailTest($"Creating the DirectoryInfo instance threw an exception: {ex.Format()}", _file, _method);
                return;
            }

            if(match == null) {
                FailTest("Parameter 'match' is null.", _file, _method);
                return;
            }

            ContainsDirectories(dir, match, _file, _method);
        }

        /// <summary>
        /// Tests if the <paramref name="directory"/> contains matching sub directories.
        /// </summary>
        /// <param name="directory">The directory to be checked.</param>
        /// <param name="match">The <see cref="Predicate{DirectoryInfo}"/> used to filter for matches.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Directory.ContainsDirectories(dir, myDirMatch);
        /// </code>
        /// </example>
        public void ContainsDirectories(DirectoryInfo directory, Predicate<DirectoryInfo> match,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(directory == null) {
                FailTest("Parameter 'directory' is null.", _file, _method);
                return;
            }

            if(!directory.Exists) {
                FailTest($"Directory {directory.Format()} doesn't exist.", _file, _method);
                return;
            }

            if(match == null) {
                FailTest("Parameter 'match' is null.", _file, _method);
                return;
            }

            List<DirectoryInfo> matches = new List<DirectoryInfo>();

            try {
                foreach(DirectoryInfo dir in directory.GetDirectories()) {
                    if(match(dir)) {
                        matches.Add(dir);
                    }
                }

            } catch(Exception ex) {
                FailTest($"Predicate threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(matches.Count > 0, String.Format("Directory {0} contains {1} matching {2}.",
                directory.FullName.Format(), matches.Count, matches.Count == 1 ? "directory" : "directories"),
                _file, _method);
        }

        #endregion

    }
}
