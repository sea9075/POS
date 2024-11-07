// 取得所有按鈕
var addButton = document.getElementById("addButton");
var editButton = document.getElementById("editButton");
var deleteButton = document.getElementById("deleteButton")
var cancelButton = document.getElementById("cancelButton");
var searchButton = document.getElementById("searchButton");
var printButton = document.getElementById("printButton");
var submitButton = document.getElementById("submitButton");

// 取得非隱藏的 input
var inputTags = document.querySelectorAll("input:not([type='hidden'])");
// 取得 textarea
var textareaTags = document.querySelectorAll("textarea");
// 取得隱藏的 input
var inputHiddenTag = document.getElementById("ModelId");
// 取得 form
var aspForm = document.getElementById("departmentForm");
// 取得 select
var selectTags = document.querySelector("select"); 

// 新增
addButton.onclick = function () {
    addButton.setAttribute("disabled", "disabled");
    editButton.setAttribute("disabled", "disabled");
    deleteButton.setAttribute("disabled", "disabled");
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");
    cancelButton.removeAttribute("disabled");
    submitButton.removeAttribute("disabled");

    for (var i = 0; i < inputTags.length; i++) {
        inputTags[i].removeAttribute("disabled");
        inputTags[i].value = "";
    }
    selectTags.removeAttribute("disabled");
    inputHiddenTag.value = 0;

    // 變更 asp-action
    aspForm.setAttribute("action", "/Administrator/Function/Create");
}

// 修改
editButton.onclick = function () {
    addButton.setAttribute("disabled", "disabled");
    editButton.setAttribute("disabled", "disabled");
    deleteButton.setAttribute("disabled", "disabled");
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");
    cancelButton.removeAttribute("disabled");
    submitButton.removeAttribute("disabled");

    for (var i = 0; i < inputTags.length; i++) {
        inputTags[i].removeAttribute("disabled");
    }

    selectTags.removeAttribute("disabled");

    aspForm.setAttribute("action", "/Administrator/Function/Edit");
}

// 刪除
deleteButton.onclick = function () {
    const id = inputHiddenTag.value;
    aspForm.setAttribute("action", "/Administrator/Function/Delete/" + id);
}

// 取消
cancelButton.onclick = function () {
    window.location.href = '/Administrator/Function/Index';
}

// DataTable
var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    // DataTable
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Administrator/Function/GetAll'
        },
        "columns": [
            {
                data: null,
                "render": function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: 'functionName' },
            { data: 'functionChineseName' },
            { data:'group' },
            {
                data: 'functionId',
                "render": function (data) {
                    return `<a href="/Administrator/Function/Index/${data}" onclick="selectItem()">選擇</a>`
                }
            }
        ]
    })
}