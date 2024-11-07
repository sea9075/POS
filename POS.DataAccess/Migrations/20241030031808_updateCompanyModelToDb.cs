using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateCompanyModelToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "CompantId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "CompantId");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 11, 18, 4, 739, DateTimeKind.Local).AddTicks(4077));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompantId",
                table: "Company");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Name");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7363));
        }
    }
}
