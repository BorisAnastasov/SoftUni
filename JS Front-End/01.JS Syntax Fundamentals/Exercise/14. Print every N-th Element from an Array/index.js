function solve(arr, num){
  let output = [];
  for (let index = 0; index < arr.length; index+=num) {
    output.push(arr[index]);
  }
  return output;
}