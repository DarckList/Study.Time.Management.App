using DbUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Migration
{
    public static class Migrations
    {
        public static Exception? ApplyMigrations(string postgreSqlConnectionString)
        {
            var upgrader =
               DeployChanges.To
               .PostgresqlDatabase(postgreSqlConnectionString)
               .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
               .LogToConsole()
               .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                return result.Error;
            }

            return null;
        }
    }
}
