namespace ThietKeForm
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoTenSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoTenSinhVienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoTenSinhVienToolStripMenuItem
            // 
            this.hoTenSinhVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai1ToolStripMenuItem1,
            this.bai2ToolStripMenuItem1,
            this.bai3ToolStripMenuItem1,
            this.bai4ToolStripMenuItem});
            this.hoTenSinhVienToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hoTenSinhVienToolStripMenuItem.Image")));
            this.hoTenSinhVienToolStripMenuItem.Name = "hoTenSinhVienToolStripMenuItem";
            this.hoTenSinhVienToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.hoTenSinhVienToolStripMenuItem.Text = "Ho Ten Sinh Vien";
            // 
            // bai1ToolStripMenuItem1
            // 
            this.bai1ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bai1ToolStripMenuItem1.Image")));
            this.bai1ToolStripMenuItem1.Name = "bai1ToolStripMenuItem1";
            this.bai1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bai1ToolStripMenuItem1.Text = "Bai 1";
            this.bai1ToolStripMenuItem1.Click += new System.EventHandler(this.bai1ToolStripMenuItem1_Click);
            // 
            // bai2ToolStripMenuItem1
            // 
            this.bai2ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bai2ToolStripMenuItem1.Image")));
            this.bai2ToolStripMenuItem1.Name = "bai2ToolStripMenuItem1";
            this.bai2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bai2ToolStripMenuItem1.Text = "Bai 2";
            this.bai2ToolStripMenuItem1.Click += new System.EventHandler(this.bai2ToolStripMenuItem1_Click);
            // 
            // bai3ToolStripMenuItem1
            // 
            this.bai3ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bai3ToolStripMenuItem1.Image")));
            this.bai3ToolStripMenuItem1.Name = "bai3ToolStripMenuItem1";
            this.bai3ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bai3ToolStripMenuItem1.Text = "Bai 3";
            this.bai3ToolStripMenuItem1.Click += new System.EventHandler(this.bai3ToolStripMenuItem1_Click);
            // 
            // bai4ToolStripMenuItem
            // 
            this.bai4ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bai4ToolStripMenuItem.Image")));
            this.bai4ToolStripMenuItem.Name = "bai4ToolStripMenuItem";
            this.bai4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bai4ToolStripMenuItem.Text = "Bai 4";
            this.bai4ToolStripMenuItem.Click += new System.EventHandler(this.bai4ToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chuong Trinh Chinh";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoTenSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bai2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bai3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bai4ToolStripMenuItem;
    }
}

