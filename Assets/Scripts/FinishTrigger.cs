using UnityEngine;

public class FinishTrigger : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        if (PlayerCollision.hasPlayerCollided == false)
        {
            gameManager.completeLevel();
        }
    }
    
}