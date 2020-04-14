using Microsoft.EntityFrameworkCore.Migrations;

namespace Job_Portal_API.Migrations
{
    public partial class Job_Portal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employer_Name = table.Column<string>(nullable: true),
                    Job_Title = table.Column<string>(nullable: true),
                    Job_Description = table.Column<string>(nullable: true),
                    SalaryRange = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPortal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPortal");
        }
    }
}
