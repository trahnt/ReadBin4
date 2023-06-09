namespace ReadBin4 {
    public class Area {
        public int[] coordinates; // [x_start, y_start, x_end, y_end] AYA index 1 based
        public List<Pattern> patterns;
        public string name;

        public Area(int[] coordinates, List<Pattern> patterns, string name) {
            this.coordinates = coordinates;
            this.name = name;
            this.patterns = new List<Pattern>();
            foreach (Pattern p in patterns) {
                this.patterns.Add(p.Copy());
            }
        }

        public Area(int[] coordinates, string name) {
            this.coordinates = coordinates;
            this.name = name;
            this.patterns = new List<Pattern>();
        }

        public void AddPattern(Pattern p) {
            patterns.Add(p.Copy());
        }

        public void AddPatterns(List<Pattern> patterns) {
            foreach (Pattern p in patterns) {
                this.patterns.Add(p.Copy());
            }
        }

        public int getRows() {
            return coordinates[3] - coordinates[1] + 1;
        }

        public int getColumns() {
            return coordinates[2] - coordinates[0] + 1;
        }
    }
}
