using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMotion : MonoBehaviour
// Handles the motion of the asteroids in the asteroid field
// Each of their velocities are generated randomly
{

    // x and z speed components of game object
    float xSpeed, zSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // initialize the x and z speed components with a random, LOW value
        xSpeed = Random.Range(-.25f, .25f) * Time.deltaTime;
        zSpeed = Random.Range(-.25f, .25f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        // move each game object each frame according to the speed of the object
        transform.Translate(new Vector3(xSpeed, 0, zSpeed));
    }
}
