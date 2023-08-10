function validPassword(word){
  let tr = true;
  if(word.length<6||word.length>11){
    console.log("Password must be between 6 and 10 characters");
    tr = false;
  }
  let digCount = 0;
  for (let i = 0; i < word.length; i++) {
    if(/^\d$/.test(word[i])){
      digCount++;
    }
    else if(/[a-zA-Z]/.test(word[i])){

    }
    else{
      console.log("Password must consist only of letters and digits");
      tr = false;
      break;
    }
  }  
  if(digCount<2){
    console.log("Password must have at least 2 digits");
    tr = false;
  }
  if(tr){
    console.log("Password is valid");
  }

}