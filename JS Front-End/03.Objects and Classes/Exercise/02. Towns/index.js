function towns(arr){
  let townList =[];
  for (let i = 0; i < arr.length; i++) {
    const element = arr[i];
    let tokens = element.split(" | ");
    let town = tokens[0];
    let latitude = Number(tokens[1]).toFixed(2).toString();
    let longitude = Number(tokens[2]).toFixed(2).toString();
    let obj = {
      town,
      latitude,
      longitude
    };
    townList.push(obj);
  }
  townList.forEach(element => {
    console.log(element);
  });
}