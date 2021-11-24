using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_handler : MonoBehaviour
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
        foreach (Transform child in transform)
        {
            child.transform.position += new Vector3(0, -env.GetScrollSpeed(), 0);

            if (child.transform.position.y < env.GetLowerBound())
            {
                Destroy(child.gameObject);
            }
        }
    }
}
