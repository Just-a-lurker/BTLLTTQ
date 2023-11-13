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
    public partial class FormStaff : Form
    {
        private Sql db = new Sql();
        private bool isUpdating = false;
        public FormStaff()
        {
            InitializeComponent();
            db.ThemVaoComboBox("select MaCV from CongViec", cmbomacv);
            db.ThemVaoComboBox("select Maca from CaLam", cmbomacl);
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableInputFields(false);
            btnThemMoi.Enabled = true;
        }

        private void LoadData()
        {
            dgvnhanvien.DataSource = db.DocBang("SELECT * FROM NhanVien");
        }

        private void EnableInputFields(bool enabled)
        {
            txtmanv.Enabled = enabled;
            txtnv.Enabled = enabled;
            cmbomacv.Enabled = enabled;
            cmbomacl.Enabled = enabled;
            cmbogioitinh.Enabled = enabled;
            txtdiachi.Enabled = enabled;
            txtdienthoai.Enabled = enabled;
            txtngaysinh.Enabled = enabled;
        }

        private void ClearInputFields()
        {
            txtmanv.Text = "";
            txtnv.Text = "";
            cmbomacv.Text = "";
            cmbomacl.Text = "";
            cmbogioitinh.Text = "";
            txtngaysinh.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
        }

        private void dgvnhanvien_Click(object sender, EventArgs e)
        {
            if (dgvnhanvien.SelectedRows.Count > 0)
            {
                try
                {
                    txtmanv.Enabled = true;
                    txtnv.Enabled = true;
                    cmbomacv.Enabled = true;
                    cmbomacl.Enabled = true;
                    cmbogioitinh.Enabled = true;
                    txtdiachi.Enabled = true;
                    txtdienthoai.Enabled = true;
                    txtngaysinh.Enabled = true;

                    txtmanv.Text = dgvnhanvien.SelectedRows[0].Cells["MaNV"].Value.ToString();
                    txtnv.Text = dgvnhanvien.SelectedRows[0].Cells["tenNV"].Value.ToString();
                    cmbomacv.Text = dgvnhanvien.SelectedRows[0].Cells["MaCV"].Value.ToString();
                    cmbomacl.Text = dgvnhanvien.SelectedRows[0].Cells["Maca"].Value.ToString();
                    cmbogioitinh.Text = dgvnhanvien.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                    txtngaysinh.Text = dgvnhanvien.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                    txtdienthoai.Text = dgvnhanvien.SelectedRows[0].Cells["DienThoai"].Value.ToString();
                    txtdiachi.Text = dgvnhanvien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                    btnThemMoi.Enabled = true;
                    isUpdating = true;
                }
                catch (Exception ex)
                {
                }
            }
            else { }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            EnableInputFields(true);
            btnThemMoi.Enabled = false;
            isUpdating = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtmanv.Text) && !string.IsNullOrWhiteSpace(txtnv.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtdienthoai.Text) && txtdienthoai.Text.Length == 10 &&
                    txtdienthoai.Text.All(char.IsDigit)) { }
                else
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ gồm 10 chữ số.", "Số điện thoại không hợp lệ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdienthoai.Focus();
                    return;
                }

                if (DateTime.TryParse(txtngaysinh.Text, out DateTime dob))
                {
                    if (dob >= DateTime.Today || dob.Year < 1950)
                    {
                        MessageBox.Show("Vui lòng nhập ngày sinh hợp lệ (trước hôm nay và sau năm 1950).", "Ngày sinh không hợp lệ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtngaysinh.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ngày sinh hợp lệ.", "Ngày sinh không hợp lệ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtngaysinh.Focus();
                    return;
                }
                if (isUpdating)
                {
                    string updateQuery = "UPDATE NhanVien SET tenNV = @tenNV, MaCV = @MaCV, Maca = @Maca , GioiTinh=@GioiTinh ,NgaySinh=@NgaySinh,DienThoai=@DienThoai,DiaChi=@DiaChi , WHERE MaNV = @MaNV";
                    db.ExecuteQuery(updateQuery,
                        ("@tenNV", txtnv.Text),
                        ("@MaCV", cmbomacv.Text),
                        ("@Maca", cmbomacl.Text),
                        ("@MaNV", txtmanv.Text),
                        ("@GioiTinh", cmbogioitinh.Text),
                        ("@NgaySinh", txtngaysinh.Text),
                        ("@DienThoai", txtdienthoai.Text),
                        ("@DiaChi", txtdiachi.Text));
                }
                else
                {
                    string insertQuery = "INSERT INTO NhanVien (MaNV, tenNV, MaCV, Maca,GioiTinh,NgaySinh,DienThoai,DiaChi) VALUES (@MaNV, @tenNV, @MaCV, @Maca,@GioiTinh,@NgaySinh,@DienThoai,@DiaChi )";
                    db.ExecuteQuery(insertQuery,
                        ("@MaNV", txtmanv.Text),
                        ("@tenNV", txtnv.Text),
                        ("@MaCV", cmbomacv.Text),
                        ("@Maca", cmbomacl.Text),
                        ("@GioiTinh", cmbogioitinh.Text),
                        ("@NgaySinh", txtngaysinh.Text),
                        ("@DienThoai", txtdienthoai.Text),
                        ("@DiaChi", txtdiachi.Text));
                }

                LoadData();
                ClearInputFields();
                EnableInputFields(false);
                btnThemMoi.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoQua.Enabled = true;
                isUpdating = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmanv.Text))
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtnv.Text))
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnv.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cmbomacv.Text))
            {
                MessageBox.Show("Bạn phải nhập mã công việc.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbomacv.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cmbomacl.Text))
            {
                MessageBox.Show("Bạn phải nhập mã ca làm.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbomacl.Focus();
            }
            else
            {
                string updateQuery = "UPDATE NhanVien SET tenNV = @tenNV, MaCV = @MaCV, Maca = @Maca , GioiTinh=@GioiTinh ,NgaySinh=@NgaySinh,DienThoai=@DienThoai,DiaChi=@DiaChi WHERE MaNV = @MaNV";

                db.ExecuteQuery(updateQuery,
                    ("@tenNV", txtnv.Text),
                    ("@MaCV", cmbomacv.Text),
                    ("@Maca", cmbomacl.Text),
                    ("@MaNV", txtmanv.Text),
                    ("@GioiTinh", cmbogioitinh.Text),
                    ("@NgaySinh", txtngaysinh.Text),
                    ("@DienThoai", txtdienthoai.Text),
                    ("@DiaChi", txtdiachi.Text));
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtmanv.Text))
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên với ID: " + txtmanv.Text + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                    db.ExecuteQuery(deleteQuery, ("@MaNV", txtmanv.Text));
                    LoadData();
                    ClearInputFields();
                }
            }
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            EnableInputFields(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ", "thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
              DialogResult.Yes) this.Close();
        }

		private void txtcl_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnCLCV_Click(object sender, EventArgs e)
		{
            FormCaLamCongViec formCaLamCongViec = new FormCaLamCongViec(false);
            formCaLamCongViec.ShowDialog();
		}
	}
}
