// file     : UniversalTypeConverter.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 17.07.2011

using System;
using System.Globalization;

namespace TB.ComponentModel {

    /// <summary>
    /// Converts a data type to another data type.
    /// </summary>
    /// <remarks>
    /// DBNull.Value is treated as null.<br></br>
    /// Supports the following conversions:<br></br>
    /// - conversion from a base type to another base type<br></br>
    /// - base type conversion includes the typical conversions from/to an enum - supporting flags<br></br>
    /// - base type conversion includes string conversion from/to a Guid<br></br>
    /// - base type conversion includes enhanced conversions for special values, e.g. "yes" to true, 'n' to false, true to 'T', etc.<br></br>
    /// - conversion from a base type to the nullable (?) pendant<br></br>
    /// - conversion from a nullable (?) base type to the not nullable pendant<br></br>
    /// - conversion supported by the TypeConverters of the given types<br></br>
    /// - conversion supported by the implementation of IConvertible of the given types<br></br>
    /// - optional conversion from null to value types using the default value<br></br>
    /// - optional conversion from whitespace to value types using the default value<br></br>
    /// <br></br>
    /// Converting whole lists of values is supported through IEnumerable and IEnumerable(T).
    /// </remarks>
    public static partial class UniversalTypeConverter {

        /// <summary>
        /// Defines the default culture which is used during conversion.
        /// Same as CultureInfo.CurrentCulture.
        /// </summary>
        public static readonly CultureInfo DefaultCulture = CultureInfo.CurrentCulture;

        /// <summary>
        /// Defines ".null." as the default null value which is used on string conversions.
        /// </summary>
        public const string DefaultNullStringValue = ".null.";

        /// <summary>
        /// Defines the semicolon (;) as the default seperator which is used on enumerable conversions.
        /// </summary>
        public const string DefaultStringSeperator = ";";

        #region [ CanConvertTo<T> ]
        /// <summary>
        /// Determines whether the given value can be converted to the specified type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <typeparam name="T">The Type to test.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool CanConvertTo<T>(object value) {
            T result;
            return TryConvertTo(value, out result);
        }

