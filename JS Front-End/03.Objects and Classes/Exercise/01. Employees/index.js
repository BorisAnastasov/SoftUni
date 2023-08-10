function employees(arr){
  let employList = [];
  for (let i = 0; i < arr.length; i++) {
    const element = arr[i];
    let letters = element.length;
    let obj = {
      name: element,
      personalNumber: letters
    };
    employList.push(obj);
  }
  employList.forEach(element => {
    console.log(`Name: ${element.name} -- Personal Number: ${element.personalNumber}`);
  });
}