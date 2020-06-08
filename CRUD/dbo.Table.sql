CREATE TABLE [dbo].[Utilizadores]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] VARCHAR(50) NOT NULL, 
    [utilizador] VARCHAR(50) NOT NULL, 
    [senha] VARCHAR(50) NOT NULL, 
    [nivel] BIT NULL DEFAULT 0
)
