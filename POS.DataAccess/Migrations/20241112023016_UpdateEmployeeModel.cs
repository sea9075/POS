using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 977, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "BirthDate", "Timeset" },
                values: new object[] { null, new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 10, 30, 14, 976, DateTimeKind.Local).AddTicks(8777));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Employee");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 12, 9, 54, 48, 265, DateTimeKind.Local).AddTicks(3755));
        }
    }
}
