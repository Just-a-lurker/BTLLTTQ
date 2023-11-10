namespace BTLLTTQ.Menu_Items
{
	partial class FormCaLamCongViec
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
			this.dgvCLCV = new System.Windows.Forms.DataGridView();
			this.btnCaLam = new System.Windows.Forms.Button();
			this.btnCongViec = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.txtMa = new System.Windows.Forms.TextBox();
			this.labelMa = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTen = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvCLCV)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCLCV
			// 
			this.dgvCLCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCLCV.Location = new System.Drawing.Point(92, 12);
			this.dgvCLCV.Margin = new System.Windows.Forms.Padding(2);
			this.dgvCLCV.Name = "dgvCLCV";
			this.dgvCLCV.RowHeadersWidth = 51;
			this.dgvCLCV.RowTemplate.Height = 24;
			this.dgvCLCV.Size = new System.Drawing.Size(352, 194);
			this.dgvCLCV.TabIndex = 4;
			this.dgvCLCV.Click += new System.EventHandler(this.dgvCLCV_Click);
			// 
			// btnCaLam
			// 
			this.btnCaLam.Location = new System.Drawing.Point(353, 210);
			this.btnCaLam.Name = "btnCaLam";
			this.btnCaLam.Size = new System.Drawing.Size(91, 40);
			this.btnCaLam.TabIndex = 5;
			this.btnCaLam.Text = "Load ca làm";
			this.btnCaLam.UseVisualStyleBackColor = true;
			this.btnCaLam.Click += new System.EventHandler(this.btnCaLam_Click);
			// 
			// btnCongViec
			// 
			this.btnCongViec.Location = new System.Drawing.Point(92, 210);
			this.btnCongViec.Name = "btnCongViec";
			this.btnCongViec.Size = new System.Drawing.Size(91, 40);
			this.btnCongViec.TabIndex = 6;
			this.btnCongViec.Text = "Load Công Việc";
			this.btnCongViec.UseVisualStyleBackColor = true;
			this.btnCongViec.Click += new System.EventHandler(this.btnCongViec_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(12, 12);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 32);
			this.btnThem.TabIndex = 7;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 8;
			this.button1.Text = "Sửa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(12, 110);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 30);
			this.btnXoa.TabIndex = 9;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(12, 157);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(75, 32);
			this.btnTim.TabIndex = 10;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// txtMa
			// 
			this.txtMa.Location = new System.Drawing.Point(509, 12);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(121, 20);
			this.txtMa.TabIndex = 11;
			// 
			// labelMa
			// 
			this.labelMa.AutoSize = true;
			this.labelMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMa.Location = new System.Drawing.Point(449, 12);
			this.labelMa.Name = "labelMa";
			this.labelMa.Size = new System.Drawing.Size(31, 20);
			this.labelMa.TabIndex = 12;
			this.labelMa.Text = "Mã";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(449, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "Tên";
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(509, 59);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(121, 20);
			this.txtTen.TabIndex = 13;
			// 
			// FormCaLamCongViec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 269);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.labelMa);
			this.Controls.Add(this.txtMa);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnCongViec);
			this.Controls.Add(this.btnCaLam);
			this.Controls.Add(this.dgvCLCV);
			this.Name = "FormCaLamCongViec";
			this.Text = "FormCaLamCongViec";
			this.Click += new System.EventHandler(this.FormCaLamCongViec_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgvCLCV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCLCV;
		private System.Windows.Forms.Button btnCaLam;
		private System.Windows.Forms.Button btnCongViec;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.TextBox txtMa;
		private System.Windows.Forms.Label labelMa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTen;
	}
}