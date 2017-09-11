using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");   
             migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make2')");   
             migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make3')");   

             migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make1-model a', (SELECT ID FROM Makes WHERE Name = 'Make1'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make1 model b', (SELECT ID FROM Makes WHERE Name = 'Make1'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make2 model a', (SELECT ID FROM Makes WHERE Name = 'Make2'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make2 model b', (SELECT ID FROM Makes WHERE Name = 'Make2'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make3 model a', (SELECT ID FROM Makes WHERE Name = 'Make3'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Make3 model b', (SELECT ID FROM Makes WHERE Name = 'Make3'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
        }
    }
}
