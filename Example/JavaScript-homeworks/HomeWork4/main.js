// ex 1
var f1 = function (start, step) {
    var a = -step;
    return function () {
        return a += step;
    }
}
var gen2 = f1(0, 2);
var take = function(gen2, x){
    var mass = [];
    for (let i = 0; i < x; i++){
        mass.push(gen2());
    }
    return mass;
}
console.log(take(gen2, 5));




