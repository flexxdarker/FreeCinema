using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedPP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlacePrice_Places_PlaceId",
                table: "PlacePrice");

            migrationBuilder.DropForeignKey(
                name: "FK_PlacePrice_Sessions_SessionId",
                table: "PlacePrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlacePrice",
                table: "PlacePrice");

            migrationBuilder.RenameTable(
                name: "PlacePrice",
                newName: "PlacesPrice");

            migrationBuilder.RenameIndex(
                name: "IX_PlacePrice_SessionId",
                table: "PlacesPrice",
                newName: "IX_PlacesPrice_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_PlacePrice_PlaceId",
                table: "PlacesPrice",
                newName: "IX_PlacesPrice_PlaceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlacesPrice",
                table: "PlacesPrice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlacesPrice_Places_PlaceId",
                table: "PlacesPrice",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlacesPrice_Sessions_SessionId",
                table: "PlacesPrice",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlacesPrice_Places_PlaceId",
                table: "PlacesPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_PlacesPrice_Sessions_SessionId",
                table: "PlacesPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlacesPrice",
                table: "PlacesPrice");

            migrationBuilder.RenameTable(
                name: "PlacesPrice",
                newName: "PlacePrice");

            migrationBuilder.RenameIndex(
                name: "IX_PlacesPrice_SessionId",
                table: "PlacePrice",
                newName: "IX_PlacePrice_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_PlacesPrice_PlaceId",
                table: "PlacePrice",
                newName: "IX_PlacePrice_PlaceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlacePrice",
                table: "PlacePrice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlacePrice_Places_PlaceId",
                table: "PlacePrice",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlacePrice_Sessions_SessionId",
                table: "PlacePrice",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
