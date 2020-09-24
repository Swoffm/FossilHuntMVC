using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace TabloidMVC.Repositories
{
    public class BaseRepo
    {
        private string _connectionString;
        public BaseRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        protected SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }
    }
}