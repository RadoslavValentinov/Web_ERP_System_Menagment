function newLine() {

    let getTable = document.getElementById("AllInfo");
 
    let ch = getTable.children;

    let tr = document.createElement('tr');

    let tdFirst = document.createElement('td');
    let inputFirst = document.createElement('input');
    inputFirst.type = 'text';
    inputFirst.setAttribute('id', 'first');
    inputFirst.addEventListener('keypress', autoField);
    tdFirst.appendChild(inputFirst);


    let tdSecond = document.createElement('td');
    let inputSecond = document.createElement('input');
    inputSecond.type = 'text';
    inputSecond.value = '0.00'
    inputSecond.setAttribute('id','quantity');
    tdSecond.appendChild(inputSecond);

    let tdThree = document.createElement('td');
    let inputThree = document.createElement('input');
    inputThree.type = 'text';
    inputThree.value = '0.00'
    inputThree.setAttribute('id', 'price');
    inputThree.addEventListener('keypress', resultSum);
    tdThree.appendChild(inputThree);


    let tdFour = document.createElement('td');
    let inputFour = document.createElement('input');
    inputFour.type = 'text';
    inputFour.value = '0.00'
    inputFour.addEventListener('keypress', newLine);
    tdFour.appendChild(inputFour);


    tr.appendChild(tdFirst);
    tr.appendChild(tdSecond);
    tr.appendChild(tdThree);
    tr.appendChild(tdFour);



    ch[0].appendChild(tr);
}
