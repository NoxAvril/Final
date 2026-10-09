using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(25f, 0f, 0f); // beside the plane

    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}