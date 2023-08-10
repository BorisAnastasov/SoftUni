function speedLimit(speed, area){
  let status = "";
  let withInTheLimit = false;
  let speedLimit = 0;
  switch(area){
    case "motorway":
      speedLimit = 130;
      if(speed<=130){
        withInTheLimit = true;
      }
      else{
        withInTheLimit = false;
      }
    break;
    case "interstate":
      speedLimit = 90;
      if(speed<=90){
        withInTheLimit = true;
      }
      else{
        withInTheLimit = false;
      }
    break;
    case "city":
      speedLimit = 50;
      if(speed<=50){
        withInTheLimit = true;
      }
      else{
        withInTheLimit = false;
      }
    break;
    case "residential":
      speedLimit = 20;
      if(speed<=20){
        withInTheLimit = true;
      }
      else{
        withInTheLimit = false;
      }
    break;
  }
  if(withInTheLimit){
    console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
  }
  else{
    let overLimit = speed-speedLimit;
    if(overLimit<=20){
      status = "speeding";
    }
    else if(overLimit<=40){
      status = "excessive speeding";
    }
    else{
      status = "reckless driving";
    }
    console.log(`The speed is ${overLimit} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
  }
}