
using UnityEngine;

public class RotatingBlock : MonoBehaviour {

	void FixedUpdate () {
        transform.Rotate(0, 215 * Time.deltaTime, 0);
	}
}
