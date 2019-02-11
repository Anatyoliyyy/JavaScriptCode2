// var x = 12;
// while (x < 10) {
//     // x = x + 1;
//     x++;
//     console.log(x);
// }

// do {
//     x++;
//     console.log(x);
// } while (x < 10)

// var i = 0;
// while (i < 5) {
//     console.log(i);
//     i++;
// }
// console.log('------------');
// for (var i = 0; i < 5; i++) {
//     console.log(i);
// }


// var model;
// var price = 0;

// while (true) {
//     model = prompt('Model');
//     if (model === 'nokia') {
//         price = 200;
//         break;
//     }
//     if (model === 'iphone') {
//         price = 500;
//         break;
//     }
// }

// document.write('<h1>' + model + ': ' + price + '$</h1>')

// var x = 0;
// while (x < 10) {
//     x++;
//     if (x === 5) {
//         continue;
//     }
//     console.log(x);
// }


// var arr = ['iphone', 'nokia', 'samsung'];
// var arr = [, , , , , ];
// var arr2 = new Array(5);

// console.log(arr);
// arr[100] = 'huawei';
// console.log(arr[5]);
// console.log(arr2);


// var arr = ['Sergey', 'sergey_pantera@gmail.com', 40];
// var driver = {
//     name: "Sergey",
//     email: "sergey_pantera@gmail.com",
//     age: 40
// }
// var name = 'age';
// console.log(driver[name]);
// console.log(driver.name);

// var key = 'email';
// console.log(driver.key);
// console.log(driver[key]);

// var numbers = [4, 56, 90, 87, 34, 32, 12, 99];

// for (var i = 0; i < numbers.length; i++) {
//     console.log(numbers[i] * 2);
//     // console.log(i);
// }


// var numbers = [4, 56, 90, 87, 34, 32, 12, 99];
// console.log(numbers);
// numbers[numbers.length] = 345;
// console.log(numbers);


// var arr = new Array(5);

// for (var i = 0; i < arr.length; i++) {
//     arr[i] = new Array(arr.length);
//     for (var j = 0; j < arr[i].length; j++) {
//         arr[i][j] = 0;
//     }
// }

// console.log(arr);


// var drivers = [{
//         "login": "mojombo",
//         "id": 1,
//         "node_id": "MDQ6VXNlcjE=",
//         "avatar_url": "https://avatars0.githubusercontent.com/u/1?v=4",
//         "gravatar_id": "",
//         "url": "https://api.github.com/users/mojombo",
//         "html_url": "https://github.com/mojombo",
//         "followers_url": "https://api.github.com/users/mojombo/followers",
//         "following_url": "https://api.github.com/users/mojombo/following{/other_user}",
//         "gists_url": "https://api.github.com/users/mojombo/gists{/gist_id}",
//         "starred_url": "https://api.github.com/users/mojombo/starred{/owner}{/repo}",
//         "subscriptions_url": "https://api.github.com/users/mojombo/subscriptions",
//         "organizations_url": "https://api.github.com/users/mojombo/orgs",
//         "repos_url": "https://api.github.com/users/mojombo/repos",
//         "events_url": "https://api.github.com/users/mojombo/events{/privacy}",
//         "received_events_url": "https://api.github.com/users/mojombo/received_events",
//         "type": "User",
//         "site_admin": false
//     },
//     {
//         "login": "defunkt",
//         "id": 2,
//         "node_id": "MDQ6VXNlcjI=",
//         "avatar_url": "https://avatars0.githubusercontent.com/u/2?v=4",
//         "gravatar_id": "",
//         "url": "https://api.github.com/users/defunkt",
//         "html_url": "https://github.com/defunkt",
//         "followers_url": "https://api.github.com/users/defunkt/followers",
//         "following_url": "https://api.github.com/users/defunkt/following{/other_user}",
//         "gists_url": "https://api.github.com/users/defunkt/gists{/gist_id}",
//         "starred_url": "https://api.github.com/users/defunkt/starred{/owner}{/repo}",
//         "subscriptions_url": "https://api.github.com/users/defunkt/subscriptions",
//         "organizations_url": "https://api.github.com/users/defunkt/orgs",
//         "repos_url": "https://api.github.com/users/defunkt/repos",
//         "events_url": "https://api.github.com/users/defunkt/events{/privacy}",
//         "received_events_url": "https://api.github.com/users/defunkt/received_events",
//         "type": "User",
//         "site_admin": true
//     },
//     {
//         "login": "pjhyett",
//         "id": 3,
//         "node_id": "MDQ6VXNlcjM=",
//         "avatar_url": "https://avatars0.githubusercontent.com/u/3?v=4",
//         "gravatar_id": "",
//         "url": "https://api.github.com/users/pjhyett",
//         "html_url": "https://github.com/pjhyett",
//         "followers_url": "https://api.github.com/users/pjhyett/followers",
//         "following_url": "https://api.github.com/users/pjhyett/following{/other_user}",
//         "gists_url": "https://api.github.com/users/pjhyett/gists{/gist_id}",
//         "starred_url": "https://api.github.com/users/pjhyett/starred{/owner}{/repo}",
//         "subscriptions_url": "https://api.github.com/users/pjhyett/subscriptions",
//         "organizations_url": "https://api.github.com/users/pjhyett/orgs",
//         "repos_url": "https://api.github.com/users/pjhyett/repos",
//         "events_url": "https://api.github.com/users/pjhyett/events{/privacy}",
//         "received_events_url": "https://api.github.com/users/pjhyett/received_events",
//         "type": "User",
//         "site_admin": false
//     },
//     {
//         "login": "wycats",
//         "id": 4,
//         "node_id": "MDQ6VXNlcjQ=",
//         "avatar_url": "https://avatars0.githubusercontent.com/u/4?v=4",
//         "gravatar_id": "",
//         "url": "https://api.github.com/users/wycats",
//         "html_url": "https://github.com/wycats",
//         "followers_url": "https://api.github.com/users/wycats/followers",
//         "following_url": "https://api.github.com/users/wycats/following{/other_user}",
//         "gists_url": "https://api.github.com/users/wycats/gists{/gist_id}",
//         "starred_url": "https://api.github.com/users/wycats/starred{/owner}{/repo}",
//         "subscriptions_url": "https://api.github.com/users/wycats/subscriptions",
//         "organizations_url": "https://api.github.com/users/wycats/orgs",
//         "repos_url": "https://api.github.com/users/wycats/repos",
//         "events_url": "https://api.github.com/users/wycats/events{/privacy}",
//         "received_events_url": "https://api.github.com/users/wycats/received_events",
//         "type": "User",
//         "site_admin": false
//     }
// ]

// for (var i = 0; i < drivers.length; i++) {
//     document.write('<div><img width="150" src="' + drivers[i].avatar_url + '"></div>')
// }