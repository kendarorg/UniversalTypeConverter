// file     : InvalidConversionException.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 29.06.2012

using System;

namespace TB.ComponentModel {

    /// <summary>
    /// The exception that is thrown when a conversion is invalid.
    /// </summary>
    public class InvalidConversionException : InvalidOperationException {

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidConversionException">InvalidConversionException</see> class.
        /// </summary>
        /// <param name="valueToConvert"></param>
        /// <param name="destinationType"></param>
        public InvalidConversionException(object valueToConvert, Type destinationType)
            : base(String.Format("'{0}' ({1}) is not convertible to '{2}'.",
                                 valueToConvert,
                                 valueToConvert == null ? null : valueToConvert.GetType(),
                                 destinationType)) {
        }
    }
}
