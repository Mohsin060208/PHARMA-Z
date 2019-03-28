/*
Navicat SQL Server Data Transfer

Source Server         : db
Source Server Version : 110000
Source Host           : DESKTOP-H4D0KNJ\SQLEXPRESS:1433
Source Database       : PHARMA-Z
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2019-03-29 04:50:33
*/


-- ----------------------------
-- Table structure for Brand
-- ----------------------------
DROP TABLE [dbo].[Brand]
GO
CREATE TABLE [dbo].[Brand] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] varchar(50) NOT NULL ,
[CompanyId] int NULL ,
[Meta] varchar(50) NULL ,
[IsFavorite] bit NULL ,
[IsRecent] bit NULL ,
[FormsId] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Brand]', RESEED, 63)
GO

-- ----------------------------
-- Records of Brand
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Brand] ON
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'2', N'Ponstan', N'2', N'Headache', null, null, N'1')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'3', N'Panadol', N'3', N'Fever', null, null, N'1')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'4', N'Brufen', N'3', N'Headache', null, null, N'1')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'5', N'Disprol', N'1', N'Fever', null, null, N'1')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'6', N'Disprin CV', N'1', N'Headache', null, null, N'1')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'7', N'Nims', N'4', N'Fever', null, null, N'1')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'57', N'Danzen', N'7', null, null, null, N'1')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'58', N'Ponstan Forte', N'2', N'Headache', null, null, N'1')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'60', N'Ponstan (Suspension)', N'2', N'Fever', null, null, N'5')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'61', N'Brufen Gel', N'3', null, null, null, N'4')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'62', N'Brufen DS', N'3', N'Headache', null, null, N'5')
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'63', N'Brufen (Suspension)', N'3', N'Fever', null, null, N'5')
GO
GO
SET IDENTITY_INSERT [dbo].[Brand] OFF
GO

-- ----------------------------
-- Table structure for Company
-- ----------------------------
DROP TABLE [dbo].[Company]
GO
CREATE TABLE [dbo].[Company] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] varchar(50) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Company]', RESEED, 1011)
GO

-- ----------------------------
-- Records of Company
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Company] ON
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1', N'Reckitt Benkiser Pakistan Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'2', N'PFizer Laboratories Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'3', N'Abbott Laboratories(Pakistan) Limited')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'4', N'Sami Pharmaceuticals (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'5', N'Searle Pakisatan (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'6', N'Glaxosmithkline')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'7', N'Helix Pharma (Private) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'8', N'Merck Private Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'9', N'Hilton Pharma (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'10', N'Novartis Pharma (Pakistan) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'11', N'AGP (Private) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'12', N'Platinum Pharmaceuticals (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'13', N'Raazee Theraputics (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1001', N'Goodman Laboratories')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1002', N'Sanofi Aventis (Pakistan) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1003', N'Nabiqasim Industries (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1004', N'Barrett Hodgson Pakistan (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1005', N'Janssen-Cilag')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1006', N'Indus Pharma (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1007', N'AGP (Private) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1008', N'Shaigan Pharmaceuticals (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1009', N'High-Q International')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1010', N'Getz Pharma Pakistan (PVT) Ltd.')
GO
GO
INSERT INTO [dbo].[Company] ([Id], [Name]) VALUES (N'1011', N'Wilsons Pharmaceuticals')
GO
GO
SET IDENTITY_INSERT [dbo].[Company] OFF
GO

-- ----------------------------
-- Table structure for Dosages
-- ----------------------------
DROP TABLE [dbo].[Dosages]
GO
CREATE TABLE [dbo].[Dosages] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Adult] varchar(50) NOT NULL ,
[Neonatal] varchar(50) NOT NULL ,
[Paedriatic] varchar(50) NOT NULL ,
[BrandId] int NULL 
)


GO

-- ----------------------------
-- Records of Dosages
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Dosages] ON
GO
SET IDENTITY_INSERT [dbo].[Dosages] OFF
GO

-- ----------------------------
-- Table structure for Feedback
-- ----------------------------
DROP TABLE [dbo].[Feedback]
GO
CREATE TABLE [dbo].[Feedback] (
[EmailFrom] varchar(50) NULL ,
[Pwd] varchar(50) NULL ,
[EmailTo] varchar(50) NULL 
)


