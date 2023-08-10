function bookShelf(arr){
  let shelves = {};
  for (let i = 0; i < arr.length; i++) {
    if(arr[i].includes(" -> ")){
      let tokens = arr[i].split(" -> ");
      let id = tokens[0];
      let genre = tokens[1];
      if(!shelves.hasOwnProperty(id)){
        shelves[id] = {
          genre,
          books: [],
          count: 0,
        }
      }
    } else if(arr[i].includes(": ")){
      let tok = arr[i].split(": ");
      let title = tok[0];
      let tokens = tok[1].split(", ");
      let author = tokens[0];
      let genre1 = tokens[1];
      let book = {
        author,
        title,
      }
      Object.keys(shelves).forEach((key)=>{
        if(shelves[key].genre===genre1){
          shelves[key].books.push(book);
          shelves[key].count++;  
        }
      });
    }
  }
  Object.keys(shelves).sort((a, b)=>shelves[b].count-shelves[a].count).forEach((key)=>{
    console.log(`${key} ${shelves[key].genre}: ${shelves[key].count}`);
    shelves[key].books.sort((z, d)=>z.title-d.title).forEach(el => {
      console.log(`--> ${el.title}: ${el.author}`);
    });
  })
}