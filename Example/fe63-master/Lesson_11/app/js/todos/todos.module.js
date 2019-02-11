import AddTodo from './add-todo';
import TodosList from './todos-list';

export default (function () {
    return {
        init: function () {
            AddTodo.init();
            TodosList.init();
        }
    }
}());