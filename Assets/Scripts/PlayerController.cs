using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // basic variable defining 
    public float speed;
    // defining the inputs
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // for when you click a key, the computer inputs it
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // movement for the ball
        transform.Translate(Vector3.forward * verticalInput * speed);
        transform.Translate(Vector3.right * horizontalInput * speed);
    }
}
