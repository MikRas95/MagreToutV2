DROP TABLE [dbo].[DemoContactPerson];
DROP TABLE [dbo].[DemoPickupPoint];
DROP TABLE [dbo].[DemoEmployee];
DROP TABLE [dbo].[DemoAd]
DROP TABLE [dbo].[DemoMagazine]


CREATE TABLE [dbo].[DemoPickupPoint] (
	[PickupPointId] int  IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[Name] 			VARCHAR(255) 	NOT NULL,
	[Address] 		VARCHAR(255) 	NOT NULL,
	[PostalCode]	VARCHAR(20) 	NOT NULL,
	[Country] 		VARCHAR(60) 	NOT NULL,
	[PhoneNumber] 	VARCHAR(20),
	[NoOfMagazine] 	int, 			
	[OpeningTime] 	Time,
	[CloseningTime] Time			
);

CREATE TABLE [dbo].[DemoContactPerson] (
    [ContactPersonId] int  IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [Name] 			VARCHAR(50) 	NOT NULL,
    [PhoneNumber] 	VARCHAR(50)		NOT NULL,
    [Email] 		VARCHAR(50) 	NOT NULL,
	[PickupPointId] int FOREIGN KEY REFERENCES DemoPickupPoint(PickupPointId) ON DELETE CASCADE
);

CREATE TABLE [dbo].[DemoEmployee](
	[EmployeeId] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] 		VARCHAR(255) 	NOT NULL,
	[Role] 		VARCHAR(30) 	NOT NULL,
	[Username] 	VARCHAR(255) 	NOT NULL,
	[Password] 	VARCHAR(255) 	NOT NULL
);

CREATE TABLE [dbo].[DemoMagazine](
	[VersionId] int  IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[Version] 	VARCHAR(255) 	NOT NULL,
);

CREATE TABLE [dbo].[DemoAd](
	[AdId] int IDENTITY (1,1) NOT NULL PRIMARY KEY,
	[Company] VARCHAR (255) NOT NULL,
	[AdPrice] DECIMAL (18) NULL,
	[VersionId] int NOT NULL FOREIGN KEY REFERENCES DemoMagazine(VersionId)
  ON DELETE CASCADE
);

