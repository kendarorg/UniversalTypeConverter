using System.Collections;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class ObjectExtension_Tests {

        #region [ CanConvertToT ]
        [TestMethod]
        public void CanConvertToT_Should_Execute() {
            "1".CanConvertTo<int>().Should().BeTrue();
        }

        [TestMethod]
        public void CanConvertToT_With_CultureInfo_Should_Execute() {
            1.23M.CanConvertTo<string>(CultureInfo.InvariantCulture).Should().BeTrue();
        }

        [TestMethod]
        public void CanConvertToT_With_ConversionOptions_Should_Execute() {
            string input = null;
            input.CanConvertTo<int>(ConversionOptions.AllowDefaultValueIfNull).Should().BeTrue();
        }

        [TestMethod]
        public void CanConvertToT_With_CultureInfo_And_ConversionOptions_Should_Execute() {
            "1".CanConvertTo<int>(CultureInfo.InvariantCulture, ConversionOptions.None).Should().BeTrue();
        }
        #endregion

        #region [ ConvertToT ]
        [TestMethod]
        public void ConvertToT_Without_Parameters_Should_Execute() {
            "1".ConvertTo<int>().Should().Be(1);
        }

        [TestMethod]
        public void ConvertToT_With_CultureInfo_Should_Execute() {
            1.23M.ConvertTo<string>(CultureInfo.InvariantCulture).Should().Be("1.23");
        }

        [TestMethod]
        public void ConvertToT_With_ConversionOptions_Should_Execute() {
            string input = null;
            input.ConvertTo<int>(ConversionOptions.AllowDefaultValueIfNull).Should().Be(0);
        }

        [TestMethod]
        public void ConvertToT_With_CultureInfo_And_ConversionOptions_Should_Execute() {
            "1".ConvertTo<int>(CultureInfo.InvariantCulture, ConversionOptions.None).Should().Be(1);
        }
        #endregion

        #region [ TryConvertToT ]
        [TestMethod]
        public void TryConvertToT_Should_Execute() {
            int result;
            "1".TryConvertTo(out result).Should().BeTrue();
            result.Should().Be(1);
        }

        [TestMethod]
        public void TryConvertToT_With_CultureInfo_Should_Execute() {
            string result;
            1.23M.TryConvertTo(out result, CultureInfo.InvariantCulture).Should().BeTrue();
            result.Should().Be("1.23");
        }

        [TestMethod]
        public void TryConvertToT_With_ConversionOptions_Should_Execute() {
            int result;
            string input = null;
            input.TryConvertTo(out result, ConversionOptions.AllowDefaultValueIfNull).Should().BeTrue();
            result.Should().Be(0);
        }

        [TestMethod]
        public void TryConvertToT_With_CultureInfo_And_ConversionOptions_Should_Execute() {
            int result;
            "1".TryConvertTo(out result, CultureInfo.InvariantCulture, ConversionOptions.None).Should().BeTrue();
            result.Should().Be(1);
        }
        #endregion

        #region [ Convert ]
        [TestMethod]
        public void Convert_Without_Parameters_Should_Execute() {
            "1".Convert(typeof(int)).Should().Be(1);
        }

        [TestMethod]
        public void Convert_With_CultureInfo_Should_Execute() {
            1.23M.Convert(typeof(string), CultureInfo.InvariantCulture).Should().Be("1.23");
        }

        [TestMethod]
        public void Convert_With_ConversionOptions_Should_Execute() {
            string input = null;
            input.Convert(typeof(int), ConversionOptions.AllowDefaultValueIfNull).Should().Be(0);
        }

        [TestMethod]
        public void Convert_With_CultureInfo_And_ConversionOptions_Should_Execute() {
            "1".Convert(typeof(int), CultureInfo.InvariantCulture, ConversionOptions.None).Should().Be(1);
        }
        #endregion

        #region [ TryConvert ]
        [TestMethod]
        public void TryConvert_Should_Execute() {
            object result;
            "1".TryConvert(typeof(int), out result).Should().BeTrue();
            result.Should().Be(1);
        }

        [TestMethod]
        public void TryConvert_With_CultureInfo_Should_Execute() {
            object result;
            1.23M.TryConvert(typeof(string), out result, CultureInfo.InvariantCulture).Should().BeTrue();
            result.Should().Be("1.23");
        }

        [TestMethod]
        public void TryConvert_With_ConversionOptions_Should_Execute() {
            object result;
            string input = null;
            input.TryConvert(typeof(int), out result, ConversionOptions.AllowDefaultValueIfNull).Should().BeTrue();
            result.Should().Be(0);
        }

        [TestMethod]
        public void TryConvert_With_CultureInfo_And_ConversionOptions_Should_Execute() {
            object result;
            "1".TryConvert(typeof(int), out result, CultureInfo.InvariantCulture, ConversionOptions.None).Should().BeTrue();
            result.Should().Be(1);
        }
        #endregion

        #region [ CanConvert ]
        [TestMethod]
        public void CanConvert_Should_Execute() {
            "1".CanConvert(typeof(int)).Should().BeTrue();
        }

        [TestMethod]
        public void CanConvert_With_CultureInfo_Should_Execute() {
            1.23M.CanConvert(typeof(string), CultureInfo.InvariantCulture).Should().BeTrue();
        }

        [TestMethod]
        public void CanConvert_With_ConversionOptions_Should_Execute() {
            string input = null;
            input.CanConvert(typeof(int), ConversionOptions.AllowDefaultValueIfNull).Should().BeTrue();
        }

        [TestMethod]
        public void CanConvert_With_CultureInfo_And_ConversionOptions_Should_Execute() {
            "1".CanConvert(typeof(int), CultureInfo.InvariantCulture, ConversionOptions.None).Should().BeTrue();
        }
        #endregion

        #region [ ConvertToEnumerable<T> ]
        [TestMethod]
        public void ConvertToEnumerableT_With_Enumerable_Should_Execute() {
            object[] input = new object[] {"1", "2"};
            input.ConvertToEnumerable<int>().Count().Should().Be(2);
        }

        [TestMethod]
        public void ConvertToEnumerableT_With_StringValueList_Should_Execute() {
            string input = "1;2";
            input.ConvertToEnumerable<int>().Count().Should().Be(2);
        }

        [TestMethod]
        public void ConvertToEnumerableT_With_StringValueList_With_Seperator_Should_Execute() {
            string input = "1,2";
            input.ConvertToEnumerable<int>(",").Count().Should().Be(2);
        }

        [TestMethod]
        public void ConvertToEnumerableT_With_StringSplitter_Should_Execute() {
            string input = "1;2";
            input.ConvertToEnumerable<int>(new TestStringSplitter(new[] {"4"})).ToArray()[0].Should().Be(4);
        }
        #endregion

        #region [ ConvertToEnumerable ]
        [TestMethod]
        public void ConvertToEnumerable_With_Enumerable_Should_Execute() {
            object[] input = new object[] { "1", "2" };
            input.ConvertToEnumerable(typeof(int)).Count().Should().Be(2);
        }

        [TestMethod]
        public void ConvertToEnumerable_With_StringValueList_Should_Execute() {
            string input = "1;2";
            input.ConvertToEnumerable(typeof(int)).Count().Should().Be(2);
        }

        [TestMethod]
        public void ConvertToEnumerable_With_StringValueList_With_Seperator_Should_Execute() {
            string input = "1,2";
            input.ConvertToEnumerable(typeof(int), ",").Count().Should().Be(2);
        }

        [TestMethod]
        public void ConvertToEnumerable_With_StringSplitter_Should_Execute() {
            string input = "1;2";
            input.ConvertToEnumerable(typeof(int), new TestStringSplitter(new[] { "4" })).ToArray()[0].Should().Be(4);
        }
        #endregion

        #region [ ConvertToStringRepresentation ]
        [TestMethod]
        public void ConvertToStringRepresentation_With_IEnumerable_Should_Execute() {
            object[] input = new object[] { 1, 2 };
            input.ConvertToStringRepresentation().Should().Be("1;2");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_With_IEnumerable_With_Seperator_Should_Execute() {
            object[] input = new object[] { 1, 2 };
            input.ConvertToStringRepresentation("-").Should().Be("1-2");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_With_IEnumerable_With_Seperator_With_NullValue_Should_Execute() {
            object[] input = new object[] { 1, null };
            input.ConvertToStringRepresentation("-", "?").Should().Be("1-?");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_With_IEnumerable_With_Culture_Should_Execute() {
            object[] input = new object[] { 1, 2 };
            input.ConvertToStringRepresentation(new CultureInfo("en")).Should().Be("1;2");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_With_IEnumerable_With_StringConcatenator_Should_Execute() {
            object[] input = new object[] { 1, 2 };
            input.ConvertToStringRepresentation(new TestStringConcatenator("Test")).Should().Be("Test");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_With_IEnumerable_With_Culture_With_StringConcatenator_Should_Execute() {
            object[] input = new object[] { 1, 2 };
            input.ConvertToStringRepresentation(new CultureInfo("en"), new TestStringConcatenator("Test")).Should().Be("Test");
        }
        #endregion
    }
}
