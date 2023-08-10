function sumTable() {
  let numbers = Array.from(document.querySelectorAll("td:nth-child(2)"));
  let total = numbers.reduce((acc, curr)=>{
    return acc+Number(curr.textContent);
  }, 0);
  document.getElementById("sum").textContent = total;
}