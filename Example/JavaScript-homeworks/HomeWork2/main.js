var memory;
var bill;
var memoryPrice;
var phone = {
    color: ['Black', 'Silver', 'Gold'],
    price: [100, 200, 300],
    colorPrice: [40, 55, 70],
    memory: [30, 60, 120]
};
output: while(true){
memory = prompt("Какая память телефона (30, 60, 120)?");
for(var i = 0; i < phone.memory.length; i++){
if(+memory === phone.memory[i]){
    document.write('Цена телефона с памятью ' + phone.memory[i] + " = " + phone.price[i] + '$');
    memoryPrice = phone.price[i];
    break output;
   
}
else if(memory === null){
    document.write('Пока!');
    break output;}
}
}
goend: while(memory !== null){
    color = prompt("Какой цвет телефона (Black, Silver, Gold)?");
    for(var i = 0; i < phone.color.length; i++){
    if(color === phone.color[i]){
        bill = memoryPrice + phone.colorPrice[i];
        document.write('<br>Цена телефона с цветом '+ phone.color[i] + ' = ' + bill  + '$');
        document.write('<img src="./img/' + color + '.png">');
        break goend;
    }
    else if(color === null){
        document.write('<br>До встречи!');
        document.write('<img src="./img/default.png" width=200px height = 200px> ');
        break goend;
    }
}
}