GO

-- ----------------------------
-- Records of Feedback
-- ----------------------------
INSERT INTO [dbo].[Feedback] ([EmailFrom], [Pwd], [EmailTo]) VALUES (N'Enter your email here', N'Enter Your Email Password', N'Something@something.com')
GO
GO

-- ----------------------------
-- Table structure for Forms
-- ----------------------------
DROP TABLE [dbo].[Forms]
GO
CREATE TABLE [dbo].[Forms] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Medicine_Form] varchar(255) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Forms]', RESEED, 5)
GO

-- ----------------------------
-- Records of Forms
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Forms] ON
GO
INSERT INTO [dbo].[Forms] ([Id], [Medicine_Form]) VALUES (N'1', N'Tablet')
GO
GO
INSERT INTO [dbo].[Forms] ([Id], [Medicine_Form]) VALUES (N'2', N'Injection')
GO
GO
INSERT INTO [dbo].[Forms] ([Id], [Medicine_Form]) VALUES (N'3', N'Capsule')
GO
GO
INSERT INTO [dbo].[Forms] ([Id], [Medicine_Form]) VALUES (N'4', N'Gel')
GO
GO
INSERT INTO [dbo].[Forms] ([Id], [Medicine_Form]) VALUES (N'5', N'Syrup')
GO
GO
SET IDENTITY_INSERT [dbo].[Forms] OFF
GO

-- ----------------------------
-- Table structure for Generic
-- ----------------------------
DROP TABLE [dbo].[Generic]
GO
CREATE TABLE [dbo].[Generic] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] varchar(255) NOT NULL ,
[Overview] varchar(50) NULL ,
[BrandId] int NULL ,
[Gramage] varchar(255) NULL ,
[IsRecent] bit NULL ,
[Indications] varchar(255) NULL ,
[Side_Effects] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Generic]', RESEED, 26)
GO

