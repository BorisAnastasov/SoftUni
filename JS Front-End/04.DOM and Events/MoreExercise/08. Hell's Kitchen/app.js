function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      let restaurants = [];
      let arr = JSON.parse(document.querySelector(".restaurant-race-class #inputs textarea").value);
      for (let i = 0; i < arr.length; i++) {
         let name = arr[i].split(" - ").shift();
         let token = arr[i].split(" - ").pop().split(", ");
         let workers = [];
         token.forEach(element => {
            let tok = element.split(" ");
            let workerName = tok[0];
            let salary = Number(tok[1]);
            let obj = {
               workerName,
               salary
            }
             workers.push(obj);
         });
         let averSalary = setSalary(workers);
         let bestSalary = setBestSalary(workers);
         let rest ={
            name,
            workers,
            averSalary,
            bestSalary
         }
         let cont = false;
         restaurants.forEach(element => {
            if(element.name === rest.name){
               cont = true;
               rest.workers.forEach(el => {
                  element.workers.push(el);
               });
               element.averSalary = setSalary(element.workers);
               element.bestSalary = setBestSalary(element.workers);
            }
         });
         if(!cont){
            restaurants.push(rest);
         } 
      }
      
      function setSalary(workers){
            let aver = (workers.reduce((total, curr)=>{
             return total+curr.salary;   
            }, 0)/workers.length).toFixed(2);
            return aver;
      }
      function setBestSalary(workers){
            let best = workers.reduce((top, curr)=>{
             return top>curr.salary?top:curr.salary;  
            }, 0);
            return best;
      }
;
      let bestRestaurant = restaurants.sort((r1, r2)=>r2.averSalary-r1.averSalary)[0];
      let bRest = document.querySelector("#bestRestaurant p");
      bRest.textContent = `Name: ${bestRestaurant.name} Average Salary: ${bestRestaurant.averSalary} Best Salary: ${bestRestaurant.bestSalary.toFixed(2)}`;
      bestRestaurant.workers.sort((a, b)=>b.salary-a.salary)
      let work = document.querySelector("#workers p");
      bestRestaurant.workers.forEach(worker=>{
         work.textContent+=`Name: ${worker.workerName} With Salary: ${worker.salary} `;
      })
   }
   
}
