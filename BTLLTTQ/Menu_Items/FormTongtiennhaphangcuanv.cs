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
    public partial class FormTongtiennhaphangcuanv : Form
    {
        Sql db = new Sql();
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
            string query = $@"
            SELECT HDN.SoHDN, HDN.NgayNhap, HDN.MaNCC, HDN.MaNV, CT.DonGia, CT.SoLuong FROM HoaDonNhap AS HDN
            INNER JOIN ChiTietHDN AS CT ON HDN.SoHDN = CT.SoHDN WHERE HDN.MaNV = '{selectedEmployee}'
            AND MONTH(HDN.NgayNhap) BETWEEN {startMonth} AND {endMonth} ";

            try
            {
                DataTable dt = db.DocBang(query);
                dgvds.DataSource = dt;
                dt.Columns.Add("Tong", typeof(decimal));

                foreach (DataRow row in dt.Rows)
                {
                    decimal donGia = Convert.ToDecimal(row["DonGia"]);
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    row["Tong"] = donGia * soLuong;
                }

                dgvds.Columns["Tong"].HeaderText = "Tong Cong";
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
    }
}
