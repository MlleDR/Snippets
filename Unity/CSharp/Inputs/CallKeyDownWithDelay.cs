// Script to call KeyDown (or any other Inputs (analog or buttons)) with a delay.
// This script can be used to control the rate the Inputs are triggered.

// Ex : If you want to increment a value with a Key, normally the value will increment as long as the Key is Down, 
// which in many cases, could be too fast for your game. With the script, you can delay this time and thus, have 
// more control on the triggered rate.

// IMPORTANT : In this example script, I'm using the PS4 controller Inputs. But you can set the input on any keyboard input.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallKeyDownWithDelay : MonoBehaviour
{ 
    // Test the behaviour on a integer.
    public int modifiedValueFromInput;
    
    // Input Dpad Vertical.
    private int inputButton;                // Int that will store DPad inputs as integer.
    public bool inputButtonDown = false;    // Will be true whenever Dpad is either 1 (down) or -1 (up).
    public float decayStartValue = 0.2f;  // User's Input Decay start value.
    private float inputDecay;             // Stoed value - Input Decay.

    private void Start()
    {
        // Initialize value to 0.
        modifiedValueFromInput = 0;
    }
    
    private void Update()
    {
        // Set Input - inputButton will be used to increase/decrease the integer modifiedValueFromInput.
        // Dpad_Vertical : The string name set in Project Settings > Inputs.
        inputButton = Mathf.RoundToInt(Input.GetAxis("Dpad_Vertical")); 

        // Once pressed, Reset button after a given delay (inputDecay).
        ResetButtonDown();
        
        // If you press on button.
        if (inputButton != 0 && !inputButtonDown)
        {
          inputButtonDown = true;
          inputDecay = decayStartValue;
          modifiedValueFromInput -= inputButton;  // Increase or decrease value according to up/down DPad input.
        }
    }

    // Method - Once pressed, Reset button after a given delay (inputDecay).
    private void ResetButtonDown()
    {
        if (inputButtonDown && inputDecay > 0)
        {
            inputDecay -= Time.deltaTime;
        }

        if (inputDecay < 0)
        {
            inputDecay = 0;
            inputButtonDown = false;
        }
    }
}
