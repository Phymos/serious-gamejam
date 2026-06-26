using UnityEngine;
using UnityEngine.SceneManagement;

public class Danger : MonoBehaviour
{
    public AudioSource playerAudio;
    public GameObject player;
    public SpriteRenderer spriteRenderer;
    public Sprite deathSprite;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            if (playerAudio != null)
            {
                playerAudio.PlayOneShot(playerAudio.clip);
            }
            player.transform.rotation = Quaternion.Euler(0, 0, 90f);

            Animator anim = player.GetComponentInChildren<Animator>();
            if (anim != null)
            {
                anim.enabled = false; 
            }

            spriteRenderer.sprite = deathSprite;

            Invoke("RestartScene", 0.5f);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}