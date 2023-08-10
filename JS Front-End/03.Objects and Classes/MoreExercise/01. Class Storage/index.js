class Storage{
  constructor(capacity){
    this.capacity = capacity;
    this.storage = [];
    this.totalCost = 0;
  }
  addProduct(product){
    if(this.storage.length+1<=this.capacity){
      this.storage.push(product);
    }
    this.totalCost+=product.price*product.quantity;
    this.capacity-=product.quantity;
  }
  getProducts(){
    let output = "";
    this.storage.forEach(element => {
      let js = JSON.stringify(element);
      output+=`${js}\n`
    });
    output = output.replace(/\n$/, "");
    return output;
  }
}