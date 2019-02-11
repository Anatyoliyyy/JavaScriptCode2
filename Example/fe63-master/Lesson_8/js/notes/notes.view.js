(function (window) {

    window.NotesView = function (moduleName, template) {
        this.moduleSelector = '[data-module=' + moduleName + '] ';
        this.$field = document.querySelector(this.moduleSelector + '.notes__add-inp');
        this.$addBtn = document.querySelector(this.moduleSelector + '.notes__add-btn');
        this.$list = document.querySelector(this.moduleSelector + '.notes__list');
        this.$rmButton = document.querySelector(this.moduleSelector + '.note__rm-button');

        this.tpl = template;
    }

    NotesView.prototype.handle = function (eventName, handler) {
        let self = this;
        if (eventName === 'addNote') {
            self.$addBtn.addEventListener('click', function () {
                let text = self.$field.value;
                handler(text);
            })
        }

        if (eventName === 'removeNote') {
            // self.$rmButton.addEventListener('click', function () {
            //     var id = 12;
            //     handler(id); //notes.controller.js 14 строка
            // })
            document.addEventListener('click', function (e) {
                var btn = e.target;
                if (btn.className === 'note__rm-button') {
                    var id = $attr(btn, 'data-id');
                    handler(+id);
                }
            })
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