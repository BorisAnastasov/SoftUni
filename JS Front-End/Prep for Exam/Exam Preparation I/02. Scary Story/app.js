window.addEventListener("load", solve)

function solve() {

























  // const inputFields = {
  //   firstName: document.querySelector('#first-name'),
  //   lastName: document.querySelector('#last-name'),
  //   age: document.querySelector('#age'),
  //   title: document.querySelector('#story-title'),
  //   genre: document.querySelector('#genre'),
  //   story: document.querySelector('#story'),
  // }
  // if (Object.values(inputFields).some((sel) => sel.value === "")) {
  //   return;
  // }
  // const storyApp = {
  //   publishButton: document.querySelector('#form-btn'),
  //   preview: document.querySelector('#preview-list'),
  //   saveStory: document.querySelector('#main'),
  // }

  // let savedData = [];

  // const createElement = ({ tag, textContent = '', value = '', className = [], attributes = {}, buttonEven = {} }) => {
  //   const e = document.createElement(tag)
  //   if (textContent) e.textContent = textContent
  //   if (value) e.value = value
  //   className.forEach(x => e.classList.add(x))
  //   for (const [key, value] of Object.entries(attributes)) {
  //     e.setAttribute(key, value)
  //   }
  //   for (const [key, value] of Object.entries(buttonEven)) {
  //     e.addEventListener(key, value)
  //   }
  //   return e
  // }

  // function publishBtnFunctionality(e) {
  //   const li = createElement({ tag: "li", className: ["story-info"] })
  //   const article = createElement({ tag: "article" });
  //   article.appendChild(createElement({ tag: "h4", textContent: `Name: ${inputFields.firstName.value} ${inputFields.lastName.value}` }))
  //   article.appendChild(createElement({ tag: "p", textContent: `Age: ${inputFields.age.value}` }))
  //   article.appendChild(createElement({ tag: "p", textContent: `Title: ${inputFields.title.value}` }))
  //   article.appendChild(createElement({ tag: "p", textContent: `Genre: ${inputFields.genre.value}` }))
  //   article.appendChild(createElement({ tag: "p", textContent: inputFields.story.value }))

  //   li.appendChild(article)
  //   li.appendChild(createElement({ tag: "button", textContent: "Save Story", className: ["save-btn"], buttonEven: { "click": saveBtnFunctionality } }))
  //   li.appendChild(createElement({ tag: "button", textContent: "Edit Story", className: ["edit-btn"], buttonEven: { "click": editBtnFunctionality } }))
  //   li.appendChild(createElement({ tag: "button", textContent: "Delete Story", className: ["delete-btn"], buttonEven: { "click": deleteBtnFunctionality } }))
  //   storyApp.publishButton.disabled = true


  // }

  // const saveBtnFunctionality = () => {
  //   storyApp.saveStory.innerHTML = ''
  //   storyApp.saveStory.appendChild(createElement({ tag: 'h1', textContent: 'Your scary story is saved!' }))
  // }

  // const editBtnFunctionality = () => {
  //   storyApp.preview.innerHTML = ""
  //   storyApp.publishButton.disabled = false
  //   let i = 0;
  //   for (const key of Object.keys(inputFields)) {
  //     inputFields[key] = savedData[i];
  //     i++;
  //   }
  // }

  // const deleteBtnFunctionality = () => {
  //   storyApp.preview.innerHTML = ""
  //   storyApp.publishButton.disabled = false
  // }

  // storyApp.publishButton.addEventListener("click", function () { publishBtnFunctionality })

}
