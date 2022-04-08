using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballPools.Web.Migrations
{
    public partial class new_entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Tournaments_TournamentId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_TournamentId",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "GoalsVisitor",
                table: "Matches",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GoalsLocal",
                table: "Matches",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Groups",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TournamentId1",
                table: "Groups",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TournamentId1",
                table: "Groups",
                column: "TournamentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Tournaments_TournamentId1",
                table: "Groups",
                column: "TournamentId1",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Tournaments_TournamentId1",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_TournamentId1",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "TournamentId1",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "GoalsVisitor",
                table: "Matches",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GoalsLocal",
                table: "Matches",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TournamentId",
                table: "Groups",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Tournaments_TournamentId",
                table: "Groups",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
