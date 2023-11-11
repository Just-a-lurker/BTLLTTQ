namespace BTLLTTQ.Menu_Items
{
    partial class Formbcdsspchokhachhang
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbokh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bangdondathang = new System.Windows.Forms.DataGridView();
            this.btntim = new System.Windows.Forms.Button();
            this.cmbothang = new System.Windows.Forms.ComboBox();
            this.btnxuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bangdondathang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // cmbokh
            // 
            this.cmbokh.FormattingEnabled = true;
            this.cmbokh.Location = new System.Drawing.Point(153, 37);
            this.cmbokh.Name = "cmbokh";
            this.cmbokh.Size = new System.Drawing.Size(258, 24);
            this.cmbokh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng";
            // 
            // bangdondathang
            // 
            this.bangdondathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangdondathang.Location = new System.Drawing.Point(55, 157);
            this.bangdondathang.Name = "bangdondathang";
            this.bangdondathang.RowHeadersWidth = 51;
            this.bangdondathang.RowTemplate.Height = 24;
            this.bangdondathang.Size = new System.Drawing.Size(682, 281);
            this.bangdondathang.TabIndex = 3;
            this.bangdondathang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangdondathang_CellContentClick);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(621, 38);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(116, 23);
            this.btntim.TabIndex = 4;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // cmbothang
            // 
            this.cmbothang.FormattingEnabled = true;
            this.cmbothang.Location = new System.Drawing.Point(153, 92);
            this.cmbothang.Name = "cmbothang";
            this.cmbothang.Size = new System.Drawing.Size(258, 24);
            this.cmbothang.TabIndex = 5;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(621, 93);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(116, 23);
            this.btnxuat.TabIndex = 6;
            this.btnxuat.Text = "Xuất Excel";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // Formbcdsspchokhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.cmbothang);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.bangdondathang);
            this.Controls.Add(this.cmbokh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formbcdsspchokhachhang";
            this.Text = "Formbcdsspchokhachhang";
            this.Load += new System.EventHandler(this.Formbcdsspchokhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangdondathang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbokh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView bangdondathang;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.ComboBox cmbothang;
        private System.Windows.Forms.Button btnxuat;
    }
}