function movies(arr){
  let movieList = [];
  for (let i = 0; i < arr.length; i++) {
    if(arr[i].includes("addMovie")){
      let [_, name] = arr[i].split("addMovie ");
      let obj = {
        name,
        director: null,
        date: null
      } 
      movieList.push(obj);
    }
    else if(arr[i].includes("directedBy")){
      let [name, director] = arr[i].split(" directedBy ");
      const movie = movieList.find((m)=>m.name === name)
      if(movie){
        movie.director = director;
      }
    }
    else if(arr[i].includes("onDate")){
      let [name, date] = arr[i].split(" onDate ");
      const movie = movieList.find((m)=>m.name === name)
      if(movie){
        movie.date = date;
      }
    }
  }
  movieList.filter((m)=>m.director&&m.date)
  .forEach((m)=>console.log(JSON.stringify(m)))
}