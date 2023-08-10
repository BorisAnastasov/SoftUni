function deleteByEmail() {
    let input = document.getElementsByName("email")[0].value;
    let result = document.getElementById("result");
    let td = document.querySelectorAll("#customers tr td:nth-child(2)");
    for (let iterator of td) {
        if(input===iterator.textContent){
            let tr = iterator.parentNode;
            tr.parentNode.removeChild(tr);
            result.textContent = "Deleted";
            return;
        }
    }
    result.textContent = "Not found.";
}