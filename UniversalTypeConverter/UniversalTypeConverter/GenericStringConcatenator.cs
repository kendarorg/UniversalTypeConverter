// file     : GenericStringConcatenator.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 30.06.2012

using System;
using System.Linq;
using System.Text;

namespace TB.ComponentModel {

    /// <summary>
    /// Defines a string representation builder for a value list.
    /// </summary>
    public class GenericStringConcatenator : IStringConcatenator {

        private readonly string mSeperator;
        private readonly string mNullValue;
        private readonly ConcatenationOptions mConcatenationOptions;

        /// <summary>
        /// Creates a new instance of the <see cref="GenericStringConcatenator">GenericStringConcatenator</see> class.<br></br>
        /// Using the <see cref="UniversalTypeConverter.DefaultStringSeperator">semicolon</see> as seperator.<br></br>
        /// Using <see cref="UniversalTypeConverter.DefaultNullStringValue">".null."</see> for null values.<br></br>
        /// Using <see cref="ConcatenationOptions.Default">ConcatenationOptions.Default</see>.
        /// </summary>
        public GenericStringConcatenator()
            : this(UniversalTypeConverter.DefaultStringSeperator) {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="GenericStringConcatenator">GenericStringConcatenator</see> class.<br></br>
        /// Using the the given seperator.<br></br>
        /// Using <see cref="UniversalTypeConverter.DefaultNullStringValue">".null."</see> for null values.<br></br>
        /// Using <see cref="ConcatenationOptions.Default">ConcatenationOptions.Default</see>.
        /// </summary>
        /// <param name="seperator">Seperator.</param>
        public GenericStringConcatenator(string seperator)
            : this(seperator, ConcatenationOptions.Default) {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="GenericStringConcatenator">GenericStringConcatenator</see> class.<br></br>
        /// Using the the given seperator.<br></br>
        /// Using <see cref="UniversalTypeConverter.DefaultNullStringValue">".null."</see> for null values.<br></br>
        /// Using the given options.
        /// </summary>
        /// <param name="seperator">Seperator.</param>
        /// <param name="concatenationOptions">Options.</param>
        public GenericStringConcatenator(string seperator, ConcatenationOptions concatenationOptions)
            : this(seperator, UniversalTypeConverter.DefaultNullStringValue, concatenationOptions) {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="GenericStringConcatenator">GenericStringConcatenator</see> class.<br></br>
        /// Using the the given seperator.<br></br>
        /// Using the given null value.<br></br>
        /// Using <see cref="ConcatenationOptions.Default">ConcatenationOptions.Default</see>.
        /// </summary>
        /// <param name="seperator">Seperator.</param>
        /// <param name="nullValue">Null value.</param>
        public GenericStringConcatenator(string seperator, string nullValue)
            : this(seperator, nullValue, ConcatenationOptions.Default) {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="GenericStringConcatenator">GenericStringConcatenator</see> class using the given settings.
        /// </summary>
        /// <param name="seperator">Seperator.</param>
        /// <param name="nullValue">Null value.</param>
        /// <param name="concatenationOptions">Options.</param>
        public GenericStringConcatenator(string seperator, string nullValue, ConcatenationOptions concatenationOptions) {
            if (seperator == null) {
                throw new ArgumentNullException("seperator");
            }
            mSeperator = seperator;
            mNullValue = nullValue;
            mConcatenationOptions = concatenationOptions;
        }

        /// <summary>
        /// Concatenates the given values to a string.
        /// </summary>
        /// <param name="values">Values to concatenate.</param>
        /// <returns>String representation.</returns>
        public string Concatenate(string[] values) {
            string[] valuesToConcatenate = values.Where(v => !IgnoreValue(v)).Select(value => value ?? mNullValue).ToArray();
            return ConcatenateCore(valuesToConcatenate);
        }

        private bool IgnoreValue(string value) {
            if (value == null &&
                (mConcatenationOptions & ConcatenationOptions.IgnoreNull) == ConcatenationOptions.IgnoreNull) {
                return true;
            }
            if (value == String.Empty &&
                (mConcatenationOptions & ConcatenationOptions.IgnoreEmpty) == ConcatenationOptions.IgnoreEmpty) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Concatenates the given values to a string.<br></br>
        /// This is the core routine to override within subclasses.
        /// </summary>
        /// <param name="values">Values to concatenate.</param>
        /// <returns>String representation.</returns>
        protected virtual string ConcatenateCore(string[] values) {
            StringBuilder result = new StringBuilder();
            foreach (string value in values) {
                if (result.Length > 0) {
                    result.Append(mSeperator);
                }
                result.Append(value);
            }
            return result.ToString();
        }
    }
}
