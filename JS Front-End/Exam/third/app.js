const url = "http://localhost:3030/jsonstore/tasks"
const list = document.querySelector("#list");
let urlId = "http://localhost:3030/jsonstore/tasks"
const loadBtn = document.querySelector("#load-vacations")
const editBtn = document.querySelector("#edit-vacation")
const addBtn = document.querySelector("#add-vacation")


const inputFields = {
  name: document.querySelector("#name"),
  days: document.querySelector("#num-days"),
  date: document.querySelector("#from-date"),
}

const clearInputs = (data) => {
  Object.values(data).forEach(x => x.value = "")
}

function attachEvents() {
  loadBtn.addEventListener("click", load)
  addBtn.addEventListener("click", addFunc)
  editBtn.addEventListener("click", editFunc)
}

function load() {
  list.innerHTML = ""
  fetch(url)
    .then(res => res.json())
    .then(response => {
      Object.values(response).forEach(res => {
        const div = createElement({ tag: "div", className: ["container"] })
        const h2Name = createElement({ tag: "h2", textContent: res.name })
        const h3Date = createElement({ tag: "h3", textContent: res.date })
        const days = createElement({ tag: "h3", textContent: res.days })
        const changeBtn = createElement({
          tag: "button", className: ["change-btn"], textContent: "Change", buttonEven: {
            "click": () => {
              editBtn.disabled = false
              addBtn.disabled = true
              let data = {
                name: changeBtn.parentElement.querySelector("h2").textContent,
                date: changeBtn.parentElement.querySelectorAll("h3")[0].textContent,
                days: changeBtn.parentElement.querySelectorAll("h3")[1].textContent,
              }

              inputFields.name.value = data.name
              inputFields.date.value = data.date
              inputFields.days.value = data.days
              urlId += `/${changeBtn.id}`
              changeBtn.parentElement.remove()

            }
          }, attributes: { "id": res._id }
        })
        const doneBtn = createElement({
          tag: "button", className: ["done-btn"], textContent: "Done", attributes: { "id": res._id }, buttonEven: {
            "click": () => {
              fetch(url + `/${doneBtn.id}`, {
                method: 'delete'
              })
              load()
            }
          }
        })
        div.appendChild(h2Name)
        div.appendChild(h3Date)
        div.appendChild(days)
        div.appendChild(changeBtn)
        div.appendChild(doneBtn)

        list.appendChild(div)
      })
      editBtn.disabled = true
    })
}

function addFunc() {
  fetch(url, {
    method: 'post',
    body: JSON.stringify({
      name: inputFields.name.value,
      days: inputFields.days.value,
      date: inputFields.date.value
    })
  })
  load()
  clearInputs(inputFields)
}
function editFunc() {
  fetch(urlId, {
    method: 'put',
    body: JSON.stringify({
      name: inputFields.name.value,
      date: inputFields.date.value,
      days: inputFields.days.value,
    })
  })
  urlId = url
  load()
  editBtn.disabled = true
  addBtn.disabled = false

}
const createElement = ({ tag, textContent = '', value = '', className = [], attributes = {}, buttonEven = {} }) => {
  const e = document.createElement(tag)
  if (textContent) e.textContent = textContent
  if (value) e.value = value
  className.forEach(x => e.classList.add(x))
  for (const [key, value] of Object.entries(attributes)) {
    e.setAttribute(key, value)
  }
  for (const [key, value] of Object.entries(buttonEven)) {
    e.addEventListener(key, value)
  }
  return e
}

attachEvents();