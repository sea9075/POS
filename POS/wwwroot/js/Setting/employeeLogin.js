// DataTable
var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    // DataTable
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Setting/EmployeeLogin/GetAll'
        },
        "pageLength": 50,
        "columns": [
            {
                data: null,
                "render": function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: 'employee.employeeId' },
            { data: 'employee.name' },
            { data: 'department.shortName' },
            { data: 'department.name' },
            { data: 'role.shortName' },
            { data: 'role.name' },
            { data: 'account' },
            {
                data: 'employeeLoginId',
                "render": function (data) {
                    return `<a href="/Setting/EmployeeLogin/Index/${data}">選擇</a>`
                }
            }
        ]
    })
}

// 取得 inputId
var inputId = document.getElementById("inputId");

// 取得所有 input (不包含 type = "hidden")
var inputTags = document.querySelectorAll("input:not([type='hidden'])");

// 取得所有 select
var selectTags = document.querySelectorAll("select");

// 取得 textarea
var textareaTag = document.querySelector("textarea");

// 取得 form
var aspForm = document.querySelector("form");

// 取得所有按鈕
var createButton = document.getElementById("createButton");
var editButton = document.getElementById("editButton");
var deleteButton = document.getElementById("deleteButton");
var cancelButton = document.getElementById("cancelButton");
var searchButton = document.getElementById("searchButton");
var printButton = document.getElementById("printButton");
var submitButton = document.getElementById("submitButton");

// 新增
function Create() {
    // 清除 input 的 disabled 屬性和內容
    for (var i = 0; i < inputTags.length; i++) {
        inputTags[i].removeAttribute("disabled");
        inputTags[i].value = "";
    }

    // 清除 select 的 disabled 和選項
    for (var i = 0; i < selectTags.length; i++) {
        selectTags[i].removeAttribute("disabled");
        if (i == 0 && selectTags[i].selectedOptions[0].textContent !== "請選擇員工") {
            var defaultOption = document.createElement("option");
            defaultOption.textContent = "請選擇員工";
            defaultOption.disabled = true;
            defaultOption.selected = true;
            selectTags[i].insertBefore(defaultOption, selectTags[i].firstChild);
        }
        if (i == 1 && selectTags[i].selectedOptions[0].textContent !== "請選擇部門") {
            var defaultOption = document.createElement("option");
            defaultOption.textContent = "請選擇部門";
            defaultOption.disabled = true;
            defaultOption.selected = true;
            selectTags[i].insertBefore(defaultOption, selectTags[i].firstChild);
        }
        if (i == 2 && selectTags[i].selectedOptions[0].textContent !== "請選擇群組") {
            var defaultOption = document.createElement("option");
            defaultOption.textContent = "請選擇群組";
            defaultOption.disabled = true;
            defaultOption.selected = true;
            selectTags[i].insertBefore(defaultOption, selectTags[i].firstChild);
        }
    }

    // 清除 textarea 的 disabled和內容
    textareaTag.removeAttribute("disabled");
    textareaTag.value = "";

    // 設定 input 的 Id 為 0
    inputId.value = 0;

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/EmployeeLogin/Create");

    // 增加 disabled
    createButton.setAttribute("disabled", "disabled");
    editButton.setAttribute("disabled", "disabled");
    deleteButton.setAttribute("disabled", "disabled");
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 移除 disabled
    cancelButton.removeAttribute("disabled");
    submitButton.removeAttribute("disabled");
}

// 如果有選擇資料時
if (inputId.value != 0) {
    editButton.removeAttribute("disabled");
    deleteButton.removeAttribute("disabled");
}

// 修改
function Edit() {
    // 清除 input 的 disabled 屬性
    for (var i = 0; i < inputTags.length; i++) {
        inputTags[i].removeAttribute("disabled");
    }

    // 清除 select 的 disabled
    for (var i = 0; i < selectTags.length; i++) {
        selectTags[i].removeAttribute("disabled");
    }

    // 清除 textarea 的 disabled和內容
    textareaTag.removeAttribute("disabled");

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/EmployeeLogin/Edit");

    // 增加 disabled
    createButton.setAttribute("disabled", "disabled");
    editButton.setAttribute("disabled", "disabled");
    deleteButton.setAttribute("disabled", "disabled");
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 移除 disabled
    cancelButton.removeAttribute("disabled");
    submitButton.removeAttribute("disabled");
}