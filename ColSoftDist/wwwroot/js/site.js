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
});

