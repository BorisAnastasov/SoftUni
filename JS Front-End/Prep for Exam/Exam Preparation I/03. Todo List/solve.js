const url = 'http://localhost:3030/jsonstore/tasks'
const loadBtn = document.querySelector("#load-button");
const addBtn = document.querySelector("#add-button");
const list = document.querySelector("#todo-list");
const title = document.querySelector("#title");


function attachEvents() {

  loadBtn.addEventListener("click", load)
  addBtn.addEventListener("click", add)

}
function load(e) {
  if (e) {
    e.preventDefault();
  }
  list.innerHTML = ""
  fetch(url)
    .then(res => res.json())
    .then((res) => {
      Object.values(res).forEach(({ name, _id }) => {
        let li = document.createElement("li");
        let span = document.createElement("span");
        let removeBtn = document.createElement("button");
        let editBtn = document.createElement("button");
        span.textContent = name;
        removeBtn.textContent = "Remove";
        removeBtn.id = _id;
        removeBtn.addEventListener("click", deleteFunc)
        editBtn.textContent = "Edit";
        editBtn.id = _id;
        editBtn.addEventListener("click", editToSubmit)
        li.appendChild(span)
        li.appendChild(removeBtn)
        li.appendChild(editBtn)
        list.appendChild(li);
      });
    })

}

function add(e) {
  e.preventDefault();
  if (typeof title.value !== "string" || title.value.length <= 3) {
    return;
  }
  fetch("http://localhost:3030/jsonstore/tasks/", {
    method: "post",
    body: JSON.stringify({
      name: title.value
    })
  }).then(() => load(e))

}

function deleteFunc(e) {
  fetch(`${url}/${e.target.id}`, {
    method: "delete"
  }).then(() => load(e))
}

function editToSubmit(e) {
  const parent = e.target.parentElement;
  parent.innerHTML = `<input value = ${parent.querySelector("span").textContent}>
    <button id=${e.target.id} class="remove-button">Remove</button>
    <button id=${e.target.id} class="submit-button">Submit</button>`;
  parent.querySelector(".remove-button").addEventListener("click", deleteFunc);
  parent.querySelector(".submit-button").addEventListener("click", submitToEdit);
}

function submitToEdit(e) {
  const input = e.target.parentElement.querySelector("input").value;
  fetch(`http://localhost:3030/jsonstore/tasks/${e.target.id}`, {
    method: 'put',
    body: JSON.stringify({ name: input })
  }).then(() => load(e))
}

attachEvents();
