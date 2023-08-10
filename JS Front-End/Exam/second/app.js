window.addEventListener("load", solve);

function solve() {

  const preview = document.querySelector("#preview-list");
  const candidate = document.querySelector("#candidates-list")
  const inputFields = {
    name: document.querySelector("#student"),
    university: document.querySelector("#university"),
    score: document.querySelector("#score")
  }

  const nextBtn = document.querySelector("#next-btn");
  nextBtn.addEventListener("click", nextFunc)

  const clearInputs = (data) => {
    Object.values(data).forEach(x => x.value = "")
  }

  function nextFunc(e) {
    if (Object.values(inputFields).some(x => x.value === "")) {

    } else {
      const li = createElement({ tag: "li", className: ["application"] })
      const artcile = createElement({ tag: "article" })
      const h4 = createElement({ tag: "h4", textContent: inputFields.name.value })
      const pUnev = createElement({ tag: "p", textContent: `University: ${inputFields.university.value}` })
      const pScore = createElement({ tag: "p", textContent: `Score: ${inputFields.score.value}` })
      const editBtn = createElement({ tag: "button", textContent: "edit", className: ["action-btn", "edit"], buttonEven: { "click": edit } })
      const applyBtn = createElement({ tag: "button", textContent: "apply", className: ["action-btn", "apply"], buttonEven: { "click": apply } })
      artcile.appendChild(h4)
      artcile.appendChild(pUnev)
      artcile.appendChild(pScore)

      li.appendChild(artcile)
      li.appendChild(editBtn)
      li.appendChild(applyBtn)

      preview.appendChild(li)
      nextBtn.disabled = true;
      clearInputs(inputFields)
    }

  }
  function edit(e) {
    nextBtn.disabled = false
    let data = {
      name: e.target.parentElement.querySelector("article h4").textContent,
      university: e.target.parentElement.querySelectorAll("article p")[0].textContent.split(" ").pop(),
      score: e.target.parentElement.querySelectorAll("article p")[1].textContent.split(" ").pop()
    }
    inputFields.name.value = data.name
    inputFields.university.value = data.university
    inputFields.score.value = data.score
    e.target.parentElement.remove()
  }

  function apply(e) {
    let data = {
      name: e.target.parentElement.querySelector("article h4").textContent,
      university: e.target.parentElement.querySelectorAll("article p")[0].textContent.split(" ").pop(),
      score: e.target.parentElement.querySelectorAll("article p")[1].textContent.split(" ").pop()
    }
    const li = createElement({ tag: "li", className: ["application"] })
    const artcile = createElement({ tag: "article" })
    const h4 = createElement({ tag: "h4", textContent: data.name })
    const pUnev = createElement({ tag: "p", textContent: `University: ${data.university}` })
    const pScore = createElement({ tag: "p", textContent: `Score: ${data.score}`, className: ["sc"] })
    artcile.appendChild(h4)
    artcile.appendChild(pUnev)
    artcile.appendChild(pScore)

    li.appendChild(artcile)

    candidate.appendChild(li)
    nextBtn.disabled = false;
    e.target.parentElement.remove()
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
}



