function solve(string){
  let text = string.split(" ");
  let specialWords = [];
  for (let index = 0; index < text.length; index++) {
    if(text[index][0] === "#"&& text[index].length>1&& /^#[A-Za-z]*$/.test(text[index])){
      specialWords.push(text[index].substring(1, text[index].length));
    }
  }
  for (let index = 0; index < specialWords.length; index++) {
    console.log(specialWords[index]);
  }

}