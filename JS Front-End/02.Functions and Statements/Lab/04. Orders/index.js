function order(product, quantity){
  let sum = 0;
  switch(product){
    case "coffee":
      sum = 1.5;
    break;
    case "water":
      sum = 1.0;
    break;
    case "coke":
      sum = 1.4;
    break;
    case "snacks":
      sum = 2.00;
    break;
  }
  sum*=quantity;
  console.log(sum.toFixed(2));
}