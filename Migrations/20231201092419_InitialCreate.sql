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