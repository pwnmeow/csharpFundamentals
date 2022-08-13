namespace Compositions
{ 
    class Program {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new Logger());
            dbMigrator.Migrate();   

            var instaler = new Installer(new Logger());
            instaler.Install();
        }

    }
}