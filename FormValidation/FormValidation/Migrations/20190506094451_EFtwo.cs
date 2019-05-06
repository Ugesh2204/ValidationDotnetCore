using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FormValidation.Migrations
{
    public partial class EFtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "EmployeeLastName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "EmployeeFirstName");

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeLastName",
                table: "Employees",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "EmployeeFirstName",
                table: "Employees",
                newName: "Email");
        }
    }
}
