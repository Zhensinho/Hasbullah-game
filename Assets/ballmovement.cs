using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    Rigidbody ball; 

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        ball.AddForce(new Vector3(0, -3, 0), ForceMode.Impulse);


    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10;
        ball.velocity = ball.velocity.normalized * speed;

       
       
        

    }
}
