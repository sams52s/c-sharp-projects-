﻿CREATE TABLE [dbo].[SignUp] (
    [Id]          INT NOT NULL,
    [name]        NVARCHAR (50) NULL,
    [password]    NVARCHAR (50) NULL,
    [mail]        NVARCHAR (50) NULL,
    [Phonenumber] NVARCHAR (50) NULL,
    [UserType]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

