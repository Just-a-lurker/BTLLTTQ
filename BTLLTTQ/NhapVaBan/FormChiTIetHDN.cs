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

namespace BTLLTTQ.NhapVaBan
{
    public partial class FormChiTIetHDN : Form
    {
        Sql db = new Sql();
        string maHDN;
        public FormChiTIetHDN(string soHDN)
        {
            InitializeComponent();
            maHDN = soHDN;
            DataTable dt = db.DocBang("Select * from chitiethdn where sohdn = N'" + soHDN +"'");
            txtSoHDN.Text = maHDN;
            dataGridView1.DataSource = dt;
            db.ThemVaoComboBox("select manoithat from dmnoithat", cbbMaNT);
            dt.Dispose();//Giải phóng bộ nhớ cho DataTable
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool checkMa(string k)
        {
            DataTable dt = db.DocBang("Select * from chitiethdn where manoithat =N'" + k + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cbbMaNT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGiamGia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtThanhTien.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Check lai DL");
            }
            else
            {
                if (!checkMa(cbbMaNT.Text))
                {
                     db.CapNhatDuLieu("insert into chitiethdn values (N'" 
                        + cbbMaNT.Text + "',N'"
                        + txtSoHDN.Text + "'," 
                        + int.Parse(txtSL.Text) + "," 
                        + int.Parse(txtDonGia.Text) + "," 
                        + int.Parse(txtGiamGia.Text) + ","
                        + int.Parse(txtThanhTien.Text) + ")");
                    txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
                    cbbMaNT.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from chitiethdn");
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Da ton tai ma noi that nay, dung sua de sua chi tiet HDN nay");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            db.CapNhatDuLieu("delete from chitiethdn where manoithat =N'" + cbbMaNT.Text + "'");
            txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
            cbbMaNT.SelectedIndex = -1;
            DataTable dt = db.DocBang("Select * from chitiethdn");
            dataGridView1.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Check lai DL");
            }
            else
            {
                if (checkMa(cbbMaNT.Text))
                {
                     db.CapNhatDuLieu("update chitiethdn set soluong=" + int.Parse(txtSL.Text)
                        + ", dongia = " + int.Parse(txtDonGia.Text) + ",giamgia =" 
                        + int.Parse(txtGiamGia.Text) + ",thanhtien =" 
                        + int.Parse(txtThanhTien.Text) + " where manoithat =N'" 
                        + cbbMaNT.Text + "'");
                    txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
                    cbbMaNT.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from chitiethdn");
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Khong ton tai ma noi that nay, dung insert de them");
                }

            }
        }
    }
}
