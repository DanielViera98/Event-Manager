CREATE VIEW location_view_min AS
    SELECT
        "Address", 
        "Name" AS LocationName,
        "Website" AS LocationWebsite
    FROM "Locations";
CREATE VIEW hosts_view_min AS SELECT "HostID", "Website" AS HostWebsite, "Name" AS HostName FROM "Hosts";
CREATE VIEW events_renamed AS
    SELECT
        "EventId",
        "Name" AS EventName,
        "Description" AS EventDescription,
        "StartDate",
        "EndDate",
        "Website" AS EventWebsite,
        "LocationAddress",
        "HostID"
    FROM "Events";
CREATE VIEW presenter_view AS
    SELECT
        "Pr"."PresenterID",
        "P"."RoomID",
        "E".*,
        "P"."Title",
        "P"."Description" AS PresentationDescription,
        "P"."Time",
        "Pr"."Name" AS PresenterName,
        "L"."locationname",
        "L"."locationwebsite",
        "H"."hostwebsite",
        "H"."hostname"
    FROM "Presents" AS "P"
    FULL OUTER JOIN "Presenters" AS "Pr" ON "P"."PresenterID" = "Pr"."PresenterID"
    FULL OUTER JOIN events_renamed AS "E" ON "E"."EventId" = "P"."EventId"
    FULL OUTER JOIN location_view_min AS "L" ON "L"."Address" = "E"."LocationAddress"
    FULL OUTER JOIN hosts_view_min AS "H" ON "H"."HostID" = "E"."HostID";

CREATE OR REPLACE VIEW host_view AS
    Select
        "E"."EventId" AS "EventID",
        "E"."eventname",
        "E"."eventdescription",
        "E"."StartDate",
        "E"."EndDate",
        "E"."eventwebsite",
        "L"."Address",
        "L"."Name" AS "LocationName",
        "L"."Website" AS "LocationWebsite",
        "L"."Email" AS "LocationEmail",
        "L"."RentalFee",
        "L"."VendorCapacity",
        "L"."Rooms",
        "L"."AttendeeCapacity",
        "H"."HostID",
        "H"."Name" AS "HostName",
        "H"."Website" AS "HostWebsite",
        "H"."Email" AS "HostEmail",
        "H"."PhoneNumber" AS "HostPhoneNumber",
        "H"."Discriminator" AS "HostType",
        "H"."RepresentativeName",
        "H"."RepresentativePhone"
    FROM events_renamed AS "E" 
    FULL OUTER JOIN "Hosts" AS "H" ON "H"."HostID" = "E"."HostID"
    FULL OUTER JOIN "Locations" AS "L" ON "L"."Address" = "E"."LocationAddress";

--Vendors should be able to see everything in events, Hosts name/site/email, Everything from location,
--TicketCount, and everything in vendors
CREATE VIEW vendor_view AS  
	Select
		"E"."EventId" AS "EventID",
	    "E"."eventname",
	    "E"."eventdescription",
    	"E"."StartDate",
    	"E"."EndDate",
	    "E"."eventwebsite",
    	"L"."Address",
		"L"."Name" AS "LocationName",
	    "L"."Website" AS "LocationWebsite",
		"L"."Email" AS "LocationEmail",
		"L"."RentalFee",
		"L"."VendorCapacity",
        "L"."Rooms",
		"L"."AttendeeCapacity",
    	"H"."HostID",
		"H"."Name" AS "HostName",
    	"H"."Website" AS "HostWebsite",
		"H"."Email" AS "HostEmail",
		"H"."Discriminator" AS "HostType",
		--"T"."TicketID" AS "TicketID",
		"V"."VendorID" AS "VendorID",
		"V"."Name" AS "VendorName",
		"V"."Email" AS "VendorEmail",
		"V"."PhoneNum" AS "VendorPhoneNumber",
		"V"."Fee" AS "VendorFee",
		"HS"."RoomID",
		"HS"."TableID",
		COUNT("T"."TicketID") AS "TicketCount"
	FROM events_renamed AS "E" 
	FULL OUTER JOIN "Hosts" AS "H" ON "H"."HostID" = "E"."HostID"
	FULL OUTER JOIN "Locations" AS "L" ON "L"."Address" = "E"."LocationAddress"
	FULL OUTER JOIN "Tickets" AS "T" ON "T"."EventId" = "E"."EventId"
	FULL OUTER JOIN "HasSpace" AS "HS" ON "HS"."EventId" = "E"."EventId"
	FULL OUTER JOIN "Vendors" AS "V" ON "V"."VendorID" = "HS"."VendorID"
	GROUP BY
    "E"."EventId",
    "E"."eventname",
    "E"."eventdescription",
    "E"."StartDate",
    "E"."EndDate",
    "E"."eventwebsite",
    "L"."Address",
    "L"."Name",
    "L"."Website",
    "L"."Email",
    "L"."RentalFee",
    "L"."VendorCapacity",
    "L"."AttendeeCapacity",
    "H"."HostID",
    "H"."Name",
    "H"."Website",
    "H"."Email",
    "H"."Discriminator",
	"V"."VendorID",
	"V"."Name",
	"V"."Email",
	"V"."PhoneNum",
	"V"."Fee",
	"HS"."RoomID",
	"HS"."TableID",
	"T"."TicketID";

CREATE OR REPLACE PROCEDURE "LoginUser"
(IN pusername text, IN ppassword text, IN paccounttype text,
 INOUT "AccountID" uuid default 'aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa',
 INOUT "UserName" text default 'a',
 INOUT "Password" text default 'oifjawoefijweofpjaefpoijoiawejf',
 INOUT "AccountType" text default 'hello')
LANGUAGE plpgsql
AS
$$
BEGIN
    IF EXISTS (
        SELECT 1
        FROM "Accounts"
        WHERE "Accounts"."UserName" = pusername
        AND "Accounts"."Password" = md5(ppassword)
        AND "Accounts"."AccountType" = paccounttype
    ) THEN
        SELECT *
        INTO "AccountID", "UserName", "AccountType", "Password"
        FROM "Accounts"
        WHERE "Accounts"."UserName" = pusername
        AND "Accounts"."Password" = md5(ppassword)
        AND "Accounts"."AccountType" = paccounttype
        LIMIT 1;
    END IF;
END;
$$;
CREATE PROCEDURE "AddUser"
(paccountid uuid,pusername text, ppassword text, paccounttype text)
LANGUAGE SQL
AS
$$
    INSERT INTO "Accounts" ("AccountID","UserName", "Password", "AccountType")
    VALUES(paccountid,pusername, md5(ppassword), paccounttype)
$$;