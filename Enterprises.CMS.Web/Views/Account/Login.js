﻿(function () {

    $(function() {
        $('#LoginButton').click(function (e) {
            e.preventDefault();
            abp.ui.setBusy(
                $('#loginform'),
                abp.ajax({
                    url: $('#loginform').attr("action"),
                    type: 'POST',
                    data: JSON.stringify({
                        tenancyName: "",
                        usernameOrEmailAddress: $('#EmailAddressInput').val(),
                        password: $('#PasswordInput').val(),
                        rememberMe: true
                    })
                })
            );
        });
    });

})();