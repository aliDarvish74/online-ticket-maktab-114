// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function createProvinceWithAjax(e) {
    let provinceName = $("#provinceName").val();
    let data = { name: provinceName };
    if (e.keyCode == 13 || e.type == "click") {
        e.preventDefault();
        $.ajax({
            type: 'Post',
            url: '/Home/InsertProvince',
            contentType: 'application/json',
            data: JSON.stringify(data),
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
