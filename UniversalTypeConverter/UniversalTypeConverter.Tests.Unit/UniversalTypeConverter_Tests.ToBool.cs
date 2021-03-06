﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    public partial class UniversalTypeConverter_Tests {

        [TestMethod]
        public void ConvertTo_Bool_From_Bool_WithValueFalse_ShouldReturn_False() {
            bool value = false;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Bool_WithValueTrue_ShouldReturn_True() {
            bool value = true;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableBool_WithValueFalse_ShouldReturn_False() {
            bool? value = false;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableBool_WithValueNull_ShouldThrowInvalidOperationException() {
            bool? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableBool_WithValueTrue_ShouldReturn_True() {
            bool? value = true;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Byte_WithValue0_ShouldReturn_False() {
            byte value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Byte_WithValue1_ShouldReturn_True() {
            byte value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableByte_WithValue0_ShouldReturn_False() {
            byte? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableByte_WithValue1_ShouldReturn_True() {
            byte? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableByte_WithValueNull_ShouldThrowInvalidOperationException() {
            byte? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Char_WithValue0_ShouldReturn_False() {
            char value = '0';
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Char_WithValue1_ShouldReturn_True() {
            char value = '1';
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Char_WithValueF_ShouldReturn_False() {
            char value = 'F';
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Char_WithValueJ_ShouldReturn_True() {
            char value = 'j';
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Char_WithValueN_ShouldReturn_False() {
            char value = 'n';
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Char_WithValueT_ShouldReturn_True() {
            char value = 'T';
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Char_WithValueX_ShouldThrowInvalidOperationException() {
            char value = 'x';
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Char_WithValueY_ShouldReturn_True() {
            char value = 'y';
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableChar_WithValue100_ShouldThrowInvalidOperationException() {
            char? value = (char)100;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableChar_WithValueNull_ShouldThrowInvalidOperationException() {
            char? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableDateTime_WithValueNull_ShouldThrowInvalidOperationException() {
            DateTime? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Decimal_WithValue0_ShouldReturn_False() {
            decimal value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Decimal_WithValue1_ShouldReturn_True() {
            decimal value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableDecimal_WithValue0_ShouldReturn_False() {
            decimal? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableDecimal_WithValue1_ShouldReturn_True() {
            decimal? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableDecimal_WithValueNull_ShouldThrowInvalidOperationException() {
            decimal? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Double_WithValue0_ShouldReturn_False() {
            double value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Double_WithValue1_ShouldReturn_True() {
            double value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableDouble_WithValue0_ShouldReturn_False() {
            double? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableDouble_WithValue1_ShouldReturn_True() {
            double? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableDouble_WithValueNull_ShouldThrowInvalidOperationException() {
            double? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Float_WithValue0_ShouldReturn_False() {
            float value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Float_WithValue1_ShouldReturn_True() {
            float value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableFloat_WithValue0_ShouldReturn_False() {
            float? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableFloat_WithValue1_ShouldReturn_True() {
            float? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableFloat_WithValueNull_ShouldThrowInvalidOperationException() {
            float? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Int_WithValue0_ShouldReturn_False() {
            int value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Int_WithValue1_ShouldReturn_True() {
            int value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableInt_WithValue0_ShouldReturn_False() {
            int? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableInt_WithValue1_ShouldReturn_True() {
            int? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableInt_WithValueNull_ShouldThrowInvalidOperationException() {
            int? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Long_WithValue0_ShouldReturn_False() {
            long value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Long_WithValue1_ShouldReturn_True() {
            long value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableLong_WithValue0_ShouldReturn_False() {
            long? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableLong_WithValue1_ShouldReturn_True() {
            long? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableLong_WithValueNull_ShouldThrowInvalidOperationException() {
            long? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Object_WithValue1_ShouldReturn_True() {
            object value = "1";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Object_WithValueNull_ShouldThrowInvalidOperationException() {
            object value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_SByte_WithValue0_ShouldReturn_False() {
            sbyte value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_SByte_WithValue1_ShouldReturn_True() {
            sbyte value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableSByte_WithValue0_ShouldReturn_False() {
            sbyte? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableSByte_WithValue1_ShouldReturn_True() {
            sbyte? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableSByte_WithValueNull_ShouldThrowInvalidOperationException() {
            sbyte? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Short_WithValue0_ShouldReturn_False() {
            short value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_Short_WithValue1_ShouldReturn_True() {
            short value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableShort_WithValue0_ShouldReturn_False() {
            short? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableShort_WithValue1_ShouldReturn_True() {
            short? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableShort_WithValueNull_ShouldThrowInvalidOperationException() {
            short? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValuePointfPoint_ShouldReturn_False() {
            string value = ".f.";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValuePointtPoint_ShouldReturn_True() {
            string value = ".t.";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValue0_ShouldReturn_False() {
            string value = "0";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValue1_ShouldReturn_True() {
            string value = "1";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueAbc_ShouldThrowInvalidOperationException() {
            string value = "abc";
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueF_ShouldReturn_False() {
            string value = "f";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueFalse_ShouldReturn_False() {
            string value = "false";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueJ_ShouldReturn_True() {
            string value = "j";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueJa_ShouldReturn_True() {
            string value = "ja";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueN_ShouldReturn_False() {
            string value = "n";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueNein_ShouldReturn_False() {
            string value = "nein";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueNo_ShouldReturn_False() {
            string value = "no";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueT_ShouldReturn_True() {
            string value = "t";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueTrue_ShouldReturn_True() {
            string value = "true";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueY_ShouldReturn_True() {
            string value = "y";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueYes_ShouldReturn_True() {
            string value = "yes";
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_String_WithValueNull_ShouldThrowInvalidOperationException() {
            string value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_UInt_WithValue0_ShouldReturn_False() {
            uint value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_UInt_WithValue1_ShouldReturn_True() {
            uint value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableUInt_WithValue0_ShouldReturn_False() {
            uint? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableUInt_WithValue1_ShouldReturn_True() {
            uint? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableUInt_WithValueNull_ShouldThrowInvalidOperationException() {
            uint? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_ULong_WithValue0_ShouldReturn_False() {
            ulong value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_ULong_WithValue1_ShouldReturn_True() {
            ulong value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableULong_WithValue0_ShouldReturn_False() {
            ulong? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableULong_WithValue1_ShouldReturn_True() {
            ulong? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableULong_WithValueNull_ShouldThrowInvalidOperationException() {
            ulong? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_UShort_WithValue0_ShouldReturn_False() {
            ushort value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_UShort_WithValue1_ShouldReturn_True() {
            ushort value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableUShort_WithValue0_ShouldReturn_False() {
            ushort? value = 0;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableUShort_WithValue1_ShouldReturn_True() {
            ushort? value = 1;
            UniversalTypeConverter.ConvertTo<bool>(value).Should().BeTrue();
        }

        [TestMethod]
        public void ConvertTo_Bool_From_NullableUShort_WithValueNull_ShouldThrowInvalidOperationException() {
            ushort? value = null;
            Action action = () => UniversalTypeConverter.ConvertTo<bool>(value);
            action.ShouldThrow<InvalidOperationException>();
        }

    }
}
