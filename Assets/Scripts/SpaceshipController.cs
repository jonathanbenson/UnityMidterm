using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{

	public float speed = 5;

	// Update is called once per frame
	void Update()
	{
		Vector3 offset = Vector3.zero;

		offset.x = Input.GetAxis("Horizontal");
		offset.z = Input.GetAxis("Vertical");

		offset = offset * speed * Time.deltaTime;

		transform.position = transform.position + offset;


	}
}
