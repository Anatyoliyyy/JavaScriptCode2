import {
    GithubModule
} from './github/github.module';

class IndexModule {
    constructor() {
        this._ghModule = new GithubModule();
    }

    init() {
        this._ghModule.init();
    }
}
const indexModule = new IndexModule();
indexModule.init();