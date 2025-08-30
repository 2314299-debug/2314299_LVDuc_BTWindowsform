namespace BTWindowsFormCau3
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
            this.rdbNGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdbTinhTong = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNGiaiThua);
            this.groupBox1.Controls.Add(this.rdbTinhTong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(148, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 107);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdbNGiaiThua
            // 
            this.rdbNGiaiThua.AutoSize = true;
            this.rdbNGiaiThua.Location = new System.Drawing.Point(22, 63);
            this.rdbNGiaiThua.Name = "rdbNGiaiThua";
            this.rdbNGiaiThua.Size = new System.Drawing.Size(181, 24);
            this.rdbNGiaiThua.TabIndex = 1;
            this.rdbNGiaiThua.TabStop = true;
            this.rdbNGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdbNGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdbTinhTong
            // 
            this.rdbTinhTong.AutoSize = true;
            this.rdbTinhTong.Location = new System.Drawing.Point(22, 33);
            this.rdbTinhTong.Name = "rdbTinhTong";
            this.rdbTinhTong.Size = new System.Drawing.Size(176, 24);
            this.rdbTinhTong.TabIndex = 0;
            this.rdbTinhTong.TabStop = true;
            this.rdbTinhTong.Text = "Tính tổng 1+2+...+N";
            this.rdbTinhTong.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.Location = new System.Drawing.Point(276, 229);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(19, 20);
            this.lblKetQua.TabIndex = 51;
            this.lblKetQua.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(142, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Kết quả là:";
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXemKQ.Location = new System.Drawing.Point(237, 177);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(114, 32);
            this.btnXemKQ.TabIndex = 47;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nhập một số nguyên dương N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(280, 21);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(137, 22);
            this.txtN.TabIndex = 44;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNGiaiThua;
        private System.Windows.Forms.RadioButton rdbTinhTong;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
    }
}