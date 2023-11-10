namespace BTLLTTQ.Menu_Items
{
    partial class FormNhaCungCap
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
			this.dataGridViewNCC = new System.Windows.Forms.DataGridView();
			this.btnHienThi = new System.Windows.Forms.Button();
			this.btnTK = new System.Windows.Forms.Button();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtDC = new System.Windows.Forms.TextBox();
			this.txtTenNCC = new System.Windows.Forms.TextBox();
			this.txtMaNCC = new System.Windows.Forms.TextBox();
			this.DienThoai = new System.Windows.Forms.Label();
			this.DiaChi = new System.Windows.Forms.Label();
			this.TenKH = new System.Windows.Forms.Label();
			this.MaNCC = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnTao = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridViewNCC);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(9, 23);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(474, 379);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách nhà cung cấp";
			// 
			// dataGridViewNCC
			// 
			this.dataGridViewNCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewNCC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewNCC.Location = new System.Drawing.Point(2, 21);
			this.dataGridViewNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridViewNCC.Name = "dataGridViewNCC";
			this.dataGridViewNCC.RowHeadersWidth = 51;
			this.dataGridViewNCC.RowTemplate.Height = 24;
			this.dataGridViewNCC.Size = new System.Drawing.Size(470, 356);
			this.dataGridViewNCC.TabIndex = 0;
			this.dataGridViewNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNCC_CellContentClick);
			// 
			// btnHienThi
			// 
			this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHienThi.Location = new System.Drawing.Point(508, 365);
			this.btnHienThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnHienThi.Name = "btnHienThi";
			this.btnHienThi.Size = new System.Drawing.Size(315, 33);
			this.btnHienThi.TabIndex = 34;
			this.btnHienThi.Text = "Hiển thị thông tin nhà cung cấp";
			this.btnHienThi.UseVisualStyleBackColor = true;
			this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
			// 
			// btnTK
			// 
			this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTK.Location = new System.Drawing.Point(508, 299);
			this.btnTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnTK.Name = "btnTK";
			this.btnTK.Size = new System.Drawing.Size(88, 33);
			this.btnTK.TabIndex = 33;
			this.btnTK.Text = "Tìm kiếm";
			this.btnTK.UseVisualStyleBackColor = true;
			this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
			// 
			// txtSDT
			// 
			this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSDT.Location = new System.Drawing.Point(634, 188);
			this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(190, 26);
			this.txtSDT.TabIndex = 32;
			// 
			// txtDC
			// 
			this.txtDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDC.Location = new System.Drawing.Point(634, 137);
			this.txtDC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtDC.Name = "txtDC";
			this.txtDC.Size = new System.Drawing.Size(190, 26);
			this.txtDC.TabIndex = 31;
			// 
			// txtTenNCC
			// 
			this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNCC.Location = new System.Drawing.Point(634, 93);
			this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTenNCC.Name = "txtTenNCC";
			this.txtTenNCC.Size = new System.Drawing.Size(190, 26);
			this.txtTenNCC.TabIndex = 30;
			// 
			// txtMaNCC
			// 
			this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNCC.Location = new System.Drawing.Point(634, 44);
			this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtMaNCC.Name = "txtMaNCC";
			this.txtMaNCC.Size = new System.Drawing.Size(190, 26);
			this.txtMaNCC.TabIndex = 29;
			// 
			// DienThoai
			// 
			this.DienThoai.AutoSize = true;
			this.DienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DienThoai.Location = new System.Drawing.Point(497, 191);
			this.DienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DienThoai.Name = "DienThoai";
			this.DienThoai.Size = new System.Drawing.Size(81, 20);
			this.DienThoai.TabIndex = 28;
			this.DienThoai.Text = "Điện thoại";
			// 
			// DiaChi
			// 
			this.DiaChi.AutoSize = true;
			this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DiaChi.Location = new System.Drawing.Point(497, 141);
			this.DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.Size = new System.Drawing.Size(57, 20);
			this.DiaChi.TabIndex = 27;
			this.DiaChi.Text = "Địa chỉ";
			// 
			// TenKH
			// 
			this.TenKH.AutoSize = true;
			this.TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TenKH.Location = new System.Drawing.Point(497, 96);
			this.TenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TenKH.Name = "TenKH";
			this.TenKH.Size = new System.Drawing.Size(136, 20);
			this.TenKH.TabIndex = 26;
			this.TenKH.Text = "Tên nhà cung cấp";
			// 
			// MaNCC
			// 
			this.MaNCC.AutoSize = true;
			this.MaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaNCC.Location = new System.Drawing.Point(497, 46);
			this.MaNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MaNCC.Name = "MaNCC";
			this.MaNCC.Size = new System.Drawing.Size(131, 20);
			this.MaNCC.TabIndex = 25;
			this.MaNCC.Text = "Mã nhà cung cấp";
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(735, 238);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(88, 35);
			this.btnXoa.TabIndex = 24;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(623, 238);
			this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(88, 35);
			this.btnSua.TabIndex = 23;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnTao
			// 
			this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTao.Location = new System.Drawing.Point(508, 238);
			this.btnTao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnTao.Name = "btnTao";
			this.btnTao.Size = new System.Drawing.Size(88, 35);
			this.btnTao.TabIndex = 22;
			this.btnTao.Text = "Tạo mới";
			this.btnTao.UseVisualStyleBackColor = true;
			this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
			// 
			// FormNhaCungCap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 421);
			this.Controls.Add(this.btnHienThi);
			this.Controls.Add(this.btnTK);
			this.Controls.Add(this.txtSDT);
			this.Controls.Add(this.txtDC);
			this.Controls.Add(this.txtTenNCC);
			this.Controls.Add(this.txtMaNCC);
			this.Controls.Add(this.DienThoai);
			this.Controls.Add(this.DiaChi);
			this.Controls.Add(this.TenKH);
			this.Controls.Add(this.MaNCC);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnTao);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormNhaCungCap";
			this.Text = "Supplier";
			this.Load += new System.EventHandler(this.FormSupplier_Load);
			this.Click += new System.EventHandler(this.FormNhaCungCap_Click);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewNCC;
		private System.Windows.Forms.Button btnHienThi;
		private System.Windows.Forms.Button btnTK;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtDC;
		private System.Windows.Forms.TextBox txtTenNCC;
		private System.Windows.Forms.TextBox txtMaNCC;
		private System.Windows.Forms.Label DienThoai;
		private System.Windows.Forms.Label DiaChi;
		private System.Windows.Forms.Label TenKH;
		private System.Windows.Forms.Label MaNCC;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnTao;
	}
}