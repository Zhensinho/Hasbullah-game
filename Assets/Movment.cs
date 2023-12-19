using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    Rigidbody myrigibody;


    // Start is called before the first frame update
    void Start()
    {
        myrigibody = GetComponent<Rigidbody>();
    }



    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            myrigibody.AddForce(new Vector3(30, 0, 0));
        }



        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            myrigibody.AddForce(new Vector3(-30, 0, 0));
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
