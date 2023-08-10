function song(input){
  let songs = [];
  class Song{
    constructor(typeList, name, time){
      this.typeList = typeList;
      this.name = name;
      this.time = time;
    }
  }
  let numberOfSongs = input.shift();
  let typeSong = input.pop();
  for (let i = 0; i < numberOfSongs ; i++) {
    let[typeList, name, time] = input[i].split("_");
    let song = new Song(typeList, name, time);
    songs.push(song);
  }
  
  if(typeSong === "all"){
    songs.forEach(element => {
      console.log(element.name);
    });
  }
  else{
    songs.filter((i)=>i.typeList===typeSong).forEach(i => {
      console.log(i.name);
    });
  }
}
