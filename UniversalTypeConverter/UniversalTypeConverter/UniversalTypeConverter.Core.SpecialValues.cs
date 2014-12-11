// file     : UniversalTypeConverter.Core.SpecialValues.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 18.07.2011

using System;
using System.Collections.Generic;

namespace TB.ComponentModel {
    partial class UniversalTypeConverter {

        private static bool TryConvertSpecialValues(object value, Type destinationType, ref object result) {

            if (value is char && destinationType == typeof (bool)) {
                return TryConvertCharToBool((char) value, ref result);
            }

            if (value is string && destinationType == typeof (bool)) {
                return TryConvertStringToBool((string) value, ref result);
            }

            if (value is bool && destinationType == typeof (char)) {
                return ConvertBoolToChar((bool) value, out result);
                
            }
            return false;
        }

        private static bool TryConvertCharToBool(char value, ref object result) {
            if ("1JYT".Contains(value.ToString().ToUpper())) {
                result = true;
                return true;
            }
            if ("0NF".Contains(value.ToString().ToUpper())) {
                result = false;
                return true;
            }
            return false;
        }

        private static bool TryConvertStringToBool(string value, ref object result) {
            List<string> trueValues = new List<string>(new[] {"1", "j", "ja", "y", "yes", "true", "t", ".t."});
            if(trueValues.Contains(value.Trim().ToLower())) {
                result = true;
                return true;
            }
            List<string> falseValues = new List<string>(new[] {"0", "n", "no", "nein", "false", "f", ".f."});
            if (falseValues.Contains(value.Trim().ToLower())) {
                result = false;
                return true;
            }
            return false;
        }

        private static bool ConvertBoolToChar(bool value, out object result) {
            result = value ? 'T' : 'F';
            return true;
        }

    }
}
