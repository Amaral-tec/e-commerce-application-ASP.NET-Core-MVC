var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/user/getall' },
        "columns": [
            { data: 'name', "width": "20%" },
            { data: 'email', "width": "20%" },
            { data: 'phoneNumber', "width": "10%" },
            { data: 'company.name', "width": "20%" },
            { data: 'role', "width": "10%" },
            {
                data: { id: "id", lockoutEnd: "lockoutEnd" },
                "render": function (data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();

                    if (lockout > today) {
                        return `
                        <div class="text-end text-nowrap">
                             <a onclick=LockUnlock('${data.id}') class="btn btn-danger btn-sm ms-1 text-white" style="cursor:pointer; width:100px;">
                                    <i class="bi bi-lock-fill"></i> Lock
                                </a> 
                                <a href="/admin/user/RoleManagment?userId=${data.id}" class="btn btn-danger btn-sm ms-1 text-white" style="cursor:pointer; width:150px;">
                                     <i class="bi bi-pencil-square"></i> Permission
                                </a>
                        </div>
                    `
                    }
                    else {
                        return `
                        <div class="text-end text-nowrap">
                              <a onclick=LockUnlock('${data.id}') class="btn btn-success btn-sm ms-1 text-white" style="cursor:pointer; width:100px;">
                                    <i class="bi bi-unlock-fill"></i> UnLock
                                </a>
                                <a href="/admin/user/RoleManagment?userId=${data.id}" class="btn btn-danger btn-sm ms-1 text-white" style="cursor:pointer; width:150px;">
                                     <i class="bi bi-pencil-square"></i> Permission
                                </a>
                        </div>
                    `
                    }
                },
                "width": "20%"
            }
        ],
        "responsive": true,
        "autoWidth": false
    });
}

function LockUnlock(id) {
    $.ajax({
        type: "POST",
        url: '/Admin/User/LockUnlock',
        data: JSON.stringify(id),
        contentType: "application/json",
        success: function (data) {
            if (data.success) {
                toastr.success(data.message);
                dataTable.ajax.reload();
            }
        }
    });
}

