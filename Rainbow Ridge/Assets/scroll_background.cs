using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_background : MonoBehaviour
{
    [SerializeField]
    private Environment env;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y < (float)-1.01)
        {
            transform.position += new Vector3(0, (float)1.01, 0);
        }

        transform.position += new Vector3(0, -env.GetScrollSpeed(), 0);
    }
}
