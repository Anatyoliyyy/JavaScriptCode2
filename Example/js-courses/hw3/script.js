var num1 = +prompt('Значение?');
var mark = prompt('Знак?');
var num2 = +prompt('Значение?');


function count(num1, num2, mark) {
    switch (mark) {
      case "*":
        return num1 * num2;
      case "+":
        return num1 + num2;
      case "-":
        return num1 - num2;
      case "/":
        return num1 / num2;
    }
}


var func = count(num1, num2, mark);

if(isNaN(func)){
  alert('Вы ввели некоректные данные!!');
}
else if (num2 == 0) {
  alert('На ноль делить нельзя!');
}
else{
  alert(count(num1, num2, mark));
}