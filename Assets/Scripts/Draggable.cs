using UnityEngine;
using UnityEngine.InputSystem;

public class Draggable : MonoBehaviour
{
    Rigidbody2D rb;
    Rigidbody2D rbPlayer;
    bool isDragging = false;
    public GameObject player;
    public float chainLength = 3f;

    [SerializeField] float dragStr = 15f;

    [SerializeField] float throwForceMultiplier = 2f;
    [SerializeField] float maxThrowForce = 50f;
    [SerializeField] float minSpinRequired = 10f;
    private Vector2 lastPosition;
    private float currentSpinSpeed;

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioClip collisionClip;
    public AudioClip chainSound;
    public AudioClip swingSound;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rbPlayer = player.GetComponent<Rigidbody2D>();
    }

        void FixedUpdate()
    {
        if (!isDragging) return;

        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector2 mouseWorld = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 offset = mouseWorld - (Vector2)player.transform.position;

        if (offset.magnitude > chainLength)
        {
            mouseWorld = (Vector2)player.transform.position + offset.normalized * chainLength;
        }

        Vector2 direction = mouseWorld - rb.position;
        rb.linearVelocity = direction * dragStr;

        float distanceMoved = Vector2.Distance(rb.position, lastPosition);

        currentSpinSpeed = distanceMoved / Time.fixedDeltaTime;

        Debug.Log("Current Spin Speed: " + currentSpinSpeed);
        
        lastPosition = rb.position;
    }

    private void OnMouseDown()
    {
        isDragging = true;
        rbPlayer.constraints = RigidbodyConstraints2D.FreezeAll;
        rbPlayer.bodyType = RigidbodyType2D.Kinematic;

        lastPosition = rb.position;
        Debug.Log("holding" + gameObject.name);
    }

    private void OnMouseDrag()
    {
        if (currentSpinSpeed > minSpinRequired)
        {
            if (!audioSource2.isPlaying)
            {
                audioSource2.clip = swingSound;
                audioSource2.volume = 0.1f;
                audioSource2.Play();
            }
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
        rbPlayer.constraints = RigidbodyConstraints2D.None;
        rbPlayer.bodyType = RigidbodyType2D.Dynamic;

        audioSource1.PlayOneShot(chainSound, 1.5f);

        Vector2 throwDirection = rb.linearVelocity.normalized;
        float spinMagnitude = rb.linearVelocity.magnitude;

        float finalThrowForce = spinMagnitude * throwForceMultiplier;
        finalThrowForce = Mathf.Clamp(finalThrowForce, dragStr, maxThrowForce);

        rb.AddForce(throwDirection * finalThrowForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource1.PlayOneShot(collisionClip, 0.2f);
    }

    private void OnDrawGizmos()
    {        
        Gizmos.DrawWireSphere(player.transform.position, chainLength);
    }
}
