using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_CanConvert_2_Tests {

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
            UniversalTypeConverter.CanConvert(input, typeof(DateTime), CultureInfo.InvariantCulture).Should().BeTrue();

            input = inputDate.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.CanConvert(input, typeof(DateTime), CultureInfo.CurrentCulture).Should().BeTrue();
        }


        [TestMethod]
        public void CanConvert_Should_Use_DefaultOptions() {
            UniversalTypeConverter.CanConvert('y', typeof(bool), CultureInfo.CurrentCulture).Should().BeTrue();
        }
    }
}
