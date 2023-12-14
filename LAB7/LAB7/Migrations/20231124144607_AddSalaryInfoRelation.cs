using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB7.Migrations
{
    /// <inheritdoc />
    public partial class AddSalaryInfoRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "SalaryInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalaryInfo",
                table: "SalaryInfo",
                column: "EmployeeId");
            migrationBuilder.InsertData(
                table: "SalaryInfo",
                columns: new[] { "EmployeeId", "Net", "Gross" },
                values: new object[,]
                {
                    { 1, 5000, 6000 },
                    { 2, 5000, 6000 },
                    { 3, 5000, 6000 },
                    { 4, 5000, 6000 },
                    { 5, 5000, 6000 },
                    { 6, 5000, 6000 },
                    { 7, 5000, 6000 },
                    { 8, 5000, 6000 },
                });
            migrationBuilder.CreateIndex(
                name: "IX_SalaryInfo_EmployeeId",
                table: "SalaryInfo",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryInfo_Employees_EmployeeId",
                table: "SalaryInfo",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryInfo_Employees_EmployeeId",
                table: "SalaryInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalaryInfo",
                table: "SalaryInfo");

            migrationBuilder.DropIndex(
                name: "IX_SalaryInfo_EmployeeId",
                table: "SalaryInfo");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "SalaryInfo");
        }
    }
}
