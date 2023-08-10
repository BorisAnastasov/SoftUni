function getInfo() {
    let input = document.querySelector("#stopId").value;
    let resultName = document.querySelector("#result #stopName");
    let busses = document.querySelector("#result #buses");
    resultName.textContent = "";
    busses.innerHTML ="";
    if(!(input==="1287"||input==="1308"||input==="1327"||input==="2334")){
        resultName.textContent = "Error";
        return;
    }
    fetch(`http://localhost:3030/jsonstore/bus/businfo/${input}`)
        .then(obj => obj.json())
        .then((obj) => {
            resultName.textContent = obj.name;
            Object.entries(obj.buses).forEach(([key, value]) => {
                let li = document.createElement("li");
                li.textContent = `Bus ${obj.buses[key]} arrives in ${obj.buses[value]} minutes` 
                busses.appendChild(li);
            });
    });
}