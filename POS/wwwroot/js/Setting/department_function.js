// 取得 DepartmentId
function getDepartmentId(id) {
    // 將 DepartmentId 放入到隱藏的 Input 中
    var inputDepartmentId = document.querySelectorAll(".inputDepartmentId");
    for (var i = 0; i < inputDepartmentId.length; i++) {
        inputDepartmentId[i].value = id;
    }

    // 必須要選擇 Department 才可以選擇 Function
    var selectFunctionButton = document.querySelectorAll(".selectFunction");
    for (var i = 0; i < selectFunctionButton.length; i++) {
        selectFunctionButton[i].removeAttribute("disabled");
    }
}

// 選擇指定的 Function Table
function selectTable(name) {
    // 隱藏全部 Table
    var allTables = document.querySelectorAll(".hidden-table");
    allTables.forEach(function (table) {
        table.style.display = "none";
    });
    // 顯示指定的 Table
    var assignTable = document.getElementById(name + "-table");
    if (assignTable) {
        assignTable.style.display = "";
    } else {
        console.warn("指定的表格不存在" + name + "-table");
    }
}