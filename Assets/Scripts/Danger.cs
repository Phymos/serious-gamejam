using UnityEngine;
using UnityEngine.SceneManagement;

public class Danger : MonoBehaviour
{
    public AudioSource playerAudio;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            if (playerAudio != null)
            {
                playerAudio.PlayOneShot(playerAudio.clip);
            }

            Invoke("RestartScene", 0.5f);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}