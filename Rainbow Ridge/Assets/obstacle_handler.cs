using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_handler : MonoBehaviour
{

    public float scroll_speed = (float)-0.001;
    public float despawn_boundary = (float)-2.0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform)
        {
            child.transform.position += new Vector3(0, scroll_speed, 0);

            if (child.transform.position.y < despawn_boundary)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
