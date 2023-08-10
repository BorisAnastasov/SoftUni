window.addEventListener('load', solve);


function solve() {
    //getting the data    
    const container = document.querySelector("div.all-hits-container")
    const addBtn = document.querySelector("#add-btn");


    const inputFields = {
        genre: document.querySelector("#genre"),
        name: document.querySelector("#name"),
        author: document.querySelector("#author"),
        date: document.querySelector("#date"),
    }

    function chechInputs(input) {
        if (Object.values(input).some(sel => sel.value === "")) {
            return false;
        } else {
            return true;
        }
    }


    function likeFunc(e) {
        const likes = document.querySelector("#total-likes .likes p");
        let text = likes.textContent
        let count = Number(text.split(" ").pop());
        count++;
        likes.textContent = `Total Likes: ${count}`
        e.target.disabled = true
    }

    function saveFunc() {
        const div = document.querySelector(".saved-container")
        const cont = document.querySelector(".all-hits-container div");
        const save = cont.querySelector(".save-btn")
        save.remove()
        const lik = cont.querySelector(".like-btn")
        lik.remove()
        div.appendChild(cont)
        container.removeChild(document.querySelector(".saved-container"))

    }

    function deleteFunc(e) {
        e.target.parentElement.remove();
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

    addBtn.addEventListener("click", () => {
        if (chechInputs(inputFields)) {
            const div = createElement({ tag: "div", className: ["hits-info"] })
            const img = createElement({ tag: "img" })
            img.src = `./static/img/img.png`
            const h2Genre = createElement({ tag: "h2", textContent: `Genre: ${inputFields.genre.value}` })
            const h2Name = createElement({ tag: "h2", textContent: `Name: ${inputFields.name.value}` })
            const h2Author = createElement({ tag: "h2", textContent: `Author: ${inputFields.author.value}` })
            const h2Date = createElement({ tag: "h3", textContent: `Date: ${inputFields.date.value}` })
            const saveBtn = createElement({ tag: "button", textContent: "Save song", className: ["save-btn"], buttonEven: { "click": saveFunc } })
            const likeBtn = createElement({ tag: "button", textContent: "Like song", className: ["like-btn"], buttonEven: { "click": likeFunc } })
            const deleteBtn = createElement({ tag: "button", textContent: "Delete", className: ["delete-btn"], buttonEven: { "click": deleteFunc } })
            div.appendChild(img)
            div.appendChild(h2Genre)
            div.appendChild(h2Name)
            div.appendChild(h2Author)
            div.appendChild(h2Date)
            div.appendChild(saveBtn)
            div.appendChild(likeBtn)
            div.appendChild(deleteBtn)
            container.appendChild(div)
            Object.values(inputFields).forEach(x => x = "")
        }
    })
}