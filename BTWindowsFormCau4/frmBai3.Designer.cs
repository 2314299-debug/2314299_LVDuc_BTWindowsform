namespace BTWindowsFormCau4
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbUSCLN = new System.Windows.Forms.RadioButton();
            this.rdbChaoHoi = new System.Windows.Forms.RadioButton();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(122, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Số m:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUSCLN);
            this.groupBox1.Controls.Add(this.rdbChaoHoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(108, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 115);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu 3";
            // 
            // rdbUSCLN
            // 
            this.rdbUSCLN.AutoSize = true;
            this.rdbUSCLN.Location = new System.Drawing.Point(22, 63);
            this.rdbUSCLN.Name = "rdbUSCLN";
            this.rdbUSCLN.Size = new System.Drawing.Size(87, 24);
            this.rdbUSCLN.TabIndex = 1;
            this.rdbUSCLN.TabStop = true;
            this.rdbUSCLN.Text = "USCLN";
            this.rdbUSCLN.UseVisualStyleBackColor = true;
            // 
            // rdbChaoHoi
            // 
            this.rdbChaoHoi.AutoSize = true;
            this.rdbChaoHoi.Location = new System.Drawing.Point(22, 33);
            this.rdbChaoHoi.Name = "rdbChaoHoi";
            this.rdbChaoHoi.Size = new System.Drawing.Size(96, 24);
            this.rdbChaoHoi.TabIndex = 0;
            this.rdbChaoHoi.TabStop = true;
            this.rdbChaoHoi.Text = "Chào hỏi";
            this.rdbChaoHoi.UseVisualStyleBackColor = true;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(198, 97);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(137, 22);
            this.txtM.TabIndex = 3;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.Location = new System.Drawing.Point(147, 356);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 20);
            this.lblKetQua.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Kết quả";
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTinhTong.Location = new System.Drawing.Point(197, 300);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(114, 32);
            this.btnTinhTong.TabIndex = 6;
            this.btnTinhTong.Text = "Xem kết quả";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(95, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(198, 23);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(222, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(197, 61);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(65, 24);
            this.rdbNam.TabIndex = 1;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(280, 61);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(51, 24);
            this.rdbNu.TabIndex = 2;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(104, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(127, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Số n:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(197, 138);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(137, 22);
            this.txtN.TabIndex = 4;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.lblKetQua);
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

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUSCLN;
        private System.Windows.Forms.RadioButton rdbChaoHoi;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN;
    }
}