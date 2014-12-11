using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class GenericStringConcatenator_Tests {

        [TestMethod]
        public void Concatenate_Should_Use_Semicolon_By_Default() {
            GenericStringConcatenator concatenator = new GenericStringConcatenator();
            concatenator.Concatenate(new[] {"H", "W"}).Should().Be("H;W");
        }

        [TestMethod]
        public void Concatenate_Should_Use_The_Given_Seperator() {
            GenericStringConcatenator concatenator = new GenericStringConcatenator(":");
            concatenator.Concatenate(new[] { "H", "W" }).Should().Be("H:W");
        }

        [TestMethod]
        public void Concatenate_Should_Use_NullValues_By_Default() {
            GenericStringConcatenator concatenator = new GenericStringConcatenator();
            concatenator.Concatenate(new[] { "H", null }).Should().Be("H;.null.");
        }

        [TestMethod]
        public void Concatenate_Should_Use_The_Given_NullValue() {
            GenericStringConcatenator concatenator = new GenericStringConcatenator(";", "?");
            concatenator.Concatenate(new[] { "H", null }).Should().Be("H;?");
        }

        [TestMethod]
        public void Concatenate_Should_Not_Ignore_Empty_Values_By_Default() {
            GenericStringConcatenator concatenator = new GenericStringConcatenator();
            concatenator.Concatenate(new[] { "H", String.Empty }).Should().Be("H;");
        }

        [TestMethod]
        public void Concatenate_Should_Not_Ignore_Empty_Values_On_Demand() {
            GenericStringConcatenator concatenator = new GenericStringConcatenator(";", ConcatenationOptions.IgnoreEmpty);
            concatenator.Concatenate(new[] { "H", String.Empty }).Should().Be("H");
        }

        [TestMethod]
        public void Concatenate_Should_Not_Ignore_Null_Values_On_Demand() {
            GenericStringConcatenator concatenator = new GenericStringConcatenator(";", ConcatenationOptions.IgnoreNull);
            concatenator.Concatenate(new[] { "H", null }).Should().Be("H");
        }
    }
}
