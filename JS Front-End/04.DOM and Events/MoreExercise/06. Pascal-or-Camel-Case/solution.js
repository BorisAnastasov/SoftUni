function solve() {
  let str = document.querySelector("form div:nth-child(1) input").value;
  let text = str.toLowerCase().split(" ");
  let type = document.querySelector("form div:nth-child(2) input").value;
  if(type === "Camel Case"){
    for (let i = 1; i < text.length; i++) {
      text[i]  = text[i][0].toUpperCase()+text[i].slice(1);
    } 
  }else if(type === "Pascal Case"){
      for (let i = 0; i < text.length; i++) {
      text[i]  = text[i][0].toUpperCase()+text[i].slice(1);
    } 
  } else{
    text.length = 0;
    text.push("Error!");
  }
  let result = document.querySelector(".result-container #result");
  result.textContent+=text.join("");
}