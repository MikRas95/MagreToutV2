DROP TABLE [dbo].[DemoContactPerson];
DROP TABLE [dbo].[DemoPickupPoint];
DROP TABLE [dbo].[DemoEmployee];
DROP TABLE [dbo].[DemoMagAd]
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
	[PickupPointId] int FOREIGN KEY REFERENCES DemoPickupPoint(PickupPointId)
);

CREATE TABLE [dbo].[DemoEmployee](
	[EmployeeId] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] 		VARCHAR(255) 	NOT NULL,
	[Role] 		VARCHAR(30) 	NOT NULL,
	[Username] 	VARCHAR(255) 	NOT NULL,
	[Password] 	VARCHAR(255) 	NOT NULL
);

CREATE TABLE [dbo].[DemoAd](
	[AdId] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Company]	VARCHAR(255) 	NOT NULL,
	[AdPrice] 	DECIMAL
);

CREATE TABLE [dbo].[DemoMagazine](
	[VersionId] int  IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[Version] 	VARCHAR(255) 	NOT NULL
);

CREATE TABLE [dbo].[DemoMagAd](
	[MagAdId] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[VersionId] int NOT NULL FOREIGN KEY REFERENCES DemoMagazine(VersionId) ON DELETE CASCADE,
	[AdId] int NOT NULL FOREIGN KEY REFERENCES DemoAd(AdId) ON DELETE CASCADE
);

INSERT INTO [DemoPickupPoint] (Name,Address,PostalCode,Country,PhoneNumber,NoOfMagazine,OpeningTime,CloseningTime)
VALUES
  ('Gillian Mcpherson','108-9976 Vulputate St.','736775','Germany','53827974',911,'12:16','17:57'),
  ('Petra Blackburn','675-6335 Sit Av.','A9X 1S1','Germany','64033511',665,'11:14','12:48'),
  ('Kristen Henry','2223 Cum Rd.','26441-788','United Kingdom (Great Britain)','13554224',651,'11:52','22:38'),
  ('Clark Roach','Ap #996-3176 A St.','05757','Germany','04761939',668,'7:52','22:50'),
  ('Chelsea Chapman','Ap #345-495 Erat, St.','85-846','Germany','00887622',832,'8:47','23:42'),
  ('Willow Humphrey','644-1117 Gravida. Rd.','307244','United Kingdom (Great Britain)','24588543',870,'10:16','23:19'),
  ('Willow Kline','Ap #339-5202 Augue. Rd.','36120','United Kingdom (Great Britain)','24150830',43,'7:47','14:37'),
  ('Nora Pratt','Ap #447-3367 Et Rd.','61266-51144','Germany','97672855',3,'6:47','20:25'),
  ('Tanek Burnett','Ap #821-2303 Morbi Street','22120','Germany','05534273',320,'9:51','19:22'),
  ('Drew Rosales','8395 Donec Road','4933','Germany','81997083',681,'9:59','15:25');

INSERT INTO [DemoContactPerson] (Name,PhoneNumber,Email,PickupPointId)
VALUES
  ('Zoe Bradshaw','85535498','laoreet@aol.net',5),
  ('Rae Burgess','78223072','vehicula@outlook.ca',5),
  ('Amber Stout','91612601','interdum.nunc.sollicitudin@yahoo.net',6),
  ('Len Greene','32364493','dolor@protonmail.com',8),
  ('Hammett Mooney','09555656','adipiscing.elit.etiam@protonmail.edu',3),
  ('Reese Stein','33777454','eu.lacus.quisque@google.ca',2),
  ('Macon Butler','71274592','magnis.dis.parturient@outlook.org',6),
  ('Bryar Burch','03103404','consectetuer@hotmail.ca',3),
  ('Orla Morrow','81667256','interdum@outlook.ca',9),
  ('Galvin Ramirez','17359658','ut@aol.org',7);

INSERT INTO [DemoEmployee] (Name,Role,Username,Password)
VALUES
  ('Scarlett Wright','Employee','Pellentesque','arcu'),
  ('Alma Ramos','Admin','viverra.','Nunc'),
  ('Cally Hoover','Employee','orci.','nec,'),
  ('Ray Chen','Employee','purus','nec,'),
  ('Medge Gutierrez','Employee','dui.','lacus.'),
  ('Erin Savage','Employee','bibendum','semper.'),
  ('Desiree Knowles','Employee','semper','Fusce'),
  ('Graham Stevenson','Admin','at','ac'),
  ('Igor Suarez','Employee','amet','et'),
  ('Cailin Simmons','Employee','eu','Nulla');

INSERT INTO [DemoAd] (Company,AdPrice)
VALUES
  ('Employee',83167),
  ('Admin',25137),
  ('Admin',64219),
  ('Admin',64445),
  ('Employee',13790),
  ('Employee',4481),
  ('Admin',41535),
  ('Employee',68794),
  ('Employee',62050),
  ('Admin',5502);

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

INSERT INTO [DemoMagAd] (VersionId, AdId)
VALUES
	(1,2),
	(2,1),
	(3,5),
	(4,3),
	(5,6),
	(6,8),
	(7,2),
	(8,9),
	(9,10),
	(10,7)
