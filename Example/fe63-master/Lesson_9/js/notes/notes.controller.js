;
(function (window) {

    window.NotesController = function (view, model) {
        var self = this;
        self.view = view;
        self.model = model;

        self.view.handle('addNote', function (text) {
            self.addItem(text);
        })

        self.view.handle('removeNote', function (id) {
            self.removeItem(id);
        })

        self.view.handle('addToFavorite', function (id) {
            self.addItemToFavorite(id);
        })

    }

    NotesController.prototype.addItem = function (text) {
        // let data = {
        //     text: text
        // }
        var self = this;
        if (!text) {
            return;
        }
        self.model.add(text, function (data) {
            self.view.clearNewNote();
            self.view.render('showNotes', data);
        })
    }

    NotesController.prototype.removeItem = function (id) {
        var self = this;
        // try {
        //     if (id === -1) {
        //         throw 'ERROR';
        //     } else {
        //         self.model.remove(+id, function (newNotes) {
        //             self.view.render('showNotes', newNotes);
        //         })
        //     }
        // } catch (error) {
        //     console.error(error);
        // }
        self.model.remove(+id, function (newNotes) {
            self.view.render('showNotes', newNotes);
        })
    }

    NotesController.prototype.addToFavorite = function (id) {

    }

    NotesController.prototype.initView = function () {
        var self = this;
        // var notesData = self.model.getAll();
        // self.view.render('showNotes', notesData);

        self.model.getAll(function (data) {
            self.view.render('showNotes', data);
            // self.view.renderAllNotes(data);
        });
    }

}(window));