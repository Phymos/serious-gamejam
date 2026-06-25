using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        transform.Rotate(Vector3.forward * (rotationSpeed * Time.deltaTime));
    }
}
