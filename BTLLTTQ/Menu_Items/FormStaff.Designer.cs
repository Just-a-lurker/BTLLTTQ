namespace BTLLTTQ.Menu_Items
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
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.nv = new System.Windows.Forms.Label();
            this.txtnv = new System.Windows.Forms.TextBox();
            this.cl = new System.Windows.Forms.Label();
            this.txtcl = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.macl = new System.Windows.Forms.Label();
            this.txtmacl = new System.Windows.Forms.TextBox();
            this.macv = new System.Windows.Forms.Label();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.cv = new System.Windows.Forms.Label();
            this.txtcv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(74, 44);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(86, 16);
            this.manv.TabIndex = 0;
            this.manv.Text = "Mã nhân viên";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(224, 37);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(286, 22);
            this.txtmanv.TabIndex = 1;
            // 
            // nv
            // 
            this.nv.AutoSize = true;
            this.nv.Location = new System.Drawing.Point(73, 78);
            this.nv.Name = "nv";
            this.nv.Size = new System.Drawing.Size(67, 16);
            this.nv.TabIndex = 0;
            this.nv.Text = "Nhân viên";
            // 
            // txtnv
            // 
            this.txtnv.Location = new System.Drawing.Point(224, 71);
            this.txtnv.Name = "txtnv";
            this.txtnv.Size = new System.Drawing.Size(286, 22);
            this.txtnv.TabIndex = 1;
            // 
            // cl
            // 
            this.cl.AutoSize = true;
            this.cl.Location = new System.Drawing.Point(73, 201);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(49, 16);
            this.cl.TabIndex = 0;
            this.cl.Text = "Ca làm";
            // 
            // txtcl
            // 
            this.txtcl.Location = new System.Drawing.Point(224, 195);
            this.txtcl.Name = "txtcl";
            this.txtcl.Size = new System.Drawing.Size(286, 22);
            this.txtcl.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(646, 41);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(646, 71);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(646, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(646, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(646, 159);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(646, 188);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Location = new System.Drawing.Point(76, 231);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.Size = new System.Drawing.Size(645, 192);
            this.dgvnhanvien.TabIndex = 3;
            this.dgvnhanvien.Click += new System.EventHandler(this.dgvnhanvien_Click);
            // 
            // macl
            // 
            this.macl.AutoSize = true;
            this.macl.Location = new System.Drawing.Point(73, 168);
            this.macl.Name = "macl";
            this.macl.Size = new System.Drawing.Size(69, 16);
            this.macl.TabIndex = 0;
            this.macl.Text = "Mã ca làm";
            // 
            // txtmacl
            // 
            this.txtmacl.Location = new System.Drawing.Point(224, 162);
            this.txtmacl.Name = "txtmacl";
            this.txtmacl.Size = new System.Drawing.Size(286, 22);
            this.txtmacl.TabIndex = 1;
            // 
            // macv
            // 
            this.macv.AutoSize = true;
            this.macv.Location = new System.Drawing.Point(74, 110);
            this.macv.Name = "macv";
            this.macv.Size = new System.Drawing.Size(87, 16);
            this.macv.TabIndex = 0;
            this.macv.Text = "Mã công việc";
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(225, 104);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(286, 22);
            this.txtmacv.TabIndex = 1;
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Location = new System.Drawing.Point(73, 138);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(67, 16);
            this.cv.TabIndex = 0;
            this.cv.Text = "Công việc";
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(225, 132);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(286, 22);
            this.txtcv.TabIndex = 1;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtmacl);
            this.Controls.Add(this.txtcl);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.txtmacv);
            this.Controls.Add(this.txtnv);
            this.Controls.Add(this.macl);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.cv);
            this.Controls.Add(this.macv);
            this.Controls.Add(this.nv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.manv);
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label nv;
        private System.Windows.Forms.TextBox txtnv;
        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.TextBox txtcl;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.Label macl;
        private System.Windows.Forms.TextBox txtmacl;
        private System.Windows.Forms.Label macv;
        private System.Windows.Forms.TextBox txtmacv;
        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.TextBox txtcv;
    }
}