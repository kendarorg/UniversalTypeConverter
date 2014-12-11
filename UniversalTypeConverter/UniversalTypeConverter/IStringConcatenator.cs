// file     : IStringConcatenator.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 30.06.2012

namespace TB.ComponentModel {

    /// <summary>
    /// Defines a string representation builder for a value list.
    /// </summary>
    public interface IStringConcatenator {

        /// <summary>
        /// Concatenates the given values to a string.
        /// </summary>
        /// <param name="values">Values to concatenate.</param>
        /// <returns>String representation.</returns>
        string Concatenate(string[] values);

    }
}
