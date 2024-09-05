using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibX.Migrations.BookDb
{
    /// <inheritdoc />
    public partial class InitialCreateForBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RFID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelfLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MemberInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckoutDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssuedByStaff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Defects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBackup = table.Column<bool>(type: "bit", nullable: false),
                    EstimatedValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimesExchanged = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
