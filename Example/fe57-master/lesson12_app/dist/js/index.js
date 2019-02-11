!function(t){var r={};function o(n){if(r[n])return r[n].exports;var e=r[n]={i:n,l:!1,exports:{}};return t[n].call(e.exports,e,e.exports,o),e.l=!0,e.exports}o.m=t,o.c=r,o.d=function(n,e,t){o.o(n,e)||Object.defineProperty(n,e,{configurable:!1,enumerable:!0,get:t})},o.n=function(n){var e=n&&n.__esModule?function(){return n.default}:function(){return n};return o.d(e,"a",e),e},o.o=function(n,e){return Object.prototype.hasOwnProperty.call(n,e)},o.p="",o(o.s=1)}([function(n,e,t){"use strict";Object.defineProperty(e,"__esModule",{value:!0});var r=function(){function r(n,e){for(var t=0;t<e.length;t++){var r=e[t];r.enumerable=r.enumerable||!1,r.configurable=!0,"value"in r&&(r.writable=!0),Object.defineProperty(n,r.key,r)}}return function(n,e,t){return e&&r(n.prototype,e),t&&r(n,t),n}}();var o=function(){function n(){!function(n,e){if(!(n instanceof e))throw new TypeError("Cannot call a class as a function")}(this,n)}return r(n,[{key:"getUsers",value:function(){return $.get("https://api.github.com/users")}},{key:"getUser",value:function(n){return $.get("https://api.github.com/users/"+n)}},{key:"getUserFollowers",value:function(n){return $.get("https://api.github.com/users/"+n+"/followers")}}]),n}();e.github=new o},function(n,e,t){n.exports=t(2)},function(n,e,t){"use strict";var r=t(3),o=t(4),i=t(5);r.user.init(),o.profile.init(),i.search.init()},function(n,e,t){"use strict";Object.defineProperty(e,"__esModule",{value:!0}),e.user=void 0;var r=function(){function r(n,e){for(var t=0;t<e.length;t++){var r=e[t];r.enumerable=r.enumerable||!1,r.configurable=!0,"value"in r&&(r.writable=!0),Object.defineProperty(n,r.key,r)}}return function(n,e,t){return e&&r(n.prototype,e),t&&r(n,t),n}}(),o=t(0);var i=function(){function n(){!function(n,e){if(!(n instanceof e))throw new TypeError("Cannot call a class as a function")}(this,n)}return r(n,[{key:"init",value:function(){this.getUsers(),this.openProfile()}},{key:"getUsers",value:function(){$("#users").html('\n            <h2 class="users__loading">LOADING ...</h2>\n        '),o.github.getUsers().done(function(n){$("#users").find(".users__loading").remove();var e=!0,t=!1,r=void 0;try{for(var o,i=n[Symbol.iterator]();!(e=(o=i.next()).done);e=!0){var u=o.value;$("#users").append('\n                        <tr class="users__item">\n                            <td>\n                                <img src="'+u.avatar_url+'" alt="" class="users__item-img" width="100">\n                            </td>\n                            <td>'+u.login+'</td>\n                            <td>\n                                <button class="users__item-more" data-login="'+u.login+'">More info</button>\n                            </td>\n                        </tr>\n                    ')}}catch(n){t=!0,r=n}finally{try{!e&&i.return&&i.return()}finally{if(t)throw r}}}).fail(function(n){console.error(n.status)})}},{key:"openProfile",value:function(){$("#users").on("click",".users__item-more",function(){var n={login:$(this).attr("data-login")};$(window).trigger("openingProfile",n)})}}]),n}();e.user=new i},function(n,e,t){"use strict";Object.defineProperty(e,"__esModule",{value:!0}),e.profile=void 0;var r=function(){function r(n,e){for(var t=0;t<e.length;t++){var r=e[t];r.enumerable=r.enumerable||!1,r.configurable=!0,"value"in r&&(r.writable=!0),Object.defineProperty(n,r.key,r)}}return function(n,e,t){return e&&r(n.prototype,e),t&&r(n,t),n}}(),o=t(0);var i=function(){function n(){!function(n,e){if(!(n instanceof e))throw new TypeError("Cannot call a class as a function")}(this,n)}return r(n,[{key:"init",value:function(){this.openProfile()}},{key:"openProfile",value:function(){$(window).on("openingProfile",function(n,e){$("#profile").html("\n                <h2>LOADING ...</h2>\n            "),o.github.getUser(e.login).done(function(n){console.log(n),$("#profile").html('\n                        <img src="'+n.avatar_url+'" width="150"> <br><br>\n                        <span>'+n.login+"</span>\n                        <h2>"+(n.name||"")+"</h2>\n                        <h3>"+(n.location||"")+"</h3>\n                        <h4>FOLLOWERS: "+(n.followers||0)+"</h4>\n                        <h4>FOLLOWING: "+(n.following||0)+"</h4>\n                    ")}).fail(function(n){console.log(n)}),$("#followers").html('\n                <h2 class="followers__loading">LOADING...</h2>\n            '),o.github.getUserFollowers(e.login).done(function(n){$("#followers .followers__loading").remove();var e=!0,t=!1,r=void 0;try{for(var o,i=n[Symbol.iterator]();!(e=(o=i.next()).done);e=!0){var u=o.value;$("#followers").append('\n                            <tr class="followers__item">\n                                <td>\n                                    <img src="'+u.avatar_url+'" alt="" class="users__item-img" width="100">\n                                </td>\n                                <td>'+u.login+"</td>\n                            </tr>\n                        ")}}catch(n){t=!0,r=n}finally{try{!e&&i.return&&i.return()}finally{if(t)throw r}}}).fail(function(n){console.log(n)})})}}]),n}();e.profile=new i},function(n,e,t){"use strict";Object.defineProperty(e,"__esModule",{value:!0}),e.search=void 0;var r=function(){function r(n,e){for(var t=0;t<e.length;t++){var r=e[t];r.enumerable=r.enumerable||!1,r.configurable=!0,"value"in r&&(r.writable=!0),Object.defineProperty(n,r.key,r)}}return function(n,e,t){return e&&r(n.prototype,e),t&&r(n,t),n}}(),o=t(0);var i=function(){function n(){!function(n,e){if(!(n instanceof e))throw new TypeError("Cannot call a class as a function")}(this,n)}return r(n,[{key:"init",value:function(){this.searchUser()}},{key:"searchUser",value:function(){$(".app__search-btn").click(function(){var n=$(".app__search-inp").val();o.github.getUser(n).done(function(n){$("#users").html('\n                        <tr class="users__item">\n                            <td>\n                                <img src="'+n.avatar_url+'" alt="" class="users__item-img" width="100">\n                            </td>\n                            <td>'+n.login+'</td>\n                            <td>\n                                <button class="users__item-more" data-login="'+n.login+'">More info</button>\n                            </td>\n                        </tr>\n                    ')}).fail(function(n){var e=n.responseJSON.message;$("#users").html('\n                        <h2 class="users__loading">'+e+"</h2>\n                    ")})})}}]),n}();e.search=new i}]);