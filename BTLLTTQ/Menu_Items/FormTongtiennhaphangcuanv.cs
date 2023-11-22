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
using Word = Microsoft.Office.Interop.Word;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace BTLLTTQ.Menu_Items
{
    public partial class FormTongtiennhaphangcuanv : Form
    {
        Sql db = new Sql();
        Merdul functions = new Merdul();
        private Word.Application oApp;
        private Word.Document oDoc;

        private object oEndOfDoc = "\\endofdoc"; 
        private object oMissing = System.Reflection.Missing.Value;
        public FormTongtiennhaphangcuanv()
        {
            InitializeComponent();
            /*DataTable dt = db.DocBang("Select * from ChiTietHDN");
            dgvds.DataSource = dt;
            dt.Dispose();*/
            db.ThemVaoComboBox("select manv from nhanvien", cmbonv);
            cmbonv.SelectedIndex = 0; 
            cmboquy.SelectedIndex = 0;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string selectedEmployee = cmbonv.SelectedItem.ToString();
            int selectedQuarter = cmboquy.SelectedIndex + 1;
            int startMonth = (selectedQuarter - 1) * 3 + 1;
            int endMonth = startMonth + 2;
            string query = $@"SELECT HDN.SoHDN, HDN.NgayNhap, HDN.MaNCC, HDN.MaNV, CT.DonGia, CT.SoLuong, CT.GiamGia,
                (CT.DonGia * CT.SoLuong * (1 - CT.GiamGia / 100)) AS TongCong FROM HoaDonNhap AS HDN
                INNER JOIN ChiTietHDN AS CT ON HDN.SoHDN = CT.SoHDN 
                WHERE HDN.MaNV = '{selectedEmployee}' AND MONTH(HDN.NgayNhap) BETWEEN {startMonth} AND {endMonth}";

            try
            {
                DataTable dt = db.DocBang(query);

                foreach (DataRow row in dt.Rows)
                {
                    decimal donGia = Convert.ToDecimal(row["DonGia"]);
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    decimal giamGia = Convert.ToDecimal(row["GiamGia"]);
                    row["TongCong"] = donGia * soLuong * (1 - giamGia / 100);
                }

                dgvds.DataSource = dt;

                decimal tongCong = 0;
                foreach (DataGridViewRow row in dgvds.Rows)
                {
                    if (row.Cells["TongCong"].Value != null)
                    {
                        tongCong += Convert.ToDecimal(row.Cells["TongCong"].Value);
                    }
                }

                MessageBox.Show($"Tổng tiền: {tongCong.ToString("C")}", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void dgvds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTongtiennhaphangcuanv_Load(object sender, EventArgs e)
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
            exRange.Range["C2:E2"].Value = "Danh sách hoá đơn và tổng tiền ";
            // Biểu diễn thông tin chung của hóa đơn bán
            string selectedEmployee = cmbonv.SelectedItem.ToString();
            int selectedQuarter = cmboquy.SelectedIndex + 1;
            int startMonth = (selectedQuarter - 1) * 3 + 1;
            int endMonth = startMonth + 2;
            string query = $@"
                WITH TongTienHoaDon AS (
                    SELECT HDN.SoHDN, HDN.NgayNhap, CT.DonGia,CT.GiamGia, CT.SoLuong,  NV.tenNV,
                           (CT.DonGia * CT.SoLuong * (1 - CT.GiamGia / 100)) AS TongCong
                    FROM HoaDonNhap AS HDN
                    INNER JOIN ChiTietHDN AS CT ON HDN.SoHDN = CT.SoHDN 
                    INNER JOIN NhanVien AS NV ON HDN.MaNV = NV.MaNV 
                    WHERE HDN.MaNV = '{selectedEmployee}' AND MONTH(HDN.NgayNhap) BETWEEN {startMonth} AND {endMonth}
                )
                SELECT SoHDN, NgayNhap, DonGia,GiamGia, SoLuong,  TongCong, tenNV,
                       SUM(TongCong) OVER (ORDER BY SoHDN) AS TongTienNhap
                FROM TongTienHoaDon
                ORDER BY SoHDN";



            tblThongtinHD = functions.GetDataToTable(query);

            exRange.Range["A5:G5"].Font.Bold = true;
            exRange.Range["A5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:G5"].ColumnWidth = 15;
            exRange.Range["A5:A5"].Value = "STT";
            exRange.Range["B5:B5"].Value = "Mã hóa đơn";
            exRange.Range["C5:C5"].Value = "Ngày nhập";
            exRange.Range["D5:D5"].Value = "Đơn Gía";
            exRange.Range["E5:E5"].Value = "Giảm giá";
            exRange.Range["F5:F5"].Value = "Số lượng";
            exRange.Range["G5:G5"].Value = "Tổng cộng";
            //exRange.Range["G5:G5"].Value = "Tổng tiền tiền";
            for (hang = 0; hang < tblThongtinHD.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 6
                exSheet.Cells[1][hang + 6] = hang + 1;
                for (cot = 0; cot < tblThongtinHD.Columns.Count - 2; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 6
                {
                    exSheet.Cells[cot + 2][hang + 6] = tblThongtinHD.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 6] = tblThongtinHD.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 8];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 8];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][7].ToString();
            exRange = exSheet.Cells[1][hang + 9]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            //exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[5][hang + 11]; //Ô A1 
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

        private void btnword_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (*.docx)|*.docx";
                sfd.FileName = "Tongtiencuanhanvien.docx";
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
                    Export_Data_To_Word(dgvds, sfd.FileName);
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
                decimal tongCong = 0;
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    if (row.Cells["TongCong"].Value != null)
                    {
                        tongCong += Convert.ToDecimal(row.Cells["TongCong"].Value);
                    }
                }

                oDoc.Content.InsertAfter("\nTổng tiền là:  " + tongCong.ToString("C"));

                DateTime currentDate = DateTime.Now;
                string ngayXuat = $"Ngày xuất: {currentDate.ToString("dd/MM/yyyy")}";
                string nhanVien = $"Nhân viên bán hàng: {GetTenNhanVien()}";
                oDoc.Content.InsertAfter("\n" + ngayXuat + "\n" + nhanVien);
                oDoc.SaveAs2(filename);
                oApp.Quit();
            }
        }
        private string GetTenNhanVien()
        {
            string selectedEmployee = cmbonv.SelectedItem.ToString();
            int selectedQuarter = cmboquy.SelectedIndex + 1;
            int startMonth = (selectedQuarter - 1) * 3 + 1;
            int endMonth = startMonth + 2;
            string query = $@"
                WITH TongTienHoaDon AS (
                    SELECT HDN.SoHDN, HDN.NgayNhap, CT.DonGia,CT.GiamGia, CT.SoLuong,  NV.tenNV,
                           (CT.DonGia * CT.SoLuong * (1 - CT.GiamGia / 100)) AS TongCong
                    FROM HoaDonNhap AS HDN
                    INNER JOIN ChiTietHDN AS CT ON HDN.SoHDN = CT.SoHDN 
                    INNER JOIN NhanVien AS NV ON HDN.MaNV = NV.MaNV 
                    WHERE HDN.MaNV = '{selectedEmployee}' AND MONTH(HDN.NgayNhap) BETWEEN {startMonth} AND {endMonth}
                )
                SELECT SoHDN, NgayNhap, DonGia,GiamGia, SoLuong,  TongCong, tenNV,
                       SUM(TongCong) OVER (ORDER BY SoHDN) AS TongTienNhap
                FROM TongTienHoaDon
                ORDER BY SoHDN";

            string tenNhanVien = functions.GetFieldValues(query).ToString();
            return tenNhanVien;
        }
    }
}
