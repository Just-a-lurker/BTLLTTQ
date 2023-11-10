using BTLLTTQ.Menu_Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ.Menu
{
    public partial class FormPartner : Form
    {
        public FormPartner()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_KH_Click(object sender, EventArgs e)
        {
            FormKhachHang  formCus = new FormKhachHang();
            formCus.ShowDialog();
        }

        private void btn_NCC_Click(object sender, EventArgs e)
        {
            FormNhaCungCap formSup = new FormNhaCungCap();
            formSup.ShowDialog();
        }
    }
}
