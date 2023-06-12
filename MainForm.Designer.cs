namespace ReadBin4 {
    partial class MainForm {
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeAreaFileButton = new System.Windows.Forms.Button();
            this.readBinButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.processingLabel = new System.Windows.Forms.Label();
            this.yeetToTextButton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAreaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(109, 450);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addAreaToolStripMenuItem
            // 
            this.addAreaToolStripMenuItem.Name = "addAreaToolStripMenuItem";
            this.addAreaToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.addAreaToolStripMenuItem.Text = "Add Area";
            this.addAreaToolStripMenuItem.Click += new System.EventHandler(this.addAreaToolStripMenuItem_Click);
            // 
            // writeAreaFileButton
            // 
            this.writeAreaFileButton.Location = new System.Drawing.Point(321, 110);
            this.writeAreaFileButton.Name = "writeAreaFileButton";
            this.writeAreaFileButton.Size = new System.Drawing.Size(145, 41);
            this.writeAreaFileButton.TabIndex = 6;
            this.writeAreaFileButton.Text = "Write Area File";
            this.writeAreaFileButton.UseVisualStyleBackColor = true;
            this.writeAreaFileButton.Click += new System.EventHandler(this.WriteAreaFileButton_Click);
            // 
            // readBinButton
            // 
            this.readBinButton.Location = new System.Drawing.Point(322, 196);
            this.readBinButton.Name = "readBinButton";
            this.readBinButton.Size = new System.Drawing.Size(146, 37);
            this.readBinButton.TabIndex = 7;
            this.readBinButton.Text = "Read Images";
            this.readBinButton.UseVisualStyleBackColor = true;
            this.readBinButton.Click += new System.EventHandler(this.readBinButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(273, 281);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(238, 34);
            this.progressBar1.TabIndex = 8;
            // 
            // processingLabel
            // 
            this.processingLabel.AutoSize = true;
            this.processingLabel.Location = new System.Drawing.Point(534, 290);
            this.processingLabel.Name = "processingLabel";
            this.processingLabel.Size = new System.Drawing.Size(0, 25);
            this.processingLabel.TabIndex = 9;
            // 
            // yeetToTextButton
            // 
            this.yeetToTextButton.Location = new System.Drawing.Point(534, 110);
            this.yeetToTextButton.Name = "yeetToTextButton";
            this.yeetToTextButton.Size = new System.Drawing.Size(168, 41);
            this.yeetToTextButton.TabIndex = 10;
            this.yeetToTextButton.Text = "Convert yeet to txt";
            this.yeetToTextButton.UseVisualStyleBackColor = true;
            this.yeetToTextButton.Click += new System.EventHandler(this.yeetToTextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yeetToTextButton);
            this.Controls.Add(this.processingLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.readBinButton);
            this.Controls.Add(this.writeAreaFileButton);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "MEOW";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem addAreaToolStripMenuItem;
        private Button writeAreaFileButton;
        private Button readBinButton;
        private ProgressBar progressBar1;
        private Label processingLabel;
        private Button yeetToTextButton;
    }
}