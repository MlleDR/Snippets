/******************************************************
* Method to toggle randomly between two specific values.
******************************************************/
function RandomToggle(value1, value2) {
    return [value1, value2][Math.round(Math.random())];
}
