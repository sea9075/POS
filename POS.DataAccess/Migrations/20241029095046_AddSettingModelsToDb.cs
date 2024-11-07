using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace POS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSettingModelsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "CostBarcode",
                columns: table => new
                {
                    CostBarcodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarcodeType = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Formula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Front1 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Front2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Front3 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number0 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number1 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number3 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number4 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number5 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number6 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number7 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number8 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Number9 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Back1 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Back2 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Back3 = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostBarcode", x => x.CostBarcodeId);
                });

            migrationBuilder.CreateTable(
                name: "CreditCardFee",
                columns: table => new
                {
                    CreditCardFeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditCardFeeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(5,4)", nullable: false),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardFee", x => x.CreditCardFeeId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Ext = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMarried = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID_Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Cellphone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmerencyContact = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmerencyContactPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Education = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Skill = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SalesTarget = table.Column<int>(type: "int", nullable: true),
                    GrossProfit = table.Column<int>(type: "int", nullable: true),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Function",
                columns: table => new
                {
                    FunctionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FunctionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Function", x => x.FunctionId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceInfo",
                columns: table => new
                {
                    InvoiceInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxIDNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TaxAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceInfo", x => x.InvoiceInfoId);
                });

            migrationBuilder.CreateTable(
                name: "IP_Permission",
                columns: table => new
                {
                    IP_PermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IP_Address = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IP_Permission", x => x.IP_PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CanRead = table.Column<bool>(type: "bit", nullable: false),
                    CanCreate = table.Column<bool>(type: "bit", nullable: false),
                    CanEdit = table.Column<bool>(type: "bit", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: false),
                    CanPrint = table.Column<bool>(type: "bit", nullable: false),
                    CanAudit = table.Column<bool>(type: "bit", nullable: false),
                    CanReview = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    InvoiceTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TaxIDNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    RespomsiblePerson = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BusinessTime = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Group = table.Column<int>(type: "int", nullable: true),
                    InvoiceType = table.Column<int>(type: "int", nullable: true),
                    SalesOrderTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ShopId);
                });

            migrationBuilder.CreateTable(
                name: "Department_Function",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    FunctionId = table.Column<int>(type: "int", nullable: false),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_Function", x => new { x.DepartmentId, x.FunctionId });
                    table.ForeignKey(
                        name: "FK_Department_Function_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Department_Function_Function_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Function",
                        principalColumn: "FunctionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLogin",
                columns: table => new
                {
                    EmployeeLoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(255)", maxLength: 16, nullable: false),
                    LimitCheckPurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LimitEditSalesOrder = table.Column<int>(type: "int", nullable: true),
                    EditSafetyStock = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLogin", x => x.EmployeeLoginId);
                    table.ForeignKey(
                        name: "FK_EmployeeLogin_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLogin_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLogin_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopSalesTarget",
                columns: table => new
                {
                    ShopSalesTargetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearAndMonth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthlySalesTarget = table.Column<int>(type: "int", nullable: true),
                    MonthlyGrossProfitTarget = table.Column<int>(type: "int", nullable: true),
                    ShopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopSalesTarget", x => x.ShopSalesTargetId);
                    table.ForeignKey(
                        name: "FK_ShopSalesTarget_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Group = table.Column<int>(type: "int", nullable: true),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stock_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "ShopId");
                });

            migrationBuilder.CreateTable(
                name: "TelecomSetting",
                columns: table => new
                {
                    TelecomSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AgentReceiptCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CountAgentReceiptGrossProfitFormula = table.Column<decimal>(type: "decimal(7,4)", nullable: true),
                    TotalAgentReceiptGrossProfitFormula = table.Column<decimal>(type: "decimal(7,4)", nullable: true),
                    Timeset = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelecomSetting", x => x.TelecomSettingId);
                    table.ForeignKey(
                        name: "FK_TelecomSetting_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Address", "Ext", "Fax", "Name", "Note", "Phone", "ShortName", "Timeset", "Url" },
                values: new object[] { 1, null, null, null, "Admin", null, null, "Admin", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7335), null });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Address", "Cellphone", "Education", "Email", "EmerencyContact", "EmerencyContactPhone", "EndDate", "Gender", "GrossProfit", "ID_Number", "IsMarried", "Name", "Note", "PermanentAddress", "Phone", "Photo", "SalesTarget", "Skill", "StartDate", "Timeset" },
                values: new object[] { 1, "*", "*", "*", "*", "*", "*", null, null, null, "*", false, "Admin", null, "*", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.InsertData(
                table: "Function",
                columns: new[] { "FunctionId", "FunctionName", "Timeset" },
                values: new object[,]
                {
                    { 1, "Company", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7380) },
                    { 2, "CostBarcode", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7381) },
                    { 3, "CreditCardFee", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7383) },
                    { 4, "Department", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7384) },
                    { 5, "Department_Function", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7385) },
                    { 6, "Employee", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7386) },
                    { 7, "EmployeeLogin", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7387) },
                    { 8, "Function", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7388) },
                    { 9, "InvoiceInfo", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7389) },
                    { 10, "IP_Permission", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7390) },
                    { 11, "Role", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7391) },
                    { 12, "Shop", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7392) },
                    { 13, "ShopSalesTarget", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7393) },
                    { 14, "Stock", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7394) },
                    { 15, "TelecomSetting", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7395) }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "CanAudit", "CanCreate", "CanDelete", "CanEdit", "CanPrint", "CanRead", "CanReview", "Name", "Note", "ShortName", "Timeset" },
                values: new object[] { 1, true, true, true, true, true, true, true, "Admin", null, "Admin", new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.InsertData(
                table: "Department_Function",
                columns: new[] { "DepartmentId", "FunctionId", "IsEnable", "Timeset" },
                values: new object[,]
                {
                    { 1, 1, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(212) },
                    { 1, 2, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(218) },
                    { 1, 3, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(219) },
                    { 1, 4, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(220) },
                    { 1, 5, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(221) },
                    { 1, 6, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(222) },
                    { 1, 7, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(223) },
                    { 1, 8, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(223) },
                    { 1, 9, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(224) },
                    { 1, 10, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(225) },
                    { 1, 11, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(226) },
                    { 1, 12, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(228) },
                    { 1, 13, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(229) },
                    { 1, 14, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(230) },
                    { 1, 15, true, new DateTime(2024, 10, 29, 17, 50, 45, 408, DateTimeKind.Local).AddTicks(231) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeLogin",
                columns: new[] { "EmployeeLoginId", "Account", "DepartmentId", "EditSafetyStock", "EmployeeId", "HashPassword", "LimitCheckPurchaseDate", "LimitEditSalesOrder", "RoleId", "Timeset" },
                values: new object[] { 1, "Administrator", 1, null, 1, "Jxwlw+635GmPXCaLI+JE5lfM/kUoiMa5roykjbAfrPU=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2024, 10, 29, 17, 50, 45, 407, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.CreateIndex(
                name: "IX_CostBarcode_BarcodeType",
                table: "CostBarcode",
                column: "BarcodeType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CreditCardFee_CreditCardFeeName",
                table: "CreditCardFee",
                column: "CreditCardFeeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_ShortName_Name",
                table: "Department",
                columns: new[] { "ShortName", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_Function_DepartmentId_FunctionId",
                table: "Department_Function",
                columns: new[] { "DepartmentId", "FunctionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_Function_FunctionId",
                table: "Department_Function",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Function_IsEnable",
                table: "Department_Function",
                column: "IsEnable");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Email",
                table: "Employee",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Name_ID_Number",
                table: "Employee",
                columns: new[] { "Name", "ID_Number" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Phone",
                table: "Employee",
                column: "Phone",
                unique: true,
                filter: "[Phone] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogin_Account",
                table: "EmployeeLogin",
                column: "Account",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogin_DepartmentId",
                table: "EmployeeLogin",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogin_EmployeeId",
                table: "EmployeeLogin",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogin_RoleId",
                table: "EmployeeLogin",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Function_FunctionName",
                table: "Function",
                column: "FunctionName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceInfo_TaxIDNumber_BusinessName",
                table: "InvoiceInfo",
                columns: new[] { "TaxIDNumber", "BusinessName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IP_Permission_IP_Address_Name",
                table: "IP_Permission",
                columns: new[] { "IP_Address", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_ShortName_Name",
                table: "Role",
                columns: new[] { "ShortName", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Name_TaxIDNumber",
                table: "Shop",
                columns: new[] { "Name", "TaxIDNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shop_RespomsiblePerson",
                table: "Shop",
                column: "RespomsiblePerson");

            migrationBuilder.CreateIndex(
                name: "IX_ShopSalesTarget_ShopId_YearAndMonth",
                table: "ShopSalesTarget",
                columns: new[] { "ShopId", "YearAndMonth" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_Name",
                table: "Stock",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ShopId",
                table: "Stock",
                column: "ShopId",
                unique: true,
                filter: "[ShopId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TelecomSetting_ShopId",
                table: "TelecomSetting",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_TelecomSetting_ShortName_ShopId",
                table: "TelecomSetting",
                columns: new[] { "ShortName", "ShopId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "CostBarcode");

            migrationBuilder.DropTable(
                name: "CreditCardFee");

            migrationBuilder.DropTable(
                name: "Department_Function");

            migrationBuilder.DropTable(
                name: "EmployeeLogin");

            migrationBuilder.DropTable(
                name: "InvoiceInfo");

            migrationBuilder.DropTable(
                name: "IP_Permission");

            migrationBuilder.DropTable(
                name: "ShopSalesTarget");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "TelecomSetting");

            migrationBuilder.DropTable(
                name: "Function");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}
