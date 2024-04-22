﻿function AllProd() {

    let getBody = document.getElementsByClassName('sale');

    let createDiv = document.createElement('div');
    createDiv.setAttribute('id', 'result');
    createDiv.style.display = 'block';
    createDiv.style.position = 'absolute';
    createDiv.style.top = '150px'
    createDiv.style.left = '400px'
    createDiv.style.backgroundColor = 'white';
    createDiv.style.width = '798px';
    createDiv.style.height = '600px';

    let createTable = document.createElement('table');
    createTable.style.border= '1px solid black';

    let createThead = document.createElement('thead');
    let createTr = document.createElement('tr');
    createTr.style.border = '1px solid black';

    let createTdFirst = document.createElement('td');
    createTdFirst.textContent = 'Name Product';
    createTr.appendChild(createTdFirst);

    let createTdsecond = document.createElement('td');
    createTdsecond.textContent = 'Quantity';
    createTr.appendChild(createTdsecond);

    let createTdThree = document.createElement('td');
    createTdThree.textContent = 'Sell Price';
    createTr.appendChild(createTdThree);

    let closeBtn = document.createElement('button');
    closeBtn.setAttribute('class','btn')
    closeBtn.textContent = 'X';
    closeBtn.addEventListener('click',removeBtn);
    createTr.appendChild(closeBtn);

    createThead.appendChild(createTr);
    createTable.appendChild(createThead);

    

    createDiv.appendChild(createTable);
    getBody[0].appendChild(createDiv);
}

//<script type="text/javascript">
//    $(function(){

//        $(".product").click(function (e) {
//            e.preventDefault();
//            $.post("@Url.Action("AllProducts")", { id: $(this).data("movieId") }, function (data) {
//                alert(data);
//            });
//        });
//});
//</script>