function solve(jsonString){
  let person = JSON.parse(jsonString);
  let ent = Object.entries(person);
  for  ( let [key, value] of ent) {
    console.log(`${key}: ${value}`)
  }
}