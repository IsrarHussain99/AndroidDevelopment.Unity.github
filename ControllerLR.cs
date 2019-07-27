using UnityEngine;
using System.Collections;

public class ControllerLR : MonoBehaviour
{


	public float speed = 10, Velocity = 10;
	Rigidbody myBody;
	bool isGrounded = false;
	float hInput = 0;

	void Start ()
	{
		//  this gets the ridgidbody2d for the movement to work - required!
		myBody = this.GetComponent<Rigidbody>();//Unity 5+
	}

void FixedUpdate ()
{
Move (hInput);
}

	void Move(float horizonalInput)
	{
		if(isGrounded)
			return;

		Vector3 moveVel = myBody.velocity;
		moveVel.x = horizonalInput * speed;
		myBody.velocity = moveVel;
	}
		
	public void StartMoving(float horizonalInput)
	{
		hInput = horizonalInput;
	}


}