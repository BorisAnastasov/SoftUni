function revealWords(words, text){
  let result = "";
  let keys = words.split(", ");
  let temp = [];
  for (let index = 0; index < keys.length; index++) {
      temp[index] = transform(keys[index]);
  }
  for (let index = 0; index < temp.length; index++) {
    text = text.replace(temp[index], keys[index]);
  } 
  function transform(word){
    let res = "";
    for (let index = 0; index < word.length; index++) {
      res+="*";
    }
    return res;
  }
  console.log(text);
}
