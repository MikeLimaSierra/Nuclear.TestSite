using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;

namespace Nuclear.TestSite.TestSuites {
    public partial class TypeTestSuite {

        #region Implements

        /// <summary>
        /// Tests if <typeparamref name="TType"/> implements <typeparamref name="TInterface"/>.
        /// </summary>
        /// <typeparam name="TType">The type to be checked.</typeparam>
        /// <typeparam name="TInterface">The interface to be implemented.</typeparam>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Type.Implements&lt;MyClass, IDisposable&gt;();
        /// </code>
        /// </example>
        public void Implements<TType, TInterface>(String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
            => Implements(typeof(TType), typeof(TInterface), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="type"/> implements <paramref name="interface"/>.
        /// </summary>
        /// <param name="type">The type to be checked.</param>
        /// <param name="interface">The interface to be implemented.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Type.Implements(obj.GetType(), typeof(IDisposable));
        /// </code>
        /// </example>
        public void Implements(Type type, Type @interface,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(type == null) {
                InternalFail($"Parameter '{nameof(type)}' is null.", _file, _method);
                return;
            }

            if(@interface == null) {
                InternalFail($"Parameter '{nameof(@interface)}' is null.", _file, _method);
                return;
            }

            if(!@interface.IsInterface) {
                InternalFail($"Type {@interface.Format()} is not an interface.",
                    _file, _method);
                return;
            }

            Boolean result = type.GetInterfaces().Where(_interface => _interface.Equals(@interface)).Count() > 0;
            InternalTest(result, String.Format("Type {0} {1} interface {2}.", type.Format(), result ? "implements" : "doesn't implement", @interface.Format()),
                customMessage, _file, _method);
        }

        #endregion

        #region IsSubClass

        /// <summary>
        /// Tests if <typeparamref name="TType"/> inherits from <typeparamref name="TBase"/>.
        /// </summary>
        /// <typeparam name="TType">The type to be checked.</typeparam>
        /// <typeparam name="TBase">The base class to be inherited from.</typeparam>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Type.IsSubClass&lt;MyClass, MyBaseClass&gt;();
        /// </code>
        /// </example>
        public void IsSubClass<TType, TBase>(String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null)
         => IsSubClass(typeof(TType), typeof(TBase), customMessage, _file, _method);

        /// <summary>
        /// Tests if <paramref name="type"/> inherits from <paramref name="baseType"/>.
        /// </summary>
        /// <param name="type">The type to be checked.</param>
        /// <param name="baseType">The base class to be inherited from.</param>
        /// <param name="customMessage">A custom message that will be used instead of the default message.
        ///   The message will only be used if the instruction fails on the actual result.
        ///   The message will not be used if the instruction failed due to faulty input.</param>
        /// <param name="_file">The file name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <param name="_method">The name of the caller. Do not use in methods decorated with <see cref="TestMethodAttribute"/>!</param>
        /// <example>
        /// <code>
        /// Test.If.Type.IsSubClass(obj.GetType(), typeof(MyBaseClass));
        /// </code>
        /// </example>
        public void IsSubClass(Type type, Type baseType,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(type == null) {
                InternalFail($"Parameter '{nameof(type)}' is null.", _file, _method);
                return;
            }

            if(baseType == null) {
                InternalFail($"Parameter '{nameof(baseType)}' is null.", _file, _method);
                return;
            }

            if(!type.IsClass) {
                InternalFail($"Type {type.Format()} is not a class.",
                    _file, _method);
                return;
            }

            if(!baseType.IsClass) {
                InternalFail($"Type {baseType.Format()} is not a class.",
                    _file, _method);
                return;
            }

            Boolean result = type.IsSubclassOf(baseType);
            InternalTest(result, String.Format("Type {0} is {1}subclass of {2}.", type.Format(), result ? "" : "no ", baseType.Format()),
                customMessage, _file, _method);
        }

        #endregion

    }
}
