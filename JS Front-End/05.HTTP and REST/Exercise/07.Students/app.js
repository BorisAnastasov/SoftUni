const submitBtn = document.querySelector("#submit")
const table = document.querySelector("tbody");
const student = {
  firstName: document.getElementsByName("firstName").value,
  lastName: document.getElementsByName("lastName").value,
  facultyNumber: document.getElementsByName("facultyNumber").value,
  grade: document.getElementsByName("grade").value,
}

function attachEvents() {

  printResult()
  submitBtn.addEventListener("click", submit)

}

function submit(e) {
  fetch("http://localhost:3030/jsonstore/collections/students", {
    method: 'post',
    body: JSON.stringify(student)
  })
  Object.values(student).forEach(x => x = "");
  printResult();
}

function printResult() {
  table.innerHTML = ``
  fetch("http://localhost:3030/jsonstore/collections/students")
    .then(res => res.json())
    .then(students => {
      for (const student of Object.values(students)) {
        const tr = document.createElement("tr");
        for (const [key, value] of Object.entries(student)) {
          const td = document.createElement("td");

          if (key === "grade") {
            td.textContent = Number(value).toFixed(2);
          } else {
            td.textContent = value;
          }

          tr.appendChild(td);
        }
        if (tr.innerHTML) {
          document.querySelector("#results tbody").appendChild(tr);
        }
      }
    })
}


attachEvents();