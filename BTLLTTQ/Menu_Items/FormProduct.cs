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
using COMExcel = Microsoft.Office.Interop.Excel;
namespace BTLLTTQ.Menu
{
    public partial class FormProduct : Form
    {
		Merdul functions=new Merdul();
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
			txtmota.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
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
					db.CapNhatDuLieu("insert into dmnoithat values (N'" + txtMaSP.Text + "',N'" + txtTenSP.Text + "',N'" + comboBox1.Text + "',N'" + comboBox2.Text + "',N'" + comboBox3.Text + "',N'"
						+ comboBox4.Text + "',N'" + comboBox5.Text + "'," + int.Parse(textBox1.Text) + "," + float.Parse(textBox2.Text) + "," + float.Parse(textBox3.Text) + ",N'" + textBox4.Text + "','" + dateBH.Text + "',N'"+ txtmota.Text + "')");
					txtMaSP.Text = txtTenSP.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = txtMaSP.Text = txtmota.Text = dateBH.Text = "";
					
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
				txtMaSP.Text = txtTenSP.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = txtMaSP.Text = txtmota.Text = dateBH.Text = "";
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
						+ "',thoigianbaohanh = '" + dateBH.Text + "',mota = N'" + txtmota.Text + "' where manoithat =N'" + txtMaSP.Text + "'");
					txtMaSP.Text = txtTenSP.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = txtMaSP.Text = txtmota.Text = dateBH.Text = "";
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
			if (!(txtMaSP.Text == "" || txtTenSP.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") && checkMaCT(txtMaSP.Text,comboBox1.Text, comboBox4.Text, comboBox5.Text, float.Parse(textBox2.Text)) )
			{
				DataTable dt = db.DocBang("Select * from dmnoithat where manoithat =N'" + txtMaSP.Text + "' and maloai  =N'" + comboBox1.Text + "' and machatlieu  =N'" + comboBox4.Text + "' and manuocsx =N'" + comboBox5.Text + "' and DonGiaNhap =" + float.Parse(textBox2.Text));
				dataGridView1.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Khong tim thay SP nay");
			}
		}

        private void FormProduct_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = txtTenSP.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = txtMaSP.Text = txtmota.Text = dateBH.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
			txtMaSP.Enabled = true;
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
			COMExcel.Application exApp = new COMExcel.Application();
			COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
			COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
			COMExcel.Range exRange;
			string sql;
			int hang = 0, cot = 0;
			System.Data.DataTable tblThongtinHD, tblThongtinHang;
			exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
			exSheet = exBook.Worksheets[1];
			// Định dạng chung
			exRange = exSheet.Cells[1, 1];
			exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
			exRange.Range["A1:B3"].Font.Size = 10;
			exRange.Range["A1:B3"].Font.Bold = true;
			exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
			exRange.Range["A1:A1"].ColumnWidth = 7;
			exRange.Range["B1:B1"].ColumnWidth = 15;
			exRange.Range["A1:B1"].MergeCells = true;
			exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
			exRange.Range["A1:B1"].Value = "Khoa CNTT.";
			exRange.Range["A2:B2"].MergeCells = true;
			exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
			exRange.Range["A2:B2"].Value = "GTVT - Hà Nội";
			exRange.Range["A3:B3"].MergeCells = true;
			exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
			exRange.Range["A3:B3"].Value = "Điện thoại: 0325122044";
			exRange.Range["E6:H6"].Font.Size = 16;
			exRange.Range["E6:H6"].Font.Bold = true;
			exRange.Range["E6:H6"].Font.ColorIndex = 3; //Màu đỏ
			exRange.Range["E6:H6"].MergeCells = true;
			exRange.Range["E6:H6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
			exRange.Range["E6:H6"].Value = "Báo Cáo Hàng Hóa";
            sql = "SELECT MaNoiThat,tenNoiThat,Maloai,Makieu,Mamau,Machatlieu,Manuocsx,SoLuong," +
				"DonGiaNhap,DonGiaBan,ThoiGianBaoHanh from DMNoiThat";
            tblThongtinHang = functions.GetDataToTable(sql);
			//Tạo dòng tiêu đề bảng
			exRange.Range["A12:F12"].Font.Bold = true;
			exRange.Range["A12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
			exRange.Range["C12:F12"].ColumnWidth = 15;
			exRange.Range["A12:A12"].Value = "STT";
			exRange.Range["B12:B12"].Value = "Mã Nội Thất";
			exRange.Range["C12:C12"].Value = "Tên Nội Thất";
			exRange.Range["D12:D12"].Value = "Mã Loại";
			exRange.Range["E12:E12"].Value = "Mã Kiểu";
			exRange.Range["F12:F12"].Value = "Mã Màu";
			exRange.Range["G12:G12"].Value = "Mã Chất Liệu";
			exRange.Range["H12:H12"].Value = "Mã Nước SX";
			exRange.Range["I12:I12"].Value = "Số Lượng";
			exRange.Range["J12:J12"].Value = "Đơn Giá Nhập";
			exRange.Range["K12:K12"].Value = "Đơn Giá Bán";
			exRange.Range["L12:L12"].Value = "Thời Gian Bảo Hành";
			for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
			{
				//Điền số thứ tự vào cột 1 từ dòng 12
				exSheet.Cells[1][hang + 13] = hang + 1;
				for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
				//Điền thông tin hàng từ cột thứ 2, dòng 12
				{
					exSheet.Cells[cot + 2][hang + 13] = tblThongtinHang.Rows[hang][cot].ToString();
					if (cot == 3) exSheet.Cells[cot + 2][hang + 13] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
				}
			}
			exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
			exRange.Range["A1:C1"].MergeCells = true;
			exRange.Range["A1:C1"].Font.Italic = true;
			exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
			DateTime d = Convert.ToDateTime(System.DateTime.Now);
			exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
			exRange.Range["A2:C2"].MergeCells = true;
			exRange.Range["A2:C2"].Font.Italic = true;
			exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
			exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
			exRange.Range["A6:C6"].MergeCells = true;
			exRange.Range["A6:C6"].Font.Italic = true;
			exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
			//exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][7];
			exSheet.Name = "Hàng Hóa";
			exApp.Visible = true;
		}
    }
}
