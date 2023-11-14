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

namespace BTLLTTQ.Menu_Items
{
    public partial class FormTongTienbanhang : Form
    {
        Sql db = new Sql();
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

            string query = $@"SELECT DDH.SoDDH, DDH.NgayGiao, DDH.DatCoc, DDH.Thue, DDH.TongTien FROM DonDatHang DDH
                JOIN ChiTietHDDH CTHD ON DDH.SoDDH = CTHD.SoDDH WHERE CTHD.MaNoithat = '{selectedItem}'";
            dataGridView1.DataSource = null;
            DataTable dt = db.DocBang(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin cho mục đã chọn.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dataGridView1.DataSource = dt;
            dt.Dispose();
        }
    }
}
