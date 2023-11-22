using BTLLTTQ.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace BTLLTTQ.Menu_Items
{
    public partial class FormTongTienbanhang : Form
    {
        Sql db = new Sql();
        Merdul functions = new Merdul();
        private Word.Application oApp;
        private Word.Document oDoc;

        private object oEndOfDoc = "\\endofdoc"; 
        private object oMissing = System.Reflection.Missing.Value;
        public FormTongTienbanhang()
        {
            InitializeComponent();
            db.ThemVaoComboBox("select MaNoiThat from DMNoiThat", cmbbmathang);
        }

        private void FormTongTienbanhang_Load(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string selectedItem = cmbbmathang.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Vui lòng chọn một mục.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = $@"SELECT DDH.SoDDH, DDH.NgayGiao, CTHD.SoLuong, CTHD.GiamGia, 
                           CTHD.ThanhTien, DDH.Thue, DDH.TongTien, NT.tenNoiThat 
                    FROM DonDatHang DDH
                    JOIN ChiTietHDDH CTHD ON DDH.SoDDH = CTHD.SoDDH 
                    JOIN DMNoiThat NT ON CTHD.MaNoithat = NT.MaNoiThat
                    WHERE NT.MaNoiThat = '{selectedItem}'";

            try
            {
                DataTable dt = db.DocBang(query);

                foreach (DataRow row in dt.Rows)
                {
                    decimal soLuong = Convert.ToDecimal(row["SoLuong"]);
                    decimal giamGia = Convert.ToDecimal(row["GiamGia"]);
                    decimal thanhTien = Convert.ToDecimal(row["ThanhTien"]);
                    decimal thue = Convert.ToDecimal(row["Thue"]);

                    row["TongTien"] = soLuong * thanhTien * (1 - giamGia / 100) * (1 + thue / 100);
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            exRange.Range["C2:E2"].Value = "Danh sách hoá đơn và tổng tiền bán ";
            // Biểu diễn thông tin chung của hóa đơn bán
            string selectedItem = cmbbmathang.SelectedItem?.ToString();
            string query = $@"
                WITH TongTienDonDatHang AS (
                    SELECT DDH.SoDDH, NT.tenNoiThat, KH.TenKhach, DDH.NgayGiao, CTHD.SoLuong, CTHD.GiamGia, 
                           CTHD.ThanhTien, DDH.Thue, NV.tenNV, DDH.TongTien 
                    FROM DonDatHang DDH
                    INNER JOIN ChiTietHDDH CTHD ON DDH.SoDDH = CTHD.SoDDH 
                    INNER JOIN NhanVien AS NV ON DDH.MaNV = NV.MaNV 
                    INNER JOIN DMNoiThat NT ON CTHD.MaNoithat = NT.MaNoiThat
                    INNER JOIN KhachHang KH ON DDH.MaKhach = KH.MaKhach
                    WHERE NT.MaNoiThat = '{selectedItem}'
                )
                SELECT SoDDH, tenNoiThat, TenKhach, NgayGiao, SoLuong, GiamGia, 
                       ThanhTien, Thue, tenNV,
                       (SoLuong * ThanhTien * (1 - GiamGia / 100) * (1 + Thue / 100)) AS TongTien
                FROM TongTienDonDatHang";



            tblThongtinHD = functions.GetDataToTable(query);

            exRange.Range["A5:I5"].Font.Bold = true;
            exRange.Range["A5:I5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:I5"].ColumnWidth = 15;
            exRange.Range["A5:A5"].Value = "STT";
            exRange.Range["B5:B5"].Value = "Mã hóa đơn";
            exRange.Range["C5:C5"].Value = "Tên nội thất";
            exRange.Range["D5:D5"].Value = "Khách hàng";
            exRange.Range["E5:E5"].Value = "Ngày giao";
            exRange.Range["F5:F5"].Value = "Số lượng";
            exRange.Range["G5:G5"].Value = "Giảm giá";
            exRange.Range["H5:H5"].Value = "Thành tiền";
            exRange.Range["I5:I5"].Value = "Thuế";
            //exRange.Range["G5:G5"].Value = "Tổng tiền tiền";
            for (hang = 0; hang < tblThongtinHD.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 6] = hang + 1;

                for (cot = 0; cot < tblThongtinHD.Columns.Count - 2; cot++) 
                {
                    if (cot == 5 || cot == 7) 
                    {
                        exSheet.Cells[cot + 2][hang + 6] = tblThongtinHD.Rows[hang][cot].ToString() + "%";
                    }
                    else
                    {
                        exSheet.Cells[cot + 2][hang + 6] = tblThongtinHD.Rows[hang][cot].ToString();
                    }
                }
                tblThongtinHD.Rows[hang]["TongTien"] = Convert.ToDecimal(tblThongtinHD.Rows[hang]["SoLuong"]) * Convert.ToDecimal(tblThongtinHD.Rows[hang]["ThanhTien"]) * (1 - Convert.ToDecimal(tblThongtinHD.Rows[hang]["GiamGia"]) / 100) * (1 + Convert.ToDecimal(tblThongtinHD.Rows[hang]["Thue"]) / 100);
            }
            exRange = exSheet.Cells[cot][hang + 8]; 
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";

            exRange = exSheet.Cells[cot + 1][hang + 8];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Compute("SUM(TongTien)", "").ToString();

            exRange = exSheet.Cells[1][hang + 9]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            //exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[7][hang + 10]; //Ô A1 
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
            exRange.Range["A3:C3"].Value = tblThongtinHD.Rows[0][8];
            exSheet.Name = "Báo Cáo";
            exApp.Visible = true;
        }

        private void btnword_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (*.docx)|*.docx";
                sfd.FileName = "Tongtienbanhang.docx";
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
                    Export_Data_To_Word(dataGridView1, sfd.FileName);
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
            string selectedItem = cmbbmathang.SelectedItem?.ToString();
            string query = $@"
                WITH TongTienDonDatHang AS (
                    SELECT DDH.SoDDH, NT.tenNoiThat, KH.TenKhach, DDH.NgayGiao, CTHD.SoLuong, CTHD.GiamGia, 
                           CTHD.ThanhTien, DDH.Thue, NV.tenNV, DDH.TongTien 
                    FROM DonDatHang DDH
                    INNER JOIN ChiTietHDDH CTHD ON DDH.SoDDH = CTHD.SoDDH 
                    INNER JOIN NhanVien AS NV ON DDH.MaNV = NV.MaNV 
                    INNER JOIN DMNoiThat NT ON CTHD.MaNoithat = NT.MaNoiThat
                    INNER JOIN KhachHang KH ON DDH.MaKhach = KH.MaKhach
                    WHERE NT.MaNoiThat = '{selectedItem}'
                )
                SELECT SoDDH, tenNoiThat, TenKhach, NgayGiao, SoLuong, GiamGia, 
                       ThanhTien, Thue, tenNV,
                       (SoLuong * ThanhTien * (1 - GiamGia / 100) * (1 + Thue / 100)) AS TongTien
                FROM TongTienDonDatHang";
            string tenNhanVien = functions.GetFieldValues(query).ToString();

            return tenNhanVien;
        }
    }
}
