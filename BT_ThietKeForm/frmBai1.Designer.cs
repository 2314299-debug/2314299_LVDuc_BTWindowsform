namespace BT_ThietKeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbChonMau = new System.Windows.Forms.GroupBox();
            this.rdbTrang = new System.Windows.Forms.RadioButton();
            this.rdbDo = new System.Windows.Forms.RadioButton();
            this.rdbXanh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbChonMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 191);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbChonMau
            // 
            this.grbChonMau.Controls.Add(this.rdbTrang);
            this.grbChonMau.Controls.Add(this.rdbDo);
            this.grbChonMau.Controls.Add(this.rdbXanh);
            this.grbChonMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbChonMau.Location = new System.Drawing.Point(294, 15);
            this.grbChonMau.Name = "grbChonMau";
            this.grbChonMau.Size = new System.Drawing.Size(230, 171);
            this.grbChonMau.TabIndex = 1;
            this.grbChonMau.TabStop = false;
            this.grbChonMau.Text = "Chọn màu xe";
            // 
            // rdbTrang
            // 
            this.rdbTrang.AutoSize = true;
            this.rdbTrang.Location = new System.Drawing.Point(6, 117);
            this.rdbTrang.Name = "rdbTrang";
            this.rdbTrang.Size = new System.Drawing.Size(68, 24);
            this.rdbTrang.TabIndex = 2;
            this.rdbTrang.TabStop = true;
            this.rdbTrang.Text = "Trắng";
            this.rdbTrang.UseVisualStyleBackColor = true;
            this.rdbTrang.CheckedChanged += new System.EventHandler(this.rdbTrang_CheckedChanged);
            // 
            // rdbDo
            // 
            this.rdbDo.AutoSize = true;
            this.rdbDo.Location = new System.Drawing.Point(6, 76);
            this.rdbDo.Name = "rdbDo";
            this.rdbDo.Size = new System.Drawing.Size(48, 24);
            this.rdbDo.TabIndex = 1;
            this.rdbDo.TabStop = true;
            this.rdbDo.Text = "Đỏ";
            this.rdbDo.UseVisualStyleBackColor = true;
            this.rdbDo.CheckedChanged += new System.EventHandler(this.rdbDo_CheckedChanged);
            // 
            // rdbXanh
            // 
            this.rdbXanh.AutoSize = true;
            this.rdbXanh.Location = new System.Drawing.Point(6, 34);
            this.rdbXanh.Name = "rdbXanh";
            this.rdbXanh.Size = new System.Drawing.Size(65, 24);
            this.rdbXanh.TabIndex = 0;
            this.rdbXanh.TabStop = true;
            this.rdbXanh.Text = "Xanh";
            this.rdbXanh.UseVisualStyleBackColor = true;
            this.rdbXanh.CheckedChanged += new System.EventHandler(this.rdbXanh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(297, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(530, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(297, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(370, 283);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(254, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền thanh toán:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTongTien.Location = new System.Drawing.Point(404, 325);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(16, 17);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(530, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "$";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(379, 213);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(136, 20);
            this.txtDonGia.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(379, 241);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(82, 20);
            this.txtSoLuong.TabIndex = 12;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 375);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbChonMau);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBai1";
            this.Text = "Mua bán xe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbChonMau.ResumeLayout(false);
            this.grbChonMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbChonMau;
        private System.Windows.Forms.RadioButton rdbXanh;
        private System.Windows.Forms.RadioButton rdbTrang;
        private System.Windows.Forms.RadioButton rdbDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}