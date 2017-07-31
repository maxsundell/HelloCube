using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Reference for the transform object of the player
    public Transform player;

    // Sets an offset between the camera and the player
    public Vector3 cameraOffset;

	void Update ()
    {
        // Makes the camera follow the player
        transform.position = player.position + cameraOffset;
	}

}
