using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_handler : MonoBehaviour
{
    public Environment env;
    public float despawn_boundary = (float)-2.0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (Transform child in transform)
        {
            child.transform.position += new Vector3(0, -env.GetScrollSpeed(), 0);

            if (child.transform.position.y < despawn_boundary)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
