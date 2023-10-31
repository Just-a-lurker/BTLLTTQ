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
            this.ncc = new System.Windows.Forms.Label();
            this.thang = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mh = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmboncc = new System.Windows.Forms.ComboBox();
            this.cmbomh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ncc
            // 
            this.ncc.AutoSize = true;
            this.ncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ncc.Location = new System.Drawing.Point(58, 43);
            this.ncc.Name = "ncc";
            this.ncc.Size = new System.Drawing.Size(160, 29);
            this.ncc.TabIndex = 0;
            this.ncc.Text = "Nhà cung cấp";
            // 
            // thang
            // 
            this.thang.AutoSize = true;
            this.thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thang.Location = new System.Drawing.Point(58, 185);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(82, 29);
            this.thang.TabIndex = 0;
            this.thang.Text = "Tháng";
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntim.Location = new System.Drawing.Point(806, 110);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(89, 37);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 272);
            this.dataGridView1.TabIndex = 4;
            // 
            // mh
            // 
            this.mh.AutoSize = true;
            this.mh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mh.Location = new System.Drawing.Point(58, 114);
            this.mh.Name = "mh";
            this.mh.Size = new System.Drawing.Size(111, 29);
            this.mh.TabIndex = 0;
            this.mh.Text = "Mặt hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // cmboncc
            // 
            this.cmboncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmboncc.FormattingEnabled = true;
            this.cmboncc.Location = new System.Drawing.Point(236, 35);
            this.cmboncc.Name = "cmboncc";
            this.cmboncc.Size = new System.Drawing.Size(269, 37);
            this.cmboncc.TabIndex = 5;
            // 
            // cmbomh
            // 
            this.cmbomh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbomh.FormattingEnabled = true;
            this.cmbomh.Location = new System.Drawing.Point(236, 106);
            this.cmbomh.Name = "cmbomh";
            this.cmbomh.Size = new System.Drawing.Size(269, 37);
            this.cmbomh.TabIndex = 5;
            // 
            // Formbaocaonhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 581);
            this.Controls.Add(this.cmbomh);
            this.Controls.Add(this.cmboncc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.mh);
            this.Controls.Add(this.ncc);
            this.Name = "Formbaocaonhacungcap";
            this.Text = "Formbaocaonhacungcap";
            this.Load += new System.EventHandler(this.Formbaocaonhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ncc;
        private System.Windows.Forms.Label thang;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmboncc;
        private System.Windows.Forms.ComboBox cmbomh;
    }
}