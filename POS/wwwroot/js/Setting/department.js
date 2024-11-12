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

// 取得所有的 input
var inputTags = document.querySelectorAll("input");

// 取得所有 textarea
var textareaTag = document.querySelector("textarea");

// 取得 from
var aspForm = document.getElementById("departmentForm");

// 取得 StockId
var inputId = document.getElementById("InputId");

// 取得新增、刪除、取消、查詢、列印和存檔的按鈕
var createButton = document.getElementById("createButton");
var deleteButton = document.getElementById("deleteButton");
var cancelButton = document.getElementById("cancelButton");
var searchButton = document.getElementById("searchButton");
var printButton = document.getElementById("printButton");
var submitButton = document.getElementById("submitButton");

// 新增
function add() {
    // 取消 disabled
    // 清空資料
    for (var i = 0; i < inputTags.length; i++) {
        inputTags[i].removeAttribute("disabled");
        inputTags[i].value = "";
    }

    textareaTag.removeAttribute("disabled");
    textareaTag.value = "";

    // 取消 submit 和 cancel 的 disabled
    submitButton.removeAttribute("disabled");
    cancelButton.removeAttribute("disabled");
    // 增加 search 和 print 的 disabled
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 設定 StockId 為 0
    inputId.value = 0;

    // 設定 asp-action
    aspForm.setAttribute("action", "/Setting/Department/Create");
}

// 取消
function cancel() {
    window.location.href = "/Setting/Department/Index";
}

// 修改
function edit() {
    // 取消 disabled
    for (var i = 0; i < inputTags.length; i++) {
        inputTags[i].removeAttribute("disabled");
    }

    textareaTag.removeAttribute("disabled");

    // 取消 submit 和 cancel 的 disabled
    submitButton.removeAttribute("disabled");
    cancelButton.removeAttribute("disabled");
    // 增加 create、delete、search 和 print 的 disabled
    createButton.setAttribute("disabled", "disabled");
    deleteButton.setAttribute("disabled", "disabled");
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 設定 asp-action
    aspForm.setAttribute("action", "/Setting/Department/Edit");
}

// 刪除
function deleteClick(id) {
    aspForm.setAttribute("action", "/Setting/Department/Delete/" + id);
}