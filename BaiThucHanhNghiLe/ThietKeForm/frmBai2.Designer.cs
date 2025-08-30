namespace ThietKeForm
{
    partial class frmBai2
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
            this.pnlHangHoa = new System.Windows.Forms.Panel();
            this.pnlMua = new System.Windows.Forms.Panel();
            this.lbHangHoa = new System.Windows.Forms.ListBox();
            this.lblHangHoa = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.lbBo = new System.Windows.Forms.ListBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblDong = new System.Windows.Forms.Label();
            this.lblKhachMua = new System.Windows.Forms.Label();
            this.pnlHangHoa.SuspendLayout();
            this.pnlMua.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHangHoa
            // 
            this.pnlHangHoa.Controls.Add(this.btnChon);
            this.pnlHangHoa.Controls.Add(this.lblHangHoa);
            this.pnlHangHoa.Controls.Add(this.lbHangHoa);
            this.pnlHangHoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHangHoa.Location = new System.Drawing.Point(0, 0);
            this.pnlHangHoa.Name = "pnlHangHoa";
            this.pnlHangHoa.Size = new System.Drawing.Size(231, 450);
            this.pnlHangHoa.TabIndex = 0;
            // 
            // pnlMua
            // 
            this.pnlMua.Controls.Add(this.lblKhachMua);
            this.pnlMua.Controls.Add(this.lblDong);
            this.pnlMua.Controls.Add(this.lblTongTien);
            this.pnlMua.Controls.Add(this.lblThanhToan);
            this.pnlMua.Controls.Add(this.btnTinhTien);
            this.pnlMua.Controls.Add(this.lbBo);
            this.pnlMua.Controls.Add(this.btnBo);
            this.pnlMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMua.Location = new System.Drawing.Point(231, 0);
            this.pnlMua.Name = "pnlMua";
            this.pnlMua.Size = new System.Drawing.Size(217, 450);
            this.pnlMua.TabIndex = 1;
            // 
            // lbHangHoa
            // 
            this.lbHangHoa.FormattingEnabled = true;
            this.lbHangHoa.Items.AddRange(new object[] {
            "Chuot",
            "Ban phim",
            "May in",
            "USB KingMax"});
            this.lbHangHoa.Location = new System.Drawing.Point(12, 98);
            this.lbHangHoa.Name = "lbHangHoa";
            this.lbHangHoa.Size = new System.Drawing.Size(132, 186);
            this.lbHangHoa.TabIndex = 0;
            this.lbHangHoa.SelectedIndexChanged += new System.EventHandler(this.lbHangHoa_SelectedIndexChanged);
            // 
            // lblHangHoa
            // 
            this.lblHangHoa.AutoSize = true;
            this.lblHangHoa.Location = new System.Drawing.Point(16, 56);
            this.lblHangHoa.Name = "lblHangHoa";
            this.lblHangHoa.Size = new System.Drawing.Size(116, 13);
            this.lblHangHoa.TabIndex = 1;
            this.lblHangHoa.Text = "Danh Sach Hang Hoa:";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(150, 98);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chon >";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnBo
            // 
            this.btnBo.Location = new System.Drawing.Point(6, 98);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(75, 23);
            this.btnBo.TabIndex = 0;
            this.btnBo.Text = "< Bo Hang";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // lbBo
            // 
            this.lbBo.FormattingEnabled = true;
            this.lbBo.Location = new System.Drawing.Point(87, 98);
            this.lbBo.Name = "lbBo";
            this.lbBo.Size = new System.Drawing.Size(118, 186);
            this.lbBo.TabIndex = 1;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(67, 325);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 2;
            this.btnTinhTien.Text = "Tinh Tien";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Location = new System.Drawing.Point(3, 367);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(118, 13);
            this.lblThanhToan.TabIndex = 3;
            this.lblThanhToan.Text = "Tong Tien Thanh Toan";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(6, 399);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(13, 13);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "0";
            // 
            // lblDong
            // 
            this.lblDong.AutoSize = true;
            this.lblDong.Location = new System.Drawing.Point(87, 399);
            this.lblDong.Name = "lblDong";
            this.lblDong.Size = new System.Drawing.Size(33, 13);
            this.lblDong.TabIndex = 5;
            this.lblDong.Text = "Dong";
            // 
            // lblKhachMua
            // 
            this.lblKhachMua.AutoSize = true;
            this.lblKhachMua.Location = new System.Drawing.Point(41, 56);
            this.lblKhachMua.Name = "lblKhachMua";
            this.lblKhachMua.Size = new System.Drawing.Size(134, 13);
            this.lblKhachMua.TabIndex = 6;
            this.lblKhachMua.Text = "Cac Mat Hang Khach Mua";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.pnlMua);
            this.Controls.Add(this.pnlHangHoa);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.pnlHangHoa.ResumeLayout(false);
            this.pnlHangHoa.PerformLayout();
            this.pnlMua.ResumeLayout(false);
            this.pnlMua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHangHoa;
        private System.Windows.Forms.Panel pnlMua;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label lblHangHoa;
        private System.Windows.Forms.ListBox lbHangHoa;
        private System.Windows.Forms.Label lblKhachMua;
        private System.Windows.Forms.Label lblDong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.ListBox lbBo;
        private System.Windows.Forms.Button btnBo;
    }
}