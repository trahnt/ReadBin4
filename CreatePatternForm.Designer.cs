namespace ReadBin4 {
    partial class CreatePatternForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.generateTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.columnLabel = new System.Windows.Forms.Label();
            this.createPatternButton = new System.Windows.Forms.Button();
            this.areaNameTextBox = new System.Windows.Forms.TextBox();
            this.areaNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Location = new System.Drawing.Point(433, 52);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(146, 31);
            this.columnsTextBox.TabIndex = 3;
            // 
            // generateTable
            // 
            this.generateTable.Location = new System.Drawing.Point(624, 52);
            this.generateTable.Name = "generateTable";
            this.generateTable.Size = new System.Drawing.Size(115, 31);
            this.generateTable.TabIndex = 5;
            this.generateTable.Text = "Generate Table";
            this.generateTable.UseVisualStyleBackColor = true;
            this.generateTable.Click += new System.EventHandler(this.generateTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(179, 104);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 320);
            this.dataGridView1.TabIndex = 6;
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(179, 52);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(155, 31);
            this.rowsTextBox.TabIndex = 1;
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(119, 55);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(54, 25);
            this.rowsLabel.TabIndex = 8;
            this.rowsLabel.Text = "Rows";
            // 
            // columnLabel
            // 
            this.columnLabel.AutoSize = true;
            this.columnLabel.Location = new System.Drawing.Point(345, 55);
            this.columnLabel.Name = "columnLabel";
            this.columnLabel.Size = new System.Drawing.Size(82, 25);
            this.columnLabel.TabIndex = 9;
            this.columnLabel.Text = "Columns";
            // 
            // createPatternButton
            // 
            this.createPatternButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createPatternButton.Location = new System.Drawing.Point(635, 392);
            this.createPatternButton.Name = "createPatternButton";
            this.createPatternButton.Size = new System.Drawing.Size(104, 32);
            this.createPatternButton.TabIndex = 10;
            this.createPatternButton.Text = "Create";
            this.createPatternButton.UseVisualStyleBackColor = true;
            this.createPatternButton.Click += new System.EventHandler(this.createPatternButton_Click);
            // 
            // areaNameTextBox
            // 
            this.areaNameTextBox.Location = new System.Drawing.Point(179, 12);
            this.areaNameTextBox.Name = "areaNameTextBox";
            this.areaNameTextBox.Size = new System.Drawing.Size(155, 31);
            this.areaNameTextBox.TabIndex = 0;
            // 
            // areaNameLabel
            // 
            this.areaNameLabel.AutoSize = true;
            this.areaNameLabel.Location = new System.Drawing.Point(73, 12);
            this.areaNameLabel.Name = "areaNameLabel";
            this.areaNameLabel.Size = new System.Drawing.Size(100, 25);
            this.areaNameLabel.TabIndex = 12;
            this.areaNameLabel.Text = "Area Name";
            // 
            // CreatePatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.areaNameLabel);
            this.Controls.Add(this.areaNameTextBox);
            this.Controls.Add(this.createPatternButton);
            this.Controls.Add(this.columnLabel);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generateTable);
            this.Controls.Add(this.columnsTextBox);
            this.Name = "CreatePatternForm";
            this.Text = "Create Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox columnsTextBox;
        private Button generateTable;
        private DataGridView dataGridView1;
        private TextBox rowsTextBox;
        private Label rowsLabel;
        private Label columnLabel;
        private Button createPatternButton;
        private TextBox areaNameTextBox;
        private Label areaNameLabel;
    }
}