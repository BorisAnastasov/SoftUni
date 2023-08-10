function create(words) {
   for (let i = 0; i < words.length; i++) {
      let content = document.getElementById("content");
      let div = document.createElement("div");
      let p = document.createElement("p");
      
      let inside = document.createTextNode(words[i]);
      p.appendChild(inside);
      div.appendChild(p);
      p.style.display = "none";
      div.addEventListener("click", myFunction);
      content.appendChild(div);
      function myFunction(){
         p.style.display = "block";
       };
   }
   
   
}