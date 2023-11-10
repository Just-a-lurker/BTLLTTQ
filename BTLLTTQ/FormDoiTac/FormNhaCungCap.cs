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
    public partial class FormNhaCungCap : Form
    {
        Sql db = new Sql();

        public FormNhaCungCap()
        {
            InitializeComponent();
		}

		private void FormSupplier_Load(object sender, EventArgs e)
		{
           
		}

		protected void showThongTinNCC()
		{
			DataTable dataTable = db.DocBang("Select * from NhaCungCap");
			dataGridViewNCC.DataSource = dataTable;
			dataGridViewNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
			dataGridViewNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
			dataGridViewNCC.Columns[2].HeaderText = "Địa chỉ";
			dataGridViewNCC.Columns[3].HeaderText = "Điện thoại";

			dataGridViewNCC.Columns[0].Width = 200;
			dataGridViewNCC.Columns[1].Width = 200;
			dataGridViewNCC.Columns[2].Width = 200;
			dataGridViewNCC.Columns[3].Width = 200;
		}

		protected bool checkTextEmpty()
		{
			if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDC.Text == "" || txtSDT.Text == "") return true;
			return false;
		}

		protected bool checkMa(string str)
		{
			string sql = "Select * from NhaCungCap where MaNCC = '" + str + "'";
			DataTable dataTable = db.DocBang(sql);
			if (dataTable.Rows.Count > 0) return true;
			return false;
		}

		protected bool checkSDT()
		{
			if (txtSDT.Text.Length > 11) return true;
			return false;
		}

		private void btnTao_Click(object sender, EventArgs e)
		{
			if (this.checkTextEmpty()) 
			{
				MessageBox.Show("Kiểm tra lại dữ liệu!", "Thông báo");
				return;
			}
			if (this.checkSDT())
			{
				MessageBox.Show("Số điện thoại chỉ tối 11 số!", "Thông báo");
				txtSDT.Text = "";
				return;
			}
			else if (!this.checkMa(txtMaNCC.Text))
			{
				string sql = "Insert into NhaCungCap values ('" + txtMaNCC.Text + "', N'" + txtTenNCC.Text
					+ "', N'" + txtDC.Text + "', '" + txtSDT.Text + "')";
				db.CapNhatDuLieu(sql);
				this.showThongTinNCC();
			}
			else
			{
				MessageBox.Show("Tồn tại mã nhà cung cấp!", "Thông báo");
				txtMaNCC.Text = "";
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (this.checkTextEmpty())
			{
				MessageBox.Show("Kiểm tra lại dữ liệu!", "Thông báo");
				return;
			}

			if (this.checkSDT())
			{
				MessageBox.Show("Số điện thoại chỉ tối 11 số!", "Thông báo");
				txtSDT.Text = "";
				return;
			}
			string sql = "Update NhaCungCap set TenNCC = N'" + txtTenNCC.Text + "', DiaChi = N'"
				+ txtDC.Text + "', DienThoai = '" + txtSDT.Text + "' where MaNCC = '" + txtMaNCC.Text + "'";
			db.CapNhatDuLieu(sql);
			this.showThongTinNCC();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string sql = "Delete from NhaCungCap where MaNCC = '" + txtMaNCC.Text + "'";
			db.CapNhatDuLieu(sql);
			this.showThongTinNCC();
		}

		private void btnTK_Click(object sender, EventArgs e)
		{
			if (txtMaNCC.Text == "") return;
			string sql = "Select * from NhaCungCap where MaNCC = '" + txtMaNCC.Text + "'";
			DataTable dataTable = db.DocBang(sql);
			if (dataTable.Rows.Count > 0) dataGridViewNCC.DataSource = dataTable;
			else
			{
				MessageBox.Show("Không tồn tại thông tin nhà cung cấp!", "Thông báo");
				txtMaNCC.Text = "";
			}
		}

		private void btnHienThi_Click(object sender, EventArgs e)
		{
			this.showThongTinNCC();
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtMaNCC.Enabled = txtTenNCC.Enabled = txtDC.Enabled = txtSDT.Enabled = true;
			txtMaNCC.Text = txtTenNCC.Text = txtDC.Text = txtSDT.Text = "";
		}

		private void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMaNCC.Text = dataGridViewNCC.CurrentRow.Cells[0].Value.ToString();
			txtTenNCC.Text = dataGridViewNCC.CurrentRow.Cells[1].Value.ToString();
			txtDC.Text = dataGridViewNCC.CurrentRow.Cells[2].Value.ToString();
			txtSDT.Text = dataGridViewNCC.CurrentRow.Cells[3].Value.ToString();
			txtMaNCC.Enabled = false;
		}
	}
}
