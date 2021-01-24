using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class DAO
    {
        protected SqlConnection dbConnection;

        public DAO()
        {
            string connString = ConfigurationManager
                                    .ConnectionStrings["DBConnectionString"]
                                    .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
    }
}
