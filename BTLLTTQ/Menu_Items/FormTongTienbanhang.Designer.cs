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
            this.btnword = new System.Windows.Forms.Button();
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
            this.btntim.Location = new System.Drawing.Point(93, 146);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(136, 38);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 207);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 433);
            this.dataGridView1.TabIndex = 3;
            // 
            // cmbbmathang
            // 
            this.cmbbmathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbbmathang.FormattingEnabled = true;
            this.cmbbmathang.Location = new System.Drawing.Point(222, 77);
            this.cmbbmathang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbmathang.Name = "cmbbmathang";
            this.cmbbmathang.Size = new System.Drawing.Size(433, 37);
            this.cmbbmathang.TabIndex = 4;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(564, 146);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(138, 42);
            this.btnxuat.TabIndex = 5;
            this.btnxuat.Text = "Xuất Excel";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnword
            // 
            this.btnword.Location = new System.Drawing.Point(963, 144);
            this.btnword.Name = "btnword";
            this.btnword.Size = new System.Drawing.Size(141, 40);
            this.btnword.TabIndex = 6;
            this.btnword.Text = "Xuất word";
            this.btnword.UseVisualStyleBackColor = true;
            this.btnword.Click += new System.EventHandler(this.btnword_Click);
            // 
            // FormTongTienbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnword);
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
        private System.Windows.Forms.Button btnword;
    }
}