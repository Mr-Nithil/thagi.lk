var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax" : { url : '/admin/product/getall'},
        "columns" : [
            { data: 'productName', "width" :"30%" },
            { data: 'price', "width": "20%" },
            { data: 'category.categoryName', "width": "30%" },
            {
                data: 'productId',
                "render": function (data) {
                    return `<div class="d-flex justify-content-center">
                    <div class="w-75 btn-group" role="group">
                        <a href="/admin/product/upsert/?id=${data}" class="btn btn-dark btn-sm mx-2 rounded" > <i class="bi bi-pencil-fill"></i> Edit </a >
                        <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger btn-sm mx-2 rounded"><i class="bi bi-trash3-fill"></i> Delete</a>
                            </div > </div>`
                },
                "width": "20%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    if (result.isConfirmed) {
                        Swal.fire(
                            'Deleted!',
                            'Your file has been deleted.',
                            'success'
                        )
                    }
                }
            })
        }
    })
}