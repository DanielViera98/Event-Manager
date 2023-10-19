using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;

//Create new class for database context
public class EventContext : DbContext
{
    public DbSet<Event> Events { get; set; }    //Table containing Stock classes
    public DbSet<Location> Locations { get; set; }    //Table containing Stock classes
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

public class Event                             //Stock class containing all information for stock
{
    //Ignore so that the csvReader does not try and use it as a column to read into. Key marks as unique identifier for entry.
    [Key] public Guid EventId { get; set; }              //Identifier for Stock entry.
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Website {  get; set; }
    public Location Location { get; set; }

}

public class Location
{
    [Key] public string Address { get; set; }
    public string Website { get; set; }
    public string Email { get; set; }
    public float RentalFee { get; set; }
    public int VendorCapacity { get; set; }
    public int AttendeeCapacity { get; set; }
    public List<Event> Events { get; set; }
}