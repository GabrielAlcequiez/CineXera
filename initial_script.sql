CREATE DATABASE [CineXeraDB]
GO

USE [CineXeraDB]

CREATE TABLE [Client] (
  [ID] uniqueidentifier PRIMARY KEY NOT NULL,
  [Name] nvarchar(100) NOT NULL,
  [Email] varchar(100) UNIQUE NOT NULL,
  [Username] varchar(50) UNIQUE NOT NULL,
  [Password_Hash] varchar(255) NOT NULL
)
GO

CREATE TABLE [Category] (
  [ID] uniqueidentifier PRIMARY KEY NOT NULL,
  [Name] varchar(100) NOT NULL
)
GO

CREATE TABLE [Movie_Category] (
  [Category_ID] uniqueidentifier NOT NULL,
  [Movie_ID] uniqueidentifier NOT NULL,
  PRIMARY KEY ([Movie_ID], [Category_ID])
)
GO

CREATE TABLE [Movie] (
  [ID] uniqueidentifier PRIMARY KEY NOT NULL,
  [Name] varchar(200) NOT NULL,
  [Description] nvarchar(500) NOT NULL,
  [Duration] smallint NOT NULL
)
GO

CREATE TABLE [Reservation] (
  [ID] uniqueidentifier PRIMARY KEY NOT NULL,
  [Created_At] datetime2(3) NOT NULL DEFAULT (SYSUTCDATETIME()),
  [Status] varchar(20) NOT NULL,
  [Screening_ID] uniqueidentifier NOT NULL,
  [Client_ID] uniqueidentifier NOT NULL
)
GO

CREATE TABLE [Screening] (
  [ID] uniqueidentifier PRIMARY KEY NOT NULL,
  [Start_Time] datetime2(0) NOT NULL,
  [End_Time] datetime2(0) NOT NULL,
  [Movie_ID] uniqueidentifier NOT NULL,
  [Auditorium_ID] uniqueidentifier NOT NULL
)
GO

CREATE TABLE [Reservation_Detail] (
  [ID] uniqueidentifier PRIMARY KEY NOT NULL,
  [Status] varchar(50) NOT NULL,
  [Blocked_Until] datetime2(3),
  [Reservation_ID] uniqueidentifier NOT NULL,
  [Seat_ID] uniqueidentifier NOT NULL
)
GO

CREATE TABLE [Auditorium] (
  [ID] uniqueidentifier PRIMARY KEY NOT NULL,
  [Name] varchar(50) NOT NULL
)
GO

CREATE TABLE [Seat] (
  [ID] uniqueidentifier PRIMARY KEY NOT NULL,
  [Row] varchar(2) NOT NULL,
  [Number] smallint NOT NULL,
  [Auditorium_ID] uniqueidentifier NOT NULL
)
GO

ALTER TABLE [Reservation] ADD FOREIGN KEY ([Client_ID]) REFERENCES [Client] ([ID])
GO

ALTER TABLE [Reservation] ADD FOREIGN KEY ([Screening_ID]) REFERENCES [Screening] ([ID])
GO

ALTER TABLE [Reservation_Detail] ADD FOREIGN KEY ([Reservation_ID]) REFERENCES [Reservation] ([ID])
GO

ALTER TABLE [Reservation_Detail] ADD FOREIGN KEY ([Seat_ID]) REFERENCES [Seat] ([ID])
GO

ALTER TABLE [Screening] ADD FOREIGN KEY ([Movie_ID]) REFERENCES [Movie] ([ID])
GO

ALTER TABLE [Screening] ADD FOREIGN KEY ([Auditorium_ID]) REFERENCES [Auditorium] ([ID])
GO

ALTER TABLE [Seat] ADD FOREIGN KEY ([Auditorium_ID]) REFERENCES [Auditorium] ([ID])
GO

ALTER TABLE [Movie_Category] ADD FOREIGN KEY ([Movie_ID]) REFERENCES [Movie] ([ID])
GO

ALTER TABLE [Movie_Category] ADD FOREIGN KEY ([Category_ID]) REFERENCES [Category] ([ID])
GO
