namespace BTLLTTQ.Menu_Items
{
    partial class FormTongTienbanhang
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
            this.btntim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbbmathang = new System.Windows.Forms.ComboBox();
            this.btnxuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mặt hàng";
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(736, 62);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(136, 61);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 473);
            this.dataGridView1.TabIndex = 3;
            // 
            // cmbbmathang
            // 
            this.cmbbmathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbbmathang.FormattingEnabled = true;
            this.cmbbmathang.Location = new System.Drawing.Point(222, 62);
            this.cmbbmathang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbmathang.Name = "cmbbmathang";
            this.cmbbmathang.Size = new System.Drawing.Size(433, 37);
            this.cmbbmathang.TabIndex = 4;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(950, 62);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(154, 61);
            this.btnxuat.TabIndex = 5;
            this.btnxuat.Text = "Xuất Excel";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // FormTongTienbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.cmbbmathang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTongTienbanhang";
            this.Text = "FormTongTienbanhang";
            this.Load += new System.EventHandler(this.FormTongTienbanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbbmathang;
        private System.Windows.Forms.Button btnxuat;
    }
}