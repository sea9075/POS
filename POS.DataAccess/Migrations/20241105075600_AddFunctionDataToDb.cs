using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFunctionDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FunctionChineseName",
                table: "Function",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

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
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "總公司 - 基本資料", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "條碼成本編碼", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "信用卡手續費", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "公司部門資料", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "員工基本資料", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "員工登入資料", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "程式功能", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "公司發票資料", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "系統 IP 權限設定", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "群組資料設定", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "各店點 - 基本資料", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "各店點 - 目標設定", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "各倉庫 - 基本資料", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "門號系統商設定", new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 5, 15, 55, 57, 434, DateTimeKind.Local).AddTicks(4294));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FunctionChineseName",
                table: "Function");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 10, 30, 15, 10, 59, 527, DateTimeKind.Local).AddTicks(5004));
        }
    }
}
