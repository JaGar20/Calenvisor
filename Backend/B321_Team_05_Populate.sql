
/*********************************************************
	Script Name: B321_Team_05_Populate.sql
	Course: ISAT B321
	Deliverable #3 - Create & Populate SQL Script
	Developers: Jonathan Garcia Arias & Jason Garcia Arias
	Last Updated: 04.30.2025

	Purpose: Drop and Create Tables, Roles, Login, and
	Users. Populate the Tables.
***********************************************************/

/*DROP ROLE, LOGIN, USER*/


--USE b320
--GO

--DROP USER IF EXISTS B321_sp25_Team05
--GO

--DROP ROLE IF EXISTS [ADMIN] 
--GO

--USE Master
--GO
 
--DROP LOGIN B321_sp25_Team05
--GO


/* CREATE ROLE, LOGIN, USER */

--USE Master
--GO

--CREATE LOGIN B321_sp25_Team05
--	WITH Password = 'P4ssword!'
--GO

--USE b320
--GO

--CREATE USER B321_sp25_Team05
--	FOR LOGIN B321_sp25_Team05
--GO

--CREATE ROLE [ADMIN]

--ALTER ROLE [ADMIN] ADD MEMBER [B321_sp25_Team05]
--GO

-- Proceed to execute the insert tables. 



-- Insert Tables ---
USE b320
GO

--- Drop Tables If Exists ---
DROP TABLE IF EXISTS [dbo].[Meetings]
GO
DROP TABLE IF EXISTS [dbo].[Availability]
GO
DROP TABLE IF EXISTS [dbo].[Locations]
GO
DROP TABLE IF EXISTS [dbo].[HourBlocks]
GO
DROP TABLE IF EXISTS [dbo].[Advisors]
GO
DROP TABLE IF EXISTS [dbo].[Students]
GO


