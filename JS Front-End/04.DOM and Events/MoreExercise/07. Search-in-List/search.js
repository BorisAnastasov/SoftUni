function search() {
   let result = document.querySelector("#result");
   let towns = document.querySelectorAll("#towns li");
   let input = document.querySelector("#searchText").value;
   let matches = 0;   
   result.textContent = "";  
   for (let i = 0; i < towns.length; i++) {
      towns[i].style.textDecoration = "none";
         towns[i].style.fontWeight = "normal";
      if(towns[i].innerText.includes(input)){   
         towns[i].style.textDecoration = "underline";
         towns[i].style.fontWeight = "bold";
         matches++;
      }
   }
   result.textContent = `${matches} matches found`;
}
