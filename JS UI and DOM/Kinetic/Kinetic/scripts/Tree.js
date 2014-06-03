function findElement(name) {
    for (var i = 0; i < familyMembers.length; i++) {
        if (familyMembers[i].mother === name || familyMembers[i].father === name) {
            return i;
        }
    }
}

function incStep(family) {
    family.level++;
    if (family.indexWithChildren.length === 0) {
        return;
    }
    for (var childIndex in family.indexWithChildren) {
        incStep(family[family.indexWithChildrens[childIndex]]);
    }
}

function createTree(Tree) {
    var countOfMembersInLevel = new Array(20).join('0').split('').map(parseFloat),
        parentsWithHeirs = [],
        i,
        k,
        corner,
        fillColor;

    for (i = 0; i < familyMembers.length; i++) {
        countOfMembersInLevel[familyMembers[i].level] = parseInt(countOfMembersInLevel[familyMembers[i].level] + 2);

        for (k = 0; k < 2; k++) {
            if (k === 0) {
                corner = 10;
                fillColor = 'white';
                text = familyMembers[i]['mother'];
            } else {
                corner = 0;
                text = familyMembers[i]['father'];
                fillColor = 'white';
            }

            parentsWithHeirs.push(text);

            Tree.push(new Kinetic.Rect({
                x: (k + countOfMembersInLevel[familyMembers[i].level] - 2) * 160,
                y: familyMembers[i].level * 120,
                width: 150,
                height: 40,
                stroke: 'yellowgreen',
                cornerRadius: corner,
                fill: fillColor,
            }));

            Tree.push(new Kinetic.Text({
                x: (k + countOfMembersInLevel[familyMembers[i].level] - 2) * 160 + 30,
                y: familyMembers[i].level * 120 + 13,
                text: text,
                fontFamily: 'Consolas',
                fill: 'black',
            }));
        }
    }

    parentsWithHeirs.sort();
    for (i = 0; i < familyMembers.length; i++) {
        for (var j = 0; j < familyMembers[i].children.length; j++) {
            if (parentsWithHeirs.indexOf(familyMembers[i].children[j]) == -1) {
                text = familyMembers[i].children[j];

                if (isNaN(countOfMembersInLevel[familyMembers[i].level + 1])) {
                    countOfMembersInLevel[familyMembers[i].level + 1] = 0;
                }

                if (text[text.length - 1] === 'а' || text[text.length - 1] === 'a') {
                    corner = 10;
                    fillColor = 'white';
                } else {
                    corner = 0;
                    fillColor = 'white';
                }

                Tree.push(new Kinetic.Rect({
                    x: (countOfMembersInLevel[familyMembers[i].level + 1]) * 160,
                    y: (familyMembers[i].level + 1) * 120,
                    width: 150,
                    height: 40,
                    stroke: 'yellowgreen',
                    cornerRadius: corner,
                    fill: fillColor,
                }));

                Tree.push(new Kinetic.Text({
                    x: (countOfMembersInLevel[familyMembers[i].level + 1]) * 160 + 30,
                    y: (familyMembers[i].level + 1) * 120 + 13,
                    text: text,
                    fontFamily: 'Consolas',
                    fill: 'black',
                }));
                countOfMembersInLevel[familyMembers[i].level + 1]++;
            }

        }
    }
}

function families() {
    for (var i = 0; i < familyMembers.length; i++) {
        familyMembers[i].level = 0;
        familyMembers[i].childrenIndex = [];
    }

    for (var i = 0; i < familyMembers.length; i++) {
        for (var j = 0; j < familyMembers.length; j++) {
            var mother = familyMembers[j].children.indexOf(familyMembers[i].mother),
                father = familyMembers[j].children.indexOf(familyMembers[i].father);

            if (mother != -1 || father != -1) {
                familyMembers[j].childrenIndex.push(i);
                familyMembers[i].level = familyMembers[j].level + 1;
                if (familyMembers[i].childrenIndex.length != 0) {
                    for (var childIndex in familyMembers[i].childrenIndex) {
                        incStep(familyMembers[familyMembers[i].childrenIndex[childIndex]]);
                    }
                }
            }
        }
    }
}

function drawTree(Tree, layer) {
    for (var i = 0; i < Tree.length; i++) {
        if (Tree[i].textArr) {
            var startX = Tree[i].getX() + 35,
                startY = Tree[i].getY() + 27,
                parent = Tree[i].textArr[0].text,
                index = findElement(parent),
                j, k;
            if (index != undefined) {
                for (j = 0; j < familyMembers[index].children.length; j++) {
                    var child = familyMembers[index].children[j];

                    for (k = 0; k < Tree.length; k++) {
                        if (Tree[k].textArr) {
                            if (Tree[k].textArr[0].text === child) {
                                var endX = Tree[k].getX() + 35,
                                    endY = Tree[k].getY() - 13;

                                layer.add(new Kinetic.Line({
                                    points: [startX, startY, endX, endY],
                                    stroke: 'green',
                                    lineCap: 'round',
                                    tension: 0.5
                                }));
                            }
                        }
                    }
                }
            }
        }
        layer.add(Tree[i]);
    }
}

function Draw() {
    var stage = new Kinetic.Stage({
        container: 'container',
        width: 2000,
        height: 2000,
    }),
    layer = new Kinetic.Layer(),
    Tree = [],
    text;

    createTree(Tree);

    drawTree(Tree, layer);

    stage.add(layer);
}

window.onload = function () {
    families();
    Draw();
};