function setup() {
    createCanvas(600, 400)
}
function draw() {
    background("#000")

    // face
    fill(255, 214, 153)
    rect(160, 60, 200, 200)

    // Nose
    fill(255, 112, 77)
    triangle(245, 130, 265, 130, 255, 110);

    // Ears
    // first ear
    fill(230, 90, 0)
    rect(135, 85, 40, 60);
    // second ear
    fill(230, 90, 0)
    rect(345, 85, 40, 60);

    // Mouth
    fill(255, 51, 51)
    arc(260, 160, 100, 40, 0, PI);
    // Eyes
    fill(255, 112, 77)
    ellipse(200, 120, 20, 20);
    // Eyes
    fill(0)
    ellipse(310, 120, 20, 20);
    // additional feature
    if (mouseIsPressed) {
        fill(0);
    } else {
        fill(255);
    }
    ellipse(mouseX, mouseY, 80, 80);
}