function solve(start, end){
  let sum =0;
  let output ="";
   for (let index = start; index <= end; index++) {
    output += `${index} `;
    sum+=index;
   }
   console.log(output);
   console.log(`Sum: ${sum}`);
}