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

    listenRemovingNote(cb) {
        // узнаем ID удаляемой заметки (значение data-id кнопки, на которую мы нажали)
        // ...
        // let self = this;
        this._s.list.addEventListener('click', (e) => {
            let target = e.target;
            if (target.className === this._s.removeBtnClass) {
                for (const a of target.attributes) {
                    if (a.name === 'data-id') {
                        cb(a.value);
                    }
                }
            }
        })
        // cb(id)
    }
}