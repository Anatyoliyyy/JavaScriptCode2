/*var arr = Array(3, 5, -3, 6, 143, 7, 12, -87, 54, 32, -78, 5, 43);
1. Поиска найбольшего значения массива
2. Поиска найменьшего значения массива
3. Сумма всех элеменов масива
4. Среднее арифметическое*/

var arr = Array(3, 5, -3, 6, 143, 7, 12, -87, 54, 32, -78, 5, 43);

/*var max = Math.max.apply(Math, arr)
console.log(max)

var min = Math.min.apply(Math, arr)
console.log(min)*/

var max = getMaxValue(arr);
var min = getMinValue(arr);
alert(max);
alert(min);

console.log(max);
console.log(min);

// №1
function getMaxValue(arr){
    var max = arr[0];
    for (var i = 0; i < arr.length; i++) {
        if (max < arr[i]) max = arr[i]; 
    }
    return (max);
    
}

// №2
function getMinValue(arr){
    var min = arr[0];
    for (var i = 0; i < arr.length; i++) {
        if (min > arr[i]) min = arr[i];
    }
    return min;

}

// №3
function arraySum(arr){
var sum = 0;
    for(var i = 0; i < arr.length; i++){
        sum += arr[i];
    }
    return sum;
}
arraySum(arr);

// №4

var arr = [], count = 0, element;
while (element = prompt ("Введите числовой элемент массива номер " + count + ". Используйте точку для дробей. Для завершения нажмите «отмена» или оставьте поле пустым")) {
    arr.push(element);
    count++;
}
alert("Для массива " + arr + " среднее арифметическое равно " + average(arr));


function average(arr) {
    var
        x, correctFactor = 0,
        sum = 0
    ;
    for (x = 0; x < arr.length; x++) {
        arr[x] = +arr[x];
        if (!isNaN(arr[x])) {
            sum += arr[x];
        } else {
            correctFactor++;
        }
    }
    return (sum / (arr.length - correctFactor)).toFixed(2);
}