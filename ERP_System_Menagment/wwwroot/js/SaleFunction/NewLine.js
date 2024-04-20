function newLine() {

    let getTable = document.getElementById("AllInfo");
<<<<<<< HEAD
    let getInput = document.getElementById("first");
    let ch = getTable.children;
=======
>>>>>>> ec55b1c22bee350e21e6a8958929dc6f0dcd5fe7
    let ch = getTable.children;


    let tr = document.createElement('tr');

    let tdFirst = document.createElement('td');
    let inputFirst = document.createElement('input');
    inputFirst.type = 'text';
<<<<<<< HEAD
    inputFirst.setAttribute('id', 'first');
    inputFirst.addEventListener('focus', seeBtn);

    let btn = document.createElement('button');
    btn.textContent = '...';
    btn.setAttribute('id', 'getAll');
    btn.style.visibility = 'hidden';
    btn.addEventListener('click', AllProd);

=======
>>>>>>> ec55b1c22bee350e21e6a8958929dc6f0dcd5fe7
    inputFirst.addEventListener('focus', seeBtn);

    let btn = document.createElement('button');
    btn.textContent = '...';
    btn.setAttribute('id', 'getAll');
    btn.setAttribute('hidden', true);
    btn.addEventListener('click', AllProd);

    tdFirst.appendChild(inputFirst);
    tdFirst.appendChild(btn);
<<<<<<< HEAD
    tdFirst.appendChild(btn);

=======
>>>>>>> ec55b1c22bee350e21e6a8958929dc6f0dcd5fe7

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


    getTable.appendChild(tr);
}
