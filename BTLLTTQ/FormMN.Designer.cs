namespace BTLLTTQ
{
    partial class FormMN
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.btn_thismonth = new System.Windows.Forms.Button();
            this.btn_l3d = new System.Windows.Forms.Button();
            this.btn_l7d = new System.Windows.Forms.Button();
            this.btn_ct = new System.Windows.Forms.Button();
            this.btn_td = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ttrevenue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ttprofit = new System.Windows.Forms.Label();
            this.btn_lo = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nb_customers = new System.Windows.Forms.Label();
            this.nb_suppliers = new System.Windows.Forms.Label();
            this.nb_products = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.btn_lo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_date
            // 
            this.start_date.CustomFormat = "MMM dd,yyyy";
            this.start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date.Location = new System.Drawing.Point(111, 21);
            this.start_date.Margin = new System.Windows.Forms.Padding(4);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(170, 28);
            this.start_date.TabIndex = 0;
            // 
            // end_date
            // 
            this.end_date.CustomFormat = "MMM dd,yyyy";
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.Location = new System.Drawing.Point(289, 20);
            this.end_date.Margin = new System.Windows.Forms.Padding(4);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(170, 28);
            this.end_date.TabIndex = 0;
            // 
            // btn_thismonth
            // 
            this.btn_thismonth.Location = new System.Drawing.Point(1083, 21);
            this.btn_thismonth.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thismonth.Name = "btn_thismonth";
            this.btn_thismonth.Size = new System.Drawing.Size(147, 32);
            this.btn_thismonth.TabIndex = 1;
            this.btn_thismonth.Text = "This Month";
            this.btn_thismonth.UseVisualStyleBackColor = true;
            this.btn_thismonth.Click += new System.EventHandler(this.btn_thismonth_Click);
            // 
            // btn_l3d
            // 
            this.btn_l3d.Location = new System.Drawing.Point(935, 21);
            this.btn_l3d.Margin = new System.Windows.Forms.Padding(4);
            this.btn_l3d.Name = "btn_l3d";
            this.btn_l3d.Size = new System.Drawing.Size(140, 32);
            this.btn_l3d.TabIndex = 1;
            this.btn_l3d.Text = "Last 30 days";
            this.btn_l3d.UseVisualStyleBackColor = true;
            this.btn_l3d.Click += new System.EventHandler(this.btn_l3d_Click);
            // 
            // btn_l7d
            // 
            this.btn_l7d.Location = new System.Drawing.Point(793, 21);
            this.btn_l7d.Margin = new System.Windows.Forms.Padding(4);
            this.btn_l7d.Name = "btn_l7d";
            this.btn_l7d.Size = new System.Drawing.Size(134, 32);
            this.btn_l7d.TabIndex = 1;
            this.btn_l7d.Text = "Last 7 days";
            this.btn_l7d.UseVisualStyleBackColor = true;
            this.btn_l7d.Click += new System.EventHandler(this.btn_l7d_Click);
            // 
            // btn_ct
            // 
            this.btn_ct.Location = new System.Drawing.Point(571, 20);
            this.btn_ct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ct.Name = "btn_ct";
            this.btn_ct.Size = new System.Drawing.Size(103, 32);
            this.btn_ct.TabIndex = 1;
            this.btn_ct.Text = "Custom";
            this.btn_ct.UseVisualStyleBackColor = true;
            this.btn_ct.Click += new System.EventHandler(this.btn_ct_Click);
            // 
            // btn_td
            // 
            this.btn_td.Location = new System.Drawing.Point(682, 20);
            this.btn_td.Margin = new System.Windows.Forms.Padding(4);
            this.btn_td.Name = "btn_td";
            this.btn_td.Size = new System.Drawing.Size(103, 32);
            this.btn_td.TabIndex = 1;
            this.btn_td.Text = "Today";
            this.btn_td.UseVisualStyleBackColor = true;
            this.btn_td.Click += new System.EventHandler(this.btn_td_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(495, 19);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(69, 34);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Oders";
            // 
            // orders
            // 
            this.orders.AutoSize = true;
            this.orders.Location = new System.Drawing.Point(75, 44);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(65, 22);
            this.orders.TabIndex = 1;
            this.orders.Text = "10000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 85);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Revenue";
            // 
            // ttrevenue
            // 
            this.ttrevenue.AutoSize = true;
            this.ttrevenue.Location = new System.Drawing.Point(75, 44);
            this.ttrevenue.Name = "ttrevenue";
            this.ttrevenue.Size = new System.Drawing.Size(65, 22);
            this.ttrevenue.TabIndex = 1;
            this.ttrevenue.Text = "10000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ttrevenue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(289, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 85);
            this.panel2.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Profit";
            // 
            // ttprofit
            // 
            this.ttprofit.AutoSize = true;
            this.ttprofit.Location = new System.Drawing.Point(75, 44);
            this.ttprofit.Name = "ttprofit";
            this.ttprofit.Size = new System.Drawing.Size(65, 22);
            this.ttprofit.TabIndex = 1;
            this.ttprofit.Text = "10000";
            // 
            // btn_lo
            // 
            this.btn_lo.BackColor = System.Drawing.Color.White;
            this.btn_lo.Controls.Add(this.ttprofit);
            this.btn_lo.Controls.Add(this.label12);
            this.btn_lo.Location = new System.Drawing.Point(695, 81);
            this.btn_lo.Name = "btn_lo";
            this.btn_lo.Size = new System.Drawing.Size(563, 85);
            this.btn_lo.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 172);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(802, 272);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(818, 172);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(440, 480);
            this.chart2.TabIndex = 7;
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            this.chart2.Titles.Add(title2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Counters";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Number of Customers";
            // 
            // nb_customers
            // 
            this.nb_customers.AutoSize = true;
            this.nb_customers.Location = new System.Drawing.Point(14, 49);
            this.nb_customers.Name = "nb_customers";
            this.nb_customers.Size = new System.Drawing.Size(65, 22);
            this.nb_customers.TabIndex = 2;
            this.nb_customers.Text = "10000";
            // 
            // nb_suppliers
            // 
            this.nb_suppliers.AutoSize = true;
            this.nb_suppliers.Location = new System.Drawing.Point(14, 105);
            this.nb_suppliers.Name = "nb_suppliers";
            this.nb_suppliers.Size = new System.Drawing.Size(65, 22);
            this.nb_suppliers.TabIndex = 5;
            this.nb_suppliers.Text = "10000";
            // 
            // nb_products
            // 
            this.nb_products.AutoSize = true;
            this.nb_products.Location = new System.Drawing.Point(14, 163);
            this.nb_products.Name = "nb_products";
            this.nb_products.Size = new System.Drawing.Size(65, 22);
            this.nb_products.TabIndex = 6;
            this.nb_products.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Suppliers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of Products";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.nb_products);
            this.panel4.Controls.Add(this.nb_suppliers);
            this.panel4.Controls.Add(this.nb_customers);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(6, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 207);
            this.panel4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Products Understock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 177);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(229, 448);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(583, 207);
            this.panel5.TabIndex = 8;
            // 
            // FormMN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 664);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_lo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_td);
            this.Controls.Add(this.btn_ct);
            this.Controls.Add(this.btn_l7d);
            this.Controls.Add(this.btn_l3d);
            this.Controls.Add(this.btn_thismonth);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMN_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMN_MouseDown);
            this.Resize += new System.EventHandler(this.FormMN_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.btn_lo.ResumeLayout(false);
            this.btn_lo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.Button btn_thismonth;
        private System.Windows.Forms.Button btn_l3d;
        private System.Windows.Forms.Button btn_l7d;
        private System.Windows.Forms.Button btn_ct;
        private System.Windows.Forms.Button btn_td;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ttrevenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ttprofit;
        private System.Windows.Forms.Panel btn_lo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label nb_customers;
        private System.Windows.Forms.Label nb_suppliers;
        private System.Windows.Forms.Label nb_products;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
    }
}