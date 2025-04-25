using Dapper;
using MultApps.Models.Entitites.Abstract;
using MySql.Data.MySqlClient;
using System.Data;

namespace MultApps.Models.repositories
{
    public class CategoriaRepositoriesBase
    {
        public string ConnectionString { get; set; }

        public CategoriaRepositoriesBase(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public CategoriaRepositoriesBase()
        {
            ConnectionString = "server=localhost;user=root;database=multapps_dev;password=root;";
        }
    }
}