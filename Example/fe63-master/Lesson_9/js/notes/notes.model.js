(function (window) {

    window.NotesModel = function (data) {
        this.data = data;
    }

    NotesModel.prototype.getAll = function (cb) {
        // getting data from ...
        cb(this.data);
        return this.data;
    }

    NotesModel.prototype.get = function (id, cb) {
        for (var i = 0; i < this.data.length; i++) {
            if (this.data[i].id === id) {
                cb(this.data[i]);
                return this.data[i];
            }
        }

        return false;
    }

    NotesModel.prototype.add = function (text, cb) {
        var newNote = {
            text: text,
            isFavorite: false
        }
        newNote.id = new Date().getTime();
        this.data.push(newNote);
        cb(this.data);
    }

    NotesModel.prototype.remove = function (id, cb) {
        for (var i = 0; i < this.data.length; i++) {
            if (this.data[i].id === id) {
                this.data.splice(i, 1);
                break;
            }
        }
        cb(this.data);
    }


}(window));