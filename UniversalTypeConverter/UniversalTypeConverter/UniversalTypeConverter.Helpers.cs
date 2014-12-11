// file     : UniversalTypeConverter.Helpers.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 18.07.2011

using System;

namespace TB.ComponentModel {

    partial class UniversalTypeConverter {

        /// <summary>
        /// Checks whether the given value represents null.
        /// The DBNull.Value is treated as null.
        /// This comes handy if conversion is applied to values coming from or sending to a database via ADO.Net.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool ValueRepresentsNull(object value) {
            return value == null || value == DBNull.Value;
        }

        /// <summary>
        /// Returns the default value of the given type.
        /// ValueTypes always have a parameterless constructor.
        /// The default value of other types is always null.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static object GetDefaultValueOfType(Type type) {
            return type.IsValueType ? Activator.CreateInstance(type) : null;
        }

        private static bool IsGenericNullable(Type type) {
            return type.IsGenericType &&
                   type.GetGenericTypeDefinition() == typeof(Nullable<>).GetGenericTypeDefinition();
        }

        private static Type GetUnderlyingType(Type type) {
            return Nullable.GetUnderlyingType(type);
        }

        private static bool IsWhiteSpace(string value) {
            for (int i = 0; i < value.Length; i++) {
                if (!char.IsWhiteSpace(value[i])) {
                    return false;
                }
            }
            return true;
        }
    }
    
}
