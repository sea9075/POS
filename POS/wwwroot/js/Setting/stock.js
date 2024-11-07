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
// 取得 select
var selectTags = document.querySelectorAll("select");
// 取得隱藏的 input
var inputHiddenTag = document.getElementById("ModelId");
// 取得 form
var aspForm = document.getElementById("stockForm");

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
        // 跳過 checkbox
        if (i === 1 || i === 2) {
            inputTags[i].setAttribute("checked", "checked")
        } else {
            inputTags[i].value = "";
        }
    }

    for (var i = 0; i < selectTags.length; i++) {
        selectTags[i].removeAttribute("disabled");
    }

    inputHiddenTag.value = 0;

    // 變更 asp-action
    aspForm.setAttribute("action", "/Setting/Stock/Create");
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

    aspForm.setAttribute("action", "/Setting/Stock/Edit");
}

// 刪除
deleteButton.onclick = function () {
    const id = inputHiddenTag.value;
    aspForm.setAttribute("action", "/Setting/Stock/Delete/" + id);
}

// 取消
cancelButton.onclick = function () {
    window.location.href = '/Setting/Stock/Index';
}

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