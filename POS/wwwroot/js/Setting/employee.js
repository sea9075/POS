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
        "pageLength": 50,
        "columns": [
            {
                data: null,
                "render": function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: 'name' },
            { data: 'phone' },
            { data: 'cellphone' },
            {
                data: 'employeeId',
                "render": function (data) {
                    return `<a href="/Setting/Employee/Index/${data}">選擇</a>`
                }
            }
        ]
    })
}

// 取得 inputId
var inputId = document.getElementById("inputId");

// 取得所有 input (不包含 type = "hidden"、"checkbox" 和 "date")
var inputTags = document.querySelectorAll("input:not([type='hidden']):not([type='checkbox'])");

// 取得 checkbox
var checkboxTag = document.querySelector("input[type='checkbox']");

// 取得 date
var dateTags = document.querySelectorAll("input[type='date']");

// 取得 select
var selectTag = document.querySelector("select");

// 取得 textarea
var textareaTag = document.querySelector("textarea");

// 取得 img
var imgTag = document.querySelector("img");

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

    // 清除 checkbox 的 disabled 和 checked 屬性
    checkboxTag.removeAttribute("disabled");
    checkboxTag.checked = false;

    // 清除 select 的 disabled 和選項
    selectTag.removeAttribute("disabled");
    if (selectTag.selectedOptions[0].textContent !== "請選擇性別") {
        var defaultOption = document.createElement("option");
        defaultOption.textContent = "請選擇群組";
        defaultOption.disabled = true;
        defaultOption.selected = true;
        selectTag.insertBefore(defaultOption, selectTag.firstChild);
    }

    // 清除 textarea 的 disabled 和內容
    textareaTag.removeAttribute("disabled");
    textareaTag.value = "";

    // 移除 img
    if (imgTag != null) {
        imgTag.remove();
    }
    

    // 設定 input 的 Id 為 0
    inputId.value = 0;

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/Employee/Create");

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

    // 清除 checkbox 的 disabled 屬性
    checkboxTag.removeAttribute("disabled");

    // 清除 select 的 disabled 屬性
    selectTag.removeAttribute("disabled");

    // 清除 textarea 的 disabled 屬性
    textareaTag.removeAttribute("disabled");

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/Employee/Edit");

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

// 取消
function Cancel() {
    window.location.href = "/Setting/Employee/Index";
}

function DeleteApi(url) {
    Swal.fire({
        title: "你確定要刪除嗎",
        text: "刪除過後資料將無法復原",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "是",
        cancelButtonText: "否"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    window.location.href = "/Setting/Employee/Index";
                }
            });
        }
    });
}


function Delete(id) {
    url = `/Setting/Employee/Delete/${id}`;
    DeleteApi(url)
}