GO
SET IDENTITY_INSERT [dbo].[DemoPickupPoint] ON
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1, N'Land & Fritid Bjerringbro', N'Jørgens Allé 33', N'8850', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (2, N'Land & Fritid Bårse', N'Korndrevet 4, Bårse', N'4720', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (3, N'Land & Fritid Grenå', N'Djurslandskajen 1', N'8500', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (4, N'Land & Fritid Hjørring', N'Johs. E Rasmussens Vej 1', N'9800', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (5, N'Land & Fritid Holstebro', N'Mads Bjerres Vej 2', N'7500', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (6, N'Land & Fritid Nr. Nebel', N'Borkvej 63', N'6830', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (7, N'Land & Fritid Nr. Vium', N'Viumvej 42', N'6920', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (8, N'Land & Fritid Nykøbing Mors', N'Ringvejen 72', N'7900', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (9, N'Land & Fritid Odder', N'Højmarksvej 1', N'8300', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (10, N'Land & Fritid Randers', N'Lorentzgade 19', N'8900', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1214, N'Land & Fritid Rom, Lemvig', N'Overbyvej 4, Rom ', N'7620', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1215, N'Land & Fritid Rudkøbing', N'Nørrebro 204', N'5900', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1216, N'Land & Fritid Rødekro', N'Mjølsvej 60', N'6230', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1217, N'Land & Fritid Skive', N'Nordhavnsvej 10', N'7800', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1218, N'Land & Fritid Skjern', N'Industrivej 33', N'6900', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1219, N'Land & Fritid Skærbæk', N'Industrivej 36', N'6780', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1220, N'Land & Fritid Stagstrup', N'Møgelvej 3, Stagstrup', N'7752', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1221, N'Land & Fritid Sundeved', N'Højsvej 1, Sundeved', N'6400', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1222, N'Land & Fritid Sørup', N'Hjedsbækvej 69, Sørup', N'9530', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1223, N'Land & Fritid Thisted ', N'tigervej 1', N'7700', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1224, N'Land & Fritid Vester Hassing', N'Aslundvej 42', N'9310', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1225, N'Land & Fritid Vrå', N'Vestre Ringvej 21 ', N'9760', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1226, N'Land & Fritid Ølgod', N'Industrivej 11', N'6870', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1227, N'Land & Fritid Åbybro', N'Mølhavevej 7-9', N'9440', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1228, N'Land & Fritid Åkirkeby', N'Birgersvej 1', N'3720', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1229, N'Land & Fritid Aars', N'Nordvestvej 1', N'9600', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1230, N'St. Hippolyt', N'Øgelundvej 7, Blåhøj', N'7330', N'Danmark', N'12345678', 500, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1231, N'TIKA Rideudstyr', N'Solbjerg Plantagevej 3', N'6731', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1232, N'Absolute Horsetrucks', N'Erhvervsparken 7', N'9500', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1233, N'Vedsted Mølle', N'Tøndervej 31', N'6500', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1234, N'Klintholm Lake Apartments', N'Langebjergvej 1', N'4791', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1235, N'Equitron', N'Vestergade 3', N'6823', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1236, N'Cheval Liberté', N'Stenbroallé 1-3', N'6650', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1237, N'Cheval Liberté', N'Sirvej 19', N'7500', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1238, N'Cheval Liberté', N'Platanvænget 18', N'8990', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1239, N'Miljøfoder A/S', N'Vognmagervej 21', N'8800', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1240, N'Esbjerg og Omegns Rideklub', N'Seljborg Kirkevej 30', N'6710', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1241, N'Krogsgaard Hestefoder', N'Nejsvej 30C', N'6310', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1242, N'Concordia Forsikring', N'Tietgens Allé 112', N'5230', N'Danmark', N'12345678', 25, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1243, N'MakeBe/Kunddahl', N'Haundrupvej 3', N'5863', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1244, N'Fyns Rideudstyr', N'Rugårdsvej 910', N'5471', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1245, N'Otterup Hobbyfoder', N'Søndergade 63', N'5450', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1246, N'Equiscout Rideudstyr', N'Blækhatten 33', N'5220', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1247, N'Kellerups Rideudstyr', N'Boltinggårdvej 5', N'5750', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1248, N'Heidi''s Rideudstyr', N'Rosningvej 119', N'4953', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1249, N'Riders Deluxe', N'Vedskøllevej 35', N'4600', N'Danmark', N'12345678', NULL, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1250, N'Land & Fritid Børkop', N'Industrivej 41', N'7080', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1251, N'Land & Fritid Hedensted', N'Blæsbjergvej 46', N'8722', N'Danmark', N'12345678', 200, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1252, N'Land & Fritid Ringe', N'Øster Ringvej 39-41', N'5750', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1253, N'Land & Fritid Ulbølle', N'Fåborgvej 127B', N'5762', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1254, N'Land & Fritid Frankfri', N'Hellevad 16', N'5690', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1255, N'Land & Fritid Årup', N'Industrivej 1, Grønnemose', N'5560', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1256, N'Skydsbjerg Horsetrucks', N'Skydsbjergvej 43', N'5463', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1257, N'Kristineholm Rideudstyr', N'Nordlige Bjergvej 7', N'8270', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1258, N'Hestehuset Husted/Husted Horse', N'Randersvej 3B, Følle', N'8410', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1259, N'Helles Rideudstyr ', N'Borgpladsen 2', N'6800', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1260, N'Horze Næstved', N'Profilbuen 1', N'4700', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1261, N'Lundemøllen', N'Fuglebjerglundvej 7', N'4250', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1262, N'Hasselø Rideudstyr', N'Hasseløvej 90', N'4800', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1263, N'Rytterhuset Viborg', N'Koldingvej 217', N'8800', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1264, N'Malgré Tout Media A/S', N'Tåstruphøj 6', N'4300', N'Danmark', N'12345678', NULL, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1265, N'Land & Fritid Fredensborg ', N'Præstemosevej 2B', N'3480', N'Danmark', N'12345678', 500, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1266, N'Land & Fritid Skævinge', N'Skævingevej 23', N'3320', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1267, N'Land & Fritid Vig', N'Møllevej 56, ', N'4560', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1268, N'Land & Fritid Tølløse', N'Agrovej 5', N'4340', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1269, N'Land & Fritid Ringsted', N'Jættevej 11', N'4100', N'Danmark', N'12345678', 200, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1270, N'Land & Fritid Bromme', N'Munebjergvej 29 ', N'4190', N'Danmark', N'12345678', 150, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1271, N'Regulator Complete', N'Sofienlund 16A ', N'7560', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1272, N'Horse Square (NAF)', N'Lindholmvej 5 J', N'3550', N'Danmark', N'12345678', 300, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1273, N'Egolibris', N'Allerødvej 30', N'3450', N'Danmark', N'12345678', 25, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1274, N'Lille Hellebæk Sadelmageri', N'Sundbylillevej 48', N'3600', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1275, N'NAG HorsePro', N'Vestergade 14', N'3200', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1276, N'NAG HorsePro', N'Borupvej 65', N'3320', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1277, N'GLS Foder', N'Edelgavevej 5', N'2765', N'Danmark', N'12345678', 200, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1278, N'Top Reiter', N'Torupvejen 76', N'3390', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1279, N'Højlund Mølle', N'Ørbækvej 268B', N'5892', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1280, N'Højlund Mølle', N'Møllevej 26', N'5792', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1281, N'Højlund Mølle afd. Haarby', N'Trunderupvej 10', N'5683', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1282, N'Højlund Mølle afd. Aarup', N'Holmelund 32', N'5560', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1283, N'Equine Power', N'Gamle Tingvej 1, Hvejsel', N'7300', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1284, N'Mental-Coach.dk', N'Stenderupvej 129', N'6092', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1285, N'Dyrecenter Midt', N'Hjermvej 4', N'7500', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1286, N'B-Steensgaard.dk', N'Klinkvej 43', N'6623', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1287, N'Winters Rideudstyr', N'Kalundborgvej 35', N'4200', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1288, N'Hestens & Hundens Helse', N'Fårupvej 81', N'8471', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1289, N'Dyr I Centrum', N'Bytoften 5', N'4000', N'Danmark', N'12345678', 200, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1290, N'Dyre-Loppen', N'Vassingerødvej 87b', N'3540', N'Danmark', N'12345678', 200, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1291, N'Hørsholm Hestepraksis ApS', N'Kongevejen 124', N'3480', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1292, N'Hemmeshøj Hestefoder', N'Gammellongvej 1', N'4241', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1293, N'Jemo Trading', N'Kystvejen 252C', N'4671', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1294, N'Grønagergård', N'Tjærebyvej 111', N'4000', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1295, N'Castle Horse Feeds', N'Højskolevej 1', N'3600', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1296, N'Contact Saddlery', N'Grønagergårdsvej 9', N'4070', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1297, N'EquiLight Danmark', N'Seerdrupvej 9', N'4200', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1298, N'NIVO', N'Erik Husfeldts Vej 7', N'2630', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1299, N'Eldorado A/S', N'Ole Rømers Vej 31-35', N'6100', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1300, N'Bioform', N'Højlundsparken 81', N'8355', N'Danmark', N'12345678', 100, N'12:00:00', N'18:00:00')
INSERT INTO [dbo].[DemoPickupPoint] ([PickupPointId], [Name], [Address], [PostalCode], [Country], [PhoneNumber], [NoOfMagazine], [OpeningTime], [CloseningTime]) VALUES (1301, N'Nynnes Beslagsmedie', N'Kirkegårdsvej 15', N'2300', N'Danmark', N'12345678', 50, N'12:00:00', N'18:00:00')
SET IDENTITY_INSERT [dbo].[DemoPickupPoint] OFF

GO
INSERT INTO [DemoContactPerson] (Name,PhoneNumber,Email,PickupPointId)
VALUES
  ('Zoe Bradshaw','85535498','laoreet@aol.net',5),
  ('Rae Burgess','78223072','vehicula@outlook.ca',1),
  ('Amber Stout','91612601','interdum.nunc.sollicitudin@yahoo.net',6),
  ('Len Greene','32364493','dolor@protonmail.com',8),
  ('Hammett Mooney','09555656','adipiscing.elit.etiam@protonmail.edu',4),
  ('Reese Stein','33777454','eu.lacus.quisque@google.ca',2),
  ('Macon Butler','71274592','magnis.dis.parturient@outlook.org',10),
  ('Bryar Burch','03103404','consectetuer@hotmail.ca',3),
  ('Orla Morrow','81667256','interdum@outlook.ca',9),
  ('Galvin Ramirez','17359658','ut@aol.org',7);

INSERT INTO [DemoEmployee] (Name,Role,Username,Password)
VALUES
  ('Mikkel','Admin','Mikkel','Password'),
  ('GoF','Admin','u','p'),
  ('Cally Hoover','Employee','orci.','nec,'),
  ('Ray Chen','Employee','purus','nec,'),
  ('Medge Gutierrez','Employee','dui.','lacus.'),
  ('Erin Savage','Employee','bibendum','semper.'),
  ('Desiree Knowles','Employee','semper','Fusce'),
  ('Graham Stevenson','Admin','at','ac'),
  ('Igor Suarez','Employee','amet','et'),
  ('Cailin Simmons','Employee','eu','Nulla');

  
INSERT INTO [DemoMagazine] (Version)
VALUES
  ('36557807-9'),
  ('11849663-9'),
  ('32822886-6'),
  ('2225423-5'),
  ('43259958-2'),
  ('4773554-8'),
  ('3052084-K'),
  ('30192926-9'),
  ('6541746-4'),
  ('36758228-6');

INSERT INTO [DemoAd] (Company, AdPrice, VersionId)
VALUES
  ('Aqua Nordic',83167,2),
  ('Novo Nordisk',25137,3),
  ('Hjemlig',64219,5),
  ('DR',64445,1),
  ('Skoda',13790,6),
  ('Nord VPN',4481,6),
  ('Asus',41535,6),
  ('Spodify',68794,7),
  ('Amazon',62050,8),
  ('Facebook',5502,9);




