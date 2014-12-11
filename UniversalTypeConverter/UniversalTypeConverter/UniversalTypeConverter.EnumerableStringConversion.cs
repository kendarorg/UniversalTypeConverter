// file     : UniversalTypeConverter.EnumerableStringConversion.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 30.06.2012

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TB.ComponentModel {
    partial class UniversalTypeConverter {

        /// <summary>
        /// Controls an conversion iteration.
        /// </summary>
        /// <typeparam name="T">The type to which the elements of the source are converted.</typeparam>
        public class EnumerableStringConversion<T> : EnumerableConversion<T> {

            private bool mIgnoreEmptyElements;
            private bool mTrimStart;
            private bool mTrimEnd;
            private string[] mNullValues = new[] {DefaultNullStringValue};

            internal EnumerableStringConversion(string valueList, IStringSplitter stringSplitter)
                : base(stringSplitter.Split(valueList)) {
            }

            internal EnumerableStringConversion(string valueList, Type destinationType, IStringSplitter stringSplitter) 
                : base(stringSplitter.Split(valueList), destinationType) {
            }

            /// <summary>
            /// Use this option to ignore empty strings after splitting.
            /// </summary>
            /// <returns>This instance.</returns>
            public EnumerableStringConversion<T> IgnoringEmptyElements() {
                mIgnoreEmptyElements = true;
                return this;
            }

            /// <summary>
            /// Use this option to trim the start of the splitted strings.
            /// </summary>
            /// <returns>This instance.</returns>
            public EnumerableStringConversion<T> TrimmingStartOfElements() {
                mTrimStart = true;
                return this;
            }

            /// <summary>
            /// Use this option to trim the end of the splitted strings.
            /// </summary>
            /// <returns>This instance.</returns>
            public EnumerableStringConversion<T> TrimmingEndOfElements() {
                mTrimEnd = true;
                return this;
            }

            /// <summary>
            /// Defines strings which are treated as null after splitting.
            /// </summary>
            /// <param name="nullValues">List of null values.</param>
            /// <returns>This instance.</returns>
            public EnumerableStringConversion<T> WithNullBeing(params string[] nullValues) {
                mNullValues = nullValues;
                return this;
            }

            /// <summary>
            /// Gets a list of the values to convert.
            /// </summary>
            /// <returns>List of values to convert.</returns>
            protected override IEnumerable GetValuesToConvert() {
                List<string> valuesToConvert = new List<string>();
                string valueToConvert;
                foreach (string value in base.GetValuesToConvert()) {
                    valueToConvert = PreProcessValueToConvert(value);
                    if (ValueShouldBeIgnored(valueToConvert)) {
                        continue;
                    }
                    valuesToConvert.Add(valueToConvert);
                }
                return valuesToConvert;
            }

            private string PreProcessValueToConvert(string value) {
                string valueToConvert = value;
                if (mTrimStart) {
                    valueToConvert = valueToConvert.TrimStart();
                }
                if (mTrimEnd) {
                    valueToConvert = valueToConvert.TrimEnd();
                }
                return ValueOrNull(valueToConvert);
            }

            private bool ValueShouldBeIgnored(string valueToConvert) {
                if (valueToConvert == String.Empty && mIgnoreEmptyElements) {
                    return true;
                }
                return false;
            }

            private string ValueOrNull(string value) {
                if (mNullValues == null) {
                    return value;
                }
                string result = value;
                if (mNullValues.Contains(value)) {
                    result = null;
                }
                return result;
            }
        }

    }
}
