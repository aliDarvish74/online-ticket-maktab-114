$(document).ready(function () {
    console.log("jQuery is working and document is ready!");

    $(document).on("click", "#pagination a", function (e) {
        e.preventDefault();
        var page = $(this).data("page");
        console.log("Pagination link clicked. Page:", page);
        searchProvincesWithPagination(page);
    });
});

function searchProvincesWithPagination(pageIndex) {
    console.log("searchProvincesWithPagination triggered with pageIndex:", pageIndex);
    let searchValue = $("#searchBox").val();

    $.ajax({
        type: 'GET',
        url: '/Home/ListOfProvincesWithPagination',
        data: { pageIndex: pageIndex, searchName: searchValue },
        success: function (data) {
            console.log("AJAX request successful.");
            var newContent = $(data).find('#data-container').html();
            $("#data-container").html(newContent);
        },
        error: function (error) {
            console.error("AJAX request failed: ", error);
            ShowMessage('', 'internal server error', '');
        }
    });
}

function searchReset() {
    $("#searchBox").val('');
    searchProvincesWithPagination(1);
}

function createProvinceWithAjax(e) {
    let provinceName = $("#provinceName").val();
    let provincePic = $("#provinceFile");

    var form = new FormData();
    let data = { name: provinceName, provinceFile: provincePic[0].files[0] };
    form.append('name', data.name);
    form.append('ProvinceFile', data.provinceFile);

    if (e.keyCode == 13 || e.type == "click") {
        e.preventDefault();
        $.ajax({
            type: 'POST',
            url: '/Home/InsertProvince',
            data: form,
            contentType: false, // Necessary for file uploads
            processData: false, // Prevents jQuery from converting data into a query string
            success: function (response) {
                if (response) {
                    if (response.name) {
                        ShowMessage('Success', "درج استان با موفقیت انجام شد", 'success');
                    } else {
                        ShowMessage('Error', response.errorMessages[0], 'error');
                    }
                } else {
                    ShowMessage('Error', 'Internal server error', 'error');
                }
            },
            error: function (err) {
                console.log(err);
                alert('Internal server error');
            }
        });
    }
}

function ShowMessage(title, text, theme) {
    alert(text);
}
