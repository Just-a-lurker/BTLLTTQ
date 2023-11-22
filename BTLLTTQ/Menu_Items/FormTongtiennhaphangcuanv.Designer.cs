namespace BTLLTTQ.Menu_Items
{
    partial class FormTongtiennhaphangcuanv
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
            this.cmbonv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboquy = new System.Windows.Forms.ComboBox();
            this.btntim = new System.Windows.Forms.Button();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // cmbonv
            // 
            this.cmbonv.FormattingEnabled = true;
            this.cmbonv.Location = new System.Drawing.Point(280, 72);
            this.cmbonv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbonv.Name = "cmbonv";
            this.cmbonv.Size = new System.Drawing.Size(265, 33);
            this.cmbonv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Qúy";
            // 
            // cmboquy
            // 
            this.cmboquy.FormattingEnabled = true;
            this.cmboquy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmboquy.Location = new System.Drawing.Point(280, 190);
            this.cmboquy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboquy.Name = "cmboquy";
            this.cmboquy.Size = new System.Drawing.Size(265, 33);
            this.cmboquy.TabIndex = 1;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(914, 73);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(210, 36);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dgvds
            // 
            this.dgvds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(129, 267);
            this.dgvds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvds.Name = "dgvds";
            this.dgvds.RowHeadersWidth = 51;
            this.dgvds.RowTemplate.Height = 24;
            this.dgvds.Size = new System.Drawing.Size(994, 367);
            this.dgvds.TabIndex = 3;
            this.dgvds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellContentClick);
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(914, 131);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(210, 36);
            this.btnxuat.TabIndex = 4;
            this.btnxuat.Text = "Xuất Excel";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnword
            // 
            this.btnword.Location = new System.Drawing.Point(914, 190);
            this.btnword.Name = "btnword";
            this.btnword.Size = new System.Drawing.Size(209, 34);
            this.btnword.TabIndex = 5;
            this.btnword.Text = "Xuất word";
            this.btnword.UseVisualStyleBackColor = true;
            this.btnword.Click += new System.EventHandler(this.btnword_Click);
            // 
            // FormTongtiennhaphangcuanv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnword);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.dgvds);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.cmboquy);
            this.Controls.Add(this.cmbonv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTongtiennhaphangcuanv";
            this.Text = "FormTongtiennhaphangcuanv";
            this.Load += new System.EventHandler(this.FormTongtiennhaphangcuanv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbonv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboquy;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnword;
    }
}