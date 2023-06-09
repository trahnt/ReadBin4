namespace ReadBin4 {
    public class Pattern {
        public int rows;
        public int columns;
        public string[] pattern;
        public Dictionary<string, double> data;
        public Dictionary<string, int> dataCount;

        public Pattern(int rows, int columns, string[] pattern) {
            this.rows = rows;
            this.columns = columns;
            this.pattern = pattern;
            this.data = new Dictionary<string, double>();
            this.dataCount = new Dictionary<string, int>();
            foreach (string category in pattern) {
                if (!data.ContainsKey(category) && category != "N") {
                    this.data.Add(category, 0);
                    this.dataCount.Add(category, 0);
                }
            }
        }

        public Pattern Copy() {
            Pattern copy = new Pattern(this.rows, this.columns, this.pattern);
            return copy;
        }
    }
}
