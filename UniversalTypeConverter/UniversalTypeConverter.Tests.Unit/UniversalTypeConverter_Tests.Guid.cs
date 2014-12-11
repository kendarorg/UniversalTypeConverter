using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    public partial class UniversalTypeConverter_Tests {

        [TestMethod]
        public void ConvertToT_Guid_ToStringAndBack_Should_Convert() {
            Guid guid = new Guid();
            string guidString = UniversalTypeConverter.ConvertTo<string>(guid);
            UniversalTypeConverter.ConvertTo<Guid>(guidString).Should().Be(guid);
        }
    }
}
