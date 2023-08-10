function validate() {
    let input = document.getElementById("email");
    input.addEventListener("change",(e)=>{
        if(/^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/.test(e.target.value)){
            input.removeAttribute("class");
        } else{
            input.setAttribute("class", "error");
        }
    })
}
