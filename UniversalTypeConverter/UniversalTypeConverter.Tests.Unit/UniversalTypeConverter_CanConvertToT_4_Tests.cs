using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_CanConvertToT_4_Tests {

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
        public void CanConvertToT_Should_Use_The_Given_Culture() {
            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);

            string input = inputDate.ToString(CultureInfo.InvariantCulture);
            UniversalTypeConverter.CanConvertTo<DateTime>(input, CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();

            input = inputDate.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.CanConvertTo<DateTime>(input, CultureInfo.CurrentCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
        }

        [TestMethod]
        public void CanConvertToT_Should_Use_The_Given_ConversionOptions() {
            UniversalTypeConverter.CanConvertTo<bool>('y', CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            UniversalTypeConverter.CanConvertTo<bool>('y', CultureInfo.InvariantCulture, ConversionOptions.None).Should().BeFalse();
        }
    }
}
