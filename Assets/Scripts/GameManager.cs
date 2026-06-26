using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnRestartLevel(InputAction.CallbackContext context)
    {
        if (context.performed)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
