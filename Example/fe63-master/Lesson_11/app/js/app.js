import TodosModule from './todos/todos.module';
var APP = (function () {
    return {
        init: function () {
            TodosModule.init();
        }
    }
}());
APP.init();