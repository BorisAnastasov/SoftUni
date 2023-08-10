function check(numOne, numTwo, numThree){
  let negCount = 0;
  if(numOne<0){
    negCount++;
  }
  if(numTwo<0){
    negCount++;
  }
  if(numThree<0){
    negCount++;
  }
  if(negCount%2!==0){
    console.log("Negative");
  }
  else{
    console.log("Positive");
  }
}