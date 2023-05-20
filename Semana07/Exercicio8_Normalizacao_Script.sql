                 ------TABELA N�O NORMALIZADA:-------

CREATE TABLE FUNCIONARIOS_NFN (
ID			INT NOT NULL PRIMARY KEY,
NOME		VARCHAR (20) NOT NULL,
CARGO		VARCHAR (20) NOT NULL,
TELEFONE1	VARCHAR (11),
TELEFONE2	VARCHAR (11)
)
GO
INSERT INTO FUNCIONARIOS_NFN (ID, NOME, CARGO, TELEFONE1, TELEFONE2) VALUES 
(1, 'Marcos', 'Atendente', '3654589', '36545987'),
(2, 'Maria', 'Gerente', '3654698', '36524569'),
(3, 'Julia', 'Atendente', '3654962', '12365458')

SELECT * FROM FUNCIONARIOS_NFN


                              ----PRIMEIRA FN:------

CREATE TABLE FUNCIONARIO_FN1(
ID		INT PRIMARY KEY NOT NULL,
NOME	VARCHAR (20) UNIQUE NOT NULL,
CARGO	VARCHAR (20) NOT NULL
)
GO 
INSERT INTO FUNCIONARIO_FN1 VALUES (1, 'Marcos', 'Atendente') , (2, 'Maria', 'Gerente'), (3, 'julia', 'Atendente')
GO 

CREATE TABLE TELEFONES_FN1 (
ID_FUNCIONARIO INT REFERENCES FUNCIONARIO_FN1 (ID) NOT NULL,
TELEFONE VARCHAR (11) NOT NULL UNIQUE
)
GO
INSERT INTO TELEFONES_FN1 VALUES (1, '3654589') , (1, '36545987'), (2, '3654698') , (2,'36524569'), (3, '3654962'), (3,'12365458')
GO
SELECT * FROM FUNCIONARIO_FN1
SELECT * FROM TELEFONES_FN1

                              -- SEGUNDA FN: --------
--N�o encontrei dados onde se pode ser aplicada a segunda forma normal

                              -----TERCEIRA FN:-------

CREATE TABLE CARGOS_FN3 (
ID		INT PRIMARY KEY,
CARGO	VARCHAR (20)
)
GO
INSERT INTO CARGOS_FN3 VALUES (1, 'Gerente') , (2, 'Atendente')
GO


CREATE TABLE FUNCIONARIOS_FN3 (
ID			INT NOT NULL PRIMARY KEY,
NOME		VARCHAR (20) NOT NULL,
ID_CARGO	INT REFERENCES CARGOS_FN3 (ID),
)
GO
INSERT INTO FUNCIONARIOS_FN3 (ID, NOME, ID_CARGO) VALUES 
(1, 'Marcos', 2),
(2, 'Maria', 1),
(3, 'Julia', 2)
GO

CREATE TABLE TELEFONES_FN3 (
ID_FUNCIONARIO	INT REFERENCES FUNCIONARIOS_FN3 (ID),
TELEFONE		VARCHAR (20) NOT NULL UNIQUE,
)
GO
INSERT INTO TELEFONES_FN3 VALUES(1, 3654589),
								(1, 36545987),
								(2, 3654698),
								(2, 36524569),
								(3, 3654962),
								(3, 12365458)
GO
SELECT * FROM FUNCIONARIOS_FN3
SELECT * FROM TELEFONES_FN3
SELECT * FROM CARGOS_FN3



