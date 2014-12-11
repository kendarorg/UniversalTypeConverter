// file     : GenericStringSplitter.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 30.06.2012

using System;

namespace TB.ComponentModel {

    /// <summary>
    /// Defines a 'split by seperator process' for converting a string represenation of a list of values.
    /// </summary>
    public class GenericStringSplitter : IStringSplitter {

        private readonly string mSeperator;

        /// <summary>
        /// Creates a new instance of the <see cref="GenericStringSplitter">GenericStringSplitter</see> class using the <see cref="UniversalTypeConverter.DefaultStringSeperator">semicolon</see> as seperator.
        /// </summary>
        public GenericStringSplitter()
            : this(UniversalTypeConverter.DefaultStringSeperator) {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="GenericStringSplitter">GenericStringSplitter</see> class.
        /// </summary>
        /// <param name="seperator">The seperator to use for splitting.</param>
        public GenericStringSplitter(string seperator) {
            if (seperator == null) {
                throw new ArgumentNullException("seperator");
            }
            mSeperator = seperator;
        }

        /// <summary>
        /// Splits the given string represenation of a list of values.
        /// </summary>
        /// <param name="valueList">String represenation of the list to split.</param>
        /// <returns>A list of the splitted values.</returns>
        public string[] Split(string valueList) {
            return valueList.Split(new[] { mSeperator }, StringSplitOptions.None);
        }
    }
}
