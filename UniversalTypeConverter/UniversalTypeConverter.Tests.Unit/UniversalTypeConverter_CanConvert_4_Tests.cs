using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_CanConvert_4_Tests {

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
        public void CanConvert_Should_Use_The_Given_Culture() {
            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);

            string input = inputDate.ToString(CultureInfo.InvariantCulture);
            UniversalTypeConverter.CanConvert(input, typeof(DateTime), CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();

            input = inputDate.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.CanConvert(input, typeof(DateTime), CultureInfo.CurrentCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
        }

        [TestMethod]
        public void CanConvert_Should_Use_The_Given_ConversionOptions() {
            UniversalTypeConverter.CanConvert('y', typeof(bool), CultureInfo.InvariantCulture, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            UniversalTypeConverter.CanConvert('y', typeof(bool), CultureInfo.InvariantCulture, ConversionOptions.None).Should().BeFalse();
        }
    }
}
