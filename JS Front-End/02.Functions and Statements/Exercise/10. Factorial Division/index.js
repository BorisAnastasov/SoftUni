function factor(num1, num2){
  function factoriel(n){
    let sum = 1;
  while(n!=1){
    sum*=n;
    n--;
  }
  return sum;
  }
  num1 = factoriel(num1);
  num2 = factoriel(num2);
  let result = num1/num2;
  console.log(result.toFixed(2));
}