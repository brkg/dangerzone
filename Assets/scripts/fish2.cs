using UnityEngine;
using System.Collections;

public class fish2 : MonoBehaviour {
	
	//declare two vectors that tell the fish how to move around
	// an idea for random motion: use a RNG for destination and change it up as an update
	public Vector3 destination = new Vector3(5f, 3f, 3f);
	public Vector3 direction;
	public float speed;
	
	// Use this for initialization
	void Start () {
		//automatically calls a function every x seconds (third arg). second argument is the time at which the first argument is called
		InvokeRepeating ("SetNewDestination", 0f, 1f);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//FixedUpdate for physics
	void FixedUpdate() 
	{
		speed = Random.Range(1f, 10f);
		//transform.forward = direction;
		transform.rotation = Quaternion.LookRotation(rigidbody.velocity);
		
		//apply some force to the direction of the destination
		direction = Vector3.Normalize(destination - transform.position);
		rigidbody.AddForce (direction*speed, ForceMode.Acceleration);
	}
	
	//the "brain" of the fish.
	
	//sets random destination for the fish.
	void SetNewDestination()
	{
		//sets destination to a random vector inside the unit sphere.
		destination = Random.insideUnitSphere*200f; 
	}
	
}
