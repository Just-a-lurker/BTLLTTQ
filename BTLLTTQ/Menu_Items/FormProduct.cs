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
		private BindingList<Product> productList = new BindingList<Product>();

		public FormProduct()
        {
            InitializeComponent();
			dataGridView.DataSource = productList;
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Tạo một sản phẩm mới từ thông tin nhập vào
			Product newProduct = new Product() { MaSP = txtMaSP.Text, TenSP = txtTenSP.Text };

			// Kiểm tra xem mã sản phẩm đã tồn tại chưa
			if (!productList.Any(p => p.MaSP == newProduct.MaSP))
			{
				productList.Add(newProduct);
			}
			else
			{
				MessageBox.Show("Mã sản phẩm đã tồn tại.");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (dataGridView.CurrentRow != null)
			{
				// Lấy sản phẩm hiện tại được chọn trong DataGridView
				Product currentProduct = dataGridView.CurrentRow.DataBoundItem as Product;
				if (currentProduct != null)
				{
					// Cập nhật thông tin từ các textbox
					currentProduct.MaSP = txtMaSP.Text;
					currentProduct.TenSP = txtTenSP.Text;

					// Cập nhật DataGridView
					dataGridView.Refresh();
				}
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (dataGridView.CurrentRow != null)
			{
				// Xóa sản phẩm được chọn khỏi danh sách
				Product currentProduct = dataGridView.CurrentRow.DataBoundItem as Product;
				productList.Remove(currentProduct);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			// Đóng form
			this.Close();
		}
	}

	public class Product
	{
		public string MaSP { get; set; }
		public string TenSP { get; set; }
	}
}
