function palin(arr){
  function pal(num){
    let string = num.toString();
    let is = true;
    for (let i = 0; i < string.length; i++) {
      if(string[i] !== string[string.length-1-i]){
        is = false;
      }
      if(i === string.length-1-i){
        break;
      }
    }
    return is;
  }
  for (let i = 0; i < arr.length; i++) {
    console.log(pal(arr[i]));
  }
}