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
        // creates an empty gameObject at target position
        cameraOrbitTarget = new GameObject(); 
        cameraOrbitTarget.transform.position = target.transform.position;
        
        // name the new Empty gameObject
        cameraOrbitTarget.name = "CAMERAORBIT_TARGET:" + target.name; 
        
        // parent the object on which you've put the script (here the camera) to new Empty gameObject
        transform.parent = cameraOrbitTarget.transform;
    }

    void Update()
    {
        // move camera orbit right
        if (Input.GetKey(KeyCode.D))
        {
            cameraOrbitTarget.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
        
        // move camera orbit left
        if (Input.GetKey(KeyCode.Q))
        {
            cameraOrbitTarget.transform.Rotate(0, -(rotateSpeed * Time.deltaTime), 0);
        }
    }
}
