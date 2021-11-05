using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_background : MonoBehaviour
{

    public float scroll_speed = (float) -0.01;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < (float) -5)
        {
            transform.position = new Vector3(0, 5, 0);
        }
        
        transform.position += new Vector3(0, scroll_speed, 0);
    }
}
