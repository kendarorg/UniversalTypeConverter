using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    public partial class UniversalTypeConverter_Tests {

        [TestMethod]
        public void ConvertTo_DateTime_From_Bool_WithValueFalse_ShouldThrowInvalidOperationException() {
            bool value = false;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Bool_WithValueTrue_ShouldThrowInvalidOperationException() {
            bool value = true;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableBool_WithValueFalse_ShouldThrowInvalidOperationException() {
            bool? value = false;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableBool_WithValueNull_ShouldThrowInvalidOperationException() {
            bool? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableBool_WithValueTrue_ShouldThrowInvalidOperationException() {
            bool? value = true;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Byte_WithValue1_ShouldThrowInvalidOperationException() {
            byte value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableByte_WithValue1_ShouldThrowInvalidOperationException() {
            byte? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableByte_WithValueNull_ShouldThrowInvalidOperationException() {
            byte? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Char_WithValue100_ShouldThrowInvalidOperationException() {
            char value = (char)100;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableChar_WithValue100_ShouldThrowInvalidOperationException() {
            char? value = (char)100;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableChar_WithValueNull_ShouldThrowInvalidOperationException() {
            char? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableDateTime_WithValueNull_ShouldThrowInvalidOperationException() {
            DateTime? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Decimal_WithValue1_ShouldThrowInvalidOperationException() {
            decimal value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableDecimal_WithValue1_ShouldThrowInvalidOperationException() {
            decimal? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableDecimal_WithValueNull_ShouldThrowInvalidOperationException() {
            decimal? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Double_WithValue1_ShouldThrowInvalidOperationException() {
            double value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableDouble_WithValue1_ShouldThrowInvalidOperationException() {
            double? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableDouble_WithValueNull_ShouldThrowInvalidOperationException() {
            double? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Float_WithValue1_ShouldThrowInvalidOperationException() {
            float value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableFloat_WithValue1_ShouldThrowInvalidOperationException() {
            float? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableFloat_WithValueNull_ShouldThrowInvalidOperationException() {
            float? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Int_WithValue1_ShouldThrowInvalidOperationException() {
            int value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableInt_WithValue1_ShouldThrowInvalidOperationException() {
            int? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableInt_WithValueNull_ShouldThrowInvalidOperationException() {
            int? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Long_WithValue1_ShouldThrowInvalidOperationException() {
            long value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableLong_WithValue1_ShouldThrowInvalidOperationException() {
            long? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableLong_WithValueNull_ShouldThrowInvalidOperationException() {
            long? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Object_WithValue1_ShouldThrowInvalidOperationException() {
            object value = "1";
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Object_WithValueNull_ShouldThrowInvalidOperationException() {
            object value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_SByte_WithValue1_ShouldThrowInvalidOperationException() {
            sbyte value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableSByte_WithValue1_ShouldThrowInvalidOperationException() {
            sbyte? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableSByte_WithValueNull_ShouldThrowInvalidOperationException() {
            sbyte? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_Short_WithValue1_ShouldThrowInvalidOperationException() {
            short value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableShort_WithValue1_ShouldThrowInvalidOperationException() {
            short? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableShort_WithValueNull_ShouldThrowInvalidOperationException() {
            short? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_String_WithValue1_ShouldThrowInvalidOperationException() {
            string value = "1";
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_String_WithValueAbc_ShouldThrowInvalidOperationException() {
            string value = "abc";
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_String_WithValueNull_ShouldThrowInvalidOperationException() {
            string value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_UInt_WithValue1_ShouldThrowInvalidOperationException() {
            uint value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableUInt_WithValue1_ShouldThrowInvalidOperationException() {
            uint? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableUInt_WithValueNull_ShouldThrowInvalidOperationException() {
            uint? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_ULong_WithValue1_ShouldThrowInvalidOperationException() {
            ulong value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableULong_WithValue1_ShouldThrowInvalidOperationException() {
            ulong? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableULong_WithValueNull_ShouldThrowInvalidOperationException() {
            ulong? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_UShort_WithValue1_ShouldThrowInvalidOperationException() {
            ushort value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableUShort_WithValue1_ShouldThrowInvalidOperationException() {
            ushort? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_DateTime_From_NullableUShort_WithValueNull_ShouldThrowInvalidOperationException() {
            ushort? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

    }
}
