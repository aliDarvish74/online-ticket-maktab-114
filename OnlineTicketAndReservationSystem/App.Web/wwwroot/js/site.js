// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


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
            type: 'Post',
            url: '/Home/InsertProvince',
            data: form,
            contentType: false, // Necessary for file uploads
            processData: false, // Prevents jQuery from converting data into a query string
            success: function (response) {
                if (response) {
                    if (response.name) {
                        ShowMessage('Success', "درج استان با موفقیت انجام شد", 'success');
                    }
                    else {
                        ShowMessage('Error', response.errorMessages[0], 'error');
                    }
                }
                else {
                    ShowMessage('Error', 'Internal server error', 'error');
                }
            },
            error: function (err) {
                console.log(err);
                alert('internal server error');
            }
        })
    }
}

function ShowMessage(title, text, theme) {
    //window.createNotification({
    //    closeOnClick: true,
    //    displayCloseButton: false,
    //    positionClass: 'nfc-top-right',
    //    showDuration: 3000,
    //    theme: theme !== '' ? theme : 'success'
    //})({
    //    title: title !== '' ? title : 'اعلان',
    //    message: decodeURI(text)
    //});

    alert(text);
}
