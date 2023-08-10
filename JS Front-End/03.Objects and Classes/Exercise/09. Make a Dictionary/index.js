function dictionary(json){
  let result = {};
  json.forEach(element => {
    let str = JSON.parse(element);
    result[Object.getOwnPropertyNames(str)] = str[Object.getOwnPropertyNames(str)]
  });
  for (const key of Object.keys(result).sort()) {
    console.log(`Term: ${key} => Definition: ${result[key]}`);
  }
}