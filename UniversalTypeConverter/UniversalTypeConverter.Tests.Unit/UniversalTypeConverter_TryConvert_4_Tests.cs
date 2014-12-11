using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_TryConvert_4_Tests {

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
        public void TryConvert_Should_Use_The_Given_Culture() {
            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);

            string input = inputDate.ToString(CultureInfo.InvariantCulture);
            object result;
            UniversalTypeConverter.TryConvert(input, typeof(DateTime), out result, CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            result.Should().Be(inputDate);

            input = inputDate.ToString(CultureInfo.CurrentCulture);
            object result2;
            UniversalTypeConverter.TryConvert(input, typeof(DateTime), out result2, CultureInfo.CurrentCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            result2.Should().Be(inputDate);
        }

        [TestMethod]
        public void TryConvert_Should_Use_The_Given_ConversionOptions() {
            object result;
            UniversalTypeConverter.TryConvert('y', typeof(bool), out result, CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            UniversalTypeConverter.TryConvert('y', typeof(bool), out result, CultureInfo.InvariantCulture, ConversionOptions.None).Should().BeFalse();
        }
    }
}
