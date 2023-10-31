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
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // cmbonv
            // 
            this.cmbonv.FormattingEnabled = true;
            this.cmbonv.Location = new System.Drawing.Point(187, 46);
            this.cmbonv.Name = "cmbonv";
            this.cmbonv.Size = new System.Drawing.Size(178, 24);
            this.cmbonv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
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
            this.cmboquy.Location = new System.Drawing.Point(187, 99);
            this.cmboquy.Name = "cmboquy";
            this.cmboquy.Size = new System.Drawing.Size(178, 24);
            this.cmboquy.TabIndex = 1;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(674, 47);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dgvds
            // 
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(86, 171);
            this.dgvds.Name = "dgvds";
            this.dgvds.RowHeadersWidth = 51;
            this.dgvds.RowTemplate.Height = 24;
            this.dgvds.Size = new System.Drawing.Size(663, 235);
            this.dgvds.TabIndex = 3;
            this.dgvds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellContentClick);
            // 
            // FormTongtiennhaphangcuanv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvds);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.cmboquy);
            this.Controls.Add(this.cmbonv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTongtiennhaphangcuanv";
            this.Text = "FormTongtiennhaphangcuanv";
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
    }
}