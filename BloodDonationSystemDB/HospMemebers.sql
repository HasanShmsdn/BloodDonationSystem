CREATE TABLE [dbo].[HospMemebers]
(
	[MembId] INT NOT NULL PRIMARY KEY, 
    [MembName] NCHAR(10) NULL, 
    [MembPosition] NCHAR(10) NULL, 
    [MembPhone] NCHAR(10) NULL, 
    [MembEmail] NCHAR(10) NULL, 
    [HospId] INT NULL, 
    [Password] NVARCHAR(50) NULL, 
    [Lastlogin] DATETIME NULL, 
    [IsAdmin] BIT NULL
)
