using UnityEngine;

public class PlayerHover : MonoBehaviour
{
    private Rigidbody2D rb;
    public float hoverForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector2.up * hoverForce);
    }

}
