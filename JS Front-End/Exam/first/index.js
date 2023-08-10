function solve(arr) {
  let result = {};
  let n = Number(arr.shift())
  for (let i = 0; i < n; i++) {
    let tokens = arr[i].split("|");
    let rider = tokens[0];
    let fuelCapacity = Number(tokens[1])
    let position = tokens[2]
    result[rider] = {
      fuelCapacity,
      position
    }
  }
  for (let i = n; i < arr.length; i++) {
    let tokens = arr[i].split(" - ");
    let command = tokens[0]
    let rider = tokens[1]
    switch (command) {
      case "StopForFuel":
        let minimum = Number(tokens[2])
        let changePos = tokens[3]
        if (result[rider].fuelCapacity < minimum) {
          console.log(`${rider} stopped to refuel but lost his position, now he is ${changePos}.`)
          result[rider].fuelCapacity = 100
          result[rider].position = changePos
        } else {
          console.log(`${rider} does not need to stop for fuel!`)
        }
        break;

      case "Overtaking":
        let rider2 = tokens[2]
        if (result[rider].position < result[rider2].position) {
          let ridPos = result[rider2].position
          console.log(`${rider} overtook ${rider2}!`)
          result[rider2].position = result[rider].position;
          result[rider].position = ridPos;
        }
        break;

      case "EngineFail":
        let left = Number(tokens[2])
        console.log(`${rider} is out of the race because of a technical issue, ${left} laps before the finish.`)
        delete result[rider]
        break;
    }
    if (command === "Finish") {
      Object.keys(result).forEach(key => {
        console.log(key)
        console.log(`Final position: ${result[key].position}`)
      })
    }
  }

}
