﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Event_Manager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    AttendeeID = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    CheckinTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.AttendeeID);
                });

            migrationBuilder.CreateTable(
                name: "Hosts",
                columns: table => new
                {
                    HostID = table.Column<Guid>(type: "uuid", nullable: false),
                    Website = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    OrganizationName = table.Column<string>(type: "text", nullable: true),
                    OrganizationPhone = table.Column<string>(type: "text", nullable: true),
                    RepresentativeName = table.Column<string>(type: "text", nullable: true),
                    RepresentativePhone = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    PhoneNum = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hosts", x => x.HostID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Address = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    RentalFee = table.Column<decimal>(type: "numeric", nullable: false),
                    VendorCapacity = table.Column<int>(type: "integer", nullable: false),
                    AttendeeCapacity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Address);
                });

            migrationBuilder.CreateTable(
                name: "Presenters",
                columns: table => new
                {
                    PresenterID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PresenterFee = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presenters", x => x.PresenterID);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorID = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNum = table.Column<string>(type: "text", nullable: false),
                    Fee = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpID = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Pay = table.Column<decimal>(type: "numeric", nullable: false),
                    ShiftSchedule = table.Column<string>(type: "text", nullable: false),
                    LocationAddress = table.Column<string>(type: "text", nullable: false),
                    HostID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpID);
                    table.ForeignKey(
                        name: "FK_Employees_Hosts_HostID",
                        column: x => x.HostID,
                        principalTable: "Hosts",
                        principalColumn: "HostID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Locations_LocationAddress",
                        column: x => x.LocationAddress,
                        principalTable: "Locations",
                        principalColumn: "Address",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Website = table.Column<string>(type: "text", nullable: false),
                    LocationAddress = table.Column<string>(type: "text", nullable: false),
                    HostID = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Hosts_HostID",
                        column: x => x.HostID,
                        principalTable: "Hosts",
                        principalColumn: "HostID");
                    table.ForeignKey(
                        name: "FK_Events_Locations_LocationAddress",
                        column: x => x.LocationAddress,
                        principalTable: "Locations",
                        principalColumn: "Address",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HasSpace",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "integer", nullable: false),
                    TableID = table.Column<int>(type: "integer", nullable: false),
                    VendorID = table.Column<Guid>(type: "uuid", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HasSpace", x => new { x.RoomID, x.TableID });
                    table.ForeignKey(
                        name: "FK_HasSpace_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HasSpace_Vendors_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendors",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HostedBy",
                columns: table => new
                {
                    HostedID = table.Column<Guid>(type: "uuid", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
                    HostID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostedBy", x => x.HostedID);
                    table.ForeignKey(
                        name: "FK_HostedBy_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HostedBy_Hosts_HostID",
                        column: x => x.HostID,
                        principalTable: "Hosts",
                        principalColumn: "HostID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presents",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PresenterID = table.Column<int>(type: "integer", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presents", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Presents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presents_Presenters_PresenterID",
                        column: x => x.PresenterID,
                        principalTable: "Presenters",
                        principalColumn: "PresenterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<Guid>(type: "uuid", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    AttendeeID = table.Column<Guid>(type: "uuid", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
                    TicketType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Tickets_Attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendees",
                        principalColumn: "AttendeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_HostID",
                table: "Employees",
                column: "HostID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LocationAddress",
                table: "Employees",
                column: "LocationAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Events_HostID",
                table: "Events",
                column: "HostID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_LocationAddress",
                table: "Events",
                column: "LocationAddress");

            migrationBuilder.CreateIndex(
                name: "IX_HasSpace_EventId",
                table: "HasSpace",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_HasSpace_VendorID",
                table: "HasSpace",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_HostedBy_EventId",
                table: "HostedBy",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_HostedBy_HostID",
                table: "HostedBy",
                column: "HostID");

            migrationBuilder.CreateIndex(
                name: "IX_Presents_EventId",
                table: "Presents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Presents_PresenterID",
                table: "Presents",
                column: "PresenterID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AttendeeID",
                table: "Tickets",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "HasSpace");

            migrationBuilder.DropTable(
                name: "HostedBy");

            migrationBuilder.DropTable(
                name: "Presents");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Presenters");

            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Hosts");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
