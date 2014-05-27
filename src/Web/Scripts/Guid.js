$(function () {
    $.get('/api/guid/empty', function (data) {
        $('#empty_n').val(data.n);
        $('#empty_d').val(data.d);
        $('#empty_b').val(data.b);
        $('#empty_p').val(data.p);
    });

    $('#generate_new').click(function () {
        $.get('/api/guid/new', function (data) {
            $('#generated_n').val(data.n);
            $('#generated_d').val(data.d);
            $('#generated_b').val(data.b);
            $('#generated_p').val(data.p);
        });
    });

    $('#generate_upper_new').click(function () {
        $.get('/api/guid/new-upper', function (data) {
            $('#generated_upper_n').val(data.n);
            $('#generated_upper_d').val(data.d);
            $('#generated_upper_b').val(data.b);
            $('#generated_upper_p').val(data.p);
        });
    });

    $('#generate_new').click();
    $('#generate_upper_new').click();
});