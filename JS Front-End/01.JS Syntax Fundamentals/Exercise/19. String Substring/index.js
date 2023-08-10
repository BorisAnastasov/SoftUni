  function stringSubstring(word, text){
    let words = text.split(" ");
    for (let index = 0; index < words.length; index++) {
      words[index] = words[index].toLowerCase();      
    }
    let found = false;
    for (let index = 0; index < words.length; index++) {
      if(words[index] === word){
        found = true;
      }
    }
    if(found === false){
      console.log(`${word} not found!`)
    }
    else{
      console.log(word);
    }
  }