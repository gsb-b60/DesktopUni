namespace ThietKeForm
{
    partial class frmBai4
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
            this.lbSoNgauNhien = new System.Windows.Forms.ListBox();
            this.lblSoCanTim = new System.Windows.Forms.Label();
            this.tbSoCanTim = new System.Windows.Forms.TextBox();
            this.btnTimSo = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSoNgauNhien
            // 
            this.lbSoNgauNhien.FormattingEnabled = true;
            this.lbSoNgauNhien.Location = new System.Drawing.Point(13, 13);
            this.lbSoNgauNhien.Name = "lbSoNgauNhien";
            this.lbSoNgauNhien.Size = new System.Drawing.Size(120, 368);
            this.lbSoNgauNhien.TabIndex = 0;
            this.lbSoNgauNhien.SelectedIndexChanged += new System.EventHandler(this.lbSoNgauNhien_SelectedIndexChanged);
            // 
            // lblSoCanTim
            // 
            this.lblSoCanTim.AutoSize = true;
            this.lblSoCanTim.Location = new System.Drawing.Point(161, 13);
            this.lblSoCanTim.Name = "lblSoCanTim";
            this.lblSoCanTim.Size = new System.Drawing.Size(91, 13);
            this.lblSoCanTim.TabIndex = 1;
            this.lblSoCanTim.Text = "Nhap So Can Tim";
            // 
            // tbSoCanTim
            // 
            this.tbSoCanTim.Location = new System.Drawing.Point(280, 13);
            this.tbSoCanTim.Name = "tbSoCanTim";
            this.tbSoCanTim.Size = new System.Drawing.Size(100, 20);
            this.tbSoCanTim.TabIndex = 2;
            // 
            // btnTimSo
            // 
            this.btnTimSo.Location = new System.Drawing.Point(280, 52);
            this.btnTimSo.Name = "btnTimSo";
            this.btnTimSo.Size = new System.Drawing.Size(75, 23);
            this.btnTimSo.TabIndex = 3;
            this.btnTimSo.Text = "Tim So";
            this.btnTimSo.UseVisualStyleBackColor = true;
            this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(161, 114);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(52, 13);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Ket Qua: ";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(249, 114);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(43, 13);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "TimThu";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnTimSo);
            this.Controls.Add(this.tbSoCanTim);
            this.Controls.Add(this.lblSoCanTim);
            this.Controls.Add(this.lbSoNgauNhien);
            this.Name = "frmBai4";
            this.Text = "Tim So Trong Danh Sach";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSoNgauNhien;
        private System.Windows.Forms.Label lblSoCanTim;
        private System.Windows.Forms.TextBox tbSoCanTim;
        private System.Windows.Forms.Button btnTimSo;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblKQ;
    }
}