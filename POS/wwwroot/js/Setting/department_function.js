function selectTable(name) {
    var allTable = document.querySelectorAll("tbody");

    // 因為 allTable 總共有 5 個， i = 0 是不需要操作的 tbody
    for (var i = 1; i < allTable.length; i++) {
        // 隱藏所有 tbody
        allTable[i].style.display = "none";
    }

    // 顯示指定的 table
    var asignTable = document.getElementById(name);
    asignTable.style.display = "";
}