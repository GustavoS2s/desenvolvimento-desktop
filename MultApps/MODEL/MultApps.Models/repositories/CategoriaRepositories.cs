using Dapper;
using MultApps.Models.Entitites.Abstract;
using MultApps.Models.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
                var comandoSql = @"SELECT Id, Nome, Status, DataCriacao, DataAlteracao 
                                   FROM Categoria";

                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;
            }
        }

        public Categoria ObterCategoriaPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT Id, Nome, Status, DataCriacao, DataAlteracao 
                                   FROM Categoria WHERE Id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var categoria = db.Query<Categoria>(comandoSql, parametros).FirstOrDefault();
                return categoria;
            }
        }
        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO Categoria (Nome, Status)
                           Values(@Nome, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);

                // Conversão direta de StatusEnum para string
                string statusString = categoria.Status.ToString().ToLower();

                parametros.Add("@Status", statusString);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool AtualizarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE Categoria
                           SET Nome = @Nome,
                               Status = @Status,
                               DataAlteracao = CURRENT_TIMESTAMP
                           WHERE Id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);

                // Conversão direta de StatusEnum para string
                string statusString = categoria.Status.ToString().ToLower();

                parametros.Add("@Status", statusString);
                parametros.Add("@Id", categoria.Id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }


    }
}
