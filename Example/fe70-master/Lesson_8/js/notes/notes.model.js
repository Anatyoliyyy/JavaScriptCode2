class NotesModel {
    constructor() {
        this._notes = [{
                id: 1,
                text: 'Some text 1'
            },
            {
                id: 2,
                text: 'Some text 2'
            },
            {
                id: 3,
                text: 'Some text 3'
            },
            {
                id: 4,
                text: 'Some text 4'
            }
        ]
    }

    getNotes(cb) {
        // getting notes.......
        cb(this._notes);
        return this._notes;
    }
}