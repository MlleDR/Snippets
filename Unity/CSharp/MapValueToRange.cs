/**********************************************
 * Method to map a value between a given range.
 * ********************************************/
float MapValueToRange(float value, float min, float max)
{
    return Mathf.Clamp(value, min, max);
}

// Ex : Clamp the Input values
float InputValue = Input.GetAxis("Horizontal");
float clampedInput = MapValueToRange(InputValue, 0, 1);

// Ex : Change Health Bar
float HealthDamage = 0.6f;
float clampedBar = MapValueToRange(HealthDamage, 0, 100);
