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
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // cmbokh
            // 
            this.cmbokh.FormattingEnabled = true;
            this.cmbokh.Location = new System.Drawing.Point(230, 58);
            this.cmbokh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbokh.Name = "cmbokh";
            this.cmbokh.Size = new System.Drawing.Size(385, 28);
            this.cmbokh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng";
            // 
            // bangdondathang
            // 
            this.bangdondathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bangdondathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangdondathang.Location = new System.Drawing.Point(82, 245);
            this.bangdondathang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bangdondathang.Name = "bangdondathang";
            this.bangdondathang.RowHeadersWidth = 51;
            this.bangdondathang.RowTemplate.Height = 24;
            this.bangdondathang.Size = new System.Drawing.Size(1023, 439);
            this.bangdondathang.TabIndex = 3;
            this.bangdondathang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangdondathang_CellContentClick);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(926, 59);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(180, 36);
            this.btntim.TabIndex = 4;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // cmbothang
            // 
            this.cmbothang.FormattingEnabled = true;
            this.cmbothang.Location = new System.Drawing.Point(230, 144);
            this.cmbothang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbothang.Name = "cmbothang";
            this.cmbothang.Size = new System.Drawing.Size(385, 28);
            this.cmbothang.TabIndex = 5;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(926, 148);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(180, 36);
            this.btnxuat.TabIndex = 6;
            this.btnxuat.Text = "Xuất excel";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // Formbcdsspchokhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.cmbothang);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.bangdondathang);
            this.Controls.Add(this.cmbokh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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