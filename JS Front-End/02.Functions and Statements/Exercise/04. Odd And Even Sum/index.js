function sumOfOdds(num){
  let sumOdd = 0;
  let sumEven = 0;
  let string = num.toString();
  for (let i = 0; i < string.length; i++) {
    let n = Number(string[i]);
    if(n%2===0){
      sumEven+=n;
    }
    else{
      sumOdd+=n;
    }
  }
  console.log(`Odd sum = ${sumOdd}, Even sum = ${sumEven}`);
}