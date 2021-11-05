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
        control.velocity = inVector;
    }
}
