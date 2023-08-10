function addItem() {
  let list = document.getElementById("items");
  let input = document.getElementById("newItemText").value;

  let listItem = document.createElement("li");
  let remove = document.createElement("a");
  let text = document.createTextNode("[Delete]");
 
  remove.appendChild(text);
  remove.href = "#";
  remove.addEventListener("click", deleteItem);


  listItem.textContent = input;

  listItem.appendChild(remove);

  list.appendChild(listItem);
  function deleteItem() {
    listItem.remove();
  }
}