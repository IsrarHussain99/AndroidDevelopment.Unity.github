using UnityEngine;
using System.Collections;

public class AutoMovement : MonoBehaviour {

	public float speed = 1; // speed in meters per second



	void Update(){


		Vector3 moveDir = Vector3.zero;
			moveDir.z = Input.GetAxis("Horizontal"); // get result of AD keys in X
			// move this object at frame rate independent speed:
			transform.position += moveDir * speed * Time.deltaTime;
		}
}

	
	
