// file     : ObjectExtension.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 28.07.2011

using System;
using System.Collections;
using System.Globalization;

namespace TB.ComponentModel {

    /// <summary>
    /// Extension methods.
    /// </summary>
    public static class ObjectExtension {

        #region [ CanConvertTo<T> ]
        /// <summary>
        /// Determines whether the value can be converted to the specified type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <typeparam name="T">The Type to test.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool CanConvertTo<T>(this object value) {
            return UniversalTypeConverter.CanConvertTo<T>(value);
        }

        /// <summary>
        /// Determines whether the value can be converted to the specified type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <typeparam name="T">The Type to test.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool CanConvertTo<T>(this object value, CultureInfo culture) {
            return UniversalTypeConverter.CanConvertTo<T>(value, culture);
        }

        /// <summary>
        /// Determines whether the value can be converted to the specified type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <typeparam name="T">The Type to test.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool CanConvertTo<T>(this object value, ConversionOptions options) {
            return UniversalTypeConverter.CanConvertTo<T>(value, options);
        }

        /// <summary>
        /// Determines whether the value can be converted to the specified type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <typeparam name="T">The Type to test.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool CanConvertTo<T>(this object value, CultureInfo culture, ConversionOptions options) {
            return UniversalTypeConverter.CanConvertTo<T>(value, culture, options);
        }
        #endregion

        #region [ TryConvertTo<T> ]
        /// <summary>
        /// Converts the value to the given Type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <typeparam name="T">The Type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="result">An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvertTo<T>(this object value, out T result) {
            return UniversalTypeConverter.TryConvertTo(value, out result);
        }

        /// <summary>
        /// Converts the value to the given Type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <typeparam name="T">The Type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="result">An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvertTo<T>(this object value, out T result, CultureInfo culture) {
            return UniversalTypeConverter.TryConvertTo(value, out result, culture);
        }

        /// <summary>
        /// Converts the value to the given Type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <typeparam name="T">The Type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="result">An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvertTo<T>(this object value, out T result, ConversionOptions options) {
            return UniversalTypeConverter.TryConvertTo(value, out result, options);
        }

        /// <summary>
        /// Converts the value to the given Type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <typeparam name="T">The Type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="result">An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvertTo<T>(this object value, out T result, CultureInfo culture, ConversionOptions options) {
            return UniversalTypeConverter.TryConvertTo(value, out result, culture, options);
        }
        #endregion

        #region [ ConvertTo<T> ]
        /// <summary>
        /// Converts the value to the given Type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <typeparam name="T">The Type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <returns>An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static T ConvertTo<T>(this object value) {
            return UniversalTypeConverter.ConvertTo<T>(value);
        }

        /// <summary>
        /// Converts the value to the given Type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <typeparam name="T">The Type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static T ConvertTo<T>(this object value, CultureInfo culture) {
            return UniversalTypeConverter.ConvertTo<T>(value, culture);
        }

        /// <summary>
        /// Converts the value to the given Type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <typeparam name="T">The Type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static T ConvertTo<T>(this object value, ConversionOptions options) {
            return UniversalTypeConverter.ConvertTo<T>(value, options);
        }

        /// <summary>
        /// Converts the value to the given Type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <typeparam name="T">The Type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static T ConvertTo<T>(this object value, CultureInfo culture, ConversionOptions options) {
            return UniversalTypeConverter.ConvertTo<T>(value, culture, options);
        }
        #endregion

        #region [ CanConvert ]
        /// <summary>
        /// Determines whether the value can be converted to the specified type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="destinationType">The Type to test.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <paramref name="destinationType"/>; otherwise, false.</returns>
        public static bool CanConvert(this object value, Type destinationType) {
            return UniversalTypeConverter.CanConvert(value, destinationType);
        }

        /// <summary>
        /// Determines whether the value can be converted to the specified type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="destinationType">The Type to test.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <paramref name="destinationType"/>; otherwise, false.</returns>
        public static bool CanConvert(this object value, Type destinationType, CultureInfo culture) {
            return UniversalTypeConverter.CanConvert(value, destinationType, culture);
        }

        /// <summary>
        /// Determines whether the value can be converted to the specified type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="destinationType">The Type to test.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <paramref name="destinationType"/>; otherwise, false.</returns>
        public static bool CanConvert(this object value, Type destinationType, ConversionOptions options) {
            return UniversalTypeConverter.CanConvert(value, destinationType, options);
        }

        /// <summary>
        /// Determines whether the value can be converted to the specified type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="destinationType">The Type to test.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <paramref name="destinationType"/>; otherwise, false.</returns>
        public static bool CanConvert(this object value, Type destinationType, CultureInfo culture, ConversionOptions options) {
            return UniversalTypeConverter.CanConvert(value, destinationType, culture, options);
        }
        #endregion

        #region [ TryConvert ]
        /// <summary>
        /// Converts the value to the given Type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The Type to which the given value is converted.</param>
        /// <param name="result">An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvert(this object value, Type destinationType, out object result) {
            return UniversalTypeConverter.TryConvert(value, destinationType, out result);
        }

        /// <summary>
        /// Converts the value to the given Type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The Type to which the given value is converted.</param>
        /// <param name="result">An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvert(this object value, Type destinationType, out object result, CultureInfo culture) {
            return UniversalTypeConverter.TryConvert(value, destinationType, out result, culture);
        }

        /// <summary>
        /// Converts the value to the given Type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The Type to which the given value is converted.</param>
        /// <param name="result">An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvert(this object value, Type destinationType, out object result, ConversionOptions options) {
            return UniversalTypeConverter.TryConvert(value, destinationType, out result, options);
        }

        /// <summary>
        /// Converts the value to the given Type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The Type to which the given value is converted.</param>
        /// <param name="result">An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvert(this object value, Type destinationType, out object result, CultureInfo culture, ConversionOptions options) {
            return UniversalTypeConverter.TryConvert(value, destinationType, out result, culture, options);
        }
        #endregion

        #region [ Convert ]
        /// <summary>
        /// Converts the value to the given Type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The Type to which the given value is converted.</param>
        /// <returns>An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static object Convert(this object value, Type destinationType) {
            return UniversalTypeConverter.Convert(value, destinationType);
        }

        /// <summary>
        /// Converts the value to the given Type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The Type to which the given value is converted.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static object Convert(this object value, Type destinationType, CultureInfo culture) {
            return UniversalTypeConverter.Convert(value, destinationType, culture);
        }

        /// <summary>
        /// Converts the value to the given Type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The Type to which the given value is converted.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static object Convert(this object value, Type destinationType, ConversionOptions options) {
            return UniversalTypeConverter.Convert(value, destinationType, options);
        }

        /// <summary>
        /// Converts the value to the given Type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The Type to which the given value is converted.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static object Convert(this object value, Type destinationType, CultureInfo culture, ConversionOptions options) {
            return UniversalTypeConverter.Convert(value, destinationType, culture, options);
        }
        #endregion

        #region [ ConvertToEnumerable<T> ]
        /// <summary>
        /// Converts all elements of the list to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the values are converted.</typeparam>
        /// <param name="values">The list of values which are converted.</param>
        /// <returns>List of converted values.</returns>
        public static UniversalTypeConverter.EnumerableConversion<T> ConvertToEnumerable<T>(this IEnumerable values) {
            return UniversalTypeConverter.ConvertToEnumerable<T>(values);
        }

        /// <summary>
        /// Splits the string by using the semicolon (;) as a seperator and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the values are converted.</typeparam>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <returns>List of converted values.</returns>
        public static UniversalTypeConverter.EnumerableStringConversion<T> ConvertToEnumerable<T>(this string valueList) {
            return UniversalTypeConverter.ConvertToEnumerable<T>(valueList);
        }

        /// <summary>
        /// Splits the string by using the given seperator and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the values are converted.</typeparam>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="seperator">The value seperator which is used in <paramref name="valueList">valueList</paramref>.</param>
        /// <returns>List of converted values.</returns>
        public static UniversalTypeConverter.EnumerableStringConversion<T> ConvertToEnumerable<T>(this string valueList, string seperator) {
            return UniversalTypeConverter.ConvertToEnumerable<T>(valueList, seperator);
        }

        /// <summary>
        /// Splits the string by using the given splitter and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the values are converted.</typeparam>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="stringSplitter">The splitter to use.</param>
        /// <returns>List of converted values.</returns>
        public static UniversalTypeConverter.EnumerableStringConversion<T> ConvertToEnumerable<T>(this string valueList, IStringSplitter stringSplitter) {
            return UniversalTypeConverter.ConvertToEnumerable<T>(valueList, stringSplitter);
        }
        #endregion

        #region [ ConvertToEnumerable ]
        /// <summary>
        /// Converts all elements of the list to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <param name="values">The list of values which are converted.</param>
        /// <param name="destinationType">The type to which the values are converted.</param>
        /// <returns>List of converted values.</returns>
        public static UniversalTypeConverter.EnumerableConversion<object> ConvertToEnumerable(this IEnumerable values, Type destinationType) {
            return UniversalTypeConverter.ConvertToEnumerable(values, destinationType);
        }

        /// <summary>
        /// Splits the string by using the semicolon (;) as a seperator and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="destinationType">The type to which the values are converted.</param>
        /// <returns>List of converted values.</returns>
        public static UniversalTypeConverter.EnumerableStringConversion<object> ConvertToEnumerable(this string valueList, Type destinationType) {
            return UniversalTypeConverter.ConvertToEnumerable(valueList, destinationType);
        }

        /// <summary>
        /// Splits the string by using the given seperator and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="destinationType">The type to which the values are converted.</param>
        /// <param name="seperator">The value seperator which is used in <paramref name="valueList">valueList</paramref>.</param>
        /// <returns>List of converted values.</returns>
        public static UniversalTypeConverter.EnumerableStringConversion<object> ConvertToEnumerable(this string valueList, Type destinationType, string seperator) {
            return UniversalTypeConverter.ConvertToEnumerable(valueList, destinationType, seperator);
        }

        /// <summary>
        /// Splits the string by using the given splitter and converts all elements of the result to the given type.
        /// The result is configurable further more before first iteration.
        /// </summary>
        /// <param name="valueList">The string representation of the list of values to convert.</param>
        /// <param name="destinationType">The type to which the values are converted.</param>
        /// <param name="stringSplitter">The splitter to use.</param>
        /// <returns>List of converted values.</returns>
        public static UniversalTypeConverter.EnumerableStringConversion<object> ConvertToEnumerable(this string valueList, Type destinationType, IStringSplitter stringSplitter) {
            return UniversalTypeConverter.ConvertToEnumerable(valueList, destinationType, stringSplitter);
        }
        #endregion

        #region [ ConvertToStringRepresentation ]
        /// <summary>
        /// Converts the list to a semicolon seperated string.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(this IEnumerable values) {
            return UniversalTypeConverter.ConvertToStringRepresentation(values);
        }

        /// <summary>
        /// Converts the list to a string where all values a seperated by the given seperator.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="seperator">Seperator.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(this IEnumerable values, string seperator) {
            return UniversalTypeConverter.ConvertToStringRepresentation(values, seperator);
        }

        /// <summary>
        /// Converts the list to a string where all values a seperated by the given seperator.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="seperator">Seperator.</param>
        /// <param name="nullValue">The string which is used for null values.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(this IEnumerable values, string seperator, string nullValue) {
            return UniversalTypeConverter.ConvertToStringRepresentation(values, seperator, nullValue);
        }

        /// <summary>
        /// Converts the list to a semicolon seperated string.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(this IEnumerable values, CultureInfo culture) {
            return UniversalTypeConverter.ConvertToStringRepresentation(values, culture);
        }

        /// <summary>
        /// Converts the list to a string.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="stringConcatenator">The concatenator which is used to build the string.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(this IEnumerable values, IStringConcatenator stringConcatenator) {
            return UniversalTypeConverter.ConvertToStringRepresentation(values, stringConcatenator);
        }

        /// <summary>
        /// Converts the list to a string.
        /// </summary>
        /// <param name="values">Values to convert to string.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="stringConcatenator">The concatenator which is used to build the string.</param>
        /// <returns>String representation of the given value list.</returns>
        public static string ConvertToStringRepresentation(this IEnumerable values, CultureInfo culture, IStringConcatenator stringConcatenator) {
            return UniversalTypeConverter.ConvertToStringRepresentation(values, culture, stringConcatenator);
        }
        #endregion
    }
}
