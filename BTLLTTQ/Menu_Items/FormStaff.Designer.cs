﻿namespace BTLLTTQ.Menu_Items
{
    partial class FormStaff
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
            this.manv = new System.Windows.Forms.Label();
            this.nv = new System.Windows.Forms.Label();
            this.txtnv = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.macl = new System.Windows.Forms.Label();
            this.macv = new System.Windows.Forms.Label();
            this.gioitinh = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.Label();
            this.dienthoai = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.Label();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.cmbogioitinh = new System.Windows.Forms.ComboBox();
            this.cmbomacv = new System.Windows.Forms.ComboBox();
            this.cmbomacl = new System.Windows.Forms.ComboBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.btnCLCV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(112, 69);
            this.manv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(130, 25);
            this.manv.TabIndex = 0;
            this.manv.Text = "Mã nhân viên";
            // 
            // nv
            // 
            this.nv.AutoSize = true;
            this.nv.Location = new System.Drawing.Point(110, 122);
            this.nv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nv.Name = "nv";
            this.nv.Size = new System.Drawing.Size(100, 25);
            this.nv.TabIndex = 0;
            this.nv.Text = "Nhân viên";
            // 
            // txtnv
            // 
            this.txtnv.Location = new System.Drawing.Point(336, 111);
            this.txtnv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnv.Name = "txtnv";
            this.txtnv.Size = new System.Drawing.Size(428, 30);
            this.txtnv.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(906, 56);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(112, 36);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(906, 103);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 36);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(906, 148);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(906, 194);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(906, 240);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(112, 36);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(906, 286);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 36);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Location = new System.Drawing.Point(114, 448);
            this.dgvnhanvien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.Size = new System.Drawing.Size(968, 272);
            this.dgvnhanvien.TabIndex = 3;
            this.dgvnhanvien.Click += new System.EventHandler(this.dgvnhanvien_Click);
            // 
            // macl
            // 
            this.macl.AutoSize = true;
            this.macl.Location = new System.Drawing.Point(110, 216);
            this.macl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.macl.Name = "macl";
            this.macl.Size = new System.Drawing.Size(102, 25);
            this.macl.TabIndex = 0;
            this.macl.Text = "Mã ca làm";
            // 
            // macv
            // 
            this.macv.AutoSize = true;
            this.macv.Location = new System.Drawing.Point(112, 172);
            this.macv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.macv.Name = "macv";
            this.macv.Size = new System.Drawing.Size(128, 25);
            this.macv.TabIndex = 0;
            this.macv.Text = "Mã công việc";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSize = true;
            this.gioitinh.Location = new System.Drawing.Point(110, 257);
            this.gioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(82, 25);
            this.gioitinh.TabIndex = 0;
            this.gioitinh.Text = "Giới tính";
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.Location = new System.Drawing.Point(110, 307);
            this.ngaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(99, 25);
            this.ngaysinh.TabIndex = 0;
            this.ngaysinh.Text = "Ngày sinh";
            // 
            // dienthoai
            // 
            this.dienthoai.AutoSize = true;
            this.dienthoai.Location = new System.Drawing.Point(112, 356);
            this.dienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Size = new System.Drawing.Size(99, 25);
            this.dienthoai.TabIndex = 0;
            this.dienthoai.Text = "Điện thoại";
            // 
            // diachi
            // 
            this.diachi.AutoSize = true;
            this.diachi.Location = new System.Drawing.Point(112, 406);
            this.diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(71, 25);
            this.diachi.TabIndex = 0;
            this.diachi.Text = "Địa chỉ";
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(336, 300);
            this.txtngaysinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(428, 30);
            this.txtngaysinh.TabIndex = 1;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(336, 347);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(428, 30);
            this.txtdienthoai.TabIndex = 1;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(336, 393);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(428, 30);
            this.txtdiachi.TabIndex = 1;
            // 
            // cmbogioitinh
            // 
            this.cmbogioitinh.FormattingEnabled = true;
            this.cmbogioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cmbogioitinh.Location = new System.Drawing.Point(336, 252);
            this.cmbogioitinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbogioitinh.Name = "cmbogioitinh";
            this.cmbogioitinh.Size = new System.Drawing.Size(428, 33);
            this.cmbogioitinh.TabIndex = 4;
            // 
            // cmbomacv
            // 
            this.cmbomacv.FormattingEnabled = true;
            this.cmbomacv.Location = new System.Drawing.Point(336, 156);
            this.cmbomacv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbomacv.Name = "cmbomacv";
            this.cmbomacv.Size = new System.Drawing.Size(428, 33);
            this.cmbomacv.TabIndex = 5;
            // 
            // cmbomacl
            // 
            this.cmbomacl.FormattingEnabled = true;
            this.cmbomacl.Location = new System.Drawing.Point(338, 203);
            this.cmbomacl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbomacl.Name = "cmbomacl";
            this.cmbomacl.Size = new System.Drawing.Size(426, 33);
            this.cmbomacl.TabIndex = 5;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(338, 59);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(426, 30);
            this.txtmanv.TabIndex = 6;
            // 
            // btnCLCV
            // 
            this.btnCLCV.Location = new System.Drawing.Point(854, 345);
            this.btnCLCV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCLCV.Name = "btnCLCV";
            this.btnCLCV.Size = new System.Drawing.Size(210, 86);
            this.btnCLCV.TabIndex = 7;
            this.btnCLCV.Text = "QL ca làm và công việc";
            this.btnCLCV.UseVisualStyleBackColor = true;
            this.btnCLCV.Click += new System.EventHandler(this.btnCLCV_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 732);
            this.Controls.Add(this.btnCLCV);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.cmbomacl);
            this.Controls.Add(this.cmbomacv);
            this.Controls.Add(this.cmbogioitinh);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtnv);
            this.Controls.Add(this.macl);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.dienthoai);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.gioitinh);
            this.Controls.Add(this.macv);
            this.Controls.Add(this.nv);
            this.Controls.Add(this.manv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manv;
        private System.Windows.Forms.Label nv;
        private System.Windows.Forms.TextBox txtnv;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.Label macl;
        private System.Windows.Forms.Label macv;
        private System.Windows.Forms.Label gioitinh;
        private System.Windows.Forms.Label ngaysinh;
        private System.Windows.Forms.Label dienthoai;
        private System.Windows.Forms.Label diachi;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.ComboBox cmbogioitinh;
        private System.Windows.Forms.ComboBox cmbomacv;
        private System.Windows.Forms.ComboBox cmbomacl;
        private System.Windows.Forms.TextBox txtmanv;
		private System.Windows.Forms.Button btnCLCV;
	}
}