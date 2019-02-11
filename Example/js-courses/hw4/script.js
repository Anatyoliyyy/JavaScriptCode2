// 1
var generator = function (start, step) {
    start -= step;
    return function () {
       return start += step;
    }
}
var g1 = generator(0, 2);


var take = function (gen, x) {
    var res = [];
    for (var i = 0; i < x; i++) {
        res.push(gen());
    }
    return res;
}

console.log(take(g1, 5));





// 2
let characters = [{ 
    'name': 'barney', 
    'age': 36 
},
{ 
    'name': 'fred', 
    'age': 40 
},
{ 
    'name': 'scott', 
    'age': 45
},
{ 
    'name': 'tom', 
    'age': 42
}];

function pluck(arr, prop) {
    let p = arr.map(function(el){
        return el[prop];
    });
    return p;
}

console.log(pluck(characters, 'name'));