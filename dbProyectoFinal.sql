USE [master]
GO
/****** Object:  Database [proyectoProgramacionV]    Script Date: 21/4/2019 01:59:16 ******/
CREATE DATABASE [proyectoProgramacionV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyectoProgramacionV', FILENAME = N'E:\SQL\MSSQL14.MSSQLSERVER\MSSQL\DATA\proyectoProgramacionV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyectoProgramacionV_log', FILENAME = N'E:\SQL\MSSQL14.MSSQLSERVER\MSSQL\DATA\proyectoProgramacionV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [proyectoProgramacionV] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyectoProgramacionV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyectoProgramacionV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyectoProgramacionV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyectoProgramacionV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [proyectoProgramacionV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyectoProgramacionV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET RECOVERY FULL 
GO
ALTER DATABASE [proyectoProgramacionV] SET  MULTI_USER 
GO
ALTER DATABASE [proyectoProgramacionV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyectoProgramacionV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyectoProgramacionV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyectoProgramacionV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyectoProgramacionV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'proyectoProgramacionV', N'ON'
GO
ALTER DATABASE [proyectoProgramacionV] SET QUERY_STORE = OFF
GO
USE [proyectoProgramacionV]
GO
/****** Object:  Table [dbo].[asddsa]    Script Date: 21/4/2019 01:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asddsa](
	[Espacio1] [int] IDENTITY(1,1) NOT NULL,
	[Espacio2] [varchar](50) NULL,
	[Espacio3] [varchar](50) NULL,
	[Espacio4] [varchar](50) NULL,
 CONSTRAINT [PK_asddsa] PRIMARY KEY CLUSTERED 
(
	[Espacio1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[foroConsulata]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[foroConsulata](
	[consultaID] [int] IDENTITY(1,1) NOT NULL,
	[nombreRemitente] [varchar](50) NOT NULL,
	[tituloConsulta] [varchar](50) NOT NULL,
	[detalleConsulta] [varchar](50) NOT NULL,
 CONSTRAINT [PK_foroConsulata] PRIMARY KEY CLUSTERED 
(
	[consultaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[foroRespuestas]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[foroRespuestas](
	[respuestaID] [int] IDENTITY(1,1) NOT NULL,
	[nombreReceptor] [varchar](50) NOT NULL,
	[detalleRespuesta] [varchar](500) NOT NULL,
	[consultaID] [int] NOT NULL,
 CONSTRAINT [PK_foroRespuestas] PRIMARY KEY CLUSTERED 
(
	[respuestaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tasaBasicaPasiva]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tasaBasicaPasiva](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codIndicador] [varchar](50) NULL,
	[desFecha] [datetime] NULL,
	[numValor] [varchar](50) NULL,
 CONSTRAINT [PK_tasaBasicaPasiva] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tasaDePolíticaMonetaria]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tasaDePolíticaMonetaria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codIndicador] [varchar](50) NULL,
	[desFecha] [datetime] NULL,
	[numValor] [varchar](50) NULL,
 CONSTRAINT [PK_tasaDePolíticaMonetaria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoDeCambioCompra]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoDeCambioCompra](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codIndicador] [varchar](50) NULL,
	[desFecha] [datetime] NULL,
	[numValor] [varchar](50) NULL,
 CONSTRAINT [PK_tipoDeCambioCompra] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoDeCambioVenta]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoDeCambioVenta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codIndicador] [varchar](50) NULL,
	[desFecha] [datetime] NULL,
	[numValor] [varchar](50) NULL,
 CONSTRAINT [PK_tipoDeCambioVenta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[iD] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [varchar](50) NOT NULL,
	[cedulaUsuario] [varchar](50) NULL,
	[edadUsuario] [int] NULL,
	[correoUsuario] [varchar](50) NOT NULL,
	[profesiónUsuario] [varchar](50) NULL,
	[provinciaUsuario] [varchar](50) NULL,
	[cantonUsuario] [varchar](50) NULL,
	[distritoUsuario] [varchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[iD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[correoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[foroRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_foroRespuestas_foroConsulata] FOREIGN KEY([consultaID])
REFERENCES [dbo].[foroConsulata] ([consultaID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[foroRespuestas] CHECK CONSTRAINT [FK_foroRespuestas_foroConsulata]
GO
/****** Object:  StoredProcedure [dbo].[insercion_Consulta]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insercion_Consulta]( @nombreRemitente varchar(50),
										@tituloConsulta varchar(50), 
										@detalleConsulta varchar(50))
 AS
 BEGIN
 SET NOCOUNT ON;

  INSERT INTO foroConsulata (nombreRemitente,tituloConsulta , detalleConsulta ) 
		VALUES (@nombreRemitente ,
				@tituloConsulta ,
				@detalleConsulta);


 END;
GO
/****** Object:  StoredProcedure [dbo].[insercion_Respuesta]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insercion_Respuesta](@nombreReceptor VARCHAR(50),
										@detalleRespuesta VARCHAR(50),
										@consultaID INT)
 AS
 BEGIN
 SET NOCOUNT ON;
 INSERT INTO foroRespuestas( nombreReceptor, detalleRespuesta, consultaID)
		VALUES( @nombreReceptor,
				@detalleRespuesta,
				@consultaID );
 END;
GO
/****** Object:  StoredProcedure [dbo].[insercion_Usuario]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[insercion_Usuario] (@nombreUsuario varchar(50)
										   ,@cedulaUsuario varchar(50)
										   ,@edadUsuario int
										   ,@correoUsuario varchar(50)
										   ,@profesiónUsuario varchar(50)
										   ,@provinciaUsuario varchar(50)
										   ,@cantonUsuario varchar(50)
										   ,@distritoUsuario varchar(50))
 AS
 BEGIN
 SET NOCOUNT ON;

  INSERT INTO [dbo].[Usuarios](nombreUsuario ,cedulaUsuario  ,edadUsuario  ,correoUsuario ,profesiónUsuario 
										   ,provinciaUsuario  ,cantonUsuario  ,distritoUsuario )
		VALUES (@nombreUsuario
					   ,@cedulaUsuario 
					   ,@edadUsuario 
					   ,@correoUsuario 
					   ,@profesiónUsuario 
					   ,@provinciaUsuario 
					   ,@cantonUsuario 
					   ,@distritoUsuario );


 END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_tasaBasicaPasiva]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_tasaBasicaPasiva]( @codIndicador varchar(50),
										@desFecha datetime, 
										@numValor varchar(50))
 AS
 BEGIN
 SET NOCOUNT ON;
 BEGIN TRY  
	IF EXISTS(SELECT * FROM tasaBasicaPasiva WHERE desFecha = @desFecha)
	RETURN;
	ELSE
	      INSERT INTO [dbo].[tasaBasicaPasiva] (codIndicador, desFecha , numValor ) 
		VALUES (@codIndicador ,
				@desFecha ,
				@numValor);
END TRY  
BEGIN CATCH   
END CATCH;
 END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_tasaDePolíticaMonetaria]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_tasaDePolíticaMonetaria]( @codIndicador varchar(50),
										@desFecha datetime, 
										@numValor varchar(50))
 AS
 BEGIN 
  SET NOCOUNT ON;
  BEGIN TRY 
   IF EXISTS(SELECT * FROM tasaDePolíticaMonetaria WHERE desFecha = @desFecha)
   RETURN;
   ELSE 
  INSERT INTO [dbo].[tasaDePolíticaMonetaria] (codIndicador, desFecha , numValor ) 
		VALUES (@codIndicador ,
				@desFecha ,
				@numValor); 
END TRY  
BEGIN CATCH  
END CATCH;
 END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_tipoDeCambioCompra]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_tipoDeCambioCompra]( @codIndicador varchar(50),
										@desFecha datetime, 
										@numValor varchar(50))
 AS
 BEGIN
 SET NOCOUNT ON;
BEGIN TRY  
 IF EXISTS( SELECT * FROM tipoDeCambioCompra WHERE desFecha = @desFecha)
 RETURN;
 ELSE
   INSERT INTO [dbo].[tipoDeCambioCompra] (codIndicador, desFecha , numValor ) 
		VALUES (@codIndicador ,
				@desFecha ,
				@numValor);
END TRY  
BEGIN CATCH   
END CATCH;
 END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_tipoDeCambioVenta]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_tipoDeCambioVenta]( @codIndicador varchar(50),
										@desFecha datetime, 
										@numValor varchar(50))
 AS
 BEGIN
 SET NOCOUNT ON;
 IF EXISTS (SELECT * FROM tipoDeCambioVenta WHERE desFecha = @desFecha)
 RETURN;
 ELSE
  INSERT INTO [dbo].[tipoDeCambioVenta] (codIndicador, desFecha , numValor ) 
		VALUES (@codIndicador ,
				@desFecha ,
				@numValor);
 END;
GO
/****** Object:  StoredProcedure [dbo].[Preguntas]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Preguntas]
 AS
 BEGIN
 SELECT C.nombreRemitente as 'Emisor', R.NombreReceptor as 'Receptor' from foroConsulata C, foroRespuestas R
 where c.consultaID=r.consultaID order by C.consultaID;
 END;
GO
/****** Object:  StoredProcedure [dbo].[Respuestas]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Respuestas]
 AS
 BEGIN
	SELECT  R.nombreReceptor as 'Autor Respuesta',R.detalleRespuesta as 'Respuestas', c.consultaID as 'Codigo'
		from  foroRespuestas R, foroConsulata C order by c.consultaID;
 END;
GO
/****** Object:  StoredProcedure [dbo].[sql_insert]    Script Date: 21/4/2019 01:59:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sql_insert]( @Espacio2 varchar(50),
										@Espacio3 varchar(50), 
										@Espacio4 varchar(50))
 AS
 BEGIN
 SET NOCOUNT ON;

  INSERT INTO [dbo].[asddsa] (Espacio2, Espacio3 , Espacio4 ) 
		VALUES (@Espacio2 ,
				@Espacio3 ,
				@Espacio4);


 END;
GO
USE [master]
GO
ALTER DATABASE [proyectoProgramacionV] SET  READ_WRITE 
GO
