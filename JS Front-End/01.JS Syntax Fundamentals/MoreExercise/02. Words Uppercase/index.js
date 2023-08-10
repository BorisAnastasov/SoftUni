function wordsUppercase(string){
  let words = [];
  let wordToAdd = '';
    for (let i = 0; i < string.length; i++) {
        const element = string[i];

        if(/\w/.test(element) && element !== ' '){
            wordToAdd += element;
            if(i==string.length-1){
              words.push(wordToAdd.toUpperCase());
            }
        }else{
            if(wordToAdd.length > 0){
                words.push(wordToAdd.toUpperCase());
            }
            wordToAdd = '';
        }
    }
    console.log(words.join(', '));
}