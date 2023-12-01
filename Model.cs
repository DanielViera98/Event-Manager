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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

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
    public DbSet<PresenterView> PresenterViews { get; set; }
    public DbSet<HostMinView> HostMinViews { get; set; }
    public DbSet<EventLog> EventLogs { get; set; }
    public DbSet<Account> Accounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ... other configurations ...

        modelBuilder.Entity<Host>()
            .HasMany(h => h.Events)
            .WithOne() // Assuming there is no navigation property back to Host in Event
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Host)
            .WithMany() // Assuming there is no collection navigation property in Host for Employees
            .HasForeignKey(e => e.HostID) // Assuming there is a HostID foreign key property in Employee
    .       OnDelete(DeleteBehavior.Cascade); // Set this if you want to set the foreign key to null instead of deleting the employee


        // ... configurations for other relationships ...

    }
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

    public EventContext()                               //Constructor for EventContext
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
        options.UseNpgsql(connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=passw0rd;Database=EventDatabase;Include Error Detail=True");
        base.OnConfiguring(options);
    }

}

public class Event                                      //Event Entity Table
{
    public Event() { }
    public Event(string name, string desc, DateTime start, DateTime end, string site, Location local)
    {
        EventId = new Guid();
        Name = name;
        Description = desc;
        StartDate = start;
        EndDate = end;
        Website = site;
        Location = local;
    }
    [Key] public Guid EventId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Website { get; set; }
    public Location Location { get; set; }              //FK to Location Table

    /*public List<Host> Hosts { get; set; }
    public List<Vendor> Vendors { get; set; }
    public List<Ticket> Tickets { get; set; }
    public List<Presenter> Presenters { get; set; }*/

}

public class Location                                   //Location Entity Table
{
    public Location() { }
    public Location(string address, string name, string website, string email, decimal rentalFee, 
        int vendors, int attendees)
    {
        Address = address;
        Name = name;
        Website = website;
        Email = email;
        RentalFee = rentalFee;
        VendorCapacity = vendors;
        AttendeeCapacity = attendees;
        Events = new List<Event>();
    }
    [Key] public string Address { get; set; }
    public string Name { get; set; }
    public string? Website { get; set; }
    public string Email { get; set; }
    public decimal RentalFee { get; set; }
    public int VendorCapacity { get; set; }
    public int AttendeeCapacity { get; set; }
    public List<Event> Events { get; set; }
}

public class Attendee                                   //Attendee Entity Table
{
    public Attendee() { }
    public Attendee(string name, string email, string phone)
    {
        Name = name;
        Email = email;
        PhoneNumber = phone;
    }
    [Key] public Guid AttendeeID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}

public class Ticket                                     //Ticket Entity Table
{
    public Ticket() { }
    public Ticket(float cost, Attendee attendee, Event evnt, string type)
    {
        //TicketID = new Guid();
        Cost = cost;
        Attendee = attendee;
        Event = evnt;
        TicketType = type;
    }
    [Key] public Guid TicketID { get; set; }
    public float Cost { get; set; }
    public Attendee Attendee { get; set; }              //FK to Attendee Table
    public Event Event { get; set; }                    //FK to Event Table
    public string TicketType { get; set; }
    public DateTime CheckInTime { get; set; }
}

public class UserTicket                                     //Ticket Entity Table
{
    public UserTicket() { }
    public float Cost { get; set; }
    public string Attendee { get; set; }              //FK to Attendee Table
    public string Event { get; set; }                    //FK to Event Table
    public string TicketType { get; set; }
}

public class Host                                       //Host Parent Entity Table
{
    [Key] public Guid HostID { get; set; }
    public string? Website { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public List<Event> Events { get; set; }
}   

public class Person                                     /*Person, inherits parent table Host*/
    : Host
{ }


public class Organization                               /*Organization, inherits parent table Host*/
    : Host
{
    public string? RepresentativeName { get; set; }      //Representative name
    public string? RepresentativePhone { get; set; }
}

[PrimaryKey(nameof(RoomID), nameof(TableID))]           //Composite primary key for HasSpace
public class HasSpace                                   //HasSpace Multi-Multi Relationship Table
{
    public HasSpace() { }
    public HasSpace(int roomID, int tableID, Vendor vendor, Event evnt)
    {
        RoomID = roomID;
        TableID = tableID;
        Vendor = vendor;
        Event = evnt;
    }
    public int RoomID { get; set; }
    public int TableID { get; set; }
    public Vendor Vendor { get; set; }                  //FK for Vendor
    public Event Event { get; set; }                    //FK for Event
}

public class HostedBy                                   //HostedBy Multi-Multi Relationship Table
{
    public HostedBy() { }

    public HostedBy(Event evnt, Host host)
    {
        Event = evnt;
        Host = host;
    }
    [Key] public Guid HostedID { get; set; }
    public Event Event { get; set; }              //FK for Event
    public Host Host { get; set; }                //FK for Host
}


public class Employee                                   //Employee Entity Table
{
    [Key] public Guid EmpID { get; set; }
    public string Name { get; set; }
    public string PhoneNum { get; set; }
    public string Email { get; set; }
    public decimal Pay { get; set; }
    public string? ShiftSchedule { get; set; }      
    public Location? Location { get; set; }              //FK to location of workplace if applicable

    public Host Host { get; set; }
    public Guid? HostID { get; set; }                      //FK to host they work for if applicable
}

public class Presenter
{
    [Key] public int PresenterID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public decimal PresenterFee { get; set; }
}

[PrimaryKey(nameof(RoomID), nameof(Time))]
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
    [Key] public Guid VendorID { get; set; }               //ID of vendor
    public string Name { get; set; }                //Name of vendor
    public string Email { get; set; }               //Email of vendor
    public string PhoneNum { get; set; }            //Phone number of vendor
    public decimal Fee { get; set; }                //Fee for space (charged to vendor)
}