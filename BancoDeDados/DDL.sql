USE ECommerce
-- Linguagem SQL
-- Para comecar a programar no SQL voce precisa abrir uma nova consulta 

-- SQL - Structured Query Language
-- Linguagem de Consulta Estruturada (Sendo assim, nao e uma linguagem de programacao)

-- T-SQL, PL/SQL - Tem if else, funcoes.

-- O SQL ele funciona por comando, tendo 3 categorias principais 
-- DDL (Data Definition Languagem) - Criar, Alterar ou Apagar Banco de Dados e Tabelas. Ele serve somente para as tabelas e Banco de Dados,
--sendo assim o banco de dados seria um grupo de tabelas.
-- DML (Data Manipulation Language)- Criar, Alterar ou Apagar Dados. Ele serve somente para trabalhar com os dados do Banco de dados.
-- DQL (Data Query Language)- Ele serve para ver o que vai ter no banco de dados e nos dados.

--Hierarquia do Banco 
--Banco de dados --> Tabelas --> Colunas 

--Comando ( DROP ) ele serve para apagar aquilo que foi criado, nao importa o que seja. 
--Comando ( CREATE ) ele serve para criar o que voce quiser no Banco de dados. 
--Master - e o banco de dados padrao do SQL, nao e para usar ele, tem que usar o banco especifico.
--Comando ( USE ) - Ele serve para ajudar a nao esquecer de trocar o MASTER, ele e usado para mecher no banco ja criado. Por exemplo: USE ECommerce. Nao pode nunca esquecer
--de colocar o USE no comeco.
-- Sempre usar o singular, comecando com a letra maiuscula.
CREATE TABLE Cliente (
-- PRIMARY KEY - ELE USAR COMO IDENTIFICADOR DO CLIENTE, COMO POR EXEMPLO: CPF.
-- INDENTITY - GERADA AUTOMATICAMENTE, SERVE PARA QUANDO VIM AS INFORMACOES E ELE VAI COLOCAR 1, 2, 3 AUTOMATICAMENTE. ELE SO GERA SO SEQUENCIA DE NUMEROS 123456 
--E ASSIM POR DIANTE.
	IdCliente INT PRIMARY KEY IDENTITY, 
	NomeCompleto VARCHAR(150), 
	Email VARCHAR(100),
	Telefone VARCHAR(20),
	Endereco VARCHAR(255),
	DataCasdatro DATE
	); -- Tem que fechar e abrir parenteses, pois o SQL ele nao avisa, entao tem que ficar se nao funciona o codigo.

CREATE TABLE Pedido (
	IdPedido INT PRIMARY KEY IDENTITY,
	DataPedido DATE,
	Status VARCHAR(20),
	ValorTotal DECIMAL(18, 6),
	IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente)
);

CREATE TABLE Pagamento (
	IdPagamento INT PRIMARY KEY IDENTITY,
	IdPedido INT FOREIGN KEY REFERENCES Pedido(IdPedido),
	FormaDePagamento INT,
	Status VARCHAR(20), 
	Data DATETIME
);
CREATE TABLE Produto (
	IdProduto INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(150),
	Descricao VARCHAR(255),
	Preco DECIMAL(18 , 6),
	EstoqueDisponivel INT,
	Categoria VARCHAR(100),
	Imagem VARCHAR(255),
);

CREATE TABLE ItemPedido (
	IdItemPedido INT PRIMARY KEY IDENTITY,
	IdPedido INT FOREIGN KEY REFERENCES Pedido(IdPedido),
	IdProduto INT FOREIGN KEY REFERENCES Produto(IdProduto),
	Quantidade INT,
);

--Para fazer o delte de uma tabela voce precisa verifica se tem uma referencia, se tiver voce tem que apagar. Para apagar tabela, voce tem que seguir uma ordem, 
--a ordem seria o que tem mais referencia. 
--Aqui ele serve para que voce so escreva as coisas que voce quer ordernar para guardar no Banco de dados, entao nao importa o que voce vai escrever no aqui, 
--se voce nao selecionar e executar nao vai acontecer nada. 

/*
DROP TABLE ItemPedido;
DROP TABLE Pagamento;
DROP TABLE Pedido;
DROP TABLE Produto;
DROP TABLE Cliente;
*/

--Esse DROP TABLE ele vai excluir a tabela que foi informada, ele serve para quando voce vai alterar alguma coisa na tabela, ai voce vai apagar a tabela completa
--pra colocar a alteracao que foi feita, selecionar a tabela com a alteracao e executar. Lembrando que a Ordem do DROP TABLE tem que ser feita pelo o que tem mais
--referencias, e as ordens das tabelas tambem sao feitas dessa forma. Para apagar uma voce tem que apagar as que estao acima de voce, como por exemplo: se for apagar
--Pagamento voce tem que executar a Item pedido tamebem.








