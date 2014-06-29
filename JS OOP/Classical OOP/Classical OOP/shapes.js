var shapes = (function () {
    // each shape has its own method draw.
    
    function Rect(x, y, width, height) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.draw = function (context) {
            context.beginPath();
            context.rect(this.x, this.y, this.width, this.height);
            context.stroke();
        }
    }

    function Circle(x, y, radius) {
        this.x = x;
        this.y = y;
        this.radius = radius;
        this.draw = function (context) {
            context.beginPath();
            context.arc(this.x, this.y, this.radius, 0, 2 * Math.PI);
            context.stroke();
        }
    }

    function Line(startX, startY, endX, endY) {
        this.startX = startX;
        this.startY = startY;
        this.endX = endX;
        this.endY = endY;
        this.draw = function (context) {
            context.beginPath();
            context.moveTo(this.startX, this.startY);
            context.lineTo(this.endX, this.endY);
            context.stroke();
        }
    }

    return {
        Rect: Rect,
        Circle: Circle,
        Line: Line
    }
}())