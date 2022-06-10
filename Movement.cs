using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float mainThrust = 10f;
    [SerializeField] float ThrustLeft = 10f;
    [SerializeField] float ThrustRight = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        


        ProcessThrust();
        ProcessRotation();


    }
    void ProcessThrust()
    { 
       if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
       
    }

    void ProcessRotation()
    {
        rb.freezeRotation = true;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.back * ThrustLeft * Time.deltaTime);
            Debug.Log("Turning Left");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * ThrustRight * Time.deltaTime);
            Debug.Log("Turning Right");
        }
        rb.freezeRotation = false;
    }
}   


