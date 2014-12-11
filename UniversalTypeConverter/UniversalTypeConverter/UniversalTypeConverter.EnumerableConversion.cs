// file     : UniversalTypeConverter.EnumerableConversion.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 29.06.2012

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace TB.ComponentModel {
    partial class UniversalTypeConverter {

        /// <summary>
        /// Controls an conversion iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the elements of the source are converted.</typeparam>
        public class EnumerableConversion<T> : IEnumerable<T> {

            private readonly IEnumerable mValuesToConvert;
            private readonly Type mDestinationType = typeof(T);
            private CultureInfo mCulture;
            private ConversionOptions mConversionOptions = ConversionOptions.Default;
            private bool mIgnoreNullElements;
            private bool mIgnoreNonConvertibleElements;

            private CultureInfo Culture {
                get { return mCulture ?? DefaultCulture; }
            }

            internal EnumerableConversion(IEnumerable values, Type destinationType)
                : this(values) {
                mDestinationType = destinationType;
            }

            internal EnumerableConversion(IEnumerable values) {
                mValuesToConvert = values;
            }

            /// <summary>
            /// Defines the culture used for conversion.
            /// </summary>
            /// <param name="culture">The CultureInfo to use as the current culture.</param>
            /// <returns>This instance.</returns>
            public EnumerableConversion<T> UsingCulture(CultureInfo culture) {
                mCulture = culture;
                return this;
            }

            /// <summary>
            /// Defines options used for conversion.
            /// </summary>
            /// <param name="options">The options which are used for conversion.</param>
            /// <returns>This instance.</returns>
            public EnumerableConversion<T> UsingConversionOptions(ConversionOptions options) {
                mConversionOptions = options;
                return this;
            }

            /// <summary>
            /// Use this option to ignore non convertible values without throwing an exception.
            /// </summary>
            /// <returns>This instance.</returns>
            public EnumerableConversion<T> IgnoringNonConvertibleElements() {
                mIgnoreNonConvertibleElements = true;
                return this;
            }

            /// <summary>
            /// Use this option to ignore null values.
            /// </summary>
            /// <returns>This instance.</returns>
            public EnumerableConversion<T> IgnoringNullElements() {
                mIgnoreNullElements = true;
                return this;
            }

            /// <summary>
            /// Returns an enumerator that iterates through the collection of converted values.
            /// A return value indicates whether the operation succeeded.
            /// </summary>
            /// <param name="result">Enumerator that iterates through the collection of converted values if the operation succeeded.</param>
            /// <returns>true on success; otherwise, false.</returns>
            public bool Try(out IEnumerable<T> result) {
                return TryConvert(out result);
            }

            /// <summary>
            /// Returns an enumerator that iterates through the collection of converted values.
            /// </summary>
            /// <returns>Enumerator that iterates through the collection of converted values.</returns>
            IEnumerator IEnumerable.GetEnumerator() {
                return GetEnumerator();
            }

            /// <summary>
            /// Returns an enumerator that iterates through the collection of converted values.
            /// </summary>
            /// <returns>Enumerator that iterates through the collection of converted values.</returns>
            public IEnumerator<T> GetEnumerator() {
                IEnumerable<T> result;
                Exception exception;
                if(TryConvert(out result, out exception)) {
                    return result.GetEnumerator();
                }
                throw exception;
            }

            private bool TryConvert(out IEnumerable<T> result) {
                Exception exception;
                return TryConvert(out result, out exception);
            }

            private bool TryConvert(out IEnumerable<T> result, out Exception exception) {
                List<T> convertedValues = new List<T>();
                object convertedValue;
                foreach (object value in GetValuesToConvert()) {
                    if (value == null && mIgnoreNullElements) {
                        continue;
                    }
                    if (!value.TryConvert(mDestinationType, out convertedValue, Culture, mConversionOptions)) {
                        if (mIgnoreNonConvertibleElements) {
                            continue;
                        }
                        result = null;
                        exception = new InvalidConversionException(value, mDestinationType);
                        return false;
                    }
                    convertedValues.Add((T) convertedValue);
                }
                result = convertedValues;
                exception = null;
                return true;
            }

            /// <summary>
            /// Gets a list of the values to convert.
            /// </summary>
            /// <returns>List of values to convert.</returns>
            protected virtual IEnumerable GetValuesToConvert() {
                return mValuesToConvert;
            }
        }
    }
}
