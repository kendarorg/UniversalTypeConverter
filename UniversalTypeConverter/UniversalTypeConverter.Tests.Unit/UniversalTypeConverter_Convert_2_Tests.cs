using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_Convert_2_Tests {

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
            UniversalTypeConverter.Convert(input, typeof(decimal), CultureInfo.InvariantCulture).Should().Be(1234.56M);
            input = 1234.56M.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.Convert(input, typeof(decimal), CultureInfo.CurrentCulture).Should().Be(1234.56M);

            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);
            input = inputDate.ToString(CultureInfo.InvariantCulture);
            UniversalTypeConverter.Convert(input, typeof(DateTime), CultureInfo.InvariantCulture).Should().Be(inputDate);
            input = inputDate.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.Convert(input, typeof(DateTime), CultureInfo.CurrentCulture).Should().Be(inputDate);
        }


        [TestMethod]
        public void Convert_Should_Use_DefaultOptions() {
            UniversalTypeConverter.Convert('y', typeof(bool), CultureInfo.CurrentCulture).Should().Be(true);
        }

    }
}
