CREATE TABLE [dbo].[AccountAsset]
(
	[AssetID] BIGINT NOT NULL, 
    [ClientAccountID] UNIQUEIDENTIFIER NOT NULL, 
    [AssetHolderID] UNIQUEIDENTIFIER NOT NULL, 
    [TokensCount] BIGINT NOT NULL, 
    CONSTRAINT [PK_AccountAsset] PRIMARY KEY CLUSTERED ([AssetID] ASC), 
    CONSTRAINT [FK_AccountAsset_ClientAccount] FOREIGN KEY ([ClientAccountID]) REFERENCES [dbo].[ClientAccount]([ClientAccountID]), 
    CONSTRAINT [FK_AccountAsset_AssetHolder] FOREIGN KEY ([AssetHolderID]) REFERENCES [dbo].[AssetHolder]([AssetHolderID])
)
