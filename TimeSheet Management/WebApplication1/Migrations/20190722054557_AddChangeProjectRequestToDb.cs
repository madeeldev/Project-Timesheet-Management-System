using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetManagement.Migrations
{
    public partial class AddChangeProjectRequestToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChangeProjectRequests",
                columns: table => new
                {
                    ChangeProjectRequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false),
                    IndividualId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeProjectRequests", x => x.ChangeProjectRequestId);
                    table.ForeignKey(
                        name: "FK_ChangeProjectRequests_AspNetUsers_IndividualId",
                        column: x => x.IndividualId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChangeProjectRequests_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChangeProjectRequests_IndividualId",
                table: "ChangeProjectRequests",
                column: "IndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeProjectRequests_ProjectId",
                table: "ChangeProjectRequests",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeProjectRequests");
        }
    }
}
