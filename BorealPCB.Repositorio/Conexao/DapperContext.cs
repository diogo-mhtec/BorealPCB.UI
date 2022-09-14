using MySqlConnector;
using System.Configuration;
using System.Data;

namespace BorealPCB.Repositorio.Conexao
{
    public class DapperContext
    {
        private readonly string _connectionString;
        public DapperContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IDbConnection CreateConnection() => new MySqlConnection(_connectionString);
    }
}
