using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget: MonoBehaviour
{

    // Target to Look at
    [SerializeField] private Transform targetToLookAt;

    // Look at Axis
    [SerializeField] private bool xAxis;
    [SerializeField] private bool yAxis;
    [SerializeField] private bool zAxis;



    private void Update()
    {
        LookAt(targetToLookAt);
    }



    private void LookAt(Transform target)
    {
        Vector3 targetPosition = target.position;

        targetPosition.x = xAxis ? transform.position.x : targetPosition.x;
        targetPosition.y = yAxis ? transform.position.y : targetPosition.y;
        targetPosition.z = zAxis ? transform.position.z : targetPosition.z;

        transform.LookAt(targetPosition);
    }
}
