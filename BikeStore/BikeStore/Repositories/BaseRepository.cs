using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BikeStore.Repositories
{
    public class BaseRepository : IDisposable
    {
        public SqlConnection connection { get; set; }

        public BaseRepository()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
