function solve(arr){
  let sumOdd = 0;
  let sumEven = 0;
  for (let index = 0; index < arr.length; index++) {
    if(arr[index]%2 === 0){
      sumEven+=arr[index];
    }
    else{
      sumOdd+=arr[index];
    }
  }
  console.log(sumEven-sumOdd);
}