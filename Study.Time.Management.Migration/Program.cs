using System;

namespace Study.Time.Management.Migration
{
    public class Program
    {
        static int Main(string[] args)
        {
            var connectionString = "Server=localhost; User Id=postgres; Password=yourPassword; Database=study_time_management; CommandTimeout=0; Timeout=1024;";
            var error= Migrations.ApplyMigrations(connectionString);
            
            if (error != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error);
                Console.ResetColor();
                return -1;
            }
            return 0;
        }
    }
}
