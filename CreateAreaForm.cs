using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadBin4 {
    public partial class CreateAreaForm : Form {
        public CreateAreaForm() {
            InitializeComponent();
        }

        private void createAreaButton_Click(object sender, EventArgs e) {
            MainForm form = (MainForm) this.Owner;
            int[] coordinates = new int[4];
            coordinates[0] = int.Parse(xStartTextBox.Text);
            coordinates[1] = int.Parse(yStartTextBox.Text);
            coordinates[2] = int.Parse(xEndTextBox.Text);
            coordinates[3] = int.Parse(yEndTextBox.Text);
            form.AddToArea(new Area(coordinates, areaNameTextBox.Text));
        }
    }
}
