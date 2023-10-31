using BTLLTTQ.Menu;
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

namespace BTLLTTQ.Menu_Items
{
    public partial class FormStaff : Form
    {
        Sql db = new Sql();
        public FormStaff()
        {
            InitializeComponent();
            db.ThemVaoComboBox("select MaCV from CongViec", cmbomacv);
            db.ThemVaoComboBox("select Maca from CaLam", cmbomacl);
        }
        string strConnect = @"Data Source=DLINH\SQLEXPRESS;Initial Catalog=lttqnhom6;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private bool isUpdating = false;


        private void FormStaff_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(strConnect);
            adapter = new SqlDataAdapter("SELECT * FROM NhanVien", connection);
            dataTable = new DataTable();

            LoadData();

            EnableInputFields(false);
            btnThemMoi.Enabled = true;
        }
        private void LoadData()
        {
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgvnhanvien.DataSource = dataTable;
        }

        private void EnableInputFields(bool enabled)
        {
            txtmanv.Enabled = enabled;
            txtnv.Enabled = enabled;
            cmbomacv.Enabled = enabled;
            txtcv.Enabled = enabled;
            cmbomacl.Enabled = enabled;
            txtcl.Enabled = enabled;
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
            txtcv.Text = "";
            cmbomacl.Text = "";
            txtcl.Text = "";
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
                    txtcv.Enabled = true;
                    cmbomacl.Enabled = true;
                    txtcl.Enabled = true;
                    cmbogioitinh.Enabled = true;
                    txtdiachi.Enabled = true;
                    txtdienthoai.Enabled = true;
                    txtngaysinh.Enabled = true;

                    txtmanv.Text = dgvnhanvien.SelectedRows[0].Cells["MaNV"].Value.ToString();
                    txtnv.Text = dgvnhanvien.SelectedRows[0].Cells["tenNV"].Value.ToString();
                    cmbomacv.Text = dgvnhanvien.SelectedRows[0].Cells["MaCV"].Value.ToString();
                    txtcv.Text = dgvnhanvien.SelectedRows[0].Cells["tenCV"].Value.ToString();
                    cmbomacl.Text = dgvnhanvien.SelectedRows[0].Cells["Maca"].Value.ToString();
                    txtcl.Text = dgvnhanvien.SelectedRows[0].Cells["tenca"].Value.ToString();
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
            if (!string.IsNullOrWhiteSpace(txtmanv.Text) && !string.IsNullOrWhiteSpace(txtnv.Text) &&
                !string.IsNullOrWhiteSpace(cmbomacv.Text) && !string.IsNullOrWhiteSpace(txtcv.Text) &&
                !string.IsNullOrWhiteSpace(cmbomacl.Text) && !string.IsNullOrWhiteSpace(txtcl.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtdienthoai.Text) && txtdienthoai.Text.Length == 10 &&
                    txtdienthoai.Text.All(char.IsDigit)){}
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
                    SqlCommand cmd = new SqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@tenNV", txtnv.Text);
                    cmd.Parameters.AddWithValue("@MaCV", cmbomacv.Text);
                    cmd.Parameters.AddWithValue("@Maca", cmbomacl.Text);
                    cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", cmbogioitinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", txtngaysinh.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtdienthoai.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    string insertQuery = "INSERT INTO NhanVien (MaNV, tenNV, MaCV, Maca,GioiTinh,NgaySinh,DienThoai,DiaChi) VALUES (@MaNV, @tenNV, @MaCV, @Maca,@GioiTinh,@NgaySinh,@DienThoai,@DiaChi )";
                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
                    cmd.Parameters.AddWithValue("@tenNV", txtnv.Text);
                    cmd.Parameters.AddWithValue("@MaCV", cmbomacv.Text);
                    cmd.Parameters.AddWithValue("@Maca", cmbomacl.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", cmbogioitinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", txtngaysinh.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtdienthoai.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
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

            else if(string.IsNullOrWhiteSpace(txtnv.Text))
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
            else if (string.IsNullOrWhiteSpace(txtcv.Text))
            {
                MessageBox.Show("Bạn phải nhập tên công việc.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcv.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cmbomacl.Text))
            {
                MessageBox.Show("Bạn phải nhập mã ca làm.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbomacl.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtcl.Text))
            {
                MessageBox.Show("Bạn phải nhập tên ca làm.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcl.Focus();
            }
            else
            {
                string updateQuery = "UPDATE NhanVien SET tenNV = @tenNV, MaCV = @MaCV, Maca = @Maca , GioiTinh=@GioiTinh ,NgaySinh=@NgaySinh,DienThoai=@DienThoai,DiaChi=@DiaChi WHERE MaNV = @MaNV";

                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenNV", txtnv.Text);
                        cmd.Parameters.AddWithValue("@MaCV", cmbomacv.Text);
                        cmd.Parameters.AddWithValue("@Maca", cmbomacl.Text);
                        cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cmbogioitinh.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", txtngaysinh.Text);
                        cmd.Parameters.AddWithValue("@DienThoai", txtdienthoai.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");

                            LoadData();
                            ClearInputFields();
                            EnableInputFields(false);
                            btnThemMoi.Enabled = true;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            btnBoQua.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật. Hãy kiểm tra dữ liệu và thử lại.");
                        }
                    }
                }
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
                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                    cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
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
    }
}
