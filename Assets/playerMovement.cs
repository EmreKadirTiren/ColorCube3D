using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    
    
public class playerMovement : MonoBehaviour
{
    public Rigidbody Rb;

    public float forwardforce = 2000f;

    public float sideforce = 500;

    public float forbackwordfoce = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Adding forwardforce to the game object every frame
        Rb.AddForce(0,0, forwardforce * Time.deltaTime); // forwardfoce * time since last frame was drawn

        if (Input.GetKey("d"))
        {
            Rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            Rb.AddForce(0, 0, -forwardforce *Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            Rb.AddForce(0, 0,  forbackwordfoce* Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
