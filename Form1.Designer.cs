namespace applicationezel
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAPATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rENKGETİRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRİDÖNÜŞÜMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kANALSIRALAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.iŞLEMLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAPATToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // kAPATToolStripMenuItem
            // 
            this.kAPATToolStripMenuItem.Name = "kAPATToolStripMenuItem";
            this.kAPATToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kAPATToolStripMenuItem.Text = "KAPAT";
            this.kAPATToolStripMenuItem.Click += new System.EventHandler(this.kAPATToolStripMenuItem_Click);
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            this.iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rENKGETİRToolStripMenuItem,
            this.gRİDÖNÜŞÜMToolStripMenuItem,
            this.kANALSIRALAToolStripMenuItem});
            this.iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            this.iŞLEMLERToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // rENKGETİRToolStripMenuItem
            // 
            this.rENKGETİRToolStripMenuItem.Name = "rENKGETİRToolStripMenuItem";
            this.rENKGETİRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rENKGETİRToolStripMenuItem.Text = "RENKGETİR";
            this.rENKGETİRToolStripMenuItem.Click += new System.EventHandler(this.rENKGETİRToolStripMenuItem_Click);
            // 
            // gRİDÖNÜŞÜMToolStripMenuItem
            // 
            this.gRİDÖNÜŞÜMToolStripMenuItem.Name = "gRİDÖNÜŞÜMToolStripMenuItem";
            this.gRİDÖNÜŞÜMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gRİDÖNÜŞÜMToolStripMenuItem.Text = "GRİDÖNÜŞÜM";
            this.gRİDÖNÜŞÜMToolStripMenuItem.Click += new System.EventHandler(this.gRİDÖNÜŞÜMToolStripMenuItem_Click);
            // 
            // kANALSIRALAToolStripMenuItem
            // 
            this.kANALSIRALAToolStripMenuItem.Name = "kANALSIRALAToolStripMenuItem";
            this.kANALSIRALAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kANALSIRALAToolStripMenuItem.Text = "KANALSIRALA";
            this.kANALSIRALAToolStripMenuItem.Click += new System.EventHandler(this.kANALSIRALAToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 249);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAPATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rENKGETİRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRİDÖNÜŞÜMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kANALSIRALAToolStripMenuItem;
    }
}

