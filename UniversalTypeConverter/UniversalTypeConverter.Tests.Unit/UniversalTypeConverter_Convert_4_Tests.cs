using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_Convert_4_Tests {

        private CultureInfo mCultureInfo;

        [TestInitialize]
        public void Initialize() {
            mCultureInfo = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
        }

        [TestCleanup]
        public void CleanUp() {
            Thread.CurrentThread.CurrentCulture = mCultureInfo;
        }

        [TestMethod]
        public void Convert_Should_Use_The_Given_Culture() {
            string input = 1234.56M.ToString(CultureInfo.InvariantCulture);
            UniversalTypeConverter.Convert(input, typeof(decimal), CultureInfo.InvariantCulture, ConversionOptions.None).Should().Be(1234.56M);
            input = 1234.56M.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.Convert(input, typeof(decimal), CultureInfo.CurrentCulture, ConversionOptions.None).Should().Be(1234.56M);

            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);
            input = inputDate.ToString(CultureInfo.InvariantCulture);
            UniversalTypeConverter.Convert(input, typeof(DateTime), CultureInfo.InvariantCulture, ConversionOptions.None).Should().Be(inputDate);
            input = inputDate.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.Convert(input, typeof(DateTime), CultureInfo.CurrentCulture, ConversionOptions.None).Should().Be(inputDate);
        }

        [TestMethod]
        public void Convert_Should_Use_The_Given_ConversionOptions() {
            UniversalTypeConverter.Convert('y', typeof(bool), CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().Be(true);

            Action action = () => UniversalTypeConverter.Convert('y', typeof(bool), CultureInfo.InvariantCulture, ConversionOptions.None);
            action.ShouldThrow<InvalidOperationException>();
        }

    }
}
