class NotesController {
    constructor(model, view) {
        this._model = model;
        this._view = view;
    }

    init() {
        this._model.getNotes((data) => {
            this._view.renderNotes(data);
        });
    }
}