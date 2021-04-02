USE [SGA]
GO
/****** Object:  Table [dbo].[usersLogin]    Script Date: 01/04/2021 22:42:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usersLogin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](max) NULL,
	[IPAddress] [varchar](50) NULL,
	[loginDate] [datetime] NULL,
	[source] [varchar](max) NULL,
 CONSTRAINT [PK_usersLogin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
