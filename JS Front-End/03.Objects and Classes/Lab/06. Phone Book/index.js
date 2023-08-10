function solve(input){
  let phoneBook = {};
  for (let el of input) {
    let tokens = el.split(" ");
    let name = tokens[0];
    let number = tokens[1];
    phoneBook[name] = number;
  }
  for (let key in phoneBook) {
    console.log(`${key} -> ${phoneBook[key]}`)
  }
}