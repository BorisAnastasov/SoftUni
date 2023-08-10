function solve(arr) {
  const list = arr.shift().split("!");
  for (let i = 0; i < arr.length; i++) {
    let tokens = arr[i].split(" ");
    let command = tokens[0];
    let product = tokens[1];
    switch (command) {
      case "Urgent":
        if (!list.includes(product)) {
          list.unshift(product);
        }
        break;

      case "Unnecessary":
        if (list.includes(product)) {
          let index = list.indexOf(product)
          list.splice(index, 1)
        }
        break;

      case "Correct":
        let newItem = tokens[2]
        if (list.includes(product)) {
          let index = list.indexOf(product)
          list.splice(index, 1, newItem)
        }
        break;

      case "Rearrange":
        if (list.includes(product)) {
          let index = list.indexOf(product)
          let item = list.splice(index, 1)
          list.push(item);
        }
        break;
    }
  }
  console.log(list.join(", "))
}