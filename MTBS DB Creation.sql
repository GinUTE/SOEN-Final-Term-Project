CREATE DATABASE [MTBS]
GO

USE [MTBS]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[phone] [varchar](15) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[last_seen] [datetime] NOT NULL,
	[join_date] [datetime] NOT NULL,
 CONSTRAINT [tblAccount_PK] PRIMARY KEY CLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAuditorium]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAuditorium](
	[auditorium_id] [int] IDENTITY(1,1) NOT NULL,
	[auditorium_name] [nvarchar](32) NOT NULL,
	[seat_num] [smallint] NOT NULL,
 CONSTRAINT [tblAuditorium_PK] PRIMARY KEY CLUSTERED 
(
	[auditorium_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGenre]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGenre](
	[genre_id] [int] IDENTITY(1,1) NOT NULL,
	[genre_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [tblGenre_PK] PRIMARY KEY CLUSTERED 
(
	[genre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMovie]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMovie](
	[movie_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](100) NOT NULL,
	[director] [nvarchar](100) NOT NULL,
	[release_date] [date] NOT NULL,
	[runtime] [smallint] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
 CONSTRAINT [tblMovie_PK] PRIMARY KEY CLUSTERED 
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMovieGenre]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMovieGenre](
	[movie_id] [int] NOT NULL,
	[genre_id] [int] NOT NULL,
 CONSTRAINT [tblMovieGenre_PK] PRIMARY KEY CLUSTERED 
(
	[movie_id] ASC,
	[genre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblReservation]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReservation](
	[reservation_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_phone] [varchar](15) NOT NULL,
	[screening_id] [int] NOT NULL,
	[is_paid] [bit] NOT NULL,
	[is_active] [bit] NOT NULL,
 CONSTRAINT [tblBookingRecord_PK] PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblReservedSeat]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReservedSeat](
	[reserved_seat_id] [int] IDENTITY(1,1) NOT NULL,
	[seat_id] [int] NOT NULL,
	[reservation_id] [int] NOT NULL,
	[screening_id] [int] NOT NULL,
 CONSTRAINT [tblReservedSeat_PK] PRIMARY KEY CLUSTERED 
(
	[reserved_seat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRole]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRole](
	[role] [nvarchar](50) NOT NULL,
	[role_description] [nvarchar](100) NOT NULL,
 CONSTRAINT [tblRole_PK] PRIMARY KEY CLUSTERED 
(
	[role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblScreening]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblScreening](
	[screening_id] [int] IDENTITY(1,1) NOT NULL,
	[movie_id] [int] NOT NULL,
	[auditorium_id] [int] NOT NULL,
	[showtime] [datetime] NOT NULL,
 CONSTRAINT [tblScreening_PK] PRIMARY KEY CLUSTERED 
(
	[screening_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSeat]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSeat](
	[seat_id] [int] IDENTITY(1,1) NOT NULL,
	[auditorium_id] [int] NOT NULL,
	[row] [char](1) NOT NULL,
	[number] [tinyint] NOT NULL,
	[seat_category_id] [int] NOT NULL,
 CONSTRAINT [tblSeat_PK] PRIMARY KEY CLUSTERED 
(
	[seat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSeatCategory]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSeatCategory](
	[seat_category_id] [int] IDENTITY(1,1) NOT NULL,
	[seat_category_name] [nvarchar](10) NOT NULL,
	[price] [decimal](6, 0) NOT NULL,
 CONSTRAINT [tblSeatCategory_PK] PRIMARY KEY CLUSTERED 
(
	[seat_category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThumbnail]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThumbnail](
	[movie_id] [int] NOT NULL,
	[thumbnail] [varbinary](max) NOT NULL,
 CONSTRAINT [tblMovieThumbnail_PK] PRIMARY KEY CLUSTERED 
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[phone] [varchar](15) NOT NULL,
	[fullname] [nvarchar](70) NOT NULL,
	[is_male] [bit] NOT NULL,
	[birth] [date] NOT NULL,
	[email] [varchar](70) NOT NULL,
	[city] [nvarchar](35) NOT NULL,
 CONSTRAINT [tblUser_PK] PRIMARY KEY CLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUserRole]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserRole](
	[phone] [varchar](15) NOT NULL,
	[role] [nvarchar](50) NOT NULL,
 CONSTRAINT [tblUserRole_PK] PRIMARY KEY CLUSTERED 
(
	[phone] ASC,
	[role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblAccount] ADD  DEFAULT (sysdatetime()) FOR [last_seen]
GO
ALTER TABLE [dbo].[tblAccount] ADD  DEFAULT (sysdatetime()) FOR [join_date]
GO
ALTER TABLE [dbo].[tblReservation] ADD  DEFAULT ((0)) FOR [is_paid]
GO
ALTER TABLE [dbo].[tblReservation] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[tblAccount]  WITH CHECK ADD  CONSTRAINT [tblAccount_FK] FOREIGN KEY([phone])
REFERENCES [dbo].[tblUser] ([phone])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblAccount] CHECK CONSTRAINT [tblAccount_FK]
GO
ALTER TABLE [dbo].[tblMovieGenre]  WITH CHECK ADD  CONSTRAINT [tblMovieGenre_FK{01}] FOREIGN KEY([movie_id])
REFERENCES [dbo].[tblMovie] ([movie_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblMovieGenre] CHECK CONSTRAINT [tblMovieGenre_FK{01}]
GO
ALTER TABLE [dbo].[tblMovieGenre]  WITH CHECK ADD  CONSTRAINT [tblMovieGenre_FK{02}] FOREIGN KEY([genre_id])
REFERENCES [dbo].[tblGenre] ([genre_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblMovieGenre] CHECK CONSTRAINT [tblMovieGenre_FK{02}]
GO
ALTER TABLE [dbo].[tblReservation]  WITH CHECK ADD  CONSTRAINT [tblReservation_FK{01}] FOREIGN KEY([customer_phone])
REFERENCES [dbo].[tblUser] ([phone])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblReservation] CHECK CONSTRAINT [tblReservation_FK{01}]
GO
ALTER TABLE [dbo].[tblReservation]  WITH CHECK ADD  CONSTRAINT [tblReservation_FK{02}] FOREIGN KEY([screening_id])
REFERENCES [dbo].[tblScreening] ([screening_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblReservation] CHECK CONSTRAINT [tblReservation_FK{02}]
GO
ALTER TABLE [dbo].[tblReservedSeat]  WITH CHECK ADD  CONSTRAINT [tblReservedSeat_FK{01}] FOREIGN KEY([seat_id])
REFERENCES [dbo].[tblSeat] ([seat_id])
GO
ALTER TABLE [dbo].[tblReservedSeat] CHECK CONSTRAINT [tblReservedSeat_FK{01}]
GO
ALTER TABLE [dbo].[tblReservedSeat]  WITH CHECK ADD  CONSTRAINT [tblReservedSeat_FK{02}] FOREIGN KEY([reservation_id])
REFERENCES [dbo].[tblReservation] ([reservation_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblReservedSeat] CHECK CONSTRAINT [tblReservedSeat_FK{02}]
GO
ALTER TABLE [dbo].[tblReservedSeat]  WITH CHECK ADD  CONSTRAINT [tblReservedSeat_FK{03}] FOREIGN KEY([screening_id])
REFERENCES [dbo].[tblScreening] ([screening_id])
GO
ALTER TABLE [dbo].[tblReservedSeat] CHECK CONSTRAINT [tblReservedSeat_FK{03}]
GO
ALTER TABLE [dbo].[tblScreening]  WITH CHECK ADD  CONSTRAINT [tblScreening_FK{01}] FOREIGN KEY([movie_id])
REFERENCES [dbo].[tblMovie] ([movie_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblScreening] CHECK CONSTRAINT [tblScreening_FK{01}]
GO
ALTER TABLE [dbo].[tblScreening]  WITH CHECK ADD  CONSTRAINT [tblScreening_FK{02}] FOREIGN KEY([auditorium_id])
REFERENCES [dbo].[tblAuditorium] ([auditorium_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblScreening] CHECK CONSTRAINT [tblScreening_FK{02}]
GO
ALTER TABLE [dbo].[tblSeat]  WITH CHECK ADD  CONSTRAINT [tblSeat_FK{01}] FOREIGN KEY([auditorium_id])
REFERENCES [dbo].[tblAuditorium] ([auditorium_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSeat] CHECK CONSTRAINT [tblSeat_FK{01}]
GO
ALTER TABLE [dbo].[tblSeat]  WITH CHECK ADD  CONSTRAINT [tblSeat_FK{02}] FOREIGN KEY([seat_category_id])
REFERENCES [dbo].[tblSeatCategory] ([seat_category_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSeat] CHECK CONSTRAINT [tblSeat_FK{02}]
GO
ALTER TABLE [dbo].[tblThumbnail]  WITH CHECK ADD  CONSTRAINT [tblMovieThumbnail_FK] FOREIGN KEY([movie_id])
REFERENCES [dbo].[tblMovie] ([movie_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblThumbnail] CHECK CONSTRAINT [tblMovieThumbnail_FK]
GO
ALTER TABLE [dbo].[tblUserRole]  WITH CHECK ADD  CONSTRAINT [tblUserRole_FK{01}] FOREIGN KEY([phone])
REFERENCES [dbo].[tblAccount] ([phone])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblUserRole] CHECK CONSTRAINT [tblUserRole_FK{01}]
GO
ALTER TABLE [dbo].[tblUserRole]  WITH CHECK ADD  CONSTRAINT [tblUserRole_FK{02}] FOREIGN KEY([role])
REFERENCES [dbo].[tblRole] ([role])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblUserRole] CHECK CONSTRAINT [tblUserRole_FK{02}]
GO
/****** Object:  StoredProcedure [dbo].[usp_CountUserAccount]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CountUserAccount]
@phone VARCHAR(15),
@password VARCHAR(50)
AS
BEGIN
SELECT COUNT(*) FROM [tblAccount] WHERE [phone] = @phone AND [password] = @password
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CountUserPhone]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CountUserPhone]
@phone VARCHAR(15)
AS
BEGIN
SELECT COUNT(*) FROM [tblAccount] WHERE [phone] = @phone
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateUserAccount]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CreateUserAccount]
@phone VARCHAR(15),
@fullname NVARCHAR(70),
@is_male BIT,
@birth DATE,
@email VARCHAR(70),
@city NVARCHAR(35),
@password VARCHAR(50)
AS
BEGIN
	INSERT INTO [tblUser] ([phone], [fullname], [is_male], [birth], [email], [city]) VALUES (@phone, @fullname, @is_male, @birth, @email, @city)
	INSERT INTO [tblAccount] ([phone], [password]) VALUES (@phone, @password)
	INSERT INTO [tblUserRole] ([phone], [role]) VALUES (@phone, 'user')
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUserRole]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetUserRole] @phone VARCHAR(15)
AS
BEGIN
SELECT [role]
FROM [tblUserRole]
WHERE [phone] = @phone
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateAccountLastSeen]    Script Date: 08-Dec-22 18:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_UpdateAccountLastSeen] @phone VARCHAR(15)
AS
BEGIN
UPDATE [tblAccount] SET [last_seen] = GETDATE() WHERE [phone] = @phone
END
GO
