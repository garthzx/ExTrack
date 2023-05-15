using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_Tracker.Migrations
{
    public partial class IncreasedLengthNoteAttr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Transactions",
                type: "NVARCHAR(75)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(5)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Transactions",
                type: "NVARCHAR(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(75)",
                oldNullable: true);
        }
    }
}
