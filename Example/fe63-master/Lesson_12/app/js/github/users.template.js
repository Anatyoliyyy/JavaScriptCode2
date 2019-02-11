export class UsersTemplate {
    constructor(componentName) {
        this._cn = componentName;
        this._componentElement = $(`[data-component=${this._cn}]`);
        this._usersList = this._componentElement.find('.users__list');
    }

    _userItemTemplate(user) {
        return `<div class="users__item">
            <h1>${this._renderer(user.login)}</h1>
        </div>`;
    }

    _renderer(x) {
        return x !== undefined || null || NaN ? x : '';
    }

    render(renderEvent, data) {
        const self = this;
        const renderEvents = {
            "getAllUsers": function () {
                for (const user of data) {
                    self._usersList.append(self._userItemTemplate(user))
                }
            }
            // "getAllUsers": () => {
            //     console.log(this);
            //     for (const user of data) {
            //         this._usersList.append(this._userItemTemplate(user))
            //     }
            // }
        }
        renderEvents[renderEvent]();
    }
}