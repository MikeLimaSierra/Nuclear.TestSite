using System;

namespace Nuclear.TestSite.TestSuites {
    class StringTestSuit_uTests {

        #region StartsWith

        [TestMethod]
        [TestParameters(null, 'x', 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', 2, false, "[String = ''; Value = 'x']")]
        [TestParameters("ax", 'x', 3, false, "[String = 'ax'; Value = 'x']")]
        [TestParameters("xa", 'x', 4, true, "[String = 'xa'; Value = 'x']")]
        void StartsWithChar(String input1, Char input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.StartsWith(input1, input2),
                (count, result, message), "Test.If.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, 'x', 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', 2, true, "[String = ''; Value = 'x']")]
        [TestParameters("ax", 'x', 3, true, "[String = 'ax'; Value = 'x']")]
        [TestParameters("xa", 'x', 4, false, "[String = 'xa'; Value = 'x']")]
        void NotStartsWithChar(String input1, Char input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.StartsWith(input1, input2),
                (count, result, message), "Test.IfNot.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", 4, true, "[String = ''; Value = '']")]
        [TestParameters("", "xy", 5, false, "[String = ''; Value = 'xy']")]
        [TestParameters("xy", "", 6, true, "[String = 'xy'; Value = '']")]
        [TestParameters("axy", "xy", 7, false, "[String = 'axy'; Value = 'xy']")]
        [TestParameters("xya", "xy", 8, true, "[String = 'xya'; Value = 'xy']")]
        void StartsWithString(String input1, String input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.StartsWith(input1, input2),
                (count, result, message), "Test.If.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", 4, false, "[String = ''; Value = '']")]
        [TestParameters("", "xy", 5, true, "[String = ''; Value = 'xy']")]
        [TestParameters("xy", "", 6, false, "[String = 'xy'; Value = '']")]
        [TestParameters("axy", "xy", 7, true, "[String = 'axy'; Value = 'xy']")]
        [TestParameters("xya", "xy", 8, false, "[String = 'xya'; Value = 'xy']")]
        void NotStartsWithString(String input1, String input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.StartsWith(input1, input2),
                (count, result, message), "Test.IfNot.String.StartsWith");

        }

        #endregion

        #region StartsWithWithMessage

        [TestMethod]
        [TestParameters(null, 'x', "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters("ax", 'x', "message", 2, false, "message")]
        [TestParameters("xa", 'x', "message", 3, true, "[String = 'xa'; Value = 'x']")]
        void StartsWithCharWithMessage(String input1, Char input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.StartsWith(input1, input2, customMessage),
                (count, result, message), "Test.If.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, 'x', "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters("ax", 'x', "message", 2, true, "[String = 'ax'; Value = 'x']")]
        [TestParameters("xa", 'x', "message", 3, false, "message")]
        void NotStartsWithCharWithMessage(String input1, Char input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.StartsWith(input1, input2, customMessage),
                (count, result, message), "Test.IfNot.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", "message", 4, true, "[String = ''; Value = '']")]
        [TestParameters("", "xy", "message", 5, false, "message")]
        void StartsWithStringWithMessage(String input1, String input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.StartsWith(input1, input2, customMessage),
                (count, result, message), "Test.If.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", "message", 4, false, "message")]
        [TestParameters("", "xy", "message", 5, true, "[String = ''; Value = 'xy']")]
        void NotStartsWithStringWithMessage(String input1, String input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.StartsWith(input1, input2, customMessage),
                (count, result, message), "Test.IfNot.String.StartsWith");

        }

        #endregion

        #region StartsWithComparison

