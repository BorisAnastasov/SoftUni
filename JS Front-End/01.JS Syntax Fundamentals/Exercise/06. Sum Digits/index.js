function solve(num){
  let sum = 0;
  while(num!=0){
   let n = num%10;
   sum+=n;
   num = Math.floor(num/10);
  }
  console.log(sum);
}