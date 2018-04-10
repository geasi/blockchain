namespace Blockchain {
    public class DataBlock : DataBlockBase
    {
        public string Value { get; set; }

        public DataBlock(string value) {
            this.Value = value;
        }

        public override string ToString() {
            return this.Value;
        }
    }
}