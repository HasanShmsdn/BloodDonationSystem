CREATE TABLE [dbo].[HospMemebers] (
    [MembId]       INT           NOT NULL,
    [MembName]     NCHAR (10)    NULL,
    [MembPosition] NCHAR (10)    NULL,
    [MembPhone]    NCHAR (10)    NULL,
    [MembEmail]    NCHAR (10)    NULL,
    [HospId]       INT           NULL,
    [Password]     NVARCHAR (50) NULL,
    [Lastlogin]    DATETIME      NULL,
    [IsAdmin]      BIT           NULL,
    PRIMARY KEY CLUSTERED ([MembId] ASC),
    CONSTRAINT [FK_HospMemebers_HospitalDetails] FOREIGN KEY ([HospId]) REFERENCES [dbo].[HospitalDetails] ([HospId])
);


