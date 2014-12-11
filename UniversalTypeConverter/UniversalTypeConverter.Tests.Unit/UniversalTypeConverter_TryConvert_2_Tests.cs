using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_TryConvert_2_Tests {

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
            UniversalTypeConverter.TryConvert(input, typeof(DateTime), out result, CultureInfo.InvariantCulture).Should().BeTrue();
            result.Should().Be(inputDate);

            input = inputDate.ToString(CultureInfo.CurrentCulture);
            object result2;
            UniversalTypeConverter.TryConvert(input, typeof(DateTime), out result2, CultureInfo.CurrentCulture).Should().BeTrue();
            result2.Should().Be(inputDate);
        }


        [TestMethod]
        public void TryConvert_Should_Use_DefaultOptions() {
            object result;
            UniversalTypeConverter.TryConvert('y', typeof(bool), out result, CultureInfo.CurrentCulture).Should().BeTrue();
            result.Should().Be(true);
        }

    }
}
