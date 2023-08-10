function pyramid(base, increment){
  let stone = 0;
  let marble = 0;
  let lapis = 0;
  let gold = 0;
  let height = 0; 
  while(base>0){
    height++;
    if(height%5===0){
      stone+=(base-2)**2;
      lapis += base**2-(base-2)**2;
    }
    else if(base**2===1||base**2===4){
      gold+=base**2;
    }
    else{
      stone+=(base-2)**2;
      marble += base*base-(base-2)**2;
    }
    base-=2;
  }
  stone*=increment;
  marble*=increment;
  lapis*=increment;
  gold*=increment;
  height*=increment;
  console.log(`Stone required: ${Math.ceil(stone)}`);
  console.log(`Marble required: ${Math.ceil(marble)}`);
  console.log(`Lapis Lazuli required: ${Math.ceil(lapis)}`);
  console.log(`Gold required: ${Math.ceil(gold)}`);
  console.log(`Final pyramid height: ${Math.floor(height)}`);
}
