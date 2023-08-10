function loading(number){
  let array = [".",".",".",".",".",".",".",".",".","."];
  
  for (let i = 0; i < number/10; i++) {
    array[i] = '%';
  }
  if(number === 100){
    console.log(`${number}% Complete!`)
    console.log(`[${array.join("")}]`);
  }
  else{
    console.log(`${number}% [${array.join("")}]`);
    console.log("Still loading...");
  }
  
}