function AddSubstract(num1, num2, num3){
  let result = 0;
  let sum = (num1, num2)=>{
    result=num1+num2;
  };
  let substract = (sum, num3)=>{
    result=sum-num3;
  };
  sum(num1, num2);
  substract(result, num3);
  console.log(result)
}