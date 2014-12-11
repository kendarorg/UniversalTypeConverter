using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_ConvertToEnumerableT_FromString_Tests {

        [TestMethod]
        public void ConvertToEnumerableT_Should_Seperate_String_By_Semicolon_By_Default() {
            const string input = "1;2;3";
            int[] result = UniversalTypeConverter.ConvertToEnumerable<int>(input).ToArray();
            result.Length.Should().Be(3);
            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(3);
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Seperate_String_By_Given_Seperator() {
            const string input = "1-2-3";
            int[] result = UniversalTypeConverter.ConvertToEnumerable<int>(input, "-").ToArray();
            result.Length.Should().Be(3);
            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(3);
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Use_The_Given_StringSeperator() {
            const string input = "1-2-3";
            int[] result =
                UniversalTypeConverter.ConvertToEnumerable<int>(input, new TestStringSplitter(new[] {"4", "5"})).
                    ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be(4);
            result[1].Should().Be(5);
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Not_Remove_Empty_Entries_By_Default() {
            const string input = "1;;3";
            string[] result = UniversalTypeConverter.ConvertToEnumerable<string>(input).ToArray();
            result.Length.Should().Be(3);
            result[0].Should().Be("1");
            result[1].Should().BeEmpty();
            result[2].Should().Be("3");
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Remove_Empty_Entries_On_Demand() {
            const string input = "1;;3";
            string[] result = UniversalTypeConverter.ConvertToEnumerable<string>(input)
                .IgnoringEmptyElements()
                .ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be("1");
            result[1].Should().Be("3");
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Not_Trim_Start_Of_Entries_By_Default() {
            const string input = "1; 2";
            string[] result = UniversalTypeConverter.ConvertToEnumerable<string>(input).ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be("1");
            result[1].Should().Be(" 2");
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Trim_Start_Of_Entries_On_Demand() {
            const string input = "1; 2";
            string[] result = UniversalTypeConverter.ConvertToEnumerable<string>(input)
                .TrimmingStartOfElements()
                .ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Not_Trim_End_Of_Entries_By_Default() {
            const string input = "1;2 ";
            string[] result = UniversalTypeConverter.ConvertToEnumerable<string>(input).ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be("1");
            result[1].Should().Be("2 ");
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Trim_End_Of_Entries_On_Demand() {
            const string input = "1;2 ";
            string[] result = UniversalTypeConverter.ConvertToEnumerable<string>(input)
                .TrimmingEndOfElements()
                .ToArray();
            result.Length.Should().Be(2);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Recognize_The_Default_NullValue() {
            const string input = "1;<null>;3;.null.";
            string[] result = UniversalTypeConverter.ConvertToEnumerable<string>(input).ToArray();
            result.Length.Should().Be(4);
            result[0].Should().Be("1");
            result[1].Should().Be("<null>");
            result[2].Should().Be("3");
            result[3].Should().BeNull();
        }

        [TestMethod]
        public void ConvertToEnumerableT_Should_Recognize_Given_NullValues() {
            const string input = "1;<null>;?;.null.";
            string[] result = UniversalTypeConverter.ConvertToEnumerable<string>(input)
                .WithNullBeing("?", "<null>")
                .ToArray();
            result.Length.Should().Be(4);
            result[0].Should().Be("1");
            result[1].Should().BeNull();
            result[2].Should().BeNull();
            result[3].Should().Be(".null.");
        }
    }
}
