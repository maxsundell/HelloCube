using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variable for for storing the state of the game
    private bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public GameObject creditsUI;

    public GameObject player;

    public void gameOver()
    {
        // Makes sure the game over state only gets triggered once
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("restartGame", restartDelay);
        }
    }

    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        PlayerCollision.hasPlayerCollided = false;
    }

    public void completeLevel()
    {
        // Disables the pmovement of the player after winning
        player.GetComponent<PlayerMovement>().enabled = false;
                
        completeLevelUI.SetActive(true);
    }

    public void completeLevel2()
    {
        // Disables the pmovement of the player after winning
        player.GetComponent<PlayerMovement>().enabled = false;

        creditsUI.SetActive(true);
    }

}
