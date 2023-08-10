function army(arr){
  let armies = {};
  for (let i = 0; i < arr.length; i++) {
    const element = arr[i];
    if(element.includes("arrives")){
      let leader = element.split(" ").shift();
      armies[leader] = {
        ArmyCount: 0,
      }; 
    }else if(element.includes(": ")){
      let info = element.split(": ");
      let leader = info.shift();
      let tokens = info[0].split(", ");
      let army = tokens[0];
      let count = Number(tokens[1]);
      if(armies.hasOwnProperty(leader)){
        armies[leader][army] = count;
        armies[leader].ArmyCount+=count;
      }
    }
    else if(element.includes(" + ")){
      let tokens = element.split(" + ");
      let army = tokens[0];
      let count = Number(tokens[1]);
      Object.keys(armies).forEach(key => {
        if(armies[key].hasOwnProperty(army)){
          armies[key][army]+=count;
          armies[key].ArmyCount+=count;
        }
      });  
    }
    else if(element.includes("defeated")){
      let leader = element.split(" ").shift();
      if(armies.hasOwnProperty(leader)){
        delete armies[leader];
      }
    }
  }
  Object.keys(armies).sort((v1, v2)=>armies[v2].ArmyCount-armies[v1].ArmyCount).forEach(element => {
    console.log(`${element}: ${armies[element].ArmyCount}`);
    Object.keys(armies[element]).sort((a1, a2)=>armies[element][a2]-armies[element][a1]).slice(1).forEach(el => {
      console.log(`>>> ${el} - ${armies[element][el]}`);  
    });
  });
}