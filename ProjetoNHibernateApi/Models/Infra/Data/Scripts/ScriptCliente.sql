USE [clienteDB]

CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf][varchar](11) NOT NULL,
	[datanascimento] [varchar](10) NOT NULL,
	[email] [varchar](50) NULL,
	[divida] [interger] null
	
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
([id] ASC)
)


INSERT INTO cliente (nome, cpf, datanascimento,email,divida) values ('joao','111.111.111-11','22/04/1999','joao@email.com',150)
INSERT INTO cliente (nome, cpf, datanascimento,email,divida) values ('jose','222.222.222-22','22/05/1998','jose@email.com',120)
INSERT INTO cliente (nome, cpf, datanascimento,email,divida) values ('maria','333.333.333-33','24/06/1997','maria@email.com',90)


