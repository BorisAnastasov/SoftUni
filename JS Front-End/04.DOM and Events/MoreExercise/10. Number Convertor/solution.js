function solve() {
    const optionBinary = document.createElement("option");
    optionBinary.text = "Binary";
    const optionHexadecimal = document.createElement("option");
    optionHexadecimal.text = "Hexadecimal";
    let selectTo = document.querySelector("#selectMenuTo");
    selectTo.appendChild(optionBinary);
    selectTo.appendChild(optionHexadecimal);
    optionBinary.setAttribute("value", "binary");
    optionHexadecimal.setAttribute("value", "hexadecimal"); 
    let input = document.querySelector("#container #input");
    let result = document.querySelector("#result");
    result.removeAttribute("disabled");
    result.removeAttribute("readonly");
    let button = document.querySelector("#container button");
    button.addEventListener("click", (e)=>{
      if(selectTo.value === "binary"){
          result.value = Number(input.value).toString(2);
      } else if(selectTo.value === "hexadecimal"){
        result.value = Number(input.value).toString(16).toUpperCase();
      }
    });
}