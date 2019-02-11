export class UserTemplate {
    constructor(componentName) {
        this._cn = componentName;
        this._componentElement = $(`[data-component=${this._cn}]`);

        this._userDetails = this._componentElement.find('.user');
        console.log(this._userDetails);

    }

    _userDetailsTemplate(user) {
        return `
            <img src="${user.avatar_url} width="150">
            <div class="users__login">${this._renderer(user.login)}</div>
            <h3>${user.name}</h3>
            <ul>
                <li>followers: ${user.followers}</li>
                <li>following: ${user.following}</li>
            </ul>
        `;
    }

    _renderer(x) {
        return x !== undefined || null || NaN ? x : '';
    }

    render(renderEvent, data) {
        const self = this;
        const renderEvents = {
            "showUserData": function () {
                console.log(self._userDetails);
                console.log(self._userDetailsTemplate(data));

                self._userDetails.html(self._userDetailsTemplate(data))
            }
        }
        renderEvents[renderEvent]();
    }
}