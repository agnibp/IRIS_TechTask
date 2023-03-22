using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO BankDetails(bank_name, bank_head_office_location) VALUES('SBI', 'Mumbai')");
            migrationBuilder.Sql("INSERT INTO BankDetails(bank_name, bank_head_office_location) VALUES('PNB', 'Delhi')");
            migrationBuilder.Sql("INSERT INTO BankDetails(bank_name, bank_head_office_location) VALUES('UCO Bank', 'Bengaluru')");
            migrationBuilder.Sql("INSERT INTO BankDetails(bank_name, bank_head_office_location) VALUES('HDFC Bank', 'Kolkata')");
            migrationBuilder.Sql("INSERT INTO BankDetails(bank_name, bank_head_office_location) VALUES('HSBC', 'Chennai')");
            migrationBuilder.Sql("INSERT INTO BankDetails(bank_name, bank_head_office_location) VALUES('ICICI Bank', 'Pune')");
            migrationBuilder.Sql("INSERT INTO BankDetails(bank_name, bank_head_office_location) VALUES('Axis Bank', 'Hyderabad')");
            migrationBuilder.Sql("INSERT INTO BankDetails(bank_name, bank_head_office_location) VALUES('Bandhan Bank', 'Gurgaon')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM BankDetails");
        }
    }
}
