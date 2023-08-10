function meetings(input){
  let meetings = {};
  for (const str of input) {
    let tokens = str.split(" ");
    let day = tokens[0];
    let name = tokens[1];
    if(!meetings.hasOwnProperty(day)){
      meetings[day] = name;
      console.log(`Scheduled for ${day}`);
    }
    else{
      console.log(`Conflict on ${day}!`)
    }
  }
  for (const key in meetings) {
    console.log(`${key} -> ${meetings[key]}`)
  }
}