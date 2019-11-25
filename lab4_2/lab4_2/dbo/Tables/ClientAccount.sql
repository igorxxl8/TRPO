CREATE TABLE [dbo].[ClientAccount]
(
	[ClientAccountID] UNIQUEIDENTIFIER NOT NULL, 
    [ClientID] UNIQUEIDENTIFIER NOT NULL, 
    [FiatMoney] MONEY NOT NULL, 
    CONSTRAINT [PK_ClientAccount] PRIMARY KEY CLUSTERED ([ClientAccountID] ASC), 
    CONSTRAINT [FK_ClientAccount_Client] FOREIGN KEY ([ClientID]) REFERENCES [dbo].[Client]([ClientID])
)
