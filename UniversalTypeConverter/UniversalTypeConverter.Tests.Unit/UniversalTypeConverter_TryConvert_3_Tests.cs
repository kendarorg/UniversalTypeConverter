﻿using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_TryConvert_3_Tests {

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
        public void TryConvert_Should_Use_CurrentCulture_As_Default() {
            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);
            string input = inputDate.ToString(CultureInfo.CurrentCulture);
            object result;
            UniversalTypeConverter.TryConvert(input, typeof(DateTime), out result, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            result.Should().Be(inputDate);
        }

        [TestMethod]
        public void TryConvert_Should_Use_The_Given_ConversionOptions() {
            object result;
            UniversalTypeConverter.TryConvert('y', typeof(bool), out result, ConversionOptions.EnhancedTypicalValues).Should().BeTrue();
            UniversalTypeConverter.TryConvert('y', typeof(bool), out result, ConversionOptions.None).Should().BeFalse();
        }
    }
}
