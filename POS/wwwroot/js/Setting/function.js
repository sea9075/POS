// DataTable
var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    // DataTable
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Administrator/Function/GetAll'
        },
        "columns": [
            {
                data: null,
                "render": function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            { data: 'functionName' },
            { data: 'functionChineseName' },
            { data:'group' },
            {
                data: 'functionId',
                "render": function (data) {
                    return `<a href="/Administrator/Function/Index/${data}" onclick="selectItem()">選擇</a>`
                }
            }
        ]
    })
}