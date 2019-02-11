var NotesModel = (function () {
    var NOTES = [{
            id: 1,
            text: 'Some note text 1'
        },
        {
            id: 2,
            text: 'Some note text 2'
        },
        {
            id: 3,
            text: 'Some note text 3'
        },
        {
            id: 4,
            text: 'Some note text 4'
        }
    ]

    return {
        getNotes: function (cb) {
            // get data from server...
            cb(NOTES);
            return NOTES;
        },
        addNote: function (newNoteText, cb) {
            var newNote = {
                id: NOTES[NOTES.length - 1].id + 1,
                text: newNoteText
            }
            NOTES.push(newNote);
            cb(NOTES);
        }
    }
}())