//using Microsoft.Office.Interop.Excel;
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

namespace BTLLTTQ.NhapVaBan
{
    public partial class FormBan : Form
    {
        CDataBase database=new CDataBase();
        DataTable dt;
        public FormBan()
        {
            
            InitializeComponent();tb_mhd.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayDat FROM DonDatHang WHERE SoDDH = N'" + tb_mhd.Text + "'";
            ngaydat.Value = DateTime.Parse(CDataBase.GetFieldValues(str));
            str = "SELECT NgayGiao FROM DonDatHang WHERE SoDDH = N'" + tb_mhd.Text + "'";
            ngaygiao.Value = DateTime.Parse(CDataBase.GetFieldValues(str));
            str = "SELECT MaNhanVien FROM DonDatHang WHERE SoDDH = N'" + tb_mhd.Text + "'";
            cmb_mnv.Text = CDataBase.GetFieldValues(str);
            str = "SELECT MaKhach FROM DonDatHang WHERE SoDDH = N'" + tb_mhd.Text + "'";
            cmb_mkh.Text = CDataBase.GetFieldValues(str);
            str = "SELECT TongTien FROM DonDatHang WHERE SoDDH = N'" + tb_mhd.Text + "'";
            str = "SELECT TienCoc FROM DonDatHang WHERE SoDDH = N'" + tb_mhd.Text + "'";
            cmb_tc.Text = CDataBase.GetFieldValues(str);
            str = "SELECT Thue FROM DonDatHang WHERE SoDDH = N'" + tb_mhd.Text + "'";
            cmb_tc.Text = CDataBase.GetFieldValues(str);
            tb_ttien.Text = CDataBase.GetFieldValues(str);
            tb_ttbc.Text = Functions.ChuyenSoSangChu(tb_ttien.Text);
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaNoiThat, b.TenNoiThat, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM ChiTietHDDH AS a, DMNoiThat AS b WHERE a.SoDDH = N'" + tb_mhd.Text + "' AND a.MaNoiThat=b.MaNoiThat";
            dt = CDataBase.GetDataToTable(sql);
            dgv_lnt.DataSource = dt;
            dgv_lnt.Columns[0].HeaderText = "Mã hàng";
            dgv_lnt.Columns[1].HeaderText = "Tên hàng";
            dgv_lnt.Columns[2].HeaderText = "Số lượng";
            dgv_lnt.Columns[3].HeaderText = "Đơn giá";
            dgv_lnt.Columns[4].HeaderText = "Giảm giá %";
            dgv_lnt.Columns[5].HeaderText = "Thành tiền";
            dgv_lnt.Columns[0].Width = 150;
            dgv_lnt.Columns[1].Width = 200;
            dgv_lnt.Columns[2].Width = 150;
            dgv_lnt.Columns[3].Width = 200;
            dgv_lnt.Columns[4].Width = 200;
            dgv_lnt.Columns[5].Width = 250;
            dgv_lnt.AllowUserToAddRows = false;
            dgv_lnt.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void FormBan_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
            btn_in.Enabled = false;
            tb_tt.Text = "0";
            tb_ttien.Text = "0";
            cmb_mkh.SelectedIndex = -1;
            cmb_mnt.SelectedIndex = -1;
            cmb_mnv.SelectedIndex = -1;
            cmb_tc.SelectedIndex = -1;
            cmb_thue.SelectedIndex = -1;
            cmb_tks.SelectedIndex = -1;
            database.ThemVaoComboBox("Select MaNoiThat from DMNoiThat", cmb_mnt);
            database.ThemVaoComboBox("Select MaNV from NhanVien", cmb_mnv);
            database.ThemVaoComboBox("Select MaKhach from KhachHang", cmb_mkh);
            if(tb_mhd.Text!="")
            {
                LoadInfoHoaDon();
                btn_xoa.Enabled=true;
                btn_in.Enabled=true;
            }
            LoadDataGridView();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_in.Enabled = false;
            btn_them.Enabled = false;
            ResetValues();
            tb_mhd.Text = Functions.CreateKey("DDH");
            LoadDataGridView();
        }

        private void ResetValues()
        {
            tb_mhd.Text = "";
            ngaydat.Text = DateTime.Now.ToShortDateString();
            ngaygiao.Text= DateTime.Now.ToShortDateString();
            cmb_mnv.Text = "";
            cmb_mkh.Text = "";
            tb_ttien.Text = "0";
            tb_ttbc.Text = "";
            cmb_mnt.Text = "";
            tb_sl.Text = "";
            tb_gg.Text = "0";
            tb_tt.Text = "0";
        }

