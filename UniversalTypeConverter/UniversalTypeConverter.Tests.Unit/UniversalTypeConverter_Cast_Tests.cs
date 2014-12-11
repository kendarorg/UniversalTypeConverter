using System;
using System.Runtime.Serialization;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_Cast_Tests {
        [TestMethod]
        public void Convert_ToImplemetedInterface_ShouldConvert() {
            int value = 1;
            IConvertible convertible = value.ConvertTo<IConvertible>();
            convertible.Should().Be(value);
        }

        [TestMethod]
        public void Convert_FromBaseToDerivedClass_ShouldConvert() {
            TestClassBase derived = new DerivedTestClass();
            DerivedTestClass result = derived.ConvertTo<DerivedTestClass>();
            result.Should().BeSameAs(derived);
        }

        [TestMethod]
        public void Convert_FromDerivedToBase_ShouldConvert() {
            DerivedTestClass derived = new DerivedTestClass();
            TestClassBase result = derived.ConvertTo<TestClassBase>();
            result.Should().BeSameAs(derived);
        }
    }

    public class TestClassBase {
    }
    public class DerivedTestClass : TestClassBase {
    }
}
