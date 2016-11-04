CREATE TABLE [dbo].[Produto]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Descricao] TEXT NULL, 
    [Titulo] NVARCHAR(250) NOT NULL, 
    [DataCadastro] DATETIME NOT NULL, 
    [Valor] DECIMAL NOT NULL, 
    [Nacional] BIT NOT NULL
)
