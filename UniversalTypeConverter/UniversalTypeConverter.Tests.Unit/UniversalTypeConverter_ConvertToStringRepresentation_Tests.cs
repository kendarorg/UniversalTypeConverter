using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_ConvertToStringRepresentation_Tests {

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
        public void ConvertToStringRepresentation_Should_Use_Default_Concatenator() {
            object[] input = new object[] { 1, "Test", 2};
            UniversalTypeConverter.ConvertToStringRepresentation(input).Should().Be("1;Test;2");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_Should_Use_The_Given_Seperator() {
            object[] input = new object[] { 1, "Test", 2 };
            UniversalTypeConverter.ConvertToStringRepresentation(input, "-").Should().Be("1-Test-2");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_Should_Use_The_Given_NullValue() {
            object[] input = new object[] { 1, null };
            UniversalTypeConverter.ConvertToStringRepresentation(input, "-", "?").Should().Be("1-?");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_Should_Use_The_Given_Culture() {
            object[] input = new object[] { new DateTime(2012, 6, 30) };
            UniversalTypeConverter.ConvertToStringRepresentation(input, CultureInfo.CreateSpecificCulture("en")).Should().Be("6.30.2012");
        }

        [TestMethod]
        public void ConvertToStringRepresentation_Should_Use_The_Given_StringConcatenator() {
            object[] input = new object[] { 1, 2 };
            UniversalTypeConverter.ConvertToStringRepresentation(input, new TestStringConcatenator("Test")).Should().Be("Test");
        }

        [TestMethod]
        public void CopnvertToStringRepresentation_With_Full_Options_Should_Execute() {
            object[] input = new object[] { 2, null, true, "Hello world!", ""};
            string stringRepresentation = input
                .ConvertToStringRepresentation(CultureInfo.CurrentCulture,
                    new GenericStringConcatenator(";", ".null.", ConcatenationOptions.IgnoreEmpty));

            stringRepresentation.Should().Be("2;.null.;True;Hello world!");
        }
    }
}
