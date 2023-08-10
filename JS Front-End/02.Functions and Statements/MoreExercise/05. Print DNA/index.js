function dna(n){
  let letters = ['A','T','C','G','T','T','A','G','G','G'];
  let count = 3;
  index = 0;
  for (let i =1; i <= n; i++) {   
    if(index>=letters.length){
      index = index-letters.length;
    }
    if(i%2===0){
      line = `*${letters[index]}--${letters[index+1]}*`;
    }
    else{
      if(count===3){
        count = 1;
        line = `**${letters[index]}${letters[index+1]}**`;
      }
      else{
      
        line = `${letters[index]}----${letters[index+1]}`;
        count = 3;
      }  
    }
    console.log(line);
    index+=2;
  }
}