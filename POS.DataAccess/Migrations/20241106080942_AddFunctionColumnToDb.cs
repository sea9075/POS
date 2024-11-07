using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFunctionColumnToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "Function",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 6, 16, 9, 39, 47, DateTimeKind.Local).AddTicks(3828));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Function");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4294));
        }
    }
}
