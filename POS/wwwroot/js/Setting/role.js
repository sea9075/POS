// DataTable
var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    // DataTable
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Setting/Role/GetAll'
        },
        "columns": [
            {
                data: null,
                "render": function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: 'shortName' },
            { data: 'name'},
            {
                data: 'canRead',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'canCreate',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'canEdit',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'canDelete',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'canPrint',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'canAudit',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'canReview',
                "render": function (data) {
                    return data ? '是' : '否';
                }
            },
            {
                data: 'roleId',
                "render": function (data) {
                    return `<a href="/Setting/Role/Index/${data}">選擇</a>`
                }
            }
        ]
    })
}

// 取得 inputId
var inputId = document.getElementById("inputId");

// 取得所有 input (不包含 type = "hidden" and "checkbox")
var inputTags = document.querySelectorAll("input:not([type='hidden']):not([type='checkbox'])");

// 取得所有 checkbox
var checkboxTags = document.querySelectorAll("input[type='checkbox']");

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

    // 清除 checkbox 的 disabled 和 checked 屬性
    for (var i = 0; i < checkboxTags.length; i++) {
        checkboxTags[i].removeAttribute("disabled");
        checkboxTags[i].checked = false;
    }

    // 清除 textarea 的 disabled 屬性和內容
    textareaTag.removeAttribute("disabled");
    textareaTag.value = "";

    // 設定 input 的 Id 為 0
    inputId.value = 0;

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/Role/Create");

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

    // 清除 checkbox 的 disabled
    for (var i = 0; i < checkboxTags.length; i++) {
        checkboxTags[i].removeAttribute("disabled");
    }

    // 清除 textarea 的 disabled 屬性
    textareaTag.removeAttribute("disabled");

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/Role/Edit");

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
    window.location.href = "/Setting/Role/Index";
}

// 刪除
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
                    window.location.href = "/Setting/Role/Index";
                }
            });
        }
    });
}


function Delete(id) {
    url = `/Setting/Role/Delete/${id}`;
    DeleteApi(url)
}