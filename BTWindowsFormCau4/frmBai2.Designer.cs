namespace BTWindowsFormCau4
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtDThucHanh = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDLyThuyet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Nhập điểm thực hành:";
            // 
            // txtDThucHanh
            // 
            this.txtDThucHanh.Location = new System.Drawing.Point(225, 66);
            this.txtDThucHanh.Name = "txtDThucHanh";
            this.txtDThucHanh.Size = new System.Drawing.Size(137, 22);
            this.txtDThucHanh.TabIndex = 1;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.ForeColor = System.Drawing.Color.Red;
            this.lblKetQua.Location = new System.Drawing.Point(195, 173);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 20);
            this.lblKetQua.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Kết quả xếp loại:";
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXepLoai.Location = new System.Drawing.Point(149, 111);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(114, 32);
            this.btnXepLoai.TabIndex = 2;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nhập điểm lý thuyết:";
            // 
            // txtDLyThuyet
            // 
            this.txtDLyThuyet.Location = new System.Drawing.Point(225, 29);
            this.txtDLyThuyet.Name = "txtDLyThuyet";
            this.txtDLyThuyet.Size = new System.Drawing.Size(137, 22);
            this.txtDLyThuyet.TabIndex = 0;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDThucHanh);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDLyThuyet);
            this.Name = "frmBai2";
            this.Text = "Xếp loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDThucHanh;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDLyThuyet;
    }
}