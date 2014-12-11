using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_ConvertToEnumerable_FromString_Tests {
        [TestMethod]
        public void ConvertToEnumerable_Should_Seperate_String_By_Semicolon_By_Default() {
            const string input = "1;2;3";
            object[] result = UniversalTypeConverter.ConvertToEnumerable(input, typeof(int)).ToArray();
            result.Length.Should().Be(3);
            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(3);
        }

        [TestMethod]
        public void ConvertToEnumerable_Should_Seperate_String_By_Given_Seperator() {
            const string input = "1-2-3";
            object[] result = UniversalTypeConverter.ConvertToEnumerable(input, typeof(int), "-").ToArray();
            result.Length.Should().Be(3);
            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(3);
        }

        [TestMethod]
        public void ConvertToEnumerable_Should_Use_The_Given_StringSeperator() {
            const string input = "1-2-3";
            object[] result =
                UniversalTypeConverter.ConvertToEnumerable(input, typeof(int), new TestStringSplitter(new[] { "4", "5" })).
                    ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be(4);
            result[1].Should().Be(5);
        }

        [TestMethod]
        public void ConvertToEnumerable_With_Full_Options_Should_Execute() {
            string input = "1;;.null.; 3 ;xyz";
            int[] result = input.ConvertToEnumerable<int>(new GenericStringSplitter(";"))
                // specifies how null values are represented within the unput string.
                .WithNullBeing(".null.")
                // Trims the end of each splitted element before conversion.
                .TrimmingEndOfElements()
                // Trims the start of each splitted element before conversion.
                .TrimmingStartOfElements()
                // ignores empty elements.
                .IgnoringEmptyElements()
                // values which are not convertible to the destination type are ignored. 
                .IgnoringNonConvertibleElements()
                // values which are null are ignored. 
                .IgnoringNullElements()
                // Specifies the options to use - have a look above in this article.
                .UsingConversionOptions(ConversionOptions.AllowDefaultValueIfWhitespace)
                // Specifies the culture to use - have a look above in this article.
                .UsingCulture(CultureInfo.CurrentCulture)
                // You can continue with basic Linq:
                .ToArray();

            result.Length.Should().Be(2);
            result[0].Should().Be(1);
            result[1].Should().Be(3);
        }
    }
}
