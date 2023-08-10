function solve(arr, num){
  for (let index = 0; index < num; index++) {
    const firstElement  = arr.shift();
    arr.push(firstElement);
  }
  let output = "";
  for (let index = 0; index < arr.length; index++) {
    output+=arr[index]+" ";
  }
  console.log(output);
}