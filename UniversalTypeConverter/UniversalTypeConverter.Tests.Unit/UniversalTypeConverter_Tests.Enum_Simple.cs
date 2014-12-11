using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    public partial class UniversalTypeConverter_Tests {

        [TestMethod]
        public void ConvertTo_String_From_SimpleEnum_Should_Return_String() {
            UniversalTypeConverter.ConvertTo<string>(SimpleTestEnum.Value1).Should().Be("Value1");
        }

        [TestMethod]
        public void ConvertTo_SimpleEnum_From_String_Should_Return_Enum() {
            UniversalTypeConverter.ConvertTo<SimpleTestEnum>("Value1").Should().Be(SimpleTestEnum.Value1);
        }

        [TestMethod]
        public void ConvertTo_Int_From_SimpleEnum_Should_Return_Int() {
            UniversalTypeConverter.ConvertTo<int>(SimpleTestEnum.Value1).Should().Be(1);
        }

        [TestMethod]
        public void ConvertTo_SimpleEnum_From_Int_Should_Return_Enum() {
            UniversalTypeConverter.ConvertTo<SimpleTestEnum>(1).Should().Be(SimpleTestEnum.Value1);
        }

        [TestMethod]
        public void ConvertTo_SimpleEnum_Form_Invalid_Value_Should_Throw_InvalidOperationException() {
            Action action = () => UniversalTypeConverter.ConvertTo<SimpleTestEnum>(true);
            action.ShouldThrow<InvalidOperationException>();
        }

    }
}
