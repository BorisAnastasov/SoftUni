function sortNumbers(array){
  let result = [];
  array.sort((a,b)=>a-b);
  while(array.  length>0){
    let start = array.shift();
    let end = array.pop();
    result.push(start);
    result.push(end);
  }
  return result;
}