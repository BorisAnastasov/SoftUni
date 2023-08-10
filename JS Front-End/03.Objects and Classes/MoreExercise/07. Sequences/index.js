function sequence(arr){
  let result = [];
  for (let i = 0; i < arr.length; i++) {
    let numberArr = JSON.parse(arr[i]);
    numberArr = numberArr.sort((a, b)=> b-a);
    if(!Incl(result, numberArr)){
      result.push(numberArr);
    }
  }
  result.sort((a, b) => a.length - b.length).forEach(element => {
    console.log(`[${element.join(", ")}]`);
  });
  function Incl(result, numberArr){
    let incl = false;
    for (let i = 0; i < result.length; i++) {
      let st1 = JSON.stringify(result[i]);
      let st2 = JSON.stringify(numberArr);
      if(st1== st2){
        incl = true;
        break;
      }
    }
    return incl;
  }
}
