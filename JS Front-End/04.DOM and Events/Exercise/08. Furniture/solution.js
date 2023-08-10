function solve() {
  const generate = document.querySelector("#exercise button");
  const table = document.querySelector(".table tbody");

  generate.addEventListener("click", addItems);
  function addItems(){
    const items = JSON.parse(document.querySelector("#exercise textarea").value);
    items.map(furniture=>{
      const row = document.createElement("tr");
      const image = document.createElement("img");
      const input = document.createElement("input");

      input.setAttribute("type", "checkbox");
      input.setAttribute("value", "disabled");
      image.src = furniture.img;
      
      row.innerHTML+=`<td>${image.outerHTML}</td>`+
      `<td>${furniture.name}</td>`+
      `<td>${furniture.price}</td>`+
      `<td>${furniture.decFactor}</td>`+
      `<td>${input.outerHTML}</td>`;
      return row;

    }).forEach(element => table.appendChild(element));
  }
  const buyButton = document.querySelector("#exercise button:nth-of-type(2)");
  buyButton.addEventListener("click", buy());
  function buy(){
    let tds = document.querySelectorAll("#exercise tr td:nth-child(5)");
    tds = tds.filter(td=>td.firstChild.checked ===true);
    const listOfFurnitures = [];
    tds.forEach(td => {
      listOfFurnitures.push(td.parentElement.querySelector("td:nth-child(2)"));
    });
    const textarea = document.querySelector("#exercise textarea:nth-child(2)");
    textarea.innerHTML+=`Bought furniture: ${listOfFurnitures.join(", ")}`;
    let totalPrice = tds.reduce((total, curr)=>{
      const val = curr.parentElement.querySelector("td:nth-child(3)");
      return total+val;
    },0);
    let averDec = tds.reduce((total, curr)=>{
      const val = curr.parentElement.querySelector("td:nth-child(4)");
      return total+val;
    },0)/tds.length;
    textarea.innerHTML+=`Total price: ${totalPrice}`;
    textarea.innerHTML+=`Average decoration factor: ${averDec}`;
  }

}