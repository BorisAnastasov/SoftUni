function garage(arr){
  let garage = {};
  for (let i = 0; i < arr.length; i++) {
    let tokens = arr[i].split(" - ");
    let information = tokens[1].split(", ");
    let obj = {};
    for (let z = 0; z < information.length; z++) {
      let type = information[z].split(": ");
      Object.defineProperty(obj, type[0], {value: type[1]});
    }
    if(!garage.hasOwnProperty(tokens[0])){
      garage[tokens[0]] = [];
    }
    garage[tokens[0]].push(obj);  
  }
  Object.keys(garage).sort().forEach(element => {
    console.log(`Garage № ${element}:`)
    garage[element].forEach(r => {
      let out = [];
      for (const key of Object.keys(r)) {
        out.push(`${key} - ${r[key]}`);
      }
      console.log(`--- ${out.join(", ")}`);
    });
  });
}

garage(['1 - color: blue, fuel type: diesel',
 '1 - color: red, manufacture: Audi',
  '2 - fuel type: petrol',
   '4 - color: dark blue, fuel type: diesel, manufacture: Fiat']);
