namespace BTLLTTQ.Menu_Items
{
    partial class FormKhachHang
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
			this.dataGridViewKH = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnTao = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtDC = new System.Windows.Forms.TextBox();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.DienThoai = new System.Windows.Forms.Label();
			this.DiaChi = new System.Windows.Forms.Label();
			this.TenKH = new System.Windows.Forms.Label();
			this.MaKH = new System.Windows.Forms.Label();
			this.btnTK = new System.Windows.Forms.Button();
			this.btnHienThi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewKH
			// 
			this.dataGridViewKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewKH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewKH.Location = new System.Drawing.Point(2, 21);
			this.dataGridViewKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridViewKH.Name = "dataGridViewKH";
			this.dataGridViewKH.RowHeadersWidth = 51;
			this.dataGridViewKH.RowTemplate.Height = 24;
			this.dataGridViewKH.Size = new System.Drawing.Size(701, 356);
			this.dataGridViewKH.TabIndex = 0;
			this.dataGridViewKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridViewKH);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(11, 20);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(705, 379);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách khách hàng";
			// 
			// btnTao
			// 
			this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTao.Location = new System.Drawing.Point(723, 236);
			this.btnTao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnTao.Name = "btnTao";
			this.btnTao.Size = new System.Drawing.Size(88, 35);
			this.btnTao.TabIndex = 1;
			this.btnTao.Text = "Tạo mới";
			this.btnTao.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(839, 236);
			this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(88, 35);
			this.btnSua.TabIndex = 2;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(950, 236);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(88, 35);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// txtSDT
			// 
			this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSDT.Location = new System.Drawing.Point(849, 186);
			this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(190, 26);
			this.txtSDT.TabIndex = 18;
			// 
			// txtDC
			// 
			this.txtDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDC.Location = new System.Drawing.Point(849, 135);
			this.txtDC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtDC.Name = "txtDC";
			this.txtDC.Size = new System.Drawing.Size(190, 26);
			this.txtDC.TabIndex = 17;
			// 
			// txtTenKH
			// 
			this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenKH.Location = new System.Drawing.Point(849, 91);
			this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(190, 26);
			this.txtTenKH.TabIndex = 16;
			// 
			// txtMaKH
			// 
			this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaKH.Location = new System.Drawing.Point(849, 41);
			this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(190, 26);
			this.txtMaKH.TabIndex = 15;
			// 
			// DienThoai
			// 
			this.DienThoai.AutoSize = true;
			this.DienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DienThoai.Location = new System.Drawing.Point(720, 188);
			this.DienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DienThoai.Name = "DienThoai";
			this.DienThoai.Size = new System.Drawing.Size(81, 20);
			this.DienThoai.TabIndex = 14;
			this.DienThoai.Text = "Điện thoại";
			// 
			// DiaChi
			// 
			this.DiaChi.AutoSize = true;
			this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DiaChi.Location = new System.Drawing.Point(720, 139);
			this.DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.Size = new System.Drawing.Size(57, 20);
			this.DiaChi.TabIndex = 13;
			this.DiaChi.Text = "Địa chỉ";
			// 
			// TenKH
			// 
			this.TenKH.AutoSize = true;
			this.TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TenKH.Location = new System.Drawing.Point(720, 93);
			this.TenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TenKH.Name = "TenKH";
			this.TenKH.Size = new System.Drawing.Size(123, 20);
			this.TenKH.TabIndex = 12;
			this.TenKH.Text = "Tên khách hàng";
			// 
			// MaKH
			// 
			this.MaKH.AutoSize = true;
			this.MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaKH.Location = new System.Drawing.Point(720, 41);
			this.MaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MaKH.Name = "MaKH";
			this.MaKH.Size = new System.Drawing.Size(118, 20);
			this.MaKH.TabIndex = 11;
			this.MaKH.Text = "Mã khách hàng";
			// 
			// btnTK
			// 
			this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTK.Location = new System.Drawing.Point(723, 297);
			this.btnTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnTK.Name = "btnTK";
			this.btnTK.Size = new System.Drawing.Size(88, 33);
			this.btnTK.TabIndex = 20;
			this.btnTK.Text = "Tìm kiếm";
			this.btnTK.UseVisualStyleBackColor = true;
			this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
			// 
			// btnHienThi
			// 
			this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHienThi.Location = new System.Drawing.Point(723, 362);
			this.btnHienThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnHienThi.Name = "btnHienThi";
			this.btnHienThi.Size = new System.Drawing.Size(315, 33);
			this.btnHienThi.TabIndex = 21;
			this.btnHienThi.Text = "Hiển thị thông tin khách khàng";
			this.btnHienThi.UseVisualStyleBackColor = true;
			this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
			// 
			// FormKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1050, 421);
			this.Controls.Add(this.btnHienThi);
			this.Controls.Add(this.btnTK);
			this.Controls.Add(this.txtSDT);
			this.Controls.Add(this.txtDC);
			this.Controls.Add(this.txtTenKH);
			this.Controls.Add(this.txtMaKH);
			this.Controls.Add(this.DienThoai);
			this.Controls.Add(this.DiaChi);
			this.Controls.Add(this.TenKH);
			this.Controls.Add(this.MaKH);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnTao);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormKhachHang";
			this.Text = "Customer";
			this.Load += new System.EventHandler(this.FormCustomer_Load);
			this.Click += new System.EventHandler(this.FormCustomer_Click);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtDC;
		private System.Windows.Forms.TextBox txtTenKH;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.Label DienThoai;
		private System.Windows.Forms.Label DiaChi;
		private System.Windows.Forms.Label TenKH;
		private System.Windows.Forms.Label MaKH;
		private System.Windows.Forms.Button btnTK;
		private System.Windows.Forms.Button btnHienThi;
	}
}