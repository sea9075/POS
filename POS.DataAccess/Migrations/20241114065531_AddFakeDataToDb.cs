using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace POS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFakeDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                columns: new[] { "FunctionChineseName", "Group", "Timeset" },
                values: new object[] { "公司部門權限管理", 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "", new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.InsertData(
                table: "Function",
                columns: new[] { "FunctionId", "FunctionChineseName", "FunctionName", "Group", "Timeset" },
                values: new object[,]
                {
                    { 16, null, "FrontFakeFunction1", 2, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8059) },
                    { 17, null, "AnalyzeFakeFunction2", 3, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8060) },
                    { 18, null, "FixFakeFunction3", 4, new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8061) }
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 14, 14, 55, 28, 116, DateTimeKind.Local).AddTicks(8017));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 1 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 2 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 3 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 4 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 5 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 6 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 7 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 8 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 9 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 10 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 11 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 12 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 13 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 14 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Department_Function",
                keyColumns: new[] { "DepartmentId", "FunctionId" },
                keyValues: new object[] { 1, 15 },
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 746, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "EmployeeLogin",
                keyColumn: "EmployeeLoginId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 1,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 2,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 3,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 4,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 5,
                columns: new[] { "FunctionChineseName", "Group", "Timeset" },
                values: new object[] { "", 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 6,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 7,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 8,
                columns: new[] { "FunctionChineseName", "Timeset" },
                values: new object[] { "程式功能", new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 9,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 10,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 11,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 12,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 13,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 14,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Function",
                keyColumn: "FunctionId",
                keyValue: 15,
                columns: new[] { "Group", "Timeset" },
                values: new object[] { 0, new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Timeset",
                value: new DateTime(2024, 11, 13, 13, 10, 45, 745, DateTimeKind.Local).AddTicks(9892));
        }
    }
}
