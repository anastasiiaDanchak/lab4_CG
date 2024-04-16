namespace lab4_CG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trbBrightnees = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransformInHSB = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.TransformInRGB = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightnees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change brightness";
            // 
            // trbBrightnees
            // 
            this.trbBrightnees.Location = new System.Drawing.Point(209, 33);
            this.trbBrightnees.Margin = new System.Windows.Forms.Padding(4);
            this.trbBrightnees.Maximum = 50;
            this.trbBrightnees.Minimum = -50;
            this.trbBrightnees.Name = "trbBrightnees";
            this.trbBrightnees.Size = new System.Drawing.Size(432, 56);
            this.trbBrightnees.TabIndex = 8;
            this.trbBrightnees.Scroll += new System.EventHandler(this.ChangeBrightness);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(480, 127);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 353);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 127);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 353);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(128, 26);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(128, 26);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransformInHSB,
            this.TransformInRGB});
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // TransformInHSB
            // 
            this.TransformInHSB.Name = "TransformInHSB";
            this.TransformInHSB.Size = new System.Drawing.Size(224, 26);
            this.TransformInHSB.Text = "In HSB";
            this.TransformInHSB.Click += new System.EventHandler(this.TransformInHSB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 499);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(433, 52);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(480, 499);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(432, 52);
            this.listBox2.TabIndex = 11;
            // 
            // TransformInRGB
            // 
            this.TransformInRGB.Name = "TransformInRGB";
            this.TransformInRGB.Size = new System.Drawing.Size(224, 26);
            this.TransformInRGB.Text = "In RGB";
            this.TransformInRGB.Click += new System.EventHandler(this.TransformInRGB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 710);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbBrightnees);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightnees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbBrightnees;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransformInHSB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolStripMenuItem TransformInRGB;
    }
}