-- ----------------------------
-- Records of Generic
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Generic] ON
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'6', N'nimesulide', N'Nimesulide is NSAID (non steroidal anti-inflammato', N'7', N'100mg', null, N'Nimesulide is primarily indicated in conditons like Bursitis, Fever , fever  Gynecological infections, inflammation , Osteoarthritis, Pain.', N'The severe or irreversible adverse effects of Nimsulide, which give rise to further complications includeStevens jhonson syndrome, lyells syndrome, hepatoxity.')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'7', N'aspirin', N'Aspirin is an NSAID (non-steroidal anti-inflammato', N'6', N'100mg', null, N'Aspirin is primarily indicates in condition like Fever, Following coronary bypass surgery, Headache inflammation, Ischaemic event , Mild to moderate pain. ', N'The severe or irreversible adverse effect of Apirin, which give rise to further complications include Utricaria, Gi bleeding, Rhinitis , Angioneurotic edema, Hepatitis, Hepatomegaly.')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'8', N'paracetamol', N'Paracetamol is analgesic and antipyretic agent . P', N'5', N'500mg', null, N'Paracetamol is primarily indicated in conditions like ear pain , fever , headache, migraine, mild to moderate pain.', N'The severe or irreversible adverse effect of Paracetamol, which give rise to further complications include Bronchospasm.')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'10', N'paracetamol', N'Paracetamol is analgesic and antipyretic agent . P', N'3', N'500mg', null, N'Paracetamol is primarily indicated in conditions like ear pain , fever , headache, migraine, mild to moderate pain.', N'The severe or irreversible adverse effect of Paracetamol, which give rise to further complications include Bronchospasm.')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'11', N'mefenamic acid', N'Mefenamic Acid is a NSAID (non steroidal antiinfla', N'2', N'50mg/5mlx', null, N'Mefenamic Acid is primarily indicated in condition like Dysmenorrhoea, Fever, fever inflammation, juvenile chronic arthritis, Menorrhagia, Migraine, Musculoskeletal  disorder, osteoarthritis . Pain , post oprative pain , post-partum pain , Rheumatoid Arth', N'The severe or Irreversible adverse effect of Mefenamic Acid, which give rise to further complication include diarrhoea, peripheral edema, Urticaria, Gi bleeding , Gl bleeding, proteinuria, Aplastic anemia, Epidermal necrolysis, jaundice , Nephrotic syndro')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'17', N'ibuprofen', N'Ibuprofen is a non-steroidal analgesic , antipyret', N'4', N'200mg/400mg/600mg', null, N'Ibuprofen is primarily indicated in conditions like cystic fibrosis, Fever , Juvenile chronic arthritis, Migraine , mild to moderate pain. ', N'The severe or irreversible adverse effect of  Ibuprofen, which give rise to further complications include Thrombocytopenia, Elevated blood pressure.')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'21', N'mefenamic acid', N'Mefenamic Acid is a NSAID (non steroidal antiinfla', N'58', N'500mg', null, N'Mefenamic Acid is primarily indicated in condition like Dysmenorrhoea, Fever, fever inflammation, juvenile chronic arthritis, Menorrhagia, Migraine, Musculoskeletal  disorder, osteoarthritis . Pain , post oprative pain , post-partum pain , Rheumatoid Arth', N'The severe or Irreversible adverse effect of Mefenamic Acid, which give rise to further complication include diarrhoea, peripheral edema, Urticaria, Gi bleeding , Gl bleeding, proteinuria, Aplastic anemia, Epidermal necrolysis, jaundice , Nephrotic syndro')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'22', N'mefenamic acid', N'Mefenamic Acid is a NSAID (non steroidal antiinfla', N'60', N'50mg/ml', null, N'Mefenamic Acid is primarily indicated in condition like Dysmenorrhoea, Fever, fever inflammation, juvenile chronic arthritis, Menorrhagia, Migraine, Musculoskeletal  disorder, osteoarthritis . Pain , post oprative pain , post-partum pain , Rheumatoid Arth', N'The severe or Irreversible adverse effect of Mefenamic Acid, which give rise to further complication include diarrhoea, peripheral edema, Urticaria, Gi bleeding , Gl bleeding, proteinuria, Aplastic anemia, Epidermal necrolysis, jaundice , Nephrotic syndro')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'23', N'ibuprofen', N'Ibuprofen is a non-steroidal analgesic , antipyret', N'61', N'10% W/W', null, N'Ibuprofen is primarily indicated in conditions like cystic fibrosis, Fever , Juvenile chronic arthritis, Migraine , mild to moderate pain. ', N'The severe or irreversible adverse effect of  Ibuprofen, which give rise to further complications include Thrombocytopenia, Elevated blood pressure.')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'24', N'ibuprofen', N'Ibuprofen is a non-steroidal analgesic , antipyret', N'63', N'100mg / 5ml', null, N'Ibuprofen is primarily indicated in conditions like cystic fibrosis, Fever , Juvenile chronic arthritis, Migraine , mild to moderate pain. ', N'The severe or irreversible adverse effect of  Ibuprofen, which give rise to further complications include Thrombocytopenia, Elevated blood pressure.')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'25', N'ibuprofen', N'Ibuprofen is a non-steroidal analgesic , antipyret', N'62', N'200mg', null, N'Ibuprofen is primarily indicated in conditions like cystic fibrosis, Fever , Juvenile chronic arthritis, Migraine , mild to moderate pain. ', N'The severe or irreversible adverse effect of  Ibuprofen, which give rise to further complications include Thrombocytopenia, Elevated blood pressure.')
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent], [Indications], [Side_Effects]) VALUES (N'26', N'serratiopeptidase', N'Serratiopeptidase used in inflammation and edema.', N'57', N'5mg / 10mg', null, N'Serratiopeptidase is primarily indicated in condition like Haematoma, inflammation,  Musculoskeletal disorders, Oedema, Osteoarthritis. ', N'Serratiopeptidase is primarily indicated in condition like Haematoma, inflammation,  Musculoskeletal disorders, Oedema, Osteoarthritis. ')
GO
GO
SET IDENTITY_INSERT [dbo].[Generic] OFF
GO

-- ----------------------------
-- Table structure for System_Configuration
-- ----------------------------
DROP TABLE [dbo].[System_Configuration]
GO
CREATE TABLE [dbo].[System_Configuration] (
[Theme_Toggle] int NULL ,
[Disclaimer_Check] bit NULL 
)


GO

-- ----------------------------
-- Records of System_Configuration
-- ----------------------------
INSERT INTO [dbo].[System_Configuration] ([Theme_Toggle], [Disclaimer_Check]) VALUES (N'1', N'1')
GO
GO

