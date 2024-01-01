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
using COMExcel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Controls;

namespace BTLLTTQ.NhapVaBan
{
    public partial class FormNhap : Form
    {
        Sql db = new Sql();
        DataRow lastRow;
        public FormNhap()
        {
            InitializeComponent();
            DataTable dt = db.DocBang("Select * from hoadonnhap");
            lastRow = dt.Rows[dt.Rows.Count - 1];
            dataGridView1.DataSource = dt;
            dt.Dispose();//Giải phóng bộ nhớ cho DataTable
            db.ThemVaoComboBox("select * from nhanvien", cbbMaNV);
            db.ThemVaoComboBox("select mancc from nhacungcap", cBBmaNCC);
            
        }

        private bool getlastrow()
        {
            DataTable dt = db.DocBang("Select * from hoadonnhap");
            if (dt.Rows.Count > 0)
            {
                lastRow = dt.Rows[dt.Rows.Count - 1];
                return true;
            }
            else return false;
        }

        private string sohdnmoi()
        {
            string ma = lastRow["sohdn"].ToString();
            //char[] separators = { 'N' };
            //string name = ma.Split(separators)[1];
            string[] separators = { "HDN" };
            string name = ma.Split(separators, StringSplitOptions.RemoveEmptyEntries)[0];
            int ma1 = int.Parse(name) + 1;
            return "HDN" + ma1.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHDN.Text == "" || cbbMaNV.Text =="" || cBBmaNCC.Text == "")
            {
                MessageBox.Show("Check lai DL");
                if (getlastrow()) txtHDN.Text = sohdnmoi();
                else txtHDN.Text = "HDN001";
            }
            else
            {
                if (!checkMa(txtHDN.Text))
                {
                    int tt = 0;
                    if (txtTongTien.Text != "") tt = int.Parse(txtTongTien.Text); 
                    db.CapNhatDuLieu("insert into hoadonnhap values (N'"+txtHDN.Text+"',N'"+cbbMaNV.Text+"',N'"+cBBmaNCC.Text+"','"+ dateNgayNhap.Value.Date.ToString("yyyyMMdd")+"',"+ tt + ")");
                    txtHDN.Text = txtTongTien.Text = "";
                    cbbMaNV.SelectedIndex = -1;
                    cBBmaNCC.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from hoadonnhap");
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Da co HDN voi soHDN nay, hay SD sua thay vi them");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkMa(txtHDN.Text))
            {
                DataTable dt1 = db.DocBang("Select * from chitiethdn where sohdn =N'" + txtHDN.Text + "'");
                if (dt1.Rows.Count > 0)
                {
                    MessageBox.Show("Hay xoa het chi tiet cua hoa don nay truoc");
                }
                else
                db.CapNhatDuLieu("delete from hoadonnhap where sohdn =N'" + txtHDN.Text + "'");
				txtHDN.Text = txtTongTien.Text = "";
                cbbMaNV.SelectedIndex = -1;
                cBBmaNCC.SelectedIndex = -1;
                DataTable dt = db.DocBang("Select * from hoadonnhap");
                dataGridView1.DataSource = dt;
            }
            else MessageBox.Show("Khong tim thay HD");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHDN.Text == "" || cbbMaNV.Text == "" || cBBmaNCC.Text == "")
            {
                MessageBox.Show("Check lai DL");
            }
            else
            {
                if (checkMa(txtHDN.Text))
                {
                    db.CapNhatDuLieu("update hoadonnhap set maNV=N'" + cbbMaNV.Text + "', mancc = N'" + cBBmaNCC.Text + "',ngaynhap ='" + dateNgayNhap.Value.Date.ToString("yyyyMMdd") + "',tongtien =" + int.Parse(txtTongTien.Text) + " where sohdn =N'" + txtHDN.Text + "'");
                    txtHDN.Text = txtTongTien.Text = "";
                    cbbMaNV.SelectedIndex = -1;
                    cBBmaNCC.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from hoadonnhap");
                    dataGridView1.DataSource = dt;
                }
                else MessageBox.Show("Chua co HDN voi soHDN nay, hay SD them thay vi sua");
            }
        }

        bool checkMa(string k)
        {
            DataTable dt = db.DocBang("Select * from hoadonnhap where sohdn =N'" + k + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtHDN.Enabled = false;
            txtHDN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbbMaNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cBBmaNCC.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateNgayNhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void FormNhap_Click(object sender, EventArgs e)
        {
            txtHDN.Text = txtTongTien.Text = "";
            cbbMaNV.SelectedIndex = -1;
            cBBmaNCC.SelectedIndex = -1;
            txtHDN.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHDN.Text == "") MessageBox.Show("Nhap hoac chon ma HDN");
            else
            {
                if (checkMa(txtHDN.Text))
                {
                    FormChiTIetHDN chiTIetHDN = new FormChiTIetHDN(txtHDN.Text);
                    chiTIetHDN.ShowDialog();
                }
                else MessageBox.Show("Khong co HDN voi maHDN nay");
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(checkMa(txtHDN.Text))
            {
                DataTable dt = db.DocBang("Select * from hoadonnhap where sohdn =N'" + txtHDN.Text + "'");
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Khong tim thay HDN nay");
            }
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            DataTable dt = db.DocBang("Select * from hoadonnhap");
            dataGridView1.DataSource = dt;
        }

		private void button2_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        private void btnExcel_Click(object sender, EventArgs e)
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
                exRange.Range["C2:E2"].Font.Size = 16;
                exRange.Range["C2:E2"].Font.Bold = true;
                exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["C2:E2"].MergeCells = true;
                exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:E2"].Value = "Đơn Nhập Hàng";
                // Biểu diễn thông tin chung của hóa đơn bán
                sql = "SELECT a.SoHDN, a.Ngaynhap, a.TongTien, b.tenncc, b.DiaChi, b.DienThoai, c.TenNV FROM hoadonnhap AS a, nhacungcap AS b, NhanVien AS c where a.mancc = b.mancc AND a.MaNV = c.MaNV";
                tblThongtinHD = db.DocBang(sql);
                exRange.Range["C12:H12"].ColumnWidth = 15;
                exRange.Range["F12:F12"].ColumnWidth = 25;
                exRange.Range["G12:G12"].ColumnWidth = 25;
                exRange.Range["A12:A12"].Value = "STT";
                exRange.Range["B12:B12"].Value = "Mã HĐN";  
                exRange.Range["C12:C12"].Value = "Ngày nhập";  
                exRange.Range["D12:D12"].Value = "Tổng tiền";
                exRange.Range["E12:E12"].Value = "Tên nhà cung cấp";
                exRange.Range["F12:F12"].Value = "Địa chỉ NCC";
                exRange.Range["G12:G12"].Value = "Số điện thoại";
                exRange.Range["H12:H12"].Value = "Mã nhân viên";
                exRange.Range["D13:D" + (tblThongtinHD.Rows.Count + 12)].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
                exRange.Range["G13:G" + (tblThongtinHD.Rows.Count + 12)].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
             for (hang = 0; hang < tblThongtinHD.Rows.Count; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[1][hang + 13] = hang + 1;
                    for (cot = 0; cot < tblThongtinHD.Columns.Count; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    {
                        exSheet.Cells[cot + 2][hang + 13] = tblThongtinHD.Rows[hang][cot].ToString();
                        
                }

                }
                exApp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ten nv la " + cbbMaNV.Text.ToString() + " ma nv la "+ cbbMaNV.SelectedValue.ToString() + "HD tiep theo la " + sohdnmoi());
        }
    }
}
