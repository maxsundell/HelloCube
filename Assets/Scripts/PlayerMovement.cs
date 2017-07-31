using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    // Reference to the players rigidbody
    public Rigidbody rb;

    // Variables for the amount of force applied to the player
    public float forwardForce = 100f;
    public float sidewaysForce = 100f;

    private void FixedUpdate()
    {
        // Adds a accelerating force to the player
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        // Gets input from the player and turns it into sideways movement
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Debug.Log("test");
        }

        // Checks to see if the player has fallen outside of the world
        if (rb.position.y < -1)
        {
            // Calls the game over function
            FindObjectOfType<GameManager>().gameOver();
        }

        if (Input.GetKey("space"))
        {
            Debug.Log("Quitting...");
            Application.Quit();
        }

    }

}
