using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace POS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFakeDataToDepartment_FunctionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.InsertData(
                table: "Department_Function",
                columns: new[] { "DepartmentId", "FunctionId", "IsEnable", "Timeset" },
                values: new object[,]
                {
                    { 1, 16, true, new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9555) },
                    { 1, 17, true, new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9557) },
                    { 1, 18, true, new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(9557) }
                });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 16,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 17,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 18,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 15, 4, 6, 341, DateTimeKind.Local).AddTicks(6969));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 117, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 16,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 17,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 18,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8017));
        }
    }
}
