export class UsersTemplate {
    constructor(componentName) {
        this._cn = componentName;
        this._componentElement = $(`[data-component=${this._cn}]`);
        this._usersList = this._componentElement.find('.users__list');
        this._userDetailsBtn = '.users__item-btn[data-action="getUserData"]';

        // this._tryGetUserDetails();
    }

    _userItemTemplate(user) {
        return `<div class="users__item">
            <h3>${this._renderer(user.login)} - <button class="users__item-btn" data-action="getUserData" data-login="${user.login}">More</button></h3>
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

    // _tryGetUserDetails() {
    //     this._usersList.on('click', this._userDetailsBtn, (e) => {
    //         console.log(e);
    //     })
    // }

    listener(action) {

        switch (action) {
            case 'getUserDetails':
                this._usersList.on('click', this._userDetailsBtn, function (e) {
                    let login = $(this).attr('data-login');
                    $(window).trigger('tryGetUserDetails', login);
                })
                break;
            default:
                return false;
        }
    }
}