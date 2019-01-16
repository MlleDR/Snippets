using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraAroundTarget : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 100f;

    private GameObject cameraOrbitTarget;

    void Start()
    {
        if (target != null)
        {
            PrepareOrbitStructure();
        }
    }
    
    void Update()
    {
        RotateWithKeyboardInput();
    }
  
    void PrepareOrbitStructure()
    {
        // creates an empty gameObject at target position
        cameraOrbitTarget = new GameObject(); 
        cameraOrbitTarget.transform.position = target.transform.position;
        
        // name the new Empty gameObject
        cameraOrbitTarget.name = "CAMERA_TARGET_OF[" + target.name + "]; 
        
        // parent the object on which you've put the script (here the camera) to new Empty gameObject
        transform.parent = cameraOrbitTarget.transform;
    }
    
    void RotateWithKeyboardInput()
    {
        float YRotation = rotationSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
        {
            targetParent.transform.Rotate(0f, YRotation, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            targetParent.transform.Rotate(0f, -YRotation, 0f);
        }
    }
}
