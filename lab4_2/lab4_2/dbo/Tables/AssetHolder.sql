CREATE TABLE [dbo].[AssetHolder]
(
	[AssetHolderID] UNIQUEIDENTIFIER NOT NULL, 
    [CompanyName] VARCHAR(50) NOT NULL, 
    [AvailaibleTokens] BIGINT NOT NULL, 
    CONSTRAINT [PK_AssetHolder] PRIMARY KEY ([AssetHolderID])
)
