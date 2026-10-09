using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    public Transform target;
    public float height = 10f;
    public float distance = 10f;
    public float rotationX = 25f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 wantedPosition = target.position 
                               - target.forward * distance 
                               + Vector3.up * height;

        transform.position = wantedPosition;

        transform.rotation = Quaternion.Euler(rotationX, target.eulerAngles.y, 0f);
    }
}