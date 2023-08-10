function radioCrystal(arr){
  let disiredThickness = arr[0];
  for (let i = 1; i < arr.length; i++) {
    let thickness = arr[i];
    console.log(`Processing chunk ${thickness} microns`);
    while(thickness !== disiredThickness){
      if(Number.isInteger(thickness/4)&&Number.isInteger(thickness/4)>0&&thickness/4>=disiredThickness){
        let count = 0;
        while(Number.isInteger(thickness/4)>0&&thickness/4>=disiredThickness){
          count++;
          thickness = Math.floor(thickness/4);
        }
        console.log(`Cut x${count}`);
      }
      else if(Number.isInteger(thickness*8/10)&&Number.isInteger(thickness*8/10)>0&&thickness*8/10>=disiredThickness){
        let count = 0;
        while(Number.isInteger(thickness*8/10)>0&&thickness*8/10>=disiredThickness){
          count++;
          thickness = thickness*8/10;
        }
        console.log(`Lap x${count}`);
      }
      else if(thickness-20>=disiredThickness){
        let count = 0;
        while(thickness-20>=disiredThickness){
          count++;
          thickness -=20;;
        }
        console.log(`Grind x${count}`);
      }
      else if(thickness-2>=disiredThickness){
        let count = 0;
        while(thickness-2>=disiredThickness){
          count++;
          thickness -=2;;
        }
        if(thickness-2===disiredThickness-1){
          thickness--;
          count++;  
          console.log(`Etch x${count}`);
          console.log("Transporting and washing");
          thickness = Math.floor(thickness);
          console.log(`X-ray x1`);
          break;
        }
        else{
          console.log(`Etch x${count}`);
        }
      }
      thickness = Math.floor(thickness);
      console.log("Transporting and washing");
    }
    console.log(`Finished crystal ${disiredThickness} microns`)
  }
}
radioCrystal([1000, 4000, 8100]);