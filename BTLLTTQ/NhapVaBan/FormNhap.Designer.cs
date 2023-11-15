namespace BTLLTTQ.NhapVaBan
{
    partial class FormNhap
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.txtHDN = new System.Windows.Forms.TextBox();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.cbbMaNV = new System.Windows.Forms.ComboBox();
			this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
			this.cBBmaNCC = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnXemAll = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(32, 222);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(764, 524);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(1010, 222);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(199, 54);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(1010, 286);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(199, 54);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(1010, 353);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(199, 54);
			this.btnSua.TabIndex = 3;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// txtHDN
			// 
			this.txtHDN.Location = new System.Drawing.Point(171, 34);
			this.txtHDN.Margin = new System.Windows.Forms.Padding(4);
			this.txtHDN.Name = "txtHDN";
			this.txtHDN.Size = new System.Drawing.Size(160, 22);
			this.txtHDN.TabIndex = 4;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(572, 34);
			this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(224, 22);
			this.txtTongTien.TabIndex = 8;
			// 
			// cbbMaNV
			// 
			this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbMaNV.FormattingEnabled = true;
			this.cbbMaNV.Location = new System.Drawing.Point(171, 91);
			this.cbbMaNV.Margin = new System.Windows.Forms.Padding(4);
			this.cbbMaNV.Name = "cbbMaNV";
			this.cbbMaNV.Size = new System.Drawing.Size(160, 24);
			this.cbbMaNV.TabIndex = 9;
			// 
			// dateNgayNhap
			// 
			this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateNgayNhap.Location = new System.Drawing.Point(171, 143);
			this.dateNgayNhap.Margin = new System.Windows.Forms.Padding(4);
			this.dateNgayNhap.Name = "dateNgayNhap";
			this.dateNgayNhap.Size = new System.Drawing.Size(160, 22);
			this.dateNgayNhap.TabIndex = 10;
			// 
			// cBBmaNCC
			// 
			this.cBBmaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBBmaNCC.FormattingEnabled = true;
			this.cBBmaNCC.Location = new System.Drawing.Point(171, 190);
			this.cBBmaNCC.Margin = new System.Windows.Forms.Padding(4);
			this.cBBmaNCC.Name = "cBBmaNCC";
			this.cBBmaNCC.Size = new System.Drawing.Size(160, 24);
			this.cBBmaNCC.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 25);
			this.label1.TabIndex = 12;
			this.label1.Text = "Số HĐN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 92);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 25);
			this.label2.TabIndex = 13;
			this.label2.Text = "Mã NV";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 143);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 25);
			this.label3.TabIndex = 14;
			this.label3.Text = "Ngày nhập";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 191);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 25);
			this.label4.TabIndex = 15;
			this.label4.Text = "Mã NCC";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(435, 34);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 25);
			this.label5.TabIndex = 16;
			this.label5.Text = "Tổng tiền";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1010, 684);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 60);
			this.button1.TabIndex = 17;
			this.button1.Text = "Xem chi tiết";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(1010, 414);
			this.btnTim.Margin = new System.Windows.Forms.Padding(4);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(199, 54);
			this.btnTim.TabIndex = 18;
			this.btnTim.Text = "Tìm Số HĐN";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// btnXemAll
			// 
			this.btnXemAll.Location = new System.Drawing.Point(1010, 622);
			this.btnXemAll.Margin = new System.Windows.Forms.Padding(4);
			this.btnXemAll.Name = "btnXemAll";
			this.btnXemAll.Size = new System.Drawing.Size(199, 54);
			this.btnXemAll.TabIndex = 19;
			this.btnXemAll.Text = "Xem tất cả HĐN";
			this.btnXemAll.UseVisualStyleBackColor = true;
			this.btnXemAll.Click += new System.EventHandler(this.btnXemAll_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1010, 476);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(199, 54);
			this.button2.TabIndex = 20;
			this.button2.Text = "Thoát";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FormNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1297, 804);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnXemAll);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cBBmaNCC);
			this.Controls.Add(this.dateNgayNhap);
			this.Controls.Add(this.cbbMaNV);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.txtHDN);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormNhap";
			this.Text = "FormNhap";
			this.Load += new System.EventHandler(this.FormNhap_Load);
			this.Click += new System.EventHandler(this.FormNhap_Click);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtHDN;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.ComboBox cBBmaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXemAll;
		private System.Windows.Forms.Button button2;
	}
}