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

namespace BTLLTTQ.Menu_Items
{
    public partial class Formbcdsspchokhachhang : Form
    {

        Sql db = new Sql();
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
            string query = $@" SELECT DDH.SoDDH, DDH.MaKhach, DDH.NgayDat, DDH.NgayGiao, DDH.DatCoc, DDH.Thue, DDH.TongTien
            FROM DonDatHang AS DDH INNER JOIN KhachHang AS K ON DDH.MaKhach = K.MaKhach WHERE K.tenKhach = '{selectedCustomer}'
            AND MONTH(DDH.NgayGiao) = {selectedMonth} AND YEAR(DDH.NgayGiao) = {selectedYear} ";

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
    }
}
