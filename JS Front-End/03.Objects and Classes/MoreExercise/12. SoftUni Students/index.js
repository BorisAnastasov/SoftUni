function softUniStudents(arr){
  let courses = {};
  for (let i = 0; i < arr.length; i++) {
    if(arr[i].includes(": ")){
      let tokens = arr[i].split(": ");
      let name = tokens[0];
      let capacity = Number(tokens[1]);
      if(!courses.hasOwnProperty(name)){
        courses[name] = {
          name,
          students: [],
          capacity,
          count: 0
        }
      } else{
        courses[name].capacity += capacity;
      }
    } else{
      let str = arr[i].split("] with email ");
      let tokens1 = str[0].split("[");
      let userName = tokens1[0];
      let credits = Number(tokens1[1]);
      let tokens2 = str[1].split(" joins ");
      let email = tokens2[0];
      let course = tokens2[1];
      let student = {
        userName,
        email,
        credits,
      }
      if(courses.hasOwnProperty(course)&&courses[course].capacity-courses[course].count>0){
        courses[course].students.push(student);
        courses[course].count++;
      }
    }
  }
  Object.keys(courses).sort((a, b)=>courses[b].count-courses[a].count).forEach((key)=>{
    console.log(`${key}: ${courses[key].capacity-courses[key].count} places left`);
    courses[key].students.sort((a, b)=> b.credits-a.credits).forEach(element => {
      console.log(`--- ${element.credits}: ${element.userName}, ${element.email}`);
    });
  })
}
softUniStudents(['JavaBasics: 2',
'user1[25] with email user1@user.com joins C#Basics',
'C#Advanced: 3',
'JSCore: 4',
'user2[30] with email user2@user.com joins C#Basics',
'user13[50] with email user13@user.com joins JSCore',
'user1[25] with email user1@user.com joins JSCore', 
'user8[18] with email user8@user.com joins C#Advanced',
'user6[85] with email user6@user.comjoins JSCore', 'JSCore: 2',
'user11[3] with email user11@user.com joins JavaBasics',
'user45[105] with email user45@user.com joins JSCore',
'user007[20] with email user007@user.com joins JSCore',
'user700[29] with email user700@user.com joins JSCore',
'user900[88] with email user900@user.com joins JSCore']
);