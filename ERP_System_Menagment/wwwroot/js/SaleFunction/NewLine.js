function newLine() {

    let getTable = document.getElementById("AllInfo");
 
    let ch = getTable.children;




    let tr = document.createElement('tr');

    let tdFirst = document.createElement('td');
    let inputFirst = document.createElement('input');
    inputFirst.type = 'text';
    inputFirst.setAttribute('id', 'first');
  
    inputFirst.addEventListener('focus', seeBtn);
    tdFirst.appendChild(inputFirst);


    let tdSecond = document.createElement('td');
    let inputSecond = document.createElement('input');
    inputSecond.type = 'text';
    tdSecond.appendChild(inputSecond);

    let tdThree = document.createElement('td');
    let inputThree = document.createElement('input');
    inputThree.type = 'text';
    tdThree.appendChild(inputThree);


    let tdFour = document.createElement('td');
    let inputFour = document.createElement('input');
    inputFour.type = 'text';
    inputFour.addEventListener('keypress', newLine);
    tdFour.appendChild(inputFour);


    tr.appendChild(tdFirst);
    tr.appendChild(tdSecond);
    tr.appendChild(tdThree);
    tr.appendChild(tdFour);



    ch[0].appendChild(tr);
}
