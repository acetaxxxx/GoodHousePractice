$(function ()
{
    $('#btnAdd').click(function ()
    {
        $.ajax({
            url: 'http://localhost:53262/Customer/Detail',
            method: 'POST',
            async: true,
            data: '',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            dataType: 'html',
            success: function (data)
            {
                $('#divDetail').html(data);
            },
            error: function (xhr, status, err)
            {
            }
        });
        $('#divDetail').modal('show');
    });
});