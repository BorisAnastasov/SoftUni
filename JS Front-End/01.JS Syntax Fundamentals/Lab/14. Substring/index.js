function solve(word, start, count){
  let rest = word.length - start-1;
  let lastIndex = 0;
  if(rest<=count){
  lastIndex = word.length-1;
  }
  else{
  lastIndex = start+count;
  }
  let output ="";
  for (let index = start; index < lastIndex; index++) {
  output+=`${word[index]}`
  }
  console.log(output);
}