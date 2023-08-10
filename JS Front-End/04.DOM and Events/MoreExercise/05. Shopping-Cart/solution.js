function solve() {
  let textarea = document.querySelector(".shopping-cart textarea");
  let buttonAdd = Array.from(document.querySelectorAll(".product .add-product"));
  let sum = 0;
  let listOfProducts = [];
  buttonAdd.forEach(button=>{
    button.addEventListener("click", add);
  })
  
  let checkout = document.querySelector(".shopping-cart .checkout");
  checkout.addEventListener("click", checkFunc);
  
  function checkFunc(){
    textarea.textContent+=`You bought ${listOfProducts.join(", ")} for ${sum.toFixed(2)}.`;
    checkout.removeEventListener("click" , checkFunc);
    buttonAdd.forEach(button=>{
    button.removeEventListener("click", add);
  })
  }
  function add(e){
    let price = Number(e.target.parentElement.parentElement
    .querySelector(".product-line-price").innerText);
    
    let name = e.target.parentElement.parentElement
    .querySelector(".product-title").innerText;
    sum += price;
    if(!listOfProducts.includes(name)){
          listOfProducts.push(name);
    }
    textarea.textContent+=(`Added ${name} for ${price.toFixed(2)} to the cart.\n`);
  } 
}

