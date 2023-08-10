function piccolo(arr){
  let parking = [];
  for (let i = 0; i < arr.length; i++) {
    let token = arr[i].split(", ");
    if(token[0]==="IN"){
      if(!parking.includes(token[1])){
        parking.push(token[1]);
      }
    }else if(token[0]==="OUT"){
      if(parking.includes(token[1])){
        const index = parking.indexOf(token[1]);
        parking.splice(index,1);
      }
    }
  }
  parking = parking.sort();
  if(parking.length>0){
    parking.forEach(element => {
      console.log(element);
    }); 
  } else{
    console.log("Parking Lot is Empty");
  }
}
