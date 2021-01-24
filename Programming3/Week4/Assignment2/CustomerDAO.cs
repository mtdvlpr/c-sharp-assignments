
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    class CustomerDAO
    {
        private SqlConnection dbConnection;

        public CustomerDAO()
        {
            string connString = ConfigurationManager
                                    .ConnectionStrings["DBConnectionString"]
                                    .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
    }
}
