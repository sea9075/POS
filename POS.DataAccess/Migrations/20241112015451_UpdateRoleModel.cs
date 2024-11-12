using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoleModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "Role",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "Role",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3828));
        }
    }
}
