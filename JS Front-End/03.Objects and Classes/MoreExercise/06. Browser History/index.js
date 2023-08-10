function browserHistory(obj, arr){
  for (let i = 0; i < arr.length; i++) {
    let tokens = arr[i].split(" ");
    let command = tokens[0];
    let site =  tokens[1];
    if(command === "Open"){
      if(!obj["Open Tabs"].includes(site)){
        obj["Open Tabs"].push(site);
        obj["Browser Logs"].push(arr[i]);
      }
    } else if(command === "Close"){
      if(obj["Open Tabs"].includes(site)){
        let index = obj["Open Tabs"].indexOf(site)
        obj["Open Tabs"].splice(index, 1);
        obj["Recently Closed"].push(site);
        obj["Browser Logs"].push(arr[i]);
      }
    } else if("Clear"===command){
      obj["Open Tabs"].length= 0;
        obj["Recently Closed"].length= 0;
        obj["Browser Logs"].length= 0;
    }
  }
  console.log(obj["Browser Name"]);
  console.log(`Open Tabs: ${obj["Open Tabs"].join(", ")}`);
  console.log(`Recently Closed: ${obj["Recently Closed"].join(", ")}`);
  console.log(`Browser Logs: ${obj["Browser Logs"].join(", ")}`);
}
browserHistory({"Browser Name":"Google Chrome","Open Tabs":["Facebook","YouTube","Google Translate"],"Recently Closed":["Yahoo","Gmail"],
 "Browser Logs":["Open YouTube","Open Yahoo","Open Google Translate","Close Yahoo","Open Gmail","Close Gmail","Open Facebook"]},
 ["Close Facebook", "Open StackOverFlow", "Open Google"]
);