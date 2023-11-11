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
		bool cv,sp;
		int a = -1;
		public FormCaLamCongViec(bool a)
		{
			InitializeComponent();
			sp = a;
			if(a)
			{
				btnCaLam.Visible = false;
				btnCongViec.Visible = false;
			}
			else
			{
				btnTheLoai.Visible = false;
				btnChatLieu.Visible = false;
				btnKieuDang.Visible = false;
				btnNuocsx.Visible = false;
				btnMauSac.Visible = false;
			}
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
			if (checkMa(txtMa.Text)) { MessageBox.Show("Ma da ton tai"); return; }
			if (!sp)
			{
			if (cv)
			{
				db.CapNhatDuLieu("insert into congviec values ("+"N'" + txtMa.Text + "',N'" + txtTen.Text+ "')");
				DataTable dt = db.DocBang("Select * from congviec");
				dgvCLCV.DataSource = dt;
			}
			else if (!cv)
			{
				db.CapNhatDuLieu("insert into calam values (" + "N'" + txtMa.Text + "',N'" + txtTen.Text + "')");
				DataTable dt = db.DocBang("Select * from calam");
				dgvCLCV.DataSource = dt;
			}
			}
			else if (sp)
			{
				if (a == 1)
				{
					db.CapNhatDuLieu("insert into theloai values (" + "N'" + txtMa.Text + "',N'" + txtTen.Text + "')");
					DataTable dt = db.DocBang("Select * from theloai");
					dgvCLCV.DataSource = dt;
				}
				if (a == 2)
				{
					db.CapNhatDuLieu("insert into kieudang values (" + "N'" + txtMa.Text + "',N'" + txtTen.Text + "')");
					DataTable dt = db.DocBang("Select * from kieudang");
					dgvCLCV.DataSource = dt;
				}
				if (a == 3)
				{
					db.CapNhatDuLieu("insert into mausac values (" + "N'" + txtMa.Text + "',N'" + txtTen.Text + "')");
					DataTable dt = db.DocBang("Select * from mausac");
					dgvCLCV.DataSource = dt;
				}
				if (a == 4)
				{
					db.CapNhatDuLieu("insert into chatlieu values (" + "N'" + txtMa.Text + "',N'" + txtTen.Text + "')");
					DataTable dt = db.DocBang("Select * from chatlieu");
					dgvCLCV.DataSource = dt;
				}
				if (a == 5)
				{
					db.CapNhatDuLieu("insert into nuocsx values (" + "N'" + txtMa.Text + "',N'" + txtTen.Text + "')");
					DataTable dt = db.DocBang("Select * from nuocsx");
					dgvCLCV.DataSource = dt;
				}
			}
		}

		bool checkMa(string k)
		{
			if (!sp)
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
			else
			{
				if (a==1)
				{
					DataTable dt = db.DocBang("Select * from theloai where maloai =N'" + k + "'");
					if (dt.Rows.Count > 0)
					{
						return true;
					}
					return false;
				}
				else if (a == 2)
				{
					DataTable dt = db.DocBang("Select * from kieudang where makieu =N'" + k + "'");
					if (dt.Rows.Count > 0)
					{
						return true;
					}
					return false;
				}
				else if (a == 3)
				{
					DataTable dt = db.DocBang("Select * from mausac where mamau =N'" + k + "'");
					if (dt.Rows.Count > 0)
					{
						return true;
					}
					return false;
				}
				else if (a == 4)
				{
					DataTable dt = db.DocBang("Select * from chatlieu where machatlieu =N'" + k + "'");
					if (dt.Rows.Count > 0)
					{
						return true;
					}
					return false;
				}
				else if (a == 5)
				{
					DataTable dt = db.DocBang("Select * from nuocsx where manuocsx =N'" + k + "'");
					if (dt.Rows.Count > 0)
					{
						return true;
					}
					return false;
				}
			}
			return false;
			
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
			if (!checkMa(txtMa.Text)) { MessageBox.Show("Ma chua ton tai"); return; }
			if (!sp)
			{
				if (cv)
				{
				db.CapNhatDuLieu("update congviec set tencv=N'" + txtTen.Text +"' where macv =N'" + txtMa.Text + "'");
				DataTable dt = db.DocBang("Select * from congviec");
				dgvCLCV.DataSource = dt;
				}
				else if (!cv)
				{
				db.CapNhatDuLieu("update calam set tenca=N'" + txtTen.Text + "' where maca =N'" + txtMa.Text + "'");
				DataTable dt = db.DocBang("Select * from calam");
				dgvCLCV.DataSource = dt;
				}
			}
			else if (sp)
			{
				if (a == 1)
				{
					db.CapNhatDuLieu("update theloai set tenloai=N'" + txtTen.Text + "' where maloai =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from theloai");
					dgvCLCV.DataSource = dt;
				}
				if (a == 2)
				{
					db.CapNhatDuLieu("update kieudang set tenkieu=N'" + txtTen.Text + "' where makieu =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from kieudang");
					dgvCLCV.DataSource = dt;
				}
				if (a == 3)
				{
					db.CapNhatDuLieu("update mausac set tenmau=N'" + txtTen.Text + "' where mamau =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from mausac");
					dgvCLCV.DataSource = dt;
				}
				if (a == 4)
				{
					db.CapNhatDuLieu("update chatlieu set tenchatlieu=N'" + txtTen.Text + "' where machatlieu =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from chatlieu");
					dgvCLCV.DataSource = dt;
				}
				if (a == 5)
				{
					db.CapNhatDuLieu("update nuocsx set tennuocsx=N'" + txtTen.Text + "' where manuocsx =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from nuocsx");
					dgvCLCV.DataSource = dt;
				}
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if(!checkMa(txtMa.Text)) {MessageBox.Show("Ma chua ton tai"); return; }
			if (!sp)
			{
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
			else
			{
				if (a == 1)
				{
					db.CapNhatDuLieu("delete from theloai where maloai =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from theloai");
					dgvCLCV.DataSource = dt;
				}
				if (a == 2)
				{
					db.CapNhatDuLieu("delete from kieudang where makieu =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from kieudang");
					dgvCLCV.DataSource = dt;
				}
				if (a == 3)
				{
					db.CapNhatDuLieu("delete from mausac where mamau =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from mausac");
					dgvCLCV.DataSource = dt;
				}
				if (a == 4)
				{
					db.CapNhatDuLieu("delete from chatlieu where machatlieu =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from chatlieu");
					dgvCLCV.DataSource = dt;
				}
				if (a == 5)
				{
					db.CapNhatDuLieu("delete from nuocsx where manuocsx =N'" + txtMa.Text + "'");
					DataTable dt = db.DocBang("Select * from nuocsx");
					dgvCLCV.DataSource = dt;
				}
			}

		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (!checkMa(txtMa.Text)) { MessageBox.Show("Ma chua ton tai"); return; }
			if (!sp)
			{
				if (cv)
				{
					DataTable dt = db.DocBang("Select * from congviec where macv =N'" + txtMa.Text + "'");
					dgvCLCV.DataSource = dt;
				}
				else if (!cv)
				{
					DataTable dt = db.DocBang("Select * from calam where maca =N'" + txtMa.Text + "'");
					dgvCLCV.DataSource = dt;
				}
			}
			else if (sp)
			{
				if (a == 1)
				{
					DataTable dt = db.DocBang("Select * from theloai where maloai =N'" + txtMa.Text + "'");
					dgvCLCV.DataSource = dt;
				}
				if (a == 2)
				{
					DataTable dt = db.DocBang("Select * from kieudang where makieu =N'" + txtMa.Text + "'");
					dgvCLCV.DataSource = dt;
				}
				if (a == 3)
				{
					DataTable dt = db.DocBang("Select * from mausac where mamau =N'" + txtMa.Text + "'");
					dgvCLCV.DataSource = dt;
				}
				if (a == 4)
				{
					DataTable dt = db.DocBang("Select * from chatlieu where machatlieu =N'" + txtMa.Text + "'");
					dgvCLCV.DataSource = dt;
				}
				if (a == 5)
				{
					DataTable dt = db.DocBang("Select * from nuocsx where manuocsx =N'" + txtMa.Text + "'");
					dgvCLCV.DataSource = dt;
				}
			}
		}

		private void btnTheLoai_Click(object sender, EventArgs e)
		{
			DataTable dt = db.DocBang("Select * from theloai");
			dgvCLCV.DataSource = dt;
			dt.Dispose();
			a = 1;
		}

		private void btnKieuDang_Click(object sender, EventArgs e)
		{
			DataTable dt = db.DocBang("Select * from kieudang");
			dgvCLCV.DataSource = dt;
			dt.Dispose();
			a = 2;
		}

		private void btnMauSac_Click(object sender, EventArgs e)
		{
			DataTable dt = db.DocBang("Select * from mausac");
			dgvCLCV.DataSource = dt;
			dt.Dispose();
			a = 3;
		}

		private void btnChatLieu_Click(object sender, EventArgs e)
		{
			DataTable dt = db.DocBang("Select * from chatlieu");
			dgvCLCV.DataSource = dt;
			dt.Dispose();
			a = 4;
		}

		private void btnNuocsx_Click(object sender, EventArgs e)
		{
			DataTable dt = db.DocBang("Select * from nuocsx");
			dgvCLCV.DataSource = dt;
			dt.Dispose();
			a = 5;
		}

		private void FormCaLamCongViec_Click(object sender, EventArgs e)
		{
			txtMa.Enabled = true;
		}
	}
}
