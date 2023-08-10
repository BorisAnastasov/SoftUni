function wordsTracker(arr){
  const [searchedWords,...words] = arr;
  let wordOcc = searchedWords.split(" ").reduce((acc, curr)=> {
    acc[curr] = 0
    return acc;
  }, {})
  words.forEach((word) => {
    if(wordOcc.hasOwnProperty(word)){
      wordOcc[word]++;
    }
  });
  Object.keys(wordOcc).sort((w1,w2)=>wordOcc[w2]-wordOcc[w1]).forEach(element => {
    console.log(`${element} - ${wordOcc[element]}`);
  });
}
