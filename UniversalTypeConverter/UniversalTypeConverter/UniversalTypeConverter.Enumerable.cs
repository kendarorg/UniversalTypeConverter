// file     : UniversalTypeConverter.Enumerable.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 29.06.2012

using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace TB.ComponentModel {
    partial class UniversalTypeConverter {

        #region [ ConvertToEnumerable<T> ]
        /// <summary>
        /// Converts all elements of the given list to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the given values are converted.</typeparam>
        /// <param name="values">The list of values which are converted.</param>
        /// <returns>List of converted values.</returns>
        public static EnumerableConversion<T> ConvertToEnumerable<T>(IEnumerable values) {
            return new EnumerableConversion<T>(values);
        }

        /// <summary>
        /// Splits the given string by using the semicolon (;) as a seperator and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the given values are converted.</typeparam>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <returns>List of converted values.</returns>
        public static EnumerableStringConversion<T> ConvertToEnumerable<T>(string valueList) {
            return ConvertToEnumerable<T>(valueList, new GenericStringSplitter());
        }

        /// <summary>
        /// Splits the given string by using the given seperator and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the given values are converted.</typeparam>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="seperator">The value seperator which is used in <paramref name="valueList">valueList</paramref>.</param>
        /// <returns>List of converted values.</returns>
        public static EnumerableStringConversion<T> ConvertToEnumerable<T>(string valueList, string seperator) {
            return ConvertToEnumerable<T>(valueList, new GenericStringSplitter(seperator));
        }

        /// <summary>
        /// Splits the given string by using the given splitter and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the given values are converted.</typeparam>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="stringSplitter">The splitter to use.</param>
        /// <returns>List of converted values.</returns>
        public static EnumerableStringConversion<T> ConvertToEnumerable<T>(string valueList, IStringSplitter stringSplitter) {
            return new EnumerableStringConversion<T>(valueList, stringSplitter);
        }
        #endregion

        #region [ ConvertToEnumerable ]
        /// <summary>
        /// Converts all elements of the given list to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <param name="values">The list of values which are converted.</param>
        /// <param name="destinationType">The type to which the given values are converted.</param>
        /// <returns>List of converted values.</returns>
        public static EnumerableConversion<object> ConvertToEnumerable(IEnumerable values, Type destinationType) {
            return new EnumerableConversion<object>(values, destinationType);
        }

        /// <summary>
        /// Splits the given string by using the semicolon (;) as a seperator and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="destinationType">The type to which the given values are converted.</param>
        /// <returns>List of converted values.</returns>
        public static EnumerableStringConversion<object> ConvertToEnumerable(string valueList, Type destinationType) {
            return ConvertToEnumerable(valueList, destinationType, DefaultStringSeperator);
        }

        /// <summary>
        /// Splits the given string by using the given seperator and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="destinationType">The type to which the given values are converted.</param>
        /// <param name="seperator">The value seperator which is used in <paramref name="valueList">valueList</paramref>.</param>
        /// <returns>List of converted values.</returns>
        public static EnumerableStringConversion<object> ConvertToEnumerable(string valueList, Type destinationType, string seperator) {
            return ConvertToEnumerable(valueList, destinationType, new GenericStringSplitter(seperator));
        }

        /// <summary>
        /// Splits the given string by using the given splitter and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="destinationType">The type to which the given values are converted.</param>
        /// <param name="stringSplitter">The splitter to use.</param>
        /// <returns>List of converted values.</returns>
        public static EnumerableStringConversion<object> ConvertToEnumerable(string valueList, Type destinationType, IStringSplitter stringSplitter) {
            return new EnumerableStringConversion<object>(valueList, destinationType, stringSplitter);
        }
        #endregion

        #region [ ConvertToStringRepresentation ]
        /// <summary>
        /// Converts the given value list to a semicolon seperated string.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(IEnumerable values) {
            return ConvertToStringRepresentation(values, DefaultCulture, new GenericStringConcatenator());
        }

        /// <summary>
        /// Converts the given value list to a string where all values a seperated by the given seperator.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="seperator">Seperator.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(IEnumerable values, string seperator) {
            return ConvertToStringRepresentation(values, DefaultCulture, new GenericStringConcatenator(seperator));
        }

        /// <summary>
        /// Converts the given value list to a string where all values a seperated by the given seperator.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="seperator">Seperator.</param>
        /// <param name="nullValue">The string which is used for null values.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(IEnumerable values, string seperator, string nullValue) {
            return ConvertToStringRepresentation(values, DefaultCulture, new GenericStringConcatenator(seperator, nullValue));
        }

        /// <summary>
        /// Converts the given value list to a semicolon seperated string.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(IEnumerable values, CultureInfo culture) {
            return ConvertToStringRepresentation(values, culture, new GenericStringConcatenator());
        }

        /// <summary>
        /// Converts the given value list to a string.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="stringConcatenator">The concatenator which is used to build the string.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(IEnumerable values, IStringConcatenator stringConcatenator) {
            return ConvertToStringRepresentation(values, DefaultCulture, stringConcatenator);
        }

        /// <summary>
        /// Converts the given value list to a string.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="stringConcatenator">The concatenator which is used to build the string.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(IEnumerable values, CultureInfo culture, IStringConcatenator stringConcatenator) {
            string[] stringValues = ConvertToEnumerable<string>(values)
                .UsingCulture(culture)
                .ToArray();
            return stringConcatenator.Concatenate(stringValues);
        }
        #endregion
    }
}
