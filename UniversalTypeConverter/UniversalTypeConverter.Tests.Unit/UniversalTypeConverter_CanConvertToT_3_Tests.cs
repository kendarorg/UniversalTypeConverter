using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_CanConvertToT_3_Tests {

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
        public void CanConvertToT_Should_Use_CurrentCulture_As_Default() {
            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);
            string input = inputDate.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.CanConvertTo<DateTime>(input, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
        }

        [TestMethod]
        public void CanConvertToT_Should_Use_The_Given_ConversionOptions() {
            UniversalTypeConverter.CanConvertTo<bool>('y', ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            UniversalTypeConverter.CanConvertTo<bool>('y', ConversionOptions.None).Should().BeFalse();
        }
    }
}
