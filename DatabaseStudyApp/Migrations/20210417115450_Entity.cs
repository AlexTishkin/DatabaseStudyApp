using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseStudyApp.Migrations
{
    public partial class Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "_created",
                table: "Musics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "_deleted",
                table: "Musics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "_updated",
                table: "Musics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "_created",
                table: "MusicGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "_deleted",
                table: "MusicGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "_updated",
                table: "MusicGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_created",
                table: "Musics");

            migrationBuilder.DropColumn(
                name: "_deleted",
                table: "Musics");

            migrationBuilder.DropColumn(
                name: "_updated",
                table: "Musics");

            migrationBuilder.DropColumn(
                name: "_created",
                table: "MusicGroups");

            migrationBuilder.DropColumn(
                name: "_deleted",
                table: "MusicGroups");

            migrationBuilder.DropColumn(
                name: "_updated",
                table: "MusicGroups");
        }
    }
}