        [TestMethod]
        [TestParameters(null, 'x', StringComparison.CurrentCulture, 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', (StringComparison) 10, 2, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", 'x', StringComparison.CurrentCulture, 3, false, "[String = ''; Value = 'x']")]
        [TestParameters("ax", 'x', StringComparison.CurrentCulture, 4, false, "[String = 'ax'; Value = 'x']")]
        [TestParameters("xa", 'x', StringComparison.CurrentCulture, 5, true, "[String = 'xa'; Value = 'x']")]
        [TestParameters("Xa", 'x', StringComparison.CurrentCulture, 6, false, "[String = 'Xa'; Value = 'x']")]
        [TestParameters("Xa", 'x', StringComparison.CurrentCultureIgnoreCase, 7, true, "[String = 'Xa'; Value = 'x'; ComparisonType = 'CurrentCultureIgnoreCase']")]
        void StartsWithCharComparison(String input1, Char input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.StartsWith(input1, input2, input3),
                (count, result, message), "Test.If.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, 'x', StringComparison.CurrentCulture, 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', (StringComparison) 10, 2, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", 'x', StringComparison.CurrentCulture, 3, true, "[String = ''; Value = 'x']")]
        [TestParameters("ax", 'x', StringComparison.CurrentCulture, 4, true, "[String = 'ax'; Value = 'x']")]
        [TestParameters("xa", 'x', StringComparison.CurrentCulture, 5, false, "[String = 'xa'; Value = 'x']")]
        [TestParameters("Xa", 'x', StringComparison.CurrentCulture, 6, true, "[String = 'Xa'; Value = 'x']")]
        [TestParameters("Xa", 'x', StringComparison.CurrentCultureIgnoreCase, 7, false, "[String = 'Xa'; Value = 'x'; ComparisonType = 'CurrentCultureIgnoreCase']")]
        void NotStartsWithCharComparison(String input1, Char input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.StartsWith(input1, input2, input3),
                (count, result, message), "Test.IfNot.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, null, StringComparison.CurrentCulture, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", StringComparison.CurrentCulture, 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, StringComparison.CurrentCulture, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 10, 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.CurrentCulture, 5, true, "[String = ''; Value = '']")]
        [TestParameters("", "xy", StringComparison.CurrentCulture, 6, false, "[String = ''; Value = 'xy']")]
        [TestParameters("xy", "", StringComparison.CurrentCulture, 7, true, "[String = 'xy'; Value = '']")]
        [TestParameters("axy", "xy", StringComparison.CurrentCulture, 8, false, "[String = 'axy'; Value = 'xy']")]
        [TestParameters("xya", "xy", StringComparison.CurrentCulture, 9, true, "[String = 'xya'; Value = 'xy']")]
        [TestParameters("Xya", "xy", StringComparison.CurrentCulture, 10, false, "[String = 'Xya'; Value = 'xy']")]
        [TestParameters("Xya", "xy", StringComparison.CurrentCultureIgnoreCase, 11, true, "[String = 'Xya'; Value = 'xy'; ComparisonType = 'CurrentCultureIgnoreCase']")]
        void StartsWithStringComparison(String input1, String input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.StartsWith(input1, input2, input3),
                (count, result, message), "Test.If.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, null, StringComparison.CurrentCulture, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", StringComparison.CurrentCulture, 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, StringComparison.CurrentCulture, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 10, 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.CurrentCulture, 5, false, "[String = ''; Value = '']")]
        [TestParameters("", "xy", StringComparison.CurrentCulture, 6, true, "[String = ''; Value = 'xy']")]
        [TestParameters("xy", "", StringComparison.CurrentCulture, 7, false, "[String = 'xy'; Value = '']")]
        [TestParameters("axy", "xy", StringComparison.CurrentCulture, 8, true, "[String = 'axy'; Value = 'xy']")]
        [TestParameters("xya", "xy", StringComparison.CurrentCulture, 9, false, "[String = 'xya'; Value = 'xy']")]
        [TestParameters("Xya", "xy", StringComparison.CurrentCulture, 10, true, "[String = 'Xya'; Value = 'xy']")]
        [TestParameters("Xya", "xy", StringComparison.CurrentCultureIgnoreCase, 11, false, "[String = 'Xya'; Value = 'xy'; ComparisonType = 'CurrentCultureIgnoreCase']")]
        void NotStartsWithStringComparison(String input1, String input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.StartsWith(input1, input2, input3),
                (count, result, message), "Test.IfNot.String.StartsWith");

        }

        #endregion

        #region StartsWithComparisonWithMessage

        [TestMethod]
        [TestParameters(null, 'x', StringComparison.CurrentCulture, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', (StringComparison) 10, "message", 2, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("ax", 'x', StringComparison.CurrentCulture, "message", 3, false, "message")]
        [TestParameters("xa", 'x', StringComparison.CurrentCulture, "message", 4, true, "[String = 'xa'; Value = 'x']")]
        void StartsWithCharComparisonWithMessage(String input1, Char input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.StartsWith(input1, input2, input3, customMessage),
                (count, result, message), "Test.If.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, 'x', StringComparison.CurrentCulture, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', (StringComparison) 10, "message", 2, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("ax", 'x', StringComparison.CurrentCulture, "message", 3, true, "[String = 'ax'; Value = 'x']")]
        [TestParameters("xa", 'x', StringComparison.CurrentCulture, "message", 4, false, "message")]
        void NotStartsWithCharComparisonWithMessage(String input1, Char input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.StartsWith(input1, input2, input3, customMessage),
                (count, result, message), "Test.IfNot.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, null, StringComparison.CurrentCulture, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", StringComparison.CurrentCulture, "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, StringComparison.CurrentCulture, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 10, "message", 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.CurrentCulture, "message", 5, true, "[String = ''; Value = '']")]
        [TestParameters("", "xy", StringComparison.CurrentCulture, "message", 6, false, "message")]
        void StartsWithStringComparisonWithMessage(String input1, String input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.StartsWith(input1, input2, input3, customMessage),
                (count, result, message), "Test.If.String.StartsWith");

        }

        [TestMethod]
        [TestParameters(null, null, StringComparison.CurrentCulture, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", StringComparison.CurrentCulture, "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, StringComparison.CurrentCulture, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 10, "message", 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.CurrentCulture, "message", 5, false, "message")]
        [TestParameters("", "xy", StringComparison.CurrentCulture, "message", 6, true, "[String = ''; Value = 'xy']")]
        void NotStartsWithStringComparisonWithMessage(String input1, String input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.StartsWith(input1, input2, input3, customMessage),
                (count, result, message), "Test.IfNot.String.StartsWith");

        }

        #endregion

        #region EndsWith

        [TestMethod]
        [TestParameters(null, 'x', 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', 2, false, "[String = ''; Value = 'x']")]
        [TestParameters("ax", 'x', 3, true, "[String = 'ax'; Value = 'x']")]
        [TestParameters("xa", 'x', 4, false, "[String = 'xa'; Value = 'x']")]
        void EndsWithChar(String input1, Char input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.EndsWith(input1, input2),
                (count, result, message), "Test.If.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, 'x', 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', 2, true, "[String = ''; Value = 'x']")]
        [TestParameters("ax", 'x', 3, false, "[String = 'ax'; Value = 'x']")]
        [TestParameters("xa", 'x', 4, true, "[String = 'xa'; Value = 'x']")]
        void NotEndsWithChar(String input1, Char input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.EndsWith(input1, input2),
                (count, result, message), "Test.IfNot.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", 4, true, "[String = ''; Value = '']")]
        [TestParameters("", "xy", 5, false, "[String = ''; Value = 'xy']")]
        [TestParameters("xy", "", 6, true, "[String = 'xy'; Value = '']")]
        [TestParameters("axy", "xy", 7, true, "[String = 'axy'; Value = 'xy']")]
        [TestParameters("xya", "xy", 8, false, "[String = 'xya'; Value = 'xy']")]
        void EndsWithString(String input1, String input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.EndsWith(input1, input2),
                (count, result, message), "Test.If.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", 4, false, "[String = ''; Value = '']")]
        [TestParameters("", "xy", 5, true, "[String = ''; Value = 'xy']")]
        [TestParameters("xy", "", 6, false, "[String = 'xy'; Value = '']")]
        [TestParameters("axy", "xy", 7, false, "[String = 'axy'; Value = 'xy']")]
        [TestParameters("xya", "xy", 8, true, "[String = 'xya'; Value = 'xy']")]
        void NotEndsWithString(String input1, String input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.EndsWith(input1, input2),
                (count, result, message), "Test.IfNot.String.EndsWith");

        }

        #endregion

        #region EndsWithWithMessage

        [TestMethod]
        [TestParameters(null, 'x', "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', "message", 2, false, "message")]
        [TestParameters("ax", 'x', "message", 3, true, "[String = 'ax'; Value = 'x']")]
        void EndsWithCharWithMessage(String input1, Char input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.EndsWith(input1, input2, customMessage),
                (count, result, message), "Test.If.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, 'x', "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', "message", 2, true, "[String = ''; Value = 'x']")]
        [TestParameters("ax", 'x', "message", 3, false, "message")]
        void NotEndsWithCharWithMessage(String input1, Char input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.EndsWith(input1, input2, customMessage),
                (count, result, message), "Test.IfNot.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", "message", 4, true, "[String = ''; Value = '']")]
        [TestParameters("", "xy", "message", 5, false, "message")]
        void EndsWithStringWithMessage(String input1, String input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.EndsWith(input1, input2, customMessage),
                (count, result, message), "Test.If.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", "message", 4, false, "message")]
        [TestParameters("", "xy", "message", 5, true, "[String = ''; Value = 'xy']")]
        void NotEndsWithStringWithMessage(String input1, String input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.EndsWith(input1, input2, customMessage),
                (count, result, message), "Test.IfNot.String.EndsWith");

        }

        #endregion

        #region EndsWithComparison

        [TestMethod]
        [TestParameters(null, 'x', StringComparison.CurrentCulture, 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', (StringComparison) 10, 2, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", 'x', StringComparison.CurrentCulture, 3, false, "[String = ''; Value = 'x']")]
        [TestParameters("xa", 'x', StringComparison.CurrentCulture, 4, false, "[String = 'xa'; Value = 'x']")]
        [TestParameters("ax", 'x', StringComparison.CurrentCulture, 5, true, "[String = 'ax'; Value = 'x']")]
        [TestParameters("aX", 'x', StringComparison.CurrentCulture, 6, false, "[String = 'aX'; Value = 'x']")]
        [TestParameters("aX", 'x', StringComparison.CurrentCultureIgnoreCase, 7, true, "[String = 'aX'; Value = 'x'; ComparisonType = 'CurrentCultureIgnoreCase']")]
        void EndsWithCharComparison(String input1, Char input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.EndsWith(input1, input2, input3),
                (count, result, message), "Test.If.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, 'x', StringComparison.CurrentCulture, 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', (StringComparison) 10, 2, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", 'x', StringComparison.CurrentCulture, 3, true, "[String = ''; Value = 'x']")]
        [TestParameters("xa", 'x', StringComparison.CurrentCulture, 4, true, "[String = 'xa'; Value = 'x']")]
        [TestParameters("ax", 'x', StringComparison.CurrentCulture, 5, false, "[String = 'ax'; Value = 'x']")]
        [TestParameters("aX", 'x', StringComparison.CurrentCulture, 6, true, "[String = 'aX'; Value = 'x']")]
        [TestParameters("aX", 'x', StringComparison.CurrentCultureIgnoreCase, 7, false, "[String = 'aX'; Value = 'x'; ComparisonType = 'CurrentCultureIgnoreCase']")]
        void NotEndsWithCharComparison(String input1, Char input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.EndsWith(input1, input2, input3),
                (count, result, message), "Test.IfNot.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, null, StringComparison.CurrentCulture, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", StringComparison.CurrentCulture, 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, StringComparison.CurrentCulture, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 10, 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.CurrentCulture, 5, true, "[String = ''; Value = '']")]
        [TestParameters("", "xy", StringComparison.CurrentCulture, 6, false, "[String = ''; Value = 'xy']")]
        [TestParameters("xy", "", StringComparison.CurrentCulture, 7, true, "[String = 'xy'; Value = '']")]
        [TestParameters("xya", "xy", StringComparison.CurrentCulture, 8, false, "[String = 'xya'; Value = 'xy']")]
        [TestParameters("axy", "xy", StringComparison.CurrentCulture, 9, true, "[String = 'axy'; Value = 'xy']")]
        [TestParameters("aXy", "xy", StringComparison.CurrentCulture, 10, false, "[String = 'aXy'; Value = 'xy']")]
        [TestParameters("aXy", "xy", StringComparison.CurrentCultureIgnoreCase, 11, true, "[String = 'aXy'; Value = 'xy'; ComparisonType = 'CurrentCultureIgnoreCase']")]
        void EndsWithStringComparison(String input1, String input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.EndsWith(input1, input2, input3),
                (count, result, message), "Test.If.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, null, StringComparison.CurrentCulture, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", StringComparison.CurrentCulture, 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, StringComparison.CurrentCulture, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 10, 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.CurrentCulture, 5, false, "[String = ''; Value = '']")]
        [TestParameters("", "xy", StringComparison.CurrentCulture, 6, true, "[String = ''; Value = 'xy']")]
        [TestParameters("xy", "", StringComparison.CurrentCulture, 7, false, "[String = 'xy'; Value = '']")]
        [TestParameters("xya", "xy", StringComparison.CurrentCulture, 8, true, "[String = 'xya'; Value = 'xy']")]
        [TestParameters("axy", "xy", StringComparison.CurrentCulture, 9, false, "[String = 'axy'; Value = 'xy']")]
        [TestParameters("aXy", "xy", StringComparison.CurrentCulture, 10, true, "[String = 'aXy'; Value = 'xy']")]
        [TestParameters("aXy", "xy", StringComparison.CurrentCultureIgnoreCase, 11, false, "[String = 'aXy'; Value = 'xy'; ComparisonType = 'CurrentCultureIgnoreCase']")]
        void NotEndsWithStringComparison(String input1, String input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.EndsWith(input1, input2, input3),
                (count, result, message), "Test.IfNot.String.EndsWith");

        }

        #endregion

        #region EndsWithComparisonWithMessage

        [TestMethod]
        [TestParameters(null, 'x', StringComparison.CurrentCulture, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', (StringComparison) 10, "message", 2, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("xa", 'x', StringComparison.CurrentCulture, "message", 3, false, "message")]
        [TestParameters("ax", 'x', StringComparison.CurrentCulture, "message", 4, true, "[String = 'ax'; Value = 'x']")]
        void EndsWithCharComparisonWithMessage(String input1, Char input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.EndsWith(input1, input2, input3, customMessage),
                (count, result, message), "Test.If.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, 'x', StringComparison.CurrentCulture, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 'x', (StringComparison) 10, "message", 2, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("xa", 'x', StringComparison.CurrentCulture, "message", 3, true, "[String = 'xa'; Value = 'x']")]
        [TestParameters("ax", 'x', StringComparison.CurrentCulture, "message", 4, false, "message")]
        void NotEndsWithCharComparisonWithMessage(String input1, Char input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.EndsWith(input1, input2, input3, customMessage),
                (count, result, message), "Test.IfNot.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, null, StringComparison.CurrentCulture, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", StringComparison.CurrentCulture, "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, StringComparison.CurrentCulture, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 10, "message", 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.CurrentCulture, "message", 5, true, "[String = ''; Value = '']")]
        [TestParameters("", "xy", StringComparison.CurrentCulture, "message", 6, false, "message")]
        void EndsWithStringComparisonWithMessage(String input1, String input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.EndsWith(input1, input2, input3, customMessage),
                (count, result, message), "Test.If.String.EndsWith");

        }

        [TestMethod]
        [TestParameters(null, null, StringComparison.CurrentCulture, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "xy", StringComparison.CurrentCulture, "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("axy", null, StringComparison.CurrentCulture, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 10, "message", 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.CurrentCulture, "message", 5, false, "message")]
        [TestParameters("", "xy", StringComparison.CurrentCulture, "message", 6, true, "[String = ''; Value = 'xy']")]
        void NotEndsWithStringComparisonWithMessage(String input1, String input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.EndsWith(input1, input2, input3, customMessage),
                (count, result, message), "Test.IfNot.String.EndsWith");

        }

        #endregion

        #region NullOrEmpty

        [TestMethod]
        [TestParameters(null, 1, true, "[String = null]")]
        [TestParameters("", 2, true, "[String = '']")]
        [TestParameters(" ", 3, false, "[String = ' ']")]
        [TestParameters("content", 4, false, "[String = 'content']")]
        void IsNOE(String input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.IsNullOrEmpty(input),
                (count, result, message), "Test.If.String.IsNullOrEmpty");

        }

        [TestMethod]
        [TestParameters(null, 1, false, "[String = null]")]
        [TestParameters("", 2, false, "[String = '']")]
        [TestParameters(" ", 3, true, "[String = ' ']")]
        [TestParameters("content", 4, true, "[String = 'content']")]
        void IsNotNOE(String input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.IsNullOrEmpty(input),
                (count, result, message), "Test.IfNot.String.IsNullOrEmpty");

        }

        #endregion

        #region NullOrEmptyWithMessage

        [TestMethod]
        [TestParameters(null, "message", 1, true, "[String = null]")]
        [TestParameters(" ", "message", 2, false, "message")]
        void IsNOEWithMessage(String input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.IsNullOrEmpty(input, customMessage),
                (count, result, message), "Test.If.String.IsNullOrEmpty");

        }

        [TestMethod]
        [TestParameters(null, "message", 1, false, "message")]
        [TestParameters(" ", "message", 2, true, "[String = ' ']")]
        void IsNotNOEWithMessage(String input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.IsNullOrEmpty(input, customMessage),
                (count, result, message), "Test.IfNot.String.IsNullOrEmpty");

        }

        #endregion

        #region NullOrWhiteSpace

        [TestMethod]
        [TestParameters(null, 1, true, "[String = null]")]
        [TestParameters("", 2, true, "[String = '']")]
        [TestParameters(" ", 3, true, "[String = ' ']")]
        [TestParameters("content", 4, false, "[String = 'content']")]
        void IsNOW(String input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.IsNullOrWhiteSpace(input),
                (count, result, message), "Test.If.String.IsNullOrWhiteSpace");

        }

        [TestMethod]
        [TestParameters(null, 1, false, "[String = null]")]
        [TestParameters("", 2, false, "[String = '']")]
        [TestParameters(" ", 3, false, "[String = ' ']")]
        [TestParameters("content", 4, true, "[String = 'content']")]
        void IsNotNOW(String input, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.IsNullOrWhiteSpace(input),
                (count, result, message), "Test.IfNot.String.IsNullOrWhiteSpace");

        }

        #endregion

        #region NullOrWhiteSpaceWithMessage

        [TestMethod]
        [TestParameters(null, "message", 1, true, "[String = null]")]
        [TestParameters("content", "message", 2, false, "message")]
        void IsNOWWithMessage(String input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.IsNullOrWhiteSpace(input, customMessage),
                (count, result, message), "Test.If.String.IsNullOrWhiteSpace");

        }

        [TestMethod]
        [TestParameters(null, "message", 1, false, "message")]
        [TestParameters("content", "message", 2, true, "[String = 'content']")]
        void IsNotNOWWithMessage(String input, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.IsNullOrWhiteSpace(input, customMessage),
                (count, result, message), "Test.IfNot.String.IsNullOrWhiteSpace");

        }

        #endregion

        #region Contains

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "abc", 2, false, "Parameter 'string' is null.")]
        [TestParameters("abc", null, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", 4, true, "[String = ''; Value = ''; Comparison = 'CurrentCulture']")]
        [TestParameters("", "abc", 5, false, "[String = ''; Value = 'abc'; Comparison = 'CurrentCulture']")]
        [TestParameters("abc", "", 6, true, "[String = 'abc'; Value = ''; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "abcd", 7, true, "[String = 'abcd'; Value = 'abcd'; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "ab", 8, true, "[String = 'abcd'; Value = 'ab'; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "cd", 9, true, "[String = 'abcd'; Value = 'cd'; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "bc", 10, true, "[String = 'abcd'; Value = 'bc'; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "cb", 11, false, "[String = 'abcd'; Value = 'cb'; Comparison = 'CurrentCulture']")]
        void Contains(String input1, String input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.Contains(input1, input2),
                (count, result, message), "Test.If.String.Contains");

        }

        [TestMethod]
        [TestParameters(null, null, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "abc", 2, false, "Parameter 'string' is null.")]
        [TestParameters("abc", null, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", 4, false, "[String = ''; Value = ''; Comparison = 'CurrentCulture']")]
        [TestParameters("", "abc", 5, true, "[String = ''; Value = 'abc'; Comparison = 'CurrentCulture']")]
        [TestParameters("abc", "", 6, false, "[String = 'abc'; Value = ''; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "abcd", 7, false, "[String = 'abcd'; Value = 'abcd'; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "ab", 8, false, "[String = 'abcd'; Value = 'ab'; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "cd", 9, false, "[String = 'abcd'; Value = 'cd'; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "bc", 10, false, "[String = 'abcd'; Value = 'bc'; Comparison = 'CurrentCulture']")]
        [TestParameters("abcd", "cb", 11, true, "[String = 'abcd'; Value = 'cb'; Comparison = 'CurrentCulture']")]
        void NotContains(String input1, String input2, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.Contains(input1, input2),
                (count, result, message), "Test.IfNot.String.Contains");

        }

        #endregion

        #region ContainsWithMessage

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "abc", "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("abc", null, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", "message", 4, true, "[String = ''; Value = ''; Comparison = 'CurrentCulture']")]
        [TestParameters("", "abc", "message", 5, false, "message")]
        void ContainsWithMessage(String input1, String input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.Contains(input1, input2, customMessage),
                (count, result, message), "Test.If.String.Contains");

        }

        [TestMethod]
        [TestParameters(null, null, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "abc", "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("abc", null, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", "message", 4, false, "message")]
        [TestParameters("", "abc", "message", 5, true, "[String = ''; Value = 'abc'; Comparison = 'CurrentCulture']")]
        void NotContainsWithMessage(String input1, String input2, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.Contains(input1, input2, customMessage),
                (count, result, message), "Test.IfNot.String.Contains");

        }

        #endregion

        #region ContainsWithComparison

        [TestMethod]
        [TestParameters(null, null, (StringComparison) 1000, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "abc", StringComparison.Ordinal, 2, false, "Parameter 'string' is null.")]
        [TestParameters("abc", null, StringComparison.Ordinal, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 1000, 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.InvariantCulture, 5, true, "[String = ''; Value = ''; Comparison = 'InvariantCulture']")]
        [TestParameters("", "abc", StringComparison.InvariantCulture, 6, false, "[String = ''; Value = 'abc'; Comparison = 'InvariantCulture']")]
        [TestParameters("abc", "", StringComparison.InvariantCulture, 7, true, "[String = 'abc'; Value = ''; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "abcd", StringComparison.InvariantCulture, 8, true, "[String = 'abcd'; Value = 'abcd'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "ab", StringComparison.InvariantCulture, 9, true, "[String = 'abcd'; Value = 'ab'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "cd", StringComparison.InvariantCulture, 10, true, "[String = 'abcd'; Value = 'cd'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "bc", StringComparison.InvariantCulture, 11, true, "[String = 'abcd'; Value = 'bc'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "cb", StringComparison.InvariantCulture, 12, false, "[String = 'abcd'; Value = 'cb'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "Bc", StringComparison.InvariantCulture, 13, false, "[String = 'abcd'; Value = 'Bc'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "Bc", StringComparison.InvariantCultureIgnoreCase, 14, true, "[String = 'abcd'; Value = 'Bc'; Comparison = 'InvariantCultureIgnoreCase']")]
        void ContainsWithComparison(String input1, String input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.Contains(input1, input2, input3),
                (count, result, message), "Test.If.String.Contains");

        }

        [TestMethod]
        [TestParameters(null, null, (StringComparison) 1000, 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "abc", StringComparison.Ordinal, 2, false, "Parameter 'string' is null.")]
        [TestParameters("abc", null, StringComparison.Ordinal, 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 1000, 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.InvariantCulture, 5, false, "[String = ''; Value = ''; Comparison = 'InvariantCulture']")]
        [TestParameters("", "abc", StringComparison.InvariantCulture, 6, true, "[String = ''; Value = 'abc'; Comparison = 'InvariantCulture']")]
        [TestParameters("abc", "", StringComparison.InvariantCulture, 7, false, "[String = 'abc'; Value = ''; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "abcd", StringComparison.InvariantCulture, 8, false, "[String = 'abcd'; Value = 'abcd'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "ab", StringComparison.InvariantCulture, 9, false, "[String = 'abcd'; Value = 'ab'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "cd", StringComparison.InvariantCulture, 10, false, "[String = 'abcd'; Value = 'cd'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "bc", StringComparison.InvariantCulture, 11, false, "[String = 'abcd'; Value = 'bc'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "cb", StringComparison.InvariantCulture, 12, true, "[String = 'abcd'; Value = 'cb'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "Bc", StringComparison.InvariantCulture, 13, true, "[String = 'abcd'; Value = 'Bc'; Comparison = 'InvariantCulture']")]
        [TestParameters("abcd", "Bc", StringComparison.InvariantCultureIgnoreCase, 14, false, "[String = 'abcd'; Value = 'Bc'; Comparison = 'InvariantCultureIgnoreCase']")]
        void NotContainsWithComparison(String input1, String input2, StringComparison input3, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.Contains(input1, input2, input3),
                (count, result, message), "Test.IfNot.String.Contains");

        }

        #endregion

        #region ContainsWithComparisonWithMessage

        [TestMethod]
        [TestParameters(null, null, (StringComparison) 1000, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "abc", StringComparison.Ordinal, "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("abc", null, StringComparison.Ordinal, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 1000, "message", 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.InvariantCulture, "message", 5, true, "[String = ''; Value = ''; Comparison = 'InvariantCulture']")]
        [TestParameters("", "abc", StringComparison.InvariantCulture, "message", 6, false, "message")]
        void ContainsWithComparisonWithMessage(String input1, String input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.Contains(input1, input2, input3, customMessage),
                (count, result, message), "Test.If.String.Contains");

        }

        [TestMethod]
        [TestParameters(null, null, (StringComparison) 1000, "message", 1, false, "Parameter 'string' is null.")]
        [TestParameters(null, "abc", StringComparison.Ordinal, "message", 2, false, "Parameter 'string' is null.")]
        [TestParameters("abc", null, StringComparison.Ordinal, "message", 3, false, "Parameter 'value' is null.")]
        [TestParameters("", "", (StringComparison) 1000, "message", 4, false, "Parameter 'comparisonType' is out of bounds.")]
        [TestParameters("", "", StringComparison.InvariantCulture, "message", 5, false, "message")]
        [TestParameters("", "abc", StringComparison.InvariantCulture, "message", 6, true, "[String = ''; Value = 'abc'; Comparison = 'InvariantCulture']")]
        void NotContainsWithComparisonWithMessage(String input1, String input2, StringComparison input3, String customMessage, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.Contains(input1, input2, input3, customMessage),
                (count, result, message), "Test.IfNot.String.Contains");

        }

        #endregion

    }
}
