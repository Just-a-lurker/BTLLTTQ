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
    public partial class FormKhachHang : Form
    {
        Sql db = new Sql();

		public FormKhachHang()
        {
            InitializeComponent();
		}

		private void FormCustomer_Load(object sender, EventArgs e)
		{
			
		}

		protected void showThongTinKH()
		{
			DataTable dataTable = db.DocBang("Select * from KhachHang");
			dataGridViewKH.DataSource = dataTable;
		}

		private void btnTao_Click(object sender, EventArgs e)
        {
			if (this.checkTextEmpty())
			{
				MessageBox.Show("Kiểm tra lại dữ liệu!", "Thông báo");
			}
			else if (!this.checkMa(txtMaKH.Text))
			{
				string sql = "Insert into KhachHang values ('" + txtMaKH.Text + "', N'" + txtTenKH.Text
					+ "', N'" + txtDC.Text + "', '" + txtSDT.Text + "')";
				db.CapNhatDuLieu(sql);
				this.showThongTinKH();
			}
			else MessageBox.Show("Tồn tại mã khách hàng này!", "Thông báo");
        }

		private void dataGridViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMaKH.Text = dataGridViewKH.CurrentRow.Cells[0].Value.ToString();
			txtTenKH.Text = dataGridViewKH.CurrentRow.Cells[1].Value.ToString();
			txtDC.Text = dataGridViewKH.CurrentRow.Cells[2].Value.ToString();
			txtSDT.Text = dataGridViewKH.CurrentRow.Cells[3].Value.ToString();
			txtMaKH.Enabled = false;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if(this.checkTextEmpty())
			{
				MessageBox.Show("Kiểm tra lại dữ liệu!", "Thông báo");
			}
			string sql = "Update KhachHang set TenKhach = N'" + txtTenKH.Text + "', DiaChi = N'" 
				+ txtDC.Text + "', DienThoai = '" + txtSDT.Text + "' where MaKhach = '" + txtMaKH.Text + "'";
			db.CapNhatDuLieu(sql);
			this.showThongTinKH();	
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string sql = "Delete from KhachHang where MaKhach = '" + txtMaKH.Text + "'";
			db.CapNhatDuLieu(sql);
			this.showThongTinKH();
		}

		private void btnTK_Click(object sender, EventArgs e)
		{
			string sql = "Select * from KhachHang where MaKhach = '" + txtMaKH.Text + "'";
			DataTable dataTable = db.DocBang(sql);
			if (dataTable.Rows.Count > 0) dataGridViewKH.DataSource = dataTable;
			else MessageBox.Show("Không tồn tại thông tin khách hàng!", "Thông báo");
		}

		private void FormCustomer_Click(object sender, EventArgs e)
		{
			txtMaKH.Enabled = true;
			txtMaKH.Text = txtTenKH.Text = txtDC.Text = txtSDT.Text = "";
			this.showThongTinKH();
		}

		protected bool checkTextEmpty()
		{
			if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDC.Text == "" || txtSDT.Text == "") return true;
			return false;
		}

		protected bool checkMa(string str)
		{
			string sql = "Select * from KhachHang where MaKhach = '" + str + "'";
			DataTable dataTable = db.DocBang(sql);
			if (dataTable.Rows.Count > 0) return true;
			return false;
		}

		private void btnHienThi_Click(object sender, EventArgs e)
		{
			this.showThongTinKH();
			txtMaKH.Text = txtTenKH.Text = txtDC.Text = txtSDT.Text = "";
		}
	}
}
