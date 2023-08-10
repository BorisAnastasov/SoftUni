function commnets(arr){
  let usersList = [];
  let articleList = [];
  let result = {};
  for (let i = 0; i < arr.length; i++) {
    if(arr[i].split(" ").shift()==="user"){
       let userName = arr[i].split(" ").pop();
       usersList.push(userName);
    } else if(arr[i].split(" ").shift()==="article"){
      let articleName = arr[i].split(" ").pop();
      articleList.push(articleName);
    } else{
       let tokens = arr[i].split(": ");
       let part1 = tokens[0];
       let part2 = tokens[1];
       let userName = part1.split(" ").shift();
       let articleName = part1.split(" ").pop();
       let title = part2.split(", ").shift();
       let comment = part2.split(", ").pop();
       if(usersList.includes(userName)&& articleList.includes(articleName)){
        if(!result.hasOwnProperty(articleName)){
          result[articleName] = [];
        }
         
         result[articleName].push(
         {
          userName,
          title,
          comment,
         });
       }
    }
  }
  Object.keys(result).sort((k1, k2)=> result[k2].length-result[k1].length).forEach(element => {
    console.log(`Comments on ${element}`)
    result[element].sort((a, b)=>a.userName.toString().localeCompare(b.userName.toString())).forEach(el => {
      console.log(`--- From user ${el.userName}: ${el.title} - ${el.comment}`);
    });
  });
}