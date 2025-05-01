using MultApps.Models.Entitites.Abstract;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MultApps.Models.repositories
{
    public class ProdutoRepositories
    {
        private readonly string _connectionString;

        public ProdutoRepositories()
        {
            _connectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root;";
        }


        public List<Produto> ListarTodosProdutos()
        {
            var produtos = new List<Produto>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Produto";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produtos.Add(new Produto
                        {
                            Id = reader.GetInt32("Id"),
                            Nome = reader.GetString("Nome"),
                            Descricao = reader.GetString("Descricao"),
                            Categoria = reader.GetString("Categoria"),
                            Preco = reader.GetDecimal("Preco"),
                            Estoque = reader.GetInt32("Estoque"),
                            UrlImagem = reader.GetString("UrlImagem"),
                            Status = reader.GetString("Status")
                        });
                    }
                }
            }

            return produtos;
        }

        public bool CadastrarProduto(Produto produto)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO Produto (Nome, Descricao, Categoria, Preco, Estoque, UrlImagem, Status) " +
                                "VALUES (@Nome, @Descricao, @Categoria, @Preco, @Estoque, @UrlImagem, @Status)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", produto.Nome);
                        command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                        command.Parameters.AddWithValue("@Categoria", produto.Categoria);
                        command.Parameters.AddWithValue("@Preco", produto.Preco);
                        command.Parameters.AddWithValue("@Estoque", produto.Estoque);
                        command.Parameters.AddWithValue("@UrlImagem", produto.UrlImagem); 
                        command.Parameters.AddWithValue("@Status", produto.Status);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AdicionarProduto(Produto produto)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Produtos 
                (Nome, Descricao, Categoria, Preco, Estoque, UrlImagem, Status)
                VALUES (@Nome, @Descricao, @Categoria, @Preco, @Estoque, @UrlImagem, @Status);";

                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", produto.Nome);
                    command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                    command.Parameters.AddWithValue("@Categoria", produto.Categoria);
                    command.Parameters.AddWithValue("@Preco", produto.Preco);
                    command.Parameters.AddWithValue("@Estoque", produto.Estoque);
                    command.Parameters.AddWithValue("@UrlImagem", produto.UrlImagem);
                    command.Parameters.AddWithValue("@Status", produto.Status);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar produto: " + ex.Message);
                return false;
            }
        }
        public bool AtualizarProduto(Produto produtoAtualizado)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "UPDATE Produto SET Nome = @Nome, Descricao = @Descricao, Categoria = @Categoria, " +
                                "Preco = @Preco, Estoque = @Estoque, Status = @Status WHERE Id = @Id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", produtoAtualizado.Id);
                        command.Parameters.AddWithValue("@Nome", produtoAtualizado.Nome);
                        command.Parameters.AddWithValue("@Descricao", produtoAtualizado.Descricao);
                        command.Parameters.AddWithValue("@Categoria", produtoAtualizado.Categoria);
                        command.Parameters.AddWithValue("@Preco", produtoAtualizado.Preco);
                        command.Parameters.AddWithValue("@Estoque", produtoAtualizado.Estoque);
                        command.Parameters.AddWithValue("@Status", produtoAtualizado.Status);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletarProduto(int id)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM Produto WHERE Id = @Id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}