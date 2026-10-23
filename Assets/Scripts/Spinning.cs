using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{

    private float rotationSpeed = 0.1F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 1000);
        }

    }
}
