
/*********************************************************
	Script Name: B321_Team_05_Procedures.sql
	Course: ISAT B321
	Deliverable #4 - Back-End Programmatic Logic SQL Script
	Developers: Jonathan Garcia Arias & Jason Garcia Arias
	Last Updated: 04.30.2025

	Purpose: Drop and Create Procedures, Functions, and 
	Triggers. Give ADMIN role access to the Procedures
***********************************************************/



-------------------------------------------------------------- Get (i.e., SELECT) Procedure-------------------------------------------------------------------------

-- Students Table --
DROP PROCEDURE IF EXISTS sp_GetStudents;
GO

CREATE PROCEDURE sp_GetStudents
	@StudentID INT = NULL
AS
BEGIN
	IF (@StudentID IS NULL)
		SELECT StudentID, StudentFName, StudentMName, StudentLName, StudentEmail, USCBID
		FROM Students;
	ELSE
		SELECT StudentID, StudentFName, StudentMName, StudentLName, StudentEmail, USCBID
		FROM Students
		WHERE StudentID = @StudentID;
END
GO

-- Test everything so far
EXEC sp_GetStudents;

EXEC sp_GetStudents 10;



-- Advisors Table --
DROP PROCEDURE IF EXISTS sp_GetAdvisors;
GO

CREATE PROCEDURE sp_GetAdvisors
	@AdvisorID INT = NULL
AS
BEGIN
	IF (@AdvisorID IS NULL)
		SELECT AdvisorID, AdvisorFName, AdvisorMName, AdvisorLName, AdvisorEmail, OfficeAddress, PhoneNumber
		FROM Advisors;
	ELSE
		SELECT AdvisorID, AdvisorFName, AdvisorMName, AdvisorLName, AdvisorEmail, OfficeAddress, PhoneNumber
		FROM Advisors
		WHERE AdvisorID = @AdvisorID;
END
GO

-- Test everything so far
EXEC sp_GetAdvisors;

EXEC sp_GetAdvisors 12;



-- HourBlocks Table --
DROP PROCEDURE IF EXISTS sp_GetHourBlocks;
GO

CREATE PROCEDURE sp_GetHourBlocks
	@HourBlockID INT = NULL
AS
BEGIN
	IF (@HourBlockID IS NULL)
		SELECT HourBlockID, StartBlock, EndBlock
		FROM HourBlocks
	ELSE
		SELECT HourBlockID, StartBlock, EndBlock
		FROM HourBlocks
		WHERE HourBlockID = @HourBlockID;
END
GO

-- Test everything so fars
EXEC sp_GetHourBlocks;

EXEC sp_GetHourBlocks 56;



-- Locations Table --
DROP PROCEDURE IF EXISTS sp_GetLocations;
GO

CREATE PROCEDURE sp_GetLocations
	@LocationID INT = NULL
AS
BEGIN
	IF (@LocationID IS NULL)
		SELECT LocationID, LocationType
		FROM Locations
	ELSE
		SELECT LocationID, LocationType
		FROM Locations
		WHERE LocationID = @LocationID;
END
GO

-- Test everything so far
EXEC sp_GetLocations;

EXEC sp_GetLocations 2;



-- Availability Table --
DROP PROCEDURE IF EXISTS sp_GetAvailability;
GO

CREATE PROCEDURE sp_GetAvailability
	@AvailabilityID INT = NULL
AS
BEGIN
	IF (@AvailabilityID IS NULL)
		SELECT AvailabilityID, AdvisorID, LocationID, HourBlockID, AvailableDate 
		FROM [Availability]
	ELSE
		SELECT AvailabilityID, AdvisorID, LocationID, HourBlockID, AvailableDate 
		FROM [Availability]
		WHERE AvailabilityID = @AvailabilityID;
END
GO

-- Test everything so far
EXEC sp_GetAvailability;

EXEC sp_GetAvailability 432;

   



---- Meetings -----
DROP PROCEDURE IF EXISTS sp_GetMeetings;
GO

CREATE PROCEDURE sp_GetMeetings
	@MeetingID INT = NULL
