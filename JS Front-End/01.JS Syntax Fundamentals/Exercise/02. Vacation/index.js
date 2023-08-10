function solve(people, typeOfGroup, dayOfWeek){
  let pricePerPerson = 0.0;
  switch(dayOfWeek){
    case "Friday":
        if(typeOfGroup === "Students"){
            pricePerPerson = 8.45;
        }
        else if(typeOfGroup === "Business"){
          pricePerPerson = 10.9;
        }
        else{//REGULAR
         pricePerPerson = 15;
        }
    break;
    case "Saturday":
      if(typeOfGroup === "Students"){
        pricePerPerson = 9.8;
    }
    else if(typeOfGroup === "Business"){
      pricePerPerson = 15.6;
    }
    else{//REGULAR
     pricePerPerson = 20;
    }
    break;
    case "Sunday":
      if(typeOfGroup === "Students"){
        pricePerPerson = 10.46;
    }
    else if(typeOfGroup === "Business"){
      pricePerPerson = 16;
    }
    else{//REGULAR
     pricePerPerson = 22.5;
    }
    break;
  }
  if(typeOfGroup === "Students" &&people>=30){
    pricePerPerson*=0.85;
  }
  if(typeOfGroup === "Business" && people>=100){
    people-=10;
  }
  if(typeOfGroup === "Regular" && people>=10&& people <= 20){
    pricePerPerson*=0.95;
  }
  let total = pricePerPerson*people;
  console.log(`Total price: ${total.toFixed(2)}`);
}