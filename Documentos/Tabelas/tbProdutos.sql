USE [TesteTI]
GO

/****** Object:  Table [CadProdutos].[tbProdutos]    Script Date: 22/07/2021 23:48:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [CadProdutos].[tbProdutos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](max) NULL,
	[Preco] [float] NULL,
	[IDUsuario] [int] NULL,
	[IDCategoria] [int] NULL,
	[status] [int] NULL,
	[dtCadastro] [datetime] NULL,
	[dtAlteracao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


