
function autoField() {

    let getPrice = document.getElementById("price");

    $(document).ready(function () {
        $("#first").last().autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "/Product/AllProduct",
                    type: "POST",
                    dataType: "json",
                    data: { term: request.term },
                    success: function (data) {
                        response($.map(data, function (item) {

                            getPrice.value = item["salePrice"];

                            return item["name"];
                        }))

                    }
                })
            },
            Messages: {
                noResults: "", results: ""
            }
        });
    });
}