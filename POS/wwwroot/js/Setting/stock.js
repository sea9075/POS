// DataTable
var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    // 定義 Enum
    const StockGroup = {
        0: '未分類群組',
        1: '倉庫群組1',
        2: '倉庫群組2',
        3: '倉庫群組3',
        4: '倉庫群組4',
        5: '倉庫群組5',
        6: '倉庫群組6',
        7: '倉庫群組7',
        8: '倉庫群組8',
        9: '倉庫群組9',
        10: '倉庫群組10'
    };

    // DataTable
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Setting/Stock/GetAll'
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
            {
                data: 'group',
                "render": function (data) {
                    return StockGroup[data];
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
                    return `<a href="/Setting/Stock/Index/${data}" onclick="selectItem()">選擇</a>`
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

// 取得所有 select
var selectTags = document.querySelectorAll("select");
// 增加 selectTags 的預設選項
if (inputId.value == 0) {
    for (var i = 0; i < selectTags.length; i++) {
        if (i == 0) {
            var defaultOption = document.createElement("option");
            defaultOption.textContent = "請選擇群組";
            defaultOption.disabled = true;
            defaultOption.selected = true;
        } else {
            var defaultOption = document.createElement("option");
            defaultOption.textContent = "請選擇店點";
            defaultOption.disabled = true;
            defaultOption.selected = true;
        }
        selectTags[i].insertBefore(defaultOption, selectTags[i].firstChild);
    }
}

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

    // 清除 select 的 disabled 和選項
    for (var i = 0; i < selectTags.length; i++) {
        selectTags[i].removeAttribute("disabled");
    }

    // 設定 input 的 Id 為 0
    inputId.value = 0;

    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/Stock/Create");

    // 增加 disabled
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 移除 disabled
    cancelButton.removeAttribute("disabled");
    submitButton.removeAttribute("disabled");
}

// 如果有選擇倉庫時
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

    // 清除 select 的 disabled
    for (var i = 0; i < selectTags.length; i++) {
        selectTags[i].removeAttribute("disabled");
    }


    // 設定 form 的 controller
    aspForm.setAttribute("action", "/Setting/Stock/Edit");

    // 增加 disabled
    createButton.setAttribute("disabled", "disabled");
    editButton.setAttribute("disabled", "disabled");
    searchButton.setAttribute("disabled", "disabled");
    printButton.setAttribute("disabled", "disabled");

    // 移除 disabled
    cancelButton.removeAttribute("disabled");
    submitButton.removeAttribute("disabled");
}

// 刪除
function Delete(stockId) {
    const url = `/Setting/Stock/Delete/${stockId}`;
    Swal.fire({
        title: "確定要刪除嗎?",
        text: "刪除後將無法恢復!",
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
                success: function (response) {
                    if (response.success) {
                        toastr.success(response.message);
                        window.location.href = "/Setting/Stock/Index";
                    } else {
                        toastr.error(response.message);
                        window.location.href = "/Setting/Stock/Index";
                    }
                },
                error: function () {
                    toastr.error("刪除失敗");
                }
            });
        }
    });
}

// 取消
function cancel() {
    window.location.href = "/Setting/Stock/Index";
}