USE [BazaPoklona]
GO
/****** Object:  Table [dbo].[Poklon]    Script Date: 24.2.2021. 20:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poklon](
	[IdPoklon] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](40) NOT NULL,
	[VrstaRobe] [int] NOT NULL,
	[Kupljen] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPoklon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trgovina]    Script Date: 24.2.2021. 20:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trgovina](
	[IdTrgovina] [int] IDENTITY(1,1) NOT NULL,
	[NazivTrgovina] [nvarchar](40) NOT NULL,
	[VrstaRobe] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTrgovina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VrstaRobe]    Script Date: 24.2.2021. 20:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VrstaRobe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Poklon] ON 
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (1, N'Slatkiši(50kn)', 1, 1)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (2, N'Slatkiši(75kn)', 1, 1)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (3, N'Slatkiši(100kn)', 4, 1)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (4, N'M. Patike', 5, 1)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (5, N'Ž. Patike', 5, 0)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (6, N'M. Trenerka', 2, 0)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (7, N'Ž. Trenerka', 2, 0)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (8, N'Hennessy', 4, 0)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (9, N'Blue Label', 4, 0)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (10, N'PS4 Joystick', 7, 0)
GO
INSERT [dbo].[Poklon] ([IdPoklon], [Naziv], [VrstaRobe], [Kupljen]) VALUES (11, N'slambos', 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Poklon] OFF
GO
SET IDENTITY_INSERT [dbo].[Trgovina] ON 
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (1, N'Kaufland', 1)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (2, N'Lidl', 1)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (3, N'PolleoSport', 3)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (4, N'Intersport', 3)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (5, N'Kik', 2)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (6, N'Bershka', 2)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (7, N'Roto', 4)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (8, N'Teri', 4)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (9, N'Shooster', 5)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (10, N'Deichman', 5)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (11, N'DM', 6)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (12, N'Bipa', 6)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (13, N'Centar Tehnike', 7)
GO
INSERT [dbo].[Trgovina] ([IdTrgovina], [NazivTrgovina], [VrstaRobe]) VALUES (14, N'Pevex', 8)
GO
SET IDENTITY_INSERT [dbo].[Trgovina] OFF
GO
SET IDENTITY_INSERT [dbo].[VrstaRobe] ON 
GO
INSERT [dbo].[VrstaRobe] ([Id], [Naziv]) VALUES (1, N'Food')
GO
INSERT [dbo].[VrstaRobe] ([Id], [Naziv]) VALUES (2, N'Clothes')
GO
INSERT [dbo].[VrstaRobe] ([Id], [Naziv]) VALUES (3, N'Sport')
GO
INSERT [dbo].[VrstaRobe] ([Id], [Naziv]) VALUES (4, N'Drinks')
GO
INSERT [dbo].[VrstaRobe] ([Id], [Naziv]) VALUES (5, N'Shoes')
GO
INSERT [dbo].[VrstaRobe] ([Id], [Naziv]) VALUES (6, N'Make-up')
GO
INSERT [dbo].[VrstaRobe] ([Id], [Naziv]) VALUES (7, N'Tech')
GO
INSERT [dbo].[VrstaRobe] ([Id], [Naziv]) VALUES (8, N'HouseEqp')
GO
SET IDENTITY_INSERT [dbo].[VrstaRobe] OFF
GO
ALTER TABLE [dbo].[Poklon]  WITH CHECK ADD FOREIGN KEY([VrstaRobe])
REFERENCES [dbo].[VrstaRobe] ([Id])
GO
ALTER TABLE [dbo].[Trgovina]  WITH CHECK ADD FOREIGN KEY([VrstaRobe])
REFERENCES [dbo].[VrstaRobe] ([Id])
GO
