using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    AudioSource carStart;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        carStart = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {

        //rb.AddForce(Vector3.forward * 1f);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * 3f);
            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            carStart.Play();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * 6f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * 6f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * 6f);
        }
      
    }

}
