﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    public partial class ValueTestSuite {

        #region IsEqual

        /// <summary>
        /// Tests if two objects are equal.
        ///     Equality is determined by checking implementations of (in given order):
        ///     <see cref="IEquatable{T}"/>
        ///     <see cref="IComparable{T}"/>
        ///     <see cref="IComparable"/>
        ///     default <see cref="IEqualityComparer{T}"/>
        /// </summary>
        /// <typeparam name="T">The type of both objects.</typeparam>
        /// <param name="left">The first object.</param>
        /// <param name="right">The second object.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(obj1, obj2);
        /// </code>
        /// </example>
        public void IsEqual<T>(T left, T right,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(left == null && right == null) {
                InternalTest(true, $"[Left = {left.Format()}; Right = {right.Format()}]",
                    customMessage, _file, _method);
                return;
            }

            if(left is IEquatable<T> eLeft) {
                try {
                    InternalTest(eLeft.Equals(right), $"({typeof(T).Format()}.IEquatable<T>) [Left = {left.Format()}; Right = {right.Format()}]",
                        customMessage, _file, _method);
                    return;

                } catch { /* advance to next */ }
            }

            if(left is IComparable<T> cTLeft) {
                try {
                    InternalTest(cTLeft.IsEqual(right), $"({typeof(T).Format()}.IComparable<T>) [Left = {left.Format()}; Right = {right.Format()}]",
                        customMessage, _file, _method);
                    return;

                } catch { /* advance to next */ }

            }

            if(left is IComparable cLeft) {
                try {
                    InternalTest(cLeft.IsEqual(right), $"({typeof(T).Format()}.IComparable) [Left = {left.Format()}; Right = {right.Format()}]",
                        customMessage, _file, _method);
                    return;

                } catch { /* advance to next */ }

            }

            IsEqual(left, right, EqualityComparer<T>.Default, customMessage, _file, _method);
        }

        #endregion

        #region IsEqualComparer

        /// <summary>
        /// Tests if two objects are equal by using a supplied <see cref="EqualityComparer{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="left">The first object.</param>
        /// <param name="right">The second object.</param>
        /// <param name="comparer">The <see cref="EqualityComparer{T}"/> to be used to determine equality.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(obj1, obj2, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void IsEqual<T>(T left, T right, EqualityComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsEqual(left, right, comparer as IEqualityComparer<T>, customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if two objects are equal by using a supplied <see cref="IEqualityComparer"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="left">The first object.</param>
        /// <param name="right">The second object.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer"/> to be used to determine equality.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(obj1, obj2, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void IsEqual<T>(T left, T right, IEqualityComparer comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsEqual(left, right, DynamicEqualityComparer.FromComparer<T>(comparer), customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if two objects are equal by using a supplied <see cref="IEqualityComparer{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="left">The first object.</param>
        /// <param name="right">The second object.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> to be used to determine equality.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(obj1, obj2, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void IsEqual<T>(T left, T right, IEqualityComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = comparer.Equals(left, right);

            } catch(Exception ex) {
                InternalFail(String.Format("Comparison threw Exception: {0}", ex.Message),
                    _file, _method);
                return;
            }

            InternalTest(result, $"({comparer.GetType().Name.Format()}) [Left = {left.Format()}; Right = {right.Format()}]",
                customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if two objects are equal by using a supplied <see cref="Comparer{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="left">The first object.</param>
        /// <param name="right">The second object.</param>
        /// <param name="comparer">The <see cref="Comparer{T}"/> to be used to determine equality.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(obj1, obj2, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void IsEqual<T>(T left, T right, Comparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsEqual(left, right, comparer as IComparer<T>, customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if two objects are equal by using a supplied <see cref="IComparer"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="left">The first object.</param>
        /// <param name="right">The second object.</param>
        /// <param name="comparer">The <see cref="IComparer"/> to be used to determine equality.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(obj1, obj2, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void IsEqual<T>(T left, T right, IComparer comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsEqual(left, right, DynamicComparer.FromComparer<T>(comparer), customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if two objects are equal by using a supplied <see cref="IComparer{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="left">The first object.</param>
        /// <param name="right">The second object.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> to be used to determine equality.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(obj1, obj2, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void IsEqual<T>(T left, T right, IComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {
            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = comparer.IsEqual(left, right);

            } catch(Exception ex) {
                InternalFail(String.Format("Comparison threw Exception: {0}", ex.Message),
                    _file, _method);
                return;
            }

            InternalTest(result, $"({comparer.GetType().Name.Format()}) [Left = {left.Format()}; Right = {right.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsEqualFloat

        /// <summary>
        /// Tests if two <see cref="Single"/> values are equal by a margin of 1e-12.
        /// </summary>
        /// <param name="left">The first value.</param>
        /// <param name="right">The second value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(val1, val2);
        /// </code>
        /// </example>
        public void IsEqual(Single left, Single right,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) => IsEqual(left, right, 1e-12f, customMessage, _file, _method);

        /// <summary>
        /// Tests if two <see cref="Single"/> values are equal by a <paramref name="margin"/>.
        /// </summary>
        /// <param name="left">The first value.</param>
        /// <param name="right">The second value.</param>
        /// <param name="margin">The margin to use as tolerance.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(val1, val2, 1e-28f);
        /// </code>
        /// </example>
        public void IsEqual(Single left, Single right, Single margin,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => InternalTest(Math.Abs(left - right) <= margin, $"[Left = {left.Format()}; Right = {right.Format()}; Margin = {margin.Format()}]",
                customMessage, _file, _method);

        /// <summary>
        /// Tests if two <see cref="Double"/> values are equal by a margin of 1e-12.
        /// </summary>
        /// <param name="left">The first value.</param>
        /// <param name="right">The second value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(val1, val2);
        /// </code>
        /// </example>
        public void IsEqual(Double left, Double right,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) => IsEqual(left, right, 1e-12d, customMessage, _file, _method);

        /// <summary>
        /// Tests if two <see cref="Double"/> values are equal by a <paramref name="margin"/>.
        /// </summary>
        /// <param name="left">The first value.</param>
        /// <param name="right">The second value.</param>
        /// <param name="margin">The margin to use as tolerance.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(val1, val2, 1e-28f);
        /// </code>
        /// </example>
        public void IsEqual(Double left, Double right, Double margin,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => InternalTest(Math.Abs(left - right) <= margin, $"[Left = {left.Format()}; Right = {right.Format()}; Margin = {margin.Format()}]",
                customMessage, _file, _method);

        #endregion

        #region IsEqualDirectory

        /// <summary>
        /// Tests if two <see cref="DirectoryInfo"/> values are equal.
        /// </summary>
        /// <param name="left">The first value.</param>
        /// <param name="right">The second value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(dir1, dir2);
        /// </code>
        /// </example>
        public void IsEqual(DirectoryInfo left, DirectoryInfo right,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(left == null) {
                InternalFail($"Parameter '{nameof(left)}' is null.", _file, _method);
                return;
            }

            if(right == null) {
                InternalFail($"Parameter '{nameof(right)}' is null.", _file, _method);
                return;
            }

            InternalTest(left.FullName == right.FullName, $"[Left = {left.FullName.Format()}; Right = {right.FullName.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsEqualFile

        /// <summary>
        /// Tests if two <see cref="FileInfo"/> values are equal.
        /// </summary>
        /// <param name="left">The first value.</param>
        /// <param name="right">The second value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.Equals(file1, file2);
        /// </code>
        /// </example>
        public void IsEqual(FileInfo left, FileInfo right,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(left == null) {
                InternalFail($"Parameter '{nameof(left)}' is null.", _file, _method);
                return;
            }

            if(right == null) {
                InternalFail($"Parameter '{nameof(right)}' is null.", _file, _method);
                return;
            }

            InternalTest(left.FullName == right.FullName, $"[Left = {left.FullName.Format()}; Right = {right.FullName.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsLessThan

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable"/>.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThan(value1, value2);
        /// </code>
        /// </example>
        public void IsLessThan<T>(T value, T other,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable => IsLessThan(value, other, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable{T}"/>.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThan(value1, value2);
        /// </code>
        /// </example>
        public void IsLessThanT<T>(T value, T other,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> => IsLessThan(value, other, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="Comparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThan(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsLessThan<T>(T value, T other, Comparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsLessThan(value, other, comparer as IComparer<T>, customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="IComparer"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThan(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsLessThan<T>(T value, T other, IComparer comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsLessThan(value, other, DynamicComparer.FromComparer<T>(comparer), customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThan(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsLessThan<T>(T value, T other, IComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = comparer.IsLessThan(value, other);

            } catch(Exception ex) {
                InternalFail($"Comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, $"[Value = {value.Format()}; Other = {other.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsLessThanOrEqual

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable"/>.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThanOrEquals(value1, value2);
        /// </code>
        /// </example>
        public void IsLessThanOrEqual<T>(T value, T other,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable => IsLessThanOrEqual(value, other, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable{T}"/>.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThanOrEquals(value1, value2);
        /// </code>
        /// </example>
        public void IsLessThanOrEqualT<T>(T value, T other,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> => IsLessThanOrEqual(value, other, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="Comparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThanOrEquals(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsLessThanOrEqual<T>(T value, T other, Comparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsLessThanOrEqual(value, other, comparer as IComparer<T>, customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="IComparer"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThanOrEquals(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsLessThanOrEqual<T>(T value, T other, IComparer comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsLessThanOrEqual(value, other, DynamicComparer.FromComparer<T>(comparer), customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is less than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsLessThanOrEquals(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsLessThanOrEqual<T>(T value, T other, IComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = comparer.IsLessThanOrEqual(value, other);

            } catch(Exception ex) {
                InternalFail($"Comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, $"[Value = {value.Format()}; Other = {other.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsGreaterThan

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable"/>.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThan(value1, value2);
        /// </code>
        /// </example>
        public void IsGreaterThan<T>(T value, T other,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable => IsGreaterThan(value, other, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable{T}"/>.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThan(value1, value2);
        /// </code>
        /// </example>
        public void IsGreaterThanT<T>(T value, T other,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> => IsGreaterThan(value, other, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="Comparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThan(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsGreaterThan<T>(T value, T other, Comparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsGreaterThan(value, other, comparer as IComparer<T>, customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="IComparer"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThan(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsGreaterThan<T>(T value, T other, IComparer comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsGreaterThan(value, other, DynamicComparer.FromComparer<T>(comparer), customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThan(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsGreaterThan<T>(T value, T other, IComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = comparer.IsGreaterThan(value, other);

            } catch(Exception ex) {
                InternalFail($"Comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, $"[Value = {value.Format()}; Other = {other.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsGreaterThanOrEqual

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable"/>.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThanOrEquals(value1, value2);
        /// </code>
        /// </example>
        public void IsGreaterThanOrEqual<T>(T value, T other,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable => IsGreaterThanOrEqual(value, other, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable{T}"/>.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThanOrEquals(value1, value2);
        /// </code>
        /// </example>
        public void IsGreaterThanOrEqualT<T>(T value, T other,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> => IsGreaterThanOrEqual(value, other, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="Comparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThanOrEquals(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsGreaterThanOrEqual<T>(T value, T other, Comparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsGreaterThanOrEqual(value, other, comparer as IComparer<T>, customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="IComparer"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThanOrEquals(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsGreaterThanOrEqual<T>(T value, T other, IComparer comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsGreaterThanOrEqual(value, other, DynamicComparer.FromComparer<T>(comparer), customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is greater than <paramref name="other"/> or equal.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against <paramref name="other"/>.</param>
        /// <param name="other">The other value.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsGreaterThanOrEquals(value1, value2, new MyComparer());
        /// </code>
        /// </example>
        public void IsGreaterThanOrEqual<T>(T value, T other, IComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = comparer.IsGreaterThanOrEqual(value, other);

            } catch(Exception ex) {
                InternalFail($"Comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, $"[Value = {value.Format()}; Other = {other.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsTrue

        /// <summary>
        /// Tests if <paramref name="value"/> is true.
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsTrue(1 + 1 == 2);
        /// </code>
        /// </example>
        public void IsTrue(Boolean value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => InternalTest(value, $"[Value = {value.Format()}]",
                customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is true.
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsTrue(someNullableBoolean);
        /// </code>
        /// </example>
        public void IsTrue(Boolean? value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(!value.HasValue) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            InternalTest(value.Value, $"[Value = {value.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsFalse

        /// <summary>
        /// Tests if <paramref name="value"/> is false.
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsFalse(1 + 1 != 2);
        /// </code>
        /// </example>
        public void IsFalse(Boolean value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => InternalTest(!value, $"[Value = {value.Format()}]",
                customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is false.
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsFalse(someNullableBoolean);
        /// </code>
        /// </example>
        public void IsFalse(Boolean? value,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(!value.HasValue) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            InternalTest(!value.Value, $"[Value = {value.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsClamped

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given inclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable"/>.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClamped(someIndex, 0, someList.Count - 1);
        /// </code>
        /// </example>
        public void IsClamped<T>(T value, T min, T max,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable => IsClamped(value, min, max, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given inclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable{T}"/>.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClamped(someIndex, 0, someList.Count - 1);
        /// </code>
        /// </example>
        public void IsClampedT<T>(T value, T min, T max,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> => IsClamped(value, min, max, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given inclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="comparer">The <see cref="Comparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClamped(someIndex, 0, someList.Count - 1, new MyComparer());
        /// </code>
        /// </example>
        public void IsClamped<T>(T value, T min, T max, Comparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsClamped(value, min, max, comparer as IComparer<T>, customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given inclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="comparer">The <see cref="IComparer"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClamped(someIndex, 0, someList.Count - 1, new MyComparer());
        /// </code>
        /// </example>
        public void IsClamped<T>(T value, T min, T max, IComparer comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsClamped(value, min, max, DynamicComparer.FromComparer<T>(comparer), customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given inclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClamped(someIndex, 0, someList.Count - 1, new MyComparer());
        /// </code>
        /// </example>
        public void IsClamped<T>(T value, T min, T max, IComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = comparer.IsClamped(value, min, max);

            } catch(Exception ex) {
                InternalFail($"Comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, $"[Value = {value.Format()}; Min = {min.Format()}; Max = {max.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

        #region IsClampedExclusive

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given exclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable"/>.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClampedExclusive(someIndex, -1, someList.Count);
        /// </code>
        /// </example>
        public void IsClampedExclusive<T>(T value, T min, T max,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable => IsClampedExclusive(value, min, max, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given exclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare - must derive from <see cref="IComparable{T}"/>.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClampedExclusive(someIndex, -1, someList.Count);
        /// </code>
        /// </example>
        public void IsClampedExclusiveT<T>(T value, T min, T max,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            where T : IComparable<T> => IsClampedExclusive(value, min, max, Comparer<T>.Create((x, y) => x.CompareTo(y)), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given exclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="comparer">The <see cref="Comparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClampedExclusive(someIndex, -1, someList.Count, new MyComparer());
        /// </code>
        /// </example>
        public void IsClampedExclusive<T>(T value, T min, T max, Comparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsClampedExclusive(value, min, max, comparer as IComparer<T>, customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given exclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="comparer">The <see cref="IComparer"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClampedExclusive(someIndex, -1, someList.Count, new MyComparer());
        /// </code>
        /// </example>
        public void IsClampedExclusive<T>(T value, T min, T max, IComparer comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            IsClampedExclusive(value, min, max, DynamicComparer.FromComparer<T>(comparer), customMessage, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="value"/> is clamped in a given exclusive range.
        /// </summary>
        /// <typeparam name="T">The type of the objects to compare.</typeparam>
        /// <param name="value">The value that is checked against the range.</param>
        /// <param name="min">The lower border of the range. Is considered lower than <paramref name="value"/> if null.</param>
        /// <param name="max">The upper border of the range. Is considered higher than <paramref name="value"/> if null.</param>
        /// <param name="comparer">The <see cref="IComparer{T}"/> to be used for comparison.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Value.IsClampedExclusive(someIndex, -1, someList.Count, new MyComparer());
        /// </code>
        /// </example>
        public void IsClampedExclusive<T>(T value, T min, T max, IComparer<T> comparer,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(value == null) {
                InternalFail($"Parameter '{nameof(value)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                InternalFail($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = comparer.IsClampedExclusive(value, min, max);

            } catch(Exception ex) {
                InternalFail($"Comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, $"[Value = {value.Format()}; Min = {min.Format()}; Max = {max.Format()}]",
                customMessage, _file, _method);
        }

        #endregion

    }
}