AS
BEGIN
	IF (@MeetingID IS NULL)
		SELECT MeetingID, StudentID, AvailabilityID, MeetingName, Status
		FROM [Meetings]
	ELSE
		SELECT MeetingID, StudentID, AvailabilityID, MeetingName, Status
		FROM [Meetings]
		WHERE MeetingID = @MeetingID;
END
GO

-- Test everything so far
EXEC sp_GetMeetings;

EXEC sp_GetMeetings 15;

-------------------------------------------------------------- Insert (i.e., INSERT) Procedure-------------------------------------------------------------------------

-- Students Table --
DROP PROCEDURE IF EXISTS sp_InsertStudents;
GO

CREATE PROCEDURE sp_InsertStudents
	@StudentFName VARCHAR(50),
	@StudentMName VARCHAR(50) = NULL,
	@StudentLName VARCHAR(50),
	@StudentEmail VARCHAR(50),
	@USCBID VARCHAR(50)
AS
BEGIN
	INSERT INTO [Students]
	([StudentFName], [StudentMName], [StudentLName], [StudentEmail], [USCBID])
	VALUES
	(@StudentFName, @StudentMName, @StudentLName, @StudentEmail, @USCBID)
END
GO

-- Test insert SProc
EXEC sp_GetStudents

EXEC sp_InsertStudents @StudentFName ='Jason', @StudentMName = 'Enok', @StudentLName = 'Garcia-Arias', @StudentEmail = 'jeg12@email.uscb.edu', @USCBID = '12345612'

EXEC sp_GetStudents

EXEC sp_GetStudents @StudentID=@@IDENTITY



-- Advisors Table --
DROP PROCEDURE IF EXISTS sp_InsertAdvisors;
GO

CREATE PROCEDURE sp_InsertAdvisors
	@AdvisorFName VARCHAR(50),
	@AdvisorMName VARCHAR(50) = NULL,
	@AdvisorLName VARCHAR(50),
	@AdvisorEmail VARCHAR(50),
	@OfficeAddress VARCHAR(50),
	@PhoneNumber VARCHAR(50)
AS
BEGIN
	INSERT INTO [Advisors]
	([AdvisorFName], [AdvisorMName], [AdvisorLName], [AdvisorEmail], [OfficeAddress], [PhoneNumber])
	VALUES
	(@AdvisorFName, @AdvisorMName, @AdvisorLName, @AdvisorEmail, @OfficeAddress, @PhoneNumber)
END
GO

-- Test insert SProc
EXEC sp_GetAdvisors

EXEC sp_InsertAdvisors @AdvisorFName ='Larry', @AdvisorMName = 'Chance', @AdvisorLName = 'Shek', @AdvisorEmail = 'bong@email.uscb.edu', @OfficeAddress = 'Chillin',  @PhoneNumber = '12342612345'

EXEC sp_GetAdvisors

EXEC sp_GetAdvisors @AdvisorID=@@IDENTITY



----HourBlocks Table ---
DROP PROCEDURE IF EXISTS sp_InsertHourBlocks;
GO

CREATE PROCEDURE sp_InsertHourBlocks
	@StartBlock VARCHAR(50),
	@EndBlock VARCHAR(50)
AS
BEGIN
	INSERT INTO [HourBlocks]
	([StartBlock], [EndBlock])
	VALUES
	(@StartBlock, @EndBlock)
END
GO

-- Test insert SProc
EXEC sp_GetHourBlocks

EXEC sp_InsertHourBlocks @StartBlock = '0:00', @EndBlock = '0:25'

EXEC sp_GetHourBlocks

EXEC sp_GetHourBlocks @HourBlockID=@@IDENTITY



----- Locations Table ------
DROP PROCEDURE IF EXISTS sp_InsertLocations;
GO

CREATE PROCEDURE sp_InsertLocations
	@LocationType VARCHAR(50)
AS
BEGIN
	INSERT INTO [Locations]
	([LocationType])
	VALUES
	(@LocationType)
END
GO

-- Test insert SProc
EXEC sp_GetLocations

EXEC sp_InsertLocations @LocationType = '432 Orange Street'

EXEC sp_GetLocations

EXEC sp_GetLocations @LocationID=@@IDENTITY



