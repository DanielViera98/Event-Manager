namespace Event_Manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EventContext db = new EventContext();
            db.Events.Add(new Event { Description = "", EndDate = DateTime.Now.ToUniversalTime(), Name = "test", 
                StartDate = DateTime.Now.ToUniversalTime(), Website = "ddsd"});
            db.SaveChanges();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}