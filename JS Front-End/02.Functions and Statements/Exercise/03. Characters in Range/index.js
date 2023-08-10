function characters(char1, char2){
  let output = "";
  if(char2.charCodeAt(0)>char1.charCodeAt(0)){
    for (let i = char1.charCodeAt(0)+1; i < char2.charCodeAt(0); i++) {
      output+=String.fromCharCode(i)+" ";
    }
  }
  else{//char2>char1
    for (let i = char2.charCodeAt(0)+1; i < char1.charCodeAt(0); i++) {
      output+=String.fromCharCode(i)+" ";
    }
  }
  console.log(output);
}