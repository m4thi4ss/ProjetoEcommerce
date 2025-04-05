-- DML - Inserir, alterar ou apagar dados 

-- INSERT INTO (Linguagem de Manipulacao de Dados)- Ele serve para inserir dados na tabela.
USE ECommerce

INSERT INTO Produto (Nome, Descricao, Preco, EstoqueDisponivel, Categoria, Imagem)
VALUES
('Mouse', 'Mouse Logitech', 99.90, 50, 'Informatica', ''),
('Teclado', 'Teclado Dell', 209.50, 100, 'Informatica', '')

--Lembrando que texto ou palavras e igual string, precisa ter os '' e os numeros nao precisa.