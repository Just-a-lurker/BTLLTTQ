using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ
{
    public partial class FormMN : Form
    {
        private Dashboard dashboard;
        public FormMN()
        {
            InitializeComponent();
            start_date.Value=DateTime.Today.AddDays(-7);
            end_date.Value = DateTime.Now;
            btn_l7d.Select();
            dashboard = new Dashboard();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData=dashboard.LoadData(start_date.Value,end_date.Value);
            if (refreshData == true)
            {
                orders.Text=dashboard.NumOrders.ToString();
                ttrevenue.Text=dashboard.TotalRevenue.ToString();
                ttprofit.Text=dashboard.TotalProfit.ToString();
                nb_customers.Text=dashboard.NumCustomers.ToString();
                nb_products.Text=dashboard.NumProducts.ToString();
                nb_suppliers.Text=dashboard.NumSuppliers.ToString();
                chart1.DataSource = dashboard.GrossRevenueList;
                chart1.Series[0].XValueMember= "Date";
                chart1.Series[0].YValueMembers = "Total Amount";
                chart1.DataBind();

                chart2.DataSource = dashboard.GrossRevenueList;
                chart2.Series[0].XValueMember = "Key";
                chart2.Series[0].YValueMembers = "Value ";
                chart2.DataBind();
                dataGridView1.DataSource = dashboard.UnderstockList;
                Console.WriteLine("Loaded view:)");

            }else
            {
                Console.WriteLine("View not loaded,same querry");
            }
        }
    }
}
