import {
    Header
} from './header';

import FooterX from "./footer";

import {
    x as SomeX,
    y,
    a
} from './main';

const App = (function () {
    return {
        init: function () {
            Header.init()
        }
    }
}())

console.log(FooterX, SomeX);