

const loadBtn = document.querySelector("#load-product");
loadBtn.addEventListener("click", load)

const addBtn = document.querySelector("#add-product");
const input = {
  product: document.querySelector("#product"),
  count: document.querySelector("#count"),
  price: document.querySelector("#price")
}
addBtn.addEventListener("click", addFunc)

const tbody = document.createElement("tbody")
document.querySelector("table").appendChild(tbody)

const updateProdBtn = document.querySelector("#update-product")

function load(e) {
  if (e) {
    e.preventDefault()
  }
  tbody.innerHTML = ""
  fetch("http://localhost:3030/jsonstore/grocery")
    .then(res => res.json())
    .then(res => {
      Object.values(res).forEach((obj) => {
        const tr = createElement({ tag: "tr" });
        const tdName = createElement({ tag: "td", textContent: obj.product, className: ["name"] })
        const tdCount = createElement({ tag: "td", textContent: obj.count, className: ["count-product"] })
        const tdPrice = createElement({ tag: "td", textContent: obj.price, className: ["product-price"] })
        const tdBtn = createElement({ tag: "td", className: ["btn"] })
        const delBtn = createElement({
          tag: "button", textContent: "Delete", className: ["delete"], attributes: { "id": obj._id }, buttonEven: {
            "click": (deleteFunc, { once: true })
          }
        })
        const updateBtn = createElement({
          tag: "button", textContent: "Update", className: ["update"], attributes: { "id": obj._id }, buttonEven: {
            "click": updateFunc
          }
        }

        )

        tdBtn.appendChild(delBtn)
        tdBtn.appendChild(updateBtn)

        tr.appendChild(tdName)
        tr.appendChild(tdCount)
        tr.appendChild(tdPrice)
        tr.appendChild(tdBtn)

        tbody.appendChild(tr)
      })
    })

}

function addFunc(e) {
  if (Object.values(input).some(x => x.value === "")) {
    return
  }
  fetch("http://localhost:3030/jsonstore/grocery", {
    method: 'post',
    body: JSON.stringify({
      product: input.product.value,
      count: input.count.value,
      price: input.price.value
    })
  })
  load(e)
}

function updateProductFunc(e) {
  fetch(`http://localhost:3030/jsonstore/grocery/${e.currentTarget.id}`, {
    method: 'put',
    body: JSON.stringify({
      product: input.product.value,
      count: input.count.value,
      price: input.price.value,
      _id: e.currentTarget.id
    })
  })
  Object.values(input).forEach(x => x.value = "")
  updateProdBtn.disabled = true
  addBtn.disabled = false
  load();

}

function updateFunc(e) {
  if (e) {
    e.preventDefault()
  }
  fetch(`http://localhost:3030/jsonstore/grocery/${e.target.id}`)
    .then(res => res.json())
    .then(res => {
      Object.entries(res).forEach(([w, value]) => {
        if (w === "product") {
          input.product.value = value;
        } else if (w === "count") {
          input.count.value = value;
        } else if (w === "price") {
          input.price.value = value;
        }

      })
    })
  updateProdBtn.disabled = false
  addBtn.disabled = true;
  updateProdBtn.addEventListener("click", updateProductFunc)
  load()
}

function deleteFunc(e) {
  fetch(`http://localhost:3030/jsonstore/grocery/${e.target.id}`, {
    method: "delete"
  })
  load();
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