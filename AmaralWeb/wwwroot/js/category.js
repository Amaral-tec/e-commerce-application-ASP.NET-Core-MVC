var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/category/getall' },
        "columns": [
            { data: 'name', "width": "30%" },
            { data: 'description', "width": "50%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="text-end text-nowrap">
                        <a href="/admin/category/upsert?id=${data}" class="btn btn-primary btn-sm ms-1">
                            <i class="bi bi-pencil-square"></i><span class="action-text"> Edit</span>
                        </a>               
                        <a onClick=Delete('/admin/category/delete/${data}') class="btn btn-danger btn-sm ms-1"> 
                            <i class="bi bi-trash-fill"></i><span class="action-text"> Delete</span>
                        </a>
                    </div>`;
                },
                "width": "20%"
            }
        ],
        "responsive": true,
        "autoWidth": false
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}
