function store(arrStock, arrOrder){
  let quantityList = {};
  for (let i = 0; i < arrStock.length; i+=2) {
    let product = arrStock[i];
    let quantity = Number(arrStock[i+1]);
    quantityList[product] = quantity;
  }
  for (let i = 0; i < arrOrder.length; i+=2) {
    let product = arrOrder[i];
    let quantity = Number(arrOrder[i+1]);
      if(!quantityList.hasOwnProperty(product)){
        quantityList[product] = quantity;
      }
      else{ 
        quantityList[product] += quantity;
      }
  }
  for (const key in quantityList) {
    console.log(`${key} -> ${quantityList[key]}`)
  }
}