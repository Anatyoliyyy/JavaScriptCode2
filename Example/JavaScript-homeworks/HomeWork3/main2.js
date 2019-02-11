var result,
    num1,
    num2,
    sign;
var mistake = false;
var calc = function(){
    num1 = prompt("Первое число?");
    num2 = prompt("Второе число?");
    sign = prompt("Выберите действие: *, +, /, -");
    if (!num1 || !num2){ 
        mistake = true;
    }
    else{
        switch(sign){
            case '*':
            return +num1 * +num2;
            break;
    
            case '+':
            return +num1 + +num2;
            break;
    
            case '/':
            return +num1 / +num2;
            break;
    
            case '-':
            return  +num1 - +num2;
            break;
            default:
            mistake = true;
        }
    }
}
result = calc();
if (mistake || isNaN(result)){
    document.write("Введены некорректные значения!");
}
else{
    document.write("Ваш результат = " + result);
}
