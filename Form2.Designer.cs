namespace applicationezel
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAPATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rENKGETİRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.renkBox = new System.Windows.Forms.PictureBox();
            this.xkor = new System.Windows.Forms.TextBox();
            this.ykor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.rENKGETİRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇToolStripMenuItem,
            this.kAPATToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // aÇToolStripMenuItem
            // 
            this.aÇToolStripMenuItem.Name = "aÇToolStripMenuItem";
            this.aÇToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aÇToolStripMenuItem.Text = "AÇ";
            this.aÇToolStripMenuItem.Click += new System.EventHandler(this.aÇToolStripMenuItem_Click);
            // 
            // kAPATToolStripMenuItem
            // 
            this.kAPATToolStripMenuItem.Name = "kAPATToolStripMenuItem";
            this.kAPATToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kAPATToolStripMenuItem.Text = "KAPAT";
            this.kAPATToolStripMenuItem.Click += new System.EventHandler(this.kAPATToolStripMenuItem_Click);
            // 
            // rENKGETİRToolStripMenuItem
            // 
            this.rENKGETİRToolStripMenuItem.Name = "rENKGETİRToolStripMenuItem";
            this.rENKGETİRToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.rENKGETİRToolStripMenuItem.Text = "RENKGETİR";
            this.rENKGETİRToolStripMenuItem.Click += new System.EventHandler(this.rENKGETİRToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kaynakBox
            // 
            this.kaynakBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kaynakBox.Location = new System.Drawing.Point(12, 37);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(200, 200);
            this.kaynakBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaynakBox.TabIndex = 2;
            this.kaynakBox.TabStop = false;
            // 
            // renkBox
            // 
            this.renkBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.renkBox.Location = new System.Drawing.Point(351, 37);
            this.renkBox.Name = "renkBox";
            this.renkBox.Size = new System.Drawing.Size(200, 200);
            this.renkBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.renkBox.TabIndex = 3;
            this.renkBox.TabStop = false;
            // 
            // xkor
            // 
            this.xkor.Location = new System.Drawing.Point(230, 45);
            this.xkor.Name = "xkor";
            this.xkor.Size = new System.Drawing.Size(100, 20);
            this.xkor.TabIndex = 4;
            // 
            // ykor
            // 
            this.ykor.Location = new System.Drawing.Point(230, 83);
            this.ykor.Name = "ykor";
            this.ykor.Size = new System.Drawing.Size(100, 20);
            this.ykor.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 302);
            this.Controls.Add(this.ykor);
            this.Controls.Add(this.xkor);
            this.Controls.Add(this.renkBox);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aÇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAPATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rENKGETİRToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.PictureBox renkBox;
        private System.Windows.Forms.TextBox xkor;
        private System.Windows.Forms.TextBox ykor;
    }
}