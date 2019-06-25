using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KontakteApp
{
    public class SQLHelper
    {
        SqlConnection conn;

        public SQLHelper(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public bool IsConnected
        {
            get
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }
    }
}