--- Availability Table ---
DROP PROCEDURE IF EXISTS sp_InsertAvailability;
GO

CREATE PROCEDURE sp_InsertAvailability
	@AdvisorID INT,
	@LocationID INT,
	@HourBlockID INT,
	@AvailableDate DATE
AS
BEGIN
	INSERT INTO [Availability]
	([AdvisorID], [LocationID], [HourBlockID], AvailableDate)
	VALUES
	(@AdvisorID, @LocationID, @HourBlockID, @AvailableDate)
END
GO

-- Test insert SProc
EXEC sp_GetAvailability

EXEC sp_InsertAvailability @AdvisorID ='14',  @LocationID = '1', @HourBlockID = '3', @AvailableDate = '2025-04-21'

EXEC sp_GetAvailability @AvailabilityID=@@IDENTITY



--- Meetings Table ---
DROP PROCEDURE IF EXISTS sp_InsertMeetings;
GO

CREATE PROCEDURE sp_InsertMeetings
	@StudentID INT,
	@AvailabilityID INT,
	@MeetingName VARCHAR(255),
	@Status VARCHAR(50)
AS
BEGIN
	INSERT INTO [Meetings]
	([StudentID], [AvailabilityID], [MeetingName], [Status])
	VALUES
	(@StudentID, @AvailabilityID, @MeetingName, @Status)
END
GO

-- Test insert SProc
EXEC sp_GetMeetings

EXEC sp_InsertMeetings @StudentID = 2, @AvailabilityID = 600, @MeetingName = 'Anxiety Consuling', @Status = 'Scheduled'

EXEC sp_GetMeetings @MeetingID=@@IDENTITY

-------------------------------------------------------------- Update (i.e., UPDATE) Procedure-------------------------------------------------------------------------

--- Students Table ---
DROP PROCEDURE IF EXISTS sp_UpdateStudents;
GO

CREATE PROCEDURE sp_UpdateStudents
	@StudentID INT,
	@StudentFName VARCHAR(50),
	@StudentMName VARCHAR(50) = NULL,
	@StudentLName VARCHAR(50),
	@StudentEmail VARCHAR(50),
	@USCBID VARCHAR(50)
AS
BEGIN
	UPDATE [Students]
	SET [StudentFName] = @StudentFName, 
		[StudentMName] = @StudentMName, 
		[StudentLName] = @StudentLName,
		[StudentEmail] = @StudentEmail,
		[USCBID] = @USCBID
	WHERE StudentID = @StudentID
END
GO

-- Test update SProc
EXEC sp_GetStudents @StudentID = 26

EXEC sp_UpdateStudents @StudentID = 26, @StudentFName='Brown', @StudentMName = 'L', @StudentLName = 'James', @StudentEmail = 'chewwr@uscb.edu', @USCBID = '12112'

EXEC sp_GetStudents @StudentID = 26



--- Advisors Table ---
DROP PROCEDURE IF EXISTS sp_UpdateAdvisors;
GO

CREATE PROCEDURE sp_UpdateAdvisors
	@AdvisorID INT,
	@AdvisorFName VARCHAR(50),
	@AdvisorMName VARCHAR(50) = NULL,
	@AdvisorLName VARCHAR(50),
	@AdvisorEmail VARCHAR(50),
	@OfficeAddress VARCHAR(50),
	@PhoneNumber VARCHAR(50)
AS
BEGIN
	UPDATE [Advisors]
	SET [AdvisorFName] = @AdvisorFName, 
		[AdvisorMName] = @AdvisorMName, 
		[AdvisorLName] = @AdvisorLName,
		[AdvisorEmail] = @AdvisorEmail,
		[OfficeAddress] = @OfficeAddress,
		[PhoneNumber] = @PhoneNumber
		
	WHERE AdvisorID = @AdvisorID
END
GO

-- Test update SProc
EXEC sp_GetAdvisors @AdvisorID = 15

EXEC sp_UpdateAdvisors @AdvisorID = 15, @AdvisorFName='Chewbacca', @AdvisorMName = 'Wost', @AdvisorLName = 'Rarr', @AdvisorEmail = 'chewwr@uscb.edu', @OfficeAddress = '12112',
@PhoneNumber = '932-332-3930'