        /// <summary>
        /// Determines whether the given value can be converted to the specified type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <typeparam name="T">The Type to test.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool CanConvertTo<T>(object value, CultureInfo culture) {
            T result;
            return TryConvertTo(value, out result, culture);
        }

        /// <summary>
        /// Determines whether the given value can be converted to the specified type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <typeparam name="T">The Type to test.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool CanConvertTo<T>(object value, ConversionOptions options) {
            T result;
            return TryConvertTo(value, out result, options);
        }

        /// <summary>
        /// Determines whether the given value can be converted to the specified type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <typeparam name="T">The Type to test.</typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool CanConvertTo<T>(object value, CultureInfo culture, ConversionOptions options) {
            T result;
            return TryConvertTo(value, out result, culture, options);
        }
        #endregion

        #region [ TryConvertTo<T> ]
        /// <summary>
        /// Converts the given value to the given type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <typeparam name="T">The type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="result">An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvertTo<T>(object value, out T result) {
            return TryConvertTo(value, out result, DefaultCulture);
        }

        /// <summary>
        /// Converts the given value to the given type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <typeparam name="T">The type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="result">An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvertTo<T>(object value, out T result, CultureInfo culture) {
            return TryConvertTo(value, out result, culture, ConversionOptions.Default);
        }

        /// <summary>
        /// Converts the given value to the given type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <typeparam name="T">The type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="result">An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvertTo<T>(object value, out T result, ConversionOptions options) {
            return TryConvertTo(value, out result, DefaultCulture, options);
        }

        /// <summary>
        /// Converts the given value to the given type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <typeparam name="T">The type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="result">An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvertTo<T>(object value, out T result, CultureInfo culture, ConversionOptions options) {
            object tmpResult;
            if (TryConvert(value, typeof(T), out tmpResult, culture, options)) {
                result = (T)tmpResult;
                return true;
            }
            result = default(T);
            return false;
        }
        #endregion

        #region [ ConvertTo<T> ]
        /// <summary>
        /// Converts the given value to the given type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <typeparam name="T">The type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <returns>An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static T ConvertTo<T>(object value) {
            return ConvertTo<T>(value, DefaultCulture);
        }

        /// <summary>
        /// Converts the given value to the given type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <typeparam name="T">The type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static T ConvertTo<T>(object value, CultureInfo culture) {
            return ConvertTo<T>(value, culture, ConversionOptions.Default);
        }

        /// <summary>
        /// Converts the given value to the given type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <typeparam name="T">The type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static T ConvertTo<T>(object value, ConversionOptions options) {
            return ConvertTo<T>(value, DefaultCulture, options);
        }

        /// <summary>
        /// Converts the given value to the given type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <typeparam name="T">The type to which the given value is converted.</typeparam>
        /// <param name="value">The value which is converted.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>An Object instance of type <typeparamref name="T">T</typeparamref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static T ConvertTo<T>(object value, CultureInfo culture, ConversionOptions options) {
            return (T)Convert(value, typeof(T), culture, options);
        }
        #endregion

        #region [ CanConvert ]
        /// <summary>
        /// Determines whether the given value can be converted to the specified type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="destinationType">The Type to test.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <paramref name="destinationType"/>; otherwise, false.</returns>
        public static bool CanConvert(object value, Type destinationType) {
            object result;
            return TryConvert(value, destinationType, out result);
        }

        /// <summary>
        /// Determines whether the given value can be converted to the specified type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="destinationType">The Type to test.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <paramref name="destinationType"/>; otherwise, false.</returns>
        public static bool CanConvert(object value, Type destinationType, CultureInfo culture) {
            object result;
            return TryConvert(value, destinationType, out result, culture);
        }

        /// <summary>
        /// Determines whether the given value can be converted to the specified type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="destinationType">The Type to test.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <paramref name="destinationType"/>; otherwise, false.</returns>
        public static bool CanConvert(object value, Type destinationType, ConversionOptions options) {
            object result;
            return TryConvert(value, destinationType, out result, options);
        }

        /// <summary>
        /// Determines whether the given value can be converted to the specified type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="destinationType">The Type to test.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> can be converted to <paramref name="destinationType"/>; otherwise, false.</returns>
        public static bool CanConvert(object value, Type destinationType, CultureInfo culture, ConversionOptions options) {
            object result;
            return TryConvert(value, destinationType, out result, culture, options);
        }
        #endregion

        #region [ TryConvert ]
        /// <summary>
        /// Converts the given value to the given type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The type to which the given value is converted.</param>
        /// <param name="result">An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvert(object value, Type destinationType, out object result) {
            return TryConvert(value, destinationType, out result, DefaultCulture);
        }

        /// <summary>
        /// Converts the given value to the given type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The type to which the given value is converted.</param>
        /// <param name="result">An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvert(object value, Type destinationType, out object result, CultureInfo culture) {
            return TryConvert(value, destinationType, out result, culture, ConversionOptions.Default);
        }

        /// <summary>
        /// Converts the given value to the given type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The type to which the given value is converted.</param>
        /// <param name="result">An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvert(object value, Type destinationType, out object result, ConversionOptions options) {
            return TryConvert(value, destinationType, out result, DefaultCulture, options);
        }

        /// <summary>
        /// Converts the given value to the given type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The type to which the given value is converted.</param>
        /// <param name="result">An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref> if the operation succeeded.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>true if <paramref name="value"/> was converted successfully; otherwise, false.</returns>
        public static bool TryConvert(object value, Type destinationType, out object result, CultureInfo culture, ConversionOptions options) {
            if (destinationType == typeof(object)) {
                result = value;
                return true;
            }
            if (ValueRepresentsNull(value)) {
                return TryConvertFromNull(destinationType, out result, options);
            }
            if (destinationType.IsAssignableFrom(value.GetType())) {
                result = value;
                return true;
            }
            Type coreDestinationType = IsGenericNullable(destinationType) ? GetUnderlyingType(destinationType) : destinationType;
            object tmpResult = null;
            if (TryConvertCore(value, coreDestinationType, ref tmpResult, culture, options)) {
                result = tmpResult;
                return true;
            }
            result = null;
            return false;
        }
        #endregion

        #region [ Convert ]
        /// <summary>
        /// Converts the given value to the given type using the current CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The type to which the given value is converted.</param>
        /// <returns>An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static object Convert(object value, Type destinationType) {
            return Convert(value, destinationType, DefaultCulture);
        }

        /// <summary>
        /// Converts the given value to the given type using the given CultureInfo and the <see cref="ConversionOptions">ConversionOptions</see>.<see cref="ConversionOptions.EnhancedTypicalValues">ConvertSpecialValues</see>.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The type to which the given value is converted.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <returns>An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static object Convert(object value, Type destinationType, CultureInfo culture) {
            return Convert(value, destinationType, culture, ConversionOptions.Default);
        }

        /// <summary>
        /// Converts the given value to the given type using the current CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The type to which the given value is converted.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static object Convert(object value, Type destinationType, ConversionOptions options) {
            return Convert(value, destinationType, DefaultCulture, options);
        }

        /// <summary>
        /// Converts the given value to the given type using the given CultureInfo and the given <see cref="ConversionOptions">ConversionOptions</see>.
        /// </summary>
        /// <param name="value">The value which is converted.</param>
        /// <param name="destinationType">The type to which the given value is converted.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="options">The options which are used for conversion.</param>
        /// <returns>An Object instance of type <paramref name="destinationType">destinationType</paramref> whose value is equivalent to the given <paramref name="value">value</paramref>.</returns>
        public static object Convert(object value, Type destinationType, CultureInfo culture, ConversionOptions options) {
            object result;
            if (TryConvert(value, destinationType, out result, culture, options)) {
                return result;
            }
            throw new InvalidConversionException(value, destinationType);
        }
        #endregion
    }
}
