namespace BTWindowsFormCau3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbKTThuTu = new System.Windows.Forms.RadioButton();
            this.rdbTachChuoi = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblKetQua1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblKetQua2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbKTThuTu);
            this.groupBox1.Controls.Add(this.rdbTachChuoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(29, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu 3";
            // 
            // rdbKTThuTu
            // 
            this.rdbKTThuTu.AutoSize = true;
            this.rdbKTThuTu.Location = new System.Drawing.Point(22, 63);
            this.rdbKTThuTu.Name = "rdbKTThuTu";
            this.rdbKTThuTu.Size = new System.Drawing.Size(140, 24);
            this.rdbKTThuTu.TabIndex = 1;
            this.rdbKTThuTu.TabStop = true;
            this.rdbKTThuTu.Text = "Kiểm tra thứ tự";
            this.rdbKTThuTu.UseVisualStyleBackColor = true;
            // 
            // rdbTachChuoi
            // 
            this.rdbTachChuoi.AutoSize = true;
            this.rdbTachChuoi.Location = new System.Drawing.Point(22, 33);
            this.rdbTachChuoi.Name = "rdbTachChuoi";
            this.rdbTachChuoi.Size = new System.Drawing.Size(112, 24);
            this.rdbTachChuoi.TabIndex = 0;
            this.rdbTachChuoi.TabStop = true;
            this.rdbTachChuoi.Text = "Tách chuỗi";
            this.rdbTachChuoi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(63, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Số n1:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(128, 47);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(137, 22);
            this.txtN1.TabIndex = 1;
            // 
            // lblKetQua1
            // 
            this.lblKetQua1.AutoSize = true;
            this.lblKetQua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQua1.Location = new System.Drawing.Point(120, 288);
            this.lblKetQua1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua1.Name = "lblKetQua1";
            this.lblKetQua1.Size = new System.Drawing.Size(0, 20);
            this.lblKetQua1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Kết quả";
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTinhTong.Location = new System.Drawing.Point(118, 234);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(114, 32);
            this.btnTinhTong.TabIndex = 4;
            this.btnTinhTong.Text = "Xem kết quả";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(128, 10);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(222, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // lblKetQua2
            // 
            this.lblKetQua2.AutoSize = true;
            this.lblKetQua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQua2.Location = new System.Drawing.Point(120, 321);
            this.lblKetQua2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua2.Name = "lblKetQua2";
            this.lblKetQua2.Size = new System.Drawing.Size(0, 20);
            this.lblKetQua2.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(63, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Số n2:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(128, 84);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(137, 22);
            this.txtN2.TabIndex = 2;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKetQua2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblKetQua1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbKTThuTu;
        private System.Windows.Forms.RadioButton rdbTachChuoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblKetQua1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblKetQua2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN2;
    }
}