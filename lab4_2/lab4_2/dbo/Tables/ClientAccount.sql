CREATE TABLE [dbo].[ClientAccount]
(
	[ClientAccountID] UNIQUEIDENTIFIER NOT NULL, 
    [ClientID] UNIQUEIDENTIFIER NOT NULL, 
    [AccountMoney] MONEY NOT NULL, 
    [AccountName] VARCHAR(30) NOT NULL, 
    CONSTRAINT [PK_ClientAccount] PRIMARY KEY CLUSTERED ([ClientAccountID] ASC), 
    CONSTRAINT [FK_ClientAccount_Client] FOREIGN KEY ([ClientID]) REFERENCES [dbo].[Client]([ClientID])
)
