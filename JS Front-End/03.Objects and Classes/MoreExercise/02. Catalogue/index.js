function catalog(arr){
  let catalog = {};
  for (let i = 0; i < arr.length; i++) {
    let tokens = arr[i].split(" : ");
    let name = tokens[0];
    let price = Number(tokens[1]);
    catalog[name] = price;
  }
  let letters = [];
  Object.keys(catalog).sort(function (a, b) {
    return a.toLowerCase().localeCompare(b.toLowerCase());
}).forEach(element => {
    if(!letters.includes(element[0])){
      console.log(element[0]);
      console.log(`  ${element}: ${catalog[element]}`);
      letters.push(element[0]);
    } else{
      console.log(`  ${element}: ${catalog[element]}`);
    }
  });
}