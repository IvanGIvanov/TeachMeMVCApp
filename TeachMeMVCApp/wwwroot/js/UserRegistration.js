console.log("hiii")

$(function () {
    var registerUserButton = $("#UserRegisterModal button[name = 'register']").click(onUserRegisterClick);
    console.log("there");
    function onUserRegisterClick()
    {
        console.log("go ahead");
        var url = "/UserAuth/RegisterUser";
        console.log("there");
        var antiForgeryToken = $("#UserRegisterModal input[name='__RequestVerificationToken']").val();
        var email = $("#UserRegisterModal input[name='Email']").val();
        var password = $("#UserRegisterModal input[name='Password']").val();
        var confirmPassword = $("#UserRegisterModal input[name='ConfirmPassword']").val();
        var firstName = $("#UserRegisterModal input[name='FirstName']").val();
        var lastName = $("#UserRegisterModal input[name='LastName']").val();
        var address = $("#UserRegisterModal input[name='Address']").val();
        var postCode = $("#UserRegisterModal input[name='PostCode']").val();
        var phoneNumber = $("#UserRegisterModal input[name='PhoneNumber']").val();
        
        var user = {
            __RequestAntiForgeryToken: antiForgeryToken,
            Email: email,
            Password: password,
            ConfirmPassword: confirmPassword,
            FirstName: firstName,
            LastName: lastName,
            Address: address,
            PostCode: postCode,
            PhoneNumber: phoneNumber,
            AcceptUserAgreement: true,
        };
        console.log("are we here?");
        //console.log(user);
        $.ajax({
            type: "POST",
            url: url,
            data: user,
            success: function (data) {
                var parsed = $.parseHTML(data);
                console.log(parsed);
                var hasErrors = $(parsed).find("input[name='RegistrationInValid']").val() == 'true';
                console.log(hasErrors);
                if (hasErrors) {
                    $("#UserRegisterModal").html(data);
                    var registerUserButton = $("#UserRegisterModal button[name = 'register']").click(onUserRegisterClick);

                    $("#UserRegistrationForm").removeData("validator");
                    $("#UserRegistrationForm").removeData("unobtrusiveValidation");
                    $.validator.unobtrusive.parse("#UserRegistrationForm");
                }

                else {
                    location.href = '/Home/Index';
                }
            },

            error: function (xhr, ajaxOptions, thrownError) {
                console.error(thrownError + '\r\n' + xhr.statusText + '\r\n' + xhr.responseText);
            }
        });

    }
});