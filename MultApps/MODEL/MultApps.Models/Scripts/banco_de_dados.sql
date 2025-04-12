CREATE DATABASE IF NOT EXISTS multapps_dev;

USE multapps_dev;

CREATE TABLE IF NOT EXISTS Categoria (
  Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(250) NOT NULL,
  DataCriacao TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  DataAlteracao TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  status ENUM('ativo', 'inativo', 'excluido') NOT NULL
);

CREATE TABLE IF NOT EXISTS Produto (
  Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,  -- Make sure only this column is AUTO_INCREMENT
  Nome VARCHAR(250) NOT NULL,
  Categoria_Id INT NOT NULL,
  Preco DECIMAL NOT NULL,
  Quantidade_Estoque INT NOT NULL,
  DataCriacao TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  DataAlteracao TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  status ENUM('ativo', 'inativo', 'excluido') NOT NULL,
  FOREIGN KEY (Categoria_Id) REFERENCES Categoria(Id)
);
