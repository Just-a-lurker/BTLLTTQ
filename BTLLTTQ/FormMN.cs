
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTLLTTQ
{
    public partial class FormMN : Form
    {
        private System.Windows.Forms.Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private int borderSize = 2;
        private Size formSize;
        private Dashboard dashboard;
        public FormMN()
        {
            InitializeComponent();
            start_date.Value=DateTime.Today.AddDays(-7);
            end_date.Value = DateTime.Now;
            btn_l7d.Select();
            dashboard = new Dashboard();
            LoadData();
            //CollapseMenu();
            //this.Padding = new Padding(borderSize);//Border size
         
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void DisableCustomDates()
        {
           start_date.Enabled = false;
            end_date.Enabled = false;
            btn_ct.Visible = false;
        }
        private void LoadData()
        {
            var refreshData = dashboard.LoadData(start_date.Value, end_date.Value);
            if (refreshData == true)
            {
                orders.Text = dashboard.NumOrders.ToString();
                ttrevenue.Text = "$" + dashboard.TotalRevenue.ToString();
                ttprofit.Text = "$" + dashboard.TotalProfit.ToString();
                nb_customers.Text = dashboard.NumCustomers.ToString();
                nb_suppliers.Text = dashboard.NumSuppliers.ToString();
                nb_products.Text = dashboard.NumProducts.ToString();
                chart1.DataSource = dashboard.GrossRevenueList;
                chart1.Series[0].XValueMember = "Date";
                chart1.Series[0].YValueMembers = "TotalAmount";
                chart1.DataBind();
                chart2.DataSource = dashboard.TopProductsList;
                chart2.Series[0].XValueMember = "Key";
                chart2.Series[0].YValueMembers = "Value";
                chart2.DataBind();
                dataGridView1.DataSource = dashboard.UnderstockList;
                dataGridView1.Columns[0].HeaderText = "Item";
                dataGridView1.Columns[1].HeaderText = "Units";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                  
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void btn_td_Click(object sender, EventArgs e)
        {
           start_date.Value = DateTime.Today;
            end_date.Value = DateTime.Now;
            LoadData();
            //DisableCustomDates();
        }

        private void btn_l7d_Click(object sender, EventArgs e)
        {
            start_date.Value = DateTime.Today.AddDays(-7);
            end_date.Value = DateTime.Now;
            LoadData();
            //DisableCustomDates();
        }

        private void btn_l3d_Click(object sender, EventArgs e)
        {
            start_date.Value = DateTime.Today.AddDays(-30);
            end_date.Value = DateTime.Now;
            LoadData();
            //DisableCustomDates();
        }

        private void btn_thismonth_Click(object sender, EventArgs e)
        {
            start_date.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            end_date.Value = DateTime.Now;
            LoadData();
            //DisableCustomDates();
        }

        private void btn_ct_Click(object sender, EventArgs e)
        {
            start_date.Enabled = true;
            start_date.Enabled = true;
            btn_ct.Visible = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //private void btn_nt_Click(object sender, EventArgs e)
        //{

        //}

        //private void btn_hd_Click(object sender, EventArgs e)
        //{

        //}

        //private void btn_dt_Click(object sender, EventArgs e)
        //{

        //}

        //private void btn_bc_Click(object sender, EventArgs e)
        //{

        //}

        //private void btn_nv_Click(object sender, EventArgs e)
        //{

        //}

        //private void btn_logout_Click(object sender, EventArgs e)
        //{

        //}

        private void FormMN_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormMN_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }else
            {
                this.WindowState= FormWindowState.Normal;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMN_Load(object sender, EventArgs e)
        {

        }
    }
}
