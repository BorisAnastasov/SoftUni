function addItem() {
    let list = document.getElementById("items");
    let input = document.getElementById("newItemText");

    let li = document.createElement("li");
    li.textContent=input.value;
    list.appendChild(li);
}