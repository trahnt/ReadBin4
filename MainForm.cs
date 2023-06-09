using System.Windows.Forms;

namespace ReadBin4 {
    public partial class MainForm : Form {
        List<Area> areas;

        public MainForm() {
            InitializeComponent();
            areas = new List<Area>();
        }

        private void addAreaToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Form form = new CreateAreaForm()) {
                form.ShowDialog(this);
            }
        }

        public void AddToArea(Area a) {
            areas.Add(a);
            menuStrip2.Items.Add(a.name);
            ToolStripItem t = new ToolStripMenuItem();
            t.Text = "Add Pattern";
            t.Click += delegate (object sender, EventArgs e) { AddPatternButtonClick(sender, e, a.name); };
            ((ToolStripMenuItem)menuStrip2.Items[menuStrip2.Items.Count - 1]).DropDownItems.Add(t);
        }

        public void AddPattern(string areaName, Pattern pattern) {
            foreach (Area a in areas) {
                if (a.name == areaName) {
                    a.AddPattern(pattern);
                    break;
                }
            }
            ToolStripItem t1 = new ToolStripMenuItem();
            t1.Text = "Pattern";
            t1.Click += delegate (object sender, EventArgs e) { OpenPatternButtonClick(sender, e, areaName, pattern); };
            foreach (ToolStripMenuItem t in menuStrip2.Items) {
                if (t.Text == areaName) {
                    t.DropDownItems.Add(t1);
                }
            }
        }

        private void AddPatternButtonClick(object sender, EventArgs e, string areaName) {
            using (CreatePatternForm form = new CreatePatternForm()) {
                form.AddAreaName(areaName);
                form.ShowDialog(this);
            }
        }

        private void OpenPatternButtonClick(object sender, EventArgs e, string areaName, Pattern pattern) {
            using (CreatePatternForm form = new CreatePatternForm()) {
                form.AddAreaName(areaName);
                form.AddPattern(pattern);
                form.ShowDialog(this);
            }
        }

        private void WriteAreaFileButton_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string selectedFileName = saveFileDialog.FileName;
                AreaFileManager.WriteFile(this.areas.ToArray(), selectedFileName);
            }
        }

        private void readBinButton_Click(object sender, EventArgs e) {
            string areaFile = "";
            string folderName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "what|*.yeet";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                areaFile = openFileDialog.FileName;
            }
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                folderName = folderBrowserDialog.SelectedPath;
            }
            processingLabel.Text = "Processing...";
            Update();
            ReadBin.Read(folderName, areaFile, this);
            processingLabel.Text = "Done";
        }

        public void UpdateProgressBar(int percent) {
            int val = progressBar1.Value;
            if (val+percent >= 0 && val+percent <= 100)
                progressBar1.Value += percent;
        }

        public void SetProgressBar(int percent) {
            progressBar1.Value = percent;
        }
    }
}
