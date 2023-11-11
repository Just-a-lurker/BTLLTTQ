namespace BTLLTTQ.Menu
{
    partial class FormProduct
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
			this.txtMaSP = new System.Windows.Forms.TextBox();
			this.groupProducts = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenSP = new System.Windows.Forms.TextBox();
			this.groupBottons = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupProducts.SuspendLayout();
			this.groupBottons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(262, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Products";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtMaSP
			// 
			this.txtMaSP.Location = new System.Drawing.Point(164, 38);
			this.txtMaSP.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.Size = new System.Drawing.Size(101, 20);
			this.txtMaSP.TabIndex = 1;
			// 
			// groupProducts
			// 
			this.groupProducts.Controls.Add(this.label3);
			this.groupProducts.Controls.Add(this.label2);
			this.groupProducts.Controls.Add(this.txtTenSP);
			this.groupProducts.Controls.Add(this.txtMaSP);
			this.groupProducts.Location = new System.Drawing.Point(36, 47);
			this.groupProducts.Margin = new System.Windows.Forms.Padding(2);
			this.groupProducts.Name = "groupProducts";
			this.groupProducts.Padding = new System.Windows.Forms.Padding(2);
			this.groupProducts.Size = new System.Drawing.Size(341, 154);
			this.groupProducts.TabIndex = 2;
			this.groupProducts.TabStop = false;
			this.groupProducts.Text = "Group Products";
			this.groupProducts.UseCompatibleTextRendering = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 95);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên sản phẩm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 41);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mã sản phẩm";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtTenSP
			// 
			this.txtTenSP.Location = new System.Drawing.Point(164, 93);
			this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.Size = new System.Drawing.Size(101, 20);
			this.txtTenSP.TabIndex = 1;
			// 
			// groupBottons
			// 
			this.groupBottons.Controls.Add(this.button1);
			this.groupBottons.Controls.Add(this.btnThoat);
			this.groupBottons.Controls.Add(this.btnXoa);
			this.groupBottons.Controls.Add(this.btnSua);
			this.groupBottons.Controls.Add(this.btnThem);
			this.groupBottons.Location = new System.Drawing.Point(911, 11);
			this.groupBottons.Margin = new System.Windows.Forms.Padding(2);
			this.groupBottons.Name = "groupBottons";
			this.groupBottons.Padding = new System.Windows.Forms.Padding(2);
			this.groupBottons.Size = new System.Drawing.Size(150, 325);
			this.groupBottons.TabIndex = 3;
			this.groupBottons.TabStop = false;
			this.groupBottons.Text = "Group Buttons";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(35, 284);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Thêm SP mới";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(45, 240);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(64, 23);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(45, 176);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(64, 23);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(45, 113);
			this.btnSua.Margin = new System.Windows.Forms.Padding(2);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(64, 23);
			this.btnSua.TabIndex = 4;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(45, 55);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(64, 23);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP});
			this.dataGridView.Location = new System.Drawing.Point(11, 295);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(869, 197);
			this.dataGridView.TabIndex = 5;
			// 
			// MaSP
			// 
			this.MaSP.HeaderText = "Mã sản phẩm";
			this.MaSP.MinimumWidth = 6;
			this.MaSP.Name = "MaSP";
			this.MaSP.Width = 125;
			// 
			// TenSP
			// 
			this.TenSP.HeaderText = "Tên sản phẩm";
			this.TenSP.MinimumWidth = 6;
			this.TenSP.Name = "TenSP";
			this.TenSP.Width = 125;
			// 
			// FormProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1072, 503);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.groupBottons);
			this.Controls.Add(this.groupProducts);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormProduct";
			this.Text = "FormProduct";
			this.groupProducts.ResumeLayout(false);
			this.groupProducts.PerformLayout();
			this.groupBottons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaSP;
		private System.Windows.Forms.GroupBox groupProducts;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenSP;
		private System.Windows.Forms.GroupBox groupBottons;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
		private System.Windows.Forms.Button button1;
	}
}