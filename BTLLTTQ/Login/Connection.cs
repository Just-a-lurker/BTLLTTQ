using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLTTQ
{
    public class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-PP0U79P7\SQLEXPRESS;Initial Catalog=lttqnhom6;Integrated Security=True";
       
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
