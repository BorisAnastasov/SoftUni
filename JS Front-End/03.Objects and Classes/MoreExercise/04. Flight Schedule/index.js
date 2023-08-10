  function flights(arr){
    let flights = arr[0];
    let changes = arr[1];
    let status = arr[2];
    let ReadyToFly = {};
    let Cancelled = {};
    for (let i = 0; i < flights.length; i++) {
      const elem = flights[i].split(" ");
      ReadyToFly[elem.shift()] = `${elem.join(" ")}`;
    }
    for (let i = 0; i < changes.length; i++) {
      const element = changes[i].substring(0, changes[i].length-10);
      if(Object.keys(ReadyToFly).includes(element)){
        Cancelled[element] = ReadyToFly[element];
        delete ReadyToFly[element];
      }      
    }
    if(status[0]==='Ready to fly'){
      Object.keys(ReadyToFly).forEach(element => {
        console.log(`{ Destination: '${ReadyToFly[element]}', Status: 'Ready to fly' }`);
      });
    }else{
      Object.values(Cancelled).sort().forEach(element => {
        console.log(`{ Destination: '${element}', Status: 'Cancelled' }`);
      });
    }
  }
