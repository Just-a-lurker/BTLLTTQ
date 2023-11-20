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
                MessageBox.Show("Check lai DL");
            }
            else
            {
                if (!checkMa(txtHDN.Text))
                {
                    db.CapNhatDuLieu("insert into hoadonnhap values ("+txtHDN.Text+",N'"+cbbMaNV.Text+"',N'"+cBBmaNCC.Text+"','"+ dateNgayNhap.Value.Date.ToString("yyyyMMdd")+"',"+int.Parse(txtTongTien.Text) + ")");
                    txtHDN.Text = txtTongTien.Text = "";
                    cbbMaNV.SelectedIndex = -1;
                    cBBmaNCC.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from hoadonnhap");
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Da co HDN voi soHDN nay, hay SD sua thay vi them");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkMa(txtHDN.Text))
            {
                DataTable dt1 = db.DocBang("Select * from chitiethdn where sohdn =N'" + txtHDN.Text + "'");
                if (dt1.Rows.Count > 0)
                {
                    MessageBox.Show("Hay xoa het chi tiet cua hoa don nay truoc");
                }
                else
                db.CapNhatDuLieu("delete from hoadonnhap where sohdn =N'" + txtHDN.Text + "'");
				txtHDN.Text = txtTongTien.Text = "";
                cbbMaNV.SelectedIndex = -1;
                cBBmaNCC.SelectedIndex = -1;
                DataTable dt = db.DocBang("Select * from hoadonnhap");
                dataGridView1.DataSource = dt;
            }
            else MessageBox.Show("Khong tim thay HD");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHDN.Text == "" || cbbMaNV.Text == "" || cBBmaNCC.Text == "")
            {
                MessageBox.Show("Check lai DL");
            }
            else
            {
                if (checkMa(txtHDN.Text))
                {
                    db.CapNhatDuLieu("update hoadonnhap set maNV=N'" + cbbMaNV.Text + "', mancc = N'" + cBBmaNCC.Text + "',ngaynhap ='" + dateNgayNhap.Value.Date.ToString("yyyyMMdd") + "',tongtien =" + int.Parse(txtTongTien.Text) + " where sohdn =N'" + txtHDN.Text + "'");
                    txtHDN.Text = txtTongTien.Text = "";
                    cbbMaNV.SelectedIndex = -1;
                    cBBmaNCC.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from hoadonnhap");
                    dataGridView1.DataSource = dt;
                }
                else MessageBox.Show("Chua co HDN voi soHDN nay, hay SD them thay vi sua");
            }
        }

        bool checkMa(string k)
        {
            DataTable dt = db.DocBang("Select * from hoadonnhap where sohdn =N'" + k + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtHDN.Enabled = false;
            txtHDN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbbMaNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cBBmaNCC.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateNgayNhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void FormNhap_Click(object sender, EventArgs e)
        {
            txtHDN.Text = txtTongTien.Text = "";
            cbbMaNV.SelectedIndex = -1;
            cBBmaNCC.SelectedIndex = -1;
            txtHDN.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHDN.Text == "") MessageBox.Show("Nhap hoac chon ma HDN");
            else
            {
                if (checkMa(txtHDN.Text))
                {
                    FormChiTIetHDN chiTIetHDN = new FormChiTIetHDN(txtHDN.Text);
                    chiTIetHDN.ShowDialog();
                }
                else MessageBox.Show("Khong co HDN voi maHDN nay");
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(checkMa(txtHDN.Text))
            {
                DataTable dt = db.DocBang("Select * from hoadonnhap where sohdn =N'" + txtHDN.Text + "'");
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Khong tim thay HDN nay");
            }
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            DataTable dt = db.DocBang("Select * from hoadonnhap");
            dataGridView1.DataSource = dt;
        }

		private void button2_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
