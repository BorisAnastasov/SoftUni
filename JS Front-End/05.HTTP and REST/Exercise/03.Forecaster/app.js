function attachEvents() {
  let location = document.querySelector("#location").value;
  let submitButton = document.querySelector("#submit");
  
  let forecast = document.querySelector("#forecast");
  
  GetTheLocationCode();
  let current = document.querySelector("#current");
  let upcoming = document.querySelector("#upcoming");
  submitButton.addEventListener("click", tellTheWeather());
  
  async function GetTheLocationCode(){
    const objArr = await (await fetch("http://localhost:3030/jsonstore/forecaster/locations")).json()
    const obj = objArr.find(l=>l.name===location);
    const code = obj.code;
    console.log(code);
  }
  
  
  
  function tellTheWeather(){
    
  }
}

attachEvents();