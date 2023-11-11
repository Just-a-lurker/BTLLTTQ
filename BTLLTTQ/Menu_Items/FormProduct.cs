using BTLLTTQ.Menu_Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ.Menu
{
    public partial class FormProduct : Form
    {
		Sql db = new Sql();

		public FormProduct()
        {
            InitializeComponent();
			DataTable dt = db.DocBang("Select * from dmnoithat");
			dataGridView1.DataSource = dt;
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		bool checkMa(string k)
		{
			DataTable dt = db.DocBang("Select * from dmnoithat where manoithat =N'" + k + "'");
			if (dt.Rows.Count > 0)
			{
				return true;
			}
			return false;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtMaSP.Text == "" || txtTenSP.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
			{
				MessageBox.Show("Check lai DL");
			}
			else
			{
				if (!checkMa(txtMaSP.Text))
				{
					db.CapNhatDuLieu("insert into dmnoithat values (" + txtMaSP.Text + ",N'" + txtTenSP.Text + "',N'" + comboBox1.Text + "','" + dateNgayNhap.Value.Date.ToString("yyyyMMdd") + "'," + int.Parse(txtTongTien.Text) + ")");
					txtHDN.Text = txtTongTien.Text = "";
					cbbMaNV.SelectedIndex = -1;
					cBBmaNCC.SelectedIndex = -1;
					DataTable dt = db.DocBang("Select * from dmnoithat");
					dataGridView1.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Da co HDN voi soHDN nay, hay SD sua thay vi them");
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			// Đóng form
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormCaLamCongViec formCaLamCongViec = new FormCaLamCongViec(true);
			formCaLamCongViec.ShowDialog();
		}

		private void FormProduct_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
