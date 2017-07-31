using UnityEngine;

public class FinishTrigger2 : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        if (PlayerCollision.hasPlayerCollided == false)
        {
            gameManager.completeLevel2();
        }
    }
    
}