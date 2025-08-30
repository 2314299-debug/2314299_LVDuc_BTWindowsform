namespace BTWindownsFormCau1
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
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.rdbChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(234, 306);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(19, 20);
            this.lblTongTien.TabIndex = 24;
            this.lblTongTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tổng tiền thanh toán:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTinhTien.Location = new System.Drawing.Point(102, 256);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(114, 32);
            this.btnTinhTien.TabIndex = 21;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTienMat);
            this.groupBox1.Controls.Add(this.rdbChuyenKhoan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(65, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 116);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức thanh toán";
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbTienMat.Location = new System.Drawing.Point(16, 65);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(95, 24);
            this.rdbTienMat.TabIndex = 1;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // rdbChuyenKhoan
            // 
            this.rdbChuyenKhoan.AutoSize = true;
            this.rdbChuyenKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbChuyenKhoan.Location = new System.Drawing.Point(16, 35);
            this.rdbChuyenKhoan.Name = "rdbChuyenKhoan";
            this.rdbChuyenKhoan.Size = new System.Drawing.Size(135, 24);
            this.rdbChuyenKhoan.TabIndex = 0;
            this.rdbChuyenKhoan.TabStop = true;
            this.rdbChuyenKhoan.Text = "Chuyển khoản";
            this.rdbChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(45, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(146, 96);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(107, 22);
            this.txtSoLuong.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Đơn giá:";
            // 
            // cbTenHang
            // 
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cbTenHang.Location = new System.Drawing.Point(146, 38);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(185, 24);
            this.cbTenHang.TabIndex = 15;
            this.cbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbTenHang_SelectedIndexChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(146, 68);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(137, 22);
            this.txtDonGia.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên hàng:";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 373);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTenHang);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.RadioButton rdbChuyenKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
    }
}