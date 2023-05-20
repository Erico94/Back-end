--EXERCICIO 1 ::Crie uma tabela chamada clientes, com os seguintes atributos: Id, Nome, Telefone, Endereco
CREATE TABLE CLIENTES (
ID INT PRIMARY KEY NOT NULL,
NOME VARCHAR (50) UNIQUE NOT NULL,
TELEFONE VARCHAR (11) NOT NULL,
ENDERECO VARCHAR (MAX) NOT NULL
)
--------------------------------------------------------------------------------------------------------------------------------------------------------------
/*EXERCICIO 2::Crie um script para inserir os seguintes clientes:
Id: 1, Nome: Vinicius Silva , Telefone: 987654, Endereco: Rua Girassol
Id: 2, Nome: Maria Antonia , Telefone: 123456 , Endereco: Rua Rosas
Id: 3, Nome: Marcus Vinicius , Telefone: 654123, Endereco: Rua Itajai
*/
INSERT INTO CLIENTES VALUES (1, 'Vinicius Silva', '987654', 'Rua Girassol'),
							(2, 'Maria Antonia', '123456', 'Rua Rosas'),
							(3, 'Marcus Vinicius', '654123', 'Rua Itajaí')
--------------------------------------------------------------------------------------------------------------------------------------------------------------
/*EXERCICIO 3::Crie um script que selecione todos os clientes.*/
SELECT * FROM CLIENTES
--------------------------------------------------------------------------------------------------------------------------------------------------------------
/*EXERCICIO 4::Crie um Script que selecione os clientes filtrando pelo campo Id*/
SELECT ID FROM CLIENTES
--------------------------------------------------------------------------------------------------------------------------------------------------------------
/*EXERCICIO 5::Crie um Script, que filtre os clientes utilizando o like '%%'*/
SELECT * FROM CLIENTES
WHERE NOME LIKE 'Mar%'
--------------------------------------------------------------------------------------------------------------------------------------------------------------
/*EXERCICIO 6::Crie um Script para atualizar o endereço do Marcus Vinicius para : Rua do Limão.*/	
UPDATE CLIENTES
SET ENDERECO = 'Rua do Limão'
WHERE NOME LIKE 'Marcu%'
-------------------------------------------------------------------------------------------------------------------------------------------------------------
/*EXERCICIO 7::Crie o Script para Excluir o cliente Id 2.*/
DELETE FROM CLIENTES
WHERE ID = 2