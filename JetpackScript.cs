using UnityEngine;
using System.Collections;

public class JetpackScript : MonoBehaviour {

		public float forwardMovementSpeed = 3.0f;
		float currentFlyTime;
	public float FlyingSpeed = 3.0f;
		public GameObject Player;
		public AudioClip ThudClip;
	public AudioClip[] CharacterClip;
	private bool AudioPlay = false;
	AudioSource audio;

	//booleans
	public bool LeftIsOn;
	public bool RightIsOn;



	public Rigidbody rb;

	public bool GoUp = false;

	//Fly Time

		void Start () {
		audio = GetComponent<AudioSource>();
		currentFlyTime = 0;
		}
		// Use this for initialization

		void OnCollisionEnter (Collision col)
		{
			//Check collision name

			if (col.gameObject.tag == "Enemy") {
				Debug.Log ("Collider");
				GetComponent<AudioSource> ().PlayOneShot (ThudClip);
				//GetComponent<ParticleSystem>().Emit(5);
			Destroy (Player);
			}
	}

// DONT TOUCH THIS AREA
	void FixedUpdate ()
	{

		//Vector3 newVelocity = GetComponent<Rigidbody>().velocity;
		//newVelocity.x = forwardMovementSpeed;
		//GetComponent<Rigidbody>().velocity = newVelocity;
		transform.position += transform.forward * Time.deltaTime * forwardMovementSpeed;
	}


	//VOID UPDATE
	void Update ()

	{
		if (LeftIsOn)
		{
			transform.Rotate(Vector3.down * FlyingSpeed);
		}
		if (RightIsOn)
		{
			transform.Rotate(Vector3.up * FlyingSpeed);
		}
	}



		public void Left ()
	{
		LeftIsOn = true;
		RightIsOn = false;
	}


		public void Right () {
		LeftIsOn = false;
		RightIsOn = true;
		}

	public void StopMoving () {
		LeftIsOn = false;
		RightIsOn = false;
}
}
