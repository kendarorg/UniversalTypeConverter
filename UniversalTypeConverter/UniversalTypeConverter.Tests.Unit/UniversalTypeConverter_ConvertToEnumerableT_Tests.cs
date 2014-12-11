using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_ConvertToEnumerableT_Tests {

        [TestMethod]
        public void ConvertToEnumerableT_Should_Convert_All_Values_To_T() {
            List<object> values = new List<object>();
            values.Add(true);
            values.Add("11");
            values.Add(111);

            var result = UniversalTypeConverter.ConvertToEnumerable<int>(values).ToArray();
            result.Length.Should().Be(3);
            result[0].Should().Be(1);
            result[1].Should().Be(11);
            result[2].Should().Be(111);
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Not_Ignore_NullElements_By_Default() {
            List<object> values = new List<object>();
            values.Add(true);
            values.Add(null);
            values.Add(111);

            var result = UniversalTypeConverter.ConvertToEnumerable<int?>(values).ToArray();
            result.Length.Should().Be(3);
            result[0].Should().Be(1);
            result[1].Should().Be(null);
            result[2].Should().Be(111);
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Ignore_NullElements_On_Demand() {
            List<object> values = new List<object>();
            values.Add(true);
            values.Add(null);
            values.Add(111);

            var result = UniversalTypeConverter.ConvertToEnumerable<int>(values)
                .IgnoringNullElements()
                .ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be(1);
            result[1].Should().Be(111);
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Not_Ignore_NonConvertibleElements_By_Default() {
            List<object> values = new List<object>();
            values.Add(1);
            values.Add(DateTime.Now);

            Action action = () => UniversalTypeConverter.ConvertToEnumerable<int?>(values).ToArray();
            action.ShouldThrow<InvalidConversionException>();
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Ignore_NonConvertibleElements_On_Demand() {
            List<object> values = new List<object>();
            values.Add(1);
            values.Add(DateTime.Now);

            var result = UniversalTypeConverter.ConvertToEnumerable<int?>(values)
                .IgnoringNonConvertibleElements()
                .ToArray();
            result.Length.Should().Be(1);
            result[0].Should().Be(1);
        }

        [TestMethod]
        public void ConvertToEnumerableT_Try_With_Valid_Input_Should_Return_True_And_Converted_Values() {
            List<object> values = new List<object>();
            values.Add(true);
            values.Add("11");
            values.Add(111);

            IEnumerable<int> result;
            UniversalTypeConverter.ConvertToEnumerable<int>(values).Try(out result).Should().BeTrue();
            var resultAsArray = result.ToArray();
            resultAsArray.Length.Should().Be(3);
            resultAsArray[0].Should().Be(1);
            resultAsArray[1].Should().Be(11);
            resultAsArray[2].Should().Be(111);
        }

        [TestMethod]
        public void ConvertToEnumerableT_Try_With_Invalid_Input_Should_Return_False() {
            List<object> values = new List<object>();
            values.Add(true);
            values.Add(DateTime.Now);

            IEnumerable<int> result;
            UniversalTypeConverter.ConvertToEnumerable<int>(values).Try(out result).Should().BeFalse();
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Use_The_Given_ConversionOptions() {
            List<object> values = new List<object>();
            values.Add("1");
            values.Add(null);

            int[] result = UniversalTypeConverter.ConvertToEnumerable<int>(values)
                .UsingConversionOptions(ConversionOptions.AllowDefaultValueIfNull)
                .ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be(1);
            result[1].Should().Be(0);
        }

        [TestMethod]
        public void ConvertToEnumerableT_With_Full_Options() {
            string[] sourceValues = new[] { "12", null, "118", "xyz" };
            int[] convertedValues = sourceValues.ConvertToEnumerable<int>()
                // null values in the input are ignored.
                .IgnoringNullElements()
                // values which are not convertible to the destination type are ignored.
                .IgnoringNonConvertibleElements()
                // Specifies the culture to use.
                .UsingCulture(CultureInfo.CurrentCulture)
                // Specifies the options to use.
                .UsingConversionOptions(ConversionOptions.AllowDefaultValueIfWhitespace)
                .ToArray();

            convertedValues.Length.Should().Be(2);
            convertedValues[0].Should().Be(12);
            convertedValues[1].Should().Be(118);
        }
    }
}
