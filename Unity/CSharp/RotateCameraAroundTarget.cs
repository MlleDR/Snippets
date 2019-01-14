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
        cameraOrbitTarget = new GameObject();
        cameraOrbitTarget.transform.position = target.transform.position;
        cameraOrbitTarget.name = "CAMERAORBIT_TARGET:" + target.name;
        transform.parent = cameraOrbitTarget.transform;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            cameraOrbitTarget.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
            Debug.Log("D");

        }

        if (Input.GetKey(KeyCode.Q))
        {
            cameraOrbitTarget.transform.Rotate(0, -(rotateSpeed * Time.deltaTime), 0);
            Debug.Log("Q");
        }
    }
}
