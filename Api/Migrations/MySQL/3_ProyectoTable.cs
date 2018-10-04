using FluentMigrator;
using System.Reflection;

namespace EnterprisePatterns.Api.Migrations.MySQL
{
    [Migration(3)]
    public class ProyectoTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("3_ProyectoTable.sql");
        }

        public override void Down()
        {
        }
    }
}
