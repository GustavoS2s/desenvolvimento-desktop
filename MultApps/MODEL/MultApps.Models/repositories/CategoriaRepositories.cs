using Dapper;
using Google.Protobuf.Collections;
using MultApps.Models.Entitites.Abstract;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Markup;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace MultApps.Models.repositories
{
    public class CategoriaRepositories
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";
        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO Categoria (Nome, Status)
                                  Values(@Nome, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public List<Categoria> ListarTodasCategorias()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT * FROM Categoria";

                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;
            }
        }


    }
}
