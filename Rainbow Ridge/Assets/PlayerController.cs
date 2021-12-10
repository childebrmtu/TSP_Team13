using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // this does the interfacing with the input system
    private PlayerInput input;
    private Rigidbody2D control;
    // placeholder for now
    public float speedFactor = 1;
    // bounding box vars
    public float upperX;
    public float upperY;
    public float lowerX;
    public float lowerY;

    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 inVector = input.actions["Move"].ReadValue<Vector2>();
        inVector.x *= Time.deltaTime * speedFactor;
        inVector.y *= Time.deltaTime * speedFactor;

        // check for bounds very sloppily
        if (control.position.x >= upperX && inVector.x > 0 || control.position.x <= lowerX && inVector.x < 0)
            inVector.x = 0;
        if (control.position.y >= upperY && inVector.y > 0 || control.position.y <= lowerY && inVector.y < 0)
            inVector.y = 0;
        
        control.velocity = inVector;
    }
}
