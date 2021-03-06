import {
    UsersTemplate
} from './users.template';

export class UsersComponent {
    constructor(componentName) {
        this._cn = componentName;
        this._template = new UsersTemplate(this._cn);
        this.USERS = [{
                login: 'LOGIN 1'
            },
            {
                login: 'LOGIN 2'
            },
            {
                login: 'LOGIN 3'
            }
        ]
    }

    init() {
        this._getUsers();
    }

    // _getElement(el) {
    //     return $(`[data-component=${this._cn}] ${el}`);
    //     // return $('[data-component='+this._cn+'}]')
    // }

    _getUsers() {
        //TODO: make get request to GitHub;
        $.ajax({
            type: 'GET',
            url: 'https://api.github.com/users',
            success: (res) => {
                this._template.render('getAllUsers', res);
            }
        })
        // TODO: make via promises (done, fail) (use shortervariant of ajax call)
    }
}