function generateReport() {
    let ths = document.querySelectorAll("thead tr th");
    let nths = [];
    let result = [];
    for (let i = 0; i < ths.length; i++) {
        const element = ths[i];
        let input = element.querySelector("input");
        if(input.checked){
            nths.push(i+1);
        }
    }
    let trs = document.querySelectorAll("tbody tr");
    for (let z = 0; z < trs.length; z++) {
        let obj = {};
        for (let i = 0; i < nths.length; i++) {
         let type = document.querySelector(`thead tr th:nth-child(${nths[i]})`).textContent.toLowerCase().trim();
         let value = document.querySelector(`tbody tr:nth-child(${z+1}) td:nth-child(${nths[i]})`).textContent;
         if (/^\d+$/.test(value)) {
           value = parseInt(value);
        }
        obj[type] = value;
        }
        result.push(obj);
    } 
    document.getElementById("output").value = JSON.stringify(result, null, 2);
}