using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to put on the GameObject calling (& executing something) after the Timer is finished
public class TimerTest: MonoBehaviour
{
    [SerializeField] float timerDuration = 1;
    private Timer timer;

    private void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = timerDuration;
        timer.Run();
    }

    private void Update()
    {
        // Each time the timer is finished, it will print "Bip" in the Console
        if (timer.Finished)
        {
            Debug.Log("Bip");

            // Run the Timer again
            timer.Run();
        }
    }

}
