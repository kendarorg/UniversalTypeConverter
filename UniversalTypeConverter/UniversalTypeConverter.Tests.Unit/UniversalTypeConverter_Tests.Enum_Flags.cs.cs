using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    partial class UniversalTypeConverter_Tests {

        [TestMethod]
        public void ConvertTo_String_From_FlagsEnum_Should_Return_String() {
            UniversalTypeConverter.ConvertTo<string>(FlagsTestEnum.Value1 | FlagsTestEnum.Value4).Should().Be("Value1, Value4");
        }

        [TestMethod]
        public void ConvertTo_FlagsEnum_From_String_Should_Return_Enum() {
            UniversalTypeConverter.ConvertTo<FlagsTestEnum>("Value1, Value4").Should().Be(FlagsTestEnum.Value1 | FlagsTestEnum.Value4);
        }

        [TestMethod]
        public void ConvertTo_Int_From_FlagsEnum_Should_Return_Int() {
            UniversalTypeConverter.ConvertTo<int>(FlagsTestEnum.Value1 | FlagsTestEnum.Value4).Should().Be(5);
        }

        [TestMethod]
        public void ConvertTo_FlagsEnum_From_Int_Should_Return_Enum() {
            UniversalTypeConverter.ConvertTo<FlagsTestEnum>(5).Should().Be(FlagsTestEnum.Value1 | FlagsTestEnum.Value4);
        }

    }
}
