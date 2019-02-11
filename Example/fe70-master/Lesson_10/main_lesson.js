// $.ajax({
//     method: 'GET',
//     url: 'https://api.githusdfsdfb.com/users/sudden-man',
//     success: function (res) {
// $('#img').html(`
//     <img src="${res.avatar_url}">
// `)
//     },
//     error: function (error) {
//         console.log('ERROR');
//     }
// })

// $.get('https://api.github.com/users/sudden-man', function (res) {
//     $('#img').html(`
//         <img src="${res.avatar_url}">
//     `)
// })


// let p = $.get('https://api.giddthub.com/users/sudden-man');

// p
//     .then(r => {
//         console.log(r);
//     })
//     .catch(e => {
//         console.log('ERROR');
//     })



// let getUser = function (login) {
//     return $.get('https://api.github.com/users/' + login);
// }

// $('#getUser').click(function () {
//     let login = $('#login').val();
//     if (login) {
//         getUser(login)
//             .then(res => {
//                 renderUserData(res);
//             })
//             .catch(error => {
//                 let errorMessage = error.responseJSON.message;
//                 alert(errorMessage);
//             })
//         return;
//     }
// })

// let renderUserData = function (user, ) {
//     $('#user').html(`
//         <h1>${user.name}</h1>
//         <img width="200" src="${user.avatar_url}">
//     `)
// }