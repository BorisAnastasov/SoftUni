function solve(num, ...arr){
  for (let i = 0; i < arr.length; i++) {
    switch(arr[i]){
      case "chop":
        num/=2;
      break;
      case "dice":
        num = Math.sqrt(num);
      break;
      case "spice":
        num+=1;
      break;
      case "bake":
        num*=3;
      break;
      case "fillet":
        num*=0.8;
      break;
    }
    console.log(num);
  }
}