using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -29) 
        {
            transform.position = new Vector3(46.9f,0.13f,0f) ;
        }
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
