using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer: MonoBehaviour
{
    #region Variables
    // Timer Duration
    private float totalSeconds = 0;

    // Timer Execution
    private float elapsedSeconds = 0;
    private bool running = false;

    // When Finished
    private bool started = false;
    #endregion


    // Run Method - Run the timer
    public void Run()
    {
        //Only Run with valid duration
        if (totalSeconds > 0)
        {
            started = true;
            running = true;
            elapsedSeconds = 0;
        }
    }


    #region Properties
    // Duration (float) - Duration of the timer
    public float Duration
    {
        set
        {
            if (!running) totalSeconds = value;
        }
    }

    // Finished (bool) - When the timer is finished
    public bool Finished
    {
        get { return started && !running; }
    }

    
    // Get the running state
    public bool Running
    {
        get { return running; }
    }
    #endregion


    private void Update()
    {
        // Update Timer & Check for Finished
        if (running)
        {
            elapsedSeconds += Time.deltaTime;
            if (elapsedSeconds >= totalSeconds) running = false;
        }
    }
}
