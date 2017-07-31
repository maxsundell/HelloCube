using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Reference to the playermovement script file
    public PlayerMovement playerMovement;

    static public bool hasPlayerCollided = false;

    // Checks for collisions
    private void OnCollisionEnter(Collision collisionInfo)
    {
        // Checks for collions for objects with the tag "Obstacle" GAME OVER
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Disables the player movement script
            playerMovement.enabled = false;

            hasPlayerCollided = true;

            // Calls the game over function
            FindObjectOfType<GameManager>().gameOver();
        }
    }

}
