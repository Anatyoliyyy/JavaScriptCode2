 var memory = prompt("Какая память телефона (30, 60, 120)?");
if (+memory === 30){
    document.write("Цена телефона = 100$");
}
else if (+memory === 60){
    document.write("Цена телефона = 200$");
}
else if (+memory === 120){
    document.write("Цена телефона = 300$");
}
else{
    alert("Выберите только 30, 60 или 120");
    memory = prompt("Какая память телефона (30, 60, 120)?");
}
var color = prompt("Выберите цвет (black, gold, silver).");
if (color === null){
    document.write("<br> Пока!");
}
else{
document.write('<img src="./img/' + color + '.png">');
}