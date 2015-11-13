using CodeholicsSPA.Data;
using CodeholicsSPA.Data.Migrations;
using System.Data.Entity;

namespace CodeholicsSPA.Api
{
    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CodeholicsSPADbContext, Configuration>());
        }
    }
}