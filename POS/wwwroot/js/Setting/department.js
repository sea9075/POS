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

    inputHiddenTag.value = 0;

    // 變更 asp-action
    aspForm.setAttribute("action", "/Setting/Department/Create");
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

    for (var i = 0; i < selectTags.length; i++) {
        selectTags[i].removeAttribute("disabled");
    }

    aspForm.setAttribute("action", "/Setting/Department/Edit");
}

// 刪除
deleteButton.onclick = function () {
    const id = inputHiddenTag.value;
    aspForm.setAttribute("action", "/Setting/Department/Delete/" + id);
}

// 取消
cancelButton.onclick = function () {
    window.location.href = '/Setting/Department/Index';
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
            url: '/Setting/Department/GetAll'
        },
        "columns": [
            {
                data: null,
                "render": function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: 'shortName' },
            {data:'name'},
            { data: 'phone' },
            { data: 'ext' },
            { data: 'fax' },
            {
                data: 'departmentId',
                "render": function (data) {
                    return `<a href="/Setting/Department/Index/${data}" onclick="selectItem()">選擇</a>`
                }
            }
        ]
    })
}