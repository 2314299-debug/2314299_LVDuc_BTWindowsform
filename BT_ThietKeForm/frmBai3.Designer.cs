namespace BT_ThietKeForm
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
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtHienThiNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(119, 46);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(217, 20);
            this.txtNghia.TabIndex = 16;
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(119, 18);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(163, 20);
            this.txtTuMoi.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nghĩa của từ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Từ mới:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(149, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thêm từ mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(374, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "NGHĨA CỦA TỪ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(82, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "DANH SÁCH TỪ MỚI";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(28, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 148);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtHienThiNghia
            // 
            this.txtHienThiNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHienThiNghia.Location = new System.Drawing.Point(299, 159);
            this.txtHienThiNghia.Multiline = true;
            this.txtHienThiNghia.Name = "txtHienThiNghia";
            this.txtHienThiNghia.ReadOnly = true;
            this.txtHienThiNghia.Size = new System.Drawing.Size(263, 148);
            this.txtHienThiNghia.TabIndex = 21;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 319);
            this.Controls.Add(this.txtHienThiNghia);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh-Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNghia;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtHienThiNghia;
    }
}