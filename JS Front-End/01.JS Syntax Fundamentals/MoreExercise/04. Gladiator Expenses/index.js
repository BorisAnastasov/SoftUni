function GladiatorExpen(fights, helmet, sword, shield, armor){
  let totalExp = Math.floor(fights/2)*helmet+Math.floor(fights/3)*sword+Math.floor(fights/6)*shield+Math.floor(fights/12)*armor;
  console.log(`Gladiator expenses: ${totalExp.toFixed(2)} aureus`);
}