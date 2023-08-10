function city(obj){
  let ent = Object.entries(obj);
  for (const [key, value] of ent) {
    console.log(`${key} -> ${value}`)
  }
}