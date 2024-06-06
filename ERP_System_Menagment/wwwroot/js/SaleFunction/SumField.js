
function resultSum() {

    let getQuantity = document.getElementById("quantity");
    let getPrice = document.getElementById("price");
    let getSum = document.getElementById("Sum");
    let Sum = document.getElementsByClassName('Allsum');


    getSum.value = Number(getQuantity.value * getPrice.value);
    Sum.textContent = $`Sum: ${getSum.value}`;

}