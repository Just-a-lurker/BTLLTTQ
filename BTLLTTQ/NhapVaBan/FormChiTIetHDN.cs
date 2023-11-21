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
using static System.Net.Mime.MediaTypeNames;

namespace BTLLTTQ.NhapVaBan
{
    public partial class FormChiTIetHDN : Form
    {
        Merdul md = new Merdul();
        Sql db = new Sql();
        string maHDN;
        int SLsua = 0, TTS = 0, DG = 0;
        public FormChiTIetHDN(string soHDN)
        {
            InitializeComponent();
            maHDN = soHDN;
            DataTable dt = db.DocBang("Select * from chitiethdn where sohdn = N'" + soHDN +"'");
            txtSoHDN.Text = maHDN;
            dataGridView1.DataSource = dt;
            db.ThemVaoComboBox("select manoithat from dmnoithat", cbbMaNT);
            dt.Dispose();//Giải phóng bộ nhớ cho DataTable
            txtThanhTien.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool checkMa(string k)
        {
            DataTable dt = db.DocBang("Select * from chitiethdn where manoithat =N'" + k + "' and sohdn = N'" + txtSoHDN.Text +"'");
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
            SLsua = int.Parse(txtSL.Text);
            TTS = int.Parse(txtThanhTien.Text);
            DG = int.Parse(txtDonGia.Text);
        }
        private void updateSL(int a)
        {
            int sl = int.Parse(md.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + cbbMaNT.Text + "'"));
            int slm = a + sl;
            if (slm > 0) { db.CapNhatDuLieu("UPDATE DMNoiThat SET SoLuong =" + slm + " WHERE MaNoiThat= N'" + cbbMaNT.Text + "'"); }
            else MessageBox.Show("SL khong hop le");
        }

        private void updateTT(int a)
        {

            int tt = int.Parse(md.GetFieldValues("SELECT tongtien FROM hoadonnhap WHERE sohdn = N'" + txtSoHDN.Text + "'"));
            tt += a;
            if (tt > 0) { db.CapNhatDuLieu("update hoadonnhap set tongtien = " + tt + " where sohdn =N'" + txtSoHDN.Text + "'"); }
            else MessageBox.Show("Tong tien khong hop le");

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
                   updateTT(int.Parse(txtThanhTien.Text));
                   updateSL(int.Parse(txtSL.Text));
                     db.CapNhatDuLieu("insert into chitiethdn values (N'" 
                        + cbbMaNT.Text + "',N'"
                        + txtSoHDN.Text + "'," 
                        + int.Parse(txtSL.Text) + "," 
                        + int.Parse(txtDonGia.Text) + "," 
                        + int.Parse(txtGiamGia.Text) + ","
                        + int.Parse(txtThanhTien.Text) + ")");
                    double temp = Math.Ceiling(int.Parse(txtDonGia.Text) * 1.1);
                    db.CapNhatDuLieu("UPDATE DMNoiThat SET dongianhap =" + int.Parse(txtDonGia.Text) + ", dongiaban = "+int.Parse(temp.ToString())+" WHERE MaNoiThat= N'" + cbbMaNT.Text + "'");
                    txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
                    cbbMaNT.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from chitiethdn where sohdn = N'" + txtSoHDN.Text +"'");
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
            if (!checkMa(cbbMaNT.Text)) { MessageBox.Show("Chon CTHD de xoa");
                return; }
            updateSL(-int.Parse(txtSL.Text));
            updateTT(-int.Parse(txtThanhTien.Text));
            db.CapNhatDuLieu("delete from chitiethdn where manoithat =N'" + cbbMaNT.Text + "' and sohdn = N'" + txtSoHDN.Text + "'");
            txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
            cbbMaNT.SelectedIndex = -1;
            DataTable dt = db.DocBang("Select * from chitiethdn where sohdn = N'" + txtSoHDN.Text +"'");
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
                    if (SLsua != int.Parse(txtSL.Text))
                    {
                        int temp = int.Parse(txtSL.Text)- SLsua;
                        updateSL(temp);
                    }
                    if (TTS != int.Parse(txtThanhTien.Text))
                    {
                        int temp = int.Parse(txtThanhTien.Text) - TTS;
                        updateTT(temp);
                    }
                    double temp2 = Math.Ceiling(int.Parse(txtDonGia.Text) * 1.1);
                    if (DG != int.Parse(txtDonGia.Text)) db.CapNhatDuLieu("UPDATE DMNoiThat SET dongianhap =" + int.Parse(txtDonGia.Text) + ", dongiaban = " + int.Parse(temp2.ToString()) + " WHERE MaNoiThat= N'" + cbbMaNT.Text + "'");
                    db.CapNhatDuLieu("update chitiethdn set soluong=" + int.Parse(txtSL.Text)
                        + ", dongia = " + int.Parse(txtDonGia.Text) + ",giamgia =" 
                        + int.Parse(txtGiamGia.Text) + ",thanhtien =" 
                        + int.Parse(txtThanhTien.Text) + " where manoithat =N'" 
                        + cbbMaNT.Text + "'");
                    txtDonGia.Text = txtGiamGia.Text = txtSL.Text = txtThanhTien.Text = "";
                    cbbMaNT.SelectedIndex = -1;
                    DataTable dt = db.DocBang("Select * from chitiethdn where sohdn = N'" + txtSoHDN.Text +"'");
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Khong ton tai ma noi that nay, dung insert de them");
                }

            }
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            DataTable dt = db.DocBang("Select * from chitiethdn where sohdn = N'" + maHDN + "'");
            dataGridView1.DataSource = dt;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (checkMa(cbbMaNT.Text))
            {
                DataTable dt = db.DocBang("Select * from chitiethdn where manoithat =N'" + cbbMaNT.Text + "', and sohdn = N'" + maHDN + "'");
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Khong tim thay chi tiet HDN nay");
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "")
            {}
            else
            {
            float giamgia = float.Parse(txtGiamGia.Text)/100 * (int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text));
            txtThanhTien.Text = Math.Ceiling((int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text) - giamgia)).ToString();
            }

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "")
            { }
            else
            {
                float giamgia = float.Parse(txtGiamGia.Text)/100 * (int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text));
                txtThanhTien.Text = Math.Ceiling((int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text) - giamgia)).ToString();
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtGiamGia.Text == "" || cbbMaNT.Text == "" || txtSL.Text == "")
            { }
            else
            {
                float giamgia = float.Parse(txtGiamGia.Text)/100 * (int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text));
                txtThanhTien.Text =Math.Ceiling((int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text) - giamgia)).ToString();
            }
        }
    }
}
