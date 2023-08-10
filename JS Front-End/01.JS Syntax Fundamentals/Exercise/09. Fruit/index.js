function solve(type, grams, pricePerKG){
  let kg = grams/1000;
let money = kg*pricePerKG;
console.log(`I need $${money.toFixed(2)} to buy ${kg.toFixed(2)} kilograms ${type}.`);
}