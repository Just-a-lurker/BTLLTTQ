namespace BTLLTTQ.Menu
{
    partial class FormPartner
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
			this.btn_KH = new System.Windows.Forms.Button();
			this.btn_NCC = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_KH
			// 
			this.btn_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_KH.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_KH.Location = new System.Drawing.Point(6, 21);
			this.btn_KH.Name = "btn_KH";
			this.btn_KH.Size = new System.Drawing.Size(212, 39);
			this.btn_KH.TabIndex = 4;
			this.btn_KH.Text = "Thêm thông tin";
			this.btn_KH.UseVisualStyleBackColor = true;
			this.btn_KH.Click += new System.EventHandler(this.btn_KH_Click);
			// 
			// btn_NCC
			// 
			this.btn_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_NCC.Location = new System.Drawing.Point(6, 21);
			this.btn_NCC.Name = "btn_NCC";
			this.btn_NCC.Size = new System.Drawing.Size(210, 39);
			this.btn_NCC.TabIndex = 5;
			this.btn_NCC.Text = "Thêm thông tin";
			this.btn_NCC.UseVisualStyleBackColor = true;
			this.btn_NCC.Click += new System.EventHandler(this.btn_NCC_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_KH);
			this.groupBox1.Location = new System.Drawing.Point(27, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(781, 180);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Khách hàng";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_NCC);
			this.groupBox2.Location = new System.Drawing.Point(29, 231);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(778, 199);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nhà cung cấp";
			// 
			// FormPartner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 457);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormPartner";
			this.Text = "Partner";
			this.Load += new System.EventHandler(this.FormCustomer_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_KH;
        private System.Windows.Forms.Button btn_NCC;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}