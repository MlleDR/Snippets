using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDirectionalRotation: MonoBehaviour
{
    // This piece of script only show the methods to detect clockwise and anti-clockwise direction when you are rotating an object (or player)
    // It is not a complete TPS locomotion script
    
    // Camera
    private Transform cam;
    
    // Locomotion
    private float RFrotationTurnVelocity;
    private Vector3 direction;

    // Locomotion States
    public bool turnLeft; // Parameter on which anti-clockwise direction will be passed
    public bool turnRight; // Parameter on which clockwise direction will be passed

    private void Awake()
    {
        // Camera
        cam = Camera.Main;
    }
    
    private void Update()
    {
        // Legacy Input System
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, 0, vertical).normalized;

        // Movement
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref RFrotationTurnVelocity, rotationSmoothTime);

        // Check if player is rotating clockwise or anti-clockwise
        Orientation = angle;
            
        // [Optional] Pass CLOCKWISE OR ANTI-CLOCKWISE to the booleans 'turnRight' and 'turnLeft'
        // Examples : Use them for Banking in the Animator, Lookat in the direction the player is going and all sorts of fun locomotion features
        turnRight = clockwiseRotation;
        turnLeft = !clockwiseRotation;
    }


    // Check if player is rotating clockwise or anti-clockwise
    private float _counter;
    public bool clockwiseRotation;
    private float Orientation
    {
        get
        {
            return _counter;
        }

        set
        {
            clockwiseRotation = _counter <= value;
            _counter = value;
        }
    }
}
