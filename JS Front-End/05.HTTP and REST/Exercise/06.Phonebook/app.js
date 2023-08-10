let phonebook = document.querySelector("#phonebook");
let loadButton = document.querySelector("#btnLoad");
let createButton = document.querySelector("#btnCreate");
let personInput = document.getElementById("person");
let phoneInput = document.getElementById("phone");
function attachEvents() {

    loadButton.addEventListener("click", load);
    createButton.addEventListener("click", create);

}
function load(e) {
    phonebook.innerHTML = "";

    fetch("http://localhost:3030/jsonstore/phonebook")
        .then(res => res.json())
        .then(res => Object.entries(res).forEach(([_, obj]) => {

            let li = document.createElement("li");
            li.textContent = `${obj.person}: ${obj.phone}`;
            let deleteBtn = document.createElement("button");
            deleteBtn.id = obj._id;
            deleteBtn.textContent = "Delete";
            deleteBtn.addEventListener("click", () => {
                fetch(`http://localhost:3030/jsonstore/phonebook/${deleteBtn.id}`, {
                    method: 'delete'
                })
                    .then(() => deleteBtn.parentElement.remove())
            })
            li.appendChild(deleteBtn)
            phonebook.appendChild(li)
        }))
}

function create(e) {
    fetch("http://localhost:3030/jsonstore/phonebook", {
        method: 'POST',
        body: JSON.stringify({
            "person": personInput.value,
            "phone": phoneInput.value
        })
    })
        .then(() => {
            personInput.value = "";
            phoneInput.value = "";
            load(e)
        })
}

attachEvents();