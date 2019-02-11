var fieldWidth = 40;
var fieldHeight = 40;
 
var field = new Array(fieldWidth * fieldHeight).fill(null).map((_, i) => {
    let cell = {
        check: false,
        flag: false,
        bomb: Math.random() < 0.1,
        neighbords: [],
        x: i % fieldHeight,
        y: i / fieldHeight | 0
    };
 
    return cell;
});
 
field.forEach((cell) => {
    [[0, -1], [1, -1], [1, 0], [1, 1], [0, 1], [-1, 1], [-1, 0], [-1, -1]].forEach((step) => {
        let pnx = cell.x + step[0];
        let pny = cell.y + step[1];
        if (pnx >= 0 && pnx < fieldWidth && pny >= 0 && pny < fieldHeight) {
            cell.neighbords.push(field[pny * fieldWidth + pnx]);
        }
    });
});
 
fieldElement.innerHTML = field.map( (cell) => `<span class="cell"></span>` ).join("");
fieldElement.style.width = fieldWidth * 10 + "px";
 
Array.from(fieldElement.children).forEach((elementCell, i) => {
    elementCell.cell = field[i];
    elementCell.cell.element = elementCell;
});
 
fieldElement.addEventListener("click", event => {
    let fill = (cell) => {
        if (!cell.check) {
            cell.check = true;
            let num = cell.neighbords.reduce((p, c) => p + c.bomb, 0);
            if (num > 0) {
                cell.element.innerText = num;
                cell.element.className = ["cell", "num"].join(" ");
            } else {
                cell.element.className = ["cell", "check"].join(" ");
                cell.neighbords.forEach(fill);
            }
        }
    };
    if (event.target.cell.bomb) {
        field.forEach( cell => {
            if (cell.bomb) {
                cell.element.className = ["cell", "bomb"].join(" ");
            }
        })
        alert("проиграл");
    } else {
        fill(event.target.cell);
    }
    return false;
});