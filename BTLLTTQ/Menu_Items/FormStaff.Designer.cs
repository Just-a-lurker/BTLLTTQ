namespace BTLLTTQ.Menu_Items
{
    partial class FormStaff
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
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tennv,
            this.tencv,
            this.calam,
            this.tongtg});
            this.dataGridViewShifts.Location = new System.Drawing.Point(84, 60);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.RowHeadersWidth = 51;
            this.dataGridViewShifts.RowTemplate.Height = 24;
            this.dataGridViewShifts.Size = new System.Drawing.Size(632, 374);
            this.dataGridViewShifts.TabIndex = 5;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 60;
            // 
            // tennv
            // 
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            this.tennv.Width = 200;
            // 
            // tencv
            // 
            this.tencv.HeaderText = "Tên công việc";
            this.tencv.MinimumWidth = 6;
            this.tencv.Name = "tencv";
            this.tencv.Width = 200;
            // 
            // calam
            // 
            this.calam.HeaderText = "Ca làm";
            this.calam.MinimumWidth = 6;
            this.calam.Name = "calam";
            this.calam.Width = 60;
            // 
            // tongtg
            // 
            this.tongtg.HeaderText = "Tổng thời gian làm";
            this.tongtg.MinimumWidth = 6;
            this.tongtg.Name = "tongtg";
            this.tongtg.Width = 60;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách ca làm việc";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewShifts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShifts;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
        private System.Windows.Forms.DataGridViewTextBoxColumn calam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}