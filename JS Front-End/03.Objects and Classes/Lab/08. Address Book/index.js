function adress(input){
  let adressInfo = {};
  for (const str of input) {
    let tokens = str.split(":");
    let name = tokens[0];
    let adress = tokens[1];
    adressInfo[name] = adress;
  }
  let sorted = Object.entries(adressInfo);
  sorted.sort((a, b) => a[0].localeCompare(b[0]));

  for (const [key, value] of sorted) {
    console.log(`${key} -> ${value}`)
  }
}