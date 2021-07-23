USE [TesteTI]
GO

/****** Object:  Table [CadProdutos].[tbCategoria]    Script Date: 22/07/2021 23:47:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [CadProdutos].[tbCategoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](max) NULL,
	[status] [int] NULL,
	[dtCadastro] [datetime] NULL,
	[dtAlteracao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


