using BTLLTTQ.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace BTLLTTQ.Menu_Items
{
    public partial class Formbcdsspchokhachhang : Form
    {

        Sql db = new Sql();
        Merdul functions = new Merdul();
        private Word.Application oApp;
        private Word.Document oDoc;

        private object oEndOfDoc = "\\endofdoc"; // Đối tượng đánh dấu kết thúc văn bản
        private object oMissing = System.Reflection.Missing.Value;
        public Formbcdsspchokhachhang()
        {
            InitializeComponent();
           /*DataTable dt = db.DocBang("Select * from hoadonnhap");
            bangdondathang.DataSource = dt;
            dt.Dispose();*/
            db.ThemVaoComboBox("select tenKhach from KhachHang", cmbokh);
            db.ThemVaoComboBox("SELECT DISTINCT FORMAT(NgayGiao, 'MM/yyyy') AS ThangNam FROM DonDatHang", cmbothang);
        }

        private void Formbcdsspchokhachhang_Load(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string selectedCustomer = cmbokh.SelectedItem.ToString();
            string selectedMonthYear = cmbothang.SelectedItem.ToString();

            int selectedMonth = int.Parse(selectedMonthYear.Split('/')[0]);
            int selectedYear = int.Parse(selectedMonthYear.Split('/')[1]);

            string query = $@" SELECT DDH.SoDDH, DDH.MaKhach, NT.tenNoiThat,NT.MaNoiThat, DDH.NgayDat,DDH.NgayGiao, DDH.TongTien FROM DonDatHang AS DDH
                INNER JOIN KhachHang AS K ON DDH.MaKhach = K.MaKhach
                INNER JOIN ChiTietHDDH AS CTHD ON DDH.SoDDH = CTHD.SoDDH
                INNER JOIN DMNoiThat AS NT ON CTHD.MaNoithat = NT.MaNoiThat
                WHERE K.tenKhach = '{selectedCustomer}' AND MONTH(DDH.NgayGiao) = {selectedMonth} AND YEAR(DDH.NgayGiao) = {selectedYear}";
            try
            {
                DataTable dt = db.DocBang(query);
                bangdondathang.AutoGenerateColumns = true;
                bangdondathang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bangdondathang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxuat_Click(object sender, EventArgs e)
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
            exRange.Range["C2:E2"].Value = "Danh sách sản phẩm bán được";
            // Biểu diễn thông tin chung của hóa đơn bán
            string selectedCustomer = cmbokh.SelectedItem.ToString();
            string selectedMonthYear = cmbothang.SelectedItem.ToString();

            int selectedMonth = int.Parse(selectedMonthYear.Split('/')[0]);
            int selectedYear = int.Parse(selectedMonthYear.Split('/')[1]);

            string query = $@" SELECT DDH.SoDDH, K.tenKhach,NT.tenNoiThat, DDH.NgayDat,DDH.NgayGiao, DDH.TongTien,NhanVien.tenNV FROM DonDatHang AS DDH
                INNER JOIN KhachHang AS K ON DDH.MaKhach = K.MaKhach
                INNER JOIN ChiTietHDDH AS CTHD ON DDH.SoDDH = CTHD.SoDDH
                INNER JOIN NhanVien ON NhanVien.MaNV = DDH.MaNV
                INNER JOIN DMNoiThat AS NT ON CTHD.MaNoithat = NT.MaNoiThat
                WHERE K.tenKhach = '{selectedCustomer}' AND MONTH(DDH.NgayGiao) = {selectedMonth} AND YEAR(DDH.NgayGiao) = {selectedYear}";
            tblThongtinHD = functions.GetDataToTable(query);
            //exRange.Range["B6:C9"].Font.Size = 6;
            //exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            ////exRange.Range["C6:E6"].MergeCells = true;
            ////exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            //exRange.Range["B7:B7"].Value = "Khách hàng:";
            ////exRange.Range["C7:E7"].MergeCells = true;
            ////exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][1].ToString();
            //exRange.Range["B8:B8"].Value = "Tên nội thất:";
            ////exRange.Range["C8:E8"].MergeCells = true;
            ////exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][2].ToString();
            //exRange.Range["B9:B9"].Value = "Ngày đăt:";
            ////exRange.Range["C9:E9"].MergeCells = true;
            ////exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][3].ToString();
            //exRange.Range["B10:B10"].Value = "Ngày giao:";
            ////exRange.Range["C10:E10"].MergeCells = true;
            ////exRange.Range["C10:E10"].Value = tblThongtinHD.Rows[0][4].ToString();
            //exRange.Range["B5:B5"].Value = "Tổng tiền:";
            //exRange.Range["C5:E5"].MergeCells = true;
            //exRange.Range["C5:E5"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            //sql = "SELECT b.TenNoiThat, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien " +
            //      "FROM ChiTietHDDH AS a , DMNoiThat AS b WHERE a.SoDDH = N'" +
            //      txt_madonhang.Text + "' AND a.MaNoiThat = b.MaNoiThat";
            //tblThongtinHang = functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A5:G5"].Font.Bold = true;
            exRange.Range["A5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:G5"].ColumnWidth = 15;
            exRange.Range["A5:A5"].Value = "STT";
            exRange.Range["B5:B5"].Value = "Mã hóa đơn";
            exRange.Range["C5:C5"].Value = "Khách hàng";
            exRange.Range["D5:D5"].Value = "Tên nội thất";
            exRange.Range["E5:E5"].Value = "Ngày đặt";
            exRange.Range["F5:F5"].Value = "Ngày giao";
            exRange.Range["G5:G5"].Value = "Tổng tiền";
            //exRange.Range["G5:G5"].Value = "Tổng tiền tiền";
            for (hang = 0; hang < tblThongtinHD.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 6
                exSheet.Cells[1][hang + 6] = hang + 1;
                for (cot = 0; cot < tblThongtinHD.Columns.Count-1; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 6
                {
                    exSheet.Cells[cot + 2][hang + 6] = tblThongtinHD.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 6] = tblThongtinHD.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 8];
            exRange.Font.Bold = true;
            //exRange.Value2 = "Tổng tiền:";
            //exRange = exSheet.Cells[cot + 1][hang + 14];
            //exRange.Font.Bold = true;
            //exRange.Value2 = tblThongtinHD.Rows[0][5].ToString();
            exRange = exSheet.Cells[1][hang + 9]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            //exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[5][hang + 10]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(System.DateTime.Now);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].Font.Italic = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Báo Cáo";
            exApp.Visible = true;
        }

        private void btnword_Click_1(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (*.docx)|*.docx";
                sfd.FileName = "DanhSachDonDatHang.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    oApp = new Word.Application();
                    if (oApp == null)
                    {
                        MessageBox.Show("Không thể khởi tạo ứng dụng Word.");
                        return;
                    }
                    oDoc = oApp.Documents.Add();
                    if (oDoc == null)
                    {
                        MessageBox.Show("Không thể tạo tài liệu Word.");
                        return;
                    }
                    Export_Data_To_Word(bangdondathang, sfd.FileName);
                    MessageBox.Show("Xuất file Word thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount];
                for (int c = 0; c < ColumnCount; c++)
                {
                    DataArray[0, c] = DGV.Columns[c].HeaderText;
                }
                for (int r = 0; r < RowCount; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {
                        DataArray[r + 1, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }
                Word.Table oTable = oDoc.Tables.Add(oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range, RowCount + 1, ColumnCount, ref oMissing, ref oMissing);
                oTable.Range.ParagraphFormat.SpaceAfter = 6;
                for (int r = 0; r <= RowCount; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {
                        oTable.Cell(r + 1, c + 1).Range.Text = DataArray[r, c]?.ToString() ?? "";
                    }
                }
                DateTime currentDate = DateTime.Now;
                string ngayXuat = $"Ngày xuất: {currentDate.ToString("dd/MM/yyyy")}";
                string nhanVien = $"Nhân viên bán hàng: {GetTenNhanVien()}";
                oDoc.Content.InsertAfter(ngayXuat + "\n" + nhanVien);
                oDoc.SaveAs2(filename);
                oApp.Quit();
            }
        }
        private string GetTenNhanVien()
        {
            string selectedCustomer = cmbokh.SelectedItem.ToString();
            string selectedMonthYear = cmbothang.SelectedItem.ToString();
            int selectedMonth = int.Parse(selectedMonthYear.Split('/')[0]);
            int selectedYear = int.Parse(selectedMonthYear.Split('/')[1]);

            string query = $@"SELECT NhanVien.tenNV
                      FROM DonDatHang AS DDH
                      INNER JOIN NhanVien ON NhanVien.MaNV = DDH.MaNV
                      INNER JOIN KhachHang AS K ON DDH.MaKhach = K.MaKhach
                      WHERE K.tenKhach = '{selectedCustomer}' AND MONTH(DDH.NgayGiao) = {selectedMonth} AND YEAR(DDH.NgayGiao) = {selectedYear}";
            string tenNhanVien = functions.GetFieldValues(query).ToString();

            return tenNhanVien;
        }
    }
}
