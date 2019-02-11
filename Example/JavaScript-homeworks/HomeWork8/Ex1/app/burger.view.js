class BurgerView {
  constructor(appName) {
    this._appName = appName;
    this._selectors = {
      sizes$: $(`[data-module="${this._appName}"] .burger__sizes`),
      stuffings$: $(`[data-module="${this._appName}"] .burger__stuffings`),
      toppings$: $(`[data-module="${this._appName}"] .burger__toppings`),
      burderData$: $(`[data-module="${this._appName}"] .burger__data`),
    }
    this._templates = {
      sizeInput: `
        <label>
          <input {{isChecked}} name="burger_size" type="radio" value="{{id}}">
          {{name}}
        </label>
      `,
      stuffingDefaultOption: `
        <option value="0">Choose stuffing</option>
      `,
      stuffingOption: `
        <option value="{{id}}">{{name}}</option>
      `,
      toppingDefaultOption: `
      <option value="3">Choose topping</option>
    `,
      toppingOption: `
      <option value="{{id}}">{{name}}</option>
    `,
      burgerData: `
        <h1>SIZE: {{size}}</h1>
        <h2>STUFFING: {{stuffing}}</h2>
        <h2>TOPPING: {{topping}}</h2>
      `
    }
  }

  renderSizes(sizes, chosenSize) {
    sizes.forEach(s => {
      let template = this._templates.sizeInput
        .replace('{{name}}', s.name)
        .replace('{{id}}', s.id)
        .replace('{{isChecked}}', s.id === chosenSize.id ? 'checked' : '');
      this._selectors.sizes$.append(template);
    });
  }

  renderStuffings(stuffings, chosenStuffing) {
    this._selectors.stuffings$.append(this._templates.stuffingDefaultOption);
    stuffings.forEach(s => {
      let template = this._templates.stuffingOption
        .replace('{{name}}', s.name)
        .replace('{{id}}', s.id);
      // .replace('{{isChecked}}', s.isChosen ? 'checked' : '');
      this._selectors.stuffings$.append(template);
      if (s.id === chosenStuffing.id) {
        this._selectors.stuffings$.val(s.id);
      }
    })
  }
  renderToppings(toppings, chosenTopping){
    this._selectors.toppings$.append(this._templates.toppingDefaultOption);
    toppings.forEach(s=> {
      let template = this._templates.toppingOption
        .replace('{{id}}', s.id)
        .replace('{{name}}', s.name);
        this._selectors.toppings$.append(template);
        if (s.id === chosenTopping.id) {
          this._selectors.toppings$.val(s.id);
        }
    })

  }

  renderBurgerData(burgerData) {
    let template = this._templates.burgerData
      .replace('{{size}}', burgerData.size.name)
      .replace('{{stuffing}}', burgerData.stuffing.name)
      .replace('{{topping}}', burgerData.topping.name)
      
    this._selectors.burderData$.html(template);
  }
}