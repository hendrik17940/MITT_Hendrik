CREATE TABLE [dbo].[UserProfile]
(
	[username] NVARCHAR(50) NOT NULL, 
    [name] VARCHAR(50) NULL, 
    [address] NVARCHAR(500) NULL, 
    [bod] DATE NULL, 
    [email] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_UserProfile_ToUser] FOREIGN KEY ([username]) REFERENCES [User]([username]) 
)
