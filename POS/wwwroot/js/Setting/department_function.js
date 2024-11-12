// 分類功能
function selectTable(name) {
    // 隱藏所有表格
    var allTables = document.querySelectorAll('.hidden-table');
    for (var i = 0; i < allTables.length; i++) {
        allTables[i].style.display = "none";
    }

    // 顯示指定的表格
    var selectedTables = document.querySelectorAll(name);
    for (var i = 0; i < selectedTables.length; i++) {
        selectedTables[i].style.display = "table-row";
    }
}