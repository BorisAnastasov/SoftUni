function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const elements = Array.from(document.querySelectorAll(".select"));
      elements.forEach(element => {
         element.classList.remove("select");
      });


      const cells = document.querySelectorAll("tbody td");
      const input = document.querySelector("#searchField").value;
      cells.forEach(cell => {
         if(cell.textContent.includes(input)){
            cell.parentElement.classList.add("select");
         }
      });
      document.querySelector("#searchField").value = "";
   }
}