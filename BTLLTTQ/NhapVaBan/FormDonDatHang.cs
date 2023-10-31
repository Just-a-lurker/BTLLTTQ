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
    public partial class FormDonDatHang : Form
    {
        DataTable tblCTHDB;
        Merdul functions=new Merdul();
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xuat.Enabled = false;
            txt_madonhang.ReadOnly = true;
            txt_tennt.ReadOnly = true;
            txt_gia.ReadOnly = true;
            txt_thanhtien.ReadOnly = true;
            txt_tongtien.ReadOnly = true;
            txt_giamgia.Text = "0";
            txt_tongtien.Text= "0";
            cmb_mnt.Text = "";
            functions.FillComboBox("Select MaNoiThat from DMNoiThat", cmb_mnt);
            cmb_mnt.SelectedIndex = -1;
            functions.FillComboBox("Select MaKhach from KhachHang", cmb_mkh);
            cmb_mkh.SelectedIndex = -1;
            functions.FillComboBox("Select MaNV from NhanVien", cmb_mnv);
            cmb_mnv.SelectedIndex = -1;
            functions.FillComboBox("Select SoDDH from DonDatHang", cmb_dondh);
            cmb_dondh.SelectedIndex = -1;
            if (txt_madonhang.Text!=null)
            {
                LoadInfoHoaDon();
                btn_xoa.Enabled=true;
                btn_xuat.Enabled=true;
            }
        }
        //Nạp dữ liệu lên data gridview
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaNoiThat, b.TenNoiThat, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM ChiTietHDDH AS a, DMNoiThat AS b WHERE a.SoDDH = N'" + txt_madonhang.Text + "' AND a.MaNoiThat=b.MaNoiThat";
            tblCTHDB = functions.GetDataToTable(sql);
            dgvHDBanHang.DataSource = tblCTHDB;
            dgvHDBanHang.Columns[0].HeaderText = "Mã hàng";
            dgvHDBanHang.Columns[1].HeaderText = "Tên hàng";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Giảm giá %";
            dgvHDBanHang.Columns[5].HeaderText = "Thành tiền";
            dgvHDBanHang.Columns[0].Width = 230;
            dgvHDBanHang.Columns[1].Width = 230;
            dgvHDBanHang.Columns[2].Width = 230;
            dgvHDBanHang.Columns[3].Width = 230;
            dgvHDBanHang.Columns[4].Width = 230;
            dgvHDBanHang.Columns[5].Width = 230;
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayDat FROM DonDatHang WHERE SoDDH = N'" + txt_madonhang.Text + "'";
            //txt_ngaydat.Text = functions.ConvertDateTime(functions.GetFieldValues(str));
            txt_ngaydat.Text = functions.GetFieldValues(str);
            str = "SELECT NgayGiao FROM DonDatHang WHERE SoDDH = N'" + txt_madonhang.Text + "'";
            //txt_ngaydat.Text = functions.ConvertDateTime(functions.GetFieldValues(str));
            txt_ngaygiao.Text = functions.GetFieldValues(str);
            str = "SELECT MaNV FROM DonDatHang WHERE SoDDH = N'" + txt_madonhang.Text + "'";
            cmb_mnv.Text = functions.GetFieldValues(str);
            str = "SELECT MaKhach FROM DonDatHang WHERE SoDDH = N'" + txt_madonhang.Text + "'";
            cmb_mkh.Text = functions.GetFieldValues(str);
            str = "SELECT TongTien FROM DonDatHang WHERE SoDDH = N'" + txt_madonhang.Text + "'";
            txt_tongtien.Text = functions.GetFieldValues(str);
            //txt_tongtienbc.Text = Functions.ChuyenSoSangChu(txt_tongtien.Text);
        }

        private void txt_ngaydat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_xuat.Enabled = false;
            btn_them.Enabled = false;
            ResetValues();
            txt_madonhang.Text = Merdul.CreateKey("HDB");
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txt_madonhang.Text = "";
            txt_ngaydat.Text = DateTime.Now.ToShortDateString();
            txt_ngaygiao.Text = DateTime.Now.ToShortDateString();
            cmb_mnv.Text = "";
            cmb_mkh.Text = "";
            txt_tongtien.Text = "0";
            txt_tongtienbc.Text = "Bằng chữ: ";
            cmb_dondh.Text = "";
            txt_soluong.Text = "";
            txt_giamgia.Text = "0";
            txt_thanhtien.Text = "0";
            txt_thue.Text = "";
            txt_datcoc.Text = "";
        }
        private void ResetValuesHang()
        {
            cmb_mnt.Text = "";
            txt_soluong.Text = "";
            txt_giamgia.Text = "0";
            txt_thanhtien.Text = "0";
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Do y want to exit","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.ExitThread();
            }
        }

        private void cmb_mnt_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmb_mnt.Text == "")
            {
                txt_tennt.Text = "";
                txt_gia.Text = "";
            }
            if(cmb_mnt.SelectedIndex!=-1)
            {
                txt_thanhtien.Text = "0";
            }
            txt_soluong.Text = "";
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenNoiThat FROM DMNoiThat WHERE MaNoiThat =N'" + cmb_mnt.Text + "'";
            txt_tennt.Text = functions.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM DMNoiThat WHERE MaNoiThat =N'" + cmb_mnt.Text + "'";
            txt_gia.Text = functions.GetFieldValues(str);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT SoDDH FROM DonDatHang WHERE SoDDH=N'" + txt_madonhang.Text + "'";
            if (!functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txt_ngaydat.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ngaydat.Focus();
                    return;
                }
                if (txt_ngaygiao.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày giao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ngaygiao.Focus();
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
                if (txt_thue.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Thuế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_thue.Focus();
                    return;
                }
                if (txt_datcoc.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Đặt cọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_datcoc.Focus();
                    return;
                }
                sql = "INSERT INTO DonDatHang(SoDDH, MaNV, MaKhach, NgayDat,NgayGiao, DatCoc,Thue,TongTien) VALUES ('" 
                    + txt_madonhang.Text
                    + "','" 
                    + cmb_mnv.Text
                    + "','" 
                    +cmb_mkh.Text
                    + "','" 
                    +txt_ngaydat.Value
                    + "','"
                    + txt_ngaygiao.Value
                    + "','"
                    + txt_datcoc.Text
                    + "','"
                    + txt_thue.Text
                    + "','" 
                    + txt_tongtien.Text 
                    + "')";
                functions.UpdateData(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cmb_mnt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_mnt.Focus();
                return;
            }
            if ((txt_soluong.Text.Trim().Length == 0) || (txt_soluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Text = "";
                txt_soluong.Focus();
                return;
            }
            if (txt_giamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_giamgia.Focus();
                return;
            }
            sql = "SELECT MaNoithat FROM ChiTietHDDH WHERE MaNoithat=N'" + cmb_mnt.Text + "' AND SoDDH = N'" + txt_madonhang.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cmb_mnt.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToInt32(functions.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + cmb_mnt.Text + "'"));
            if (Convert.ToInt32(txt_soluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Text = "";
                txt_soluong.Focus();
                return;
            }
            sql = "INSERT INTO ChiTietHDDH(MaNoiThat,SoDDH,SoLuong,GiamGia,ThanhTien) VALUES('" 
                +cmb_mnt.Text + "','" 
               
                + txt_madonhang.Text + "','" 
                
                + txt_soluong.Text +  "','" 
                
                + txt_giamgia.Text + "','"
                 
                + txt_thanhtien.Text + "')";
                
            functions.UpdateData(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToInt32(txt_soluong.Text);
            sql = "UPDATE DMNoiThat SET SoLuong =" + SLcon + " WHERE MaNoiThat= N'" + cmb_mnt.Text + "'";
            functions.UpdateData(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToInt32(functions.GetFieldValues("SELECT TongTien FROM DonDatHang WHERE SoDDH = N'" + txt_madonhang.Text + "'"));
            Tongmoi = tong + Convert.ToInt32(txt_thanhtien.Text);
            Tongmoi = Tongmoi - Tongmoi * Convert.ToInt32(Convert.ToInt32(txt_thue.Text)  / 100);
            sql = "UPDATE DonDatHang SET TongTien =" + Tongmoi + " WHERE SoDDH = N'" + txt_madonhang.Text + "'";
            functions.UpdateData(sql);
            txt_tongtien.Text = Tongmoi.ToString();
            //txt_tongtienbc.Text =  Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_xuat.Enabled = true;
        }

        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            int ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgvHDBanHang.CurrentRow.Cells["MaNoiThat"].Value.ToString();
                SoLuongxoa = Convert.ToInt32(dgvHDBanHang.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToInt32(dgvHDBanHang.CurrentRow.Cells["ThanhTien"].Value.ToString());
                
                sql = "DELETE ChiTietHDDH WHERE SoDDH=N'" + txt_madonhang.Text + "' AND MaNoiThat = N'" + MaHangxoa + "'";
                
                functions.UpdateData(sql);
                // Cập nhật lại số lượng cho các mặt hàng
               
                sl = Convert.ToInt32(functions.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + MaHangxoa + "'"));
               
                slcon = sl + SoLuongxoa;
                
                sql = "UPDATE DMNoiThat SET SoLuong =" + slcon + " WHERE MaNoiThat= N'" + MaHangxoa + "'";
                
                functions.UpdateData(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                
                tong = Convert.ToInt32(functions.GetFieldValues("SELECT TongTien FROM DonDatHang WHERE SoDDH = N'" + txt_madonhang.Text + "'"));
               
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE DonDatHang SET TongTien =" + tongmoi + " WHERE SoDDH = N'" + txt_madonhang.Text + "'";
                
                
                functions.UpdateData(sql);
                txt_tongtien.Text = tongmoi.ToString();
                //txt_tongtienbc.Text = /*Functions.ChuyenSoSangChu(tongmoi.ToString());*/
                LoadDataGridView();
            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
             
               
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToInt32(txt_soluong.Text);
            if (txt_gia.Text == "")
                gg = 0;
            else
                gg = Convert.ToInt32(txt_giamgia.Text);
            if (txt_gia.Text == "")
                dg = 0;
            else
                dg = Convert.ToInt32(txt_gia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_thanhtien.Text = tt.ToString();
        }

        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            if (txt_giamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_giamgia.Text);
            if (txt_gia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_gia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_thanhtien.Text = tt.ToString();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (cmb_dondh.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_dondh.Focus();
                return;
            }
            txt_madonhang.Text = cmb_dondh.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
            btn_xuat.Enabled = true;
            cmb_dondh.SelectedIndex = -1;
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cmb_dondh_DropDown(object sender, EventArgs e)
        {
            functions.FillComboBox("SELECT SoDDH FROM DonDatHang", cmb_dondh);
            cmb_dondh.SelectedIndex = -1;
        }

        private void FormDonDatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void cmb_mnt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
