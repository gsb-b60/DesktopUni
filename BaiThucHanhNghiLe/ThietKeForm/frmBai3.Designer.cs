namespace ThietKeForm
{
    partial class frmBai3
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
            this.lblTuMoi = new System.Windows.Forms.Label();
            this.tbTuMoi = new System.Windows.Forms.TextBox();
            this.lblNghia = new System.Windows.Forms.Label();
            this.tbNghia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lbTuMoi = new System.Windows.Forms.ListBox();
            this.tbXuatNghia = new System.Windows.Forms.TextBox();
            this.lblNghiaCuaTu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTuMoi
            // 
            this.lblTuMoi.AutoSize = true;
            this.lblTuMoi.Location = new System.Drawing.Point(54, 41);
            this.lblTuMoi.Name = "lblTuMoi";
            this.lblTuMoi.Size = new System.Drawing.Size(43, 13);
            this.lblTuMoi.TabIndex = 0;
            this.lblTuMoi.Text = "Tu Moi:";
            // 
            // tbTuMoi
            // 
            this.tbTuMoi.Location = new System.Drawing.Point(170, 38);
            this.tbTuMoi.Name = "tbTuMoi";
            this.tbTuMoi.Size = new System.Drawing.Size(100, 20);
            this.tbTuMoi.TabIndex = 1;
            // 
            // lblNghia
            // 
            this.lblNghia.AutoSize = true;
            this.lblNghia.Location = new System.Drawing.Point(54, 91);
            this.lblNghia.Name = "lblNghia";
            this.lblNghia.Size = new System.Drawing.Size(68, 13);
            this.lblNghia.TabIndex = 2;
            this.lblNghia.Text = "Nghia cua tu\r\n";
            // 
            // tbNghia
            // 
            this.tbNghia.Location = new System.Drawing.Point(170, 91);
            this.tbNghia.Name = "tbNghia";
            this.tbNghia.Size = new System.Drawing.Size(100, 20);
            this.tbNghia.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(82, 127);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Them Tu Moi";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(57, 172);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(97, 13);
            this.lblDanhSach.TabIndex = 5;
            this.lblDanhSach.Text = "Danh Sach Tu Moi";
            // 
            // lbTuMoi
            // 
            this.lbTuMoi.FormattingEnabled = true;
            this.lbTuMoi.Location = new System.Drawing.Point(12, 210);
            this.lbTuMoi.Name = "lbTuMoi";
            this.lbTuMoi.Size = new System.Drawing.Size(156, 212);
            this.lbTuMoi.TabIndex = 6;
            this.lbTuMoi.SelectedIndexChanged += new System.EventHandler(this.lbTuMoi_SelectedIndexChanged);
            // 
            // tbXuatNghia
            // 
            this.tbXuatNghia.Location = new System.Drawing.Point(241, 210);
            this.tbXuatNghia.Multiline = true;
            this.tbXuatNghia.Name = "tbXuatNghia";
            this.tbXuatNghia.ReadOnly = true;
            this.tbXuatNghia.Size = new System.Drawing.Size(179, 115);
            this.tbXuatNghia.TabIndex = 7;
            // 
            // lblNghiaCuaTu
            // 
            this.lblNghiaCuaTu.AutoSize = true;
            this.lblNghiaCuaTu.Location = new System.Drawing.Point(241, 172);
            this.lblNghiaCuaTu.Name = "lblNghiaCuaTu";
            this.lblNghiaCuaTu.Size = new System.Drawing.Size(73, 13);
            this.lblNghiaCuaTu.TabIndex = 8;
            this.lblNghiaCuaTu.Text = "Nghia Cua Tu";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.lblNghiaCuaTu);
            this.Controls.Add(this.tbXuatNghia);
            this.Controls.Add(this.lbTuMoi);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbNghia);
            this.Controls.Add(this.lblNghia);
            this.Controls.Add(this.tbTuMoi);
            this.Controls.Add(this.lblTuMoi);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuMoi;
        private System.Windows.Forms.TextBox tbTuMoi;
        private System.Windows.Forms.Label lblNghia;
        private System.Windows.Forms.TextBox tbNghia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ListBox lbTuMoi;
        private System.Windows.Forms.TextBox tbXuatNghia;
        private System.Windows.Forms.Label lblNghiaCuaTu;
    }
}