
// Constant Lerp from A to B with speed

private float moveDir;
private void ConstantLerp(Vector3 from, Vector3 to, float speed)
{
    moveDir = speed * (1 / Vector3.Distance(from.position, to.position) * Time.deltaTime);
    transform.position = Vector3.Lerp(from.position, to.position, moveDir);
}
