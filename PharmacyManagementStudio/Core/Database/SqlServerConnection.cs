using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace PharmacyManagementStudio.Core.Database
{
    public class SqlServerConnection : IConnection
    {
        private string _connectionString = "Data Source=DESKTOP-JOQACIC;Initial Catalog=MedicineSale;Integrated Security=True";

        public DbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
