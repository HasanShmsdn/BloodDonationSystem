CREATE TABLE [dbo].[Clients]
(
	[ClientId] INT NOT NULL PRIMARY KEY, 
    [ClientName] NCHAR(10) NULL, 
    [ClientPhoneNb] NCHAR(10) NULL, 
    [ClientLocation] NCHAR(10) NULL, 
    [ClientRegistration] BIT NULL, 
    [ClientBloodType] NCHAR(10) NULL, 
    [UuId] NCHAR(10) NULL
)
