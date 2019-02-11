;
(function (window) {

    window.NotesTemplate = function () {
        this.noteTemplate = `
            <div class="note">
                <div class="note__text">{{text}} <button data-id="{{id}}" class="note__rm-button">X</button></div>
            </div>
        `;
    }

    // NotesTemplate.prototype.showOne = function (data) {
    //     let template = this.noteTemplate;
    //     template = template.replace('{{text}}', data)
    //     return template;
    // }

    NotesTemplate.prototype.show = function (data) {
        var i, l;
        var view = '';

        if (data.length > 0 && typeof data === 'object') {
            for (i = 0, l = data.length; i < l; i++) {
                var template = this.noteTemplate;
                template = template.replace('{{text}}', data[i].text);
                // template = template.replace('{{id}}', data[i].id);
                view = view + template;
            }
        }
        // else {
        //     var template = this.noteTemplate;
        //     template = template.replace('{{text}}', data.text);
        //     template = template.replace('{{id}}', data.id);
        //     view = view + template;
        // }

        return view;
    }

}(window));