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
        public FormStaff()
        {
            InitializeComponent();
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
            txtmacv.Enabled = enabled;
            txtcv.Enabled = enabled;
            txtmacl.Enabled = enabled;
            txtcl.Enabled = enabled;
        }

        private void ClearInputFields()
        {
            txtmanv.Text = "";
            txtnv.Text = "";
            txtmacv.Text = "";
            txtcv.Text = "";
            txtmacl.Text = "";
            txtcl.Text = "";
        }

        private void dgvnhanvien_Click(object sender, EventArgs e)
        {
            txtmanv.Text = dgvnhanvien.SelectedRows[0].Cells["MaNV"].Value.ToString();
            txtnv.Text = dgvnhanvien.SelectedRows[0].Cells["tenNV"].Value.ToString();
            txtmacv.Text = dgvnhanvien.SelectedRows[0].Cells["MaCV"].Value.ToString();
            txtcv.Text = dgvnhanvien.SelectedRows[0].Cells["tenCV"].Value.ToString();
            txtmacl.Text = dgvnhanvien.SelectedRows[0].Cells["Maca"].Value.ToString();
            txtcl.Text = dgvnhanvien.SelectedRows[0].Cells["tenca"].Value.ToString();
            EnableInputFields(false);
            btnThemMoi.Enabled = true;
            isUpdating = true;
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
                !string.IsNullOrWhiteSpace(txtmacv.Text) && !string.IsNullOrWhiteSpace(txtcv.Text) &&
                !string.IsNullOrWhiteSpace(txtmacl.Text) && !string.IsNullOrWhiteSpace(txtcl.Text))
            {
                if (isUpdating)
                {
                    string updateQuery = "UPDATE NhanVien SET tenNV = @tenNV, MaCV = @MaCV, Maca = @Maca WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@tenNV", txtnv.Text);
                    cmd.Parameters.AddWithValue("@MaCV", txtmacv.Text);
                    cmd.Parameters.AddWithValue("@Maca", txtmacl.Text);
                    cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    string insertQuery = "INSERT INTO NhanVien (MaNV, tenNV, MaCV, Maca) VALUES (@MaNV, @tenNV, @MaCV, @Maca)";
                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
                    cmd.Parameters.AddWithValue("@tenNV", txtnv.Text);
                    cmd.Parameters.AddWithValue("@MaCV", txtmacv.Text);
                    cmd.Parameters.AddWithValue("@Maca", txtmacl.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                LoadData();
                ClearInputFields();
                EnableInputFields(false);
                btnThemMoi.Enabled = true;
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
            else if (string.IsNullOrWhiteSpace(txtmacv.Text))
            {
                MessageBox.Show("Bạn phải nhập mã công việc.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacv.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtcv.Text))
            {
                MessageBox.Show("Bạn phải nhập tên công việc.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcv.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtmacl.Text))
            {
                MessageBox.Show("Bạn phải nhập mã ca làm.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacl.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtcl.Text))
            {
                MessageBox.Show("Bạn phải nhập tên ca làm.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcl.Focus();
            }
            else
            {
                string updateQuery = "UPDATE NhanVien SET tenNV = @tenNV, MaCV = @MaCV, Maca = @Maca WHERE MaNV = @MaNV";

                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenNV", txtnv.Text);
                        cmd.Parameters.AddWithValue("@MaCV", txtmacv.Text);
                        cmd.Parameters.AddWithValue("@Maca", txtmacl.Text);
                        cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            LoadData(); 
                            ClearInputFields();
                            EnableInputFields(false);
                            btnXoa.Enabled = false;
                            btnSua.Enabled = false;
                            btnluu.Enabled = false;
                            btnBoQua.Enabled = false;
                            btnThemMoi.Enabled = true;
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
                if (MessageBox.Show("Do you want to delete employee with ID: " + txtmanv.Text + "?", "Confirmation",
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
            if (MessageBox.Show("ban co muon thoat", "thong bao",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
              DialogResult.Yes) this.Close();
        }
    }
}
