function inventory(arr){
  let heroes = [];
  for (let i = 0; i < arr.length; i++) {
    let info = arr[i].split(" / ");
    let Hero = info[0];
    let level = Number(info[1]);
    let items = info[2].split(", ");
    let obj = {
      Hero,
      level,
      items
    }
    heroes.push(obj);
  }
  heroes = heroes.sort((h1, h2)=>h1.level-h2.level);
  heroes.forEach(element => {
    console.log(`Hero: ${element.Hero}`);
    console.log(`level => ${element.level}`);
    console.log(`items => ${element.items.join(", ")}`);
  });
}