using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOPractical
{
    public class DatabaseManager
    {
        SqlConnection bitdevConnection;


        public DatabaseManager()
        {
            bitdevConnection = new SqlConnection();
        }

        public void ConnectToDatabase()
        {
            bitdevConnection.ConnectionString = "D"
        }



    }
}