EXEC sp_GetAdvisors @AdvisorID = 15



--- Locations Table ---
DROP PROCEDURE IF EXISTS sp_UpdateLocations;
GO

CREATE PROCEDURE sp_UpdateLocations
	@LocationID INT,
	@LocationType VARCHAR(50)
AS
BEGIN
	UPDATE [Locations]
	SET [LocationType] = @LocationType
		
	WHERE LocationID = @LocationID
END
GO

-- Test update SProc
EXEC sp_GetLocations @LocationID = 4

EXEC sp_UpdateLocations @LocationID = 4, @LocationType = 'Brown Street'

EXEC sp_GetLocations @LocationID = 4



--- Availability Table ---
DROP PROCEDURE IF EXISTS sp_UpdateAvailability;
GO

CREATE PROCEDURE sp_UpdateAvailability
	@AvailabilityID INT,
	@AdvisorID INT,
	@LocationID INT,
	@HourBlockID INT,
	@AvailableDate DATE
AS
BEGIN
	UPDATE [Availability]
	SET [AdvisorID] = @AdvisorID,
		[LocationID] = @LocationID,
		[HourBlockID] = @HourBlockID,
		[AvailableDate] = @AvailableDate
	WHERE AvailabilityID = @AvailabilityID
END
GO

-- Test update SProc
EXEC sp_GetAvailability @AvailabilityID = 601

EXEC sp_UpdateAvailability @AvailabilityID = 601, @AdvisorID = 7, @LocationID = 1, @HourBlockID = 5, @AvailableDate = '2025-04-21'

EXEC sp_GetAvailability @AvailabilityID = 601


--- Meetings Table ---
DROP PROCEDURE IF EXISTS sp_UpdateMeetings;
GO

CREATE PROCEDURE sp_UpdateMeetings
	@MeetingID INT,
	@StudentID INT,
	@AvailabilityID INT,
	@MeetingName VARCHAR(255),
	@Status VARCHAR(50)
AS
BEGIN
	UPDATE [Meetings]
	SET [StudentID] = @StudentID,
		[AvailabilityID] = @AvailabilityID,
		[MeetingName] = @MeetingName,
		[Status] = @Status
	WHERE MeetingID = @MeetingID
END
GO

-- Test update SProc
EXEC sp_GetMeetings @MeetingID = 1

EXEC sp_UpdateMeetings @MeetingID = 1, @StudentID = 3, @AvailabilityID = 5, @MeetingName = 'Deciding Dance Classes', @Status = 'Completed'

EXEC sp_GetMeetings @MeetingID = 1



--- HourBlocks Table ---
DROP PROCEDURE IF EXISTS sp_UpdateHourBlocks;
GO

CREATE PROCEDURE sp_UpdateHourBlocks
	@HourBlockID INT,
	@StartBlock VARCHAR(50),
	@EndBlock VARCHAR(50)
AS
BEGIN
	UPDATE [HourBlocks]
	   SET [StartBlock] = @StartBlock,
		   [EndBlock] = @EndBlock
	WHERE HourBlockID = @HourBlockID
END
GO

-- Test update SProc
EXEC sp_GetHourBlocks @HourBlockID = 97

EXEC sp_UpdateHourBlocks @HourBlockID = 97, @StartBlock = '1:00', @EndBlock = '2:00'

EXEC sp_GetHourBlocks @HourBlockID = 97



-------------------------------------------------------------- Delete (i.e., DELETE) Procedure-------------------------------------------------------------------------

--- Students Table ---
DROP PROCEDURE IF EXISTS sp_DeleteStudents;
GO

CREATE PROCEDURE sp_DeleteStudents
	@StudentID INT
AS
BEGIN
	DELETE 
	FROM [Students]
	WHERE StudentID = @StudentID
END
GO

-- Test delete SProc
EXEC sp_GetStudents @StudentID = 26

EXEC sp_DeleteStudents @StudentID = 26

EXEC sp_GetStudents @StudentID = 26

EXEC sp_GetStudents



--- Advisors Table ---
DROP PROCEDURE IF EXISTS sp_DeleteAdvisors;
GO

CREATE PROCEDURE sp_DeleteAdvisors
	@AdvisorID INT
