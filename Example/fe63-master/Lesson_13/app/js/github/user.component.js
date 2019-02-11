import {
    UserTemplate
} from './user.template';
import {
    UsersTemplate
} from './users.template';

import {
    GithubService
} from './github.service';

export class UserComponent {
    constructor(componentName) {
        this._cn = componentName;
        this._gs = new GithubService();
        this._userTemplate = new UserTemplate(this._cn);
    }

    init() {
        this._onTryGetUserDetails();
    }

    _onTryGetUserDetails() {
        $(window).on('tryGetUserDetails', (e, data) => {
            this._gs.getUser(data)
                .done(user => {
                    this._userTemplate.render('showUserData', user);
                })
        })
    }
}