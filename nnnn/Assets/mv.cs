using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mv : MonoBehaviour
{
   
    public float force = 200f;
    Rigidbody rigidbody;
    //public GameObject v;
    private float speed;
   // public GameObject v2;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        //v = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.position != v2.transform.position)
        // {
            speed = rigidbody.velocity.magnitude;
            
            if (Input.GetKey("up"))
            {
            //rigidbody.drag = 10f;
            rigidbody.AddForce(Vector3.down * force);    
            }
        if (Input.GetKeyUp("up"))
        {
            //this.transform.position = v.transform.position;
            //rigidbody.drag = 100f;
        }
            
       // }
       // else transform.Translate(v);
    }
}
