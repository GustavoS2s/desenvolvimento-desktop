﻿using Dapper;
using MultApps.Models.Entitites.Abstract;
using MySql.Data.MySqlClient;
using System.Data;

namespace MultApps.Models.repositories
{
    public class CategoriaRepositoriesBase
    {
        private string ConnectionString;

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
    }
}
