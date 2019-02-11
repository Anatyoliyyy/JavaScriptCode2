// Асинхронная операция
function cookBurger (type) { ... }  

// Обычная операция
function makeMilkshake (type) { ... }

// Функция оформления заказа, возвращает промис
function order (type) {   
   return new Promise(function(resolve, reject) {
      var burger = cookBurger(type)
      burger.ready = function (err, burger) {
         if (err) {
            return reject(Error('Error while cooking'))
         }
         return resolve(burger)
      }
   })
}

order('JakeBurger')
.then( burger => {
    const milkshake = makeMilkshake('vanila')
    const foodItems = { burger: burger, shake: milkshake }
    console.log('BURGER PARTY !', foodItems)
    return foodItems;
})
.catch( err => {
    console.log(err)   
   })