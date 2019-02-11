var img = 'black.png';
document.write('<img src="../img/' + img + '" alt="">');

var x = 0;
while (x < 10) {
    console.log(x);
    x++;
}
console.log('!!!');


var i = 0;
while (i < 10) {
    i++;
    if (i === 5) {
        continue;
    }
    console.log(i);
}


var i = 20;
do {a
    console.log(i);
} while (i < 10);
while (i < 10) {
    console.log(i);
}

var j = 0;
while (j < 10) {
    console.log(j);
    j++;
}

for (var i = 0; i < 10; i++) {
    console.log(i);
}

var arr = [3, 5, -3, {}, 143, true, '12'];
var arr2 = new Array(3, 5, -3, {}, 143, true, '12');

var arr = [5];
var arr2 = new Array(5);


var arr = [3, 5, -3, 6, 143, 7, 12, -87, 54];
console.log(arr);
console.log(arr[2]);
console.log(arr[20]);
arr[2] = 'NEW DATA';
console.log(arr[2]);
arr[20] = 'NEW 20';
console.log(arr);


var chosenKey = 'name';
var user1 = {
    email: 'link@gmail.com',
    name: 'Link',
    age: 50
}
var user2 = {
    email: 'sara@gmail.com',
    name: 'Sara',
    age: 30
}

console.log(user1['' + chosenKey + '']);
console.log(user1[chosenKey]);


console.log(user.email);
console.log(user['мое имя ))))']);

var users = [{
        email: 'link@gmail.com',
        name: 'Link',
        age: 50
    },
    {
        email: 'sara@gmail.com',
        name: 'Sara',
        age: 30
    }
]


for (var i = 0; i < 2; i++) {
    console.log(i, users[i].email);
}

var colors = [{
        name: 'black',
        img: 'black.png',
        k: 20
    },
    {
        name: 'silver',
        img: 'silver.png',
        k: 0
    },
    {
        name: 'gold',
        img: 'gold.png',
        k: 30
    }
];
var memories = [{
        val: 128,
        price: 600
    },
    {
        val: 256,
        price: 800
    },
    {
        val: 512,
        price: 1000
    }
];

var color, memory;
var img = 'default.png';
var price = 0;

do {
    color = prompt('Color ?');
} while (color !== 'black' || color !== 'silver');


color: while (true) {
    color = prompt('Color ?');
    if (color === null) {
        alert('Пока!');
        break;
    }
    for (var i = 0; i < colors.length; i++) {
        if (colors[i].name === color) {
            img = colors[i].img;
            price = price + colors[i].k;
            price += colors[i].k;
            break color;
        }
    }
}

memory: while (color) {
    memory = prompt('Memory ?');
    if (memory === null) {
        alert('Пока!');
        break;
    }
    for (var i = 0; i < memories.length; i++) {
        if (memories[i].val === +memory) {
            price += memories[i].price;
            break memory;
        }
    }
}
document.write('<img width=200" src="../img/' + img + '">');
document.write('<h2>Price: ' + price + '$</h2>');



var arr = [3, 5, -3, 6, 143, 7, 12, -87, 54, 32, -78, 5, 43];

var min = arr[0];
var max = arr[0];
var sum = 0;
var avg = 0;

for (var i = 0; i < arr.length; i++) {
    if (arr[i] < min) min = arr[i];
    if (arr[i] > max) max = arr[i];
    sum += arr[i];
}
avg = sum / arr.length;
console.log(min, max, sum, avg);





var arr = [3, 5, -3, 6, 143, 7, 12, -87];
console.log(arr);
var x = arr.push(7, 12, -87);
var x = arr.pop();
var x = arr.unshift('NEW');
var x = arr.shift();
document.write(arr.join(' | '));
var x = arr.slice(2, 5);
var x = arr.splice(2, 5);
var x = arr.splice(2, 0, 'new -3', 'new 6', 'new 143');
var x = arr.concat([7, 12, -87]);
console.log(x);
console.log(arr);