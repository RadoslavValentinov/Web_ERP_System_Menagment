
function resultSum() {

    let getQuantity = document.getElementById("quantity");
    let getPrice = document.getElementById("price");
    let getSum = document.getElementById("Sum");

    getSum.value = Number(getQuantity.value * getPrice.value);

}