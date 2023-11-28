
using BTLLTTQ.Menu;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace BTLLTTQ.NhapVaBan
{
    public partial class FormDonDatHang : Form
    {
        System.Data.DataTable tblCTHDB;
        Merdul functions=new Merdul();
        int SLCT;
        string CODE;
        string seachtype="";
        private void Reset_M()
        {
            SLCT = 0;
            CODE = "";
        }
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
            excel.Checked = true;
            cmb_dondh.SelectedIndex = -1;
            rd_ddh.Checked = true;
            if (rd_ddh.Checked)
            {
                cmb_dondh.Items.Clear();
                functions.FillComboBox("Select SoDDH from DonDatHang", cmb_dondh);
            }
                
            if (txt_madonhang.Text!="")
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
            dgvHDBanHang.Columns[0].HeaderText = "Mã nội thất";
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
        private void LoadDataGridViewSearchType()
        {
            string sql;
            string stype = "";
            if(rd_ddh.Checked==true)
            {
                LoadDataGridView();
                return;
            }else if(rd_nv.Checked==true)
            {
                cmb_mnv.Text=cmb_dondh.Text;
                stype += "c.MaNV";
            }
            else if (rd_kh.Checked==true)
            {
                cmb_mkh.Text = cmb_dondh.Text;
                stype += "c.MaKhach";
            }else if(rd_h.Checked==true)
            {
                stype += "a.MaNoiThat";
            }

            sql = "SELECT a.MaNoiThat, b.TenNoiThat, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien ";
            if(rd_kh.Checked==true)
            {
                sql += ",c.MaNV,a.SoDDH";
            }else if (rd_nv.Checked == true)
            {
                sql += ",c.MaKhach,a.SoDDH";
            }else if (rd_h.Checked == true)
            {
                sql += ",c.MaNV,a.SoDDH,c.MaKhach";
            }
              
            sql+=" FROM ChiTietHDDH  a, DMNoiThat  b,DonDatHang  c " +
                "WHERE (a.SoDDH = N'" + txt_madonhang.Text + "' Or "+stype+"='"+cmb_dondh.Text+"' )AND a.MaNoiThat=b.MaNoiThat AND c.SoDDH=a.SoDDH";
            tblCTHDB = functions.GetDataToTable(sql);
            dgvHDBanHang.DataSource = tblCTHDB;
            dgvHDBanHang.Columns[0].HeaderText = "Mã nội thất";
            dgvHDBanHang.Columns[1].HeaderText = "Tên hàng";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Giảm giá %";
            dgvHDBanHang.Columns[5].HeaderText = "Thành tiền";
            if(rd_kh.Checked==true)
            {
                dgvHDBanHang.Columns[6].HeaderText = "Mã Nhân Viên";
                dgvHDBanHang.Columns[6].Width = 100;
                dgvHDBanHang.Columns[7].HeaderText = "Số Đơn Đặt Hàng";
                dgvHDBanHang.Columns[7].Width = 100;

            }
            else if(rd_nv.Checked==true)
            {
                dgvHDBanHang.Columns[6].HeaderText = "Mã Khách Hàng";
                dgvHDBanHang.Columns[6].Width = 100;
                dgvHDBanHang.Columns[7].HeaderText = "Số Đơn Đặt Hàng";
                dgvHDBanHang.Columns[7].Width = 100;
            }else if(rd_h.Checked==true)
            {
                dgvHDBanHang.Columns[6].HeaderText = "Mã Khách Hàng";
                dgvHDBanHang.Columns[6].Width = 100;
                dgvHDBanHang.Columns[7].HeaderText = "Mã Nhân Viên";
                dgvHDBanHang.Columns[7].Width = 100;
                dgvHDBanHang.Columns[8].HeaderText = "Số Đơn Đặt Hàng";
                dgvHDBanHang.Columns[8].Width = 100;
            }    
            dgvHDBanHang.Columns[0].Width = 100;
            dgvHDBanHang.Columns[1].Width = 130;
            dgvHDBanHang.Columns[2].Width = 130;
            dgvHDBanHang.Columns[3].Width = 130;
            dgvHDBanHang.Columns[4].Width = 130;
            dgvHDBanHang.Columns[5].Width = 130;

            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        //đẩy dữ liệu vào combobox
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

      

        //xây dựng sự kiện cho btn thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_xuat.Enabled = false;
            btn_them.Enabled = false;
            btn_Sua.Enabled = false;
            ResetValues();
            txt_madonhang.Text = Merdul.CreateKey("DDH");
            LoadDataGridView();
        }

        //đặt lại toàn bộ giá trị
        private void ResetValues()
        {
            txt_madonhang.Text = "";
            txt_ngaydat.Text = DateTime.Now.ToShortDateString();
            txt_ngaygiao.Text = DateTime.Now.ToShortDateString();
            cmb_mnv.Text = "";
            cmb_mkh.Text = "";
            txt_tongtien.Text = "0";
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
                this.Close();
            }
        }

        //hiện tên,giá khi chọn mã nt
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

        //đẩy dự liệu vào trong cơ sở dl
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            int sl, SLcon, tong, Tongmoi;
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

        //xóa mh khi click 2 lần
        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            int ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (rd_ddh.Checked == true)
            {
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
                    //
                    if (dgvHDBanHang.Rows.Count == 0)
                    {
                        sql = "Delete from DonDatHang Where SoDDH ='" + txt_madonhang.Text + "'";
                        functions.UpdateData(sql);
                    }
                    //txt_tongtienbc.Text = /*Functions.ChuyenSoSangChu(tongmoi.ToString());*/
                    LoadDataGridView();
                    ResetValuesHang();
                }
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể xóa khi chọn mã DDH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
        }

        //thay đổi thành tiền khi thay đổi sl
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
        //thay đổi thành tiền khi thay đổi giảm giá
        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToInt32(txt_soluong.Text);
            if (txt_giamgia.Text == "")
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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string text = "";
            if (cmb_dondh.Text == "")
            {
                if (rd_ddh.Checked == true)
                {
                    text += "mã hóa đơn";
                }
                else if (rd_h.Checked == true)
                {
                    text += "mã nội thất";
                }
                else if (rd_kh.Checked == true)
                {
                    text += "mã khách hàng";

                }
                else if (rd_nv.Checked == true)
                {
                    text += "mã nhân viên";
                }
                MessageBox.Show("Bạn phải chọn một "+text+" để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_dondh.Focus();
                return;
            }
           

          
            
            //LoadInfoHoaDon(); 
            //LoadDataGridView();

            // string ssql = "";

           
            if (rd_ddh.Checked == true)
            {
                txt_madonhang.Text = cmb_dondh.Text;
                LoadInfoHoaDon();
                LoadDataGridView();
                btn_dong.Enabled = true;
                btn_xoa.Enabled = true;
                btn_luu.Enabled = true;
                btn_Sua.Enabled = true;
                btn_xuat.Enabled = true;

            }
            else if (rd_h.Checked == true)
            {
                LoadDataGridViewSearchType();
                btn_dong.Enabled = true;
                btn_xoa.Enabled = false;
                btn_luu.Enabled = false;
                btn_Sua.Enabled = false;
                btn_xuat.Enabled = false;

            }
            else if (rd_kh.Checked == true)
            {
                LoadDataGridViewSearchType();
                btn_dong.Enabled = true;
                btn_xoa.Enabled = false;
                btn_luu.Enabled = false;
                btn_Sua.Enabled = false;
                btn_xuat.Enabled = false;
            }
            else if (rd_nv.Checked == true)
            {
                LoadDataGridViewSearchType();
                btn_dong.Enabled = true;
                btn_xoa.Enabled = false;
                btn_luu.Enabled = false;
                btn_Sua.Enabled = false;
                btn_xuat.Enabled = false;
            }



           
            cmb_dondh.SelectedIndex = -1;
        }

        //ktra kiểu sl
        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cmb_dondh_DropDown(object sender, EventArgs e)
        {
            if (cmb_dondh.Items.Count == 0)
            {
                cmb_dondh.SelectedIndex = -1;
                if (rd_ddh.Checked == true)
                {
                    functions.FillComboBox("SELECT SoDDH FROM DonDatHang", cmb_dondh);
                } else if (rd_h.Checked == true)
                {
                    functions.FillComboBox("Select MaNoiThat from DMNoiThat", cmb_dondh);
                }
                else if(rd_kh.Checked == true)
                {
                    functions.FillComboBox("Select MaKhach from KhachHang", cmb_dondh);
                }
                else if(rd_nv.Checked==true)
                {
                    functions.FillComboBox("Select MaNV from NhanVien", cmb_dondh);
                }
           
           
            }
           
        }

        private void FormDonDatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

       

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            if (excel.Checked == true)
            {
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
                COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                COMExcel.Range exRange;
                string sql;
                int hang = 0, cot = 0;
                System.Data.DataTable tblThongtinHD, tblThongtinHang;
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                // Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
                exRange.Range["A1:B3"].Font.Size = 10;
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
                exRange.Range["A1:A1"].ColumnWidth = 7;
                exRange.Range["B1:B1"].ColumnWidth = 15;
                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "Khoa CNTT.";
                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "GTVT - Hà Nội";
                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A3:B3"].Value = "Điện thoại: 0325122044";
                exRange.Range["C2:E2"].Font.Size = 16;
                exRange.Range["C2:E2"].Font.Bold = true;
                exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["C2:E2"].MergeCells = true;
                exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:E2"].Value = "Đơn Đặt Hàng";
                // Biểu diễn thông tin chung của hóa đơn bán
                sql = "SELECT a.SoDDH, a.NgayDat,a.NgayGiao, a.TongTien, b.TenKhach, b.DiaChi, b.DienThoai, c.TenNV FROM DonDatHang AS a, KhachHang AS b, NhanVien AS c WHERE a.SoDDH = N'" + txt_madonhang.Text + "' AND a.MaKhach = b.MaKhach AND a.MaNV = c.MaNV";
                tblThongtinHD = functions.GetDataToTable(sql);
                exRange.Range["B6:C9"].Font.Size = 12;
                exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
                exRange.Range["C6:E6"].MergeCells = true;
                exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
                exRange.Range["B7:B7"].Value = "Khách hàng:";
                exRange.Range["C7:E7"].MergeCells = true;
                exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][4].ToString();
                exRange.Range["B8:B8"].Value = "Địa chỉ:";
                exRange.Range["C8:E8"].MergeCells = true;
                exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][5].ToString();
                exRange.Range["B9:B9"].Value = "Điện thoại:";
                exRange.Range["C9:E9"].MergeCells = true;
                exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][6].ToString();
                exRange.Range["B10:B10"].Value = "Ngày Đặt:";
                exRange.Range["C10:E10"].MergeCells = true;
                exRange.Range["C10:E10"].Value = tblThongtinHD.Rows[0][1].ToString();
                exRange.Range["B11:B11"].Value = "Ngày Giao:";
                exRange.Range["C11:E11"].MergeCells = true;
                exRange.Range["C11:E11"].Value = tblThongtinHD.Rows[0][2].ToString();
                //Lấy thông tin các mặt hàng
                sql = "SELECT b.TenNoiThat, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien " +
                      "FROM ChiTietHDDH AS a , DMNoiThat AS b WHERE a.SoDDH = N'" +
                      txt_madonhang.Text + "' AND a.MaNoiThat = b.MaNoiThat";
                tblThongtinHang = functions.GetDataToTable(sql);
                //Tạo dòng tiêu đề bảng
                exRange.Range["A12:F12"].Font.Bold = true;
                exRange.Range["A12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C12:F12"].ColumnWidth = 12;
                exRange.Range["A12:A12"].Value = "STT";
                exRange.Range["B12:B12"].Value = "Tên Nội Thất";
                exRange.Range["C12:C12"].Value = "Số lượng";
                exRange.Range["D12:D12"].Value = "Đơn giá";
                exRange.Range["E12:E12"].Value = "Giảm giá";
                exRange.Range["F12:F12"].Value = "Thành tiền";
                for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[1][hang + 13] = hang + 1;
                    for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    {
                        exSheet.Cells[cot + 2][hang + 13] = tblThongtinHang.Rows[hang][cot].ToString();
                        if (cot == 3) exSheet.Cells[cot + 2][hang + 13] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                    }
                }
                exRange = exSheet.Cells[cot][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = "Tổng tiền:";
                exRange = exSheet.Cells[cot + 1][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = tblThongtinHD.Rows[0][3].ToString();
                exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
                exRange.Range["A1:F1"].MergeCells = true;
                exRange.Range["A1:F1"].Font.Bold = true;
                exRange.Range["A1:F1"].Font.Italic = true;
                exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
                //exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
                exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                DateTime d = Convert.ToDateTime(System.DateTime.Now);
                exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                exRange.Range["A2:C2"].MergeCells = true;
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
                exRange.Range["A6:C6"].MergeCells = true;
                exRange.Range["A6:C6"].Font.Italic = true;
                exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][7];
                exSheet.Name = "Đơn đặt hàng";
                exApp.Visible = true;
            }else if(word.Checked==true)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Word Documents (*.docx)|*.docx";

                sfd.FileName = "export.docx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    Export_Data_To_Word(dgvHDBanHang, sfd.FileName);
                }
            }
                
           
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Content.Font.Size = 14;
                oDoc.Content.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oDoc.Application.Visible = true;
                oDoc.Content.Text ="\n Mã Nhân Viên:"+ cmb_mnv.Text+"\n Mã Khách Hàng:"+cmb_mkh.Text+"\nNgày Đặt:"+txt_ngaydat.Text+"\n Ngày Giao:"+txt_ngaygiao.Text+"\n Tổng Tiền:"+txt_tongtien.Text;
                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times new roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                DateTime a= DateTime.Now;
                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Đơn Đặt Hàng "+txt_madonhang.Text;
                    headerRange.Font.Size = 16;
                    headerRange.Font.Color = Word.WdColor.wdColorBlack;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    Word.Range footer = section.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footer.Fields.Add(footer, Word.WdFieldType.wdFieldPage);
                    string sql = "Select tenNV from NhanVien where MaNV='" + cmb_mnv.Text+"'";
                    string tnv=functions.GetFieldValues(sql).ToString();
                    footer.Text = "Hà Nội , Ngày" + a.Day + " Tháng " + a.Month + " năm " + a.Year+"\n\n\n\n\n\n"+tnv;
                    footer.Font.Size = 16;
                    footer.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    footer.Font.Color = Word.WdColor.wdColorBlack;
                }

                //save the file
                oDoc.SaveAs2(filename);

              
            }
        }
        //private void btn_word_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog sfd = new SaveFileDialog();

        //    sfd.Filter = "Word Documents (*.docx)|*.docx";

        //    sfd.FileName = "export.docx";

        //    if (sfd.ShowDialog() == DialogResult.OK)
        //    {

        //        Export_Data_To_Word(dgvHDBanHang, sfd.FileName);
        //    }
        //}
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            if(dgvHDBanHang.Rows.Count==0)
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_dondh.Focus();
                return;
            }else
            {
                string sql = "";
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn muốn sửa thật à?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        int sltk,a; 
                        sltk = Convert.ToInt32(functions.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + cmb_mnt.Text + "'"));
                        if (Convert.ToInt32(txt_soluong.Text) > sltk)
                        {
                            MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sltk, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_soluong.Text = "";
                            txt_soluong.Focus();
                            return;
                        } 
                       
                        //Reup SL
                        int temp = int.Parse(txt_soluong.Text) - SLCT;
                        int temp2 = temp + sltk;
                        if (CODE != cmb_mnt.Text)
                        {
                           
                            sql = "UPDATE DMNoiThat SET SoLuong = '" + temp2 + " 'WHERE MaNoiThat = N'" + CODE + "'";
                            functions.UpdateData(sql);
                        }else
                        {
                            sql = "UPDATE DMNoiThat SET SoLuong = '" + temp2 + " 'WHERE MaNoiThat = N'" + cmb_mnt.Text + "'";
                            functions.UpdateData(sql);
                        }


                        //sltk = Convert.ToInt32(functions.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + cmb_mnt.Text + "'"));

                        sql = "UPDATE ChiTietHDDH SET SoLuong = '" + Convert.ToInt32(txt_soluong.Text)
                   + "', GiamGia = '" + Convert.ToInt32(txt_giamgia.Text)
                   + "', ThanhTien = '" + Convert.ToInt32(txt_thanhtien.Text)
                   + "' WHERE SoDDH = '" + txt_madonhang.Text + "'";
                        functions.UpdateData(sql);
                        //int c = sltk - Convert.ToInt32(txt_soluong);
                        //sql="Update DMNoiThat Set SoLuong='"
                        //    +c.ToString()
                        //    + " WHERE MaNoiThat = N'" + cmb_mnt.Text + "'";
                        //functions.UpdateData(sql);
                        //int SLc, sl;
                        //sql = "UPDATE DMNoiThat SET SoLuong =" + SLc + " WHERE MaNoiThat= N'" + cmb_mnt.Text + "'";
                        //   sql = "UPDATE DonDatHang SET MaNV = '" + cmb_mnv.Text
                        //+ "', MaKhach = '" + cmb_mkh.Text
                        //+ "', NgayDat = '" + txt_ngaydat.Value.ToString("yyyy-MM-dd")
                        //+ "', NgayGiao = '" + txt_ngaygiao.Value.ToString("yyyy-MM-dd")
                        //+ "', DatCoc = '" + Convert.ToInt32(txt_datcoc.Text)
                        //+ "', Thue = '" + Convert.ToInt32(txt_thue.Text)
                        //+ "', TongTien = '" + Convert.ToInt32(txt_tongtien.Text)
                        //+ "' WHERE SoDDH = '" + txt_madonhang.Text + "'";
                        sql = "UPDATE DonDatHang SET TongTien = '" + Convert.ToInt32(txt_tongtien.Text)+ "' WHERE SoDDH = '" + txt_madonhang.Text + "'";
                        functions.UpdateData(sql);
                        LoadInfoHoaDon();
                        LoadDataGridView();
                        MessageBox.Show("OK Luon");
                        Reset_M();
                    }
                        

                }catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
               
               
            }
            
        }

        private void dgvHDBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_mnt.SelectedItem = dgvHDBanHang.SelectedRows[0].Cells[0].Value.ToString();
            txt_tennt.Text = dgvHDBanHang.SelectedRows[0].Cells[1].Value.ToString();
            txt_soluong.Text= dgvHDBanHang.SelectedRows[0].Cells[2].Value.ToString();
            txt_gia.Text = dgvHDBanHang.SelectedRows[0].Cells[3].Value.ToString();
            txt_giamgia.Text= dgvHDBanHang.Rows[0].Cells[4].Value.ToString();
            txt_thanhtien.Text = dgvHDBanHang.SelectedRows[0].Cells[5].Value.ToString();
            SLCT = Convert.ToInt32(txt_soluong.Text);
            CODE = cmb_mnt.SelectedItem.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if(rd_ddh.Checked==true)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "SELECT SoDDH,SoLuong FROM ChiTietHDDH WHERE SoDDH = N'" + txt_madonhang.Text + "'";
                    System.Data.DataTable NoiThat = functions.GetDataToTable(sql);
                    for (int hang = 0; hang <= NoiThat.Rows.Count - 1; hang++)
                    {

                        sl = Convert.ToDouble(functions.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + NoiThat.Rows[hang][0].ToString() + "'"));
                        slxoa = Convert.ToDouble(NoiThat.Rows[hang][1].ToString());
                        slcon = sl + slxoa;
                        sql = "UPDATE DMNoiThat SET SoLuong =" + slcon + " WHERE MaNoiThat= N'" + NoiThat.Rows[hang][0].ToString() + "'";
                        functions.UpdateData(sql);
                    }

                    //Xóa chi tiết hóa đơn
                    sql = "DELETE ChiTietHDDH WHERE SoDDH=N'" + txt_madonhang.Text + "'";
                    functions.RunSqlDel(sql);

                    //Xóa hóa đơn
                    sql = "DELETE DonDatHang WHERE SoDDH=N'" + txt_madonhang.Text + "'";
                    functions.RunSqlDel(sql);
                    ResetValues();
                    LoadDataGridView();
                    btn_xoa.Enabled = false;
                    btn_xuat.Enabled = false;
                }
            }else
            {
                MessageBox.Show("Bạn chỉ có thể xóa khi chọn mã đơn đặt hàng");
                return;
            }
            
        }

        private void rd_kh_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_kh.Checked == true)
            {
                cmb_dondh.Items.Clear();
                cmb_dondh.Text = "";
                functions.FillComboBox("Select MaKhach from KhachHang", cmb_dondh);
                btn_dong.Enabled = true;
                btn_luu.Enabled = false;
                btn_Sua.Enabled = false;
                btn_xoa.Enabled = false;
                btn_xuat.Enabled = false;
                dgvHDBanHang.Columns.Clear();
                MessageBox.Show("Ok b");
            }
               
        }

        private void rd_h_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_h.Checked == true)
            {
                cmb_dondh.Items.Clear();
                cmb_dondh.Text = "";
                functions.FillComboBox("Select MaNoiThat from DMNoiThat", cmb_dondh);
                btn_dong.Enabled = true;
                btn_luu.Enabled = false;
                btn_Sua.Enabled = false;
                btn_xuat.Enabled = false;
                btn_xoa.Enabled = false;
                dgvHDBanHang.Columns.Clear();
                MessageBox.Show("Ok b");
            }
        }

        private void rd_nv_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_nv.Checked == true)
            {
                cmb_dondh.Items.Clear();
                cmb_dondh.Text = "";
                functions.FillComboBox("Select MaNV from NhanVien", cmb_dondh);
                btn_dong.Enabled = true;
                btn_xoa.Enabled = false;
                btn_luu.Enabled = false;
                btn_Sua.Enabled = false;
                btn_xuat.Enabled = false;
                dgvHDBanHang.Columns.Clear();
                MessageBox.Show("Ok b");
            }
        }

        private void rd_ddh_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ddh.Checked == true)
            {
                cmb_dondh.Items.Clear();
                cmb_dondh.Text = "";
                functions.FillComboBox("Select SoDDH from DonDatHang", cmb_dondh);
                dgvHDBanHang.Columns.Clear();
                //MessageBox.Show("Ok b");
            }
        }

      

        private void txt_datcoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        

        private void txt_thue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }


        private void txt_ngaydat_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// //////click nham
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_mnt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txt_datcoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_thue_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_dondh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_xuat_TextChanged(object sender, EventArgs e)
        {
          
         
        }

        private void excel_CheckedChanged(object sender, EventArgs e)
        {
            if(excel.Checked==true)
            {
                btn_xuat.Text = "Xuất ra Excel";
            }
        }

        private void word_CheckedChanged(object sender, EventArgs e)
        {
            if (word.Checked == true)
            {
                btn_xuat.Text = "Xuất ra Word";
            }
        }
    }
}
