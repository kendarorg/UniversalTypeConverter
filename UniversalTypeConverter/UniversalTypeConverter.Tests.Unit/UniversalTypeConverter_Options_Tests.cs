using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_Options_Tests {

        [TestMethod]
        public void Null_With_DefaultOption_Should_Throw_InvalidOperationException_If_DestinationType_Is_Not_Nullable() {
            Action action = () => UniversalTypeConverter.ConvertTo<int>(null);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void Null_With_AllowDefaultValueIfNullOption_Should_Convert_To_DefaultValue() {
            UniversalTypeConverter.ConvertTo<int>(null, ConversionOptions.AllowDefaultValueIfNull).Should().Be(0);
        }

        [TestMethod]
        public void EnhancedTypicalValue_With_DefaultOption_Should_Convert() {
            UniversalTypeConverter.ConvertTo<char>(false).Should().Be('F');
        }

        [TestMethod]
        public void EnhancedTypicalValue_Without_EnhancedTypicalValuesOption_Should_Throw_InvalidOperationException() {
            Action action = () => UniversalTypeConverter.ConvertTo<char>(false, ConversionOptions.None);
            action.ShouldThrow<InvalidOperationException>();
        }
        
        [TestMethod]
        public void Whitespace_Without_HandleWhitespaceAsNullOption_Should_Throw_InvalidOperationException() {
            Action action = () => UniversalTypeConverter.ConvertTo<Guid>(String.Empty, ConversionOptions.None);
            action.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void Whitespace_With_HandleWhitespaceAsNullOption_Should_Convert() {
            UniversalTypeConverter.ConvertTo<Guid>(String.Empty, ConversionOptions.AllowDefaultValueIfWhitespace).Should().Be(Guid.Empty);
        }
    }
}
