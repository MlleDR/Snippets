/****************************************************
* Method to toggle randomly between two given values.
*****************************************************/
function RandomToggle(value1, value2) {
    return [value1, value2][Math.round(Math.random())];
}
