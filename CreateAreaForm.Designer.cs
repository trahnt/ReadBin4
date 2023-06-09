namespace ReadBin4 {
    partial class CreateAreaForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.areaNameTextBox = new System.Windows.Forms.TextBox();
            this.xStartTextBox = new System.Windows.Forms.TextBox();
            this.yStartTextBox = new System.Windows.Forms.TextBox();
            this.xEndTextBox = new System.Windows.Forms.TextBox();
            this.yEndTextBox = new System.Windows.Forms.TextBox();
            this.createAreaButton = new System.Windows.Forms.Button();
            this.areaNameLabel = new System.Windows.Forms.Label();
            this.xStartLabel = new System.Windows.Forms.Label();
            this.yStartLabel = new System.Windows.Forms.Label();
            this.xEndLabel = new System.Windows.Forms.Label();
            this.yEndLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // areaNameTextBox
            // 
            this.areaNameTextBox.Location = new System.Drawing.Point(264, 49);
            this.areaNameTextBox.Name = "areaNameTextBox";
            this.areaNameTextBox.Size = new System.Drawing.Size(150, 31);
            this.areaNameTextBox.TabIndex = 0;
            // 
            // xStartTextBox
            // 
            this.xStartTextBox.Location = new System.Drawing.Point(261, 116);
            this.xStartTextBox.Name = "xStartTextBox";
            this.xStartTextBox.Size = new System.Drawing.Size(150, 31);
            this.xStartTextBox.TabIndex = 1;
            // 
            // yStartTextBox
            // 
            this.yStartTextBox.Location = new System.Drawing.Point(256, 185);
            this.yStartTextBox.Name = "yStartTextBox";
            this.yStartTextBox.Size = new System.Drawing.Size(150, 31);
            this.yStartTextBox.TabIndex = 2;
            // 
            // xEndTextBox
            // 
            this.xEndTextBox.Location = new System.Drawing.Point(277, 262);
            this.xEndTextBox.Name = "xEndTextBox";
            this.xEndTextBox.Size = new System.Drawing.Size(150, 31);
            this.xEndTextBox.TabIndex = 3;
            // 
            // yEndTextBox
            // 
            this.yEndTextBox.Location = new System.Drawing.Point(287, 344);
            this.yEndTextBox.Name = "yEndTextBox";
            this.yEndTextBox.Size = new System.Drawing.Size(150, 31);
            this.yEndTextBox.TabIndex = 4;
            // 
            // createAreaButton
            // 
            this.createAreaButton.Location = new System.Drawing.Point(578, 190);
            this.createAreaButton.Name = "createAreaButton";
            this.createAreaButton.Size = new System.Drawing.Size(92, 36);
            this.createAreaButton.TabIndex = 5;
            this.createAreaButton.Text = "Create";
            this.createAreaButton.UseVisualStyleBackColor = true;
            this.createAreaButton.Click += new System.EventHandler(this.createAreaButton_Click);
            // 
            // areaNameLabel
            // 
            this.areaNameLabel.AutoSize = true;
            this.areaNameLabel.Location = new System.Drawing.Point(133, 47);
            this.areaNameLabel.Name = "areaNameLabel";
            this.areaNameLabel.Size = new System.Drawing.Size(59, 25);
            this.areaNameLabel.TabIndex = 6;
            this.areaNameLabel.Text = "Name";
            // 
            // xStartLabel
            // 
            this.xStartLabel.AutoSize = true;
            this.xStartLabel.Location = new System.Drawing.Point(145, 124);
            this.xStartLabel.Name = "xStartLabel";
            this.xStartLabel.Size = new System.Drawing.Size(64, 25);
            this.xStartLabel.TabIndex = 7;
            this.xStartLabel.Text = "X Start";
            // 
            // yStartLabel
            // 
            this.yStartLabel.AutoSize = true;
            this.yStartLabel.Location = new System.Drawing.Point(137, 196);
            this.yStartLabel.Name = "yStartLabel";
            this.yStartLabel.Size = new System.Drawing.Size(63, 25);
            this.yStartLabel.TabIndex = 8;
            this.yStartLabel.Text = "Y Start";
            // 
            // xEndLabel
            // 
            this.xEndLabel.AutoSize = true;
            this.xEndLabel.Location = new System.Drawing.Point(144, 274);
            this.xEndLabel.Name = "xEndLabel";
            this.xEndLabel.Size = new System.Drawing.Size(58, 25);
            this.xEndLabel.TabIndex = 9;
            this.xEndLabel.Text = "X End";
            // 
            // yEndLabel
            // 
            this.yEndLabel.AutoSize = true;
            this.yEndLabel.Location = new System.Drawing.Point(146, 357);
            this.yEndLabel.Name = "yEndLabel";
            this.yEndLabel.Size = new System.Drawing.Size(57, 25);
            this.yEndLabel.TabIndex = 10;
            this.yEndLabel.Text = "Y End";
            // 
            // CreateAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yEndLabel);
            this.Controls.Add(this.xEndLabel);
            this.Controls.Add(this.yStartLabel);
            this.Controls.Add(this.xStartLabel);
            this.Controls.Add(this.areaNameLabel);
            this.Controls.Add(this.createAreaButton);
            this.Controls.Add(this.yEndTextBox);
            this.Controls.Add(this.xEndTextBox);
            this.Controls.Add(this.yStartTextBox);
            this.Controls.Add(this.xStartTextBox);
            this.Controls.Add(this.areaNameTextBox);
            this.Name = "CreateAreaForm";
            this.Text = "Create Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox areaNameTextBox;
        private TextBox xStartTextBox;
        private TextBox yStartTextBox;
        private TextBox xEndTextBox;
        private TextBox yEndTextBox;
        private Button createAreaButton;
        private Label areaNameLabel;
        private Label xStartLabel;
        private Label yStartLabel;
        private Label xEndLabel;
        private Label yEndLabel;
    }
}