USE SISTEMADEVENDAS
GO

select * from FUNCIONARIO

CREATE TABLE CLIENTE (
		id_cliente int not null identity primary key,
		cnpj_cliente int not null unique,
		nome_cliente varchar(50) not null,
		telefone1_cliente char(14) not null,
		logradouro_cliente varchar(100) not null,
		numero_cliente varchar(1000) null,
		bairro_cliente varchar(40) not null,
		cidade_cliente varchar(40) not null,
		uf_cliente char(2) not null,
		cep_cliente char(9) not null,
		dtdecadatro_cliente datetime NOT NULL DEFAULT getdate(),  
)

CREATE TABLE FUNCIONARIO (
		id_funcionario int not null identity primary key,
		cpf_funcionario int not null unique,
		rg_funcionario int not null unique,
		nome_funcionario varchar(50) not null,
		login_funcionario varchar(50)not null,
		senha_funcionario varchar(50) not null,
		logradouro_funcionario varchar(100) not null,
		numero_funcionario varchar(1000) null,
		bairro_funcionario varchar(40) not null,
		cidade_funcionario varchar(40) not null,
		uf_funcionario char(2) not null,
		cep_funcionario char(9) not null,
		dtdecadatro_funcionario datetime NOT NULL DEFAULT getdate(),  
)

CREATE TABLE PRODUTO 
( 
	id_produto int not null identity primary key,  
	nome_produto varchar(50) not null, 
	img_produto varchar(max) null,
	qtdeestoque_produto int not null,  
	preco_produto decimal(10,2) not null,  
	descricao_produto varchar(255) null,  
)

CREATE TABLE SOLICITACAO 
( 
	id_solicitacao INT PRIMARY KEY,  
	id_funcionario_solicitacao int not null,  
	id_cliente_solicitacao int not null,  
	idproduto_solicitacao int not null, 
	status_solicitacao varchar(15), 
	descricao_solicitacao varchar(255) null,  
	dtdecadatro_funcionario datetime NOT NULL DEFAULT getdate(),    
)

CREATE TABLE CONTEM 
( 
 id_solicitacao_contem INT PRIMARY KEY,  
 id_produto_contem INT,  
)

CREATE TABLE alteracaoProduto(
	id_produto_alt int not null,
	nome_produto_alt varchar(50) not null,
	qtdeestoque_produto int not null,
	datadealteracao_produto_alt datetime NOT NULL
)

CREATE TABLE alteracaoSolicitacao(
	id_solicitacao_alt int not null,
	status_solicitacao_alt int not null,
	datadealteracao_solicitacao_alt datetime NOT NULL
)

drop table data_alteracaoProduto
drop table data_alteracaoSolicitacao

ALTER TABLE SOLICITACAO ADD FOREIGN KEY(id_cliente_solicitacao) REFERENCES CLIENTE (id_cliente)
ALTER TABLE SOLICITACAO ADD FOREIGN KEY(id_funcionario_solicitacao) REFERENCES FUNCIONARIO (id_funcionario)
ALTER TABLE CONTEM ADD FOREIGN KEY(id_solicitacao_contem) REFERENCES SOLICITACAO (id_solicitacao)
ALTER TABLE CONTEM ADD FOREIGN KEY(id_produto_contem) REFERENCES PRODUTO (id_produto)