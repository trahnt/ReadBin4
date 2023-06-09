namespace ReadBin4 {
    public partial class CreatePatternForm : Form {
        public CreatePatternForm() {
            InitializeComponent();
        }

        private void generateTable_Click(object sender, EventArgs e) {
            int columns = int.Parse(columnsTextBox.Text);
            int rows = int.Parse(rowsTextBox.Text);
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            foreach (DataGridViewRow r in dataGridView1.Rows) {
                r.Height = (dataGridView1.Height - 3) / rows;
            }
            foreach (DataGridViewColumn c in dataGridView1.Columns) {
                c.Width = (dataGridView1.Width - 3) / columns;
            }
        }

        private void createPatternButton_Click(object sender, EventArgs e) {
            string areaName = areaNameTextBox.Text;
            int rows = int.Parse(rowsTextBox.Text);
            int columns = int.Parse(columnsTextBox.Text);
            string[] colorPattern = new string[rows * columns];
            for (int r = 0; r < rows; r++) {
                for (int c = 0; c < columns; c++) {
                    colorPattern[r*columns + c] = (string) dataGridView1.Rows[r].Cells[c].Value;
                }
            }
            MainForm form = (MainForm) this.Owner;
            form.AddPattern(areaName, new Pattern(rows, columns, colorPattern));
        }

        public void AddAreaName(string areaName) {
            areaNameTextBox.Text = areaName;
        }

        public void AddPattern(Pattern pattern) {
            rowsTextBox.Text = Convert.ToString(pattern.rows);
            columnsTextBox.Text = Convert.ToString(pattern.columns);
            dataGridView1.ColumnCount = pattern.columns;
            dataGridView1.RowCount = pattern.rows;
            foreach (DataGridViewRow r in dataGridView1.Rows) {
                r.Height = (dataGridView1.Height - 3) / pattern.rows;
            }
            foreach (DataGridViewColumn c in dataGridView1.Columns) {
                c.Width = (dataGridView1.Width - 3) / pattern.columns;
            }
            for (int r = 0; r < dataGridView1.RowCount; r++) {
                for (int c = 0; c < dataGridView1.ColumnCount; c++) {
                    dataGridView1.Rows[r].Cells[c].Value = pattern.pattern[r * pattern.columns + c];
                }
            }
        }
    }
}