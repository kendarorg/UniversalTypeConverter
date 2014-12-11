// file     : UniversalTypeConverter.Core.cs
// project  : UniversalTypeConverter
// author   : Thorsten Bruning
// date     : 19.07.2011

using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Linq;

namespace TB.ComponentModel {
    partial class UniversalTypeConverter {

        private const string ImplicitOperatorMethodName = "op_Implicit";
        private const string ExplicitOperatorMethodName = "op_Explicit";

        private static bool TryConvertFromNull(Type destinationType, out object result, ConversionOptions options) {
            result = GetDefaultValueOfType(destinationType);
            if (result == null) {
                return true;
            }
            return (options & ConversionOptions.AllowDefaultValueIfNull) ==
                   ConversionOptions.AllowDefaultValueIfNull;
        }

        private static bool TryConvertCore(object value, Type destinationType, ref object result, CultureInfo culture, ConversionOptions options) {
            if (value.GetType() == destinationType) {
                result = value;
                return true;
            }
            if (TryConvertByDefaultTypeConverters(value, destinationType, culture, ref result)) {
                return true;
            }
            if (TryConvertByIConvertibleImplementation(value, destinationType, culture, ref result)) {
                return true;
            }
            if (TryConvertXPlicit(value, destinationType, ExplicitOperatorMethodName, ref result)) {
                return true;
            }
            if (TryConvertXPlicit(value, destinationType, ImplicitOperatorMethodName, ref result)) {
                return true;
            }
            if (TryConvertByIntermediateConversion(value, destinationType, ref result, culture, options)) {
                return true;
            }
            if (destinationType.IsEnum) {
                if (TryConvertToEnum(value, destinationType, ref result)) {
                    return true;
                }
            }
            if ((options & ConversionOptions.EnhancedTypicalValues) == ConversionOptions.EnhancedTypicalValues) {
                if (TryConvertSpecialValues(value, destinationType, ref result)) {
                    return true;
                }
            }
            if ((options & ConversionOptions.AllowDefaultValueIfWhitespace) == ConversionOptions.AllowDefaultValueIfWhitespace) {
                if (value is string) {
                    if (IsWhiteSpace((string)value)) {
                        result = GetDefaultValueOfType(destinationType);
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool TryConvertByDefaultTypeConverters(object value, Type destinationType, CultureInfo culture, ref object result) {
            TypeConverter converter = TypeDescriptor.GetConverter(destinationType);
            if (converter != null) {
                if (converter.CanConvertFrom(value.GetType())) {
                    try {
                        // ReSharper disable AssignNullToNotNullAttribute
                        result = converter.ConvertFrom(null, culture, value);
                        // ReSharper restore AssignNullToNotNullAttribute
                        return true;
                    }
                    // ReSharper disable EmptyGeneralCatchClause
                    catch {
                        // ReSharper restore EmptyGeneralCatchClause
                    }
                }
            }

            converter = TypeDescriptor.GetConverter(value);
            if (converter != null) {
                if (converter.CanConvertTo(destinationType)) {
                    try {
                        result = converter.ConvertTo(null, culture, value, destinationType);
                        return true;

                    }
                    // ReSharper disable EmptyGeneralCatchClause
                    catch {
                        // ReSharper restore EmptyGeneralCatchClause
                    }
                }
            }
            return false;
        }

        private static bool TryConvertByIConvertibleImplementation(object value, Type destinationType, IFormatProvider formatProvider, ref object result) {
            IConvertible convertible = value as IConvertible;
            if (convertible != null) {
                try {
                    if (destinationType == typeof(Boolean)) {
                        result = convertible.ToBoolean(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(Byte)) {
                        result = convertible.ToByte(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(Char)) {
                        result = convertible.ToChar(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(DateTime)) {
                        result = convertible.ToDateTime(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(Decimal)) {
                        result = convertible.ToDecimal(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(Double)) {
                        result = convertible.ToDouble(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(Int16)) {
                        result = convertible.ToInt16(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(Int32)) {
                        result = convertible.ToInt32(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(Int64)) {
                        result = convertible.ToInt64(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(SByte)) {
                        result = convertible.ToSByte(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(Single)) {
                        result = convertible.ToSingle(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(UInt16)) {
                        result = convertible.ToUInt16(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(UInt32)) {
                        result = convertible.ToUInt32(formatProvider);
                        return true;
                    }
                    if (destinationType == typeof(UInt64)) {
                        result = convertible.ToUInt64(formatProvider);
                        return true;
                    }
                }
                catch {
                    return false;
                }
            }
            return false;
        }

        private static bool TryConvertXPlicit(object value, Type destinationType, string operatorMethodName, ref object result) {
            if (TryConvertXPlicit(value, value.GetType(), destinationType, operatorMethodName, ref result)) {
                return true;
            }
            if (TryConvertXPlicit(value, destinationType, destinationType, operatorMethodName, ref result)) {
                return true;
            }
            return false;
        }

        private static bool TryConvertXPlicit(object value, Type invokerType, Type destinationType, string xPlicitMethodName, ref object result) {
            var methods = invokerType.GetMethods(BindingFlags.Public | BindingFlags.Static);
            foreach (MethodInfo method in methods.Where(m => m.Name == xPlicitMethodName)) {
                if (destinationType.IsAssignableFrom(method.ReturnType)) {
                    var parameters = method.GetParameters();
                    if (parameters.Count() == 1 && parameters[0].ParameterType == value.GetType()) {
                        try {
                            result = method.Invoke(null, new[] { value });
                            return true;
                        }
                        // ReSharper disable EmptyGeneralCatchClause
                        catch {
                            // ReSharper restore EmptyGeneralCatchClause
                        }
                    }
                }
            }
            return false;
        }

        private static bool TryConvertByIntermediateConversion(object value, Type destinationType, ref object result, CultureInfo culture, ConversionOptions options) {
            if (value is char
                && (destinationType == typeof(double) || destinationType == typeof(float))) {
                return TryConvertCore(System.Convert.ToInt16(value), destinationType, ref result, culture, options);
            }
            if ((value is double || value is float) && destinationType == typeof(char)) {
                return TryConvertCore(System.Convert.ToInt16(value), destinationType, ref result, culture, options);
            }
            return false;
        }

        private static bool TryConvertToEnum(object value, Type destinationType, ref object result) {
            try {
                result = Enum.ToObject(destinationType, value);
                return true;
            }
            catch {
                return false;
            }
        }

    }
}
