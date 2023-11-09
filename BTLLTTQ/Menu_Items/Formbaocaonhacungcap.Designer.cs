namespace BTLLTTQ.Menu_Items
{
    partial class Formbaocaonhacungcap
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
            this.thang = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mh = new System.Windows.Forms.Label();
            this.cmbomh = new System.Windows.Forms.ComboBox();
            this.cmbothang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // thang
            // 
            this.thang.AutoSize = true;
            this.thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thang.Location = new System.Drawing.Point(58, 118);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(82, 29);
            this.thang.TabIndex = 0;
            this.thang.Text = "Tháng";
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntim.Location = new System.Drawing.Point(806, 90);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(89, 37);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 356);
            this.dataGridView1.TabIndex = 4;
            // 
            // mh
            // 
            this.mh.AutoSize = true;
            this.mh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mh.Location = new System.Drawing.Point(58, 46);
            this.mh.Name = "mh";
            this.mh.Size = new System.Drawing.Size(111, 29);
            this.mh.TabIndex = 0;
            this.mh.Text = "Mặt hàng";
            // 
            // cmbomh
            // 
            this.cmbomh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbomh.FormattingEnabled = true;
            this.cmbomh.Location = new System.Drawing.Point(236, 46);
            this.cmbomh.Name = "cmbomh";
            this.cmbomh.Size = new System.Drawing.Size(269, 37);
            this.cmbomh.TabIndex = 5;
            // 
            // cmbothang
            // 
            this.cmbothang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbothang.FormattingEnabled = true;
            this.cmbothang.Location = new System.Drawing.Point(236, 118);
            this.cmbothang.Name = "cmbothang";
            this.cmbothang.Size = new System.Drawing.Size(269, 37);
            this.cmbothang.TabIndex = 6;
            // 
            // Formbaocaonhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 581);
            this.Controls.Add(this.cmbothang);
            this.Controls.Add(this.cmbomh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.mh);
            this.Name = "Formbaocaonhacungcap";
            this.Text = "Formbaocaonhacungcap";
            this.Load += new System.EventHandler(this.Formbaocaonhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label thang;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mh;
        private System.Windows.Forms.ComboBox cmbomh;
        private System.Windows.Forms.ComboBox cmbothang;
    }
}