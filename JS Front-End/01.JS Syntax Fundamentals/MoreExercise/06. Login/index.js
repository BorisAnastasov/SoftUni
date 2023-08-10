function login(arr){
  let username = arr[0];
  let spl = arr[0].split("");
  spl = spl.reverse(); 
  let password = "";
  for (let index = 0; index < spl.length; index++) {
    password+=spl[index];
  }
  let tries = 0;
  for (let index = 1; index < arr.length; index++) {
    tries++;
    if(arr[index]===password){
      console.log(`User ${username} logged in.`);
      return;
    }
    else if(tries===4){
     console.log(`User ${username} blocked!`);
     return;
    }
    else{
      console.log("Incorrect password. Try again.");
    }
  }
}