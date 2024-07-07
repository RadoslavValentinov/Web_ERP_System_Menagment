function resultSum() {

    let getQuantity = document.getElementById("quantity");
    let getPrice = document.getElementById("price");
    let getSum = document.getElementById("Sum");
    let Sum = document.getElementsByClassName('Allsum');


    getSum.value = Number(getQuantity.value * getPrice.value);
    Sum[0].textContent = 'Sum:' + Number(getSum.value).toFixed(2)+'lv.';

}