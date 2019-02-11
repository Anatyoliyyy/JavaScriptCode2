var NotesController = (function () {

    var getNotes = function () {
        NotesModel.getNotes(function (notes) { // cb функция в model.getNotes
            NotesView.render('notes', notes);
        })
    }

    var listeners = function () {
        NotesView.listen('addingNote', function (noteText) {
            NotesModel.addNote(noteText, function (notes) {
                NotesView.render('notes', notes);
            });
        })
    }

    return {
        init: function () {
            getNotes();
            listeners();
        }
    }
}())