using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    public partial class EnumerableTestSuite {

        #region IsEmpty

        /// <summary>
        /// Tests if <paramref name="enumeration"/> is empty.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        public void IsEmpty(IEnumerable enumeration,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            IsEmpty(enumeration.Cast<Object>(), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> is empty.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        public void IsEmpty<T>(IEnumerable<T> enumeration,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            Boolean result = enumeration.Count() == 0;

            InternalTest(result, String.Format("Enumeration is {0}empty. Enumeration is: {1}", result ? String.Empty : "not ", enumeration.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsNull

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a null element.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        public void ContainsNull(IEnumerable enumeration,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            ContainsNull(enumeration.Cast<Object>(), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a null element.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        public void ContainsNull<T>(IEnumerable<T> enumeration,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            Boolean result = false;

            foreach(T element in enumeration) {
                if(element == null) {
                    result = true;
                    break;
                }
            }

            InternalTest(result, String.Format("Enumeration {0} null. Enumeration is: {1}", result ? "contains" : "doesn't contain", enumeration.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsNonNull

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a non null element.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        public void ContainsNonNull(IEnumerable enumeration,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            ContainsNonNull(enumeration.Cast<Object>(), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a non null element.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        public void ContainsNonNull<T>(IEnumerable<T> enumeration,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            Boolean result = false;

            foreach(T element in enumeration) {
                if(element != null) {
                    result = true;
                    break;
                }
            }

            InternalTest(result, String.Format("Enumeration {0} a non null value. Enumeration is: {1}", result ? "contains" : "doesn't contain", enumeration.Format()),
                _file, _method);
        }

        #endregion

        #region Contains

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains <paramref name="element"/>.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="element">The <see cref="Object"/> to search for.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, someObject);
        /// </code>
        /// </example>
        public void Contains(IEnumerable enumeration, Object element,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            Contains(enumeration.Cast<Object>(), element, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains <paramref name="element"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="element">The element of type <typeparamref name="T"/> to search for.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, someObject);
        /// </code>
        /// </example>
        public void Contains<T>(IEnumerable<T> enumeration, T element,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            Boolean result = enumeration.Contains(element);

            InternalTest(result, String.Format("Enumeration {0} element {1}. Enumeration is: {2}", result ? "contains" : "doesn't contain", element.Format(), enumeration.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsComparer

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains <paramref name="element"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="element">The element of type <typeparamref name="T"/> to search for.</param>
        /// <param name="comparer">The <see cref="EqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, someObject, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void Contains<T>(IEnumerable<T> enumeration, T element, EqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Contains(enumeration, element, comparer as IEqualityComparer<T>, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains <paramref name="element"/>.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="element">The <see cref="Object"/> to search for.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, someObject, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void Contains(IEnumerable enumeration, Object element, IEqualityComparer comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Contains(enumeration.Cast<Object>(), element, DynamicEqualityComparer.FromComparer<Object>(comparer), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains <paramref name="element"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="element">The element of type <typeparamref name="T"/> to search for.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, someObject, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void Contains<T>(IEnumerable<T> enumeration, T element, IEqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = enumeration.Contains(element, comparer);

            } catch(Exception ex) {
                FailTest($"Comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, String.Format("Enumeration {0} element {1}. Enumeration is: {2}", result ? "contains" : "doesn't contain", element.Format(), enumeration.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsComparerKVP

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains <paramref name="element"/>.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{KeyValuePair}"/> that is checked.</param>
        /// <param name="element">The element of type <see cref="KeyValuePair{TKey, TValue}"/> to search for.</param>
        /// <param name="keyComparer">The <see cref="EqualityComparer{TKey}"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="EqualityComparer{TValue}"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, someObject, new MyKeyEqualityComparer(), new MyValueEqualityComparer());
        /// </code>
        /// </example>
        public void Contains<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> enumeration, KeyValuePair<TKey, TValue> element, EqualityComparer<TKey> keyComparer, EqualityComparer<TValue> valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            Contains(enumeration, element, keyComparer as IEqualityComparer<TKey>, valueComparer as IEqualityComparer<TValue>, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains <paramref name="element"/>.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable{DictionaryEntry}"/> that is checked.</param>
        /// <param name="element">The <see cref="DictionaryEntry"/> to search for.</param>
        /// <param name="keyComparer">The <see cref="IEqualityComparer"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="IEqualityComparer"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, someObject, new MyKeyEqualityComparer(), new MyValueEqualityComparer());
        /// </code>
        /// </example>
        public void Contains(IEnumerable<DictionaryEntry> enumeration, DictionaryEntry element, IEqualityComparer keyComparer, IEqualityComparer valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            Contains(enumeration.Select(de => new KeyValuePair<Object, Object>(de.Key, de.Value)), new KeyValuePair<Object, Object>(element.Key, element.Value),
                DynamicEqualityComparer.FromComparer<Object>(keyComparer), DynamicEqualityComparer.FromComparer<Object>(valueComparer), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains <paramref name="element"/>.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{KeyValuePair}"/> that is checked.</param>
        /// <param name="element">The element of type <see cref="KeyValuePair{TKey, TValue}"/> to search for.</param>
        /// <param name="keyComparer">The <see cref="IEqualityComparer{TKey}"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="IEqualityComparer{TValue}"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, someObject, new MyKeyEqualityComparer(), new MyValueEqualityComparer());
        /// </code>
        /// </example>
        public void Contains<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> enumeration, KeyValuePair<TKey, TValue> element, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            Boolean result = default;
            IEnumerable<TKey> keys = enumeration.Select(kvp => kvp.Key);

            try {
                result = keys.Contains(element.Key, keyComparer);

            } catch(Exception ex) {
                FailTest($"Key comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            if(!result) {
                InternalTest(result, String.Format("Enumeration {0} element with key {1}. Enumeration is: {2}", result ? "contains" : "doesn't contain", element.Key.Format(), enumeration.Format()),
                    _file, _method);
                return;
            }

            result = false;

            foreach(KeyValuePair<TKey, TValue> kvp in enumeration.Where(kvp => keyComparer.Equals(kvp.Key, element.Key))) {
                try {
                    if(valueComparer.Equals(kvp.Value, element.Value)) {
                        result = true;
                        break;
                    }

                } catch(Exception ex) {
                    FailTest($"Value comparer threw Exception: {ex.Message.Format()}",
                        _file, _method);
                    return;
                }
            }

            InternalTest(result, String.Format("Enumeration {0} element {1}. Enumeration is: {2}", result ? "contains" : "doesn't contain", element.Format(), enumeration.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsPredicate

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains an element matching <paramref name="match"/>.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="match">The <see cref="Predicate{Object}"/> used to filter for matches.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, new Predicate&lt;Object&gt;((element) => element as Int32 > 0));
        /// </code>
        /// </example>
        public void Contains(IEnumerable enumeration, Predicate<Object> match,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(match == null) {
                FailTest($"Parameter '{nameof(match)}' is null.", _file, _method);
                return;
            }

            Contains(enumeration.Cast<Object>(), match, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains an element matching <paramref name="match"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="match">The <see cref="Predicate{T}"/> used to filter for matches.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Contains(someEnumeration, new Predicate&lt;Int32&gt;((element) => element > 0));
        /// </code>
        /// </example>
        public void Contains<T>(IEnumerable<T> enumeration, Predicate<T> match,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(match == null) {
                FailTest($"Parameter '{nameof(match)}' is null.", _file, _method);
                return;
            }

            Boolean result = false;

            try {
                foreach(T element in enumeration) {
                    if(match(element)) {
                        result = true;
                        break;
                    }
                }

            } catch(Exception ex) {
                FailTest($"Predicate threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, String.Format("Enumeration {0} a matching element. Enumeration is: {1}", result ? "contains" : "doesn't contain", enumeration.Format()),
            _file, _method);

        }

        #endregion

        #region ContainsDuplicates

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains duplicate items.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsDuplicates(someEnumeration);
        /// </code>
        /// </example>
        public void ContainsDuplicates(IEnumerable enumeration,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            ContainsDuplicates(enumeration.Cast<Object>(), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains duplicate items.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsDuplicates(someEnumeration);
        /// </code>
        /// </example>
        public void ContainsDuplicates<T>(IEnumerable<T> enumeration,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            Boolean result = false;

            foreach(T element in enumeration) {
                if(enumeration.Where((other) => element.IsEqual(other)).Count() > 1) {
                    result = true;
                    break;
                }
            }

            InternalTest(result, String.Format("Enumeration {0} duplicates. Enumeration is: {1}", result ? "contains" : "doesn't contain", enumeration.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsDuplicatesComparer

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains duplicate items.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="comparer">The <see cref="EqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsDuplicates(someEnumeration, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsDuplicates<T>(IEnumerable<T> enumeration, EqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            ContainsDuplicates(enumeration, comparer as IEqualityComparer<T>, _file, _method);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsDuplicates(someEnumeration, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsDuplicates(IEnumerable enumeration, IEqualityComparer comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            ContainsDuplicates(enumeration.Cast<Object>(), DynamicEqualityComparer.FromComparer<Object>(comparer), _file, _method);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsDuplicates(someEnumeration, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsDuplicates<T>(IEnumerable<T> enumeration, IEqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Boolean result;

            try {
                result = enumeration.Distinct(comparer).Count() != enumeration.Count();

            } catch(Exception ex) {
                FailTest($"Comparer threw Exception: {ex.Message.Format()}",
                    _file, _method);
                return;
            }

            InternalTest(result, String.Format("Enumeration {0} duplicates. Enumeration is: {1}", result ? "contains" : "doesn't contain", enumeration.Format()),
                _file, _method);
        }

        #endregion

        #region ContainsRange

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a range of <paramref name="elements"/>.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="elements">The range of <see cref="Object"/> to search for.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsRange(someEnumeration, someCollection);
        /// </code>
        /// </example>
        public void ContainsRange(IEnumerable enumeration, IEnumerable elements,
        [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(elements == null) {
                FailTest($"Parameter '{nameof(elements)}' is null.", _file, _method);
                return;
            }

            ContainsRange(enumeration.Cast<Object>(), elements.Cast<Object>(), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a range of <paramref name="elements"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="elements">The <see cref="IEnumerable{T}"/> to search for.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsRange(someEnumeration, someCollection);
        /// </code>
        /// </example>
        public void ContainsRange<T>(IEnumerable<T> enumeration, IEnumerable<T> elements,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(elements == null) {
                FailTest($"Parameter '{nameof(elements)}' is null.", _file, _method);
                return;
            }

            Int32 elementsCount = 0;
            Int32 elementsFound = 0;

            foreach(T element in elements) {
                elementsCount++;

                if(enumeration.Contains(element)) {
                    elementsFound++;
                }
            }

            InternalTest(elementsCount == elementsFound, $"Enumeration contains {elementsFound} of {elementsCount} elements. Enumeration is: {enumeration.Format()}; Elements are: {elements.Format()}",
                _file, _method);
        }

        #endregion

        #region ContainsRangeComparer

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a range of <paramref name="elements"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="elements">The <see cref="IEnumerable{T}"/> to search for.</param>
        /// <param name="comparer">The <see cref="EqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsRange(someEnumeration, someCollection, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsRange<T>(IEnumerable<T> enumeration, IEnumerable<T> elements, EqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(elements == null) {
                FailTest($"Parameter '{nameof(elements)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            ContainsRange(enumeration, elements, comparer as IEqualityComparer<T>, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a range of <paramref name="elements"/>.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="elements">The <see cref="IEnumerable"/> to search for.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsRange(someEnumeration, someCollection, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsRange(IEnumerable enumeration, IEnumerable elements, IEqualityComparer comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(elements == null) {
                FailTest($"Parameter '{nameof(elements)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            ContainsRange(enumeration.Cast<Object>(), elements.Cast<Object>(), DynamicEqualityComparer.FromComparer<Object>(comparer), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a range of <paramref name="elements"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="elements">The <see cref="IEnumerable{T}"/> to search for.</param>
        /// <param name="comparer">´The <see cref="IEqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsRange(someEnumeration, someCollection, new MyEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsRange<T>(IEnumerable<T> enumeration, IEnumerable<T> elements, IEqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(elements == null) {
                FailTest($"Parameter '{nameof(elements)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Int32 elementsCount = 0;
            Int32 elementsFound = 0;


            foreach(T element in elements) {
                elementsCount++;
                Boolean contains = false;

                try {
                    contains = enumeration.Contains(element, comparer);

                } catch(Exception ex) {
                    FailTest($"Comparer threw Exception: {ex.Message.Format()}",
                        _file, _method);
                    return;
                }

                if(contains) { elementsFound++; }
            }

            InternalTest(elementsCount == elementsFound, $"Enumeration contains {elementsFound} of {elementsCount} elements. Enumeration is: {enumeration.Format()}; Elements are: {elements.Format()}",
                _file, _method);
        }

        #endregion

        #region ContainsRangeComparerKVP

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a range of <paramref name="elements"/>.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{KeyValuePair}"/> that is checked.</param>
        /// <param name="elements">The <see cref="IEnumerable{KeyValuePair}"/> to search for.</param>
        /// <param name="keyComparer">The <see cref="EqualityComparer{TKey}"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="EqualityComparer{TValue}"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsRange(someEnumeration, someCollection, new MyKeyEqualityComparer(), new MyValueEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsRange<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> enumeration, IEnumerable<KeyValuePair<TKey, TValue>> elements, EqualityComparer<TKey> keyComparer, EqualityComparer<TValue> valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(elements == null) {
                FailTest($"Parameter '{nameof(elements)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            ContainsRange(enumeration, elements, keyComparer as IEqualityComparer<TKey>, valueComparer as IEqualityComparer<TValue>, _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a range of <paramref name="elements"/>.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable{DictionaryEntry}"/> that is checked.</param>
        /// <param name="elements">The <see cref="IEnumerable{DictionaryEntry}"/> to search for.</param>
        /// <param name="keyComparer">The <see cref="IEqualityComparer"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="IEqualityComparer"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsRange(someEnumeration, someCollection, new MyKeyEqualityComparer(), new MyValueEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsRange(IEnumerable<DictionaryEntry> enumeration, IEnumerable<DictionaryEntry> elements, IEqualityComparer keyComparer, IEqualityComparer valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(elements == null) {
                FailTest($"Parameter '{nameof(elements)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            ContainsRange(enumeration.Select(de => new KeyValuePair<Object, Object>(de.Key, de.Value)), elements.Select(de => new KeyValuePair<Object, Object>(de.Key, de.Value)),
                DynamicEqualityComparer.FromComparer<Object>(keyComparer), DynamicEqualityComparer.FromComparer<Object>(valueComparer), _file, _method);
        }

        /// <summary>
        /// Tests if <paramref name="enumeration"/> contains a range of <paramref name="elements"/>.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{KeyValuePair}"/> that is checked.</param>
        /// <param name="elements">The <see cref="IEnumerable{KeyValuePair}"/> to search for.</param>
        /// <param name="keyComparer">The <see cref="IEqualityComparer{TKey}"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="IEqualityComparer{TValue}"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.ContainsRange(someEnumeration, someCollection, new MyKeyEqualityComparer(), new MyValueEqualityComparer());
        /// </code>
        /// </example>
        public void ContainsRange<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> enumeration, IEnumerable<KeyValuePair<TKey, TValue>> elements, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(elements == null) {
                FailTest($"Parameter '{nameof(elements)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            Int32 elementsCount = elements.Count();
            Int32 elementsFound = 0;


            foreach(KeyValuePair<TKey, TValue> element in elements) {
                IEnumerable<TKey> keys = enumeration.Select(kvp => kvp.Key);

                try {
                    if(!keys.Contains(element.Key, keyComparer)) {
                        break;
                    }

                } catch(Exception ex) {
                    FailTest($"Key comparer threw Exception: {ex.Message.Format()}",
                        _file, _method);
                    return;
                }

                IEnumerable<TValue> values = enumeration.Where(kvp => keyComparer.Equals(element.Key, kvp.Key)).Select(kvp => kvp.Value);

                try {
                    if(!values.Contains(element.Value, valueComparer)) {
                        break;
                    }

                } catch(Exception ex) {
                    FailTest($"Value comparer threw Exception: {ex.Message.Format()}",
                        _file, _method);
                    return;
                }

                elementsFound++;
            }

            InternalTest(elementsCount == elementsFound, $"Enumeration contains {elementsFound} of {elementsCount} elements. Enumeration is: {enumeration.Format()}; Elements are: {elements.Format()}",
                _file, _method);
        }

        #endregion

        #region Matches

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> ignoring order.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable"/> that is checked for.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration);
        /// </code>
        /// </example>
        public void Matches(IEnumerable enumeration, IEnumerable other,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            Matches(enumeration.Cast<Object>(), other.Cast<Object>(), _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> ignoring order.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{T}"/> that is checked for.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration);
        /// </code>
        /// </example>
        public void Matches<T>(IEnumerable<T> enumeration, IEnumerable<T> other,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            Int32 count1 = enumeration.Count();
            Int32 count2 = other.Count();
            Boolean result = count1 == 0 && count2 == 0;

            if(!result && count1 == count2) {
                result = true;
                List<T> otherAsList = other.ToList();

                foreach(T element in enumeration) {
                    if(otherAsList.Contains(element)) {
                        otherAsList.Remove(element);
                    } else {
                        result = false;
                        break;
                    }
                }
            }

            InternalTest(result, String.Format("Enumerations {0}. Enumeration is: {1}; Elements are: {2}", result ? "match" : "don't match", enumeration.Format(), other.Format()),
                _file, _method);
        }

        #endregion

        #region MatchesComparer

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> ignoring order.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{T}"/> that is checked for.</param>
        /// <param name="comparer">The <see cref="EqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void Matches<T>(IEnumerable<T> enumeration, IEnumerable<T> other, EqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Matches(enumeration, other, comparer as IEqualityComparer<T>, _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> ignoring order.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable"/> that is checked for.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void Matches(IEnumerable enumeration, IEnumerable other, IEqualityComparer comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Matches(enumeration.Cast<Object>(), other.Cast<Object>(), DynamicEqualityComparer.FromComparer<Object>(comparer), _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> ignoring order.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{T}"/> that is checked for.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void Matches<T>(IEnumerable<T> enumeration, IEnumerable<T> other, IEqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Int32 count1 = enumeration.Count();
            Int32 count2 = other.Count();
            Boolean result = count1 == 0 && count2 == 0;

            if(!result && count1 == count2) {
                result = true;
                List<T> otherAsList = other.ToList();

                foreach(T element in enumeration) {
                    Int32 index = -1;

                    try {
                        index = otherAsList.FindIndex(new Predicate<T>((_) => comparer.Equals(_, element)));

                    } catch(Exception ex) {
                        FailTest($"Comparer threw Exception: {ex.Message.Format()}",
                            _file, _method);
                        return;
                    }

                    if(index >= 0) {
                        otherAsList.RemoveAt(index);
                    } else {
                        result = false;
                        break;
                    }
                }
            }

            InternalTest(result, String.Format("Enumerations {0}. Enumeration is: {1}; Elements are: {2}", result ? "match" : "don't match", enumeration.Format(), other.Format()),
                _file, _method);
        }

        #endregion

        #region MatchesComparerKVP

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> ignoring order.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{KeyValuePair}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{KeyValuePair}"/> that is checked for.</param>
        /// <param name="keyComparer">The <see cref="EqualityComparer{TKey}"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="EqualityComparer{TValue}"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void Matches<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> enumeration, IEnumerable<KeyValuePair<TKey, TValue>> other, EqualityComparer<TKey> keyComparer, EqualityComparer<TValue> valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            Matches(enumeration, other, keyComparer as IEqualityComparer<TKey>, valueComparer as IEqualityComparer<TValue>, _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> ignoring order.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable{DictionaryEntry}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{DictionaryEntry}"/> that is checked for.</param>
        /// <param name="keyComparer">The <see cref="IEqualityComparer"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="IEqualityComparer"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void Matches(IEnumerable<DictionaryEntry> enumeration, IEnumerable<DictionaryEntry> other, IEqualityComparer keyComparer, IEqualityComparer valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            Matches(enumeration.Select(de => new KeyValuePair<Object, Object>(de.Key, de.Value)), other.Select(de => new KeyValuePair<Object, Object>(de.Key, de.Value)),
                DynamicEqualityComparer.FromComparer<Object>(keyComparer), DynamicEqualityComparer.FromComparer<Object>(valueComparer), _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> ignoring order.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{KeyValuePair}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{KeyValuePair}"/> that is checked for.</param>
        /// <param name="keyComparer">The <see cref="IEqualityComparer{TKey}"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="IEqualityComparer{TValue}"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void Matches<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> enumeration, IEnumerable<KeyValuePair<TKey, TValue>> other, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }
        }

        #endregion

        #region MatchesExactly

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> respecting order.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable"/> that is checked for.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.MatchesExactly(someEnumeration, someOtherEnumeration);
        /// </code>
        /// </example>
        public void MatchesExactly(IEnumerable enumeration, IEnumerable other,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            MatchesExactly(enumeration.Cast<Object>(), other.Cast<Object>(), _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> respecting order.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{T}"/> that is checked for.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.MatchesExactly(someEnumeration, someOtherEnumeration);
        /// </code>
        /// </example>
        public void MatchesExactly<T>(IEnumerable<T> enumeration, IEnumerable<T> other,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            Int32 count1 = enumeration.Count();
            Int32 count2 = other.Count();
            Boolean result = count1 == 0 && count2 == 0;

            if(!result && count1 == count2) {
                result = true;

                using IEnumerator<T> enum1 = enumeration.GetEnumerator();
                using IEnumerator<T> enum2 = other.GetEnumerator();

                while(enum1.MoveNext() && enum2.MoveNext()) {
                    T element1 = enum1.Current;
                    T element2 = enum2.Current;

                    if(!element1.IsEqual<T>(element2)) {
                        result = false;
                        break;
                    }
                }
            }

            InternalTest(result, String.Format("Enumerations {0}. Enumeration is: {1}; Elements are: {2}", result ? "match" : "don't match", enumeration.Format(), other.Format()),
                _file, _method);
        }

        #endregion

        #region MatchesExactlyComparer

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> respecting order.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{T}"/> that is checked for.</param>
        /// <param name="comparer">The <see cref="EqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.MatchesExactly(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void MatchesExactly<T>(IEnumerable<T> enumeration, IEnumerable<T> other, EqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            MatchesExactly(enumeration, other, comparer as IEqualityComparer<T>, _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> respecting order.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable"/> that is checked for.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.MatchesExactly(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void MatchesExactly(IEnumerable enumeration, IEnumerable other, IEqualityComparer comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            MatchesExactly(enumeration.Cast<Object>(), other.Cast<Object>(), DynamicEqualityComparer.FromComparer<Object>(comparer), _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> respecting order.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="enumeration"/>.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{T}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{T}"/> that is checked for.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> used to determine equality.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.MatchesExactly(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void MatchesExactly<T>(IEnumerable<T> enumeration, IEnumerable<T> other, IEqualityComparer<T> comparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(comparer == null) {
                FailTest($"Parameter '{nameof(comparer)}' is null.", _file, _method);
                return;
            }

            Int32 count1 = enumeration.Count();
            Int32 count2 = other.Count();
            Boolean result = count1 == 0 && count2 == 0;

            if(!result && count1 == count2) {
                result = true;

                using IEnumerator<T> enum1 = enumeration.GetEnumerator();
                using IEnumerator<T> enum2 = other.GetEnumerator();

                while(enum1.MoveNext() && enum2.MoveNext()) {
                    T element1 = enum1.Current;
                    T element2 = enum2.Current;
                    Boolean contains = false;

                    try {
                        contains = comparer.Equals(element1, element2);

                    } catch(Exception ex) {
                        FailTest($"Comparer threw Exception: {ex.Message.Format()}",
                            _file, _method);
                        return;
                    }

                    if(!contains) {
                        result = false;
                        break;
                    }
                }
            }

            InternalTest(result, String.Format("Enumerations {0}. Enumeration is: {1}; Elements are: {2}", result ? "match" : "don't match", enumeration.Format(), other.Format()),
                    _file, _method);
        }

        #endregion

        #region MatchesComparerKVP

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> respecting order.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{KeyValuePair}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{KeyValuePair}"/> that is checked for.</param>
        /// <param name="keyComparer">The <see cref="EqualityComparer{TKey}"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="EqualityComparer{TValue}"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void MatchesExactly<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> enumeration, IEnumerable<KeyValuePair<TKey, TValue>> other, EqualityComparer<TKey> keyComparer, EqualityComparer<TValue> valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            MatchesExactly(enumeration, other, keyComparer as IEqualityComparer<TKey>, valueComparer as IEqualityComparer<TValue>, _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> respecting order.
        /// </summary>
        /// <param name="enumeration">The <see cref="IEnumerable{DictionaryEntry}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{DictionaryEntry}"/> that is checked for.</param>
        /// <param name="keyComparer">The <see cref="IEqualityComparer"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="IEqualityComparer"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void MatchesExactly(IEnumerable<DictionaryEntry> enumeration, IEnumerable<DictionaryEntry> other, IEqualityComparer keyComparer, IEqualityComparer valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }

            MatchesExactly(enumeration.Select(de => new KeyValuePair<Object, Object>(de.Key, de.Value)), other.Select(de => new KeyValuePair<Object, Object>(de.Key, de.Value)),
                DynamicEqualityComparer.FromComparer<Object>(keyComparer), DynamicEqualityComparer.FromComparer<Object>(valueComparer), _file, _method);
        }

        /// <summary>
        /// Tests if the elements of <paramref name="enumeration"/> match the elements of <paramref name="other"/> respecting order.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="enumeration">The <see cref="IEnumerable{KeyValuePair}"/> that is checked.</param>
        /// <param name="other">The other <see cref="IEnumerable{KeyValuePair}"/> that is checked for.</param>
        /// <param name="keyComparer">The <see cref="IEqualityComparer{TKey}"/> used to determine equality of the key.</param>
        /// <param name="valueComparer">The <see cref="IEqualityComparer{TValue}"/> used to determine equality of the value.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Enumeration.Matches(someEnumeration, someOtherEnumeration, new MyComparer());
        /// </code>
        /// </example>
        public void MatchesExactly<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> enumeration, IEnumerable<KeyValuePair<TKey, TValue>> other, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer,
            [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(enumeration == null) {
                FailTest($"Parameter '{nameof(enumeration)}' is null.", _file, _method);
                return;
            }

            if(other == null) {
                FailTest($"Parameter '{nameof(other)}' is null.", _file, _method);
                return;
            }

            if(keyComparer == null) {
                FailTest($"Parameter '{nameof(keyComparer)}' is null.", _file, _method);
                return;
            }

            if(valueComparer == null) {
                FailTest($"Parameter '{nameof(valueComparer)}' is null.", _file, _method);
                return;
            }
        }

        #endregion

    }
}
