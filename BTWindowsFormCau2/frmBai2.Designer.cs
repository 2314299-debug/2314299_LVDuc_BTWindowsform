namespace BTWindowsFormCau2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbChia = new System.Windows.Forms.RadioButton();
            this.rdbNhan = new System.Windows.Forms.RadioButton();
            this.rdbTru = new System.Windows.Forms.RadioButton();
            this.rdbCong = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbChia);
            this.groupBox1.Controls.Add(this.rdbNhan);
            this.groupBox1.Controls.Add(this.rdbTru);
            this.groupBox1.Controls.Add(this.rdbCong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(55, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 166);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdbChia
            // 
            this.rdbChia.AutoSize = true;
            this.rdbChia.Location = new System.Drawing.Point(22, 123);
            this.rdbChia.Name = "rdbChia";
            this.rdbChia.Size = new System.Drawing.Size(64, 24);
            this.rdbChia.TabIndex = 3;
            this.rdbChia.TabStop = true;
            this.rdbChia.Text = "Chia";
            this.rdbChia.UseVisualStyleBackColor = true;
            // 
            // rdbNhan
            // 
            this.rdbNhan.AutoSize = true;
            this.rdbNhan.Location = new System.Drawing.Point(22, 93);
            this.rdbNhan.Name = "rdbNhan";
            this.rdbNhan.Size = new System.Drawing.Size(69, 24);
            this.rdbNhan.TabIndex = 2;
            this.rdbNhan.TabStop = true;
            this.rdbNhan.Text = "Nhân";
            this.rdbNhan.UseVisualStyleBackColor = true;
            // 
            // rdbTru
            // 
            this.rdbTru.AutoSize = true;
            this.rdbTru.Location = new System.Drawing.Point(22, 63);
            this.rdbTru.Name = "rdbTru";
            this.rdbTru.Size = new System.Drawing.Size(55, 24);
            this.rdbTru.TabIndex = 1;
            this.rdbTru.TabStop = true;
            this.rdbTru.Text = "Trừ";
            this.rdbTru.UseVisualStyleBackColor = true;
            // 
            // rdbCong
            // 
            this.rdbCong.AutoSize = true;
            this.rdbCong.Location = new System.Drawing.Point(22, 33);
            this.rdbCong.Name = "rdbCong";
            this.rdbCong.Size = new System.Drawing.Size(69, 24);
            this.rdbCong.TabIndex = 0;
            this.rdbCong.TabStop = true;
            this.rdbCong.Text = "Cộng";
            this.rdbCong.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.Location = new System.Drawing.Point(170, 344);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(19, 20);
            this.lblKetQua.TabIndex = 43;
            this.lblKetQua.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kết quả là:";
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXemKQ.Location = new System.Drawing.Point(131, 292);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(114, 32);
            this.btnXemKQ.TabIndex = 39;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(48, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Số thứ hai:";
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(153, 67);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(137, 22);
            this.txtSoThuHai.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Số thứ nhất:";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(153, 26);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(137, 22);
            this.txtSoThuNhat.TabIndex = 36;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoThuNhat);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChia;
        private System.Windows.Forms.RadioButton rdbNhan;
        private System.Windows.Forms.RadioButton rdbTru;
        private System.Windows.Forms.RadioButton rdbCong;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoThuNhat;
    }
}