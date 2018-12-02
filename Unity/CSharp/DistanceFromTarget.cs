/*********************************************************************
 * Method 1 - Fast compile time method
 * Returns the distance between Source and Target using .sqrMagnitude
 * *******************************************************************/
float SqrMag_DistanceFromTarget(Transform Source, Transform Target)
{
    float dist = (Target.position - Source.position).sqrMagnitude;
    return dist;
}

/*************************************************************************
 * Method 2 - Slower compile time method
 * Returns the distance between Source and Target using Vector3.Distance()
 * (Unity manuals) => Vector3.Dstance(a,b) is the same as (a,b).magnitude
 * ***********************************************************************/
float Vector_DistanceFromTarget(Transform Source, Transform Target)
{
    float dist = Vector3.Distance(Target.position, Source.position);
    return dist;
}
