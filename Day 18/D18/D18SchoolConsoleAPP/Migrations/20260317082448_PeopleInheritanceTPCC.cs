using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D18SchoolConsoleAPP.Migrations
{
    /// <inheritdoc />
    public partial class PeopleInheritanceTPCC : Migration
    {
        /// <inheritdoc />
        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropPrimaryKey(
        //        name: "PK_People",
        //        table: "People");

        //    migrationBuilder.DropColumn(
        //        name: "EnrollmentDate",
        //        table: "People");

        //    migrationBuilder.DropColumn(
        //        name: "Grade",
        //        table: "People");

        //    //migrationBuilder.DropColumn(
        //    //    name: "Id",
        //    //    table: "People");

        //    migrationBuilder.RenameTable(
        //        name: "People",
        //        newName: "WalkInStudents");

        //    //migrationBuilder.AddColumn<int>
        //    //    (name: "Id", table: "WalkInStudents", type: "int", nullable: true
        //    //    );

        //    migrationBuilder.CreateSequence(
        //        name: "PersonSequence");

        //    migrationBuilder.AlterColumn<string>(
        //        name: "CourseCode",
        //        table: "WalkInStudents",
        //        type: "nvarchar(10)",
        //        maxLength: 10,
        //        nullable: false,
        //        defaultValue: "",
        //        oldClrType: typeof(string),
        //        oldType: "nvarchar(10)",
        //        oldMaxLength: 10,
        //        oldNullable: true);

        //    migrationBuilder.AlterColumn<int>(
        //        name: "Id",
        //        table: "WalkInStudents",
        //        type: "int",
        //        nullable: false,
        //        defaultValueSql: "NEXT VALUE FOR [PersonSequence]",
        //        oldClrType: typeof(int),
        //        oldType: "int")
        //        .OldAnnotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.AddPrimaryKey(
        //        name: "PK_WalkInStudents",
        //        table: "WalkInStudents",
        //        column: "Id");

        //    migrationBuilder.CreateTable(
        //        name: "FullTimeStudents",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonSequence]"),
        //            Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
        //            IsEnrolled = table.Column<bool>(type: "bit", nullable: false),
        //            Grade = table.Column<byte>(type: "tinyint", nullable: false),
        //            EnrollmentDate = table.Column<DateOnly>(type: "date", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FullTimeStudents", x => x.Id);
        //        });
        //}


        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Note: SQL Server does not allow changing IDENTITY with ALTER COLUMN.
            // This implementation drops/creates new tables and preserves existing Id values
            // by inserting them explicitly into new tables that use a SEQUENCE for new rows.

            // keep original intention: remove primary key from old table so we can drop it later
            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            // Create or restart a sequence that starts after the current max Id in People.
            // Use dynamic SQL to set the START WITH value = MAX(Id) + 1 to avoid collisions.
            migrationBuilder.Sql(@"
                    DECLARE @maxId int = (SELECT ISNULL(MAX(Id), 0) FROM People);

                    IF NOT EXISTS (SELECT * FROM sys.sequences WHERE name = 'PersonSequence')
                    BEGIN
                        DECLARE @sql01 nvarchar(max) = N'CREATE SEQUENCE PersonSequence START WITH ' + CAST(@maxId + 1 AS nvarchar(20)) + N' INCREMENT BY 1;';
                        EXEC sp_executesql @sql01;
                    END
                    ELSE
                    BEGIN
                        DECLARE @sql02 nvarchar(max) = N'ALTER SEQUENCE PersonSequence RESTART WITH ' + CAST(@maxId + 1 AS nvarchar(20)) + N';';
                        EXEC sp_executesql @sql02;
                    END
                    ");

            // Create the WalkInStudents table (new concrete table for walk-ins)
            // Id uses the sequence for future inserts; we'll explicitly insert existing Ids.
            migrationBuilder.CreateTable(
                name: "WalkInStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonSequence]"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsEnrolled = table.Column<bool>(type: "bit", nullable: false),
                    CourseCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalkInStudents", x => x.Id);
                });

            // Create the FullTimeStudents table (new concrete table for full-time students)
            migrationBuilder.CreateTable(
                name: "FullTimeStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonSequence]"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsEnrolled = table.Column<bool>(type: "bit", nullable: false),
                    Grade = table.Column<byte>(type: "tinyint", nullable: false),
                    EnrollmentDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullTimeStudents", x => x.Id);
                });

            // Move data from the existing People table into the two new tables.
            // - Rows that have Grade or EnrollmentDate are treated as FullTimeStudent.
            // - Other rows become WalkInStudent; ensure CourseCode is not null by using ISNULL(...,'').
            migrationBuilder.Sql(@"
                INSERT INTO FullTimeStudents (Id, Name, IsEnrolled, Grade, EnrollmentDate)
                SELECT Id, Name, IsEnrolled, Grade, EnrollmentDate
                FROM People
                WHERE Grade IS NOT NULL OR EnrollmentDate IS NOT NULL;
                ");

                            migrationBuilder.Sql(@"
                INSERT INTO WalkInStudents (Id, Name, IsEnrolled, CourseCode)
                SELECT Id, Name, IsEnrolled, ISNULL(CourseCode, '')
                FROM People
                WHERE Grade IS NULL AND EnrollmentDate IS NULL;
                ");

            // Drop the old People table now that data has been migrated.
            migrationBuilder.Sql("DROP TABLE People;");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullTimeStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WalkInStudents",
                table: "WalkInStudents");

            migrationBuilder.DropSequence(
                name: "PersonSequence");

            migrationBuilder.RenameTable(
                name: "WalkInStudents",
                newName: "People");

            migrationBuilder.AlterColumn<string>(
                name: "CourseCode",
                table: "People",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "People",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [PersonSequence]")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateOnly>(
                name: "EnrollmentDate",
                table: "People",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Grade",
                table: "People",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");
        }
    }
}
