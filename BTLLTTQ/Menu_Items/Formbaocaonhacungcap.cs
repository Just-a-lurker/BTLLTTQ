﻿using BTLLTTQ.Menu;
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
namespace BTLLTTQ.Menu_Items
{
    public partial class Formbaocaonhacungcap : Form
    {
        Sql db = new Sql();
        Merdul functions = new Merdul();
        public Formbaocaonhacungcap()
        {
            InitializeComponent();
            db.ThemVaoComboBox("select MaNoiThat from DMNoiThat", cmbomh);
            db.ThemVaoComboBox("SELECT DISTINCT FORMAT(NgayNhap, 'MM/yyyy') AS ThangNam FROM HoaDonNhap", cmbothang);
        }

        private void Formbaocaonhacungcap_Load(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string selectedItem = cmbomh.SelectedItem?.ToString();
            string selectedMonth = cmbothang.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedItem) || string.IsNullOrEmpty(selectedMonth))
            {
                MessageBox.Show("Vui lòng chọn cả mục và tháng.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string query = $@"SELECT DISTINCT NCC.tenNCC FROM NhaCungCap NCC
                INNER JOIN HoaDonNhap HDN ON NCC.MaNCC = HDN.MaNCC
                INNER JOIN ChiTietHDN CTHDN ON HDN.SoHDN = CTHDN.SoHDN
                INNER JOIN DMNoiThat NT ON CTHDN.MaNoithat = NT.MaNoiThat
                WHERE NT.MaNoiThat = '{selectedItem}' AND FORMAT(HDN.NgayNhap, 'MM/yyyy') = '{selectedMonth}'";
            dataGridView1.DataSource = null;
            DataTable dt = db.DocBang(query);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin cho mục và tháng đã chọn.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView1.DataSource = dt;
            dt.Dispose();
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
            string selectedItem = cmbomh.SelectedItem?.ToString();
            string selectedMonth = cmbothang.SelectedItem?.ToString();
            string query = $@"SELECT DISTINCT NCC.tenNCC ,NT.tenNoiThat,HDN.NgayNhap ,NV.tenNV FROM NhaCungCap NCC
                  INNER JOIN HoaDonNhap HDN ON NCC.MaNCC = HDN.MaNCC
                  INNER JOIN ChiTietHDN CTHDN ON HDN.SoHDN = CTHDN.SoHDN
                  INNER JOIN NhanVien AS NV ON HDN.MaNV = NV.MaNV 
                  INNER JOIN DMNoiThat NT ON CTHDN.MaNoithat = NT.MaNoiThat
                  WHERE NT.MaNoiThat = '{selectedItem}' AND FORMAT(HDN.NgayNhap, 'MM/yyyy') = '{selectedMonth}'";

            tblThongtinHD = functions.GetDataToTable(query);

            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 15;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên nhà cung cấp";
            exRange.Range["C11:C11"].Value = "Tên nội thất";
            exRange.Range["D11:D11"].Value = "Ngày nhập";
            for (hang = 0; hang < tblThongtinHD.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHD.Columns.Count - 1; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHD.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 12];
            exRange.Font.Bold = true;

            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
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
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].Font.Italic = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = tblThongtinHD.Rows[0][3];
            exSheet.Name = "Báo Cáo";
            exApp.Visible = true;
        }
    }
}
