using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_TryConvertToT_4_Tests {

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
        public void TryConvertToT_Should_Use_The_Given_Culture() {
            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);

            string input = inputDate.ToString(CultureInfo.InvariantCulture);
            DateTime result;
            UniversalTypeConverter.TryConvertTo(input, out result, CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            result.Should().Be(inputDate);

            input = inputDate.ToString(CultureInfo.CurrentCulture);
            DateTime result2;
            UniversalTypeConverter.TryConvertTo(input, out result2, CultureInfo.CurrentCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            result2.Should().Be(inputDate);
        }

        [TestMethod]
        public void TryConvertToT_Should_Use_The_Given_ConversionOptions() {
            bool result;
            UniversalTypeConverter.TryConvertTo('y', out result, CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            UniversalTypeConverter.TryConvertTo('y', out result, CultureInfo.InvariantCulture, ConversionOptions.None).Should().BeFalse();
        }
    }
}
