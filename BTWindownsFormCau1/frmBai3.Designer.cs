namespace BTWindownsFormCau1
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
            this.rdbTongDaySo = new System.Windows.Forms.RadioButton();
            this.rdbTong2So = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTongDaySo);
            this.groupBox1.Controls.Add(this.rdbTong2So);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(49, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 115);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính tổng";
            // 
            // rdbTongDaySo
            // 
            this.rdbTongDaySo.AutoSize = true;
            this.rdbTongDaySo.Location = new System.Drawing.Point(22, 63);
            this.rdbTongDaySo.Name = "rdbTongDaySo";
            this.rdbTongDaySo.Size = new System.Drawing.Size(207, 24);
            this.rdbTongDaySo.TabIndex = 1;
            this.rdbTongDaySo.TabStop = true;
            this.rdbTongDaySo.Text = "Tổng dãy số(từ 1 đến n)";
            this.rdbTongDaySo.UseVisualStyleBackColor = true;
            // 
            // rdbTong2So
            // 
            this.rdbTong2So.AutoSize = true;
            this.rdbTong2So.Location = new System.Drawing.Point(22, 33);
            this.rdbTong2So.Name = "rdbTong2So";
            this.rdbTong2So.Size = new System.Drawing.Size(117, 24);
            this.rdbTong2So.TabIndex = 0;
            this.rdbTong2So.TabStop = true;
            this.rdbTong2So.Text = "Tổng hai số";
            this.rdbTong2So.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(37, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Số n:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(130, 108);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(137, 22);
            this.txtN.TabIndex = 29;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.Location = new System.Drawing.Point(169, 331);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(19, 20);
            this.lblKetQua.TabIndex = 35;
            this.lblKetQua.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kết quả";
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTinhTong.Location = new System.Drawing.Point(130, 277);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(114, 32);
            this.btnTinhTong.TabIndex = 31;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(37, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Số b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(130, 66);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(137, 22);
            this.txtB.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(130, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(137, 22);
            this.txtA.TabIndex = 27;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTongDaySo;
        private System.Windows.Forms.RadioButton rdbTong2So;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
    }
}