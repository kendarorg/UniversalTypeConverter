using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    public partial class UniversalTypeConverter_Tests {

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Bool_WithValueFalse_ShouldThrowInvalidOperationException() {
            bool value = false;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Bool_WithValueTrue_ShouldThrowInvalidOperationException() {
            bool value = true;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableBool_WithValueFalse_ShouldThrowInvalidOperationException() {
            bool? value = false;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableBool_WithValueNull_ShouldReturn_Null() {
            bool? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableBool_WithValueTrue_ShouldThrowInvalidOperationException() {
            bool? value = true;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Byte_WithValue1_ShouldThrowInvalidOperationException() {
            byte value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableByte_WithValue1_ShouldThrowInvalidOperationException() {
            byte? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableByte_WithValueNull_ShouldReturn_Null() {
            byte? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Char_WithValue100_ShouldThrowInvalidOperationException() {
            char value = (char)100;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableChar_WithValue100_ShouldThrowInvalidOperationException() {
            char? value = (char)100;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableChar_WithValueNull_ShouldReturn_Null() {
            char? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableDateTime_WithValueNull_ShouldReturn_Null() {
            DateTime? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Decimal_WithValue1_ShouldThrowInvalidOperationException() {
            decimal value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableDecimal_WithValue1_ShouldThrowInvalidOperationException() {
            decimal? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableDecimal_WithValueNull_ShouldReturn_Null() {
            decimal? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Double_WithValue1_ShouldThrowInvalidOperationException() {
            double value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableDouble_WithValue1_ShouldThrowInvalidOperationException() {
            double? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableDouble_WithValueNull_ShouldReturn_Null() {
            double? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Float_WithValue1_ShouldThrowInvalidOperationException() {
            float value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableFloat_WithValue1_ShouldThrowInvalidOperationException() {
            float? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableFloat_WithValueNull_ShouldReturn_Null() {
            float? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Int_WithValue1_ShouldThrowInvalidOperationException() {
            int value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableInt_WithValue1_ShouldThrowInvalidOperationException() {
            int? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableInt_WithValueNull_ShouldReturn_Null() {
            int? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Long_WithValue1_ShouldThrowInvalidOperationException() {
            long value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableLong_WithValue1_ShouldThrowInvalidOperationException() {
            long? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableLong_WithValueNull_ShouldReturn_Null() {
            long? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Object_WithValue1_ShouldThrowInvalidOperationException() {
            object value = "1";
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Object_WithValueNull_ShouldReturn_Null() {
            object value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_SByte_WithValue1_ShouldThrowInvalidOperationException() {
            sbyte value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableSByte_WithValue1_ShouldThrowInvalidOperationException() {
            sbyte? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableSByte_WithValueNull_ShouldReturn_Null() {
            sbyte? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_Short_WithValue1_ShouldThrowInvalidOperationException() {
            short value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableShort_WithValue1_ShouldThrowInvalidOperationException() {
            short? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableShort_WithValueNull_ShouldReturn_Null() {
            short? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_String_WithValue1_ShouldThrowInvalidOperationException() {
            string value = "1";
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_String_WithValueAbc_ShouldThrowInvalidOperationException() {
            string value = "abc";
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_String_WithValueNull_ShouldReturn_Null() {
            string value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_UInt_WithValue1_ShouldThrowInvalidOperationException() {
            uint value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableUInt_WithValue1_ShouldThrowInvalidOperationException() {
            uint? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableUInt_WithValueNull_ShouldReturn_Null() {
            uint? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_ULong_WithValue1_ShouldThrowInvalidOperationException() {
            ulong value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableULong_WithValue1_ShouldThrowInvalidOperationException() {
            ulong? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableULong_WithValueNull_ShouldReturn_Null() {
            ulong? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_UShort_WithValue1_ShouldThrowInvalidOperationException() {
            ushort value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableUShort_WithValue1_ShouldThrowInvalidOperationException() {
            ushort? value = 1;
            Action action = () => UniversalTypeConverter.ConvertTo<DateTime?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableDateTime_From_NullableUShort_WithValueNull_ShouldReturn_Null() {
            ushort? value = null;
            DateTime? expectedValue = null;
            UniversalTypeConverter.ConvertTo<DateTime?>(value).HasValue.Should().BeFalse();
        }

    }
}