        private void cmb_mnt_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void tb_sl_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (tb_sl.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(tb_sl.Text);
            if (tb_gg.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(tb_gg.Text);
            if (tb_gia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(tb_gia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            tb_tt.Text = tt.ToString();
        }

        private void cmb_mnt_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmb_mnt.Text == "")
            {
                tb_tnt.Text = "";
                tb_gia.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenNoiThat FROM DMNoiThat WHERE MaNoiThat =N'" +
                cmb_mnt.SelectedValue + "'";
            tb_tnt.Text = CDataBase.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM DMNoiThat WHERE MaNoiThat =N'" + cmb_mnt.SelectedValue + "'";
            tb_gia.Text = CDataBase.GetFieldValues(str);
        }

        private void tb_gg_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (tb_sl.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(tb_sl.Text);
            if (tb_gg.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(tb_gg.Text);
            if (tb_gia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(tb_gia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            tb_tt.Text = tt.ToString();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            if (cmb_tks.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_tks.Focus();
                return;
            }
            tb_mhd.Text = cmb_tks.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
            btn_in.Enabled = true;
            cmb_tks.SelectedIndex = -1;
        }

        private void FormBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void cmb_tks_DropDown(object sender, EventArgs e)
        {

        }

        private void tb_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
        private void ResetValuesHang()
        {
            cmb_mnt.Text = "";
            tb_sl.Text = "";
            tb_gg.Text = "";
            tb_tt.Text = "0";
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT SoDDH FROM tblHDBan WHERE SoDDH=N'" + tb_mhd.Text + "'";
            if (!CDataBase.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (ngaydat.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ngaydat.Focus();
                    return;
                }
                if (cmb_mnv.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_mnv.Focus();
                    return;
                }
                if (cmb_mkh.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_mkh.Focus();
                    return;
                }
                sql = "INSERT INTO DonDatHang(SoDDH, MaNV, MaKhach, NgayDat,NgayGiao,DatCoc,Thue, TongTien) VALUES (N'" 
                    + tb_mhd.Text.Trim() + "','" 
                    + cmb_mnv.Text + "','" 
                    + cmb_mkh.Text + "','"
                    + Functions.ConvertDateTime(ngaydat.Text.Trim()) + "','"+ Functions.ConvertDateTime(ngaygiao.Text.Trim())+"','" + cmb_tc.Text + "','"
                   +cmb_thue.Text + "'," 
                        + tb_tt.Text + ")";
                database.CapNhatDuLieu(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cmb_mnt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_mnt.Focus();
                return;
            }
            if ((tb_sl.Text.Trim().Length == 0) || (tb_sl.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_sl.Text = "";
                tb_sl.Focus();
                return;
            }
            if (tb_gg.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_gg.Focus();
                return;
            }
            sql = "SELECT MaNoiThat FROM ChiTietHDDH WHERE MaNoiThat=N'" + cmb_mnt.SelectedValue + "' AND MaHDBan = N'" + tb_mhd.Text.Trim() + "'";
            if (CDataBase.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cmb_mnt.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(CDataBase.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + cmb_mnt.SelectedValue + "'"));
            if (Convert.ToDouble(tb_sl.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_sl.Text = "";
                tb_sl.Focus();
                return;
            }
            sql = "INSERT INTO ChiTietHDDH(MaNoiThat,SoDDH,SoLuong,DonGia, GiamGia,ThanhTien) VALUES(N'" + cmb_mnt.SelectedValue + "',N'" + tb_mhd.Text.Trim() + "'," + tb_sl.Text + "," + tb_gia.Text + "," + tb_gg.Text + "," + tb_tt.Text + ")";
           database.CapNhatDuLieu(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(tb_sl.Text);
            sql = "UPDATE DMNoiThat SET SoLuong =" + SLcon + " WHERE MaNoiThat= N'" + cmb_mnt.SelectedValue + "'";
            database.CapNhatDuLieu(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(CDataBase.GetFieldValues("SELECT TongTien FROM DonDatHang WHERE SoDDH = N'" + tb_mhd.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(tb_tt.Text);
            sql = "UPDATE tblHDBan SET TongTien =" + Tongmoi + " WHERE SoDDH = N'" + tb_mhd.Text + "'";
            database.CapNhatDuLieu(sql);
            tb_tt.Text = Tongmoi.ToString();
           tb_ttbc.Text = Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
           btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_in.Enabled = true;
        }

        private void tb_tnt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
