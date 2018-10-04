using FluentMigrator;
using System.Reflection;

namespace EnterprisePatterns.Api.Migrations.MySQL
{
    [Migration(1)]
    public class ClientTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("1_ClientTable.sql");
        }

        public override void Down()
        {
        }
    }
}
