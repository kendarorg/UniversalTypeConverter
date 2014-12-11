namespace TB.ComponentModel.Tests.Unit {
    public class TestStringConcatenator : IStringConcatenator {
        private readonly string mReturnValue;

        public TestStringConcatenator(string returnValue) {
            mReturnValue = returnValue;
        }

        public string Concatenate(string[] values) {
            return mReturnValue;
        }
    }
}