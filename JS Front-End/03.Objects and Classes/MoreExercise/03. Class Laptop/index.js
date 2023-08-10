class Laptop{
  constructor(info, quality){
    this.info = info;
    this.isOn = false;
    this.quality = quality;
  }
  turnOn(){
    this.isOn = true;
    this.quality--;
  }
  turnOff(){
    this.isOn = false;
    this.quality--;
  }
  showInfo(){
    let str = JSON.stringify(this.info);
    return str;
  }
  get price(){
   let sum = 800-(this.info.age*2)+(this.quality*0.5);
   return sum;
  }
}