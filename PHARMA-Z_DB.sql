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

Date: 2019-03-27 18:32:32
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
[Uses] varchar(50) NULL ,
[Precautions] varchar(50) NULL ,
[Side_Effects] varchar(50) NULL ,
[Overview] varchar(50) NULL ,
[Meta] varchar(50) NULL ,
[IsFavorite] bit NULL ,
[IsRecent] bit NULL ,
[FormsId] bit NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Brand]', RESEED, 56)
GO

-- ----------------------------
-- Records of Brand
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Brand] ON
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'1', N'Disprin', N'1', null, null, null, null, N'Headache', null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'2', N'Ponstan', N'2', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'3', N'Panadol', N'3', null, null, null, null, N'Fever', null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'4', N'Brufen', N'3', null, null, null, null, N'Fever', null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'5', N'Disprol', N'1', null, null, null, null, N'Fever', null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'6', N'Disprin CV', N'1', null, null, null, null, N'Headache', null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'7', N'Nims', N'4', null, null, null, null, N'Fever', null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'8', N'Nuberol', N'5', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'9', N'Nuberol Forte', N'5', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'10', N'Septran', N'6', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'11', N'Septran DS', N'6', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'12', N'Danzen', N'7', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'13', N'Neurobion', N'8', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'14', N'Methycobal', N'9', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'15', N'Cac-1000', N'10', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'16', N'Qalsan-D', N'10', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'17', N'Osnate-800', N'11', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'18', N'Surbex-Z', N'3', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'19', N'Surbex-T', N'3', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'20', N'Dayalets', N'3', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'21', N'Cecon', N'3', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'22', N'Klint', N'4', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'23', N'Buscopin', N'8', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'24', N'Buscopan-Plus', N'8', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'25', N'Velosef', N'6', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'26', N'Velora', N'12', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'27', N'Azit', N'13', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'28', N'Azithro', N'1001', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'29', N'Augmentin', N'6', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'30', N'Augmentin-BD', N'6', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'31', N'Mucain', N'2', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'32', N'Tixylix Linctus', N'1002', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'33', N'Polybion', N'8', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'34', N'Polybion-Z', N'8', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'35', N'Polybion-Forte', N'8', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'36', N'Polybion-N', N'8', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'37', N'Polyfax', N'6', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'38', N'Polyfax-Plus', N'6', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'39', N'Acefyl', N'1003', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'40', N'Acicon', N'1004', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'41', N'Domel', N'1004', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'42', N'Motilium', N'1005', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'43', N'Motilium-V', N'1005', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'44', N'Dyclo', N'1006', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'45', N'Dyclo-GR', N'1006', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'46', N'Dicloran', N'4', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'47', N'Dicloran-SR', N'4', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'48', N'Novidat', N'4', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'49', N'Febrol', N'1004', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'50', N'Febrol-Extra', N'1004', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'51', N'Rigix', N'11', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'52', N'Esso', N'1008', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'53', N'Eskem', N'1009', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'54', N'Risek', N'1010', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'55', N'Diagesic', N'1011', null, null, null, null, null, null, null, null)
GO
GO
INSERT INTO [dbo].[Brand] ([Id], [Name], [CompanyId], [Uses], [Precautions], [Side_Effects], [Overview], [Meta], [IsFavorite], [IsRecent], [FormsId]) VALUES (N'56', N'Acetaminophen', null, null, null, null, null, null, null, null, null)
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
[Id] int NOT NULL ,
[Medicine_Form] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of Forms
-- ----------------------------

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
[IsRecent] bit NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Generic]', RESEED, 20)
GO

-- ----------------------------
-- Records of Generic
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Generic] ON
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'2', N'Sulphamethoxazole', null, N'11', N'800mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'3', N'Sulphamethoxazole', null, N'10', N'400mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'4', N'Orphenadrine', null, N'9', N'50mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'5', N'Orphenadrine', null, N'8', N'35mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'6', N'Nimesulide', null, N'7', N'100mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'7', N'Aspirin', null, N'6', N'100mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'8', N'Paracetamol', null, N'5', N'500mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'9', N'Ibuprofen ', null, N'4', N'200mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'10', N'Paracetamol', null, N'3', N'500mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'11', N'Mefenamic Acid', null, N'2', N'50mg/5mlx', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'12', N'Aspirin ', null, N'1', N'300mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'13', N'trimethoprime', null, N'11', N'160mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'14', N'trimethoprime', null, N'10', N' 80mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'15', N' paracetamol', null, N'9', N' 650mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'16', N'paracetamol', null, N'8', N'450mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'17', N'Ibuprofen', null, N'4', N'600mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'18', N'Ibuprofen', null, N'4', N'400mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'19', N'calcium carbonate', null, N'1', N'90mg', null)
GO
GO
INSERT INTO [dbo].[Generic] ([Id], [Name], [Overview], [BrandId], [Gramage], [IsRecent]) VALUES (N'20', N'citric acid', null, N'1', N'30mg', null)
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
INSERT INTO [dbo].[System_Configuration] ([Theme_Toggle], [Disclaimer_Check]) VALUES (N'0', N'1')
GO
GO

-- ----------------------------
-- Procedure structure for GetAllGeneric
-- ----------------------------
DROP PROCEDURE [dbo].[GetAllGeneric]
GO
CREATE PROCEDURE [dbo].[GetAllGeneric]
AS
	SELECT * from Generic
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
dbo.Brand.Name,
dbo.Company.Name as Company,
dbo.Brand.Overview,
dbo.Brand.Uses,
dbo.Brand.Precautions,
dbo.Brand.Side_Effects
FROM
dbo.Brand
INNER JOIN dbo.Company ON dbo.Brand.CompanyId = dbo.Company.Id
WHERE
dbo.Brand.Meta = 'Headache'

RETURN 0
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

-- ----------------------------
-- Foreign Key structure for table [dbo].[Dosages]
-- ----------------------------
ALTER TABLE [dbo].[Dosages] ADD FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Generic] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Generic]
-- ----------------------------
ALTER TABLE [dbo].[Generic] ADD FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO
