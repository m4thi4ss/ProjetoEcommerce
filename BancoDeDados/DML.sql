-- DML - Inserir, alterar ou apagar dados 

-- INSERT INTO (Linguagem de Manipulacao de Dados)- Ele serve para inserir dados na tabela.
USE ECommerce

INSERT INTO Produto (Nome, Descricao, Preco, EstoqueDisponivel, Categoria, Imagem)
VALUES
('Mouse', 'Mouse Logitech', 99.90, 50, 'Informatica', ''),
('Teclado', 'Teclado Dell', 209.50, 100, 'Informatica', '')

--Lembrando que texto ou palavras e igual string, precisa ter os '' e os numeros nao precisa.

INSERT INTO Cliente (NomeCompleto, Email, Telefone, Endereco, DataCasdatro)
VALUES
('Vinicio Santos', 'vinicio@senai.br', '(11) 999994444', 'Rua Niteroi, 180 - Sao Paulo/SP', '04/05/2025'),
('Saulo Santos', 'saulo@senai.br', '(11)22222333444', 'Rua Niteroi, 250 - Sao Paulo/SP', '01/05/2025')

INSERT INTO Pedido (IdCliente,DataPedido , Status, ValorTotal)
VALUES
(1, '06/05/2022', 'Processando', 3200.99),
(2, '10/05/2022', 'Concluido', 450.90)

INSERT INTO Pagamento (IdPedido, FormaDePagamento, Status, Data)
VALUES
(1, 'Cartao de Credito', 'Aprovado', '08/05/2023 12:30:00'),
(2, 'Boleto', 'Aprovado', '18/05/2023 16:30:00')

INSERT INTO ItemPedido(IdPedido, IdProduto, Quantidade)
VALUES
(2, 1, 2),
(2, 2, 1),
(2, 1, 1)

/*
DELETE FROM Cliente WHERE NomeCompleto = 'Vinicio Santos';
Esse serve para deletar a informacao que e o Vinicio Santos 
/*