function subtract() {
    let div = document.getElementById("result");
    let firstNumber = document.getElementById("firstNumber").value;
    let secondNumber = document.getElementById("secondNumber").value;
    
    let result = document.createTextNode(Number(firstNumber)-Number(secondNumber));

    div.appendChild(result);

}