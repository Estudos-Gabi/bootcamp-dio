--SELECT COUNT(*)  QuantidadeProdutos FROM Produtos
---- Retorna a quantidade de linhas
-- SELECT COUNT(*)  QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'
-- SELECT SUM (Preco) PrecoTotal FROM Produtos
-- SELECT AVG (Preco) Media FROM Produtos 

-- SELECT 
--Nome + ' -- ' + Cor +' -- ' +  Genero NomeProduto
--FROM Produtos 

--SELECT 
--Nome + ' -- ' + Cor +' -- ' +  Genero NomeProduto,
--UPPER(Nome) Nome,
--LOWER(Cor) cor
--FROM Produtos 

--ALTER TABLE Produtos
--ADD DataCadastro DATETIME2

--UPDATE Produtos SET DataCadastro = GETDATE()

--SELECT Nome, Cor,
--FORMAT(DataCadastro, 'dd/MM/yyy HH:mm') Data
--FROM Produtos

--SELECT 
--Tamanho,
--COUNT(*) Quantidade 
--FROM Produtos 
--WHERE Tamanho <> ''
--GROUP BY Tamanho

--CREATE TABLE Enderecos (
--Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
--IdCliente int NULL,
--Rua varchar(255) NULL,
--Bairro varchar(255) NULL,
--Cidade varchar(255) NULL,
--Estado char(2) NULL,

--CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente) 
--REFERENCES Clientes(Id)
--)


--INSERT INTO Enderecos VALUES (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste','MG')


SELECT * FROM Clientes
SELECT * FROM Enderecos

SELECT 
*
FROM
	Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4