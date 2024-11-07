function selectDepartmentId(departmentId) {
    var inputDepartmentId = document.querySelectorAll(".input-department-id");
    var functionButtons = document.querySelectorAll("button");

    for (var i = 0; i < inputDepartmentId.length; i++) {
        inputDepartmentId[i].value = departmentId;
    }

    for (var i = 0; i < functionButtons.length; i++) {
        functionButtons[i].removeAttribute("disabled");
    }
}

// 顯示 FunctionList
function showTable(name) {
    var hiddenTables = document.querySelectorAll('.hidden-Table');
    for (var i = 0; i < hiddenTables.length; i++) {
        hiddenTables[i].style.display = "none";
    }
    var showTable = document.getElementById(name + "Table");
    showTable.style.display = "";
}