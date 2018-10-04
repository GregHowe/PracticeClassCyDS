using FluentMigrator;
using System.Reflection;

namespace EnterprisePatterns.Api.Migrations.MySQL
{
    [Migration(2)]
    public class UsuarioTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("2_UsuarioTable.sql");
        }

        public override void Down()
        {
        }
    }
}
