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
			db.ThemVaoComboBox("select maloai from theloai", comboBox1);
			db.ThemVaoComboBox("select makieu from kieudang", comboBox2);
			db.ThemVaoComboBox("select mamau from mausac", comboBox3);
			db.ThemVaoComboBox("select machatlieu from chatlieu", comboBox4);
			db.ThemVaoComboBox("select manuocsx from nuocsx", comboBox5);
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

		bool checkMaCT(string k,string k1 , string k2, string k3, float k4)
		{
			DataTable dt = db.DocBang("Select * from dmnoithat where manoithat =N'" + k + "' and maloai  =N'" + k1 + "' and machatlieu  =N'" + k2 + "' and manuocsx =N'" + k3 + "' and dongianhap =" + k4);
			if (dt.Rows.Count > 0)
			{
				return true;
			}
			return false;
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

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			txtMaSP.Enabled = false;
			txtMaSP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			txtTenSP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			comboBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			comboBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			comboBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			textBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			textBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
			textBox3.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
			dateBH.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			if (txtMaSP.Text == "" || txtTenSP.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
			{
				MessageBox.Show("Check lai DL");
			}
			else
			{
				if (!checkMa(txtMaSP.Text))
				{
					db.CapNhatDuLieu("insert into dmnoithat values (" + txtMaSP.Text + ",N'" + txtTenSP.Text + "',N'" + comboBox1.Text + "',N'" + comboBox2.Text + "',N'" + comboBox3.Text + "',N'"
						+ comboBox4.Text + "',N" + comboBox5.Text + "'," + int.Parse(textBox1.Text) + "," + float.Parse(textBox2.Text) + "," + float.Parse(textBox3.Text) + ",N'" + textBox4.Text + "','" + dateBH.Value.Date.ToString("yyyyMMdd") + "')");
					txtMaSP.Text = txtTenSP.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
					comboBox1.SelectedIndex = -1;
					comboBox2.SelectedIndex = -1;
					comboBox3.SelectedIndex = -1;
					comboBox4.SelectedIndex = -1;
					comboBox5.SelectedIndex = -1;
					DataTable dt = db.DocBang("Select * from dmnoithat");
					dataGridView1.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Da co san pham voi ma nay");
				}
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (checkMa(txtMaSP.Text))
			{
				db.CapNhatDuLieu("delete from chitiethddh where manoithat =N'" + txtMaSP.Text + "'");
				db.CapNhatDuLieu("delete from chitiethdn where manoithat =N'" + txtMaSP.Text + "'");
				db.CapNhatDuLieu("delete from dmnoithat where manoithat =N'" + txtMaSP.Text + "'");
				txtMaSP.Text = txtTenSP.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
				comboBox1.SelectedIndex = -1;
				comboBox2.SelectedIndex = -1;
				comboBox3.SelectedIndex = -1;
				comboBox4.SelectedIndex = -1;
				comboBox5.SelectedIndex = -1;
				DataTable dt = db.DocBang("Select * from dmnoithat");
				dataGridView1.DataSource = dt;
			}
			else MessageBox.Show("Khong xoa duoc vi khong tim thay ma sp nay");
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtMaSP.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "")
			{
				MessageBox.Show("Check lai DL");
			}
			else
			{
				if (checkMa(txtMaSP.Text))
				{
					db.CapNhatDuLieu("update dmnoithat set tennoithat =N'" + txtTenSP.Text + "',maloai = N'" + comboBox1.Text + "', makieu = N'" + comboBox2.Text 
						+ "', mamau = N'" + comboBox3.Text + "', machatlieu = N'"
						+ comboBox4.Text + "', manuocsx = N'" + comboBox5.Text + "', soluong = " + int.Parse(textBox1.Text) 
						+ ", dongianhap = " + float.Parse(textBox2.Text) + ", dongiaban = " + float.Parse(textBox3.Text) + ",anh = N'" + textBox4.Text 
						+ "',thoigianbaohanh = '" + dateBH.Value.Date.ToString("yyyyMMdd") + "' where manoithat =N'" + txtMaSP.Text + "'");
					txtMaSP.Text = txtTenSP.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
					comboBox1.SelectedIndex = -1;
					comboBox2.SelectedIndex = -1;
					comboBox3.SelectedIndex = -1;
					comboBox4.SelectedIndex = -1;
					comboBox5.SelectedIndex = -1;
					DataTable dt = db.DocBang("Select * from dmnoithat");
					dataGridView1.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Da co san pham voi ma nay");
				}
			}
		}

		private void btntim_Click(object sender, EventArgs e)
		{
			if (checkMaCT(txtMaSP.Text,comboBox1.Text, comboBox4.Text, comboBox5.Text, float.Parse(textBox2.Text)) )
			{
				DataTable dt = db.DocBang("Select * from dmnoithat where manoithat =N'" + txtMaSP.Text + "' and maloai  =N'" + comboBox1.Text + "' and machatlieu  =N'" + comboBox4.Text + "' and manuocsx =N'" + comboBox5.Text + "' and DonGiaNhap =" + float.Parse(textBox2.Text));
				dataGridView1.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Khong tim thay SP nay");
			}
		}
	}
}
