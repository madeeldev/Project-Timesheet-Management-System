using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetManagement.Migrations
{
    public partial class AddWeekSettingsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeekSettings",
                columns: table => new
                {
                    WeekSettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDay = table.Column<string>(nullable: true),
                    EndDay = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    WorkspaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekSettings", x => x.WeekSettingId);
                    table.ForeignKey(
                        name: "FK_WeekSettings_Workspaces_WorkspaceId",
                        column: x => x.WorkspaceId,
                        principalTable: "Workspaces",
                        principalColumn: "WorkspaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeekSettings_WorkspaceId",
                table: "WeekSettings",
                column: "WorkspaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeekSettings");
        }
    }
}
