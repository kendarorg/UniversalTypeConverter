namespace TB.ComponentModel.Tests.Unit {
    public class TestStringSplitter : IStringSplitter {
        private readonly string[] mReturnValues;

        public TestStringSplitter(string[] returnValues) {
            mReturnValues = returnValues;
        }

        public string[] Split(string valueList) {
            return mReturnValues;
        }
    }
}