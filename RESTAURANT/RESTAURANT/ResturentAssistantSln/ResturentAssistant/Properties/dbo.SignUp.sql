CREATE TABLE [dbo].[SignUp] (
    [ID]          INT           NOT NULL,
    [UserType]    NVARCHAR (50) NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [PassWord]    NVARCHAR (50) NULL,
    [PhoneNumber] NVARCHAR (50) NULL,
    [Gmail]       NVARCHAR (50) NULL,
    [City]        NVARCHAR (50) NULL,
    CONSTRAINT [PK_SignUp] PRIMARY KEY CLUSTERED ([Name])
);

