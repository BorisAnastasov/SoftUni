  function extract(content) {
    let p = document.getElementById(content).textContent;
    let result = [];
    let start = 0;
    let end = 0;
    for (let i = 0; i < p.length; i++) {
      if(p[i] === "("){
        start = i;
      } else if(p[i] === ")"){
        end = i;
        let word = p.substring(start, end);
        result.push(word);
      }
    }
    return result.join("; ");
  }