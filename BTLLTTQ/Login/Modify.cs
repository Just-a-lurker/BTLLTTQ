using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLTTQ
{
    class Modify
    {
        public Modify() { }
        SqlCommand sqlCommand;
        SqlDataReader reader;
        public List<Account> Accounts(string querry)
        {
            List<Account> accounts = new List<Account>();
            using(SqlConnection sqlConnection=Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand=new SqlCommand(querry, sqlConnection);
                reader=sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    accounts.Add(new Account(reader.GetString(0),reader.GetString(1)));

                }
                sqlConnection.Close();
            }
            return accounts;
        }
    }
}
