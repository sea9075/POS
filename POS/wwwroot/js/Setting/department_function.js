let departmentId = 0;

document.querySelectorAll(".getDepartmentId").forEach(link => {
    link.addEventListener("click", function () {
        event.preventDefault();
        departmentId = this.getAttribute("data-department-id");
        console.log(departmentId);
    });
});

// 顯示對應的資料
document.getElementById("showFrontSetting").addEventListener("click", function () {
    showTable("frontTable")
});

document.getElementById("showBackSetting").addEventListener("click", function () {
    showTable("backTable")
});

document.getElementById("showAnalyzeSetting").addEventListener("click", function () {
    showTable("analyzeTable")
})

document.getElementById("showFixSetting").addEventListener("click", function () {
    showTable("fixTable")
})

function showTable(tableId) {
    var tables = document.querySelectorAll('select-table');
    tables.forEach(function (table) {
        table.style.display = 'none';
    });

    document.getElementById(tableId).style.display = 'table-row-group';
    console.log("AAA");
}