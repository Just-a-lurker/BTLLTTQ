namespace BTLLTTQ.NhapVaBan
{
    partial class FormDonDatHang
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
            this.txt_madonhang = new System.Windows.Forms.TextBox();
            this.cmb_mkh = new System.Windows.Forms.ComboBox();
            this.cmb_mnv = new System.Windows.Forms.ComboBox();
            this.txt_ngaygiao = new System.Windows.Forms.DateTimePicker();
            this.txt_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_tennt = new System.Windows.Forms.TextBox();
            this.cmb_mnt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_nv = new System.Windows.Forms.RadioButton();
            this.rd_h = new System.Windows.Forms.RadioButton();
            this.rd_kh = new System.Windows.Forms.RadioButton();
            this.rd_ddh = new System.Windows.Forms.RadioButton();
            this.cmb_dondh = new System.Windows.Forms.ComboBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_datcoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_thue = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_tongtienbc = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_madonhang);
            this.groupBox1.Controls.Add(this.cmb_mkh);
            this.groupBox1.Controls.Add(this.cmb_mnv);
            this.groupBox1.Controls.Add(this.txt_ngaygiao);
            this.groupBox1.Controls.Add(this.txt_ngaydat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1166, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn đặt hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_madonhang
            // 
            this.txt_madonhang.Location = new System.Drawing.Point(234, 51);
            this.txt_madonhang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_madonhang.Name = "txt_madonhang";
            this.txt_madonhang.Size = new System.Drawing.Size(221, 28);
            this.txt_madonhang.TabIndex = 8;
            // 
            // cmb_mkh
            // 
            this.cmb_mkh.FormattingEnabled = true;
            this.cmb_mkh.Location = new System.Drawing.Point(234, 147);
            this.cmb_mkh.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_mkh.Name = "cmb_mkh";
            this.cmb_mkh.Size = new System.Drawing.Size(221, 30);
            this.cmb_mkh.TabIndex = 7;
            // 
            // cmb_mnv
            // 
            this.cmb_mnv.FormattingEnabled = true;
            this.cmb_mnv.Location = new System.Drawing.Point(234, 96);
            this.cmb_mnv.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_mnv.Name = "cmb_mnv";
            this.cmb_mnv.Size = new System.Drawing.Size(221, 30);
            this.cmb_mnv.TabIndex = 7;
            // 
            // txt_ngaygiao
            // 
            this.txt_ngaygiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaygiao.Location = new System.Drawing.Point(729, 113);
            this.txt_ngaygiao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngaygiao.Name = "txt_ngaygiao";
            this.txt_ngaygiao.Size = new System.Drawing.Size(273, 28);
            this.txt_ngaygiao.TabIndex = 6;
            // 
            // txt_ngaydat
            // 
            this.txt_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaydat.Location = new System.Drawing.Point(729, 54);
            this.txt_ngaydat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngaydat.Name = "txt_ngaydat";
            this.txt_ngaydat.Size = new System.Drawing.Size(273, 28);
            this.txt_ngaydat.TabIndex = 5;
            this.txt_ngaydat.ValueChanged += new System.EventHandler(this.txt_ngaydat_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày giao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày đặt ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn đặt hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.txt_gia);
            this.groupBox2.Controls.Add(this.txt_giamgia);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_tennt);
            this.groupBox2.Controls.Add(this.cmb_mnt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvHDBanHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1166, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(937, 82);
            this.txt_thanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(206, 28);
            this.txt_thanhtien.TabIndex = 12;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(937, 36);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.ReadOnly = true;
            this.txt_gia.Size = new System.Drawing.Size(206, 28);
            this.txt_gia.TabIndex = 11;
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Location = new System.Drawing.Point(599, 77);
            this.txt_giamgia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(206, 28);
            this.txt_giamgia.TabIndex = 10;
            this.txt_giamgia.TextChanged += new System.EventHandler(this.txt_giamgia_TextChanged);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(234, 76);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(221, 28);
            this.txt_soluong.TabIndex = 9;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // txt_tennt
            // 
            this.txt_tennt.Location = new System.Drawing.Point(599, 34);
            this.txt_tennt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tennt.Name = "txt_tennt";
            this.txt_tennt.ReadOnly = true;
            this.txt_tennt.Size = new System.Drawing.Size(206, 28);
            this.txt_tennt.TabIndex = 8;
            // 
            // cmb_mnt
            // 
            this.cmb_mnt.FormattingEnabled = true;
            this.cmb_mnt.Location = new System.Drawing.Point(234, 33);
            this.cmb_mnt.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_mnt.Name = "cmb_mnt";
            this.cmb_mnt.Size = new System.Drawing.Size(221, 30);
            this.cmb_mnt.TabIndex = 7;
            this.cmb_mnt.SelectedIndexChanged += new System.EventHandler(this.cmb_mnt_SelectedIndexChanged);
            this.cmb_mnt.TextChanged += new System.EventHandler(this.cmb_mnt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(823, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "Thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(823, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Giảm giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên Nội Thất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã nội thất";
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHDBanHang.Location = new System.Drawing.Point(4, 126);
            this.dgvHDBanHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.RowHeadersWidth = 51;
            this.dgvHDBanHang.RowTemplate.Height = 24;
            this.dgvHDBanHang.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvHDBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDBanHang.Size = new System.Drawing.Size(1158, 218);
            this.dgvHDBanHang.TabIndex = 0;
            this.dgvHDBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDBanHang_CellClick);
            this.dgvHDBanHang.DoubleClick += new System.EventHandler(this.dgvHDBanHang_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_nv);
            this.panel1.Controls.Add(this.rd_h);
            this.panel1.Controls.Add(this.rd_kh);
            this.panel1.Controls.Add(this.rd_ddh);
            this.panel1.Controls.Add(this.cmb_dondh);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 641);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 67);
            this.panel1.TabIndex = 2;
            // 
            // rd_nv
            // 
            this.rd_nv.AutoSize = true;
            this.rd_nv.Location = new System.Drawing.Point(332, 17);
            this.rd_nv.Name = "rd_nv";
            this.rd_nv.Size = new System.Drawing.Size(156, 26);
            this.rd_nv.TabIndex = 11;
            this.rd_nv.TabStop = true;
            this.rd_nv.Text = "Mã Nhân Viên";
            this.rd_nv.UseVisualStyleBackColor = true;
            this.rd_nv.CheckedChanged += new System.EventHandler(this.rd_nv_CheckedChanged);
            // 
            // rd_h
            // 
            this.rd_h.AutoSize = true;
            this.rd_h.Location = new System.Drawing.Point(197, 17);
            this.rd_h.Name = "rd_h";
            this.rd_h.Size = new System.Drawing.Size(110, 26);
            this.rd_h.TabIndex = 10;
            this.rd_h.TabStop = true;
            this.rd_h.Text = "Mã Hàng";
            this.rd_h.UseVisualStyleBackColor = true;
            this.rd_h.CheckedChanged += new System.EventHandler(this.rd_h_CheckedChanged);
            // 
            // rd_kh
            // 
            this.rd_kh.AutoSize = true;
            this.rd_kh.Location = new System.Drawing.Point(16, 17);
            this.rd_kh.Name = "rd_kh";
            this.rd_kh.Size = new System.Drawing.Size(172, 26);
            this.rd_kh.TabIndex = 9;
            this.rd_kh.TabStop = true;
            this.rd_kh.Text = "Mã Khách Hàng";
            this.rd_kh.UseVisualStyleBackColor = true;
            this.rd_kh.CheckedChanged += new System.EventHandler(this.rd_kh_CheckedChanged);
            // 
            // rd_ddh
            // 
            this.rd_ddh.AutoSize = true;
            this.rd_ddh.Location = new System.Drawing.Point(504, 17);
            this.rd_ddh.Name = "rd_ddh";
            this.rd_ddh.Size = new System.Drawing.Size(189, 26);
            this.rd_ddh.TabIndex = 8;
            this.rd_ddh.TabStop = true;
            this.rd_ddh.Text = "Mã Đơn Đặt Hàng";
            this.rd_ddh.UseVisualStyleBackColor = true;
            this.rd_ddh.CheckedChanged += new System.EventHandler(this.rd_ddh_CheckedChanged);
            // 
            // cmb_dondh
            // 
            this.cmb_dondh.FormattingEnabled = true;
            this.cmb_dondh.Location = new System.Drawing.Point(740, 16);
            this.cmb_dondh.Name = "cmb_dondh";
            this.cmb_dondh.Size = new System.Drawing.Size(188, 30);
            this.cmb_dondh.TabIndex = 3;
            this.cmb_dondh.DropDown += new System.EventHandler(this.cmb_dondh_DropDown);
            this.cmb_dondh.SelectedIndexChanged += new System.EventHandler(this.cmb_dondh_SelectedIndexChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(982, 12);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(142, 42);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 551);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "Đặt Cọc";
            // 
            // txt_datcoc
            // 
            this.txt_datcoc.Location = new System.Drawing.Point(151, 551);
            this.txt_datcoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_datcoc.Name = "txt_datcoc";
            this.txt_datcoc.Size = new System.Drawing.Size(173, 28);
            this.txt_datcoc.TabIndex = 4;
            this.txt_datcoc.TextChanged += new System.EventHandler(this.txt_datcoc_TextChanged);
            this.txt_datcoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_datcoc_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 554);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "Thuế";
            // 
            // txt_thue
            // 
            this.txt_thue.Location = new System.Drawing.Point(433, 549);
            this.txt_thue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thue.Name = "txt_thue";
            this.txt_thue.Size = new System.Drawing.Size(183, 28);
            this.txt_thue.TabIndex = 6;
            this.txt_thue.TextChanged += new System.EventHandler(this.txt_thue_TextChanged);
            this.txt_thue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thue_KeyPress);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(746, 551);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(188, 28);
            this.txt_tongtien.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(643, 554);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 22);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tổng tiền";
            // 
            // txt_tongtienbc
            // 
            this.txt_tongtienbc.Location = new System.Drawing.Point(943, 551);
            this.txt_tongtienbc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tongtienbc.Name = "txt_tongtienbc";
            this.txt_tongtienbc.Size = new System.Drawing.Size(187, 28);
            this.txt_tongtienbc.TabIndex = 9;
            this.txt_tongtienbc.Visible = false;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(37, 584);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(140, 50);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm Mới";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(224, 584);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(145, 50);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu DS";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(421, 586);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(142, 50);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.Location = new System.Drawing.Point(609, 584);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(151, 50);
            this.btn_xuat.TabIndex = 13;
            this.btn_xuat.Text = "Xuất ra Excel";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(983, 586);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(147, 50);
            this.btn_dong.TabIndex = 14;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(795, 586);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(149, 50);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 708);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tongtienbc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.txt_thue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_datcoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDonDatHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDonDatHang_FormClosing);
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHDBanHang;
        private System.Windows.Forms.ComboBox cmb_mnv;
        private System.Windows.Forms.DateTimePicker txt_ngaygiao;
        private System.Windows.Forms.DateTimePicker txt_ngaydat;
        private System.Windows.Forms.TextBox txt_madonhang;
        private System.Windows.Forms.ComboBox cmb_mkh;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_tennt;
        private System.Windows.Forms.ComboBox cmb_mnt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_datcoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_thue;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_tongtienbc;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.ComboBox cmb_dondh;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.RadioButton rd_nv;
        private System.Windows.Forms.RadioButton rd_h;
        private System.Windows.Forms.RadioButton rd_kh;
        private System.Windows.Forms.RadioButton rd_ddh;
    }
}