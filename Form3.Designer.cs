namespace applicationezel
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAYDETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAPATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRİDÖNÜŞÜMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRTALAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lUMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇIKLIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kANALSIRALAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.gRİDÖNÜŞÜMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇToolStripMenuItem,
            this.kAYDETToolStripMenuItem,
            this.kAPATToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // aÇToolStripMenuItem
            // 
            this.aÇToolStripMenuItem.Name = "aÇToolStripMenuItem";
            this.aÇToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.aÇToolStripMenuItem.Text = "AÇ";
            this.aÇToolStripMenuItem.Click += new System.EventHandler(this.aÇToolStripMenuItem_Click);
            // 
            // kAYDETToolStripMenuItem
            // 
            this.kAYDETToolStripMenuItem.Name = "kAYDETToolStripMenuItem";
            this.kAYDETToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.kAYDETToolStripMenuItem.Text = "KAYDET";
            this.kAYDETToolStripMenuItem.Click += new System.EventHandler(this.kAYDETToolStripMenuItem_Click);
            // 
            // kAPATToolStripMenuItem
            // 
            this.kAPATToolStripMenuItem.Name = "kAPATToolStripMenuItem";
            this.kAPATToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.kAPATToolStripMenuItem.Text = "KAPAT";
            this.kAPATToolStripMenuItem.Click += new System.EventHandler(this.kAPATToolStripMenuItem_Click);
            // 
            // gRİDÖNÜŞÜMToolStripMenuItem
            // 
            this.gRİDÖNÜŞÜMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRTALAMAToolStripMenuItem,
            this.bT709ToolStripMenuItem,
            this.lUMAToolStripMenuItem,
            this.aÇIKLIKToolStripMenuItem,
            this.kANALSIRALAToolStripMenuItem});
            this.gRİDÖNÜŞÜMToolStripMenuItem.Name = "gRİDÖNÜŞÜMToolStripMenuItem";
            this.gRİDÖNÜŞÜMToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.gRİDÖNÜŞÜMToolStripMenuItem.Text = "GRİDÖNÜŞÜM";
            // 
            // oRTALAMAToolStripMenuItem
            // 
            this.oRTALAMAToolStripMenuItem.Name = "oRTALAMAToolStripMenuItem";
            this.oRTALAMAToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.oRTALAMAToolStripMenuItem.Text = "ORTALAMA";
            this.oRTALAMAToolStripMenuItem.Click += new System.EventHandler(this.oRTALAMAToolStripMenuItem_Click);
            // 
            // bT709ToolStripMenuItem
            // 
            this.bT709ToolStripMenuItem.Name = "bT709ToolStripMenuItem";
            this.bT709ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bT709ToolStripMenuItem.Text = "BT709";
            this.bT709ToolStripMenuItem.Click += new System.EventHandler(this.bT709ToolStripMenuItem_Click);
            // 
            // lUMAToolStripMenuItem
            // 
            this.lUMAToolStripMenuItem.Name = "lUMAToolStripMenuItem";
            this.lUMAToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.lUMAToolStripMenuItem.Text = "LUMA";
            this.lUMAToolStripMenuItem.Click += new System.EventHandler(this.lUMAToolStripMenuItem_Click);
            // 
            // aÇIKLIKToolStripMenuItem
            // 
            this.aÇIKLIKToolStripMenuItem.Name = "aÇIKLIKToolStripMenuItem";
            this.aÇIKLIKToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aÇIKLIKToolStripMenuItem.Text = "AÇIKLIK";
            this.aÇIKLIKToolStripMenuItem.Click += new System.EventHandler(this.aÇIKLIKToolStripMenuItem_Click);
            // 
            // kANALSIRALAToolStripMenuItem
            // 
            this.kANALSIRALAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
            this.gToolStripMenuItem,
            this.bToolStripMenuItem});
            this.kANALSIRALAToolStripMenuItem.Name = "kANALSIRALAToolStripMenuItem";
            this.kANALSIRALAToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kANALSIRALAToolStripMenuItem.Text = "KANALÇIKARIM";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kaynakBox
            // 
            this.kaynakBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kaynakBox.Location = new System.Drawing.Point(16, 33);
            this.kaynakBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(265, 245);
            this.kaynakBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaynakBox.TabIndex = 3;
            this.kaynakBox.TabStop = false;
            // 
            // islemBox
            // 
            this.islemBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.islemBox.Location = new System.Drawing.Point(407, 33);
            this.islemBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(265, 245);
            this.islemBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.islemBox.TabIndex = 4;
            this.islemBox.TabStop = false;
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rToolStripMenuItem.Text = "R";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gToolStripMenuItem.Text = "G";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 385);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aÇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAYDETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAPATToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem gRİDÖNÜŞÜMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRTALAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lUMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aÇIKLIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kANALSIRALAToolStripMenuItem;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
    }
}