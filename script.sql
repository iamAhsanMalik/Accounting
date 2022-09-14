CREATE TABLE [dbo].[GLChartOfAccounts](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[AccountCode] [nvarchar](15) NOT NULL,
	[ParentAccountCode] [nvarchar](15) NULL,
	[AccountName] [nvarchar](250) NULL,
	[AccountCodeMask] [nvarchar](15) NULL,
	[AccountStatus] [bit] NULL,
	[AccountDescription] [nvarchar](max) NULL,
	[ClassId] [smallint] NULL,
	[TypeId] [int] NULL,
	[Prefix] [nvarchar](50) NULL,
	[CurrencyISOCode] [nvarchar](5) NULL,
	[CountryISONumericCode] [nvarchar](3) NULL,
	[RevalueYN] [bit] NULL,
	[Revalue] [decimal](18, 4) NULL,
	[DebiteLimit] [decimal](18, 4) NULL,
	[CreditLimit] [decimal](18, 4) NULL,
	[TaxPercentage] [decimal](18, 4) NULL,
	[VATWithholdingTax] [decimal](18, 4) NULL,
	[Charges] [bit] NULL,
	[IsHead] [bit] NULL,
	[ForeignCurrencyBalance] [decimal](18, 4) NULL,
	[LocalCurrencyBalance] [decimal](18, 4) NULL,
	[AddedBy] [nvarchar](128) NOT NULL,
	[AddedDate] [datetime] NOT NULL,
	[LastModifyBy] [nvarchar](128) NOT NULL,
	[LastModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GLChartOfAccounts] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[GLReferences](
	[GLReferenceId] [int] IDENTITY(1,1) NOT NULL,
	[TypeiCode] [nvarchar](15) NULL,
	[ReferenceNo] [nvarchar](50) NULL,
	[Memorandum] [nvarchar](250) NULL,
	[IsPosted] [bit] NULL,
	[PostedBy] [nvarchar](128) NULL,
	[DatePosted] [datetime] NULL,
	[AuthorizedBy] [nvarchar](128) NULL,
	[AuthorizedDate] [datetime] NULL,
	[VoucherNumber] [int] NULL,
 CONSTRAINT [PK_GLReferences] PRIMARY KEY CLUSTERED 
(
	[GLReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



CREATE TABLE [dbo].[GLTransactions](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[GLReferenceId] [int] NULL,
	[Type] [smallint] NULL,
	[AccountTypeiCode] [nvarchar](15) NULL,
	[AccountCode] [nvarchar](50) NOT NULL,
	[Memorandum] [nvarchar](250) NULL,
	[BaseAmount] [decimal](18, 4) NULL,
	[LocalAmount] [decimal](18, 4) NULL,
	[ForeignCurrencyISOCode] [nvarchar](3) NULL,
	[ForeignCurrencyAmount] [decimal](18, 4) NULL,
	[LocalCurrencyAmount] [decimal](18, 4) NULL,
	[ExchangeRate] [decimal](18, 4) NULL,
	[GLPersonTypeiCode] [nvarchar](15) NULL,
	[PersonID] [nvarchar](128) NULL,
	[DimensionId] [smallint] NULL,
	[Dimension2Id] [smallint] NULL,
	[TransactionNumber] [nvarchar](20) NULL,
	[Payee] [nvarchar](150) NULL,
    [Customer] [nvarchar](150) NULL,
	[AddedBy] [nvarchar](128) NOT NULL,
	[AddedDate] [datetime] NOT NULL,
	[LastModifyBy] [nvarchar](128) NOT NULL,
	[LastModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GLTransactions] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[GLTransactions]  WITH CHECK ADD  CONSTRAINT [FK_GLTransactions_GLReferences] FOREIGN KEY([GLReferenceID])
REFERENCES [dbo].[GLReferences] ([GLReferenceID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[GLTransactions] CHECK CONSTRAINT [FK_GLTransactions_GLReferences]
GO



CREATE TABLE [dbo].[SystemSettings](
	[SettingId] [int] IDENTITY(1,1) NOT NULL,
	[KeyName] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NULL,
	[KeyType] [nvarchar](20) NULL,
	[KeyValue] [nvarchar](max) NULL,
	[KeyLength] [tinyint] NULL,
    [AddedBy] [nvarchar](128) NOT NULL,
	[AddedDate] [datetime] NOT NULL,
	[LastModifyBy] [nvarchar](128) NOT NULL,
	[LastModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK_SysSettings] PRIMARY KEY CLUSTERED 
(
	[KeyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GLDimensions](
	[GLDimensionId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[StartDate] [datetime] NULL,
	[RequiredDate] [datetime] NULL,
	[Notes] [nvarchar](250) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_GLDimensions] PRIMARY KEY CLUSTERED 
(
	[GLDimensionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GLEntriesTemp](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[GLTransactionTypeiCode] [nvarchar](150) NULL,
	[AccountCode] [nvarchar](50) NULL,
	[Memorandum] [nvarchar](250) NULL,
	[BaseAmount] [decimal](18, 4) NULL,
	[LocalAmount] [decimal](18, 4) NULL,
	[ForeignCurrencyAmount] [decimal](18, 4) NULL,
	[LocalCurrencyAmount] [decimal](18, 4) NULL,
	[UserRefNo] [nvarchar](50) NULL,
	[GLDimensionsID] [int] NULL,
	[PersonId] [nvarchar](max) NULL,
	[ExchangeRate] [decimal](18, 4) NULL,
	[ForeignCurrencyISOCode] [nvarchar](3) NULL,
	[Payee] [nvarchar](150) NULL,
	[Customer] [nvarchar](150) NULL,
 CONSTRAINT [PK_GLEntriesTemp] PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[GLEntriesTemp]  WITH CHECK ADD  CONSTRAINT [FK_GLEntriesTemp_GLDimensions] FOREIGN KEY([GLDimensionsID])
REFERENCES [dbo].[GLDimensions] ([GLDimensionID])
GO

ALTER TABLE [dbo].[GLEntriesTemp] CHECK CONSTRAINT [FK_GLEntriesTemp_GLDimensions]
GO




CREATE TABLE [dbo].[GLFiscalYear](
	[FiscalYearId] [int] IDENTITY(1,1) NOT NULL,
	[BeginDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Closed] [bit] NULL,
    [AddedBy] [nvarchar](128) NOT NULL,
	[AddedDate] [datetime] NOT NULL,
	[LastModifyBy] [nvarchar](128) NOT NULL,
	[LastModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GLFiscalYear] PRIMARY KEY CLUSTERED 
(
	[FiscalYearId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



