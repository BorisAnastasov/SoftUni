function smallest(num1, num2, num3){
  let result = (num1,num2,num3)=>{
    if(num1>=num3 &&num2>=num3){
      console.log(num3);
    }
    else if(num1>=num2 &&num3>=num2){
      console.log(num2);
    }
    else{
      console.log(num1);
    }
  };
  result(num1,num2,num3);
}