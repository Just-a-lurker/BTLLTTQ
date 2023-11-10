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
			DataTable dataTable = db.DocBang("Select * from NhaCungCap");
			dataGridViewNCC.DataSource = dataTable;
		}

		private void FormSupplier_Load(object sender, EventArgs e)
		{
           
		}

		protected void showThongTinNCC()
		{
			DataTable dataTable = db.DocBang("Select * from NhaCungCap");
			dataGridViewNCC.DataSource = dataTable;
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

		private void btnTao_Click(object sender, EventArgs e)
		{
			if (this.checkTextEmpty())
			{
				MessageBox.Show("Kiểm tra lại dữ liệu!", "Thông báo");
			}
			else if (!this.checkMa(txtMaNCC.Text))
			{
				string sql = "Insert into NhaCungCap values ('" + txtMaNCC.Text + "', N'" + txtTenNCC.Text
					+ "', N'" + txtDC.Text + "', '" + txtSDT.Text + "')";
				db.CapNhatDuLieu(sql);
				this.showThongTinNCC();
			}
			else MessageBox.Show("Tồn tại mã nhà cung cấp!", "Thông báo");
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (this.checkTextEmpty())
			{
				MessageBox.Show("Kiểm tra lại dữ liệu!", "Thông báo");
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
			string sql = "Select * from NhaCungCap where MaNCC = '" + txtMaNCC.Text + "'";
			DataTable dataTable = db.DocBang(sql);
			if (dataTable.Rows.Count > 0) dataGridViewNCC.DataSource = dataTable;
			else MessageBox.Show("Không tồn tại thông tin nhà cung cấp!", "Thông báo");
		}

		private void btnHienThi_Click(object sender, EventArgs e)
		{
			this.showThongTinNCC();
			txtMaNCC.Text = txtTenNCC.Text = txtDC.Text = txtSDT.Text = "";
		}

		private void dataGridViewNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMaNCC.Text = dataGridViewNCC.CurrentRow.Cells[0].Value.ToString();
			txtTenNCC.Text = dataGridViewNCC.CurrentRow.Cells[1].Value.ToString();
			txtDC.Text = dataGridViewNCC.CurrentRow.Cells[2].Value.ToString();
			txtSDT.Text = dataGridViewNCC.CurrentRow.Cells[3].Value.ToString();
			txtMaNCC.Enabled = false;
		}

		private void FormNhaCungCap_Click(object sender, EventArgs e)
		{
			txtMaNCC.Enabled = true;
			txtMaNCC.Text = txtTenNCC.Text = txtDC.Text = txtSDT.Text = "";
		}
	}
}
