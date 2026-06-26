using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rb.gravityScale = 10f;
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
