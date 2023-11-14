using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLLTTQ
{
	public partial class ChonDB : Form
	{
		public ChonDB()
		{
			InitializeComponent();
		}

		private void ChonDB_Load(object sender, EventArgs e)
		{

		}
		public bool CheckConnection()
		{
			this.Cursor = Cursors.WaitCursor;
			string conString = @"Data Source=" + DBNAME.NAME + @"\SQLEXPRESS;Initial Catalog=lttqnhom6;Integrated Security=True;Connection Timeout=03";
			bool isValid = false;
			SqlConnection con = null;
			try
			{
				con = new SqlConnection(conString);
				con.Open();
				isValid = true;
			}
			catch (SqlException ex)
			{
				isValid = false;
				MessageBox.Show("Không tìm thấy DB");
			}
			finally
			{
				if (con.State == ConnectionState.Open)
				{
					con.Close();
				}
			}
			this.Cursor = Cursors.Default;
			return isValid;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			char[] separators = { '(', ' ' };
			string name = comboBox1.Text.ToString().Split(separators)[0];
			DBNAME.NAME = name;
			if (CheckConnection())
			{
				this.Hide();
				FormMNN formMenu = new FormMNN();
				formMenu.ShowDialog();
				this.Close();
			}

		}
	}
}