-- ----------------------------
-- Procedure structure for GetAllCoughMedicines
-- ----------------------------
DROP PROCEDURE [dbo].[GetAllCoughMedicines]
GO
CREATE PROCEDURE [dbo].[GetAllCoughMedicines]
AS
	SELECT
dbo.Brand.Name as Brand,
dbo.Company.Name as Company,
dbo.Forms.Medicine_Form,
dbo.Generic.Name as Composition,
dbo.Generic.Gramage

FROM
dbo.Brand
INNER JOIN dbo.Company ON dbo.Brand.CompanyId = dbo.Company.Id
INNER JOIN dbo.Forms ON dbo.Brand.FormsId = dbo.Forms.Id
INNER JOIN dbo.Generic ON dbo.Generic.BrandId = dbo.Brand.Id
WHERE
dbo.Brand.Meta = 'Cough'

RETURN 0
GO

-- ----------------------------
-- Procedure structure for GetAllFeverMedicines
-- ----------------------------
DROP PROCEDURE [dbo].[GetAllFeverMedicines]
GO
CREATE PROCEDURE [dbo].[GetAllFeverMedicines]
AS
	SELECT
dbo.Brand.Name as Brand,
dbo.Company.Name as Company,
dbo.Forms.Medicine_Form,
dbo.Generic.Name as Composition,
dbo.Generic.Gramage

FROM
dbo.Brand
INNER JOIN dbo.Company ON dbo.Brand.CompanyId = dbo.Company.Id
INNER JOIN dbo.Forms ON dbo.Brand.FormsId = dbo.Forms.Id
INNER JOIN dbo.Generic ON dbo.Generic.BrandId = dbo.Brand.Id
WHERE
dbo.Brand.Meta = 'Fever'

RETURN 0
GO

-- ----------------------------
-- Procedure structure for GetAllFluMedicines
-- ----------------------------
DROP PROCEDURE [dbo].[GetAllFluMedicines]
GO
CREATE PROCEDURE [dbo].[GetAllFluMedicines]
AS
	SELECT
dbo.Brand.Name as Brand,
dbo.Company.Name as Company,
dbo.Forms.Medicine_Form,
dbo.Generic.Name as Composition,
dbo.Generic.Gramage

FROM
dbo.Brand
INNER JOIN dbo.Company ON dbo.Brand.CompanyId = dbo.Company.Id
INNER JOIN dbo.Forms ON dbo.Brand.FormsId = dbo.Forms.Id
INNER JOIN dbo.Generic ON dbo.Generic.BrandId = dbo.Brand.Id
WHERE
dbo.Brand.Meta = 'Flu'

RETURN 0
GO

-- ----------------------------
-- Procedure structure for GetAllHeadacheMedicines
-- ----------------------------
DROP PROCEDURE [dbo].[GetAllHeadacheMedicines]
GO
CREATE PROCEDURE [dbo].[GetAllHeadacheMedicines]
AS
	SELECT
dbo.Brand.Name as Brand,
dbo.Company.Name as Company,
dbo.Forms.Medicine_Form,
dbo.Generic.Name as Composition,
dbo.Generic.Gramage

FROM
dbo.Brand
INNER JOIN dbo.Company ON dbo.Brand.CompanyId = dbo.Company.Id
INNER JOIN dbo.Forms ON dbo.Brand.FormsId = dbo.Forms.Id
INNER JOIN dbo.Generic ON dbo.Generic.BrandId = dbo.Brand.Id
WHERE
dbo.Brand.Meta = 'Headache'

RETURN 0
GO

-- ----------------------------
-- Procedure structure for GetBrand
-- ----------------------------
DROP PROCEDURE [dbo].[GetBrand]
GO
CREATE PROCEDURE [dbo].[GetBrand]
	@id int
AS

SELECT
dbo.Brand.Name AS Brand,
dbo.Company.Name AS Company,
dbo.Generic.Name As Composition,
dbo.Generic.Gramage,
dbo.Forms.Medicine_Form

FROM
dbo.Brand
INNER JOIN dbo.Generic ON dbo.Generic.BrandId = dbo.Brand.Id
INNER JOIN dbo.Company ON dbo.Brand.CompanyId = dbo.Company.Id
INNER JOIN dbo.Forms ON dbo.Brand.FormsId = dbo.Forms.Id

