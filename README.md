CÓDIGO Do MYSQL

CREATE DATABASE clientes_unip;
USE clientes_unip;

SELECT * FROM pessoas;
DROP TABLE pessoas;

CREATE TABLE pessoas(
id int AUTO_INCREMENT PRIMARY KEY,
nome varchar(255) NOT NULL,
cpf bigint NOT NULL,
logradouro varchar(255) NOT NULL,
numero bigint NOT NULL,
cep bigint NOT NULL,
bairro varchar(255) NOT NULL,
cidade varchar(255) NOT NULL,
estado varchar(255) NOT NULL,
telefone bigint NOT NULL
);
