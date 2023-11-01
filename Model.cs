using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;
using System.Diagnostics.SymbolStore;
using System.Numerics;
using System.ComponentModel.DataAnnotations.Schema;

//Create new class for database context
public class EventContext : DbContext
{
    public DbSet<Event> Events { get; set; }    //Table containing Stock classes
    public DbSet<Location> Locations { get; set; }    //Table containing Stock classes
    public DbSet<Attendee> Attendees { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Host> Hosts { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Presenter> Presenters { get; set; }
    public DbSet<Presents> Presents { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<HasSpace> HasSpace { get; set; }
    public DbSet<HostedBy> HostedBy { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public string DbPath { get; }               //Path to the database
    public string StockPath { get; set; }       //Path to the Stock Files folder


    public EventContext()                               //Constructor for StockContext
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;    //Get folder name for data
        var path = Environment.GetFolderPath(folder);                   //Get path to folder
        DbPath = System.IO.Path.Join(path, "Stocks.db");                //Update path variable to folder + name for database
        string mypath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);    //Get path to exe location
    }
    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=passw0rd;Database=testdb;");
        base.OnConfiguring(options);
    }

}

public class Event                                      //Event Entity Table
{
    [Key] public Guid EventId { get; set; }             
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Website {  get; set; }
    public Location Location { get; set; }              //FK to Location Table
}

public class Location                                   //Location Entity Table
{
    [Key] public string Address { get; set; }
    public string Website { get; set; }
    public string Email { get; set; }
    public decimal RentalFee { get; set; }
    public int VendorCapacity { get; set; }
    public int AttendeeCapacity { get; set; }
    public List<Event> Events { get; set; }
}

public class Attendee                                   //Attendee Entity Table
{
    [Key] public Guid AttendeeID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime CheckinTime { get; set; }
}

public class Ticket                                     //Ticket Entity Table
{
    [Key] public Guid TicketID { get; set; }
    public float Cost { get; set; }
    public Attendee Attendee { get; set; }              //FK to Attendee Table
    public Event Event { get; set; }                    //FK to Event Table
    public string TicketType { get; set; }
}

public class Host                                       //Host Parent Entity Table
{
    [Key] public Guid HostID { get; set; }
    public string Website { get; set; }
    public string Email { get; set; }
}

public class Person                                     /*Person, inherits parent table Host*/
    : Host
{
    public string Name { get; set; }
    public string PhoneNum { get; set; }
}

public class Organization                               /*Organization, inherits parent table Host*/
    :Host
{
    public string OrganizationName { get; set; }                //Name of organization
    public string OrganizationPhone { get; set; }
    public string RepresentativeName { get; set; }      //Representative name
    public string RepresentativePhone { get; set; }
}

[PrimaryKey(nameof(RoomID), nameof(TableID))]           //Composite primary key for HasSpace
public class HasSpace                                   //HasSpace Multi-Multi Relationship Table
{
    public int RoomID { get; set; }
    public int TableID { get; set; }
    public Vendor Vendor { get; set; }                  //FK for Vendor
    public Event Event { get; set; }                    //FK for Event
}

[PrimaryKey(nameof(EventID), nameof(HostID))]
public class HostedBy                                   //HostedBy Multi-Multi Relationship Table
{
    public int EventID { get; set; }              //FK for Event
    public int HostID { get; set; }                //FK for Host
}

public class Employee                                   //Employee Entity Table
{
    [Key] public Guid EmpID { get; set;}
    public string Name { get; set; }
    public float Pay { get; set; }
    public string ShiftSchedule { get; set; }
    public string WorkAddress { get; set; }
    public Host Host { get; set; }
}

public class Presenter
{
    [Key] public int PresenterID { get; set; }
    public int Name { get; set; }
    public string Email { get; set; }
    public float PresenterFee { get; set; }
}

public class Presents
{
    [Key] public int RoomID { set; get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Time { get; set; }
    public Presenter Presenter { get; set; }
    public Event Event { get; set; }
}
public class Vendor
{
    [Key] public int VendorID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public float VendorFee { get; set; }
}