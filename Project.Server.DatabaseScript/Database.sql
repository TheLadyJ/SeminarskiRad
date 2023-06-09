USE [master]
GO
/****** Object:  Database [SeminarskiRad]    Script Date: 20-Jun-23 14:59:19 ******/
CREATE DATABASE [SeminarskiRad]
GO
ALTER DATABASE [SeminarskiRad] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SeminarskiRad] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SeminarskiRad] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SeminarskiRad] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SeminarskiRad] SET ARITHABORT OFF 
GO
ALTER DATABASE [SeminarskiRad] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SeminarskiRad] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SeminarskiRad] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SeminarskiRad] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SeminarskiRad] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SeminarskiRad] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SeminarskiRad] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SeminarskiRad] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SeminarskiRad] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SeminarskiRad] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SeminarskiRad] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SeminarskiRad] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SeminarskiRad] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SeminarskiRad] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SeminarskiRad] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SeminarskiRad] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SeminarskiRad] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SeminarskiRad] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SeminarskiRad] SET  MULTI_USER 
GO
ALTER DATABASE [SeminarskiRad] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SeminarskiRad] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SeminarskiRad] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SeminarskiRad] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SeminarskiRad] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SeminarskiRad] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SeminarskiRad] SET QUERY_STORE = OFF
GO
USE [SeminarskiRad]
GO
/****** Object:  Table [dbo].[KeteringFirma]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeteringFirma](
	[KeteringFirmaID] [int] IDENTITY(1,1) NOT NULL,
	[NazivFirme] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_KeteringFirma] PRIMARY KEY CLUSTERED 
(
	[KeteringFirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KeteringMeni]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeteringMeni](
	[KeteringMeniID] [int] IDENTITY(1,1) NOT NULL,
	[Predjelo] [varchar](50) NOT NULL,
	[GlavnoJelo] [varchar](50) NOT NULL,
	[Dezert] [varchar](50) NOT NULL,
	[CenaHranePoOsobi] [float] NOT NULL,
	[KeteringFirmaID] [int] NOT NULL,
 CONSTRAINT [PK_KeteringMeni] PRIMARY KEY CLUSTERED 
(
	[KeteringMeniID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Klijent]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klijent](
	[KlijentID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Klijent] PRIMARY KEY CLUSTERED 
(
	[KlijentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesto]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesto](
	[MestoID] [int] IDENTITY(1,1) NOT NULL,
	[Grad] [varchar](50) NOT NULL,
	[PostanskiBroj] [varchar](50) NOT NULL,
	[Adresa] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Mesto] PRIMARY KEY CLUSTERED 
(
	[MestoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proizvodjac]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvodjac](
	[ProizvodjacID] [int] IDENTITY(1,1) NOT NULL,
	[NazivProizvodjaca] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Proizvodjac] PRIMARY KEY CLUSTERED 
(
	[ProizvodjacID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnik](
	[RadnikID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Lozinka] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Radnik] PRIMARY KEY CLUSTERED 
(
	[RadnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[RezervacijaID] [int] IDENTITY(1,1) NOT NULL,
	[DatumVremeOd] [datetime] NOT NULL,
	[TipProslaveID] [int] NOT NULL,
	[UkupnaCena] [float] NOT NULL,
	[MestoID] [int] NOT NULL,
	[RadnikID] [int] NOT NULL,
	[KlijentID] [int] NOT NULL,
	[KeteringMeniID] [int] NOT NULL,
	[DatumVremeDo] [datetime] NOT NULL,
 CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED 
(
	[RezervacijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RezervisanSto]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RezervisanSto](
	[RezervacijaID] [int] NOT NULL,
	[RbStola] [int] NOT NULL,
 CONSTRAINT [PK_RezervisanSto_1] PRIMARY KEY CLUSTERED 
(
	[RezervacijaID] ASC,
	[RbStola] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sto]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sto](
	[RbStola] [int] IDENTITY(1,1) NOT NULL,
	[Kapacitet] [int] NOT NULL,
	[CenaStola] [float] NOT NULL,
	[ProizvodjacID] [int] NOT NULL,
 CONSTRAINT [PK_Sto] PRIMARY KEY CLUSTERED 
(
	[RbStola] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipProslave]    Script Date: 20-Jun-23 14:59:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipProslave](
	[TipProslaveID] [int] IDENTITY(1,1) NOT NULL,
	[NazivTipaProslave] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipRezervacije] PRIMARY KEY CLUSTERED 
(
	[TipProslaveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KeteringFirma] ON 

INSERT [dbo].[KeteringFirma] ([KeteringFirmaID], [NazivFirme], [Telefon], [Email]) VALUES (1, N'Chily Wau Ketering', N'069 2128351', N'chily.wau@gmail.com')
INSERT [dbo].[KeteringFirma] ([KeteringFirmaID], [NazivFirme], [Telefon], [Email]) VALUES (2, N'Harmonija ketering', N'065 8045068', N'harmonija.ketering@gmail.com')
INSERT [dbo].[KeteringFirma] ([KeteringFirmaID], [NazivFirme], [Telefon], [Email]) VALUES (3, N'Viktorija ketering', N'011 6165014', N'viktorija.ketering@gmail.com')
SET IDENTITY_INSERT [dbo].[KeteringFirma] OFF
GO
SET IDENTITY_INSERT [dbo].[KeteringMeni] ON 

INSERT [dbo].[KeteringMeni] ([KeteringMeniID], [Predjelo], [GlavnoJelo], [Dezert], [CenaHranePoOsobi], [KeteringFirmaID]) VALUES (2, N'Mali sendvici', N'Piletina i rižoto', N'Vocna torta', 500, 1)
INSERT [dbo].[KeteringMeni] ([KeteringMeniID], [Predjelo], [GlavnoJelo], [Dezert], [CenaHranePoOsobi], [KeteringFirmaID]) VALUES (4, N'Corba od pecuraka', N'Meso sa povrcem', N'Tiramisu', 800, 1)
INSERT [dbo].[KeteringMeni] ([KeteringMeniID], [Predjelo], [GlavnoJelo], [Dezert], [CenaHranePoOsobi], [KeteringFirmaID]) VALUES (5, N'Male pitice', N'Medaljoni u saftu', N'Cokoladni tart', 700, 1)
INSERT [dbo].[KeteringMeni] ([KeteringMeniID], [Predjelo], [GlavnoJelo], [Dezert], [CenaHranePoOsobi], [KeteringFirmaID]) VALUES (7, N'Slani rolati', N'Piletina u cili sosu', N'Karamel kocke', 800, 2)
INSERT [dbo].[KeteringMeni] ([KeteringMeniID], [Predjelo], [GlavnoJelo], [Dezert], [CenaHranePoOsobi], [KeteringFirmaID]) VALUES (8, N'Hladna salata', N'Pljeskavice', N'Jaffa kocke', 600, 2)
INSERT [dbo].[KeteringMeni] ([KeteringMeniID], [Predjelo], [GlavnoJelo], [Dezert], [CenaHranePoOsobi], [KeteringFirmaID]) VALUES (9, N'Šarena pita', N'Natur šnicla', N'Americke palacinke', 700, 3)
INSERT [dbo].[KeteringMeni] ([KeteringMeniID], [Predjelo], [GlavnoJelo], [Dezert], [CenaHranePoOsobi], [KeteringFirmaID]) VALUES (10, N'Projice', N'Grašak, meso i krompir', N'Puding od kokosa', 600, 3)
INSERT [dbo].[KeteringMeni] ([KeteringMeniID], [Predjelo], [GlavnoJelo], [Dezert], [CenaHranePoOsobi], [KeteringFirmaID]) VALUES (12, N'Pica mafini', N'Testenina sa piletinom', N'Kolac od maline i vanile', 700, 3)
SET IDENTITY_INSERT [dbo].[KeteringMeni] OFF
GO
SET IDENTITY_INSERT [dbo].[Klijent] ON 

INSERT [dbo].[Klijent] ([KlijentID], [Ime], [Prezime], [Telefon], [Email]) VALUES (3, N'Vera', N'Veric', N'066 3331112', N'vera@gmail.com')
INSERT [dbo].[Klijent] ([KlijentID], [Ime], [Prezime], [Telefon], [Email]) VALUES (1002, N'Lena', N'Lenic', N'063 3331112', N'lena@gmail.com')
INSERT [dbo].[Klijent] ([KlijentID], [Ime], [Prezime], [Telefon], [Email]) VALUES (2003, N'Jelena', N'Veric', N'011 2224440', N'jelena@gmail.com')
INSERT [dbo].[Klijent] ([KlijentID], [Ime], [Prezime], [Telefon], [Email]) VALUES (3002, N'Pera', N'Peric', N'063 321321', N'pera@gmail.com')
INSERT [dbo].[Klijent] ([KlijentID], [Ime], [Prezime], [Telefon], [Email]) VALUES (4002, N'Tina', N'Bambina', N'060 1112223', N'tina@gmail.com')
SET IDENTITY_INSERT [dbo].[Klijent] OFF
GO
SET IDENTITY_INSERT [dbo].[Mesto] ON 

INSERT [dbo].[Mesto] ([MestoID], [Grad], [PostanskiBroj], [Adresa]) VALUES (1, N'Beograd', N'11070', N'Jurija Gagarina 32')
INSERT [dbo].[Mesto] ([MestoID], [Grad], [PostanskiBroj], [Adresa]) VALUES (2, N'Beograd', N'11030', N'Ada Ciganlija BB')
INSERT [dbo].[Mesto] ([MestoID], [Grad], [PostanskiBroj], [Adresa]) VALUES (3, N'Beograd', N'11080', N'Grobljanska BB')
INSERT [dbo].[Mesto] ([MestoID], [Grad], [PostanskiBroj], [Adresa]) VALUES (4, N'Novi Sad', N'21000', N'Novosadski sajam')
INSERT [dbo].[Mesto] ([MestoID], [Grad], [PostanskiBroj], [Adresa]) VALUES (5, N'Novi Sad', N'21000', N'Heroja Pinkija 105')
INSERT [dbo].[Mesto] ([MestoID], [Grad], [PostanskiBroj], [Adresa]) VALUES (6, N'Novi Sad', N'21000', N'Bulevar patrijarha Pavla')
SET IDENTITY_INSERT [dbo].[Mesto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proizvodjac] ON 

INSERT [dbo].[Proizvodjac] ([ProizvodjacID], [NazivProizvodjaca], [Telefon], [Email]) VALUES (1, N'Wood & Steel', N'063 646996', N'office@woodsteel.rs')
INSERT [dbo].[Proizvodjac] ([ProizvodjacID], [NazivProizvodjaca], [Telefon], [Email]) VALUES (2, N'Stolar Beograd', N'064 5180297', N'stolaribeograd@gmail.com')
INSERT [dbo].[Proizvodjac] ([ProizvodjacID], [NazivProizvodjaca], [Telefon], [Email]) VALUES (3, N'Matis', N'063 640739', N'info@matis.rs')
SET IDENTITY_INSERT [dbo].[Proizvodjac] OFF
GO
SET IDENTITY_INSERT [dbo].[Radnik] ON 

INSERT [dbo].[Radnik] ([RadnikID], [Ime], [Prezime], [KorisnickoIme], [Lozinka]) VALUES (1, N'Jovana', N'Vidakovic', N'jvn', N'jvn123')
INSERT [dbo].[Radnik] ([RadnikID], [Ime], [Prezime], [KorisnickoIme], [Lozinka]) VALUES (2, N'Pera', N'Peric', N'pera', N'pera123')
INSERT [dbo].[Radnik] ([RadnikID], [Ime], [Prezime], [KorisnickoIme], [Lozinka]) VALUES (3, N'Mika', N'Mikic', N'mika', N'mika123')
SET IDENTITY_INSERT [dbo].[Radnik] OFF
GO
SET IDENTITY_INSERT [dbo].[Rezervacija] ON 

INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumVremeOd], [TipProslaveID], [UkupnaCena], [MestoID], [RadnikID], [KlijentID], [KeteringMeniID], [DatumVremeDo]) VALUES (3, CAST(N'2023-06-29T07:00:00.000' AS DateTime), 2, 15600, 1, 1, 3, 8, CAST(N'2023-06-29T10:00:00.000' AS DateTime))
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumVremeOd], [TipProslaveID], [UkupnaCena], [MestoID], [RadnikID], [KlijentID], [KeteringMeniID], [DatumVremeDo]) VALUES (4, CAST(N'2023-06-22T18:30:00.000' AS DateTime), 2, 15800, 4, 1, 2003, 5, CAST(N'2023-06-22T21:30:00.000' AS DateTime))
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumVremeOd], [TipProslaveID], [UkupnaCena], [MestoID], [RadnikID], [KlijentID], [KeteringMeniID], [DatumVremeDo]) VALUES (2002, CAST(N'2023-06-19T12:00:00.000' AS DateTime), 1, 17150, 1, 1, 2003, 4, CAST(N'2023-06-19T15:00:00.000' AS DateTime))
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumVremeOd], [TipProslaveID], [UkupnaCena], [MestoID], [RadnikID], [KlijentID], [KeteringMeniID], [DatumVremeDo]) VALUES (2003, CAST(N'2023-06-19T22:00:00.000' AS DateTime), 1, 11600, 3, 1, 3, 2, CAST(N'2023-06-19T23:00:00.000' AS DateTime))
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumVremeOd], [TipProslaveID], [UkupnaCena], [MestoID], [RadnikID], [KlijentID], [KeteringMeniID], [DatumVremeDo]) VALUES (3002, CAST(N'2023-06-30T18:00:00.000' AS DateTime), 1, 13500, 1, 2, 3, 9, CAST(N'2023-06-30T22:00:00.000' AS DateTime))
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumVremeOd], [TipProslaveID], [UkupnaCena], [MestoID], [RadnikID], [KlijentID], [KeteringMeniID], [DatumVremeDo]) VALUES (3003, CAST(N'2023-07-22T16:00:00.000' AS DateTime), 1, 18800, 6, 3, 1002, 12, CAST(N'2023-07-22T20:00:00.000' AS DateTime))
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumVremeOd], [TipProslaveID], [UkupnaCena], [MestoID], [RadnikID], [KlijentID], [KeteringMeniID], [DatumVremeDo]) VALUES (3004, CAST(N'2023-07-11T11:00:00.000' AS DateTime), 1, 12400, 5, 2, 3, 10, CAST(N'2023-07-11T19:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Rezervacija] OFF
GO
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (3, 4002)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (3, 4007)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (4, 4002)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (4, 4006)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (2002, 4005)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (2002, 4006)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (2003, 4002)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (2003, 4006)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (3002, 4002)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (3002, 4004)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (3003, 4006)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (3003, 4007)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (3004, 4004)
INSERT [dbo].[RezervisanSto] ([RezervacijaID], [RbStola]) VALUES (3004, 4006)
GO
SET IDENTITY_INSERT [dbo].[Sto] ON 

INSERT [dbo].[Sto] ([RbStola], [Kapacitet], [CenaStola], [ProizvodjacID]) VALUES (4002, 10, 500, 1)
INSERT [dbo].[Sto] ([RbStola], [Kapacitet], [CenaStola], [ProizvodjacID]) VALUES (4003, 12, 600, 2)
INSERT [dbo].[Sto] ([RbStola], [Kapacitet], [CenaStola], [ProizvodjacID]) VALUES (4004, 8, 400, 3)
INSERT [dbo].[Sto] ([RbStola], [Kapacitet], [CenaStola], [ProizvodjacID]) VALUES (4005, 9, 550, 3)
INSERT [dbo].[Sto] ([RbStola], [Kapacitet], [CenaStola], [ProizvodjacID]) VALUES (4006, 11, 600, 2)
INSERT [dbo].[Sto] ([RbStola], [Kapacitet], [CenaStola], [ProizvodjacID]) VALUES (4007, 14, 700, 1)
SET IDENTITY_INSERT [dbo].[Sto] OFF
GO
SET IDENTITY_INSERT [dbo].[TipProslave] ON 

INSERT [dbo].[TipProslave] ([TipProslaveID], [NazivTipaProslave]) VALUES (1, N'Privatna')
INSERT [dbo].[TipProslave] ([TipProslaveID], [NazivTipaProslave]) VALUES (2, N'Korporativna')
SET IDENTITY_INSERT [dbo].[TipProslave] OFF
GO
ALTER TABLE [dbo].[KeteringMeni]  WITH CHECK ADD  CONSTRAINT [FK_KeteringMeni_KeteringFirma] FOREIGN KEY([KeteringFirmaID])
REFERENCES [dbo].[KeteringFirma] ([KeteringFirmaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KeteringMeni] CHECK CONSTRAINT [FK_KeteringMeni_KeteringFirma]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_KeteringMeni] FOREIGN KEY([KeteringMeniID])
REFERENCES [dbo].[KeteringMeni] ([KeteringMeniID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_KeteringMeni]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Klijent] FOREIGN KEY([KlijentID])
REFERENCES [dbo].[Klijent] ([KlijentID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Klijent]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Mesto] FOREIGN KEY([MestoID])
REFERENCES [dbo].[Mesto] ([MestoID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Mesto]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Radnik] FOREIGN KEY([RadnikID])
REFERENCES [dbo].[Radnik] ([RadnikID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Radnik]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_TipProslave] FOREIGN KEY([TipProslaveID])
REFERENCES [dbo].[TipProslave] ([TipProslaveID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_TipProslave]
GO
ALTER TABLE [dbo].[RezervisanSto]  WITH CHECK ADD  CONSTRAINT [FK_RezervisanSto_Rezervacija] FOREIGN KEY([RezervacijaID])
REFERENCES [dbo].[Rezervacija] ([RezervacijaID])
GO
ALTER TABLE [dbo].[RezervisanSto] CHECK CONSTRAINT [FK_RezervisanSto_Rezervacija]
GO
ALTER TABLE [dbo].[RezervisanSto]  WITH CHECK ADD  CONSTRAINT [FK_RezervisanSto_Sto] FOREIGN KEY([RbStola])
REFERENCES [dbo].[Sto] ([RbStola])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[RezervisanSto] CHECK CONSTRAINT [FK_RezervisanSto_Sto]
GO
ALTER TABLE [dbo].[Sto]  WITH CHECK ADD  CONSTRAINT [FK_Sto_Proizvodjac] FOREIGN KEY([ProizvodjacID])
REFERENCES [dbo].[Proizvodjac] ([ProizvodjacID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sto] CHECK CONSTRAINT [FK_Sto_Proizvodjac]
GO
ALTER TABLE [dbo].[KeteringMeni]  WITH CHECK ADD  CONSTRAINT [CK_CenaHranePoOsobi] CHECK  (([CenaHranePoOsobi]>(0)))
GO
ALTER TABLE [dbo].[KeteringMeni] CHECK CONSTRAINT [CK_CenaHranePoOsobi]
GO
ALTER TABLE [dbo].[Mesto]  WITH CHECK ADD  CONSTRAINT [CK_PostanskiBroj] CHECK  (([PostanskiBroj]>(0)))
GO
ALTER TABLE [dbo].[Mesto] CHECK CONSTRAINT [CK_PostanskiBroj]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [CK_Rezervacija] CHECK  (([DatumVremeOd]<[DatumVremeDo]))
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [CK_Rezervacija]
GO
ALTER TABLE [dbo].[RezervisanSto]  WITH CHECK ADD  CONSTRAINT [CK_RezervisanSto] CHECK  (([RbStola]>(0)))
GO
ALTER TABLE [dbo].[RezervisanSto] CHECK CONSTRAINT [CK_RezervisanSto]
GO
ALTER TABLE [dbo].[Sto]  WITH CHECK ADD  CONSTRAINT [CK_CenaStola] CHECK  (([CenaStola]>=(0)))
GO
ALTER TABLE [dbo].[Sto] CHECK CONSTRAINT [CK_CenaStola]
GO
ALTER TABLE [dbo].[Sto]  WITH CHECK ADD  CONSTRAINT [CK_Kapacitet] CHECK  (([Kapacitet]>=(0)))
GO
ALTER TABLE [dbo].[Sto] CHECK CONSTRAINT [CK_Kapacitet]
GO
USE [master]
GO
ALTER DATABASE [SeminarskiRad] SET  READ_WRITE 
GO
