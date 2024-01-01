using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Controls;

namespace BTLLTTQ.Menu
{
    internal class Sql
    {
        string strConnect = @"Data Source=" + DBNAME.NAME + @"\SQLEXPRESS;Initial Catalog=Lttqnhom6;Integrated Security=True";
		SqlConnection sqlConnect = null;
        //Hàm mở kết nối CSDL
        private void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Hàm đóng kết nối CSDL
        private void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }
        //Hàm thực thi câu lệnh dạng Select trả về một DataTable
        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql,sqlConnect);
            sqldataAdapte.Fill(dtBang);
            DongKetNoiCSDL();
            return dtBang;
        }
        //Hàm thực lệnh insert hoặc update hoặc delete
        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnect;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
        //Hàm thêm vào 1 combobox
        public void ThemVaoComboBox(string sql, System.Windows.Forms.ComboBox cb)
        {
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnect;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            SqlDataReader DR = sqlcommand.ExecuteReader();
            while (DR.Read())
            {
                cb.Items.Add(DR[0]);

            }
        }

        public void ThemVaoComboBox(string sql,string value, string name, System.Windows.Forms.ComboBox cb)
        {
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnect;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DataTable dataTable = DocBang(sql);
            cb.ValueMember = value;
            cb.DisplayMember = name;
            cb.DataSource = dataTable;

        }

        public void ExecuteQuery(string query, params (string, object)[] parameters)
        {
            KetNoiCSDL();
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = sqlConnect;
                sqlCommand.CommandText = query;

                foreach (var (parameterName, parameterValue) in parameters)
                {
                    sqlCommand.Parameters.AddWithValue(parameterName, parameterValue);
                }

                sqlCommand.ExecuteNonQuery();
            }
            DongKetNoiCSDL();
        }
    }
}
