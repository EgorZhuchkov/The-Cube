using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsOver = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;
    public PlayerMovement playerMovement;

    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
        playerMovement.enabled = false;
    }

    public void EndGame()
    {
        if(!gameIsOver)
        {
            gameIsOver = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
