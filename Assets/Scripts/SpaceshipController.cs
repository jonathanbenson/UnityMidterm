using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
// Controller to move the spaceship according to the keys that the user presses (WASD)
{
	
	// variable to keep track of the speed of the spaceship
	public float speed = 5;

	// Update is called once per frame
	void Update() {

		// initialize the offset value for the speed to 0
		Vector3 offset = Vector3.zero;

		// retrieve the x and z speed components from the input manager
		offset.x = Input.GetAxis("Horizontal");
		offset.z = Input.GetAxis("Vertical");

		// calculate the next offset as the product of the current offset and speed
		// ...also multiply the next offset by the time delta to make the motion smooth across all architectures
		offset = offset * speed * Time.deltaTime;

		// update the position of the spaceship
		transform.position = transform.position + offset;
	}

	void OnCollisionEnter(Collision collision) {

		// upon the spaceship colliding with a game object
		// tell the user they lost in the debug console
		Debug.Log("You Lose!");

		// destroy the spaceship (makes it disappear)
		Destroy(this.gameObject);

	}

	private void OnTriggerEnter(Collider other) {

		// upon the spaceship making it to the end of the asteroid field
		// tell the user they won in the debug console
		Debug.Log("You Win!");

		// destroy the spaceship (makes it disappear)
		Destroy(this.gameObject);

	}
}
