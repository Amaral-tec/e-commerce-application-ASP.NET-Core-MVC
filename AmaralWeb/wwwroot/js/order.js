var dataTable;

$(document).ready(function () {
    var url = window.location.search;
    var status = "all";

    if (url.includes("inprocess")) {
        status = "inprocess";
    } else if (url.includes("completed")) {
        status = "completed";
    } else if (url.includes("pending")) {
        status = "pending";
    } else if (url.includes("approved")) {
        status = "approved";
    }

    loadDataTable(status);
});


function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/order/getall' },
        "columns": [
            { data: 'id', "width": "5%" },
            { data: 'name', "width": "25%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'applicationUser.email', "width": "20%" },
            { data: 'orderStatus', "width": "15%" },
            {
                data: 'orderTotal',
                "width": "10%",
                "render": function (data) {
                    return data.toLocaleString('en-US', { style: 'currency', currency: 'USD' });
                } },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="text-end">
                     <a href="/admin/order/details?orderId=${data}" class="btn btn-primary btn-sm ms-1"> <i class="bi bi-pencil-square"></i><span class="action-text"> Edit</span></a>             
                    </div>`
                },
                "width": "10%"
            }
        ],
        "responsive": true,
        "autoWidth": false,
        "columnDefs": [
            { "targets": "_all", "className": "dt-responsive" }
        ]
    });
}