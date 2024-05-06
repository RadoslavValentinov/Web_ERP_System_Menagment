$(document).ready(function () {
    $("#first").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Home/GetRecord",
                type: "POST",
                dataType: "json",
                data: { prefix: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return console.log(item);
                    }))
                }
            })
        },
    });
});
