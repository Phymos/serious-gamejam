using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float magnetForce = 10f;
    public LayerMask chainLayer;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & chainLayer) != 0)
        {
            Rigidbody2D rb = other.attachedRigidbody;
            
            if (rb != null)
            {
                Vector2 direction = (Vector2)transform.position - rb.position;
                
                rb.AddForce(direction.normalized * magnetForce, ForceMode2D.Force);
            }
        }
    }
}
