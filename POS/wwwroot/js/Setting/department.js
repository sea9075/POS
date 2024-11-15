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
                    return `<a href="/Setting/Department/Index/${data}">選擇</a>`
                }
            }
        ]
    })
}

// 取得 inputId
var inputId = document.getElementById("inputId");

// 取得所有的 input
var inputTags = document.querySelectorAll("input:not([type='hidden'])");

// 取得 textarea
var textareTag = document.querySelector("textarea");

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

    // 設定 input 的 Id 為 0
    inputId.value = 0;

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/Department/Create");

    // 清除 textarea 的 disabled 屬性和內容
    textareTag.removeAttribute("disabled");
    textareTag.textContent = "";

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

    // 清除 textarea 的 disabled 屬性
    textareTag.removeAttribute("disabled");

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/Department/Edit");

    // 增加 disabled
    createButton.setAttribute("disabled", "disabled");
    editButton.setAttribute("disabled", "disabled");
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 移除 disabled
    cancelButton.removeAttribute("disabled");
    submitButton.removeAttribute("disabled");
}

// 取消
function Cancel() {
    window.location.href = "/Setting/Department/Index";
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
                    window.location.href = "/Setting/Department/Index";
                }
            });
        }
    });
}


function Delete(id) {
    url = `/Setting/Department/Delete/${id}`;
    DeleteApi(url)
}