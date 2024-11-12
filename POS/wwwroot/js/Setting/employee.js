// DataTable
var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    // DataTable
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Setting/Employee/GetAll'
        },
        "pageLength" : 50,
        "columns": [
            {
                data: null,
                "render": function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: 'name' },
            {
                data: 'group',
                "render": function (data) {
                    return EmployeeGroup[data];
                }
            },
            { data: 'phone' },
            { data: 'fax' },
            { data: 'address' },
            {
                data: 'isShowFront',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'isShowHeadquarters',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'stockId',
                "render": function (data) {
                    return `<a href="/Setting/Employee/Index/${data}" onclick="selectItem()">選擇</a>`
                }
            }
        ]
    })
}

// 取得所有的 input，不包含 Checkbox
var inputTags = document.querySelectorAll("input:not([type='checkbox']):not([type='hidden'])");

// 取得所有的 checkbox
var checkboxTags = document.querySelectorAll("input[type='checkbox']");

// 取得所有的 select 
var selectTags = document.querySelectorAll("select");

// 取得 from
var aspForm = document.getElementById("stockForm");

// 取得 EmployeeId
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

    for (var i = 0; i < checkboxTags.length; i++) {
        checkboxTags[i].removeAttribute("disabled");
        checkboxTags[i].checked = false;
    }

    for (var i = 0; i < selectTags.length; i++) {
        selectTags[i].removeAttribute("disabled");
    }

    // 取消 submit 和 cancel 的 disabled
    submitButton.removeAttribute("disabled");
    cancelButton.removeAttribute("disabled");
    // 增加 search 和 print 的 disabled
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 設定 EmployeeId 為 0
    inputId.value = 0;

    // 設定 asp-action
    aspForm.setAttribute("action", "/Setting/Employee/Create");
}

// 取消
function cancel() {
    window.location.href = "/Setting/Employee/Index";
}

// 修改
function edit() {
    // 取消 disabled
    for (var i = 0; i < inputTags.length; i++) {
        inputTags[i].removeAttribute("disabled");
    }

    for (var i = 0; i < checkboxTags.length; i++) {
        checkboxTags[i].removeAttribute("disabled");
    }

    for (var i = 0; i < selectTags.length; i++) {
        selectTags[i].removeAttribute("disabled");
    }

    // 取消 submit 和 cancel 的 disabled
    submitButton.removeAttribute("disabled");
    cancelButton.removeAttribute("disabled");
    // 增加 create、delete、search 和 print 的 disabled
    createButton.setAttribute("disabled", "disabled");
    deleteButton.setAttribute("disabled", "disabled");
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 設定 asp-action
    aspForm.setAttribute("action", "/Setting/Employee/Edit");
}

// 刪除
function deleteClick(id) {
    aspForm.setAttribute("action", "/Setting/Employee/Delete/" + id);
}