var $attr = function (targetElement, attrName) {
    var attrValue = -1;
    for (var i = 0; i < targetElement.attributes.length; i++) {
        if (targetElement.attributes[i].name === attrName) {
            attrValue = targetElement.attributes[i].value;
            break;
        }
    }
    return attrValue;
}