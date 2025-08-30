namespace BTWindownsFormCau1
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
            this.lblHienThi = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHienThi.Location = new System.Drawing.Point(79, 56);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(0, 20);
            this.lblHienThi.TabIndex = 5;
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(115, 57);
            this.lblTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(0, 16);
            this.lblTT.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin hàng hóa";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 226);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.label1);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label label1;
    }
}