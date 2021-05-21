CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [loginUser] NVARCHAR(50) NOT NULL, 
    [carName] NVARCHAR(100) NOT NULL, 
    [dataOrder] NVARCHAR(50) NOT NULL,
	FOREIGN KEY (loginUser) REFERENCES Users(login),
	FOREIGN KEY (carName) REFERENCES Cars(name)
)
