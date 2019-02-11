export class GithubService {
    constructor() {}

    getUsers() {
        return $.get('https://api.github.com/users');
    }

    getUser(login) {
        return $.get(`https://api.github.com/users/${login}`);
    }
}