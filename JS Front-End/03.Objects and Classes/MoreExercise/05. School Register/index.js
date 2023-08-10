function schoolRegister(arr){
  let register = {};
  for (let i = 0; i < arr.length; i++) {
    let tokens = arr[i].split(", ");
    let name = tokens[0].split(": ").pop();
    let grade = Number(tokens[1].split(": ").pop());
    let averScore = Number(tokens[2].split(": ").pop());
    if(averScore>=3){
      if(register.hasOwnProperty(grade)){
        register[grade].Students.push(name);
        register[grade].Scores.push(averScore);
      }
      else{
        register[grade] = {
           Students: [],
           Scores: []
        }
        register[grade].Students.push(name);
        register[grade].Scores.push(averScore);
      }
    }      
  }
  Object.keys(register).sort((k1, k2)=>k1>k2).forEach(element => {
    console.log(`${Number(element)+1} Grade`);
    console.log(`List of students: ${register[element].Students.join(", ")}`);
    let sum = register[element].Scores.reduce(
      (acum, curr)=>acum+curr, 0);
    console.log(`Average annual score from last year: ${(sum/register[element].Students.length).toFixed(2)}`);
    console.log();
  });
}
schoolRegister([
  "Student name: Mark, Grade: 8, Graduated with an average score: 4.75",
   "Student name: Ethan, Grade: 9, Graduated with an average score: 5.66",
   "Student name: George, Grade: 8, Graduated with an average score: 2.83",
   "Student name: Steven, Grade: 10, Graduated with an average score: 4.20",
   "Student name: Joey, Grade: 9, Graduated with an average score: 4.90",
   "Student name: Angus, Grade: 11, Graduated with an average score: 2.90",
   "Student name: Bob, Grade: 11, Graduated with an average score: 5.15",
   "Student name: Daryl, Grade: 8, Graduated with an average score: 5.95",
   "Student name: Bill, Grade: 9, Graduated with an average score: 6.00",
   "Student name: Philip, Grade: 10, Graduated with an average score: 5.05",
   "Student name: Peter, Grade: 11, Graduated with an average score: 4.88",
   "Student name: Gavin, Grade: 10, Graduated with an average score: 4.00"
  ])