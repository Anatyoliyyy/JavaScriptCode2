import {
    UsersComponent
} from './users.component';
import {
    UserComponent
} from './user.component';

export class GithubModule {
    constructor() {
        this._usersComponent = new UsersComponent('users-component');
        this._userComponent = new UserComponent('user-component');
    }

    init() {
        this._usersComponent.init();
        this._userComponent.init();
    }
}