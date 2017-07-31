using UnityEngine;

public class RotatingBlocklol : MonoBehaviour
{

	void FixedUpdate () {
        transform.Rotate(0, 215 * Time.deltaTime, 0);
	}

}
