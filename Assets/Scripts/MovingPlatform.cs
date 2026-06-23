using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float rawSin = Mathf.Sin(Time.fixedTime * speed);
        float progress = (rawSin + 1f) / 2f;
        
        Vector2 targetPosition = Vector2.Lerp(pointA.position, pointB.position, progress);
        rb.MovePosition(targetPosition);
    }
}
