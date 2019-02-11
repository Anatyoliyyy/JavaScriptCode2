var arr = prompt('Введите цвет телефона: ' )


if (arr === "black"){
    document.write('<img src ="img/black.png"></img>')
    var gb = prompt('Теперь введите память в гигабайтах : ')
    if (gb === "32"){
        alert('Цена : 500$')
    }
    else if (gb === "64"){
        alert('Цена : 1000$')
    }
    else if (gb === "128"){
        alert('Цена : 1500$')
    }
    else if(gb === null){
        alert('Возвращайтесь!')
    }
    else if(gb !== null && gb === ""){
        alert('Вы не ввели значение')
    }
    else{
        alert('Извините но телефона с такое памятью нету')
    }
}

else if (arr === "gold"){
    document.write('<img src ="img/gold.png"></img>')
    var gb = prompt('Теперь введите память в гигабайтах : ')
    if (gb === "32"){
        alert('Цена : 500$')
    }
    else if(gb === "64"){
        alert('Цена : 1000$')
    }
    else if(gb === "128"){
        alert('Цена : 1500$')
    }
    else if(gb === null){
        alert('Возвращайтесь!')
    }
    else if(gb !== null && gb === ""){
        alert('Вы не ввели значение')
    }
    else{
        alert('Извините но телефона с такое памятью нету')
    }
}
else if (arr === "silver"){
    document.write('<img src ="img/silver.png"></img>')
    var gb = prompt('Теперь введите память в гигабайтах : ')
    if (gb === "32"){
        alert('Цена : 500$')
    }
    else if(gb === "64"){
        alert('Цена : 1000$')
    }
    else if(gb === "128"){
        alert('Цена : 1500$')
    }
    else if(gb === null){
        alert('Возвращайтесь!')
    }
    else if(gb !== null && gb === ""){
        alert('Вы не ввели значение')
    }
    else{
        alert('Извините но телефона с такое памятью нету')
    }
}


else if(arr === null){
    alert('Возвращайтесь!')
}

// else if(gb !== null && gb !== ""){
//     alert('Вы не ввели значение')
// }

else{
    document.write('<img src ="img/default.png"></img>')
}



