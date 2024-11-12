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
                    return `<a href="/Setting/Role/Index/${data}" onclick="selectItem()">選擇</a>`
                }
            }
        ]
    })
}