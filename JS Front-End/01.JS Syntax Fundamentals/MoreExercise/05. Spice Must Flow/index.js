function spices(starting){
  let days = 0;
  let collected = 0;
  while(starting>=100){
   collected+=starting-26;
   if(collected<0){
    collected = 0;
   }
   days++;
   starting-=10;
  }
  collected-=26;
  if(collected<0){
    collected = 0;
   }
  console.log(days);
  console.log(collected);
}