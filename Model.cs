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
    public string DbPath { get; }               //Path to the database
    public string StockPath { get; set; }       //Path to the Stock Files folder

    public EventContext()                               //Constructor for StockContext
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;    //Get folder name for data
        var path = Environment.GetFolderPath(folder);                   //Get path to folder
        DbPath = System.IO.Path.Join(path, "Stocks.db");                //Update path variable to folder + name for database
        string mypath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);    //Get path to exe location
        if (mypath != null)
        {
            //Get substring of path to solution folder, then add "\Stock Data". Save as StockPath.
            mypath = mypath.Substring(0, mypath.IndexOf("COP4365_Project1") + "COP4365_Project1".Length);
            mypath += "\\Stock Data";
            StockPath = mypath;
        }
        else
        {
            Debug.WriteLine("FAILED TO GET CURRENT DIRECTORY");
            return;
        }
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
    [Key] public Guid Id { get; set; }              //Identifier for Stock entry.
    public DateOnly Date { get; set; }                      //Date of stock (DateTime format)
    public string Ticker { get; set; }                      //Stock Ticker (Three/four letter string)
    public string Period { get; set; }                      //Timespan for the stock (month/week/day)
    public double Open { get; set; }                        //Open value for stock (Dollars-Cents)
    public double High { get; set; }                        //High value for stock (Dollars-Cents)
    public double Low { get; set; }                         //Low value for stock (Dollars-Cents)
    public double Close { get; set; }                       //Close value for stock (Dollars-Cents)
    //Needs to be 64-bit, numbers get too large for signed 32-bit
    public Int64 Volume { get; set; }                       //Volume value for stock (Int count)
    public string StockFilePath { get; set; }      //Path to file
}

public class Location
{
    [Key] public string Address { get; set; }
    public string Website { get; set; }
    public string Email { get; set; }
    public float RentalFee { get; set; }
    public int VendorCapacity { get; set; }
    public int AttendeeCapacity { get; set; }
}