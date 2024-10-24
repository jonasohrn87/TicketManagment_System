using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class Updatedtabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Prioritys_PriorityId",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "PriorityId1",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4386da6-2c10-4bad-8790-b7d28fa6ae35", "AQAAAAIAAYagAAAAEL++tlyujCvsWk/G1OenIYfNO4yafkztBDgXbmjhJbqC1GlVhXmmWwvhh7H27vcyog==", "5447ffda-6e31-4f3e-b7cb-4b96a3628d10" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "PriorityId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "PriorityId1",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PriorityId1",
                table: "Tickets",
                column: "PriorityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Categories_PriorityId",
                table: "Tickets",
                column: "PriorityId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Prioritys_PriorityId1",
                table: "Tickets",
                column: "PriorityId1",
                principalTable: "Prioritys",
                principalColumn: "PriorityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Categories_PriorityId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Prioritys_PriorityId1",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PriorityId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PriorityId1",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65d1a9e8-75db-4a14-b831-60be3b6cb83e", "AQAAAAIAAYagAAAAEEQPixmAMeJLOQP0Ms//LE9y4YJdKW6VL9GsVwTSCr4C6S8v2lywuDfvcRCIX81EVw==", "8053cec2-807d-4141-be79-1ba87126973a" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Prioritys_PriorityId",
                table: "Tickets",
                column: "PriorityId",
                principalTable: "Prioritys",
                principalColumn: "PriorityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
