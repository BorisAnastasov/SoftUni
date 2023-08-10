function solve() {
    let departButton = document.querySelector("#depart");
    let arriveButton = document.querySelector("#arrive");
    let status = document.querySelector("#info .info");
    let url = `http://localhost:3030/jsonstore/bus/schedule/depot`;
    let stopName = "";
    let nextStopName = "";
    function depart() {
       fetch(url)
       .then(res=>res.json())   
       .then((res) => {
        stopName = res.name;
       nextStopName = res.next;
       status.textContent = `Next stop ${stopName}`;
       departButton.disabled = true;
       arriveButton.disabled = false; 
    }).catch((_)=>{
        status.textContent = `Error`;
        departButton.disabled = true;
       arriveButton.disabled = true;
    });
    }

    async function arrive() {
        
       status.textContent = `Arriving at ${stopName}`;
       departButton.disabled = false;
       arriveButton.disabled = true;
       stopName = nextStopName;
       url =`http://localhost:3030/jsonstore/bus/schedule/${stopName}`;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();