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

namespace BTLLTTQ.Menu_Items
{
	public partial class FormCaLamCongViec : Form
	{
		Sql db = new Sql();
		bool cv;
		public FormCaLamCongViec()
		{
			InitializeComponent();
		}

		private void btnCongViec_Click(object sender, EventArgs e)
		{
			DataTable dt = db.DocBang("Select * from congviec");
			dgvCLCV.DataSource = dt;
			dt.Dispose();
			cv = true;
		}

		private void btnCaLam_Click(object sender, EventArgs e)
		{
			DataTable dt = db.DocBang("Select * from calam");
			dgvCLCV.DataSource = dt;
			dt.Dispose();
			cv = false;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (cv && !checkMa(txtMa.Text))
			{
				db.CapNhatDuLieu("insert into congviec values ("+"N'" + txtMa.Text + "',N'" + txtTen.Text+ "')");
				DataTable dt = db.DocBang("Select * from congviec");
				dgvCLCV.DataSource = dt;
			}
			else if (!cv && !checkMa(txtMa.Text))
			{
				db.CapNhatDuLieu("insert into calam values (" + "N'" + txtMa.Text + "',N'" + txtTen.Text + "')");
				DataTable dt = db.DocBang("Select * from calam");
				dgvCLCV.DataSource = dt;
			}
			else MessageBox.Show("Ma da ton tai");
		}

		bool checkMa(string k)
		{
			if (cv)
			{
				DataTable dt = db.DocBang("Select * from congviec where macv =N'" + k + "'");
				if (dt.Rows.Count > 0)
				{
					return true;
				}
				return false;
			}
			else
			{
				DataTable dt = db.DocBang("Select * from calam where maca =N'" + k + "'");
				if (dt.Rows.Count > 0)
				{
					return true;
				}
				return false;
			}
			
		}

		private void dgvCLCV_Click(object sender, EventArgs e)
		{
			txtMa.Enabled = false;
			txtMa.Text = dgvCLCV.CurrentRow.Cells[0].Value.ToString();
			txtTen.Text = dgvCLCV.CurrentRow.Cells[1].Value.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Sua
			if (cv && checkMa(txtMa.Text))
			{
				db.CapNhatDuLieu("update congviec set tencv=N'" + txtTen.Text +"' where macv =N'" + txtMa.Text + "'");
				DataTable dt = db.DocBang("Select * from congviec");
				dgvCLCV.DataSource = dt;
			}
			else if (!cv && checkMa(txtMa.Text))
			{
				db.CapNhatDuLieu("update calam set tenca=N'" + txtTen.Text + "' where maca =N'" + txtMa.Text + "'");
				DataTable dt = db.DocBang("Select * from calam");
				dgvCLCV.DataSource = dt;
			}
			else MessageBox.Show("Ma chua ton tai");
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if(!checkMa(txtMa.Text)) {MessageBox.Show("Ma chua ton tai"); return; }
			if (cv)
			{
				db.CapNhatDuLieu("delete from congviec where macv =N'" + txtMa.Text + "'");
				DataTable dt = db.DocBang("Select * from congviec");
				dgvCLCV.DataSource = dt;
			}
			else if (!cv)
			{
				db.CapNhatDuLieu("delete from calam where maca =N'" + txtMa.Text + "'");
				DataTable dt = db.DocBang("Select * from calam");
				dgvCLCV.DataSource = dt;
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (cv && checkMa(txtMa.Text))
			{
				DataTable dt = db.DocBang("Select * from congviec where macv =N'" + txtMa.Text + "'");
				dgvCLCV.DataSource = dt;
			}
			else if (!cv && checkMa(txtMa.Text))
			{
				DataTable dt = db.DocBang("Select * from calam where maca =N'" + txtMa.Text + "'");
				dgvCLCV.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Khong tim thay HDN nay");
			}
		}

		private void FormCaLamCongViec_Click(object sender, EventArgs e)
		{
			txtMa.Enabled = true;
		}
	}
}