AS
BEGIN
	DELETE 
	FROM [Advisors]
	WHERE AdvisorID = @AdvisorID
END
GO

-- Test delete SProc
EXEC sp_GetAdvisors @AdvisorID = 15

EXEC sp_DeleteAdvisors @AdvisorID = 15

EXEC sp_GetAdvisors @AdvisorID = 15

EXEC sp_GetAdvisors



--- Locations Table ---
DROP PROCEDURE IF EXISTS sp_DeleteLocations;
GO

CREATE PROCEDURE sp_DeleteLocations
	@LocationID INT
AS
BEGIN
	DELETE 
	FROM [Locations]
	WHERE LocationID = @LocationID
END
GO

-- Test delete SProc
EXEC sp_GetLocations @LocationID = 4

EXEC sp_DeleteLocations @LocationID = 4

EXEC sp_GetLocations @LocationID = 4

EXEC sp_GetLocations



--- Meetings Table ---
DROP PROCEDURE IF EXISTS sp_DeleteMeetings;
GO

CREATE PROCEDURE sp_DeleteMeetings
	@MeetingID INT
AS
BEGIN
	DELETE 
	FROM [Meetings]
	WHERE MeetingID = @MeetingID
END
GO

-- Test delete SProc
EXEC sp_GetMeetings @MeetingID = 3

EXEC sp_DeleteMeetings @MeetingID = 3

EXEC sp_GetMeetings @MeetingID = 3

EXEC sp_GetMeetings



--- Availability Table ---
DROP PROCEDURE IF EXISTS sp_DeleteAvailability;
GO

CREATE PROCEDURE sp_DeleteAvailability
	@AvailabilityID INT
AS
BEGIN
	DELETE 
	FROM [Availability]
	WHERE AvailabilityID = @AvailabilityID
END
GO

-- Test delete SProc
EXEC sp_GetAvailability @AvailabilityID = 2

EXEC sp_DeleteAvailability @AvailabilityID = 2

EXEC sp_GetAvailability @AvailabilityID = 2

EXEC sp_GetAvailability



--- HourBlocks Table ---
DROP PROCEDURE IF EXISTS sp_DeleteHourBlocks;
GO

CREATE PROCEDURE sp_DeleteHourBlocks
	@HourBlockID INT
AS
BEGIN
	DELETE 
	FROM [HourBlocks]
	WHERE HourBlockID = @HourBlockID
END
GO

-- Test delete SProc
EXEC sp_GetHourBlocks @HourBlockID = 97

EXEC sp_DeleteHourBlocks @HourBlockID = 97

EXEC sp_GetHourBlocks @HourBlockID = 97

EXEC sp_GetHourBlocks


-- TRIGGERS --
/***
Prevents duplicate Availability by checking 
whether the inserted Availability matches to the 
one of the rows from the Availability table. 
If there is a match, it will
throw an Error.
****/

DROP TRIGGER IF EXISTS AvailabilityTimeConflicts
GO

CREATE TRIGGER AvailabilityTimeConflicts
	ON [Availability]
	AFTER INSERT, UPDATE
AS 
BEGIN
IF EXISTS
   (
		SELECT 1
		FROM Inserted i
		INNER JOIN Availability
			ON i.AvailabilityID <> Availability.AvailabilityID
			AND i.AvailableDate = Availability.AvailableDate
			AND i.AdvisorID = Availability.AdvisorID
			AND i.HourBlockID = Availability.HourBlockID
	)
BEGIN
	ROLLBACK TRAN;
	THROW 50113,
	'Time Conflict! Please Put a Different Time!', 1;
	END
END;
GO

-- TRIGGER 2 --
/***
Prevents duplicate meetings by checking 
whether the inserted meeting matches to the 
list of available meetings. If there is a meeting
that matches the inserted meeting, it will
throw an Error.
****/

DROP TRIGGER IF EXISTS MeetingTimeConflicts
GO


CREATE TRIGGER MeetingTimeConflicts
	ON Meetings
	AFTER INSERT, UPDATE
