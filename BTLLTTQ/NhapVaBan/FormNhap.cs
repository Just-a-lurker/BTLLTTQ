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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTLLTTQ.NhapVaBan
{
    public partial class FormNhap : Form
    {
        Sql db = new Sql();
        public FormNhap()
        {
            InitializeComponent();
            DataTable dt = db.DocBang("Select * from hoadonnhap");
            dataGridView1.DataSource = dt;
            dt.Dispose();//Giải phóng bộ nhớ cho DataTable
            db.ThemVaoComboBox("select manv from nhanvien", cbbMaNV);
            db.ThemVaoComboBox("select mancc from nhacungcap", cBBmaNCC);
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

            }
            else
            {
                db.CapNhatDuLieu("insert into hoadonnhap values ("+txtHDN.Text+","+cbbMaNV.Text+",'"+cBBmaNCC.Text+"','"+ dateNgayNhap.Value.Date.ToString("yyyyMMdd")+"',"+int.Parse(txtTongTien.Text) + ")");
                txtHDN.Text = txtTongTien.Text = "";
                cbbMaNV.SelectedIndex = -1;
                cBBmaNCC.SelectedIndex = -1;
                DataTable dt = db.DocBang("Select * from hoadonnhap");
                dataGridView1.DataSource = dt;
            }
        }
    }
}
