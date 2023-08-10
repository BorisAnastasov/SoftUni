function solve(num){
  let char = num%10;
  let same = true;
  let sum = 0;
  while(num){
   let n = num%10;
   if(n === char&& same === true){
    same = true;
   }
   else{
    same = false;
   }
   sum+=n;
   num = Math.floor(num/10);
  }
  console.log(same);
  console.log(sum);
}