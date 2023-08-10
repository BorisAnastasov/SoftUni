function lockedProfile() {
    let buttons = Array.from(document.querySelectorAll("button"))
    buttons.forEach(button=>{
        button.addEventListener("click", (e)=>{
            let lockedRadio = e.currentTarget.parentElement.querySelector("input[type='radio']");//first one
            if(!lockedRadio.checked && e.currentTarget.textContent === "Show more"){
              e.currentTarget.textContent = "Hide it";
              let div = e.currentTarget.parentElement.querySelector("#user1HiddenFields");
              div.style.display = "block";
            } else if(!lockedRadio.checked&&e.currentTarget.textContent === "Hide it"){
                e.currentTarget.textContent = "Show more";
                let div = e.currentTarget.parentElement.querySelector("#user1HiddenFields");
              div.style.display = "none";
            }
        })
    })
}