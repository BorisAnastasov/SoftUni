function solve(text, word){
  const censordWord = "*".repeat(word.length);
  while(text.includes(word)){
    text = text.replace(word, censordWord);
  }
  console.log(text);
}