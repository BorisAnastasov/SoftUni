function oddOcur(str){
  str = str.toLowerCase();
  let result = {};
  let arr = str.split(" ");
  for (let i = 0; i < arr.length; i++) {
    if(!result.hasOwnProperty(arr[i])){
      result[arr[i]] = 1;
    }
    else{
      result[arr[i]]++;
    }
  }
  let output = [];
  for (let key of Object.keys(result).sort((k)=>result[k])) {
    if(result[key]%2!==0){
       output.push(key);
    }
  }
  console.log(output.join(" "));
}