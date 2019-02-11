import {
    UsersComponent
} from './users.component';

export class GithubModule {
    constructor() {
        this._uc = new UsersComponent('users-component');
    }

    init() {
        this._uc.init();
    }
}