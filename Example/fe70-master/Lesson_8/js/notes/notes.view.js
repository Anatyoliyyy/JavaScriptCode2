class NotesView {

    constructor() {
        this._s = {
            list: document.querySelector('.list'),
            removeBtnClass: 'list__element-btn'
        }

        this._t = {
            item: `
                <li class="list__element">
                    {{text}}
                    <button data-id="{{id}}" class="list__element-btn">Remove</button>
                </li>
            `
        }
    }

    renderNotes(notes) {
        // console.log('!!!', notes);
        let template = '';
        for (const n of notes) {
            template += this._t.item
                .replace('{{text}}', n.text)
                .replace('{{id}}', n.id);
        }
        // notes.forEach(n => {
        //     template += this._t.item.replace('{{text}}', n.text);
        // });
        this._s.list.innerHTML = template;
    }
}