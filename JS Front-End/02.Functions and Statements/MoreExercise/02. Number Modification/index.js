function numMod(number){
  let aver = Average(number);
  while(aver<=5){
    let numToString = number.toString();
    numToString+="9";
    number = Number(numToString);
    aver = Average(number);
  }
  console.log(number);
  function Average(number){
    let sum = 0;
    let count = 0;
    let numToString = number.toString();
    for (let i = 0; i < numToString.length; i++) {
      const element = numToString[i];
      count++;
      sum+=Number(element);
    }
    let aver = sum/count.toFixed(2);
    return aver;
  }
}