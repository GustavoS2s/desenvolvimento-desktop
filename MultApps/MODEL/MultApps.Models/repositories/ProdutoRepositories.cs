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
    public class ProdutoRepositories
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";

        public bool CadastrarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO Produto (Nome, Descricao, Categoria, Preco, Estoque, Status)
                                   VALUES (@Nome, @Descricao, @Categoria, @Preco, @Estoque, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Descricao", produto.Descricao);
                parametros.Add("@Categoria", produto.Categoria);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@Estoque", produto.Estoque);
                parametros.Add("@Status", produto.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public List<Produto> ListarTodosProdutos()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT Id, Nome, Descricao, Categoria, Preco, Estoque, Status, DataCriacao, DataAlteracao 
                                   FROM Produto";

                var resultado = db.Query<Produto>(comandoSql).ToList();
                return resultado;
            }
        }

        public Produto ObterProdutoPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT Id, Nome, Descricao, Categoria, Preco, Estoque, Status, DataCriacao, DataAlteracao 
                                   FROM Produto WHERE Id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var produto = db.Query<Produto>(comandoSql, parametros).FirstOrDefault();
                return produto;
            }
        }

        public bool AtualizarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE Produto
                                   SET Nome = @Nome,
                                       Descricao = @Descricao,
                                       Categoria = @Categoria,
                                       Preco = @Preco,
                                       Estoque = @Estoque,
                                       Status = @Status,
                                       DataAlteracao = CURRENT_TIMESTAMP
                                   WHERE Id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Descricao", produto.Descricao);
                parametros.Add("@Categoria", produto.Categoria);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@Estoque", produto.Estoque);
                parametros.Add("@Status", produto.Status);
                parametros.Add("@Id", produto.Id);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }

        public bool DeletarProduto(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM Produto WHERE Id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }
    }