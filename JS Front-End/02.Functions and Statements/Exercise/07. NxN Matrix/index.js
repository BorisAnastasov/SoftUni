function matrix(n){
  let output = "";
  for (let index = 0; index < n; index++) {
    for (let i = 0; i < n; i++) {
      output+=`${n} `
    }
    output+=`\n`;
  }
  console.log(output);
}