--- Create Table ----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Students(
	StudentID INT IDENTITY(1,1) NOT NULL,
	StudentFName VARCHAR(50) NULL,
	StudentMName VARCHAR(50) NULL,
	StudentLName VARCHAR(50) NULL,
	StudentEmail VARCHAR(50) NULL,
	USCBID VARCHAR(50) NULL
	CONSTRAINT PK_Students PRIMARY KEY CLUSTERED
	  (
		StudentID ASC
	  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Advisors(
	AdvisorID INT IDENTITY(1,1) NOT NULL,
	AdvisorFName VARCHAR(50) NULL,
	AdvisorMName VARCHAR(50) NULL,
	AdvisorLName VARCHAR(50) NULL,
	AdvisorEmail VARCHAR(50) NULL,
	OfficeAddress VARCHAR(50) NULL,
	PhoneNumber VARCHAR(50) NULL
	CONSTRAINT PK_Advisors PRIMARY KEY CLUSTERED
	  (
		AdvisorID ASC
	  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Locations](
	LocationID INT IDENTITY(1,1) NOT NULL,
	LocationType VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Locations PRIMARY KEY CLUSTERED
	  (
		LocationID ASC
	  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE HourBlocks(
	HourBlockID INT IDENTITY(1,1) NOT NULL,
	StartBlock VARCHAR(50) NOT NULL,
	EndBlock VARCHAR(50) NOT NULL
	CONSTRAINT PK_HourBlocks PRIMARY KEY CLUSTERED
	  (
		HourBlockID ASC
	  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Availability](
	AvailabilityID INT IDENTITY(1,1) NOT NULL,
	AdvisorID INT NULL,
	LocationID INT NULL,
	HourBlockID INT NULL,
	AvailableDate DATE NULL
	CONSTRAINT PK_Availability PRIMARY KEY CLUSTERED
	  (
		AvailabilityID ASC
	  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Meetings(
	MeetingID INT IDENTITY(1,1) NOT NULL,
	StudentID INT NULL,
	AvailabilityID INT NULL,
	MeetingName VARCHAR(255) NULL,
	[Status] VARCHAR(50) NULL
	CONSTRAINT PK_Meetings PRIMARY KEY CLUSTERED
	  (
		MeetingID ASC
	  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) ON [PRIMARY]
GO


--- Insert Tables ---
SET IDENTITY_INSERT Students ON 
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (1,'Damon','Johnson','Bradley','damonjb@email.uscb.edu','X27115310');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (2,'Rick','Vicktor','Jones','rickvj@email.uscb.edu','Q58343504');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (3,'Jerry','George','Walker','jerrygw@email.uscb.edu','I24379114');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (4,'Melissa','Lilly','Hill','melissalh@email.uscb.edu','P17452803');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (5,'Anthony','Caden','Gomez','anthonycg@email.uscb.edu','Q72514098');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (6,'Terrence','Wilson','Johnson','terrencwj@email.uscb.edu','I54064382');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (7,'Abby','Jayla','Smith','abbyjs@email.uscb.edu','U58616841');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (8,'Jordan','Donovan','Bennett','jordandb@email.uscb.edu','P68983097');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (9,'Kylie','Thompson','Hinson','kylieth@email.uscb.edu','P27343843');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (10,'Jeremy','Cody','Wagner','jeremycw@email.uscb.edu','B90912792');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (11,'Alexa','Michelle','Martinez','alexamm@email.uscb.edu','C63542732');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (12,'Olivia','Bella','Beck','oliviabb@email.uscb.edu','A90998191');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (13,'John','Denzel','Morris','johndm@email.uscb.edu','S48320403');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (14,'Vanessa','Sheldon','Young','vanessasy@email.uscb.edu','Z18377717');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (15,'Freddy','Mick','Gordon','freddymg@email.uscb.edu','L33877577');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (16,'Mitchell','Blessing','Myles','mitchelbm@email.uscb.edu','Z78304063');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (17,'Cory','Kyle','Beasley','corykb@email.uscb.edu','K51916488');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (18,'Thomas','Kevin','Rivers','thomaskr@email.uscb.edu','U85473212');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (19,'Ashley','Jonathan','Dola','ashleyjd@email.uscb.edu','F43171816');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (20,'Liam','Erik','Brown','liameb@email.uscb.edu','N93342094');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (21,'Martha','Davis','Cousins','marthadc@email.uscb.edu','A40462037');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (22,'Daniel','Albert','Williams','danielaw@email.uscb.edu','L29071938');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (23,'Nathan','Mark','Graham','nathanmg@email.uscb.edu','Z33426203');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (24,'Avery','Joseph','Harkless','averyjh@email.uscb.edu','N27936040');
INSERT INTO Students(StudentID,StudentFName,StudentMName,StudentLName,StudentEmail,USCBID) VALUES (25,'Samantha','Leo','Green','samanthlg@email.uscb.edu','F91541354');
SET IDENTITY_INSERT Students OFF

SET IDENTITY_INSERT Advisors ON
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (1,'Morgin',NULL,'Jones-Williams','morgin@uscb.edu','SciTech 219','(843) 208-8313');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (2,'Timothy','J','Hogenboom','timothyh@uscb.edu','Hargray 253','(843) 208-8103');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (3,'Manuel','J','Sanders','mjsander@uscb.edu','Hargray 220','(843) 208-8106');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (4,'Davide',NULL,'Fusi','dfusi@uscb.edu','SciTech 215','(843) 208-8172');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (5,'Volkan',NULL,'Sevim','vsevim@uscb.edu','Hargray 216','(843) 208-8275');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (6,'Rosie',NULL,'Villiancourt','rosie.villiancourt@uscb.edu','Library 213','(843) 208-8051');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (7,'Chelsea','M','Ponce','cponce@uscb.edu','Library 216','(843) 208-8054');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (8,'Candice',NULL,'Sutton','cblawat@uscb.edu','Library 215','(843) 208-8057');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (9,'William','J','Thrasher','thrashw@uscb.edu','SciTech 220','(843) 208-8163');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (10,'Paul','H','Comitz','pcomitz@uscb.edu','1100 Boundary Street',NULL);
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (11,'Xuwei',NULL,'Liang','xliang@uscb.edu','SciTech 144','(843) 208-8227');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (12,'Ronald',NULL,'Erdei','erdei@uscb.edu','Hargray 162A','(843) 208-8221');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (13,'Brian','A','Canada','bcanada@uscb.edu','SciTech 145','(843) 208-8314');
INSERT INTO Advisors(AdvisorID,AdvisorFName,AdvisorMName,AdvisorLName,AdvisorEmail,OfficeAddress,PhoneNumber) VALUES (14,'Xiaomei',NULL,'Zhang','xiaomei@uscb.edu','SciTech 143','(843) 208-8377');
SET IDENTITY_INSERT Advisors OFF

SET IDENTITY_INSERT HourBlocks ON
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (1,'0:00','0:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (2,'0:15','0:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (3,'0:30','0:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (4,'0:45','1:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (5,'1:00','1:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (6,'1:15','1:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (7,'1:30','1:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (8,'1:45','2:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (9,'2:00','2:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (10,'2:15','2:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (11,'2:30','2:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (12,'2:45','3:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (13,'3:00','3:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (14,'3:15','3:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (15,'3:30','3:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (16,'3:45','4:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (17,'4:00','4:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (18,'4:15','4:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (19,'4:30','4:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (20,'4:45','5:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (21,'5:00','5:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (22,'5:15','5:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (23,'5:30','5:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (24,'5:45','6:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (25,'6:00','6:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (26,'6:15','6:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (27,'6:30','6:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (28,'6:45','7:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (29,'7:00','7:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (30,'7:15','7:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (31,'7:30','7:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (32,'7:45','8:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (33,'8:00','8:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (34,'8:15','8:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (35,'8:30','8:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (36,'8:45','9:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (37,'9:00','9:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (38,'9:15','9:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (39,'9:30','9:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (40,'9:45','10:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (41,'10:00','10:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (42,'10:15','10:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (43,'10:30','10:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (44,'10:45','11:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (45,'11:00','11:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (46,'11:15','11:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (47,'11:30','11:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (48,'11:45','12:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (49,'12:00','12:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (50,'12:15','12:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (51,'12:30','12:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (52,'12:45','13:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (53,'13:00','13:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (54,'13:15','13:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (55,'13:30','13:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (56,'13:45','14:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (57,'14:00','14:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (58,'14:15','14:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (59,'14:30','14:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (60,'14:45','15:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (61,'15:00','15:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (62,'15:15','15:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (63,'15:30','15:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (64,'15:45','16:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (65,'16:00','16:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (66,'16:15','16:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (67,'16:30','16:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (68,'16:45','17:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (69,'17:00','17:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (70,'17:15','17:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (71,'17:30','17:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (72,'17:45','18:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (73,'18:00','18:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (74,'18:15','18:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (75,'18:30','18:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (76,'18:45','19:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (77,'19:00','19:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (78,'19:15','19:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (79,'19:30','19:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (80,'19:45','20:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (81,'20:00','20:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (82,'20:15','20:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (83,'20:30','20:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (84,'20:45','21:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (85,'21:00','21:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (86,'21:15','21:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (87,'21:30','21:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (88,'21:45','22:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (89,'22:00','22:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (90,'22:15','22:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (91,'22:30','22:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (92,'22:45','23:00');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (93,'23:00','23:15');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (94,'23:15','23:30');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (95,'23:30','23:45');
INSERT INTO HourBlocks(HourBlockID,StartBlock,EndBlock) VALUES (96,'23:45','0:00');
SET IDENTITY_INSERT HourBlocks OFF

SET IDENTITY_INSERT Locations ON 
INSERT INTO Locations(LocationID, LocationType) VALUES (1,'Phone Number');
INSERT INTO Locations(LocationID, LocationType) VALUES (2,'Zoom');
INSERT INTO Locations(LocationID, LocationType) VALUES (3,'Office Address');
SET IDENTITY_INSERT Locations OFF

SET IDENTITY_INSERT [Availability] ON
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (1,1,3,43,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (2,1,3,44,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (3,1,3,45,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (4,1,3,46,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (5,1,3,63,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (6,1,3,64,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (7,1,3,65,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (8,1,3,66,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (9,1,3,41,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (10,1,3,42,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (11,1,3,43,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (12,1,3,44,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (13,1,3,43,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (14,1,3,44,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (15,1,3,45,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (16,1,3,46,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (17,1,3,63,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (18,1,3,64,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (19,1,3,44,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (20,1,3,63,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (21,1,3,64,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (22,1,3,51,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (23,1,3,52,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (24,1,3,53,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (25,1,3,54,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (26,1,3,63,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (27,1,3,64,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (28,1,3,51,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (29,1,3,52,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (30,1,3,53,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (31,1,3,54,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (32,1,3,63,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (33,1,3,64,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (34,1,3,51,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (35,1,3,52,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (36,1,3,53,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (37,1,3,54,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (38,1,3,63,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (39,2,3,46,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (40,2,3,47,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (41,2,3,48,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (42,2,3,49,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (43,2,3,57,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (44,2,3,58,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (45,2,3,46,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (46,2,3,47,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (47,2,3,48,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (48,2,3,49,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (49,2,3,57,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (50,2,3,40,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (51,2,3,41,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (52,2,3,42,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (53,2,3,43,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (54,2,3,49,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (55,2,3,37,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (56,2,3,38,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (57,2,3,39,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (58,2,3,40,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (59,2,3,41,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (60,2,3,42,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (61,2,3,47,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (62,2,3,48,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (63,2,3,49,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (64,2,3,50,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (65,2,3,51,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (66,2,3,46,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (67,2,3,47,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (68,2,3,48,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (69,2,3,49,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (70,2,3,46,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (71,2,3,47,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (72,2,3,48,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (73,2,3,49,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (74,2,3,57,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (75,2,3,46,'8-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (76,2,3,47,'8-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (77,2,3,48,'8-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (78,3,3,36,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (79,3,3,37,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (80,3,3,38,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (81,3,3,39,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (82,3,3,40,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (83,3,3,36,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (84,3,3,37,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (85,3,3,38,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (86,3,3,39,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (87,3,3,40,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (88,3,3,41,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (89,3,3,36,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (90,3,3,37,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (91,3,3,38,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (92,3,3,39,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (93,3,3,40,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (94,3,3,36,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (95,3,3,37,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (96,3,3,38,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (97,3,3,40,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (98,3,3,51,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (99,3,3,52,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (100,3,3,53,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (101,3,3,36,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (102,3,3,37,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (103,3,3,38,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (104,3,3,36,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (105,3,3,37,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (106,3,3,37,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (107,3,3,38,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (108,3,3,42,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (109,3,3,43,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (110,3,3,37,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (111,3,3,38,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (112,3,3,39,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (113,3,3,40,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (114,3,3,41,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (115,3,3,42,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (116,3,3,43,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (117,3,3,44,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (118,3,3,51,'9-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (119,3,3,52,'9-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (120,3,3,53,'9-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (121,4,3,50,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (122,4,3,51,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (123,4,3,52,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (124,4,3,53,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (125,4,3,54,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (126,4,3,55,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (127,4,3,56,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (128,4,3,60,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (129,4,3,61,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (130,4,3,62,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (131,4,3,52,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (132,4,3,53,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (133,4,3,54,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (134,4,3,55,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (135,4,3,53,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (136,4,3,54,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (137,4,3,55,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (138,4,3,53,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (139,4,3,54,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (140,4,3,55,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (141,4,3,60,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (142,4,3,61,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (143,4,3,50,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (144,4,3,51,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (145,4,3,44,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (146,4,3,45,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (147,4,3,46,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (148,4,3,47,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (149,4,3,50,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (150,4,3,51,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (151,4,3,52,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (152,4,3,53,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (153,5,3,41,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (154,5,3,42,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (155,5,3,43,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (156,5,3,44,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (157,5,3,41,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (158,5,3,42,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (159,5,3,43,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (160,5,3,44,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (161,5,3,51,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (162,5,3,41,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (163,5,3,42,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (164,5,3,43,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (165,5,3,44,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (166,5,3,51,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (167,5,3,41,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (168,5,3,42,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (169,5,3,43,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (170,5,3,44,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (171,5,3,51,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (172,5,3,41,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (173,5,3,42,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (174,5,3,43,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (175,5,3,41,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (176,5,3,42,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (177,5,3,41,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (178,5,3,42,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (179,5,3,43,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (180,5,3,44,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (181,5,3,51,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (182,5,3,52,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (183,5,3,43,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (184,5,3,44,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (185,5,3,51,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (186,5,3,52,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (187,5,3,43,'9-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (188,5,3,44,'9-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (189,5,3,51,'9-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (190,5,3,52,'9-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (191,5,3,53,'9-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (192,6,3,37,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (193,6,3,38,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (194,6,3,39,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (195,6,3,40,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (196,6,3,37,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (197,6,3,38,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (198,6,3,39,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (199,6,3,40,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (200,6,3,41,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (201,6,3,55,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (202,6,3,56,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (203,6,3,57,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (204,6,3,58,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (205,6,3,59,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (206,6,3,37,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (207,6,3,38,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (208,6,3,39,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (209,6,3,60,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (210,6,3,61,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (211,6,3,62,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (212,6,3,56,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (213,6,3,57,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (214,6,3,58,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (215,6,3,59,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (216,6,3,57,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (217,6,3,58,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (218,6,3,59,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (219,6,3,60,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (220,6,3,61,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (221,6,3,62,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (222,6,3,56,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (223,6,3,57,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (224,6,3,58,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (225,6,3,59,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (226,6,3,57,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (227,6,3,58,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (228,6,3,59,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (229,6,3,60,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (230,6,3,61,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (231,6,3,37,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (232,6,3,38,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (233,6,3,39,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (234,6,3,40,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (235,6,3,57,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (236,6,3,58,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (237,6,3,59,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (238,6,3,60,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (239,6,3,61,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (240,6,3,62,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (241,6,3,37,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (242,6,3,38,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (243,6,3,39,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (244,6,3,40,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (245,6,3,41,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (246,6,3,42,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (247,6,3,57,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (248,6,3,58,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (249,6,3,59,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (250,6,3,60,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (251,6,3,61,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (252,6,3,62,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (253,6,3,37,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (254,6,3,38,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (255,6,3,39,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (256,6,3,40,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (257,6,3,41,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (258,6,3,42,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (259,6,3,43,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (260,6,3,38,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (261,6,3,39,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (262,6,3,40,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (263,6,3,60,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (264,6,3,61,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (265,6,3,62,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (266,6,3,63,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (267,6,3,64,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (268,6,3,54,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (269,6,3,55,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (270,6,3,56,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (271,6,3,57,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (272,6,3,58,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (273,6,3,59,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (274,6,3,65,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (275,6,3,66,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (276,6,3,67,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (277,6,3,68,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (278,6,3,69,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (279,6,3,70,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (280,6,3,71,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (281,6,3,37,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (282,6,3,38,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (283,6,3,39,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (284,6,3,40,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (285,6,3,65,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (286,6,3,66,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (287,7,3,37,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (288,7,3,38,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (289,7,3,39,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (290,7,3,40,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (291,7,3,37,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (292,7,3,38,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (293,7,3,39,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (294,7,3,40,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (295,7,3,41,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (296,7,3,55,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (297,7,3,56,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (298,7,3,57,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (299,7,3,58,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (300,7,3,59,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (301,7,3,37,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (302,7,3,38,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (303,7,3,39,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (304,7,3,60,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (305,7,3,61,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (306,7,3,62,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (307,7,3,56,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (308,7,3,57,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (309,7,3,58,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (310,7,3,59,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (311,7,3,56,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (312,7,3,57,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (313,7,3,58,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (314,7,3,59,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (315,7,3,57,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (316,7,3,58,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (317,7,3,59,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (318,7,3,60,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (319,7,3,61,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (320,7,3,37,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (321,7,3,38,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (322,7,3,39,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (323,7,3,40,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (324,7,3,57,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (325,7,3,58,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (326,7,3,59,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (327,7,3,60,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (328,7,3,61,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (329,7,3,62,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (330,7,3,37,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (331,7,3,38,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (332,7,3,39,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (333,7,3,40,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (334,7,3,41,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (335,7,3,42,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (336,7,3,37,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (337,7,3,38,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (338,7,3,39,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (339,7,3,40,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (340,7,3,41,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (341,7,3,42,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (342,7,3,43,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (343,7,3,38,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (344,7,3,39,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (345,7,3,40,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (346,7,3,60,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (347,7,3,61,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (348,7,3,62,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (349,7,3,63,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (350,7,3,64,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (351,7,3,54,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (352,7,3,55,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (353,7,3,56,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (354,7,3,57,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (355,7,3,58,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (356,7,3,59,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (357,7,3,65,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (358,7,3,66,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (359,7,3,67,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (360,7,3,68,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (361,7,3,69,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (362,7,3,70,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (363,7,3,71,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (364,7,3,37,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (365,7,3,38,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (366,7,3,39,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (367,7,3,40,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (368,7,3,65,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (369,7,3,66,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (370,8,3,37,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (371,8,3,38,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (372,8,3,39,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (373,8,3,40,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (374,8,3,37,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (375,8,3,38,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (376,8,3,39,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (377,8,3,40,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (378,8,3,41,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (379,8,3,55,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (380,8,3,56,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (381,8,3,57,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (382,8,3,58,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (383,8,3,59,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (384,8,3,37,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (385,8,3,38,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (386,8,3,39,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (387,8,3,56,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (388,8,3,57,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (389,8,3,58,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (390,8,3,59,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (391,8,3,57,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (392,8,3,58,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (393,8,3,59,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (394,8,3,60,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (395,8,3,61,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (396,8,3,62,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (397,8,3,56,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (398,8,3,57,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (399,8,3,58,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (400,8,3,59,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (401,8,3,57,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (402,8,3,58,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (403,8,3,59,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (404,8,3,60,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (405,8,3,61,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (406,8,3,37,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (407,8,3,38,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (408,8,3,39,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (409,8,3,40,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (410,8,3,57,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (411,8,3,58,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (412,8,3,59,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (413,8,3,60,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (414,8,3,61,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (415,8,3,62,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (416,8,3,37,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (417,8,3,38,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (418,8,3,39,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (419,8,3,40,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (420,8,3,41,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (421,8,3,42,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (422,8,3,57,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (423,8,3,58,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (424,8,3,59,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (425,8,3,60,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (426,8,3,61,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (427,8,3,62,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (428,8,3,37,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (429,8,3,38,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (430,8,3,39,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (431,8,3,40,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (432,8,3,41,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (433,8,3,42,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (434,8,3,43,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (435,8,3,38,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (436,8,3,39,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (437,8,3,40,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (438,8,3,60,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (439,8,3,61,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (440,8,3,62,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (441,8,3,63,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (442,8,3,64,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (443,8,3,54,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (444,8,3,55,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (445,8,3,56,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (446,8,3,57,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (447,8,3,58,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (448,8,3,59,'3-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (449,8,3,65,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (450,8,3,66,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (451,8,3,67,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (452,8,3,68,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (453,8,3,69,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (454,8,3,70,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (455,8,3,71,'4-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (456,8,3,37,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (457,8,3,38,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (458,8,3,39,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (459,8,3,40,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (460,8,3,65,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (461,8,3,66,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (462,9,3,41,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (463,9,3,42,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (464,9,3,43,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (465,9,3,44,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (466,9,3,57,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (467,9,3,58,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (468,9,3,59,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (469,9,3,60,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (470,9,3,61,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (471,9,3,62,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (472,9,3,63,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (473,9,3,41,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (474,9,3,42,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (475,9,3,43,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (476,9,3,44,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (477,9,3,57,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (478,9,3,58,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (479,9,3,59,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (480,9,3,41,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (481,9,3,42,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (482,9,3,43,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (483,9,3,44,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (484,9,3,58,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (485,9,3,59,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (486,9,3,41,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (487,9,3,42,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (488,9,3,43,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (489,9,3,44,'7-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (490,10,3,50,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (491,10,3,51,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (492,10,3,52,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (493,10,3,55,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (494,10,3,56,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (495,10,3,50,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (496,10,3,51,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (497,10,3,52,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (498,10,3,55,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (499,10,3,56,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (500,11,3,45,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (501,11,3,46,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (502,11,3,47,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (503,11,3,48,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (504,11,3,49,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (505,11,3,50,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (506,11,3,45,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (507,11,3,46,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (508,11,3,47,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (509,11,3,48,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (510,11,3,49,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (511,11,3,54,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (512,11,3,55,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (513,11,3,56,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (514,11,3,57,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (515,11,3,59,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (516,11,3,45,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (517,11,3,46,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (518,11,3,47,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (519,11,3,48,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (520,11,3,49,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (521,11,3,45,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (522,11,3,46,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (523,11,3,47,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (524,11,3,48,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (525,11,3,49,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (526,11,3,54,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (527,11,3,45,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (528,11,3,46,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (529,11,3,47,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (530,11,3,48,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (531,11,3,55,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (532,11,3,56,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (533,11,3,57,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (534,11,3,60,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (535,11,3,61,'6-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (536,11,3,55,'8-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (537,11,3,56,'8-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (538,11,3,57,'8-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (539,12,3,37,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (540,12,3,38,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (541,12,3,39,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (542,12,3,40,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (543,12,3,41,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (544,12,3,53,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (545,12,3,54,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (546,12,3,37,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (547,12,3,38,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (548,12,3,53,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (549,12,3,54,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (550,12,3,55,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (551,12,3,56,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (552,12,3,37,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (553,12,3,38,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (554,12,3,53,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (555,12,3,37,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (556,12,3,38,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (557,12,3,39,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (558,12,3,40,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (559,12,3,55,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (560,12,3,37,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (561,12,3,38,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (562,12,3,39,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (563,12,3,37,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (564,12,3,38,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (565,12,3,37,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (566,12,3,38,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (567,12,3,39,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (568,12,3,53,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (569,12,3,54,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (570,12,3,55,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (571,12,3,53,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (572,12,3,54,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (573,12,3,55,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (574,13,3,61,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (575,13,3,62,'14-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (576,13,3,61,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (577,13,3,62,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (578,13,3,63,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (579,13,3,64,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (580,13,3,65,'16-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (581,13,3,61,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (582,13,3,62,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (583,13,3,63,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (584,13,3,64,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (585,13,3,65,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (586,13,3,61,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (587,13,3,62,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (588,13,3,63,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (589,13,3,64,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (590,13,3,65,'18-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (591,13,3,61,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (592,13,3,62,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (593,13,3,63,'21-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (594,13,3,64,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (595,13,3,65,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (596,13,3,66,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (597,13,3,67,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (598,13,3,68,'23-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (599,13,3,65,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (600,13,3,66,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (601,13,3,67,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (602,13,3,68,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (603,13,3,61,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (604,13,3,62,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (605,13,3,63,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (606,13,3,64,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (607,13,3,65,'25-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (608,13,3,61,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (609,13,3,62,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (610,13,3,63,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (611,13,3,64,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (612,13,3,65,'28-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (613,13,3,61,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (614,13,3,62,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (615,13,3,63,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (616,13,3,64,'30-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (617,13,3,61,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (618,13,3,62,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (619,13,3,63,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (620,13,3,64,'2-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (621,13,3,61,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (622,13,3,62,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (623,13,3,63,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (624,13,3,64,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (625,13,3,66,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (626,13,3,67,'5-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (627,14,3,38,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (628,14,3,39,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (629,14,3,40,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (630,14,3,41,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (631,14,3,42,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (632,14,3,43,'15-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (633,14,3,45,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (634,14,3,46,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (635,14,3,47,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (636,14,3,48,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (637,14,3,49,'17-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (638,14,3,41,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (639,14,3,42,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (640,14,3,43,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (641,14,3,44,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (642,14,3,45,'22-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (643,14,3,38,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (644,14,3,39,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (645,14,3,40,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (646,14,3,41,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (647,14,3,42,'24-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (648,14,3,43,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (649,14,3,45,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (650,14,3,46,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (651,14,3,47,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (652,14,3,48,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (653,14,3,49,'29-Apr-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (654,14,3,41,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (655,14,3,42,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (656,14,3,43,'1-May-25');
INSERT INTO Availability(AvailabilityID,AdvisorID,LocationID,HourBlockID,AvailableDate) VALUES (657,14,3,44,'1-May-25');
SET IDENTITY_INSERT [Availability] OFF

SET IDENTITY_INSERT [Meetings] ON
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (1,1,324,'Academic Advising','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (2,1,330,'Study Group - Biology','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (3,2,407,'Internship Prep Workshop','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (4,3,558,'Career Counseling','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (5,4,370,'Club Leadership Meeting','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (6,5,475,'Research Assistant Check-in','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (7,5,480,'Mental Health Support Session','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (8,6,329,'Office Hours - Prof. Martinez','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (9,7,328,'Scholarship Info Session','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (10,7,336,'Peer Tutoring - Calculus','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (11,8,515,'Mock Interview','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (12,9,608,'Student Council Planning','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (13,10,626,'Group Project - Marketing','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (14,11,280,'Writing Center Appointment','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (15,11,284,'Tech Club Hackathon Prep','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (16,12,14,'Financial Aid Q&A','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (17,13,380,'One-on-One with Mentor','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (18,13,389,'Thesis Proposal Review','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (19,14,607,'Language Exchange - Spanish/English','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (20,15,383,'Guest Speaker Event - AI Ethics','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (21,16,490,'Study Abroad Orientation','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (22,16,497,'Lab Safety Training','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (23,17,496,'Part-time Job Interview','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (24,18,262,'Study Group - Organic Chem','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (25,19,386,'Professor Feedback Session','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (26,19,391,'Pre-Med Society Meeting','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (27,20,316,'Wellness Workshop','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (28,21,357,'Final Exam Review Session','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (29,22,80,'RA Floor Meeting','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (30,22,88,'Honors Program Check-In','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (31,22,97,'Zoom Class Catch-up','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (32,23,569,'Networking Night Prep','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (33,24,378,'Capstone Project Brainstorm','Scheduled');
INSERT INTO Meetings(MeetingID,StudentID,AvailabilityID,MeetingName,Status) VALUES (34,25,379,'Academic Probation Check-In','Scheduled');
SET IDENTITY_INSERT [Meetings] OFF


-- Foreign Key Contraint --
ALTER TABLE [Availability] ADD FOREIGN KEY (AdvisorID)
REFERENCES Advisors(AdvisorID)
GO

ALTER TABLE [Availability] ADD FOREIGN KEY (LocationID)
REFERENCES [Locations](LocationID)
GO

ALTER TABLE [Availability] ADD FOREIGN KEY (HourBlockID)
REFERENCES HourBlocks(HourBlockID)
GO

ALTER TABLE Meetings ADD FOREIGN KEY (StudentID)
REFERENCES Students(StudentID)
GO

ALTER TABLE Meetings ADD FOREIGN KEY (AvailabilityID)
REFERENCES [Availability](AvailabilityID)
GO

