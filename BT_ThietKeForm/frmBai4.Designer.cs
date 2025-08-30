namespace BT_ThietKeForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtTimSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimSo = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 212);
            this.listBox1.TabIndex = 0;
            // 
            // txtTimSo
            // 
            this.txtTimSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimSo.Location = new System.Drawing.Point(375, 49);
            this.txtTimSo.Multiline = true;
            this.txtTimSo.Name = "txtTimSo";
            this.txtTimSo.Size = new System.Drawing.Size(118, 27);
            this.txtTimSo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(255, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập số cần tìm:";
            // 
            // btnTimSo
            // 
            this.btnTimSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimSo.Location = new System.Drawing.Point(322, 92);
            this.btnTimSo.Name = "btnTimSo";
            this.btnTimSo.Size = new System.Drawing.Size(98, 26);
            this.btnTimSo.TabIndex = 18;
            this.btnTimSo.Text = "Tìm số";
            this.btnTimSo.UseVisualStyleBackColor = true;
            this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Red;
            this.lblKetQua.Location = new System.Drawing.Point(359, 151);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 16);
            this.lblKetQua.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(255, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kết quả";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 264);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimSo);
            this.Controls.Add(this.txtTimSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "frmBai4";
            this.Text = "Tìm số trong danh sách";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtTimSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimSo;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label4;
    }
}