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
using static System.Net.Mime.MediaTypeNames;

namespace BTLLTTQ.NhapVaBan
{
    public partial class FormChiTIetHDN : Form
    {
        Merdul md = new Merdul();
        Sql db = new Sql();
        string maHDN;
        int SLsua = 0, TTS = 0, DG = 0;
        public FormChiTIetHDN(string soHDN)
        {
            InitializeComponent();
            maHDN = soHDN;
            DataTable dt = db.DocBang("Select * from ChiTietHDN where SoHDN = N'" + soHDN +"'");
            txtSoHDN.Text = maHDN;
            dataGridView1.DataSource = dt;
            db.ThemVaoComboBox("select manoithat from dmnoithat", cbbMaNT);
            dt.Dispose();//Giải phóng bộ nhớ cho DataTable
            txtThanhTien.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool checkMa(string k)
        {
            DataTable dt = db.DocBang("Select * from ChiTietHDN where manoithat =N'" + k + "' and sohdn = N'" + txtSoHDN.Text +"'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cbbMaNT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGiamGia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtThanhTien.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            SLsua = int.Parse(txtSL.Text);
            TTS = int.Parse(txtThanhTien.Text);
            DG = int.Parse(txtDonGia.Text);
        }
        private void updateSL(int a)
        {
            int sl = int.Parse(md.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + cbbMaNT.Text + "'"));
            int slm = a + sl;
            if (slm > 0) { db.CapNhatDuLieu("UPDATE DMNoiThat SET SoLuong =" + slm + " WHERE MaNoiThat= N'" + cbbMaNT.Text + "'"); }
            else MessageBox.Show("SL khong hop le");
        }

        private void updateTT(int a)
        {

            int tt = int.Parse(md.GetFieldValues("SELECT tongtien FROM hoadonnhap WHERE sohdn = N'" + txtSoHDN.Text + "'"));
            tt += a;
            if (tt > 0) { db.CapNhatDuLieu("update hoadonnhap set tongtien = " + tt + " where sohdn =N'" + txtSoHDN.Text + "'"); }
            else MessageBox.Show("Tong tien khong hop le");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Check lai DL");
            }
            else
            {
                if (!checkMa(cbbMaNT.Text))
                {
                   updateTT(int.Parse(txtThanhTien.Text));
                   updateSL(int.Parse(txtSL.Text));
                     db.CapNhatDuLieu("insert into ChiTietHDN values (N'"
                        + cbbMaNT.Text + "',N'"
                        + txtSoHDN.Text + "'," 
                        + int.Parse(txtSL.Text) + "," 
                        + int.Parse(txtDonGia.Text) + "," 
                        + int.Parse(txtGiamGia.Text) + ","
                        + int.Parse(txtThanhTien.Text) + ")");
                    double temp = Math.Ceiling(int.Parse(txtDonGia.Text) * 1.1);
                    db.CapNhatDuLieu("UPDATE DMNoiThat SET dongianhap =" + int.Parse(txtDonGia.Text) + ", dongiaban = "+int.Parse(temp.ToString())+" WHERE MaNoiThat= N'" + cbbMaNT.Text + "'");
                    txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
                    cbbMaNT.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from ChiTietHDN where sohdn = N'" + txtSoHDN.Text +"'");
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Da ton tai ma noi that nay, dung sua de sua chi tiet HDN nay");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkMa(cbbMaNT.Text)) { MessageBox.Show("Chon CTHD de xoa");
                return; }
            updateSL(-int.Parse(txtSL.Text));
            updateTT(-int.Parse(txtThanhTien.Text));
            db.CapNhatDuLieu("delete from ChiTietHDN where manoithat =N'" + cbbMaNT.Text + "' and sohdn = N'" + txtSoHDN.Text + "'");
            txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
            cbbMaNT.SelectedIndex = -1;
            DataTable dt = db.DocBang("Select * from ChiTietHDN where sohdn = N'" + txtSoHDN.Text +"'");
            dataGridView1.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Check lai DL");
            }
            else
            {
                if (checkMa(cbbMaNT.Text))
                {
                    if (SLsua != int.Parse(txtSL.Text))
                    {
                        int temp = int.Parse(txtSL.Text)- SLsua;
                        updateSL(temp);
                    }
                    if (TTS != int.Parse(txtThanhTien.Text))
                    {
                        int temp = int.Parse(txtThanhTien.Text) - TTS;
                        updateTT(temp);
                    }
                    double temp2 = Math.Ceiling(int.Parse(txtDonGia.Text) * 1.1);
                    if (DG != int.Parse(txtDonGia.Text)) db.CapNhatDuLieu("UPDATE DMNoiThat SET dongianhap =" + int.Parse(txtDonGia.Text) + ", dongiaban = " + int.Parse(temp2.ToString()) + " WHERE MaNoiThat= N'" + cbbMaNT.Text + "'");
                    db.CapNhatDuLieu("update ChiTietHDN set soluong=" + int.Parse(txtSL.Text)
                        + ", dongia = " + int.Parse(txtDonGia.Text) + ",giamgia =" 
                        + int.Parse(txtGiamGia.Text) + ",thanhtien =" 
                        + int.Parse(txtThanhTien.Text) + " where manoithat =N'" 
                        + cbbMaNT.Text + "'");
                    txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
                    cbbMaNT.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from ChiTietHDN where sohdn = N'" + txtSoHDN.Text +"'");
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Khong ton tai ma noi that nay, dung insert de them");
                }

            }
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            DataTable dt = db.DocBang("Select * from ChiTietHDN where sohdn = N'" + maHDN + "'");
            dataGridView1.DataSource = dt;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (checkMa(cbbMaNT.Text))
            {
                DataTable dt = db.DocBang("Select * from ChiTietHDN where manoithat =N'" + cbbMaNT.Text + "', and sohdn = N'" + maHDN + "'");
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Khong tim thay chi tiet HDN nay");
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "")
            {}
            else
            {
            float giamgia = float.Parse(txtGiamGia.Text)/100 * (int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text));
            txtThanhTien.Text = Math.Ceiling((int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text) - giamgia)).ToString();
            }

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
            exRange.Range["C2:E2"].Value = "Chi Tiết Đơn Nhập Hàng";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.SoHDN, a.Ngaynhap, a.TongTien, b.tenncc, b.DiaChi, b.DienThoai, c.TenNV FROM hoadonnhap AS a, nhacungcap AS b, NhanVien AS c WHERE a.sohdn = N'" + txtSoHDN.Text + "' and a.mancc = b.mancc AND a.MaNV = c.MaNV";
            tblThongtinHD = db.DocBang(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            exRange.Range["B10:B10"].Value = "Ngày Nhập:";
            exRange.Range["C10:E10"].MergeCells = true;
            exRange.Range["C10:E10"].Value = tblThongtinHD.Rows[0][1].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenNoiThat, a.SoLuong, a.dongia, a.GiamGia, a.ThanhTien " +
                  "FROM chitiethdn AS a , DMNoiThat AS b WHERE a.sohdn = N'" +
                  txtSoHDN.Text + "' AND a.MaNoiThat = b.MaNoiThat";
            tblThongtinHang = db.DocBang(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A12:F12"].Font.Bold = true;
            exRange.Range["A12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C9:E9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["C10:E10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["C12:F12"].ColumnWidth = 12;
            exRange.Range["A12:A12"].Value = "STT";
            exRange.Range["B12:B12"].Value = "Tên Nội Thất";
            exRange.Range["C12:C12"].Value = "Số lượng";
            exRange.Range["D12:D12"].Value = "Đơn giá nhập";
            exRange.Range["E12:E12"].Value = "Giảm giá";
            exRange.Range["F12:F12"].Value = "Thành tiền";
            int tt = 0;
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 13] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    if (cot == 4) tt += int.Parse(tblThongtinHang.Rows[hang][cot].ToString());
                    exSheet.Cells[cot + 2][hang + 13] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 13] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tt;
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            //exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
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
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Đơn nhập hàng";
            exApp.Visible = true;
        }

        private void FormChiTIetHDN_Load(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "")
            { }
            else
            {
                float giamgia = float.Parse(txtGiamGia.Text)/100 * (int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text));
                txtThanhTien.Text = Math.Ceiling((int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text) - giamgia)).ToString();
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "")
            { }
            else
            {
                float giamgia = float.Parse(txtGiamGia.Text)/100 * (int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text));
                txtThanhTien.Text =Math.Ceiling((int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text) - giamgia)).ToString();
            }
        }
    }
}
