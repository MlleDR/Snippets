/***********************************************************************
* Method to make an object move around a circle.
*
* pX and pY are the object x and y coordinates.
* "cX" and "cY" are the starting points (ex: center of canvas)
* "radius" will vary the distance from starting points.
* "angle" changes vector.
*
* Demo on https://github.com/MlleDR/point-on-circle using p5.js library
************************************************************************/
function pX(cX, radius, angle) {
    return cX + radius * Math.sin(radians(angle));
}

function pY(cY, radius, angle) {
    return cY + radius * Math.cos(radians(angle));
}
