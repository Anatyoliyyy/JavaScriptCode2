(function (window) {

    window.NotesView = function (moduleName, template) {
        this.moduleSelector = '[data-module=' + moduleName + '] ';
        this.$field = document.querySelector(this.moduleSelector + '.notes__add-inp');
        this.$addBtn = document.querySelector(this.moduleSelector + '.notes__add-btn');
        this.$list = document.querySelector(this.moduleSelector + '.notes__list');
        this.$rmButton = document.querySelector(this.moduleSelector + '.note__remove-btn');

        this.rmButtonClassName = 'note__remove-btn';
        this.idAttrName = 'data-id';

        this.tpl = template;
    }

    NotesView.prototype.handle = function (eventName, handler) {
        var self = this;
        if (eventName === 'addNote') {
            self.$addBtn.addEventListener('click', function () {
                let text = self.$field.value;
                handler(text);
            })
        }

        if (eventName === 'removeNote' || eventName === 'addToFavorite') {
            // ДЗ написать обертку над addEventListener таким образом, чтобы 
            // ПРИМЕР:
            // $on('click', button, funciton(){...})
            // $on('click', button, 'className ЭЛЕМЕНТА ПРИ НАЖАТИИ НА КОТОРЫЙ ДОЛЖЕН СРАБОТАТЬ ОБРАБОТЧИК',funciton(){...})
            //обработать try catch
            document.addEventListener('click', function (e) {
                var id = -1;
                for (var i = 0; i < e.target.classList.length; i++) {
                    if (e.target.classList[i] === self.rmButtonClassName) {
                        id = $attr(e.target, self.idAttrName);
                    }
                }
                handler(id);
            })

            // $on('click', self.$list, self.rmButtonClassName, function(){
            //     id = $attr(e.target, self.idAttrName);
            //     handler(id);
            // })
            // $on('click', self.rmButtonClassName, function(){
            //     id = $attr(e.target, self.idAttrName);
            //     handler(id);
            // }) // не сработает, так как кнопки нет в html
        }

    }

    NotesView.prototype.render = function (viewCmd, data) {
        var self = this;
        var viewCommands = {
            showNotes: function () {
                self.$list.innerHTML = self.tpl.show(data);
            }
        }
        viewCommands[viewCmd]();
    }

    // NotesView.prototype.renderAllNotes = function (data) {
    //     // рисует все заметки
    // }

    NotesView.prototype.clearNewNote = function () {
        this.$field.value = '';
    }



}(window));