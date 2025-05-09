﻿using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enums;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Data;
using Dapper;
using System.Linq;
using MultApps.Models.Entitites.Abstract;

namespace MultApps.Models.Repositories
{
    public class UsuarioRepositories
    {
        private readonly string _connectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root;";

        public bool CadastrarUsuario(Usuario usuario)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Usuarios 
                        (NomeCompleto, CPF, Email, Senha, DataCadastro, DataUltimoAcesso, Status)
                        VALUES (@NomeCompleto, @CPF, @Email, @Senha, @DataCadastro, @DataUltimoAcesso, @Status);";

                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NomeCompleto", usuario.NomeCompleto);
                    command.Parameters.AddWithValue("@CPF", usuario.CPF);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@Senha", usuario.Senha);
                    command.Parameters.AddWithValue("@DataCadastro", usuario.DataCriacao);
                    command.Parameters.AddWithValue("@DataUltimoAcesso", usuario.DataAlteracao ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Status", (int)usuario.Status);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar usuário: " + ex.Message);
                return false;
            }
        }

        public List<Usuario> ListarTodosUsuarios()
        {
            var usuarios = new List<Usuario>();

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Usuarios WHERE Status != @StatusExcluido;";
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StatusExcluido", (int)StatusEnum.Excluido);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                Id = reader.GetInt32("Id"),
                                NomeCompleto = reader.GetString("NomeCompleto"),
                                CPF = reader.GetString("CPF"),
                                Email = reader.GetString("Email"),
                                Senha = reader.GetString("Senha"),
                                DataCriacao = reader.GetDateTime("DataCadastro"),
                                DataAlteracao = reader.IsDBNull(reader.GetOrdinal("DataUltimoAcesso"))
                                    ? (DateTime?)null
                                    : reader.GetDateTime("DataUltimoAcesso"),
                                Status = (StatusEnum)reader.GetInt32("Status")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar usuários: " + ex.Message);
            }

            return usuarios;
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            Usuario usuario = null;

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Usuarios WHERE Id = @Id;";
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = reader.GetInt32("Id"),
                                NomeCompleto = reader.GetString("NomeCompleto"),
                                CPF = reader.GetString("CPF"),
                                Email = reader.GetString("Email"),
                                Senha = reader.GetString("Senha"),
                                DataCriacao = reader.GetDateTime("DataCadastro"),
                                DataAlteracao = reader.IsDBNull(reader.GetOrdinal("DataUltimoAcesso"))
                                    ? (DateTime?)null
                                    : reader.GetDateTime("DataUltimoAcesso"),
                                Status = (StatusEnum)reader.GetInt32("Status")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter usuário por ID: " + ex.Message);
            }

            return usuario;
        }

        public List<Usuario> FiltrarUsuariosPorStatus(StatusEnum status)
        {
            var usuarios = new List<Usuario>();

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Usuarios WHERE Status = @Status;";
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Status", (int)status);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                Id = reader.GetInt32("Id"),
                                NomeCompleto = reader.GetString("NomeCompleto"),
                                CPF = reader.GetString("CPF"),
                                Email = reader.GetString("Email"),
                                Senha = reader.GetString("Senha"),
                                DataCriacao = reader.GetDateTime("DataCadastro"),
                                DataAlteracao = reader.IsDBNull(reader.GetOrdinal("DataUltimoAcesso"))
                                    ? (DateTime?)null
                                    : reader.GetDateTime("DataUltimoAcesso"),
                                Status = (StatusEnum)reader.GetInt32("Status")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao filtrar usuários: " + ex.Message);
            }

            return usuarios;
        }

        public bool DeletarUsuario(int usuarioId)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Usuarios SET Status = @Status WHERE Id = @Id;";
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Status", (int)StatusEnum.Excluido);
                    command.Parameters.AddWithValue("@Id", usuarioId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao deletar usuário: " + ex.Message);
                return false;
            }
        }
        public List<Usuario> ObterUsuarios()
        {
            var usuarios = new List<Usuario>();

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Usuarios";
                    var command = new MySqlCommand(query, connection);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuario = new Usuario
                            {
                                Id = reader.GetInt32("Id"),
                                NomeCompleto = reader.GetString("Nome"),
                                Status = (StatusEnum)reader.GetInt32("Status")
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter usuários: " + ex.Message);
            }

            return usuarios;
        }
        public bool AtualizarUsuario(Usuario usuario)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE Usuarios SET
                    NomeCompleto = @NomeCompleto,
                    CPF = @CPF,
                    Email = @Email,
                    Senha = @Senha,
                    DataUltimoAcesso = @DataUltimoAcesso,
                    Status = @Status
                WHERE Id = @Id;";

                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NomeCompleto", usuario.NomeCompleto);
                    command.Parameters.AddWithValue("@CPF", usuario.CPF);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@Senha", usuario.Senha);
                    command.Parameters.AddWithValue("@DataUltimoAcesso", usuario.DataAlteracao ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Status", (int)usuario.Status);
                    command.Parameters.AddWithValue("@Id", usuario.Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar usuário: " + ex.Message);
                return false;
            }
        }

        public bool EmaiLExiste(string email)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(_connectionString))
                {
                    var comandoSql = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email;";
                    var parametros = new DynamicParameters();
                    parametros.Add("@Email", email);

                    var resultado = db.ExecuteScalar<int>(comandoSql, parametros);
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar se o e-mail existe: " + ex.Message);
                return false;
            }
        }

        public Usuario ObterUsuarioPorEmail(string email)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                var comandoSql = @"SELECT 
                                    id AS Id, 
                                    NomeCompleto AS Nome,
                                    CPF AS Cpf, 
                                    Senha AS Senha,     
                                    Email AS email,
                                    DataCadastro AS DataCriacao,
                                    dataUltimoAcesso AS DataUltimoAcesso, 
                                    Status AS Status
                                   FROM Usuarios 
                                   WHERE email = @Email";
                var parametros = new DynamicParameters();
                parametros.Add("@Email", email);
                var resultado = db.Query<Usuario>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }

        public bool AtualizarSenha(string novaSenha, string email)
        {
                using (IDbConnection db = new MySqlConnection(_connectionString))
                {
                var comandoSql = @"UPDATE Usuarios
                   SET Senha = @Senha
                   WHERE Email = @Email";

                var parametros = new DynamicParameters();
                    parametros.Add("@Senha", novaSenha);
                    parametros.Add("@Email", email);

                    var resposta = db.Execute(comandoSql, parametros);
                    return resposta > 0;
                }
        }
    }
}
