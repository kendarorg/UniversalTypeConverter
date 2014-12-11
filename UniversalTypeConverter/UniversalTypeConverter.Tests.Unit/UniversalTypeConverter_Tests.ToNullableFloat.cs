using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    public partial class UniversalTypeConverter_Tests {

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Bool_WithValueFalse_ShouldReturn_0() {
            bool value = false;
            float? expectedValue = 0;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Bool_WithValueTrue_ShouldReturn_1() {
            bool value = true;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableBool_WithValueFalse_ShouldReturn_0() {
            bool? value = false;
            float? expectedValue = 0;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableBool_WithValueNull_ShouldReturn_Null() {
            bool? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableBool_WithValueTrue_ShouldReturn_1() {
            bool? value = true;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Byte_WithValue1_ShouldReturn_1() {
            byte value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableByte_WithValue1_ShouldReturn_1() {
            byte? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableByte_WithValueNull_ShouldReturn_Null() {
            byte? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Char_WithValue100_ShouldReturn_100() {
            char value = (char)100;
            float? expectedValue = 100;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableChar_WithValue100_ShouldReturn_100() {
            char? value = (char)100;
            float? expectedValue = 100;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableChar_WithValueNull_ShouldReturn_Null() {
            char? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableDateTime_WithValueNull_ShouldReturn_Null() {
            DateTime? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Decimal_WithValue1_ShouldReturn_1() {
            decimal value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableDecimal_WithValue1_ShouldReturn_1() {
            decimal? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableDecimal_WithValueNull_ShouldReturn_Null() {
            decimal? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Double_WithValue1_ShouldReturn_1() {
            double value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableDouble_WithValue1_ShouldReturn_1() {
            double? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableDouble_WithValueNull_ShouldReturn_Null() {
            double? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Float_WithValue1_ShouldReturn_1() {
            float value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableFloat_WithValue1_ShouldReturn_1() {
            float? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableFloat_WithValueNull_ShouldReturn_Null() {
            float? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Int_WithValue1_ShouldReturn_1() {
            int value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableInt_WithValue1_ShouldReturn_1() {
            int? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableInt_WithValueNull_ShouldReturn_Null() {
            int? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Long_WithValue1_ShouldReturn_1() {
            long value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableLong_WithValue1_ShouldReturn_1() {
            long? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableLong_WithValueNull_ShouldReturn_Null() {
            long? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Object_WithValue1_ShouldReturn_1() {
            object value = "1";
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Object_WithValueNull_ShouldReturn_Null() {
            object value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_SByte_WithValue1_ShouldReturn_1() {
            sbyte value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableSByte_WithValue1_ShouldReturn_1() {
            sbyte? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableSByte_WithValueNull_ShouldReturn_Null() {
            sbyte? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_Short_WithValue1_ShouldReturn_1() {
            short value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableShort_WithValue1_ShouldReturn_1() {
            short? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableShort_WithValueNull_ShouldReturn_Null() {
            short? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_String_WithValue1_ShouldReturn_1() {
            string value = "1";
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_String_WithValueAbc_ShouldThrowInvalidOperationException() {
            string value = "abc";
            Action action = () => UniversalTypeConverter.ConvertTo<float?>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_String_WithValueNull_ShouldReturn_Null() {
            string value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_UInt_WithValue1_ShouldReturn_1() {
            uint value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableUInt_WithValue1_ShouldReturn_1() {
            uint? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableUInt_WithValueNull_ShouldReturn_Null() {
            uint? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_ULong_WithValue1_ShouldReturn_1() {
            ulong value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableULong_WithValue1_ShouldReturn_1() {
            ulong? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableULong_WithValueNull_ShouldReturn_Null() {
            ulong? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_UShort_WithValue1_ShouldReturn_1() {
            ushort value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableUShort_WithValue1_ShouldReturn_1() {
            ushort? value = 1;
            float? expectedValue = 1;
            UniversalTypeConverter.ConvertTo<float?>(value).Should().BeInRange(expectedValue, expectedValue);
        }

        [TestMethod]
        public void ConvertTo_NullableFloat_From_NullableUShort_WithValueNull_ShouldReturn_Null() {
            ushort? value = null;
            float? expectedValue = null;
            UniversalTypeConverter.ConvertTo<float?>(value).HasValue.Should().BeFalse();
        }

    }
}
