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
    public partial class Formbaocaonhacungcap : Form
    {
        Sql db = new Sql();
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
            dataGridView1.Columns[0].Width = 700;
            dt.Dispose();
        }
    }
}