AS 
BEGIN
IF EXISTS 
	(
		SELECT 1
		FROM Inserted i 
		INNER JOIN Availability
		    ON i.AvailabilityID = Availability.AvailabilityID
		INNER JOIN Meetings
			ON i.AvailabilityID = Meetings.AvailabilityID
			AND i.MeetingID <> Meetings.MeetingID
	)
BEGIN
	ROLLBACK TRAN;
	THROW 50114,
	'Time Conflict! Please Put a Different Time!', 1;
	END
END;
GO


-- FUNCTION --

/***
Count down days till the due date of the Available Time. If the due
date has passed, it will return a value of 'Overdue!' Signifying that the 
selected availability has expired.
****/
GO
DROP FUNCTION IF EXISTS fnDaysLeft
GO

CREATE FUNCTION fnDaysLeft(@TargetDate DATE)
RETURNS VARCHAR(20)
AS
BEGIN 
	DECLARE @Result VARCHAR(20);
	IF DATEDIFF(DAY, GETDATE(), @TargetDate) < 0 
		SET @Result = 'Overdue!';
	ELSE
		SET @Result = CAST(DATEDIFF(DAY, GETDATE(), @TargetDate) AS VARCHAR(20));
RETURN @Result;
END;
GO


-- Test Function --
SELECT AvailableDate,
	   dbo.fnDaysLeft(AvailableDate) AS DaysLeft
FROM Availability
 

-- Wrap Function to Procedure --
DROP PROCEDURE IF EXISTS sp_GetAvailabilityWithDaysLeft
GO

GO
CREATE PROCEDURE sp_GetAvailabilityWithDaysLeft 
	@AvailabilityID INT
AS 
BEGIN 
	SELECT dbo.fnDaysLeft(AvailableDate) AS DaysLeft
	FROM Availability
	WHERE AvailabilityID = @AvailabilityID;
END;
GO

-- Test Wrapped-Function --
EXEC sp_GetAvailabilityWithDaysLeft @AvailabilityID = 1;

-- GRANT EXECUTE --
GRANT EXECUTE ON sp_GetStudents TO [ADMIN]
GO
GRANT EXECUTE ON sp_GetAdvisors TO [ADMIN]
GO
GRANT EXECUTE ON sp_GetHourBlocks TO [ADMIN]
GO
GRANT EXECUTE ON sp_GetLocations TO [ADMIN]
GO
GRANT EXECUTE ON sp_GetAvailability TO [ADMIN]
GO
GRANT EXECUTE ON sp_GetMeetings TO [ADMIN]
GO
GRANT EXECUTE ON sp_InsertStudents TO [ADMIN]
GO
GRANT EXECUTE ON sp_InsertAdvisors TO [ADMIN]
GO
GRANT EXECUTE ON sp_InsertHourBlocks TO [ADMIN]
GO
GRANT EXECUTE ON sp_InsertLocations TO [ADMIN]
GO
GRANT EXECUTE ON sp_InsertAvailability TO [ADMIN]
GO
GRANT EXECUTE ON sp_InsertMeetings TO [ADMIN]
GO
GRANT EXECUTE ON sp_UpdateStudents TO [ADMIN]
GO
GRANT EXECUTE ON sp_UpdateAdvisors TO [ADMIN]
GO
GRANT EXECUTE ON sp_UpdateHourBlocks TO [ADMIN]
GO
GRANT EXECUTE ON sp_UpdateLocations TO [ADMIN]
GO
GRANT EXECUTE ON sp_UpdateMeetings TO [ADMIN]
GO
GRANT EXECUTE ON sp_UpdateAvailability TO [ADMIN]
GO
GRANT EXECUTE ON sp_DeleteStudents TO [ADMIN]
GO
GRANT EXECUTE ON sp_DeleteAdvisors TO [ADMIN]
GO
GRANT EXECUTE ON sp_DeleteHourBlocks TO [ADMIN]
GO
GRANT EXECUTE ON sp_DeleteAvailability TO [ADMIN]
GO
GRANT EXECUTE ON sp_DeleteMeetings TO [ADMIN]
GO
GRANT EXECUTE ON sp_DeleteLocations TO [ADMIN]
GO
GRANT EXECUTE ON sp_GetAvailabilityWithDaysLeft TO [ADMIN]
GO