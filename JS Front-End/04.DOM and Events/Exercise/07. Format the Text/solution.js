function solve() {
  let sentences = document.getElementById("input").value.split(".");
  sentences = sentences.filter((s)=>s.length>0);
  const output = document.getElementById("output");
  while(sentences.length>0){
    let text = "";
    let count = 0;
    while(count!==3){
      if(sentences.length>0){
        text+=sentences.shift()+".";
        count++;    
      }else{
        output.innerHTML+=`<p>${text}</p>`;
        return;
      }
    }
    output.innerHTML+=`<p>${text}</p>`;
  }
}
