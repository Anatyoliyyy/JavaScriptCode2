var phone = {
    color : ['black','gold','silver','blue','red'],
    memory : [32,64,128,256,512],
    price: [500,700,1000,1300,1500],
    priceColor: [50,100,200,300,400]
};
var q_color;
var q_memory;

outer_memory : while (true){
    q_memory = prompt('Введите память телефона в gb: ');
    for (var i = 0; i < phone.memory.length; i++){
        if (+q_memory === phone.memory[i]){
            var arr = phone.price[i];
            document.write('Цена без учета цвета: ' + phone.price[i] + '$' + "</br>");
            break outer_memory;
            }
        else if (q_memory === null) {
            alert('Возвращайтесь!')
            break outer_memory;
        }
    }
}

outer_color : while (q_memory !== null){
    q_color = prompt('Введите цвет телефона: ');
    for (var j = 0; j < phone.color.length; j++){
        if (q_color === phone.color[j]){
            var sum = arr + phone.priceColor[j];
            document.write('Цена с учетом цвета: ' + sum + '$');
            document.write('<img src="./img/' + q_color + '.png" width = "300">');
            break outer_color;
        }
        else if (q_color === null){
            document.write('<img src="./img/default.png">');
            break outer_color;
        }
    }
 }