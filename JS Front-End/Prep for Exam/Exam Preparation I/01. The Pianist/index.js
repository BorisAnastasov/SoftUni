function solve(arr) {
  let count = Number(arr.shift());
  let pieces = {};
  for (let i = 0; i < count; i++) {
    let tokens = arr.shift().split("|");
    let piece = tokens[0];
    let composer = tokens[1];
    let key = tokens[2];
    pieces[piece] = {
      composer,
      key
    }
  }
  for (let i = 0; i < arr.length - 1; i++) {
    let tokens = arr[i].split("|");
    let command = tokens.shift();
    let piece = tokens[0];
    switch (command) {
      case "Add":
        let composer = tokens[1];
        let key = tokens[2];
        if (pieces.hasOwnProperty(piece)) {
          console.log(`${piece} is already in the collection!`);
        }
        else {
          pieces[piece] = {
            composer,
            key
          }
          console.log(`${piece} by ${composer} in ${key} added to the collection!`);
        }
        break;
      case "Remove":
        if (pieces.hasOwnProperty(piece)) {
          console.log(`Successfully removed ${piece}!`);
          delete pieces[piece];
        } else {
          console.log(`Invalid operation! ${piece} does not exist in the collection.`);
        }
        break;
      case "ChangeKey":
        let newKey = tokens[1];
        if (pieces.hasOwnProperty(piece)) {
          console.log(`Changed the key of ${piece} to ${newKey}!`);
          pieces[piece].key = newKey;
        }
        else {
          console.log(`Invalid operation! ${piece} does not exist in the collection.`);
        }
        break;
    }
  }

  Object.keys(pieces).forEach(el => {
    console.log(`${el} -> Composer: ${pieces[el].composer}, Key: ${pieces[el].key}`);
  });
}
// solve([
//   '4',
//   'Eine kleine Nachtmusik|Mozart|G Major',
//   'La Campanella|Liszt|G# Minor',
//   'The Marriage of Figaro|Mozart|G Major',
//   'Hungarian Dance No.5|Brahms|G Minor',
//   'Add|Spring|Vivaldi|E Major',
//   'Remove|The Marriage of Figaro',
//   'Remove|Turkish March',
//   'ChangeKey|Spring|C Major',
//   'Add|Nocturne|Chopin|C# Minor',
//   'Stop']
// );