WHERE Brand.Id = @id

RETURN 0
GO

-- ----------------------------
-- Procedure structure for GetBrandName
-- ----------------------------
DROP PROCEDURE [dbo].[GetBrandName]
GO
CREATE PROCEDURE [dbo].[GetBrandName]
	-- @Param1 varchar(30), @Param2 int
AS
BEGIN
SELECT
dbo.Brand.Name

FROM
dbo.Brand

END

GO

-- ----------------------------
-- Procedure structure for GetGenericMedicine
-- ----------------------------
DROP PROCEDURE [dbo].[GetGenericMedicine]
GO
CREATE PROCEDURE [dbo].[GetGenericMedicine]
@id int	
AS

SELECT DISTINCT
dbo.Generic.Name,
dbo.Generic.Overview,
dbo.Generic.Indications,
dbo.Generic.Side_Effects

FROM
dbo.Generic


WHERE dbo.Generic.Id = @id

return 0;
GO

-- ----------------------------
-- Procedure structure for GetGenericName
-- ----------------------------
DROP PROCEDURE [dbo].[GetGenericName]
GO
CREATE PROCEDURE [dbo].[GetGenericName]
	-- @Param1 varchar(30), @Param2 int
AS
BEGIN
	SELECT DISTINCT
dbo.Generic.Name

FROM
dbo.Generic

END

GO

-- ----------------------------
-- Procedure structure for GetInitialSystemConfiguration
-- ----------------------------
DROP PROCEDURE [dbo].[GetInitialSystemConfiguration]
GO

CREATE PROCEDURE [dbo].[GetInitialSystemConfiguration]
AS
	SELECT * FROM System_Configuration;


GO

-- ----------------------------
-- Procedure structure for InitializeFeedback
-- ----------------------------
DROP PROCEDURE [dbo].[InitializeFeedback]
GO

CREATE PROCEDURE [dbo].[InitializeFeedback]
AS
	SELECT * FROM Feedback

GO

-- ----------------------------
-- Procedure structure for UpdateDisclaimerCheck
-- ----------------------------
DROP PROCEDURE [dbo].[UpdateDisclaimerCheck]
GO

CREATE PROCEDURE [dbo].[UpdateDisclaimerCheck]
		@DisclaimerCheck bit
AS
	UPDATE System_Configuration SET Disclaimer_Check = @DisclaimerCheck;

GO

-- ----------------------------
-- Procedure structure for UpdateTheme
-- ----------------------------
DROP PROCEDURE [dbo].[UpdateTheme]
GO

CREATE PROCEDURE [dbo].[UpdateTheme]
	@theme int
AS
	UPDATE System_Configuration SET Theme_Toggle = @theme;

GO

-- ----------------------------
-- Indexes structure for table Brand
-- ----------------------------
CREATE INDEX [IX_Brand_Company] ON [dbo].[Brand]
([CompanyId] ASC) 
GO
CREATE INDEX [IX_Brand_Forms] ON [dbo].[Brand]
([FormsId] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table Brand
-- ----------------------------
ALTER TABLE [dbo].[Brand] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Company
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Company
-- ----------------------------
ALTER TABLE [dbo].[Company] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Dosages
-- ----------------------------
CREATE UNIQUE INDEX [IX_DOSAGES_BRAND] ON [dbo].[Dosages]
([BrandId] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table Dosages
-- ----------------------------
ALTER TABLE [dbo].[Dosages] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Forms
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Forms
-- ----------------------------
ALTER TABLE [dbo].[Forms] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Generic
-- ----------------------------
CREATE INDEX [IX_GenericBrand] ON [dbo].[Generic]
([BrandId] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table Generic
-- ----------------------------
ALTER TABLE [dbo].[Generic] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Brand]
-- ----------------------------
ALTER TABLE [dbo].[Brand] ADD FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Brand] ADD FOREIGN KEY ([FormsId]) REFERENCES [dbo].[Forms] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Dosages]
-- ----------------------------
ALTER TABLE [dbo].[Dosages] ADD FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Generic]
-- ----------------------------
ALTER TABLE [dbo].[Generic] ADD FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO
