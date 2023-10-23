using BTLLTTQ.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ.NhapVaBan
{
    public partial class FormNhap : Form
    {
        Sql db = new Sql();
        public FormNhap()
        {
            InitializeComponent();
            DataTable dt = db.DocBang("Select * from hoadonnhap");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã chất liệu";
            dataGridView1.Columns[1].HeaderText = "Tên chất liệu";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.BackgroundColor = Color.LightBlue;
            dt.Dispose();//Giải phóng bộ nhớ cho DataTable
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
