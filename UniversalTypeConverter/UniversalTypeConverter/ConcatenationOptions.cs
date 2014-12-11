// file     : ConcatenationOptions.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 30.06.2012

using System;

namespace TB.ComponentModel {

    /// <summary>
    /// Defines Options for a string concatenation.
    /// </summary>
    [Flags]
    public enum ConcatenationOptions {
        /// <summary>
        /// No options are used.
        /// </summary>
        None = 0,

        /// <summary>
        /// Null values are ignored on concatenation.
        /// </summary>
        IgnoreNull = 1,

        /// <summary>
        /// Empty values are ignored on concatenation.
        /// </summary>
        IgnoreEmpty = 2,

        /// <summary>
        /// The default value for concatenations. Same as <see cref="None">ConcatenationOptions.None</see>.
        /// </summary>
        Default = None
    }
}
