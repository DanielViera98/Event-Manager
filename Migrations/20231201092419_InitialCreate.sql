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
