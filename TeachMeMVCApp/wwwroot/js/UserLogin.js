$(function () {
    var userLoginButton = $("#UserLoginModal button[name='login']").click(onUserLoginClick);

    function onUserLoginClick() {

        var url = "UserAuth/Login";

        var antiForgeryToken = $("#UserLoginModal input[name='__RequestVerificationToken']").val();

        var email = $("#UserLoginModal input[name='Email']").val();
        var password = $("#UserLoginModal input[name='Password']").val();
        var rememberMe = $("#UserLoginModal input[name='RememberMe']").prop('checked');

        var userInput = {
            __RequestVerificationToken: antiForgeryToken,
            Email: email,
            Password: password,
            RememberMe: rememberMe
        };

        $.ajax({
            type: "POST",
            url: url,
            data: userInput,
            success: function (data) {

                var parsed = $.parseHTML(data);

                var hasErrors = $(parsed).find("input[name='LoginInValid']").val() == "true";

                if (hasErrors == true) {
                    $("#UserLoginModal").html(data);

                    userLoginButton = $("#UserLoginModal button[name='logn']").click(onUserLoginClick);
                }
                else {
                    location.href = 'Home/Index';

                }

            },
            error: function (xhr, ajaxOptions, throwError) {
                console.log(throwError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
            }
        });

    }

});