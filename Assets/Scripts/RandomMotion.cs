using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMotion : MonoBehaviour
{

    float xSpeed, zSpeed;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = Random.Range(-.25f, .25f) * Time.deltaTime;
        zSpeed = Random.Range(-.25f, .25f) * Time.deltaTime;


        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xSpeed, 0, zSpeed));
    }
}
