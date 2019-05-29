$(document).ready(function () {

    $("#upload").on("change", function () {
        var file = this.files[0],
            fileName = file.name;
        var name = fileName.replace(/\.[^.]+$/, "");

        $('#inp_name').val(name);
    });

    $('#inp_about').focusin(function () {
        $('.lbl-about').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('.lbl-about').next().addClass('move-pen');
        }, 100);
    });

    $('#inp_about').focusout(function () {
        $('.lbl-about').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp_name').focusin(function () {
        $('.lbl-name').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('.lbl-name').next().addClass('move-pen');
        }, 100);
    });

    $('#inp_name').focusout(function () {
        $('.lbl-name').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-login-email').focusin(function () {
        $('#lbl-login-email').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-login-email').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-login-email').focusout(function () {
        $('#lbl-login-email').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-login-pass').focusin(function () {
        $('#lbl-login-pass').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-login-pass').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-login-pass').focusout(function () {
        $('#lbl-login-pass').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-reg-email').focusin(function () {
        $('#lbl-reg-email').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-reg-email').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-reg-email').focusout(function () {
        $('#lbl-reg-email').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-reg-pass').focusin(function () {
        $('#lbl-reg-pass').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-reg-pass').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-reg-pass').focusout(function () {
        $('#lbl-reg-pass').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-reg-confirmpass').focusin(function () {
        $('#lbl-reg-confirmpass').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-reg-confirmpass').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-reg-confirmpass').focusout(function () {
        $('#lbl-reg-confirmpass').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-edituser-email').focusin(function () {
        $('#lbl-edituser-email').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-edituser-email').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-edituser-email').focusout(function () {
        $('#lbl-edituser-email').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-edituser-pass').focusin(function () {
        $('#lbl-edituser-pass').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-edituser-pass').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-edituser-pass').focusout(function () {
        $('#lbl-edituser-pass').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-createuser-email').focusin(function () {
        $('#lbl-createuser-email').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-createuser-email').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-createuser-email').focusout(function () {
        $('#lbl-createuser-email').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });

    $('#inp-createuser-pass').focusin(function () {
        $('#lbl-createuser-pass').transition({ x: '80px' }, 500, 'ease').next()
            .transition({ x: '5px' }, 500, 'ease');
        setTimeout(function () {
            $('#lbl-createuser-pass').next().addClass('move-pen');
        }, 100);
    });

    $('#inp-createuser-pass').focusout(function () {
        $('#lbl-createuser-pass').transition({ x: '0px' }, 500, 'ease').next()
            .transition({ x: '-100px' }, 500, 'ease').removeClass('move-pen');
    });
});

