using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D18SchoolConsoleAPP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeachFullName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "FullName",
               table: "SchoolWorkers",
               type: "nvarchar(150)",
               maxLength: 150,
               nullable: false,
               defaultValue: "");

            migrationBuilder.Sql("""
                update [SchoolWorkers]
                Set FullName = FName +' ' + LName
                """);

            migrationBuilder.DropColumn(
                name: "FName",
                table: "SchoolWorkers");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "SchoolWorkers");
           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "SchoolWorkers");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "SchoolWorkers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "SchoolWorkers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
