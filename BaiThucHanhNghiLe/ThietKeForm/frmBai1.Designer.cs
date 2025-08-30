namespace ThietKeForm
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.gbMauXe = new System.Windows.Forms.GroupBox();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblKyHieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.gbMauXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCar
            // 
            this.pbCar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbCar.ErrorImage")));
            this.pbCar.Image = ((System.Drawing.Image)(resources.GetObject("pbCar.Image")));
            this.pbCar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCar.InitialImage")));
            this.pbCar.Location = new System.Drawing.Point(12, 12);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(252, 231);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 0;
            this.pbCar.TabStop = false;
            this.pbCar.Click += new System.EventHandler(this.pbCar_Click);
            // 
            // gbMauXe
            // 
            this.gbMauXe.Controls.Add(this.rdTrang);
            this.gbMauXe.Controls.Add(this.rdDo);
            this.gbMauXe.Controls.Add(this.rdXanh);
            this.gbMauXe.Location = new System.Drawing.Point(292, 60);
            this.gbMauXe.Name = "gbMauXe";
            this.gbMauXe.Size = new System.Drawing.Size(200, 100);
            this.gbMauXe.TabIndex = 1;
            this.gbMauXe.TabStop = false;
            this.gbMauXe.Text = "Chon Mau Xe";
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Location = new System.Drawing.Point(19, 20);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(50, 17);
            this.rdXanh.TabIndex = 0;
            this.rdXanh.TabStop = true;
            this.rdXanh.Text = "Xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.Location = new System.Drawing.Point(19, 44);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(39, 17);
            this.rdDo.TabIndex = 1;
            this.rdDo.TabStop = true;
            this.rdDo.Text = "Do";
            this.rdDo.UseVisualStyleBackColor = true;
            this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
            // 
            // rdTrang
            // 
            this.rdTrang.AutoSize = true;
            this.rdTrang.Location = new System.Drawing.Point(19, 77);
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.Size = new System.Drawing.Size(53, 17);
            this.rdTrang.TabIndex = 2;
            this.rdTrang.TabStop = true;
            this.rdTrang.Text = "Trang";
            this.rdTrang.UseVisualStyleBackColor = true;
            this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(292, 180);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(46, 13);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Don Gia";
            // 
            // tbDonGia
            // 
            this.tbDonGia.Location = new System.Drawing.Point(353, 177);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(100, 20);
            this.tbDonGia.TabIndex = 3;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(295, 229);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(53, 13);
            this.lblSL.TabIndex = 4;
            this.lblSL.Text = "So Luong";
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(353, 229);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(100, 20);
            this.tbSL.TabIndex = 5;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(293, 301);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 6;
            this.btnTinhTien.Text = "Tinh Tien";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Location = new System.Drawing.Point(140, 380);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(118, 13);
            this.lblThanhToan.TabIndex = 7;
            this.lblThanhToan.Text = "Tong Tien Thanh Toan";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(293, 379);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 13);
            this.lblTongTien.TabIndex = 8;
            // 
            // lblKyHieu
            // 
            this.lblKyHieu.AutoSize = true;
            this.lblKyHieu.Location = new System.Drawing.Point(325, 380);
            this.lblKyHieu.Name = "lblKyHieu";
            this.lblKyHieu.Size = new System.Drawing.Size(13, 13);
            this.lblKyHieu.TabIndex = 9;
            this.lblKyHieu.Text = "$";
            this.lblKyHieu.Click += new System.EventHandler(this.lblKyHieu_Click);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKyHieu);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.tbDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.gbMauXe);
            this.Controls.Add(this.pbCar);
            this.Name = "frmBai1";
            this.Text = "Mua Ban Xe";
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.gbMauXe.ResumeLayout(false);
            this.gbMauXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.GroupBox gbMauXe;
        private System.Windows.Forms.RadioButton rdTrang;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblKyHieu;
    }
}