using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class DbRepository
    {
        public DbConnection OpenConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["BloodDonationSystemDB"].ConnectionString;
            return OpenConnection(connection);
        }

        public DbConnection OpenConnection(string connection)
        {
            var cnn = new SqlConnection(connection);
            cnn.Open();
            return cnn;
        }

    }
}
